namespace IntroductoryEducationalPractice
{
    partial class FormOOP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabTask1 = new TabPage();
            tabTask2 = new TabPage();
            tabTask3 = new TabPage();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabTask1);
            tabControl.Controls.Add(tabTask2);
            tabControl.Controls.Add(tabTask3);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // tabTask1
            // 
            tabTask1.Location = new Point(4, 24);
            tabTask1.Name = "tabTask1";
            tabTask1.Padding = new Padding(3);
            tabTask1.Size = new Size(792, 422);
            tabTask1.TabIndex = 0;
            tabTask1.Text = "Задание 1";
            tabTask1.UseVisualStyleBackColor = true;
            // 
            // tabTask2
            // 
            tabTask2.Location = new Point(4, 24);
            tabTask2.Name = "tabTask2";
            tabTask2.Padding = new Padding(3);
            tabTask2.Size = new Size(792, 422);
            tabTask2.TabIndex = 1;
            tabTask2.Text = "Задание 2";
            tabTask2.UseVisualStyleBackColor = true;
            // 
            // tabTask3
            // 
            tabTask3.Location = new Point(4, 24);
            tabTask3.Name = "tabTask3";
            tabTask3.Padding = new Padding(3);
            tabTask3.Size = new Size(792, 422);
            tabTask3.TabIndex = 2;
            tabTask3.Text = "Задание 3";
            tabTask3.UseVisualStyleBackColor = true;
            // 
            // FormOOP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "FormOOP";
            Text = "FormOOP";
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabTask1;
        private TabPage tabTask2;
        private TabPage tabTask3;
    }
}