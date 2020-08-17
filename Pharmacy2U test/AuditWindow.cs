using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pharmacy2U_test
{
    public partial class AuditWindow : Form
    {
        private List<string> fileContent = new List<string>();
        private List<DateTime> DateList = new List<DateTime>();

        public AuditWindow()
        {
            InitializeComponent();                      
        }

        public void printintoTextBox()
        {
            for (int i = 0; i < fileContent.Count; i++)
            {
                AuditTextBox.Text += fileContent[i] + System.Environment.NewLine;
            }
        }

        public void printintoTextBoxWithDateFilter()
        {
            AuditTextBox.Clear();
            for (int i = 0; i < fileContent.Count; i++)
            {
                if ((DateList[i] >= DateTime.Parse(FromDateBox.Text)) && (DateList[i] <= DateTime.Parse(ToDateBox.Text)))
                {
                    AuditTextBox.Text += fileContent[i] + System.Environment.NewLine;
                }
            }
        }

        public void ReadAuditFile()
        {
            StreamReader reader = new StreamReader("Audit.txt");
            bool readtoggle = true;
            try
            {
                do
                {
                    string fileLine = reader.ReadLine();
                    if (fileLine != null)
                    {
                        fileContent.Add(fileLine);
                    }
                    else
                    {
                        readtoggle = false;
                    }
                }
                while (readtoggle);
            }
            catch
            {

            }
            reader.Close();
            GetDateList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetDateList()
        {
            for (int i = 0; i < fileContent.Count; i++)
            {
                string[] tempSplit = fileContent[i].Split(',');
                DateTime dateTemp = DateTime.Parse(tempSplit[2]);
                DateList.Add(dateTemp);
                FromDateBox.Items.Add(dateTemp);
                ToDateBox.Items.Add(dateTemp);
            }
            FromDateBox.Text = DateList[0].ToString();
            ToDateBox.Text = DateList[DateList.Count-1].ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            printintoTextBoxWithDateFilter();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            printintoTextBoxWithDateFilter();
        }
    }
}
