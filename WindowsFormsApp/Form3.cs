//Stock Form
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class StockReportForm : Form
    {
        public StockReportForm()
        {
            InitializeComponent();
        }
        //Method to load and generate the stock report based on current stock data
        //This method creates a detailed stock report and displays it on the form
        public void StockFormLoad(String[] Size, String[] FoodItems, String[] ItemType, int[,] CurrentStock)
        {
            string CurrentDate = DateTime.Now.ToString("MM-dd-yyyy");
            string CurrentTime = DateTime.Now.ToString("HH:mm:ss");
            string StockReportPath = "StockReport-" + CurrentDate + ".txt";
            List<string> StockReportLines = new List<string>();
            string FirstRow = String.Join("\t", Size);
            string Row;

            StockReportLines.Add($"Date Generated: {CurrentDate}\t\tTime Generated: {CurrentTime}");
            StockReportLines.Add("\n");
            StockReportLines.Add(FirstRow);
            StockReportLines.Add("\n");

            for (int LoopFoodItem = 0; LoopFoodItem < FoodItems.Length; LoopFoodItem++)
            {
                Row = FoodItems[LoopFoodItem];
                for (int LoopItemType = 0; LoopItemType < ItemType.Length; LoopItemType++)
                {
                    Row += "\t" + CurrentStock[LoopFoodItem, LoopItemType];
                }
                StockReportLines.Add(Row);
            }

            try
            {
                File.WriteAllLines(StockReportPath, StockReportLines);
            }
            catch (Exception ExceptionDetails)
            {
                MessageBox.Show($"An error occurred while creating the gourmet shop's stock report: {ExceptionDetails.Message}", "Stock Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Populate StockListBox with current stock details
            PopulateStockListBox(FoodItems, ItemType, CurrentStock);
        }

        //Method to populate the StockListBox with the current stock details
        //This method formats and displays the stock data in the list box
        private void PopulateStockListBox(String[] FoodItems, String[] ItemType, int[,] CurrentStock)
        {
            string Row;
            for (int LoopFoodItem = 0; LoopFoodItem < FoodItems.Length; LoopFoodItem++)
            {
                Row = "";
                for (int LoopItemType = 0; LoopItemType < ItemType.Length; LoopItemType++)
                {
                    Row += "\t" + CurrentStock[LoopFoodItem, LoopItemType];
                }
                StockListBox.Items.Add(Row);
            }
        }
        //Event handler for the Exit button click
        //Closes the StockReportForm when clicked
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
