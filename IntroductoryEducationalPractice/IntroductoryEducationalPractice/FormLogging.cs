using Microsoft.Extensions.Logging;

namespace IntroductoryEducationalPractice;

public partial class FormLogging : Form
{
    private readonly ILogger _logger;

    public FormLogging(ILogger<FormLogging> logger)
    {
        InitializeComponent();
        _logger = logger;
        _logger.LogInformation("Программа запущена");
    }

    private void ButtonCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            double varX = double.Parse(textBoxXValue.Text), funcY, sumS = 0;

            _logger.LogInformation("Начато вычисление функции Y");
            funcY = Math.Log(1 - Math.Pow(varX, 2));
            _logger.LogInformation($"Значение функции Y = {funcY.ToString()}");
            textBoxFuncY.Text = funcY.ToString();

            _logger.LogInformation("Начато вычисление суммы S");
            for (int i = 1; i <= 20; i++)
            {
                sumS += -1 * (Math.Pow(varX, i * 2) / i);
            }
            _logger.LogInformation($"Значение суммы S = {sumS.ToString()}");
            textBoxSumS.Text = sumS.ToString();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            MessageBox.Show(ex.Message);
        }
    }
}
