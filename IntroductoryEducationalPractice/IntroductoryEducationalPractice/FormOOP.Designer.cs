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
            buttonShowObjects = new Button();
            buttonCreateObject = new Button();
            labelIsFolding = new Label();
            labelName = new Label();
            labelCountOfLegs = new Label();
            labelHeight = new Label();
            labelLength = new Label();
            labelWidth = new Label();
            radioButtonIsNotFolding = new RadioButton();
            radioButtonIsFolding = new RadioButton();
            numericUpDownCountOfLegs = new NumericUpDown();
            textBoxLength = new TextBox();
            textBoxHeight = new TextBox();
            textBoxWidth = new TextBox();
            textBoxName = new TextBox();
            listBoxObjects = new ListBox();
            tabTask2 = new TabPage();
            listBoxFigures = new ListBox();
            buttonShowFigure = new Button();
            buttonCreateFilledFigure = new Button();
            buttonCreateFigure = new Button();
            labelFigureHeight = new Label();
            labelFigureWidth = new Label();
            textBoxFigureHeight = new TextBox();
            textBoxFigureWidth = new TextBox();
            pictureBoxFigure = new PictureBox();
            tabTask3 = new TabPage();
            buttonCalculate = new Button();
            labelValue2 = new Label();
            labelValue1 = new Label();
            textBoxResult = new TextBox();
            textBoxValue2 = new TextBox();
            textBoxValue1 = new TextBox();
            tabControl.SuspendLayout();
            tabTask1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountOfLegs).BeginInit();
            tabTask2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFigure).BeginInit();
            tabTask3.SuspendLayout();
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
            tabTask1.Controls.Add(buttonShowObjects);
            tabTask1.Controls.Add(buttonCreateObject);
            tabTask1.Controls.Add(labelIsFolding);
            tabTask1.Controls.Add(labelName);
            tabTask1.Controls.Add(labelCountOfLegs);
            tabTask1.Controls.Add(labelHeight);
            tabTask1.Controls.Add(labelLength);
            tabTask1.Controls.Add(labelWidth);
            tabTask1.Controls.Add(radioButtonIsNotFolding);
            tabTask1.Controls.Add(radioButtonIsFolding);
            tabTask1.Controls.Add(numericUpDownCountOfLegs);
            tabTask1.Controls.Add(textBoxLength);
            tabTask1.Controls.Add(textBoxHeight);
            tabTask1.Controls.Add(textBoxWidth);
            tabTask1.Controls.Add(textBoxName);
            tabTask1.Controls.Add(listBoxObjects);
            tabTask1.Location = new Point(4, 24);
            tabTask1.Name = "tabTask1";
            tabTask1.Padding = new Padding(3);
            tabTask1.Size = new Size(792, 422);
            tabTask1.TabIndex = 0;
            tabTask1.Text = "Задание 1";
            tabTask1.UseVisualStyleBackColor = true;
            // 
            // buttonShowObjects
            // 
            buttonShowObjects.Location = new Point(6, 227);
            buttonShowObjects.Name = "buttonShowObjects";
            buttonShowObjects.Size = new Size(220, 23);
            buttonShowObjects.TabIndex = 15;
            buttonShowObjects.Text = "Вывести";
            buttonShowObjects.UseVisualStyleBackColor = true;
            buttonShowObjects.Click += ButtonShowObjects_Click;
            // 
            // buttonCreateObject
            // 
            buttonCreateObject.Location = new Point(6, 198);
            buttonCreateObject.Name = "buttonCreateObject";
            buttonCreateObject.Size = new Size(220, 23);
            buttonCreateObject.TabIndex = 14;
            buttonCreateObject.Text = "Создать";
            buttonCreateObject.UseVisualStyleBackColor = true;
            buttonCreateObject.Click += ButtonCreateObject_Click;
            // 
            // labelIsFolding
            // 
            labelIsFolding.AutoSize = true;
            labelIsFolding.Location = new Point(6, 148);
            labelIsFolding.Name = "labelIsFolding";
            labelIsFolding.Size = new Size(98, 15);
            labelIsFolding.TabIndex = 13;
            labelIsFolding.Text = "Раскладывается:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 119);
            labelName.Name = "labelName";
            labelName.Size = new Size(62, 15);
            labelName.TabIndex = 12;
            labelName.Text = "Название:";
            // 
            // labelCountOfLegs
            // 
            labelCountOfLegs.AutoSize = true;
            labelCountOfLegs.Location = new Point(6, 90);
            labelCountOfLegs.Name = "labelCountOfLegs";
            labelCountOfLegs.Size = new Size(113, 15);
            labelCountOfLegs.TabIndex = 11;
            labelCountOfLegs.Text = "Количество ножек:";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(6, 61);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(50, 15);
            labelHeight.TabIndex = 10;
            labelHeight.Text = "Высота:";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(6, 32);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(45, 15);
            labelLength.TabIndex = 9;
            labelLength.Text = "Длина:";
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(6, 3);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(55, 15);
            labelWidth.TabIndex = 8;
            labelWidth.Text = "Ширина:";
            // 
            // radioButtonIsNotFolding
            // 
            radioButtonIsNotFolding.AutoSize = true;
            radioButtonIsNotFolding.Location = new Point(126, 173);
            radioButtonIsNotFolding.Name = "radioButtonIsNotFolding";
            radioButtonIsNotFolding.Size = new Size(45, 19);
            radioButtonIsNotFolding.TabIndex = 7;
            radioButtonIsNotFolding.TabStop = true;
            radioButtonIsNotFolding.Text = "Нет";
            radioButtonIsNotFolding.UseVisualStyleBackColor = true;
            // 
            // radioButtonIsFolding
            // 
            radioButtonIsFolding.AutoSize = true;
            radioButtonIsFolding.Location = new Point(126, 148);
            radioButtonIsFolding.Name = "radioButtonIsFolding";
            radioButtonIsFolding.Size = new Size(39, 19);
            radioButtonIsFolding.TabIndex = 6;
            radioButtonIsFolding.TabStop = true;
            radioButtonIsFolding.Text = "Да";
            radioButtonIsFolding.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCountOfLegs
            // 
            numericUpDownCountOfLegs.Location = new Point(126, 90);
            numericUpDownCountOfLegs.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownCountOfLegs.Name = "numericUpDownCountOfLegs";
            numericUpDownCountOfLegs.Size = new Size(100, 23);
            numericUpDownCountOfLegs.TabIndex = 5;
            numericUpDownCountOfLegs.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(126, 32);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 23);
            textBoxLength.TabIndex = 4;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(126, 61);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 23);
            textBoxHeight.TabIndex = 3;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(126, 3);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(126, 119);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // listBoxObjects
            // 
            listBoxObjects.FormattingEnabled = true;
            listBoxObjects.ItemHeight = 15;
            listBoxObjects.Location = new Point(232, 3);
            listBoxObjects.Name = "listBoxObjects";
            listBoxObjects.Size = new Size(552, 244);
            listBoxObjects.TabIndex = 0;
            // 
            // tabTask2
            // 
            tabTask2.Controls.Add(listBoxFigures);
            tabTask2.Controls.Add(buttonShowFigure);
            tabTask2.Controls.Add(buttonCreateFilledFigure);
            tabTask2.Controls.Add(buttonCreateFigure);
            tabTask2.Controls.Add(labelFigureHeight);
            tabTask2.Controls.Add(labelFigureWidth);
            tabTask2.Controls.Add(textBoxFigureHeight);
            tabTask2.Controls.Add(textBoxFigureWidth);
            tabTask2.Controls.Add(pictureBoxFigure);
            tabTask2.Location = new Point(4, 24);
            tabTask2.Name = "tabTask2";
            tabTask2.Padding = new Padding(3);
            tabTask2.Size = new Size(792, 422);
            tabTask2.TabIndex = 1;
            tabTask2.Text = "Задание 2";
            tabTask2.UseVisualStyleBackColor = true;
            // 
            // listBoxFigures
            // 
            listBoxFigures.FormattingEnabled = true;
            listBoxFigures.ItemHeight = 15;
            listBoxFigures.Location = new Point(8, 178);
            listBoxFigures.Name = "listBoxFigures";
            listBoxFigures.Size = new Size(204, 199);
            listBoxFigures.TabIndex = 8;
            // 
            // buttonShowFigure
            // 
            buttonShowFigure.Location = new Point(6, 391);
            buttonShowFigure.Name = "buttonShowFigure";
            buttonShowFigure.Size = new Size(206, 23);
            buttonShowFigure.TabIndex = 7;
            buttonShowFigure.Text = "Вывести";
            buttonShowFigure.UseVisualStyleBackColor = true;
            buttonShowFigure.Click += ButtonShowFigure_Click;
            // 
            // buttonCreateFilledFigure
            // 
            buttonCreateFilledFigure.Location = new Point(114, 103);
            buttonCreateFilledFigure.Name = "buttonCreateFilledFigure";
            buttonCreateFilledFigure.Size = new Size(100, 69);
            buttonCreateFilledFigure.TabIndex = 6;
            buttonCreateFilledFigure.Text = "Создать закрашенный круг";
            buttonCreateFilledFigure.UseVisualStyleBackColor = true;
            buttonCreateFilledFigure.Click += ButtonCreateFilledFigure_Click;
            // 
            // buttonCreateFigure
            // 
            buttonCreateFigure.Location = new Point(8, 103);
            buttonCreateFigure.Name = "buttonCreateFigure";
            buttonCreateFigure.Size = new Size(100, 69);
            buttonCreateFigure.TabIndex = 5;
            buttonCreateFigure.Text = "Создать прямоугольник";
            buttonCreateFigure.UseVisualStyleBackColor = true;
            buttonCreateFigure.Click += ButtonCreateFigure_Click;
            // 
            // labelFigureHeight
            // 
            labelFigureHeight.AutoSize = true;
            labelFigureHeight.Location = new Point(8, 69);
            labelFigureHeight.Name = "labelFigureHeight";
            labelFigureHeight.Size = new Size(50, 15);
            labelFigureHeight.TabIndex = 4;
            labelFigureHeight.Text = "Высота:";
            // 
            // labelFigureWidth
            // 
            labelFigureWidth.AutoSize = true;
            labelFigureWidth.Location = new Point(8, 23);
            labelFigureWidth.Name = "labelFigureWidth";
            labelFigureWidth.Size = new Size(55, 15);
            labelFigureWidth.TabIndex = 3;
            labelFigureWidth.Text = "Ширина:";
            // 
            // textBoxFigureHeight
            // 
            textBoxFigureHeight.Location = new Point(81, 61);
            textBoxFigureHeight.Name = "textBoxFigureHeight";
            textBoxFigureHeight.Size = new Size(133, 23);
            textBoxFigureHeight.TabIndex = 2;
            // 
            // textBoxFigureWidth
            // 
            textBoxFigureWidth.Location = new Point(81, 20);
            textBoxFigureWidth.Name = "textBoxFigureWidth";
            textBoxFigureWidth.Size = new Size(133, 23);
            textBoxFigureWidth.TabIndex = 1;
            // 
            // pictureBoxFigure
            // 
            pictureBoxFigure.Dock = DockStyle.Right;
            pictureBoxFigure.Location = new Point(220, 3);
            pictureBoxFigure.Name = "pictureBoxFigure";
            pictureBoxFigure.Size = new Size(569, 416);
            pictureBoxFigure.TabIndex = 0;
            pictureBoxFigure.TabStop = false;
            // 
            // tabTask3
            // 
            tabTask3.Controls.Add(buttonCalculate);
            tabTask3.Controls.Add(labelValue2);
            tabTask3.Controls.Add(labelValue1);
            tabTask3.Controls.Add(textBoxResult);
            tabTask3.Controls.Add(textBoxValue2);
            tabTask3.Controls.Add(textBoxValue1);
            tabTask3.Location = new Point(4, 24);
            tabTask3.Name = "tabTask3";
            tabTask3.Padding = new Padding(3);
            tabTask3.Size = new Size(792, 422);
            tabTask3.TabIndex = 2;
            tabTask3.Text = "Задание 3";
            tabTask3.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(8, 69);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(171, 23);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Вычислить операцию";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += ButtonCalculate_Click;
            // 
            // labelValue2
            // 
            labelValue2.AutoSize = true;
            labelValue2.Location = new Point(6, 43);
            labelValue2.Name = "labelValue2";
            labelValue2.Size = new Size(67, 15);
            labelValue2.TabIndex = 4;
            labelValue2.Text = "2 значение";
            // 
            // labelValue1
            // 
            labelValue1.AutoSize = true;
            labelValue1.Location = new Point(6, 14);
            labelValue1.Name = "labelValue1";
            labelValue1.Size = new Size(67, 15);
            labelValue1.TabIndex = 3;
            labelValue1.Text = "1 значение";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 98);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(173, 23);
            textBoxResult.TabIndex = 2;
            // 
            // textBoxValue2
            // 
            textBoxValue2.Location = new Point(79, 40);
            textBoxValue2.Name = "textBoxValue2";
            textBoxValue2.Size = new Size(100, 23);
            textBoxValue2.TabIndex = 1;
            // 
            // textBoxValue1
            // 
            textBoxValue1.Location = new Point(79, 11);
            textBoxValue1.Name = "textBoxValue1";
            textBoxValue1.Size = new Size(100, 23);
            textBoxValue1.TabIndex = 0;
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
            tabTask1.ResumeLayout(false);
            tabTask1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountOfLegs).EndInit();
            tabTask2.ResumeLayout(false);
            tabTask2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFigure).EndInit();
            tabTask3.ResumeLayout(false);
            tabTask3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabTask1;
        private TabPage tabTask2;
        private TabPage tabTask3;
        private ListBox listBoxObjects;
        private TextBox textBoxWidth;
        private TextBox textBoxName;
        private TextBox textBoxLength;
        private TextBox textBoxHeight;
        private RadioButton radioButtonIsNotFolding;
        private RadioButton radioButtonIsFolding;
        private NumericUpDown numericUpDownCountOfLegs;
        private Label labelWidth;
        private Label labelIsFolding;
        private Label labelName;
        private Label labelCountOfLegs;
        private Label labelHeight;
        private Label labelLength;
        private Button buttonCreateObject;
        private Button buttonShowObjects;
        private PictureBox pictureBoxFigure;
        private TextBox textBoxFigureWidth;
        private Label labelFigureHeight;
        private Label labelFigureWidth;
        private TextBox textBoxFigureHeight;
        private Button buttonCreateFilledFigure;
        private Button buttonCreateFigure;
        private Button buttonShowFigure;
        private ListBox listBoxFigures;
        private Button buttonCalculate;
        private Label labelValue2;
        private Label labelValue1;
        private TextBox textBoxResult;
        private TextBox textBoxValue2;
        private TextBox textBoxValue1;
    }
}