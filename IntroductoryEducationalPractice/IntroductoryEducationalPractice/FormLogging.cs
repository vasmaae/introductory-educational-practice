using Microsoft.Extensions.Logging;

namespace IntroductoryEducationalPractice;

public partial class FormLogging : Form
{
    private readonly ILogger _logger;

    public FormLogging(ILogger<FormLogging> logger)
    {
        InitializeComponent();
        _logger = logger;
    }

    private void ButtonCalculate_Click(object sender, EventArgs e)
    {
        try
        {

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            MessageBox.Show(ex.Message);
        }
    }
}
