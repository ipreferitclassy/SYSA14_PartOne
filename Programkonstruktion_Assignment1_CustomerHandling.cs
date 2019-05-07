using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSA14_Biljettbokning
{
    public partial class Programkonstruktion_Assignment1_CustomerHandling : Form
    {
        public Programkonstruktion_Assignment1_CustomerHandling()
        {
            InitializeComponent();
        }

        Controller controller = new Controller(); 

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Programkonstruktion_Assignment1 temp = new Programkonstruktion_Assignment1();
            temp.Show();
            this.Hide();
        }

        private void BtnSearchForCustomer_Click(object sender, EventArgs e)
        {
            bool tempCheckSearchViaID = radioBtnSearchViaID.Checked;
            bool tempCheckSearchViaName = radioBtnSearchViaName.Checked;
            bool tempCheckForException = false; 
            String tempString = textBoxCustomerID.Text;
            int tempCustomerID = 0;
            String tempCustomerName = textBoxCustomerName.Text; 

            lblFeedbackCustomerAddress.Text = "";
            lblFeedbackCustomerEmail.Text = "";
            lblFeedbackCustomerID.Text = "";
            lblFeedBackCustomerName.Text = "";
            lblFeedbackEventPerformed.Text = "";
            dataGridView.DataSource = null;

            if (tempCheckSearchViaID == true)
            {

                if (textBoxCustomerID.Text.Length > 0)
                {
                    try
                    {
                        tempCustomerID = int.Parse(tempString);

                        if ( tempCustomerID <= 0)
                        {

                            lblFeedbackCustomerAddress.Text = "";
                            lblFeedbackCustomerEmail.Text = "";
                            lblFeedbackCustomerID.Text = " Id:t måste vara ett heltal större än 0!";
                            lblFeedBackCustomerName.Text = "";
                            lblFeedbackEventPerformed.Text = "";
                            dataGridView.DataSource = null;
                        }

                    } catch (FormatException ex)
                    {
           
                        lblFeedbackCustomerAddress.Text = "";
                        lblFeedbackCustomerEmail.Text = "";
                        lblFeedbackCustomerID.Text = "Id:t får enbart innehålla siffror!";
                        lblFeedBackCustomerName.Text = "";
                        lblFeedbackEventPerformed.Text = "";
                        dataGridView.DataSource = null;

                        tempCheckForException = true; 
                    }

                    if(tempCheckForException == false && tempCustomerID > 0)
                    {
                        DataTable tempTable = controller.CSearchAndConstructACustomerTable(tempCustomerID);

                        if (tempTable.Rows.Count >=1)
                        {
                            dataGridView.DataSource = tempTable;

                            lblFeedbackCustomerAddress.Text = "";
                            lblFeedbackCustomerEmail.Text = "";
                            lblFeedbackCustomerID.Text = "";
                            lblFeedBackCustomerName.Text = "";
                            lblFeedbackEventPerformed.Text = "Sökningen har genomförts!";

                        } else if(tempTable.Rows.Count <=0)
                        {
                            lblFeedbackCustomerAddress.Text = "";
                            lblFeedbackCustomerEmail.Text = "";
                            lblFeedbackCustomerID.Text = "Finns ingen kund med det angivna id:t!";
                            lblFeedBackCustomerName.Text = "";
                            lblFeedbackEventPerformed.Text = "";
                            dataGridView.DataSource = null;
                        }

                    }

                } else if (textBoxCustomerID.Text.Length<=0)
                {
                    lblFeedbackCustomerAddress.Text = "";
                    lblFeedbackCustomerEmail.Text = "";
                    lblFeedbackCustomerID.Text = "Ett id måste anges!";
                    lblFeedBackCustomerName.Text = "";
                    lblFeedbackEventPerformed.Text = "";
                    dataGridView.DataSource = null;
                }

            } else if (tempCheckSearchViaName == true)
            {

                if (textBoxCustomerName.Text.Length > 0)
                {
                    
                      DataTable tempTable = controller.CSearchAndConstructACustomerTable(tempCustomerName);

                        if (tempTable.Rows.Count >= 1)
                        {
                            dataGridView.DataSource = tempTable;

                            lblFeedbackCustomerAddress.Text = "";
                            lblFeedbackCustomerEmail.Text = "";
                            lblFeedbackCustomerID.Text = "";
                            lblFeedBackCustomerName.Text = "";
                            lblFeedbackEventPerformed.Text = "Sökningen har genomförts!";


                    }
                        else if (tempTable.Rows.Count <= 0)
                        {
                            lblFeedbackCustomerAddress.Text = "";
                            lblFeedbackCustomerEmail.Text = "";
                            lblFeedbackCustomerID.Text = "";
                            lblFeedBackCustomerName.Text = "Finns ingen kund med det angivna namnet!";
                            lblFeedbackEventPerformed.Text = "";
                            dataGridView.DataSource = null;
                        }

                    

                }
                else if (textBoxCustomerName.Text.Length <= 0)
                {
                    lblFeedbackCustomerAddress.Text = "";
                    lblFeedbackCustomerEmail.Text = "";
                    lblFeedbackCustomerID.Text = "";
                    lblFeedBackCustomerName.Text = "Ett namn måste anges!";
                    lblFeedbackEventPerformed.Text = "";
                    dataGridView.DataSource = null;
                }


            }


        }

        private void BtnShowAllCustomers_Click(object sender, EventArgs e)
        {
            DataTable temptable = new DataTable();
            temptable = controller.CConstructCustomerTableOverAllCustomers();

            if (temptable.Rows.Count > 0)
            {
                dataGridView.DataSource = temptable;

                lblFeedbackCustomerAddress.Text = "";
                lblFeedbackCustomerEmail.Text = "";
                lblFeedbackCustomerID.Text = "";
                lblFeedBackCustomerName.Text = "";
                lblFeedbackEventPerformed.Text = "Samtliga kunder visas i tabellen!";

            } else if (temptable.Rows.Count < 0)
            {
                lblFeedbackCustomerAddress.Text = "";
                lblFeedbackCustomerEmail.Text = "";
                lblFeedbackCustomerID.Text = "";
                lblFeedBackCustomerName.Text = "";
                lblFeedbackEventPerformed.Text = "Hämtningen har utförts men inga kunder har ännu lagts till!";
            }


        }

        private void BtnRegisterOfCustomer_Click(object sender, EventArgs e)
        {
            // 1. Kontrollera att alla inparametrar är ok, samt att id:t är av typen int
            // 2. Kontrollera så att id:t är av typen int
            // 3. Anropa Controller --> Retunerar 1 om kunden redan finns och 2 om kunden inte fanns och lagts till korrekt! 
            // 4. Feedback till användaren

            lblFeedbackCustomerAddress.Text = "";
            lblFeedbackCustomerEmail.Text = "";
            lblFeedbackCustomerID.Text = "";
            lblFeedBackCustomerName.Text = "";
            lblFeedbackEventPerformed.Text = "";
            dataGridView.DataSource = null;

            String tempCheckCustomerID = textBoxCustomerID.Text;
            String tempCustomerName = textBoxCustomerName.Text;
            String tempCustomerAddress = textBoxCustomerAddress.Text;
            String tempCustomerEmail = textBoxCustomerEmail.Text;
            int tempCustomerID = 0; 
            bool checkException = false;


            if (tempCheckCustomerID.Length <= 0)
            {
                lblFeedbackCustomerAddress.Text = "";
                lblFeedbackCustomerEmail.Text = "";
                lblFeedbackCustomerID.Text = "Kundens id måste anges!";
                lblFeedBackCustomerName.Text = "";
                lblFeedbackEventPerformed.Text = "";
                dataGridView.DataSource = null;
            }
            else if (tempCustomerName.Length <= 0)
            {
                lblFeedbackCustomerAddress.Text = "";
                lblFeedbackCustomerEmail.Text = "";
                lblFeedbackCustomerID.Text = "";
                lblFeedBackCustomerName.Text = "Kundens namn måste anges! ";
                lblFeedbackEventPerformed.Text = "";
                dataGridView.DataSource = null; 
            }
            else if(tempCustomerAddress.Length <= 0)
            {
                lblFeedbackCustomerAddress.Text = "Kundens adress måste anges!";
                lblFeedbackCustomerEmail.Text = "";
                lblFeedbackCustomerID.Text = "";
                lblFeedBackCustomerName.Text = "";
                lblFeedbackEventPerformed.Text = "";
                dataGridView.DataSource = null;

            }
            else if (tempCustomerEmail.Length <= 0)
            {
                lblFeedbackCustomerAddress.Text = "";
                lblFeedbackCustomerEmail.Text = "Kundens email måste anges!";
                lblFeedbackCustomerID.Text = "";
                lblFeedBackCustomerName.Text = "";
                lblFeedbackEventPerformed.Text = "";
                dataGridView.DataSource = null;
            }
            else
            {

                try
                {
                    tempCustomerID = int.Parse(tempCheckCustomerID); 

                } catch (FormatException ex)
                {
                    checkException = true;

                    lblFeedbackCustomerAddress.Text = "";
                    lblFeedbackCustomerEmail.Text = "";
                    lblFeedbackCustomerID.Text = "Id:t får endast innehålla siffror!";
                    lblFeedBackCustomerName.Text = "";
                    lblFeedbackEventPerformed.Text = "";
                    dataGridView.DataSource = null;

                }

                if (tempCustomerID == 0 && checkException == false){

                    lblFeedbackCustomerAddress.Text = "";
                    lblFeedbackCustomerEmail.Text = "";
                    lblFeedbackCustomerID.Text = "Id:t får endast bestå ett heltal större än 0!";
                    lblFeedBackCustomerName.Text = "";
                    lblFeedbackEventPerformed.Text = "";
                    dataGridView.DataSource = null;

                } else if (tempCustomerID != 0 && checkException == false)
                {
                    int resultOfController = controller.CAddingACustomer(tempCustomerID, tempCustomerName, tempCustomerAddress, tempCustomerEmail);

                    if (resultOfController == 1)
                    {
                        lblFeedbackCustomerAddress.Text = "";
                        lblFeedbackCustomerEmail.Text = "";
                        lblFeedbackCustomerID.Text = "En kund med dat angivna idnummret finns redan registrerat!";
                        lblFeedBackCustomerName.Text = "";
                        lblFeedbackEventPerformed.Text = "";
                        dataGridView.DataSource = null;

                    } else if (resultOfController == 2)
                    {
                        lblFeedbackCustomerAddress.Text = "";
                        lblFeedbackCustomerEmail.Text = "";
                        lblFeedbackCustomerID.Text = "";
                        lblFeedBackCustomerName.Text = "";
                        lblFeedbackEventPerformed.Text = "Den nya kunden har lagts till!";
                        dataGridView.DataSource = null;
                    }


                }

            }


        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {

            lblFeedbackCustomerAddress.Text = "";
            lblFeedbackCustomerEmail.Text = "";
            lblFeedbackCustomerID.Text = "";
            lblFeedBackCustomerName.Text = "";
            lblFeedbackEventPerformed.Text = "";
            dataGridView.DataSource = null;

            String CheckCustomerID = textBoxCustomerID.Text;
           
            int tempCustomerID = 0;
            bool checkException = false;


            if (CheckCustomerID.Length <= 0)
            {
                lblFeedbackCustomerAddress.Text = "";
                lblFeedbackCustomerEmail.Text = "";
                lblFeedbackCustomerID.Text = "Kundens id måste anges!";
                lblFeedBackCustomerName.Text = "";
                lblFeedbackEventPerformed.Text = "";
                dataGridView.DataSource = null;
            }
            
            else
            {

                try
                {
                    tempCustomerID = int.Parse(CheckCustomerID);

                }
                catch (FormatException ex)
                {
                    checkException = true;

                    lblFeedbackCustomerAddress.Text = "";
                    lblFeedbackCustomerEmail.Text = "";
                    lblFeedbackCustomerID.Text = "Id:t får endast innehålla siffror!";
                    lblFeedBackCustomerName.Text = "";
                    lblFeedbackEventPerformed.Text = "";
                    dataGridView.DataSource = null;

                }

                if (tempCustomerID == 0 && checkException == false)
                {

                    lblFeedbackCustomerAddress.Text = "";
                    lblFeedbackCustomerEmail.Text = "";
                    lblFeedbackCustomerID.Text = "Id:t får endast bestå ett heltal större än 0!";
                    lblFeedBackCustomerName.Text = "";
                    lblFeedbackEventPerformed.Text = "";
                    dataGridView.DataSource = null;

                }
                else if (tempCustomerID != 0 && checkException == false)
                {
                    int resultOfController = controller.CDeleteACustomer(tempCustomerID);

                    if (resultOfController == 1)
                    {
                        lblFeedbackCustomerAddress.Text = "";
                        lblFeedbackCustomerEmail.Text = "";
                        lblFeedbackCustomerID.Text = " Det finns ingen kund med det angivna id:t registrerad!";
                        lblFeedBackCustomerName.Text = "";
                        lblFeedbackEventPerformed.Text = "";
                        dataGridView.DataSource = null;

                    }
                    else if (resultOfController == 2)
                    {
                        lblFeedbackCustomerAddress.Text = "";
                        lblFeedbackCustomerEmail.Text = "";
                        lblFeedbackCustomerID.Text = "";
                        lblFeedBackCustomerName.Text = "";
                        lblFeedbackEventPerformed.Text = "Kunden har tagits bort!";
                        dataGridView.DataSource = null;
                    }


                }

            }

        }
    }
}
