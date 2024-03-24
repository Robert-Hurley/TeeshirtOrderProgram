namespace RobertsTeeShirtOrderingProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnAddToOrder = new Button();
            btnClearForm = new Button();
            button3 = new Button();
            radSmall = new RadioButton();
            radMedium = new RadioButton();
            radLarge = new RadioButton();
            radXL = new RadioButton();
            radXXL = new RadioButton();
            radXXXL = new RadioButton();
            gbxSize = new GroupBox();
            cbxMonogram = new CheckBox();
            cbxPocket = new CheckBox();
            gbxOptions = new GroupBox();
            tbxColorBar = new TextBox();
            lblOrderTotal = new Label();
            lbxItemsOrdered = new ListBox();
            lblItemsOrdered = new Label();
            gbxSize.SuspendLayout();
            gbxOptions.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 21);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(74, 18);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(179, 23);
            txtQuantity.TabIndex = 1;
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(287, 18);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(105, 76);
            btnAddToOrder.TabIndex = 2;
            btnAddToOrder.Text = "&Add to Order";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.Location = new Point(287, 136);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(105, 76);
            btnClearForm.TabIndex = 3;
            btnClearForm.Text = "&Clear Form";
            btnClearForm.UseVisualStyleBackColor = true;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // button3
            // 
            button3.Location = new Point(287, 254);
            button3.Name = "button3";
            button3.Size = new Size(105, 76);
            button3.TabIndex = 4;
            button3.Text = "Start &New Order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radSmall
            // 
            radSmall.AutoSize = true;
            radSmall.Location = new Point(8, 22);
            radSmall.Name = "radSmall";
            radSmall.Size = new Size(54, 19);
            radSmall.TabIndex = 5;
            radSmall.TabStop = true;
            radSmall.Text = "Small";
            radSmall.UseVisualStyleBackColor = true;
            // 
            // radMedium
            // 
            radMedium.AutoSize = true;
            radMedium.Location = new Point(8, 48);
            radMedium.Name = "radMedium";
            radMedium.Size = new Size(70, 19);
            radMedium.TabIndex = 6;
            radMedium.TabStop = true;
            radMedium.Text = "Medium";
            radMedium.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            radLarge.AutoSize = true;
            radLarge.Location = new Point(8, 74);
            radLarge.Name = "radLarge";
            radLarge.Size = new Size(54, 19);
            radLarge.TabIndex = 7;
            radLarge.TabStop = true;
            radLarge.Text = "Large";
            radLarge.UseVisualStyleBackColor = true;
            // 
            // radXL
            // 
            radXL.AutoSize = true;
            radXL.Location = new Point(8, 100);
            radXL.Name = "radXL";
            radXL.Size = new Size(38, 19);
            radXL.TabIndex = 8;
            radXL.TabStop = true;
            radXL.Text = "XL";
            radXL.UseVisualStyleBackColor = true;
            // 
            // radXXL
            // 
            radXXL.AutoSize = true;
            radXXL.Location = new Point(8, 126);
            radXXL.Name = "radXXL";
            radXXL.Size = new Size(44, 19);
            radXXL.TabIndex = 9;
            radXXL.TabStop = true;
            radXXL.Text = "2XL";
            radXXL.UseVisualStyleBackColor = true;
            // 
            // radXXXL
            // 
            radXXXL.AutoSize = true;
            radXXXL.Location = new Point(8, 152);
            radXXXL.Name = "radXXXL";
            radXXXL.Size = new Size(44, 19);
            radXXXL.TabIndex = 10;
            radXXXL.TabStop = true;
            radXXXL.Text = "3XL";
            radXXXL.UseVisualStyleBackColor = true;
            // 
            // gbxSize
            // 
            gbxSize.Controls.Add(radXXL);
            gbxSize.Controls.Add(radXL);
            gbxSize.Controls.Add(radXXXL);
            gbxSize.Controls.Add(radLarge);
            gbxSize.Controls.Add(radMedium);
            gbxSize.Controls.Add(radSmall);
            gbxSize.Location = new Point(16, 70);
            gbxSize.Name = "gbxSize";
            gbxSize.Size = new Size(237, 178);
            gbxSize.TabIndex = 11;
            gbxSize.TabStop = false;
            gbxSize.Text = "Size";
            // 
            // cbxMonogram
            // 
            cbxMonogram.AutoSize = true;
            cbxMonogram.Location = new Point(9, 21);
            cbxMonogram.Name = "cbxMonogram";
            cbxMonogram.Size = new Size(86, 19);
            cbxMonogram.TabIndex = 12;
            cbxMonogram.Text = "Monogram";
            cbxMonogram.UseVisualStyleBackColor = true;
            // 
            // cbxPocket
            // 
            cbxPocket.AutoSize = true;
            cbxPocket.Location = new Point(9, 46);
            cbxPocket.Name = "cbxPocket";
            cbxPocket.Size = new Size(62, 19);
            cbxPocket.TabIndex = 13;
            cbxPocket.Text = "Pocket";
            cbxPocket.UseVisualStyleBackColor = true;
            // 
            // gbxOptions
            // 
            gbxOptions.Controls.Add(cbxPocket);
            gbxOptions.Controls.Add(cbxMonogram);
            gbxOptions.Location = new Point(16, 254);
            gbxOptions.Name = "gbxOptions";
            gbxOptions.Size = new Size(241, 76);
            gbxOptions.TabIndex = 14;
            gbxOptions.TabStop = false;
            gbxOptions.Text = "Options";
            // 
            // tbxColorBar
            // 
            tbxColorBar.BackColor = SystemColors.MenuHighlight;
            tbxColorBar.BorderStyle = BorderStyle.None;
            tbxColorBar.HideSelection = false;
            tbxColorBar.Location = new Point(12, 336);
            tbxColorBar.Multiline = true;
            tbxColorBar.Name = "tbxColorBar";
            tbxColorBar.ReadOnly = true;
            tbxColorBar.Size = new Size(380, 10);
            tbxColorBar.TabIndex = 15;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderTotal.Location = new Point(12, 358);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(380, 40);
            lblOrderTotal.TabIndex = 16;
            lblOrderTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbxItemsOrdered
            // 
            lbxItemsOrdered.FormattingEnabled = true;
            lbxItemsOrdered.ItemHeight = 15;
            lbxItemsOrdered.Location = new Point(12, 432);
            lbxItemsOrdered.Name = "lbxItemsOrdered";
            lbxItemsOrdered.Size = new Size(380, 214);
            lbxItemsOrdered.TabIndex = 17;
            // 
            // lblItemsOrdered
            // 
            lblItemsOrdered.AutoSize = true;
            lblItemsOrdered.Location = new Point(12, 414);
            lblItemsOrdered.Name = "lblItemsOrdered";
            lblItemsOrdered.Size = new Size(85, 15);
            lblItemsOrdered.TabIndex = 18;
            lblItemsOrdered.Text = "Items Ordered:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 653);
            Controls.Add(lblItemsOrdered);
            Controls.Add(lbxItemsOrdered);
            Controls.Add(lblOrderTotal);
            Controls.Add(tbxColorBar);
            Controls.Add(gbxOptions);
            Controls.Add(gbxSize);
            Controls.Add(button3);
            Controls.Add(btnClearForm);
            Controls.Add(btnAddToOrder);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            gbxSize.ResumeLayout(false);
            gbxSize.PerformLayout();
            gbxOptions.ResumeLayout(false);
            gbxOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnAddToOrder;
        private Button btnClearForm;
        private Button button3;
        private RadioButton radSmall;
        private RadioButton radMedium;
        private RadioButton radLarge;
        private RadioButton radXL;
        private RadioButton radXXL;
        private RadioButton radXXXL;
        private GroupBox gbxSize;
        private CheckBox cbxMonogram;
        private CheckBox cbxPocket;
        private GroupBox gbxOptions;
        private TextBox tbxColorBar;
        private Label lblOrderTotal;
        private ListBox lbxItemsOrdered;
        private Label lblItemsOrdered;
    }
}
