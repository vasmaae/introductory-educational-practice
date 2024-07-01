namespace IntroductoryEducationalPractice
{
    partial class FormLogging
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
            textBoxXValue = new TextBox();
            textBoxSumS = new TextBox();
            textBoxFuncY = new TextBox();
            buttonCalculate = new Button();
            labelXValue = new Label();
            labelSumS = new Label();
            labelFuncY = new Label();
            SuspendLayout();
            // 
            // textBoxXValue
            // 
            textBoxXValue.Location = new Point(12, 27);
            textBoxXValue.Name = "textBoxXValue";
            textBoxXValue.Size = new Size(100, 23);
            textBoxXValue.TabIndex = 0;
            // 
            // textBoxSumS
            // 
            textBoxSumS.Location = new Point(12, 100);
            textBoxSumS.Name = "textBoxSumS";
            textBoxSumS.ReadOnly = true;
            textBoxSumS.Size = new Size(100, 23);
            textBoxSumS.TabIndex = 1;
            // 
            // textBoxFuncY
            // 
            textBoxFuncY.Location = new Point(118, 100);
            textBoxFuncY.Name = "textBoxFuncY";
            textBoxFuncY.ReadOnly = true;
            textBoxFuncY.Size = new Size(100, 23);
            textBoxFuncY.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(12, 56);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 23);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Рассчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += ButtonCalculate_Click;
            // 
            // labelXValue
            // 
            labelXValue.AutoSize = true;
            labelXValue.Location = new Point(12, 9);
            labelXValue.Name = "labelXValue";
            labelXValue.Size = new Size(17, 15);
            labelXValue.TabIndex = 4;
            labelXValue.Text = "X:";
            // 
            // labelSumS
            // 
            labelSumS.AutoSize = true;
            labelSumS.Location = new Point(12, 82);
            labelSumS.Name = "labelSumS";
            labelSumS.Size = new Size(57, 15);
            labelSumS.TabIndex = 5;
            labelSumS.Text = "Сумма S:";
            // 
            // labelFuncY
            // 
            labelFuncY.AutoSize = true;
            labelFuncY.Location = new Point(118, 82);
            labelFuncY.Name = "labelFuncY";
            labelFuncY.Size = new Size(68, 15);
            labelFuncY.TabIndex = 6;
            labelFuncY.Text = "Функция Y:";
            // 
            // FormLogging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelFuncY);
            Controls.Add(labelSumS);
            Controls.Add(labelXValue);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxFuncY);
            Controls.Add(textBoxSumS);
            Controls.Add(textBoxXValue);
            Name = "FormLogging";
            Text = "FormLogging";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxXValue;
        private TextBox textBoxSumS;
        private TextBox textBoxFuncY;
        private Button buttonCalculate;
        private Label labelXValue;
        private Label labelSumS;
        private Label labelFuncY;
    }
}