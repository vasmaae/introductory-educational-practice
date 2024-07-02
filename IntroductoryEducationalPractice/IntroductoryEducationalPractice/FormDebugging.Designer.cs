namespace IntroductoryEducationalPractice
{
    partial class FormDebugging
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
            dataGridView = new DataGridView();
            ColumnVarX = new DataGridViewTextBoxColumn();
            ColumnFuncY = new DataGridViewTextBoxColumn();
            ColumnSLag = new DataGridViewTextBoxColumn();
            ColumnUpperNumber = new DataGridViewTextBoxColumn();
            ColumnSumS = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
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
            textBoxFuncY.Location = new Point(12, 144);
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
            labelFuncY.Location = new Point(12, 126);
            labelFuncY.Name = "labelFuncY";
            labelFuncY.Size = new Size(68, 15);
            labelFuncY.TabIndex = 6;
            labelFuncY.Text = "Функция Y:";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnVarX, ColumnFuncY, ColumnSLag, ColumnUpperNumber, ColumnSumS });
            dataGridView.Dock = DockStyle.Right;
            dataGridView.Location = new Point(118, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(682, 450);
            dataGridView.TabIndex = 7;
            // 
            // ColumnVarX
            // 
            ColumnVarX.HeaderText = "X";
            ColumnVarX.Name = "ColumnVarX";
            // 
            // ColumnFuncY
            // 
            ColumnFuncY.HeaderText = "Y";
            ColumnFuncY.Name = "ColumnFuncY";
            // 
            // ColumnSLag
            // 
            ColumnSLag.HeaderText = "Слагаемое";
            ColumnSLag.Name = "ColumnSLag";
            // 
            // ColumnUpperNumber
            // 
            ColumnUpperNumber.HeaderText = "Верхнее число (2, 5, 10, ...)";
            ColumnUpperNumber.Name = "ColumnUpperNumber";
            // 
            // ColumnSumS
            // 
            ColumnSumS.HeaderText = "S";
            ColumnSumS.Name = "ColumnSumS";
            // 
            // FormDebugging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(labelFuncY);
            Controls.Add(labelSumS);
            Controls.Add(labelXValue);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxFuncY);
            Controls.Add(textBoxSumS);
            Controls.Add(textBoxXValue);
            Name = "FormDebugging";
            Text = "FormLogging";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
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
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ColumnVarX;
        private DataGridViewTextBoxColumn ColumnFuncY;
        private DataGridViewTextBoxColumn ColumnSLag;
        private DataGridViewTextBoxColumn ColumnUpperNumber;
        private DataGridViewTextBoxColumn ColumnSumS;
    }
}