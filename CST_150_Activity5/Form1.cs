/*Author: Miguel Torres Perez */

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

namespace CST_150_Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            var word = File.ReadAllText(openFileDialog1.FileName).ToLower();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string[] words = word.Split(' ');
                            Array.Sort<string>(words);
                            resultsTB.Text = ("The original text: \r\n" + File.ReadAllText(openFileDialog1.FileName)
                                + "\r\nAll lower case text: \r\n" + word);
                            foreach(string item in words)
                            {
                                alphabeticalTB.Text += "\r\n" + item;

                            }
                            string longest = words.OrderByDescending(s => s.Length).First();
                            mostTB.Text += "\r\n" + longest;
                            foreach(string item in words)
                            {
                                string temp = null;
                                if (item.Contains("a") || item.Contains("e") || item.Contains("i") || item.Contains("o") || item.Contains("u"))
                                {
                                    int total = 0;
                                    total++;
                                    int tempTotal = 0;
                                    if (tempTotal > total)
                                    {
                                        temp = item;
                                    }
                                }
                                mostTB.Text += temp; 
                            }

                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void examineFileButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resultsTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using(StreamWriter objWriter = new StreamWriter("test1.txt"))
            {
                objWriter.Write(resultsTB.Text);
                objWriter.Write(alphabeticalTB.Text);
                objWriter.Write(mostTB.Text);
                MessageBox.Show("All has been written to test1.txt file");
            }
        }
    }
}
