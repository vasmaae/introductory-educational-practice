namespace IntroductoryEducationalPractice
{
    partial class FormTraycing
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
            dataGridView = new DataGridView();
            buttonCalculate = new Button();
            textBoxStartYear = new TextBox();
            labelStartYear = new Label();
            textBoxStartPopulation = new TextBox();
            textBoxMortalityRate = new TextBox();
            textBoxrequiredPopulationIncrease = new TextBox();
            textBoxGrowthPercentage = new TextBox();
            labelStartPopulation = new Label();
            labelGrowthPercentage = new Label();
            labelMortalityRate = new Label();
            labelrequiredPopulationIncrease = new Label();
            ColumnYear = new DataGridViewTextBoxColumn();
            ColumnStartYearPopulation = new DataGridViewTextBoxColumn();
            ColumnRaising = new DataGridViewTextBoxColumn();
            ColumnMortality = new DataGridViewTextBoxColumn();
            ColumnResult = new DataGridViewTextBoxColumn();
            ColumnPopulationDifference = new DataGridViewTextBoxColumn();
            ColumnCondition = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnYear, ColumnStartYearPopulation, ColumnRaising, ColumnMortality, ColumnResult, ColumnPopulationDifference, ColumnCondition });
            dataGridView.Dock = DockStyle.Right;
            dataGridView.Location = new Point(118, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(767, 450);
            dataGridView.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(12, 415);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 23);
            buttonCalculate.TabIndex = 1;
            buttonCalculate.Text = "Рассчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += ButtonCalculate_Click;
            // 
            // textBoxStartYear
            // 
            textBoxStartYear.Location = new Point(12, 27);
            textBoxStartYear.Name = "textBoxStartYear";
            textBoxStartYear.Size = new Size(100, 23);
            textBoxStartYear.TabIndex = 2;
            textBoxStartYear.Text = "2014";
            // 
            // labelStartYear
            // 
            labelStartYear.AutoSize = true;
            labelStartYear.Location = new Point(12, 9);
            labelStartYear.Name = "labelStartYear";
            labelStartYear.Size = new Size(26, 15);
            labelStartYear.TabIndex = 3;
            labelStartYear.Text = "Год";
            // 
            // textBoxStartPopulation
            // 
            textBoxStartPopulation.Location = new Point(12, 82);
            textBoxStartPopulation.Name = "textBoxStartPopulation";
            textBoxStartPopulation.Size = new Size(100, 23);
            textBoxStartPopulation.TabIndex = 4;
            textBoxStartPopulation.Text = "300000";
            // 
            // textBoxMortalityRate
            // 
            textBoxMortalityRate.Location = new Point(12, 198);
            textBoxMortalityRate.Name = "textBoxMortalityRate";
            textBoxMortalityRate.Size = new Size(100, 23);
            textBoxMortalityRate.TabIndex = 5;
            textBoxMortalityRate.Text = "5";
            // 
            // textBoxrequiredPopulationIncrease
            // 
            textBoxrequiredPopulationIncrease.Location = new Point(12, 251);
            textBoxrequiredPopulationIncrease.Name = "textBoxrequiredPopulationIncrease";
            textBoxrequiredPopulationIncrease.Size = new Size(100, 23);
            textBoxrequiredPopulationIncrease.TabIndex = 6;
            textBoxrequiredPopulationIncrease.Text = "2";
            // 
            // textBoxGrowthPercentage
            // 
            textBoxGrowthPercentage.Location = new Point(12, 138);
            textBoxGrowthPercentage.Name = "textBoxGrowthPercentage";
            textBoxGrowthPercentage.Size = new Size(100, 23);
            textBoxGrowthPercentage.TabIndex = 7;
            textBoxGrowthPercentage.Text = "7";
            // 
            // labelStartPopulation
            // 
            labelStartPopulation.AutoSize = true;
            labelStartPopulation.Location = new Point(12, 64);
            labelStartPopulation.Name = "labelStartPopulation";
            labelStartPopulation.Size = new Size(67, 15);
            labelStartPopulation.TabIndex = 8;
            labelStartPopulation.Text = "Население";
            // 
            // labelGrowthPercentage
            // 
            labelGrowthPercentage.AutoSize = true;
            labelGrowthPercentage.Location = new Point(12, 120);
            labelGrowthPercentage.Name = "labelGrowthPercentage";
            labelGrowthPercentage.Size = new Size(68, 15);
            labelGrowthPercentage.TabIndex = 9;
            labelGrowthPercentage.Text = "% Прирост";
            // 
            // labelMortalityRate
            // 
            labelMortalityRate.AutoSize = true;
            labelMortalityRate.Location = new Point(12, 180);
            labelMortalityRate.Name = "labelMortalityRate";
            labelMortalityRate.Size = new Size(86, 15);
            labelMortalityRate.TabIndex = 10;
            labelMortalityRate.Text = "% Смертность";
            // 
            // labelrequiredPopulationIncrease
            // 
            labelrequiredPopulationIncrease.AutoSize = true;
            labelrequiredPopulationIncrease.Location = new Point(12, 233);
            labelrequiredPopulationIncrease.Name = "labelrequiredPopulationIncrease";
            labelrequiredPopulationIncrease.Size = new Size(73, 15);
            labelrequiredPopulationIncrease.TabIndex = 11;
            labelrequiredPopulationIncrease.Text = "Увеличение";
            // 
            // ColumnYear
            // 
            ColumnYear.HeaderText = "Год";
            ColumnYear.Name = "ColumnYear";
            // 
            // ColumnStartYearPopulation
            // 
            ColumnStartYearPopulation.HeaderText = "Начало года";
            ColumnStartYearPopulation.Name = "ColumnStartYearPopulation";
            // 
            // ColumnRaising
            // 
            ColumnRaising.HeaderText = "Прирост";
            ColumnRaising.Name = "ColumnRaising";
            // 
            // ColumnMortality
            // 
            ColumnMortality.HeaderText = "Смертность";
            ColumnMortality.Name = "ColumnMortality";
            // 
            // ColumnResult
            // 
            ColumnResult.HeaderText = "Конец года";
            ColumnResult.Name = "ColumnResult";
            // 
            // ColumnPopulationDifference
            // 
            ColumnPopulationDifference.HeaderText = "Годовой прирост";
            ColumnPopulationDifference.Name = "ColumnPopulationDifference";
            // 
            // ColumnCondition
            // 
            ColumnCondition.HeaderText = "Население больше начального в 2 раза";
            ColumnCondition.Name = "ColumnCondition";
            // 
            // FormTraycing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 450);
            Controls.Add(labelrequiredPopulationIncrease);
            Controls.Add(labelMortalityRate);
            Controls.Add(labelGrowthPercentage);
            Controls.Add(labelStartPopulation);
            Controls.Add(textBoxGrowthPercentage);
            Controls.Add(textBoxrequiredPopulationIncrease);
            Controls.Add(textBoxMortalityRate);
            Controls.Add(textBoxStartPopulation);
            Controls.Add(labelStartYear);
            Controls.Add(textBoxStartYear);
            Controls.Add(buttonCalculate);
            Controls.Add(dataGridView);
            Name = "FormTraycing";
            Text = "FormTraycing";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonCalculate;
        private TextBox textBoxStartYear;
        private Label labelStartYear;
        private TextBox textBoxStartPopulation;
        private TextBox textBoxMortalityRate;
        private TextBox textBoxrequiredPopulationIncrease;
        private TextBox textBoxGrowthPercentage;
        private Label labelStartPopulation;
        private Label labelGrowthPercentage;
        private Label labelMortalityRate;
        private Label labelrequiredPopulationIncrease;
        private DataGridViewTextBoxColumn ColumnYear;
        private DataGridViewTextBoxColumn ColumnStartYearPopulation;
        private DataGridViewTextBoxColumn ColumnRaising;
        private DataGridViewTextBoxColumn ColumnMortality;
        private DataGridViewTextBoxColumn ColumnResult;
        private DataGridViewTextBoxColumn ColumnPopulationDifference;
        private DataGridViewTextBoxColumn ColumnCondition;
    }
}