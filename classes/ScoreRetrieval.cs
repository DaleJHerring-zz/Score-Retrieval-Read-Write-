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

namespace ScoreRetrievalApp
{
    public partial class ScoreRetrievalForm : Form
    {
        private StreamReader inFile;
        private StreamWriter outFile;
        string[] line1, line2, line3, line4, line5, line6, line7, line8;
        string inValue;
        int caseCnt, avg1, avg2, avg3, avg4, avg5, avg6, avg7, avg8;

        private void ScoreRetrievalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseMth();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            CloseMth();
            Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DispNewWriteBox.Items.Clear();
            ErrorLbl.Hide();
            ErrorLbl.Text = " ";
            RewriteBtn.Enabled = true;
        }

        private void RewriteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                while ((inValue = inFile.ReadLine()) != null)
                {
                    switch (caseCnt)
                    {
                        case 1:
                            line1 = inValue.Split(' ');
                            break;
                        case 2:
                            line2 = inValue.Split(' ');
                            break;
                        case 3:
                            line3 = inValue.Split(' ');
                            break;
                        case 4:
                            line4 = inValue.Split(' ');
                            break;
                        case 5:
                            line5 = inValue.Split(' ');
                            break;
                        case 6:
                            line6 = inValue.Split(' ');
                            break;
                        case 7:
                            line7 = inValue.Split(' ');
                            break;
                        case 8:
                            line8 = inValue.Split(' ');
                            break;
                        default:
                            ErrorLbl.Text = "Error";
                            break;
                    }//end switch

                    caseCnt++;

                } //end while

                avg1 = (int.Parse(line1[2]) + int.Parse(line1[3]) + int.Parse(line1[4])) / 3;
                avg2 = (int.Parse(line2[2]) + int.Parse(line2[3]) + int.Parse(line2[4])) / 3;
                avg3 = (int.Parse(line3[2]) + int.Parse(line3[3]) + int.Parse(line3[4])) / 3;
                avg4 = (int.Parse(line4[2]) + int.Parse(line4[3]) + int.Parse(line4[4])) / 3;
                avg5 = (int.Parse(line5[2]) + int.Parse(line5[3]) + int.Parse(line5[4])) / 3;
                avg6 = (int.Parse(line6[2]) + int.Parse(line6[3]) + int.Parse(line6[4])) / 3;
                avg7 = (int.Parse(line7[2]) + int.Parse(line7[3]) + int.Parse(line7[4])) / 3;
                avg8 = (int.Parse(line8[2]) + int.Parse(line8[3]) + int.Parse(line8[4])) / 3;

                outFile.WriteLine(line1[0] + " " + line1[1] + " " + avg1);
                outFile.WriteLine(line2[0] + " " + line2[1] + " " + avg2);
                outFile.WriteLine(line3[0] + " " + line3[1] + " " + avg3);
                outFile.WriteLine(line4[0] + " " + line4[1] + " " + avg4);
                outFile.WriteLine(line5[0] + " " + line5[1] + " " + avg5);
                outFile.WriteLine(line6[0] + " " + line6[1] + " " + avg6);
                outFile.WriteLine(line7[0] + " " + line7[1] + " " + avg7);
                outFile.WriteLine(line8[0] + " " + line8[1] + " " + avg8);

                DispNewWriteBox.Items.Add(line1[0] + " " + line1[1] + " " + avg1);
                DispNewWriteBox.Items.Add(line2[0] + " " + line2[1] + " " + avg2);
                DispNewWriteBox.Items.Add(line3[0] + " " + line3[1] + " " + avg3);
                DispNewWriteBox.Items.Add(line4[0] + " " + line4[1] + " " + avg4);
                DispNewWriteBox.Items.Add(line5[0] + " " + line5[1] + " " + avg5);
                DispNewWriteBox.Items.Add(line6[0] + " " + line6[1] + " " + avg6);
                DispNewWriteBox.Items.Add(line7[0] + " " + line7[1] + " " + avg7);
                DispNewWriteBox.Items.Add(line8[0] + " " + line8[1] + " " + avg8);

                RewriteBtn.Enabled = false;
            }//end try
            catch (FormatException frmX)
            {
                ErrorLbl.Text = frmX.Message;
                ErrorLbl.Show();
            }
            catch (ArithmeticException aX)
            {
                ErrorLbl.Text = aX.Message;
                ErrorLbl.Show();
            }
            catch (ArrayTypeMismatchException atX)
            {
                ErrorLbl.Text = atX.Message;
                ErrorLbl.Show();
            }
            catch (IndexOutOfRangeException iorX)
            {
                ErrorLbl.Text = iorX.Message;
                ErrorLbl.Show();
            }
            catch (Exception eX)
            {
                ErrorLbl.Text = eX.Message;
                ErrorLbl.Show();
            }
        }//end rewrite btn click

        public ScoreRetrievalForm()
        {
            InitializeComponent();
        }

        private void ScoreRetrievalForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("StoredScores.txt"))
                {
                    inFile = new StreamReader("StoredScores.txt");  
                    outFile = new StreamWriter("AvgScores.txt");
                } //end if
                
                line1 = new string[5];
                line2 = new string[5];
                line3 = new string[5];
                line4 = new string[5];
                line5 = new string[5];
                line6 = new string[5];
                line7 = new string[5];
                line8 = new string[5];
                caseCnt = 1;
            }//end try
            catch (FileNotFoundException fX)
            {
                ErrorLbl.Text = fX.Message;
                ErrorLbl.Show();
            }//end catch
            catch (Exception X)
            {
                ErrorLbl.Text = X.Message;
                ErrorLbl.Show();
            }//end catch
        }//end formload

        private void CloseMth()
        {
            try
            {
                inFile.Close();
                outFile.Close();         
            }//end try
            catch (IOException ioX)
            {
                ErrorLbl.Text = ioX.Message;
                ErrorLbl.Show();
            }
            catch (Exception xX)
            {
                ErrorLbl.Text = xX.Message;
                ErrorLbl.Show();
            }
        }//end close


    }//end class
}//end namespace
