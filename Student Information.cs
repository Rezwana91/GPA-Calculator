using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculation
{
    public partial class Form1 : Form
    {
        List<string> id = new List<string> { };
        List<string> name = new List<string> { };
        List<string> mobile = new List<string> { };
        List<string> age = new List<string> { };
        List<string> address = new List<string> { };
        List<string> gpaPoint = new List<string> { };
        List<double> gpaPoint2 = new List<double> { };
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                displayRichTextBox.Text = "";
                top:

                if (idTextBox.Text == "" || nameTextBox.Text == "" || mobileTextBox.Text == "" || ageTextBox.Text == "" || addressTextBox.Text == "" || gpapointTextBox.Text == "")
                {
                    MessageBox.Show("Please enter all information");
                }
                else
                {
                    if (idTextBox.Text.Length == 4)
                    {
                        if (id.Contains(idTextBox.Text))
                        {
                            MessageBox.Show("ID must be uniqe");
                            idTextBox.Text = "";
                            goto top;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Must be enter 4 digit id");
                        idTextBox.Text = "";
                        goto top;

                    }
                    if (nameTextBox.Text.Length > 30)
                    {
                        MessageBox.Show("please enter less then 30 letter");
                        nameTextBox.Text = "";
                        goto top;
                        
                    }
                   

                    if (mobileTextBox.Text.Length == 11)
                    {

                        if (mobile.Contains(mobileTextBox.Text))
                        {
                            MessageBox.Show("Mobile No. must be uniqe");
                            mobileTextBox.Text = "";
                            goto top;

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Must be enter 11 digit id");
                        mobileTextBox.Text = "";
                        goto top;
                    }
                    double a = Convert.ToDouble(gpapointTextBox.Text);
                    if (a < 0 && a > 4)
                    {
                        MessageBox.Show("please enter value between 0 to 4");
                        gpapointTextBox.Text = "";
                        goto top;

                    }
                  

                    id.Add(idTextBox.Text);
                    name.Add(nameTextBox.Text);
                    mobile.Add(mobileTextBox.Text);
                    age.Add(ageTextBox.Text);
                    address.Add(addressTextBox.Text);
                    gpaPoint2.Add(a);
                    gpaPoint.Add(gpapointTextBox.Text);




                    //gpaPoint.Add(a);
                    MessageBox.Show("All data is successfuly saved");

                    displayRichTextBox.SelectedText = Environment.NewLine + "ID       :" + id[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Name     :" + name[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Mobile   :" + mobile[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Age      :" + age[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "Address  :" + address[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + "GPA Point:" + gpaPoint[i];
                    displayRichTextBox.SelectedText = Environment.NewLine + " ";

                    idTextBox.Text = "";
                    nameTextBox.Text = "";
                    mobileTextBox.Text = "";
                    ageTextBox.Text = "";
                    addressTextBox.Text = "";
                    gpapointTextBox.Text = "";

                    i++;
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

           

        }

        private void showallButton_Click(object sender, EventArgs e)
        {
            try
            {
                displayRichTextBox.Text = "";
                string mes = "";
                for (int j = 0; j < id.Count; j++)
                {
                    mes += "ID       :" + id[j] + "\n" + "Name     :" + name[j] + "\n" +
                           "Mobile   :" + mobile[j] + "\n" + "Age      :" + age[j] + "\n"
                           + "Address  :" + address[j] + "\n" + "GPA Point:" + gpaPoint[j]
                           + "\n";

                }

                displayRichTextBox.SelectedText = Environment.NewLine + mes + " ";


                maxTextBox.Text = gpaPoint.Max();


                minTextBox.Text = gpaPoint.Min();


                double average = gpaPoint2.Average();
                avgTextBox.Text = average.ToString();

                double m = 0;
                for (int k = 0; k < gpaPoint2.Count; k++)
                {
                    m += gpaPoint2[k];

                    if (gpaPoint[k] == maxTextBox.Text)
                    {
                        maxnameTextBox.Text = name[k];

                    }

                    if (gpaPoint[k] == minTextBox.Text)
                    {
                        minnameTextBox.Text = name[k];
                    }



                }

                totalTextBox.Text = m.ToString();


                //avgTextBox.Text = gpaPoint.;



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                displayRichTextBox.Text = "";
                for (int n = 0; n < id.Count; n++)
                {
                    if (idRadioButton.Checked == true)
                    {
                        if (idTextBox.Text == id[n])
                        {
                            displayRichTextBox.SelectedText = Environment.NewLine + "ID       :" + id[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Name     :" + name[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Mobile   :" + mobile[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Age      :" + age[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Address  :" + address[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "GPA Point:" + gpaPoint[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + " ";
                        }
                    }
                    else if (nameRadioButton.Checked == true)
                    {
                        if (nameTextBox.Text == name[n])
                        {
                            displayRichTextBox.SelectedText = Environment.NewLine + "ID       :" + id[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Name     :" + name[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Mobile   :" + mobile[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Age      :" + age[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Address  :" + address[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "GPA Point:" + gpaPoint[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + " ";
                        }
                    }

                    else if (mobileRadioButton.Checked == true)
                    {
                        if (mobileTextBox.Text == mobile[n])
                        {
                            displayRichTextBox.SelectedText = Environment.NewLine + "ID       :" + id[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Name     :" + name[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Mobile   :" + mobile[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Age      :" + age[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "Address  :" + address[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + "GPA Point:" + gpaPoint[n];
                            displayRichTextBox.SelectedText = Environment.NewLine + " ";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the search option");
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            

        }
    }
}
