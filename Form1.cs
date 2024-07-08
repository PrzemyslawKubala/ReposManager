using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFoldersIntoComboBox();
        }

        private string folderPath = @"C:\Users\kubal\source\repos";
        private string output = string.Empty;

        public string RepoPath
            => folderPath + @"\" + comboBoxFolder.SelectedItem.ToString();

        private void LoadFoldersIntoComboBox()
        {
            comboBoxFolder.Items.Clear();
            string[] directories = Directory.GetDirectories(folderPath);

            foreach (string directory in directories)
                comboBoxFolder.Items.Add(Path.GetFileName(directory));
        }

        private async Task ExecuteCommand(string command)
        {
            try
            {
                string combinedCommand = $"cd /d \"{RepoPath}\" && {command}";

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + combinedCommand,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();
                    textBox.Text = "process started";
                    output = await process.StandardOutput.ReadToEndAsync();
                    textBox.Text = output;
                    string error = await process.StandardError.ReadToEndAsync();
                    await process.WaitForExitAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst¹pi³ b³¹d: " + ex.Message);
            }
        }

        private async void comboBoxFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ExecuteCommand("git status");
            branch.Text = GetBranchName();
        }

        private async void fetch_Click(object sender, EventArgs e)
        {
            await ExecuteCommand("git fetch");
            await ExecuteCommand("git status");
        }

        private async void pull_Click(object sender, EventArgs e)
        {
            await ExecuteCommand("git pull");
        }

        private async void clean_Click(object sender, EventArgs e)
        {
            await ExecuteCommand("git clean -dxfe.vs");
        }

        private async void build_Click(object sender, EventArgs e)
        {
            await ExecuteCommand("dotnet build soneta.sln");
        }

        private async void checkout_Click(object sender, EventArgs e)
        {
            await ExecuteCommand($"git checkout {branch.Text}");
        }

        private string GetBranchName()
        {
            string searchPhrase = "On branch ";
            int startIndex = output.IndexOf(searchPhrase);

            if (startIndex != -1)
            {
                startIndex += searchPhrase.Length;
                int endIndex = output.IndexOf('\n', startIndex);

                if (endIndex == -1)
                {
                    endIndex = output.Length;
                }

                return output.Substring(startIndex, endIndex - startIndex).Trim();
            }

            return string.Empty;
        }
    }
}
