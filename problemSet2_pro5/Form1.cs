using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemSet2_pro5
{
    public partial class PriceCalculatorForm : Form
    {
        public PriceCalculatorForm()
        {
            totalPrice = 0;
            tempPrice = 0;
            rowDoubleClicked = false;
            currentIndexOfRowToUpdate = 0;
            InitializeComponent();
        }


        private int tempPrice;
        private int totalPrice;
        private bool rowDoubleClicked;
        private int currentIndexOfRowToUpdate;

       

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            updateButton.Enabled = false;
            addToDataGridViewButton.Enabled = false;
            productDetailsDataGridView.Rows.Clear();
            payValueLabel.Text = "0";
            totalPrice = 0;
            tempPrice = 0;
        }

        private void addToDataGridViewButton_Click_1(object sender, EventArgs e)
        {

            int itemCount = Convert.ToInt32(numbetOfItemsTextBox.Text);

            char[] splitChar = { '[', '(' };



            {
                string[] name = productNameAndPriceComboBox.SelectedItem.ToString().Split(splitChar);
                string[] priceInComboboxList = name[1].Split(' ');

                {
                    tempPrice = itemCount * Convert.ToInt32(priceInComboboxList[0]);

                    productDetailsDataGridView.Rows.Add(name[0], priceInComboboxList[0], tempPrice.ToString());
                    totalPrice += tempPrice;
                    payValueLabel.Text = totalPrice.ToString();

                }




            }

            numbetOfItemsTextBox.Text = "";
            productNameAndPriceComboBox.Text = "";
        }

        private void PriceCalculatorForm_Load_1(object sender, EventArgs e)
        {
            addToDataGridViewButton.Enabled = false;
            updateButton.Enabled = false;
        }

        private void productNameAndPriceComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            addToDataGridViewButton.Enabled = true;
        }

        private void productDetailsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("clicked");
        }

        private void productDetailsDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //string show = "Product Name :"
            //    +productDetailsDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "\n"
            //    +"Unit Price :"          
            //    + productDetailsDataGridView.SelectedRows[0].Cells[1].Value + "\n"
            //    +"Total Amount :"
            //    + productDetailsDataGridView.SelectedRows[0].Cells[2].Value;




            //MessageBox.Show(show);

            addToDataGridViewButton.Enabled = false;
            updateButton.Enabled = true;

            productNameAndPriceComboBox.Text = productDetailsDataGridView.SelectedRows[0].Cells[0].Value.ToString() +
                                               " ["+productDetailsDataGridView.SelectedRows[0].Cells[1]
                                                   .Value.ToString()+" Tk]";
               
            numbetOfItemsTextBox.Text = (Convert.ToInt32(productDetailsDataGridView
                .SelectedRows[0].Cells[2].Value)/Convert.ToInt32(productDetailsDataGridView.SelectedRows[0].Cells[1]
                                                   .Value)).ToString();


            rowDoubleClicked = true;
            currentIndexOfRowToUpdate = productDetailsDataGridView.SelectedRows[0].Index;
            //MessageBox.Show(productDetailsDataGridView.SelectedRows[0].Index.ToString());
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            updateButton.Enabled = false;
            addToDataGridViewButton.Enabled = true;



            int itemCount = 0;
            int olderPrice = 0;

            if (rowDoubleClicked == true)
            {
                char[] splitChar = {'[', '('};




                string[] name = productNameAndPriceComboBox.Text.Split(splitChar);
                string[] priceInComboboxList = name[1].Split(' ');

                olderPrice = Convert.ToInt32(productDetailsDataGridView.Rows[currentIndexOfRowToUpdate]
                    .Cells[2].Value);


                itemCount = Convert.ToInt32(numbetOfItemsTextBox.Text);

                tempPrice = itemCount*Convert.ToInt32(priceInComboboxList[0]);





                productDetailsDataGridView.Rows[currentIndexOfRowToUpdate]
                    .Cells[0].Value = name[0].ToString();
                productDetailsDataGridView.Rows[currentIndexOfRowToUpdate]
                    .Cells[1].Value = priceInComboboxList[0];
                productDetailsDataGridView.Rows[currentIndexOfRowToUpdate]
                    .Cells[2].Value = tempPrice.ToString();


                totalPrice = Convert.ToInt32(payValueLabel.Text)-olderPrice + tempPrice;


                payValueLabel.Text = totalPrice.ToString();

            }
        }

       
    }
}
