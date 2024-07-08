namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxFolder = new ComboBox();
            textBox = new RichTextBox();
            fetch = new Button();
            pull = new Button();
            clean = new Button();
            build = new Button();
            branch = new TextBox();
            checkout = new Button();
            SuspendLayout();
            // 
            // comboBoxFolder
            // 
            comboBoxFolder.FormattingEnabled = true;
            comboBoxFolder.Location = new Point(139, 13);
            comboBoxFolder.Name = "comboBoxFolder";
            comboBoxFolder.Size = new Size(216, 23);
            comboBoxFolder.TabIndex = 1;
            comboBoxFolder.SelectedIndexChanged += comboBoxFolder_SelectedIndexChanged;
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(139, 42);
            textBox.Name = "textBox";
            textBox.Size = new Size(649, 396);
            textBox.TabIndex = 2;
            textBox.Text = "";
            // 
            // fetch
            // 
            fetch.Location = new Point(12, 12);
            fetch.Name = "fetch";
            fetch.Size = new Size(121, 23);
            fetch.TabIndex = 3;
            fetch.Text = "Fetch";
            fetch.UseVisualStyleBackColor = true;
            fetch.Click += fetch_Click;
            // 
            // pull
            // 
            pull.Location = new Point(12, 41);
            pull.Name = "pull";
            pull.Size = new Size(121, 23);
            pull.TabIndex = 4;
            pull.Text = "Pull";
            pull.UseVisualStyleBackColor = true;
            pull.Click += pull_Click;
            // 
            // clean
            // 
            clean.Location = new Point(12, 70);
            clean.Name = "clean";
            clean.Size = new Size(121, 23);
            clean.TabIndex = 5;
            clean.Text = "Clean";
            clean.UseVisualStyleBackColor = true;
            clean.Click += clean_Click;
            // 
            // build
            // 
            build.Location = new Point(12, 99);
            build.Name = "build";
            build.Size = new Size(121, 23);
            build.TabIndex = 6;
            build.Text = "Build";
            build.UseVisualStyleBackColor = true;
            build.Click += build_Click;
            // 
            // branch
            // 
            branch.Location = new Point(361, 13);
            branch.Name = "branch";
            branch.Size = new Size(300, 23);
            branch.TabIndex = 7;
            // 
            // checkout
            // 
            checkout.Location = new Point(667, 13);
            checkout.Name = "checkout";
            checkout.Size = new Size(121, 23);
            checkout.TabIndex = 8;
            checkout.Text = "Checkout";
            checkout.UseVisualStyleBackColor = true;
            checkout.Click += checkout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(checkout);
            Controls.Add(branch);
            Controls.Add(build);
            Controls.Add(clean);
            Controls.Add(pull);
            Controls.Add(fetch);
            Controls.Add(textBox);
            Controls.Add(comboBoxFolder);
            Name = "Form1";
            ShowIcon = false;
            Text = "GIT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxFolder;
        private RichTextBox textBox;
        private Button fetch;
        private Button pull;
        private Button clean;
        private Button build;
        private TextBox branch;
        private Button checkout;
    }
}
