namespace IntroductoryEducationalPractice
{
    partial class FormAaDS
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
            panelADT = new Panel();
            numericUpDownIndexOfDeleting = new NumericUpDown();
            buttonDelete = new Button();
            textBoxADTValues = new TextBox();
            buttonShow = new Button();
            buttonAdd = new Button();
            textBoxDescription1 = new TextBox();
            panelSort = new Panel();
            buttonGenerateArray = new Button();
            textBoxSortedArray = new TextBox();
            textBoxSourceArray = new TextBox();
            textBoxSortAlgorithmDescription = new TextBox();
            panel3 = new Panel();
            buttonSortArray = new Button();
            textBox3 = new TextBox();
            textBoxAlgorithmDescription = new TextBox();
            panelADT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIndexOfDeleting).BeginInit();
            panelSort.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelADT
            // 
            panelADT.Controls.Add(numericUpDownIndexOfDeleting);
            panelADT.Controls.Add(buttonDelete);
            panelADT.Controls.Add(textBoxADTValues);
            panelADT.Controls.Add(buttonShow);
            panelADT.Controls.Add(buttonAdd);
            panelADT.Controls.Add(textBoxDescription1);
            panelADT.Dock = DockStyle.Left;
            panelADT.Location = new Point(0, 0);
            panelADT.Name = "panelADT";
            panelADT.Size = new Size(183, 450);
            panelADT.TabIndex = 0;
            // 
            // numericUpDownIndexOfDeleting
            // 
            numericUpDownIndexOfDeleting.Location = new Point(3, 227);
            numericUpDownIndexOfDeleting.Name = "numericUpDownIndexOfDeleting";
            numericUpDownIndexOfDeleting.Size = new Size(174, 23);
            numericUpDownIndexOfDeleting.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(3, 198);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(177, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxADTValues
            // 
            textBoxADTValues.Dock = DockStyle.Bottom;
            textBoxADTValues.Location = new Point(0, 342);
            textBoxADTValues.Multiline = true;
            textBoxADTValues.Name = "textBoxADTValues";
            textBoxADTValues.ReadOnly = true;
            textBoxADTValues.Size = new Size(183, 108);
            textBoxADTValues.TabIndex = 5;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(3, 313);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(177, 23);
            buttonShow.TabIndex = 3;
            buttonShow.Text = "Вывести";
            buttonShow.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 137);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(177, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription1
            // 
            textBoxDescription1.Dock = DockStyle.Top;
            textBoxDescription1.Location = new Point(0, 0);
            textBoxDescription1.Multiline = true;
            textBoxDescription1.Name = "textBoxDescription1";
            textBoxDescription1.ReadOnly = true;
            textBoxDescription1.Size = new Size(183, 131);
            textBoxDescription1.TabIndex = 0;
            // 
            // panelSort
            // 
            panelSort.Controls.Add(textBox3);
            panelSort.Controls.Add(buttonSortArray);
            panelSort.Controls.Add(buttonGenerateArray);
            panelSort.Controls.Add(textBoxSortedArray);
            panelSort.Controls.Add(textBoxSourceArray);
            panelSort.Controls.Add(textBoxSortAlgorithmDescription);
            panelSort.Dock = DockStyle.Left;
            panelSort.Location = new Point(183, 0);
            panelSort.Name = "panelSort";
            panelSort.Size = new Size(307, 450);
            panelSort.TabIndex = 1;
            // 
            // buttonGenerateArray
            // 
            buttonGenerateArray.Location = new Point(6, 137);
            buttonGenerateArray.Name = "buttonGenerateArray";
            buttonGenerateArray.Size = new Size(108, 46);
            buttonGenerateArray.TabIndex = 3;
            buttonGenerateArray.Text = "Генерировать массив";
            buttonGenerateArray.UseVisualStyleBackColor = true;
            // 
            // textBoxSortedArray
            // 
            textBoxSortedArray.Location = new Point(120, 189);
            textBoxSortedArray.Multiline = true;
            textBoxSortedArray.Name = "textBoxSortedArray";
            textBoxSortedArray.ReadOnly = true;
            textBoxSortedArray.Size = new Size(184, 46);
            textBoxSortedArray.TabIndex = 2;
            // 
            // textBoxSourceArray
            // 
            textBoxSourceArray.Location = new Point(120, 137);
            textBoxSourceArray.Multiline = true;
            textBoxSourceArray.Name = "textBoxSourceArray";
            textBoxSourceArray.Size = new Size(184, 46);
            textBoxSourceArray.TabIndex = 1;
            // 
            // textBoxSortAlgorithmDescription
            // 
            textBoxSortAlgorithmDescription.Dock = DockStyle.Top;
            textBoxSortAlgorithmDescription.Location = new Point(0, 0);
            textBoxSortAlgorithmDescription.Multiline = true;
            textBoxSortAlgorithmDescription.Name = "textBoxSortAlgorithmDescription";
            textBoxSortAlgorithmDescription.ReadOnly = true;
            textBoxSortAlgorithmDescription.Size = new Size(307, 131);
            textBoxSortAlgorithmDescription.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxAlgorithmDescription);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(490, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 450);
            panel3.TabIndex = 1;
            // 
            // buttonSortArray
            // 
            buttonSortArray.Location = new Point(6, 189);
            buttonSortArray.Name = "buttonSortArray";
            buttonSortArray.Size = new Size(108, 46);
            buttonSortArray.TabIndex = 4;
            buttonSortArray.Text = "Сортировать массив";
            buttonSortArray.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 241);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(184, 46);
            textBox3.TabIndex = 5;
            // 
            // textBoxAlgorithmDescription
            // 
            textBoxAlgorithmDescription.Dock = DockStyle.Top;
            textBoxAlgorithmDescription.Location = new Point(0, 0);
            textBoxAlgorithmDescription.Multiline = true;
            textBoxAlgorithmDescription.Name = "textBoxAlgorithmDescription";
            textBoxAlgorithmDescription.ReadOnly = true;
            textBoxAlgorithmDescription.Size = new Size(310, 131);
            textBoxAlgorithmDescription.TabIndex = 1;
            // 
            // FormAaDS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panelSort);
            Controls.Add(panelADT);
            Name = "FormAaDS";
            Text = "FormAaDS";
            panelADT.ResumeLayout(false);
            panelADT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIndexOfDeleting).EndInit();
            panelSort.ResumeLayout(false);
            panelSort.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelADT;
        private Button buttonShow;
        private Button buttonDelete;
        private Button buttonAdd;
        private TextBox textBoxDescription1;
        private Panel panelSort;
        private Panel panel3;
        private TextBox textBoxADTValues;
        private NumericUpDown numericUpDownIndexOfDeleting;
        private TextBox textBoxSortAlgorithmDescription;
        private TextBox textBoxSortedArray;
        private TextBox textBoxSourceArray;
        private Button buttonGenerateArray;
        private TextBox textBox3;
        private Button buttonSortArray;
        private TextBox textBoxAlgorithmDescription;
    }
}