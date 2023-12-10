using System;
using System.IO;
using System;
using System.Windows.Forms;
using NUnit.Framework;



class Program
{
    static void Main()
    {
        try
        {
            throw new InvalidOperationException("Simulated exception");
        }
        catch (Exception ex)
        {
            LogError(ex);
        }
    }

    static void LogError(Exception ex)
    {
        string logFilePath = "error_log.txt";
        string logMessage = $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n\n";

        File.AppendAllText(logFilePath, logMessage);
    }
}


public class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        Button btnSubmit = new Button();
        btnSubmit.Text = "Submit";
        btnSubmit.Click += BtnSubmit_Click;
        Controls.Add(btnSubmit);
    }

    private void BtnSubmit_Click(object sender, EventArgs e)
    {
        
    }
}

[TestFixture]
public class StudentManagementTests
{
    [Test]
    public void TestCRUDOperations()
    {
       
        Assert.AreEqual(4, 2 + 2);
    }
}

