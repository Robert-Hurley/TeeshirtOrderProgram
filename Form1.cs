namespace RobertsTeeShirtOrderingProgram
{
    public partial class Form1 : Form
    {
        // Order Total
        private decimal OrderTotal = 0m;

        // Sizes
        private const decimal SMALL = 10m;
        private const decimal MEDIUM = 10m;
        private const decimal LARGE = 11m;
        private const decimal XL = 11m;
        private const decimal XXL = 12m;
        private const decimal XXXL = 13m;

        // Options 
        private const decimal MONOGRAM = 3m;
        private const decimal POCKET = 2m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtQuantity.Focus();
            lblOrderTotal.Text = string.Empty;
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            int quantity;

            // Error Checking
            if (string.IsNullOrEmpty(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0 || quantity > 1000)
            {
                MessageBox.Show("Please enter a valid quantity between 1 and 1000.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantity.SelectAll();
                txtQuantity.Focus();
                return;
            }

            // Calculate price based on size
            decimal price = GetSelectedSizePrice();
            if (price == 0m)
            {
                MessageBox.Show("Please select a size.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Add additional options
            if (cbxMonogram.Checked)
                price += MONOGRAM;
            if (cbxPocket.Checked)
                price += POCKET;

            // Calculate total price for the order
            decimal totalPrice = price * quantity;

            // Update Order Total
            OrderTotal += totalPrice;
            lblOrderTotal.Text = "Order Total: $" + OrderTotal.ToString();

            // Add item to the list box
            string size = GetSelectedSizeLabel();
            string monogram = cbxMonogram.Checked ? "Yes" : "No";
            string pocket = cbxPocket.Checked ? "Yes" : "No";
            string item = quantity + "  " + size + "Shirt(s). " + " Monogram: " + monogram + "." + "  Pocket: " + pocket + ". " + " Price: $" + totalPrice.ToString();
            lbxItemsOrdered.Items.Add(item);

            // Clear inputs
            txtQuantity.Clear();
            ClearRadioButtons(gbxSize);
            cbxMonogram.Checked = false;
            cbxPocket.Checked = false;

            // Return focus to Quantity textbox
            txtQuantity.Focus();
        }

        // Method to get the selected size price
        private decimal GetSelectedSizePrice()
        {
            if (radSmall.Checked)
                return SMALL;
            else if (radMedium.Checked)
                return MEDIUM;
            else if (radLarge.Checked)
                return LARGE;
            else if (radXL.Checked)
                return XL;
            else if (radXXL.Checked)
                return XXL;
            else if (radXXXL.Checked)
                return XXXL;
            else
                return 0m; // Return 0 if no size is selected
        }

        // Method to get the selected size label
        private string GetSelectedSizeLabel()
        {
            if (radSmall.Checked)
                return "Small";
            else if (radMedium.Checked)
                return "Medium";
            else if (radLarge.Checked)
                return "Large";
            else if (radXL.Checked)
                return "XL";
            else if (radXXL.Checked)
                return "XXL";
            else if (radXXXL.Checked)
                return "XXXL";
            else
                return ""; // Return an empty string if no size is selected
        }

        // Method to clear radio buttons in a group box
        private void ClearRadioButtons(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            // Clear Quantity textbox
            txtQuantity.Clear();

            // Clear radio buttons for sizes
            ClearRadioButtons(gbxSize);

            // Uncheck checkboxes for options
            cbxMonogram.Checked = false;
            cbxPocket.Checked = false;

            // Return focus to Quantity textbox
            txtQuantity.Focus();
        }

        private void ClearRadioButtons(GroupBox groupBox, int size)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ask the user for confirmation
            DialogResult yOrN;
            yOrN = MessageBox.Show("Are you sure you want to start a new order? Existing data will be lost.",
                                                  "Start New Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (yOrN == DialogResult.Yes)
            {
                // Clear the Quantity textbox
                txtQuantity.Clear();

                // Clear all radio buttons for sizes
                ClearRadioButtons(gbxSize);

                // Uncheck the checkboxes for options
                cbxMonogram.Checked = false;
                cbxPocket.Checked = false;

                // Reset the Order Total
                OrderTotal = 0m;
                lblOrderTotal.Text = "Order Total: $0.00";

                // Clear the ListBox
                lbxItemsOrdered.Items.Clear();

                // Return focus to Quantity textbox
                txtQuantity.Focus();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult yOrN;

            yOrN = MessageBox.Show("Are you sure you want to exit the program?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (yOrN == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
