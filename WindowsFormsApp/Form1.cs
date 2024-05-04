/* Created a well-designed application which serves as a management interface for a gourmet food store, 
 * where users can select and add items to a shopping cart, finalize and record transactions, clear selections, 
 * search for specific items or sales data and generate detailed sales and stock reports. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //This class manages the home page of a gourmet food shop application
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        //Global Variables to store food categories, items, types, and their prices
        readonly private static string[] FOODCATEGORIES = { "CLASSIC" , "DELUXE", "ORGANIC", "MINI", "GIFT-PACK", "SAMPLER" };

        readonly private static string[] FOODITEMS = { "Cheese", "Chocolate", "Tea", "Coffee", "Olive Oil",
                                                       "Vinegar", "Jams and Preserves", "Pasta", "Spices",
                                                       "Biscuits and Crackers", "Nuts and Dried Fruits",
                                                       "Sauces and Condiments", "Wines"};

        readonly private static string[] ITEMTYPE = { "Classic", "Deluxe", "Organic", "Mini", "Gift Pack", "Sampler" };

        /* The prices follow these business assumptions: Deluxe is more expensive than Classic, Mini is cheaper than Classic,
           Sampler is the cheapest, Organic is more expensive than Classic but less than Deluxe,
           Gift Pack is the most expensive variation. */
        readonly private static decimal[,] FoodPrices = {
                                                         {7.68M, 11.52M, 9.22M, 5.76M, 13.06M, 4.61M},
                                                         {5.96M, 8.94M, 7.15M, 4.47M, 10.13M, 3.58M},
                                                         {2.41M, 3.62M, 2.89M, 1.81M, 4.1M, 1.45M},
                                                         {6.61M, 9.92M, 7.93M, 4.96M, 11.24M, 3.97M},
                                                         {9.4M, 14.1M, 11.28M, 7.05M, 15.98M, 5.64M},
                                                         {2.66M, 3.99M, 3.19M, 1.99M, 4.52M, 1.6M},
                                                         {5.89M, 8.83M, 7.07M, 4.42M, 10.01M, 3.53M},
                                                         {3.23M, 4.84M, 3.88M, 2.42M, 5.49M, 1.94M},
                                                         {4.59M, 6.88M, 5.51M, 3.44M, 7.8M, 2.75M},
                                                         {2.29M, 3.44M, 2.75M, 1.72M, 3.89M, 1.37M},
                                                         {6.45M, 9.68M, 7.74M, 4.84M, 10.96M, 3.87M},
                                                         {3.7M, 5.55M, 4.44M, 2.78M, 6.29M, 2.22M},
                                                         {13.66M, 20.49M, 16.39M, 10.25M, 23.22M, 8.2M}
                                                         };

        //Stock Variables
        private int[,] FoodItemOpeningStock = new int[FOODITEMS.Length, ITEMTYPE.Length];
        private int[,] FoodItemTempStock = new int[FOODITEMS.Length, ITEMTYPE.Length];
        private int[,] FoodItemLiveStock = new int[FOODITEMS.Length, ITEMTYPE.Length];

        //File and Transaction Information
        private string TransactionID;
        decimal TotalPrice = 0;
        private string FILENAMESTOCK = "InventoryStock.txt";
        private string FILENAMEPOS = "PointOfSale.txt";
        private string CurrentDate;

        //Constants and Formatting
        private const string DATETIMEFORMAT = "MM/dd/yyyy HH:mm:ss";
        private const char COMMASEPARATOR = ',';
        private const int MinimumID = 10000;
        private const int MaximumID = 99999;
        private const int Alphabhets = 26;

        //Transaction Positions
        private const int FIRSTPOS = 3;
        private const int LOCATION = 0;
        private const int DATELOCATION = 1;
        private const int TOTALPRICELOCATION = 2;

        //Event handler for MainForm_Load - This method initializes the form with stock data from files
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Local Variables to store read text and stock levels
            string[] ReadText, StockLevels;
            int LoopRow, LoopColumn;

            try
            {
                //Reading stock data from file
                ReadText = File.ReadAllLines(FILENAMESTOCK);

                //Looping through the food items and initialize stock
                for (LoopRow = 0; LoopRow < FOODITEMS.Length; LoopRow++)
                {
                    StockLevels = ReadText[LoopRow].Split(COMMASEPARATOR);
                    for (LoopColumn = 0; LoopColumn < ITEMTYPE.Length; LoopColumn++)
                    {
                        FoodItemOpeningStock[LoopRow, LoopColumn] = int.Parse(StockLevels[LoopColumn]);
                    }
                }
                //Copying opening stock to temporary and live stock variables
                Copy2DIntegerArray(FoodItemOpeningStock, ref FoodItemTempStock);
                Copy2DIntegerArray(FoodItemOpeningStock, ref FoodItemLiveStock);
            }
            catch (Exception Ex)
            {
                //Displaying an error message if file reading fails
                string ErrorMessage = "An error occurred while loading inventory data: " + Ex.Message;
                MessageBox.Show(ErrorMessage, "Inventory Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Used to copy Opening Stock to Temporary Stock
        private void Copy2DIntegerArray(int[,] FromArray, ref int[,] ToArray)
        {
            //Local Variables 
            int RowIndex, ColumnIndex;

            //Loop through each element of the array and copy it
            for (RowIndex = 0; RowIndex < FromArray.GetLength(0); RowIndex++)
            {
                for (ColumnIndex = 0; ColumnIndex < FromArray.GetLength(1); ColumnIndex++)
                {
                    ToArray[RowIndex, ColumnIndex] = FromArray[RowIndex, ColumnIndex];
                }
            }
        }

        //Event handler for CartButton_Click - This method processes the addition of items to the cart
        private void CartButton_Click(object sender, EventArgs e)
        {
            //Local Variables
            int SelectedType;
            string SizeOfItem;
            int SelectedSize;
            int Quantity;
            decimal TotalPriceItem;
            string FoodItem, OrderDetails;

            SelectedType = InputListBox1.SelectedIndex;
            SelectedSize = InputListBox2.SelectedIndex;

            if (SelectedType != -1)
            {
                if (SelectedSize != -1)
                {
                    Quantity = (int)QuantityInput.Value;
                    if (Quantity > 0)
                    {
                        if (Quantity <= FoodItemTempStock[SelectedType, SelectedSize])
                        {
                            //Processing the cart item selection
                            FoodItem = FOODITEMS[SelectedType];
                            SizeOfItem = ITEMTYPE[SelectedSize];
                            TotalPriceItem = FoodPrices[SelectedType, SelectedSize] * Quantity;
                            FoodItemTempStock[SelectedType, SelectedSize] -= Quantity;
                            //Updating Total Price
                            TotalPrice += TotalPriceItem;

                            OrderDetails = $"{FoodItem}-{SizeOfItem}\t{Quantity}\t{TotalPriceItem.ToString("C2")}";
                            CartOutputListBox.Items.Add(OrderDetails);
                            TotalLabel.Text = TotalPrice.ToString("C2");
                            QuantityInput.Value = 0;
                            InputListBox1.ClearSelected();
                            InputListBox2.ClearSelected();
                            PlaceOrderButton.Enabled = true;
                        }
                        else
                        {
                            //Displaying an error message if requested quantity exceeds available stock
                            string StockMessage = FoodItemTempStock[SelectedType, SelectedSize] == 0 ?
                                "Your selected gourmet item is currently out of stock. Please select a different delicacy." :
                                $"Only {FoodItemTempStock[SelectedType, SelectedSize]} units available. Adjust your quantity accordingly.";

                            MessageBox.Show(StockMessage, "Stock Availability Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QuantityInput.Value = Math.Min(FoodItemTempStock[SelectedType, SelectedSize], 1);
                            QuantityInput.Focus();
                        }
                    }
                    else
                    {
                        //Displaying an error message if the quantity entered is zero or negative
                        MessageBox.Show("Please enter a quantity greater than zero to add to your gourmet cart.", "Quantity Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        QuantityInput.Focus();
                        QuantityInput.Select();
                    }
                }
                else
                {
                    //Displaying an error message if no size variation is selected
                    MessageBox.Show("Please select a size or type for your gourmet selection.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    InputListBox2.Focus();
                }
            }
            else
            {
                //Displaying an error message if no food item is selected
                MessageBox.Show("Please select a gourmet item to add to your cart.", "Item Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputListBox1.Focus();
            }
        }

        //Event handler for changes in the input list box - Updates the subtotal and unit price labels based on selections
        private void InputListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal SubTotal;

            if (InputListBox1.SelectedIndex != -1 && InputListBox2.SelectedIndex != -1 && QuantityInput.Value > 0)
            {
                SubTotal = QuantityInput.Value * FoodPrices[InputListBox1.SelectedIndex, InputListBox2.SelectedIndex];
                SubTotalLabel.Text = SubTotal.ToString("C2");
                UnitPriceLabel.Text = FoodPrices[InputListBox1.SelectedIndex, InputListBox2.SelectedIndex].ToString("C2");
            }
            else
            {
                SubTotalLabel.Text = 0.ToString("C2");
                UnitPriceLabel.Text = 0.ToString("C2");
            }

        }
        //Method to check if a transaction ID already exists in the transaction file - Returns true if the ID is found, otherwise false
        private bool TransactionIDCheck(string TransactionID)
        {
            bool IsFound = false;
            string[] AllReadText;

            try
            {
                //Reading all lines from the file
                AllReadText = File.ReadAllLines(FILENAMEPOS);

                //Checking if the transaction ID already exists in the file
                IsFound = AllReadText.Contains(TransactionID);
            }
            catch (Exception ExceptionDetails)
            {
                string ErrorMessage = $"An error occurred while accessing the gourmet shop's transaction records: {ExceptionDetails.Message}";
                MessageBox.Show(ErrorMessage, "Transaction Record Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return IsFound;
        }

        //Method to generate a unique transaction ID - Combines a timestamp with random letters and numbers for uniqueness
        private string RandomUniqueTransactionIDGenerator()
        {
            //Local Variables
            Random Rand;
            StringBuilder TransactionIDBuilder;
            string Timestamp; 
            char RandomLetter;
            string RandomNum;
            int RandomNumberOrLetter;

            Rand = new Random();
            TransactionIDBuilder = new StringBuilder();
            Timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");

            //Adding a timestamp to add uniqueness
            TransactionIDBuilder.Append(Timestamp);

            do
            {
                //Generating a random number within the specified range
                RandomNum = Rand.Next(MinimumID, MaximumID + 1).ToString();

                //Generating a random uppercase letter from the alphabet
                RandomLetter = (char)('S' + Rand.Next(0, Alphabhets));

                //Combining the letter and number to form part of the transaction ID
                TransactionIDBuilder.Append($"{RandomLetter}{RandomNum}");

                //Appending a few more random alphanumeric characters
                for (int i = 0; i < 3; i++) //Adding 3 more characters
                {
                    RandomNumberOrLetter = Rand.Next(0, 2);

                    if (RandomNumberOrLetter % 2 == 0)
                    {
                        //Appending a digit
                        TransactionIDBuilder.Append(Rand.Next(0, 10).ToString());
                    }
                    else
                    {
                        //Appending an uppercase letter
                        TransactionIDBuilder.Append((char)('A' + Rand.Next(0, Alphabhets)));
                    }
                }
            }
            //Checking if the generated transaction ID is unique
            while (TransactionIDCheck(TransactionIDBuilder.ToString()));

            //Returning the unique transaction ID
            return TransactionIDBuilder.ToString();
        }

        //Method to write a 2D integer array to a file, it is used for updating inventory data
        private void Write2DIntegerArray(string FileName, ref int[,] Record)
        {
            int[] RecordRow = new int[Record.GetLength(1)];
            int LoopRowIndex, LoopColumnIndex;

            try
            {
                using (StreamWriter StreamWriter = File.CreateText(FileName))
                {
                    for (LoopRowIndex = 0; LoopRowIndex < Record.GetLength(0); LoopRowIndex++)
                    {
                        for (LoopColumnIndex = 0; LoopColumnIndex < Record.GetLength(1); LoopColumnIndex++)
                        {
                            RecordRow[LoopColumnIndex] = Record[LoopRowIndex, LoopColumnIndex];
                        }
                        StreamWriter.WriteLine(String.Join(COMMASEPARATOR.ToString(), RecordRow));
                    }
                }
            }
            catch (Exception ExceptionDetails)
            {
                string ErrorMessage = $"An error occurred while updating the gourmet shop's inventory file: {ExceptionDetails.Message}";
                MessageBox.Show(ErrorMessage, "Inventory File Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Event handler for the PlaceOrderButton_Click - Finalizes the order and writes transaction details to a file
        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            //Local Variables
            string[] OrderedItemsArray;
            int LoopForCartItems, LoopForOrderItems;

            //Generating an unique transaction ID and to get the current date
            TransactionID = RandomUniqueTransactionIDGenerator();
            CurrentDate = DateTime.Now.ToString(DATETIMEFORMAT);

            //Initializing an array to hold order details
            OrderedItemsArray = new string[FIRSTPOS + CartOutputListBox.Items.Count];

            //Filling the initial positions with transaction details
            OrderedItemsArray[LOCATION] = TransactionID;
            OrderedItemsArray[DATELOCATION] = CurrentDate;
            OrderedItemsArray[TOTALPRICELOCATION] = TotalLabel.Text;

            //Adding each item from the cart to the order details
            for (LoopForCartItems = 0; LoopForCartItems < CartOutputListBox.Items.Count; LoopForCartItems++)
            {
                OrderedItemsArray[FIRSTPOS + LoopForCartItems] = CartOutputListBox.Items[LoopForCartItems].ToString();
            }

            try
            {
                //Writing the transaction details to the file
                using (StreamWriter StreamWriter = File.AppendText(FILENAMEPOS))
                {
                    StreamWriter.WriteLine($"Transaction ID: {TransactionID}");
                    StreamWriter.WriteLine($"Date: {CurrentDate}");
                    StreamWriter.WriteLine("Ordered Items:");
                    for (LoopForOrderItems = FIRSTPOS; LoopForOrderItems < OrderedItemsArray.Length; LoopForOrderItems++)
                    {
                        StreamWriter.WriteLine(OrderedItemsArray[LoopForOrderItems]);
                    }
                    StreamWriter.WriteLine($"Total Price: {TotalLabel.Text}");
                    StreamWriter.WriteLine();
                }

                //Displaying a success message
                MessageBox.Show("Your gourmet order is confirmed! We are preparing your delicious items with care.", "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ExceptionDetails)
            {
                //Displaying an error message if file processing fails
                MessageBox.Show($"There was a problem processing your order: {ExceptionDetails.Message}", "Order Processing Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Updating the stock and clear the current transaction details
            Copy2DIntegerArray(FoodItemTempStock, ref FoodItemLiveStock);
            Write2DIntegerArray(FILENAMESTOCK, ref FoodItemLiveStock);
            //Clear Button called
            ClearButton_Click(sender, e);
        }

        //Event handler for the Clear button click - Resets the form to its initial state
        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserInputGroupBox.Visible = true;
            CartGroupBox.Visible = true;
            SearchGroupBox.Visible = false;
            InputListBox1.ClearSelected();
            InputListBox2.ClearSelected();
            QuantityInput.Value = 0;

            CartOutputListBox.Items.Clear();
            TotalLabel.Text = "";
            UnitPriceLabel.Text = "";
            SubTotalLabel.Text = "";
            CartButton.Enabled = true;
            PlaceOrderButton.Enabled = false;
            SearchInput.Enabled = false;
            Copy2DIntegerArray(FoodItemLiveStock, ref FoodItemTempStock);
        }

        //Event handler for changing the Transaction ID radio button - Updates the search label and enables/disables the search input
        private void TransactionIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TransactionIDRadioButton.Checked)
            {
                SearchLabel.Text = "Please enter a Transaction ID";
                SearchInput.Enabled = true;
            }
            else if(DateRadioButton.Checked)
            {
                SearchLabel.Text = "Enter enter a Date (MM/DD/YYYY)";
                SearchInput.Enabled = true;
            }
        }

        //Method to find the index of a search term in an array
        private int SearchByIndex(string SearchTerm, string[] ArrayToBeSearched)
        {
            int Position; 

            for (Position = 0; Position < ArrayToBeSearched.Length; Position++)
            {
                if (ArrayToBeSearched[Position].IndexOf(SearchTerm, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    return Position;
                }
            }
            return -1;
        }

        //Method to find the next index of a search term in an array from a given starting point
        private int FindNextIndex(string SearchTerm, string[] ArrayToBeSearched, int StartFromIndex)
        {
            int CurrentIdx; 

            for (CurrentIdx = StartFromIndex; CurrentIdx < ArrayToBeSearched.Length; CurrentIdx++)
            {
                if (ArrayToBeSearched[CurrentIdx].IndexOf(SearchTerm, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    return CurrentIdx;
                }
            }
            return -1; 
        }

        //Event handler for the Search button click - Displays the search group box and hides others
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Disable and enable appropriate GroupBoxes
            SearchGroupBox.Visible = true;
            UserInputGroupBox.Visible = false;
            CartGroupBox.Visible = false;
        }

        //Event handler for the Search2 button click - Performs the search operation based on the user input
        private void Search2Button_Click(object sender, EventArgs e)
        {
            //Local Variables
            string SearchTerm;
            string[] AllLines;
            bool IsDateSearchResultFound = false; // Flag for date-related search results

            //Checking for empty search input
            if (String.IsNullOrEmpty(SearchInput.Text))
            {
                return;
            }

            //Assigning the search term and clear the SearchListBox
            SearchTerm = SearchInput.Text;
            SearchListBox.Items.Clear();

            try
            {
                //Reading all lines from the file
                AllLines = File.ReadAllLines(FILENAMEPOS);

                if (TransactionIDRadioButton.Checked)
                {
                    //Performing search for Transaction ID
                    int LoopIndex = SearchByIndex(SearchTerm, AllLines);

                    if (LoopIndex != -1)
                    {
                        DisplaySearchResults(LoopIndex, AllLines);
                    }
                    else
                    {
                        SearchListBox.Items.Add("No transaction ID matches found in gourmet shop records.");
                    }
                }
                else
                {
                    //Performing date search
                    int LoopIndex = SearchByIndex(SearchTerm, AllLines);

                    while (LoopIndex != -1)
                    {
                        IsDateSearchResultFound = true;
                        LoopIndex--;
                        DisplaySearchResults(LoopIndex, AllLines);

                        //Finding the next index with the search term
                        LoopIndex = FindNextIndex(SearchTerm, AllLines, LoopIndex + 1);
                    }

                    if (!IsDateSearchResultFound)
                    {
                        SearchListBox.Items.Add("No date matches found in gourmet shop records.");
                    }
                }
            }
            catch (Exception ExceptionDetails)
            {
                MessageBox.Show($"An error occurred while accessing the transaction records: {ExceptionDetails.Message}", "Transaction Record Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Event Handlder for Display Button 
        private void DisplaySearchResults(int StartIndex, string[] Lines)
        {
            while (!String.IsNullOrWhiteSpace(Lines[StartIndex]))
            {
                SearchListBox.Items.Add(Lines[StartIndex]);
                StartIndex++;
            }
            SearchListBox.Items.Add("-----------------------------------------------------------------");
        }

        //Even Handler for ClearButton - This clears the inputs and outputs in the search screen
        private void ClearButtonSearch_Click(object sender, EventArgs e)
        {
            SearchInput.Clear();
            SearchListBox.Items.Clear();
            SearchInput.Enabled = false;
        }

        //Event Handler for Sales Report Button - This function is used to connect with the SalesReportForm and send the relevant values there for display
        private void SalesReportButton_Click(object sender, EventArgs e)
        {
            SalesReportForm MySales = new SalesReportForm();
            MySales.LoadSalesData(FOODITEMS, ITEMTYPE, FoodItemOpeningStock, FoodItemLiveStock, FoodPrices);
            MySales.ShowDialog();
            ClearButton_Click(sender, e);
        }

        //Event Handler for Stock Report Button - This function is used to connect with the StockReportForm and send the relevant values there for display 
        private void StockReport_Click(object sender, EventArgs e)
        {
            StockReportForm MyStockForm = new StockReportForm();
            MyStockForm.StockFormLoad(FOODCATEGORIES, FOODITEMS, ITEMTYPE, FoodItemLiveStock);
            MyStockForm.ShowDialog();
            ClearButton_Click(sender, e);
        }

    }
}
