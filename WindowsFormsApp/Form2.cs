//Sales Form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //Sales Form
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }
        //Method to load sales data into the SalesReportForm
        //This method calculates and displays the sales summary based on the given data
        public void LoadSalesData(String[] ArrayFoodItems, String[] ArrayItemTypes, int[,] OpeningStock, int[,] CurrentStock, decimal[,] PriceList)
        {
            bool IsSaleRecorded = false;
            decimal TotalSalesValue = 0;
            decimal ItemSalesValue;
            string SaleDetails;

            for (int LoopFoodItem = 0; LoopFoodItem < OpeningStock.GetLength(0); LoopFoodItem++)
            {
                for (int LoopItemType = 0; LoopItemType < OpeningStock.GetLength(1); LoopItemType++)
                {
                    int SoldQuantity = OpeningStock[LoopFoodItem, LoopItemType] - CurrentStock[LoopFoodItem, LoopItemType];
                    //If items were sold, record the sale and update the total sales value
                    if (SoldQuantity > 0)
                    {
                        IsSaleRecorded = true;
                        ItemSalesValue = SoldQuantity * PriceList[LoopFoodItem, LoopItemType];
                        TotalSalesValue += ItemSalesValue;

                        SaleDetails = $"{ArrayFoodItems[LoopFoodItem]} - {ArrayItemTypes[LoopItemType]}: Sold {SoldQuantity} units at {ItemSalesValue:C2} each";
                        SalesListBox.Items.Add(SaleDetails);
                    }
                }
            }

            if (!IsSaleRecorded)
            {
                SalesListBox.Items.Add("No gourmet delights were sold today. Let's prepare for a tastier tomorrow!");
            }
            else
            {
                //Displaying the summary of sales
                SalesListBox.Items.Add("-------------------------------------------------------------");
                SalesListBox.Items.Add("Gourmet Sales Summary:");
                SalesListBox.Items.Add($"Total Gourmet Sales: {TotalSalesValue:C2}");
                SalesListBox.Items.Add("A flavorful success indeed!");
            }
        }
       //Event handler for the Exit button click
       //Closes the SalesReportForm when clicked
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
