using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy2U_test;
using System.IO;

namespace Pharmacy2U_test
{
    public partial class ConversionWindow : Form
    {
        private ConverstionImformation Converstion;
        private AuditWindow Audit = new AuditWindow();
        private List<string[]> ConversionData;
        private int InputNum;

        public ConversionWindow()
        {
            Converstion = new ConverstionImformation();
            InitializeComponent();
            ConversionData = Converstion.GetConversionInformation();
        }        

        private void ConvertInputBox_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(ConvertInputBox.Text,out _))
            {
                ConvertInputBox.Text = "";
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            InputNum = int.Parse(ConvertInputBox.Text);
            Double ConversionRate = FindConversionRate();

            Double Result = InputNum * ConversionRate;

            ConvertOutputBox.Text = Result.ToString();
            AuditConverts(CurrencyConvertTo.Text, Result);
        }

        private Double FindConversionRate()
        {
            for(int i = 0; i < ConversionData.Count; i++)
            {
                if(ConversionData[i][0] == CurrencyConvertTo.Text)
                {
                    return Double.Parse(ConversionData[i][1]);
                }
            }
            return 0;
        }

        private void AuditButton_Click(object sender, EventArgs e)
        {
            Audit.ReadAuditFile();
            Audit.printintoTextBox();
            Audit.ShowDialog();
        }

        private void AuditConverts(string Convertsion, double convertedNum)
        {
            StreamReader reader = new StreamReader("Audit.txt");
            string filecontent = reader.ReadToEnd();
            reader.Close();
            StreamWriter writer = new StreamWriter("Audit.txt");
            writer.Write(filecontent + Convertsion + "," + convertedNum + "," + System.DateTime.Now + System.Environment.NewLine);
            writer.Close();
        }
    }
}
