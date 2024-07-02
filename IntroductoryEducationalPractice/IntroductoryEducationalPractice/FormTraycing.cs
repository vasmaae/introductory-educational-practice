namespace IntroductoryEducationalPractice;

public partial class FormTraycing : Form
{
    public FormTraycing()
    {
        InitializeComponent();
    }

    private void ButtonCalculate_Click(object sender, EventArgs e)
    {
        int startYear = int.Parse(textBoxStartYear.Text), currentYear = startYear;
        int startPopulation = int.Parse(textBoxStartPopulation.Text), currentPopulation = startPopulation;
        double growthPercentage = double.Parse(textBoxGrowthPercentage.Text) / 100, 
            mortalityRate = double.Parse(textBoxMortalityRate.Text) / 100;
        double requiredPopulationIncrease = double.Parse(textBoxrequiredPopulationIncrease.Text);

        int annualGrowth, annualMortality, populationDifference;
        while (currentPopulation / startPopulation < requiredPopulationIncrease)
        {
            dataGridView.Rows.Add(currentYear, currentPopulation, "", "", "", "", "");

            annualGrowth = (int)(currentPopulation * growthPercentage);
            dataGridView.Rows.Add(currentYear, "", annualGrowth, "", "", "", "");

            annualMortality = (int)(currentPopulation * mortalityRate);
            dataGridView.Rows.Add(currentYear, "", "", annualMortality, "", "", "");

            currentPopulation += annualGrowth;
            currentPopulation -= annualMortality;
            dataGridView.Rows.Add(currentYear, "", "", "", currentPopulation, "", "");

            populationDifference = annualGrowth - annualMortality;
            dataGridView.Rows.Add(currentYear, "", "", "", "", populationDifference, "");

            dataGridView.Rows.Add(currentYear, "", "", "", "", "", (currentPopulation / startPopulation < requiredPopulationIncrease) ? "+" : "-");

            currentYear++;
        }
    }
}
