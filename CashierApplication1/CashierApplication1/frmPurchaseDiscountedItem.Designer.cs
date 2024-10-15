namespace CashierApplication1
{
    partial class frmPurchaseDiscountedItem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            totalAmountValueTxt = new Label();
            changeValueTxt = new Label();
            submitBtn = new Button();
            paymentReceivedTxtBx = new TextBox();
            itemTxtBx = new TextBox();
            priceTxtBx = new TextBox();
            discountTxtBx = new TextBox();
            quantityTxtBx = new TextBox();
            computeBtn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 23);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 23);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Discount (%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 78);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 137);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 4;
            label5.Text = "Total amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 167);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 5;
            label6.Text = "Payment Received:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 200);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "Change:";
            label7.Click += label7_Click;
            // 
            // totalAmountValueTxt
            // 
            totalAmountValueTxt.AutoSize = true;
            totalAmountValueTxt.Location = new Point(124, 137);
            totalAmountValueTxt.Name = "totalAmountValueTxt";
            totalAmountValueTxt.Size = new Size(28, 15);
            totalAmountValueTxt.TabIndex = 7;
            totalAmountValueTxt.Text = "0.00";
            // 
            // changeValueTxt
            // 
            changeValueTxt.AutoSize = true;
            changeValueTxt.Location = new Point(124, 200);
            changeValueTxt.Name = "changeValueTxt";
            changeValueTxt.Size = new Size(28, 15);
            changeValueTxt.TabIndex = 8;
            changeValueTxt.Text = "0.00";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(230, 163);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 9;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // paymentReceivedTxtBx
            // 
            paymentReceivedTxtBx.Location = new Point(124, 164);
            paymentReceivedTxtBx.Name = "paymentReceivedTxtBx";
            paymentReceivedTxtBx.Size = new Size(100, 23);
            paymentReceivedTxtBx.TabIndex = 10;
            // 
            // itemTxtBx
            // 
            itemTxtBx.Location = new Point(11, 41);
            itemTxtBx.Name = "itemTxtBx";
            itemTxtBx.Size = new Size(156, 23);
            itemTxtBx.TabIndex = 11;
            // 
            // priceTxtBx
            // 
            priceTxtBx.Location = new Point(55, 75);
            priceTxtBx.Name = "priceTxtBx";
            priceTxtBx.Size = new Size(112, 23);
            priceTxtBx.TabIndex = 12;
            // 
            // discountTxtBx
            // 
            discountTxtBx.Location = new Point(173, 41);
            discountTxtBx.Name = "discountTxtBx";
            discountTxtBx.Size = new Size(100, 23);
            discountTxtBx.TabIndex = 13;
            // 
            // quantityTxtBx
            // 
            quantityTxtBx.Location = new Point(235, 75);
            quantityTxtBx.Name = "quantityTxtBx";
            quantityTxtBx.Size = new Size(61, 23);
            quantityTxtBx.TabIndex = 14;
            // 
            // computeBtn
            // 
            computeBtn.Location = new Point(124, 104);
            computeBtn.Name = "computeBtn";
            computeBtn.Size = new Size(75, 23);
            computeBtn.TabIndex = 15;
            computeBtn.Text = "Compute";
            computeBtn.UseVisualStyleBackColor = true;
            computeBtn.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(318, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(157, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(157, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 231);
            Controls.Add(computeBtn);
            Controls.Add(quantityTxtBx);
            Controls.Add(discountTxtBx);
            Controls.Add(priceTxtBx);
            Controls.Add(itemTxtBx);
            Controls.Add(paymentReceivedTxtBx);
            Controls.Add(submitBtn);
            Controls.Add(changeValueTxt);
            Controls.Add(totalAmountValueTxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPurchaseDiscountedItem";
            Text = "Purchase Discounted Item";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label totalAmountValueTxt;
        private Label changeValueTxt;
        private Button submitBtn;
        private TextBox paymentReceivedTxtBx;
        private TextBox itemTxtBx;
        private TextBox priceTxtBx;
        private TextBox discountTxtBx;
        private TextBox quantityTxtBx;
        private Button computeBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}
