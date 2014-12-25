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

namespace Math_Deviations
{
    public partial class Form1 : Form
    {
        double sumOfXes = 0, squares = 0, sumOfSquares = 0, sumOfXesSquared = 0, textBoxNumber = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtAdd.Text != "")
            {
                textBoxNumber = Convert.ToDouble(txtAdd.Text);
                sumOfXes += textBoxNumber;
                squares = textBoxNumber * textBoxNumber;
                lblRunningSquares.Text = squares.ToString();
                sumOfSquares += squares;
                count++;
                lblCountDisplay.Text = count.ToString();
                txtAdd.Clear();
                txtAdd.Focus();
            }
            else { MessageBox.Show("Please enter a number then click add"); }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double variance = 0, standardDeviation = 0;

            sumOfXesSquared = sumOfXes * sumOfXes;
            variance = (sumOfSquares - (sumOfXesSquared / count)) / (count - 1);
            standardDeviation = Math.Sqrt(variance);
            lblVariationDisplay.Text = variance.ToString();
            lblDeviationDisplay.Text = standardDeviation.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open datafile";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(File.OpenRead(fileOpen.FileName));
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    //int[] numbers1 = line.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                    double[] numbers = line.Split(',').Select(n => double.Parse(n.Trim())).ToArray();

                    //for each through array and call add function 
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sumOfXes += numbers[i];
                        sumOfSquares += numbers[i] * numbers[i];
                        count = numbers.Length;
                        lblCountDisplay.Text = count.ToString();
                        numbers[i] = 0;
                    }

                }
                reader.Dispose();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblVariationDisplay.Text = "";
            lblDeviationDisplay.Text = "";
        }


	
    }
}
    
