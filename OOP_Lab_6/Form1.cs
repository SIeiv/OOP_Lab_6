namespace OOP_Lab_6;

public partial class Form1 : Form
{
    public AsyncMethods asyncMethods;
    public Form1()
    {
        InitializeComponent();
        asyncMethods = new AsyncMethods();
    }

    public void FormErrorHandler(Exception exception)
    {
        MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private async void button3_Click(object sender, EventArgs e)
    {
        try
        {
            textBox4.Text = await asyncMethods.GetSystemDateAsync();
        }
        catch (Exception exception)
        {
            FormErrorHandler(exception);
        }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
        try
        {
            await asyncMethods.GenerateRandomVectorAsync(int.Parse(textBox3.Text));
            textBox1.Text = asyncMethods.VectorToString();
        }
        catch (Exception exception)
        {
            FormErrorHandler(exception);
        }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        try
        {
            textBox2.Text = (await asyncMethods.CalcVectorSumAsync()).ToString();
        }
        catch (Exception exception)
        {
            FormErrorHandler(exception);
        }
    }
}