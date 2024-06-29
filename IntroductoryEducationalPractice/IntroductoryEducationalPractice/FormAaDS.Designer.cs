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
            buttonDelete = new Button();
            textBoxADTValues = new TextBox();
            buttonShow = new Button();
            buttonAdd = new Button();
            textBoxADTDescription = new TextBox();
            panelSort = new Panel();
            buttonNextState = new Button();
            buttonPrevState = new Button();
            textBoxState = new TextBox();
            buttonSortArray = new Button();
            buttonGenerateArray = new Button();
            textBoxSortedArray = new TextBox();
            textBoxSourceArray = new TextBox();
            textBoxSortAlgorithmDescription = new TextBox();
            panel3 = new Panel();
            buttonShowSubsequence = new Button();
            textBoxLongestIncreasingSubsequence = new TextBox();
            textBoxSource = new TextBox();
            textBoxAlgorithmDescription = new TextBox();
            textBox1 = new TextBox();
            panelADT.SuspendLayout();
            panelSort.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelADT
            // 
            panelADT.Controls.Add(textBox1);
            panelADT.Controls.Add(buttonDelete);
            panelADT.Controls.Add(textBoxADTValues);
            panelADT.Controls.Add(buttonShow);
            panelADT.Controls.Add(buttonAdd);
            panelADT.Controls.Add(textBoxADTDescription);
            panelADT.Dock = DockStyle.Left;
            panelADT.Location = new Point(0, 0);
            panelADT.Name = "panelADT";
            panelADT.Size = new Size(183, 450);
            panelADT.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(0, 239);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(177, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
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
            buttonShow.Click += ButtonShow_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 137);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(177, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // textBoxADTDescription
            // 
            textBoxADTDescription.Dock = DockStyle.Top;
            textBoxADTDescription.Location = new Point(0, 0);
            textBoxADTDescription.Multiline = true;
            textBoxADTDescription.Name = "textBoxADTDescription";
            textBoxADTDescription.ReadOnly = true;
            textBoxADTDescription.Size = new Size(183, 131);
            textBoxADTDescription.TabIndex = 0;
            // 
            // panelSort
            // 
            panelSort.Controls.Add(buttonNextState);
            panelSort.Controls.Add(buttonPrevState);
            panelSort.Controls.Add(textBoxState);
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
            // buttonNextState
            // 
            buttonNextState.Location = new Point(3, 314);
            buttonNextState.Name = "buttonNextState";
            buttonNextState.Size = new Size(108, 23);
            buttonNextState.TabIndex = 7;
            buttonNextState.Text = "Вперёд";
            buttonNextState.UseVisualStyleBackColor = true;
            buttonNextState.Click += ButtonNextState_Click;
            // 
            // buttonPrevState
            // 
            buttonPrevState.Location = new Point(3, 291);
            buttonPrevState.Name = "buttonPrevState";
            buttonPrevState.Size = new Size(108, 23);
            buttonPrevState.TabIndex = 6;
            buttonPrevState.Text = "Назад";
            buttonPrevState.UseVisualStyleBackColor = true;
            buttonPrevState.Click += ButtonPrevState_Click;
            // 
            // textBoxState
            // 
            textBoxState.Location = new Point(117, 291);
            textBoxState.Multiline = true;
            textBoxState.Name = "textBoxState";
            textBoxState.ReadOnly = true;
            textBoxState.Size = new Size(184, 46);
            textBoxState.TabIndex = 5;
            // 
            // buttonSortArray
            // 
            buttonSortArray.Location = new Point(3, 239);
            buttonSortArray.Name = "buttonSortArray";
            buttonSortArray.Size = new Size(108, 46);
            buttonSortArray.TabIndex = 4;
            buttonSortArray.Text = "Сортировать массив";
            buttonSortArray.UseVisualStyleBackColor = true;
            buttonSortArray.Click += ButtonSortArray_Click;
            // 
            // buttonGenerateArray
            // 
            buttonGenerateArray.Location = new Point(6, 137);
            buttonGenerateArray.Name = "buttonGenerateArray";
            buttonGenerateArray.Size = new Size(108, 46);
            buttonGenerateArray.TabIndex = 3;
            buttonGenerateArray.Text = "Генерировать массив";
            buttonGenerateArray.UseVisualStyleBackColor = true;
            buttonGenerateArray.Click += ButtonGenerateArray_Click;
            // 
            // textBoxSortedArray
            // 
            textBoxSortedArray.Location = new Point(117, 239);
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
            panel3.Controls.Add(buttonShowSubsequence);
            panel3.Controls.Add(textBoxLongestIncreasingSubsequence);
            panel3.Controls.Add(textBoxSource);
            panel3.Controls.Add(textBoxAlgorithmDescription);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(490, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 450);
            panel3.TabIndex = 1;
            // 
            // buttonShowSubsequence
            // 
            buttonShowSubsequence.Location = new Point(6, 242);
            buttonShowSubsequence.Name = "buttonShowSubsequence";
            buttonShowSubsequence.Size = new Size(184, 23);
            buttonShowSubsequence.TabIndex = 4;
            buttonShowSubsequence.Text = "Показать";
            buttonShowSubsequence.UseVisualStyleBackColor = true;
            buttonShowSubsequence.Click += ButtonShowMinDistance_Click;
            // 
            // textBoxLongestIncreasingSubsequence
            // 
            textBoxLongestIncreasingSubsequence.Location = new Point(6, 190);
            textBoxLongestIncreasingSubsequence.Multiline = true;
            textBoxLongestIncreasingSubsequence.Name = "textBoxLongestIncreasingSubsequence";
            textBoxLongestIncreasingSubsequence.ReadOnly = true;
            textBoxLongestIncreasingSubsequence.Size = new Size(184, 46);
            textBoxLongestIncreasingSubsequence.TabIndex = 3;
            // 
            // textBoxSource
            // 
            textBoxSource.Location = new Point(6, 138);
            textBoxSource.Multiline = true;
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(184, 46);
            textBoxSource.TabIndex = 2;
            // 
            // textBoxAlgorithmDescription
            // 
            textBoxAlgorithmDescription.Dock = DockStyle.Top;
            textBoxAlgorithmDescription.Location = new Point(0, 0);
            textBoxAlgorithmDescription.Multiline = true;
            textBoxAlgorithmDescription.Name = "textBoxAlgorithmDescription";
            textBoxAlgorithmDescription.ReadOnly = true;
            textBoxAlgorithmDescription.Size = new Size(193, 131);
            textBoxAlgorithmDescription.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 268);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 6;
            // 
            // FormAaDS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 450);
            Controls.Add(panel3);
            Controls.Add(panelSort);
            Controls.Add(panelADT);
            Name = "FormAaDS";
            Text = "FormAaDS";
            panelADT.ResumeLayout(false);
            panelADT.PerformLayout();
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
        private TextBox textBoxADTDescription;
        private Panel panelSort;
        private Panel panel3;
        private TextBox textBoxADTValues;
        private TextBox textBoxSortAlgorithmDescription;
        private TextBox textBoxSortedArray;
        private TextBox textBoxSourceArray;
        private Button buttonGenerateArray;
        private TextBox textBoxState;
        private Button buttonSortArray;
        private TextBox textBoxAlgorithmDescription;
        private Button buttonNextState;
        private Button buttonPrevState;
        private Button buttonShowSubsequence;
        private TextBox textBoxLongestIncreasingSubsequence;
        private TextBox textBoxSource;
        private TextBox textBox1;
    }
}