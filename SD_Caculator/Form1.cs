using System;
using System.Collections;
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
        ArrayList numbers = new ArrayList();
        
        
        public Form1()
        {
            InitializeComponent();
        }
        //public double 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtAdd.Text != "")
            {
                try
                {
                   numbers.Add( Convert.ToDouble(txtAdd.Text));
                }
                catch (FormatException ex) // catch the specific exception
                                            //for entering a letter instead of a number
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex) // the base class will catch other exceptions
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    lblCountDisplay.Text = numbers.Count.ToString();
                    txtAdd.Clear();
                    txtAdd.Focus();
                }
            }
            else { MessageBox.Show("Please enter a number then click add"); }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double sumOfXes = 0, sumOfSquares = 0, sumOfXesSquared = 0;
            double variance = 0, standardDeviation = 0;

            sumOfXes = SumTheXs(numbers);
            sumOfSquares = GetSumOfSquares(numbers);
            sumOfXesSquared = sumOfXes * sumOfXes;
            variance = (sumOfSquares - (sumOfXesSquared / numbers.Count)) / (numbers.Count - 1);
            standardDeviation = Math.Sqrt(variance);
            lblVariationDisplay.Text = variance.ToString();
            lblDeviationDisplay.Text = standardDeviation.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs  e)
        {
            double[] dataset;
            using(OpenFileDialog fileOpen = new OpenFileDialog()) 
            {
                
                fileOpen.Title = "Open datafile";

                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(File.OpenRead(fileOpen.FileName));
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        //int[] numbers1 = line.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                        try
                        {
                            dataset = line.Split(',').Select(n => double.Parse(n.Trim())).ToArray();
                            numbers.AddRange(dataset); 
                        }
                        catch (FormatException ex) // catch the specific exception
                        //for entering a letter instead of a number
                        {
                            MessageBox.Show(ex.Message);
                            break;
                        }
                        catch (Exception ex) // the base class will catch other exceptions
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            
                            lblCountDisplay.Text = numbers.Count.ToString();
                           
                        }
                        
                    }//end while
                    reader.Dispose();
                    reader.Close();
                }//end if
                
            }//end using
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblVariationDisplay.Text = "";
            lblDeviationDisplay.Text = "";
            lblCountDisplay.Text = "";
            numbers.Clear();
        }

        public double SumTheXs(ArrayList numbers)
        {
            double total = 0;
            foreach(double number in numbers)
            {
                total += number;
            }
            return total;

        }

        public double GetSumOfSquares(ArrayList numbers)
        {
            double total = 0;
            foreach(double number in numbers)
            {
                total += number * number;
            }
            return total;
	    {
		 
	}
    }
	
    }
}
    
