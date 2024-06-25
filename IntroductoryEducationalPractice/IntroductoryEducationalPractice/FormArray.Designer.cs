namespace IntroductoryEducationalPractice
{
    partial class FormArray
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
            panelTasks = new Panel();
            buttonTask6 = new Button();
            buttonTask5 = new Button();
            buttonTask4 = new Button();
            buttonTask3 = new Button();
            buttonTask2 = new Button();
            labelTask = new Label();
            buttonTask1 = new Button();
            panelInitialArray = new Panel();
            labelGeneratingValues = new Label();
            labelMaxValue = new Label();
            labelMinValue = new Label();
            labelHeight = new Label();
            labelLength = new Label();
            labelInitialArray = new Label();
            numericUpDownMaxValue = new NumericUpDown();
            numericUpDownMinValue = new NumericUpDown();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownLength = new NumericUpDown();
            labelGenerate = new Label();
            buttonGenerate2DArray = new Button();
            buttonGenerate1DArray = new Button();
            textBoxMassive = new TextBox();
            textBoxOptionalTask = new TextBox();
            panelProcessedArray = new Panel();
            labelSolution = new Label();
            buttonShowSolution = new Button();
            textBoxSolution = new TextBox();
            labelOptionalTask = new Label();
            panelTasks.SuspendLayout();
            panelInitialArray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            panelProcessedArray.SuspendLayout();
            SuspendLayout();
            // 
            // panelTasks
            // 
            panelTasks.Controls.Add(buttonTask6);
            panelTasks.Controls.Add(buttonTask5);
            panelTasks.Controls.Add(buttonTask4);
            panelTasks.Controls.Add(buttonTask3);
            panelTasks.Controls.Add(buttonTask2);
            panelTasks.Controls.Add(labelTask);
            panelTasks.Controls.Add(buttonTask1);
            panelTasks.Dock = DockStyle.Left;
            panelTasks.Location = new Point(0, 0);
            panelTasks.Name = "panelTasks";
            panelTasks.Size = new Size(98, 364);
            panelTasks.TabIndex = 0;
            // 
            // buttonTask6
            // 
            buttonTask6.Location = new Point(3, 290);
            buttonTask6.Name = "buttonTask6";
            buttonTask6.Size = new Size(92, 46);
            buttonTask6.TabIndex = 5;
            buttonTask6.Text = "6";
            buttonTask6.UseVisualStyleBackColor = true;
            buttonTask6.Click += ButtonTask_Click;
            // 
            // buttonTask5
            // 
            buttonTask5.Location = new Point(3, 238);
            buttonTask5.Name = "buttonTask5";
            buttonTask5.Size = new Size(92, 46);
            buttonTask5.TabIndex = 4;
            buttonTask5.Text = "5";
            buttonTask5.UseVisualStyleBackColor = true;
            buttonTask5.Click += ButtonTask_Click;
            // 
            // buttonTask4
            // 
            buttonTask4.Location = new Point(3, 186);
            buttonTask4.Name = "buttonTask4";
            buttonTask4.Size = new Size(92, 46);
            buttonTask4.TabIndex = 3;
            buttonTask4.Text = "4";
            buttonTask4.UseVisualStyleBackColor = true;
            buttonTask4.Click += ButtonTask_Click;
            // 
            // buttonTask3
            // 
            buttonTask3.Location = new Point(3, 134);
            buttonTask3.Name = "buttonTask3";
            buttonTask3.Size = new Size(92, 46);
            buttonTask3.TabIndex = 2;
            buttonTask3.Text = "3";
            buttonTask3.UseVisualStyleBackColor = true;
            buttonTask3.Click += ButtonTask_Click;
            // 
            // buttonTask2
            // 
            buttonTask2.Location = new Point(3, 82);
            buttonTask2.Name = "buttonTask2";
            buttonTask2.Size = new Size(92, 46);
            buttonTask2.TabIndex = 1;
            buttonTask2.Text = "2";
            buttonTask2.UseVisualStyleBackColor = true;
            buttonTask2.Click += ButtonTask_Click;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(3, 9);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(55, 15);
            labelTask.TabIndex = 2;
            labelTask.Text = "Задание:";
            // 
            // buttonTask1
            // 
            buttonTask1.Location = new Point(3, 30);
            buttonTask1.Name = "buttonTask1";
            buttonTask1.Size = new Size(92, 46);
            buttonTask1.TabIndex = 0;
            buttonTask1.Text = "1";
            buttonTask1.UseVisualStyleBackColor = true;
            buttonTask1.Click += ButtonTask_Click;
            // 
            // panelInitialArray
            // 
            panelInitialArray.Controls.Add(labelGeneratingValues);
            panelInitialArray.Controls.Add(labelMaxValue);
            panelInitialArray.Controls.Add(labelMinValue);
            panelInitialArray.Controls.Add(labelHeight);
            panelInitialArray.Controls.Add(labelLength);
            panelInitialArray.Controls.Add(labelInitialArray);
            panelInitialArray.Controls.Add(numericUpDownMaxValue);
            panelInitialArray.Controls.Add(numericUpDownMinValue);
            panelInitialArray.Controls.Add(numericUpDownHeight);
            panelInitialArray.Controls.Add(numericUpDownLength);
            panelInitialArray.Controls.Add(labelGenerate);
            panelInitialArray.Controls.Add(buttonGenerate2DArray);
            panelInitialArray.Controls.Add(buttonGenerate1DArray);
            panelInitialArray.Controls.Add(textBoxMassive);
            panelInitialArray.Dock = DockStyle.Top;
            panelInitialArray.Location = new Point(98, 0);
            panelInitialArray.Name = "panelInitialArray";
            panelInitialArray.Size = new Size(578, 185);
            panelInitialArray.TabIndex = 1;
            // 
            // labelGeneratingValues
            // 
            labelGeneratingValues.AutoSize = true;
            labelGeneratingValues.Location = new Point(289, 61);
            labelGeneratingValues.Name = "labelGeneratingValues";
            labelGeneratingValues.Size = new Size(146, 15);
            labelGeneratingValues.TabIndex = 12;
            labelGeneratingValues.Text = "Генерируемые значения:";
            // 
            // labelMaxValue
            // 
            labelMaxValue.AutoSize = true;
            labelMaxValue.Location = new Point(432, 82);
            labelMaxValue.Name = "labelMaxValue";
            labelMaxValue.Size = new Size(103, 15);
            labelMaxValue.TabIndex = 11;
            labelMaxValue.Text = "Верхняя граница:";
            // 
            // labelMinValue
            // 
            labelMinValue.AutoSize = true;
            labelMinValue.Location = new Point(289, 82);
            labelMinValue.Name = "labelMinValue";
            labelMinValue.Size = new Size(102, 15);
            labelMinValue.TabIndex = 10;
            labelMinValue.Text = "Нижняя граница:";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(432, 9);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(50, 15);
            labelHeight.TabIndex = 9;
            labelHeight.Text = "Высота:";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(289, 9);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(45, 15);
            labelLength.TabIndex = 8;
            labelLength.Text = "Длина:";
            // 
            // labelInitialArray
            // 
            labelInitialArray.AutoSize = true;
            labelInitialArray.Location = new Point(6, 9);
            labelInitialArray.Name = "labelInitialArray";
            labelInitialArray.Size = new Size(117, 15);
            labelInitialArray.TabIndex = 3;
            labelInitialArray.Text = "Начальный массив:";
            // 
            // numericUpDownMaxValue
            // 
            numericUpDownMaxValue.Location = new Point(432, 105);
            numericUpDownMaxValue.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownMaxValue.Name = "numericUpDownMaxValue";
            numericUpDownMaxValue.Size = new Size(137, 23);
            numericUpDownMaxValue.TabIndex = 7;
            numericUpDownMaxValue.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numericUpDownMinValue
            // 
            numericUpDownMinValue.Location = new Point(289, 105);
            numericUpDownMinValue.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownMinValue.Name = "numericUpDownMinValue";
            numericUpDownMinValue.Size = new Size(137, 23);
            numericUpDownMinValue.TabIndex = 6;
            numericUpDownMinValue.Value = new decimal(new int[] { 50, 0, 0, int.MinValue });
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(432, 31);
            numericUpDownHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(137, 23);
            numericUpDownHeight.TabIndex = 5;
            numericUpDownHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.Location = new Point(289, 30);
            numericUpDownLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(137, 23);
            numericUpDownLength.TabIndex = 4;
            numericUpDownLength.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelGenerate
            // 
            labelGenerate.AutoSize = true;
            labelGenerate.Location = new Point(162, 9);
            labelGenerate.Name = "labelGenerate";
            labelGenerate.Size = new Size(93, 15);
            labelGenerate.TabIndex = 3;
            labelGenerate.Text = "Сгенерировать:";
            // 
            // buttonGenerate2DArray
            // 
            buttonGenerate2DArray.Location = new Point(162, 82);
            buttonGenerate2DArray.Name = "buttonGenerate2DArray";
            buttonGenerate2DArray.Size = new Size(121, 46);
            buttonGenerate2DArray.TabIndex = 2;
            buttonGenerate2DArray.Text = "Двумерный массив";
            buttonGenerate2DArray.UseVisualStyleBackColor = true;
            buttonGenerate2DArray.Click += ButtonGenerate2DArray_Click;
            // 
            // buttonGenerate1DArray
            // 
            buttonGenerate1DArray.Location = new Point(162, 30);
            buttonGenerate1DArray.Name = "buttonGenerate1DArray";
            buttonGenerate1DArray.Size = new Size(121, 46);
            buttonGenerate1DArray.TabIndex = 1;
            buttonGenerate1DArray.Text = "Одномерный массив";
            buttonGenerate1DArray.UseVisualStyleBackColor = true;
            buttonGenerate1DArray.Click += ButtonGenerate1DArray_Click;
            // 
            // textBoxMassive
            // 
            textBoxMassive.Location = new Point(6, 30);
            textBoxMassive.Multiline = true;
            textBoxMassive.Name = "textBoxMassive";
            textBoxMassive.Size = new Size(150, 150);
            textBoxMassive.TabIndex = 0;
            // 
            // textBoxOptionalTask
            // 
            textBoxOptionalTask.Location = new Point(6, 21);
            textBoxOptionalTask.Multiline = true;
            textBoxOptionalTask.Name = "textBoxOptionalTask";
            textBoxOptionalTask.ReadOnly = true;
            textBoxOptionalTask.Size = new Size(200, 150);
            textBoxOptionalTask.TabIndex = 1;
            // 
            // panelProcessedArray
            // 
            panelProcessedArray.Controls.Add(textBoxOptionalTask);
            panelProcessedArray.Controls.Add(labelSolution);
            panelProcessedArray.Controls.Add(buttonShowSolution);
            panelProcessedArray.Controls.Add(textBoxSolution);
            panelProcessedArray.Controls.Add(labelOptionalTask);
            panelProcessedArray.Dock = DockStyle.Bottom;
            panelProcessedArray.Location = new Point(98, 183);
            panelProcessedArray.Name = "panelProcessedArray";
            panelProcessedArray.Size = new Size(578, 181);
            panelProcessedArray.TabIndex = 7;
            // 
            // labelSolution
            // 
            labelSolution.AutoSize = true;
            labelSolution.Location = new Point(212, 3);
            labelSolution.Name = "labelSolution";
            labelSolution.Size = new Size(106, 15);
            labelSolution.TabIndex = 6;
            labelSolution.Text = "Решение задания:";
            // 
            // buttonShowSolution
            // 
            buttonShowSolution.Location = new Point(373, 78);
            buttonShowSolution.Name = "buttonShowSolution";
            buttonShowSolution.Size = new Size(193, 23);
            buttonShowSolution.TabIndex = 2;
            buttonShowSolution.Text = "Вывести решение";
            buttonShowSolution.UseVisualStyleBackColor = true;
            buttonShowSolution.Click += ButtonShowSolution_Click;
            // 
            // textBoxSolution
            // 
            textBoxSolution.Location = new Point(212, 21);
            textBoxSolution.Multiline = true;
            textBoxSolution.Name = "textBoxSolution";
            textBoxSolution.ReadOnly = true;
            textBoxSolution.Size = new Size(150, 150);
            textBoxSolution.TabIndex = 1;
            // 
            // labelOptionalTask
            // 
            labelOptionalTask.AutoSize = true;
            labelOptionalTask.Location = new Point(6, 3);
            labelOptionalTask.Name = "labelOptionalTask";
            labelOptionalTask.Size = new Size(125, 15);
            labelOptionalTask.TabIndex = 4;
            labelOptionalTask.Text = "Задание по варианту:";
            // 
            // FormArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 364);
            Controls.Add(panelProcessedArray);
            Controls.Add(panelInitialArray);
            Controls.Add(panelTasks);
            Name = "FormArray";
            Text = "Form";
            panelTasks.ResumeLayout(false);
            panelTasks.PerformLayout();
            panelInitialArray.ResumeLayout(false);
            panelInitialArray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            panelProcessedArray.ResumeLayout(false);
            panelProcessedArray.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTasks;
        private Button buttonTask6;
        private Button buttonTask5;
        private Button buttonTask4;
        private Button buttonTask3;
        private Button buttonTask2;
        private Button buttonTask1;
        private Panel panelInitialArray;
        private Button buttonGenerate2DArray;
        private Button buttonGenerate1DArray;
        private TextBox textBoxMassive;
        private Label labelGenerate;
        private TextBox textBoxOptionalTask;
        private Panel panelProcessedArray;
        private TextBox textBoxSolution;
        private NumericUpDown numericUpDownLength;
        private Label labelHeight;
        private Label labelLength;
        private NumericUpDown numericUpDownMaxValue;
        private NumericUpDown numericUpDownMinValue;
        private NumericUpDown numericUpDownHeight;
        private Label labelMaxValue;
        private Label labelMinValue;
        private Button buttonShowSolution;
        private Label labelInitialArray;
        private Label labelTask;
        private Label labelSolution;
        private Label labelOptionalTask;
        private Label labelGeneratingValues;
    }
}