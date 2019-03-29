namespace FinalProject
{
    partial class WagOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdress = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblBillingInfo = new System.Windows.Forms.Label();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.texAdress = new System.Windows.Forms.TextBox();
            this.textBillingInfo = new System.Windows.Forms.TextBox();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.lblItemOrdered = new System.Windows.Forms.Label();
            this.grWidget = new System.Windows.Forms.GroupBox();
            this.comboWLarge = new System.Windows.Forms.ComboBox();
            this.comboWMedium = new System.Windows.Forms.ComboBox();
            this.comboWSmall = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textWLargeQ = new System.Windows.Forms.TextBox();
            this.textWMediumQ = new System.Windows.Forms.TextBox();
            this.txtWSmallQ = new System.Windows.Forms.TextBox();
            this.chkWLarge = new System.Windows.Forms.CheckBox();
            this.chkWMedium = new System.Windows.Forms.CheckBox();
            this.chkWSmall = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grGadget = new System.Windows.Forms.GroupBox();
            this.comboGlarge = new System.Windows.Forms.ComboBox();
            this.comboGMedium = new System.Windows.Forms.ComboBox();
            this.comboGSmall = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textGLarge = new System.Windows.Forms.TextBox();
            this.textGMedium = new System.Windows.Forms.TextBox();
            this.textGSmall = new System.Windows.Forms.TextBox();
            this.checkGLarge = new System.Windows.Forms.CheckBox();
            this.checkGMedium = new System.Windows.Forms.CheckBox();
            this.checkGSmall = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.grWidget.SuspendLayout();
            this.grGadget.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(35, 45);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Adress";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(209, 286);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(97, 28);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(35, 9);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(80, 13);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer name";
            // 
            // lblBillingInfo
            // 
            this.lblBillingInfo.AutoSize = true;
            this.lblBillingInfo.Location = new System.Drawing.Point(315, 22);
            this.lblBillingInfo.Name = "lblBillingInfo";
            this.lblBillingInfo.Size = new System.Drawing.Size(88, 13);
            this.lblBillingInfo.TabIndex = 4;
            this.lblBillingInfo.Text = "Billing information";
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(38, 22);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(100, 20);
            this.textCustomerName.TabIndex = 5;
            this.textCustomerName.TextChanged += new System.EventHandler(this.textCustomerName_TextChanged);
            this.textCustomerName.Leave += new System.EventHandler(this.textCustomerName_Leave);
            // 
            // texAdress
            // 
            this.texAdress.Location = new System.Drawing.Point(38, 61);
            this.texAdress.Name = "texAdress";
            this.texAdress.Size = new System.Drawing.Size(100, 20);
            this.texAdress.TabIndex = 6;
            this.texAdress.TextChanged += new System.EventHandler(this.texAdress_TextChanged);
            this.texAdress.Leave += new System.EventHandler(this.texAdress_Leave);
            // 
            // textBillingInfo
            // 
            this.textBillingInfo.Location = new System.Drawing.Point(318, 38);
            this.textBillingInfo.Name = "textBillingInfo";
            this.textBillingInfo.Size = new System.Drawing.Size(100, 20);
            this.textBillingInfo.TabIndex = 7;
            this.textBillingInfo.TextChanged += new System.EventHandler(this.textBillingInfo_TextChanged);
            this.textBillingInfo.Leave += new System.EventHandler(this.textBillingInfo_Leave);
            // 
            // comboItem
            // 
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Items.AddRange(new object[] {
            "Gadgets and Widgets",
            "Gaget",
            "Widget"});
            this.comboItem.Location = new System.Drawing.Point(318, 77);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(121, 21);
            this.comboItem.TabIndex = 8;
            this.comboItem.SelectedIndexChanged += new System.EventHandler(this.comboItem_SelectedIndexChanged_1);
            // 
            // lblItemOrdered
            // 
            this.lblItemOrdered.AutoSize = true;
            this.lblItemOrdered.Location = new System.Drawing.Point(315, 61);
            this.lblItemOrdered.Name = "lblItemOrdered";
            this.lblItemOrdered.Size = new System.Drawing.Size(66, 13);
            this.lblItemOrdered.TabIndex = 9;
            this.lblItemOrdered.Text = "Item ordered";
            // 
            // grWidget
            // 
            this.grWidget.Controls.Add(this.comboWLarge);
            this.grWidget.Controls.Add(this.comboWMedium);
            this.grWidget.Controls.Add(this.comboWSmall);
            this.grWidget.Controls.Add(this.label7);
            this.grWidget.Controls.Add(this.textWLargeQ);
            this.grWidget.Controls.Add(this.textWMediumQ);
            this.grWidget.Controls.Add(this.txtWSmallQ);
            this.grWidget.Controls.Add(this.chkWLarge);
            this.grWidget.Controls.Add(this.chkWMedium);
            this.grWidget.Controls.Add(this.chkWSmall);
            this.grWidget.Controls.Add(this.label5);
            this.grWidget.Controls.Add(this.label6);
            this.grWidget.Location = new System.Drawing.Point(270, 114);
            this.grWidget.Name = "grWidget";
            this.grWidget.Size = new System.Drawing.Size(251, 150);
            this.grWidget.TabIndex = 10;
            this.grWidget.TabStop = false;
            this.grWidget.Text = "Widget";
            // 
            // comboWLarge
            // 
            this.comboWLarge.Enabled = false;
            this.comboWLarge.FormattingEnabled = true;
            this.comboWLarge.Items.AddRange(new object[] {
            "Plain",
            "Plated",
            "Painted"});
            this.comboWLarge.Location = new System.Drawing.Point(185, 83);
            this.comboWLarge.Name = "comboWLarge";
            this.comboWLarge.Size = new System.Drawing.Size(53, 21);
            this.comboWLarge.TabIndex = 22;
            this.comboWLarge.SelectedIndexChanged += new System.EventHandler(this.comboWLarge_SelectedIndexChanged);
            // 
            // comboWMedium
            // 
            this.comboWMedium.Enabled = false;
            this.comboWMedium.FormattingEnabled = true;
            this.comboWMedium.Items.AddRange(new object[] {
            "Plain",
            "Painted",
            "Plated"});
            this.comboWMedium.Location = new System.Drawing.Point(126, 83);
            this.comboWMedium.Name = "comboWMedium";
            this.comboWMedium.Size = new System.Drawing.Size(54, 21);
            this.comboWMedium.TabIndex = 21;
            this.comboWMedium.SelectedIndexChanged += new System.EventHandler(this.comboWMedium_SelectedIndexChanged);
            // 
            // comboWSmall
            // 
            this.comboWSmall.Enabled = false;
            this.comboWSmall.FormattingEnabled = true;
            this.comboWSmall.Items.AddRange(new object[] {
            "Plain",
            "Painted",
            "Plated"});
            this.comboWSmall.Location = new System.Drawing.Point(69, 83);
            this.comboWSmall.Name = "comboWSmall";
            this.comboWSmall.Size = new System.Drawing.Size(51, 21);
            this.comboWSmall.TabIndex = 20;
            this.comboWSmall.SelectedIndexChanged += new System.EventHandler(this.comboWSmall_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Color ";
            // 
            // textWLargeQ
            // 
            this.textWLargeQ.Enabled = false;
            this.textWLargeQ.Location = new System.Drawing.Point(185, 48);
            this.textWLargeQ.Name = "textWLargeQ";
            this.textWLargeQ.Size = new System.Drawing.Size(53, 20);
            this.textWLargeQ.TabIndex = 15;
            this.textWLargeQ.TextChanged += new System.EventHandler(this.textWLargeQ_TextChanged);
            this.textWLargeQ.Leave += new System.EventHandler(this.textWLargeQ_Leave);
            // 
            // textWMediumQ
            // 
            this.textWMediumQ.Enabled = false;
            this.textWMediumQ.Location = new System.Drawing.Point(126, 48);
            this.textWMediumQ.Name = "textWMediumQ";
            this.textWMediumQ.Size = new System.Drawing.Size(54, 20);
            this.textWMediumQ.TabIndex = 14;
            this.textWMediumQ.TextChanged += new System.EventHandler(this.textWMediumQ_TextChanged);
            this.textWMediumQ.Leave += new System.EventHandler(this.textWMediumQ_Leave);
            // 
            // txtWSmallQ
            // 
            this.txtWSmallQ.Enabled = false;
            this.txtWSmallQ.Location = new System.Drawing.Point(69, 49);
            this.txtWSmallQ.Name = "txtWSmallQ";
            this.txtWSmallQ.Size = new System.Drawing.Size(51, 20);
            this.txtWSmallQ.TabIndex = 13;
            this.txtWSmallQ.TextChanged += new System.EventHandler(this.txtWSmallQ_TextChanged);
            this.txtWSmallQ.Leave += new System.EventHandler(this.txtWSmallQ_Leave);
            // 
            // chkWLarge
            // 
            this.chkWLarge.AutoSize = true;
            this.chkWLarge.Location = new System.Drawing.Point(185, 26);
            this.chkWLarge.Name = "chkWLarge";
            this.chkWLarge.Size = new System.Drawing.Size(53, 17);
            this.chkWLarge.TabIndex = 12;
            this.chkWLarge.Text = "Large";
            this.chkWLarge.UseVisualStyleBackColor = true;
            this.chkWLarge.CheckedChanged += new System.EventHandler(this.chkWLarge_CheckedChanged);
            // 
            // chkWMedium
            // 
            this.chkWMedium.AutoSize = true;
            this.chkWMedium.Location = new System.Drawing.Point(126, 25);
            this.chkWMedium.Name = "chkWMedium";
            this.chkWMedium.Size = new System.Drawing.Size(63, 17);
            this.chkWMedium.TabIndex = 11;
            this.chkWMedium.Text = "Medium";
            this.chkWMedium.UseVisualStyleBackColor = true;
            this.chkWMedium.CheckedChanged += new System.EventHandler(this.chkWMedium_CheckedChanged);
            // 
            // chkWSmall
            // 
            this.chkWSmall.AutoSize = true;
            this.chkWSmall.Location = new System.Drawing.Point(69, 25);
            this.chkWSmall.Name = "chkWSmall";
            this.chkWSmall.Size = new System.Drawing.Size(51, 17);
            this.chkWSmall.TabIndex = 10;
            this.chkWSmall.Text = "Small";
            this.chkWSmall.UseVisualStyleBackColor = true;
            this.chkWSmall.CheckedChanged += new System.EventHandler(this.chkWSmall_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Size";
            // 
            // grGadget
            // 
            this.grGadget.Controls.Add(this.comboGlarge);
            this.grGadget.Controls.Add(this.comboGMedium);
            this.grGadget.Controls.Add(this.comboGSmall);
            this.grGadget.Controls.Add(this.label8);
            this.grGadget.Controls.Add(this.textGLarge);
            this.grGadget.Controls.Add(this.textGMedium);
            this.grGadget.Controls.Add(this.textGSmall);
            this.grGadget.Controls.Add(this.checkGLarge);
            this.grGadget.Controls.Add(this.checkGMedium);
            this.grGadget.Controls.Add(this.checkGSmall);
            this.grGadget.Controls.Add(this.label4);
            this.grGadget.Controls.Add(this.lblSize);
            this.grGadget.Location = new System.Drawing.Point(12, 114);
            this.grGadget.Name = "grGadget";
            this.grGadget.Size = new System.Drawing.Size(252, 150);
            this.grGadget.TabIndex = 11;
            this.grGadget.TabStop = false;
            this.grGadget.Text = "Gadget";
            // 
            // comboGlarge
            // 
            this.comboGlarge.Enabled = false;
            this.comboGlarge.FormattingEnabled = true;
            this.comboGlarge.Items.AddRange(new object[] {
            "Plain",
            "Plated",
            "Paineted"});
            this.comboGlarge.Location = new System.Drawing.Point(191, 67);
            this.comboGlarge.Name = "comboGlarge";
            this.comboGlarge.Size = new System.Drawing.Size(53, 21);
            this.comboGlarge.TabIndex = 26;
            this.comboGlarge.SelectedIndexChanged += new System.EventHandler(this.comboGlarge_SelectedIndexChanged);
            // 
            // comboGMedium
            // 
            this.comboGMedium.Enabled = false;
            this.comboGMedium.FormattingEnabled = true;
            this.comboGMedium.Items.AddRange(new object[] {
            "Plain",
            "Painted",
            "Plated"});
            this.comboGMedium.Location = new System.Drawing.Point(132, 67);
            this.comboGMedium.Name = "comboGMedium";
            this.comboGMedium.Size = new System.Drawing.Size(54, 21);
            this.comboGMedium.TabIndex = 25;
            this.comboGMedium.SelectedIndexChanged += new System.EventHandler(this.comboGMedium_SelectedIndexChanged);
            // 
            // comboGSmall
            // 
            this.comboGSmall.Enabled = false;
            this.comboGSmall.FormattingEnabled = true;
            this.comboGSmall.Items.AddRange(new object[] {
            "Painted",
            "Plain",
            "Plated"});
            this.comboGSmall.Location = new System.Drawing.Point(75, 67);
            this.comboGSmall.Name = "comboGSmall";
            this.comboGSmall.Size = new System.Drawing.Size(51, 21);
            this.comboGSmall.TabIndex = 24;
            this.comboGSmall.SelectedIndexChanged += new System.EventHandler(this.comboGSmall_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Color ";
            // 
            // textGLarge
            // 
            this.textGLarge.Enabled = false;
            this.textGLarge.Location = new System.Drawing.Point(191, 38);
            this.textGLarge.Name = "textGLarge";
            this.textGLarge.Size = new System.Drawing.Size(53, 20);
            this.textGLarge.TabIndex = 7;
            this.textGLarge.TextChanged += new System.EventHandler(this.textGLarge_TextChanged);
            this.textGLarge.Leave += new System.EventHandler(this.textGlarge_Leave);
            // 
            // textGMedium
            // 
            this.textGMedium.Enabled = false;
            this.textGMedium.Location = new System.Drawing.Point(132, 38);
            this.textGMedium.Name = "textGMedium";
            this.textGMedium.Size = new System.Drawing.Size(54, 20);
            this.textGMedium.TabIndex = 6;
            this.textGMedium.TextChanged += new System.EventHandler(this.textGMedium_TextChanged);
            this.textGMedium.Leave += new System.EventHandler(this.textGMedium_Leave);
            // 
            // textGSmall
            // 
            this.textGSmall.Enabled = false;
            this.textGSmall.Location = new System.Drawing.Point(75, 39);
            this.textGSmall.Name = "textGSmall";
            this.textGSmall.Size = new System.Drawing.Size(51, 20);
            this.textGSmall.TabIndex = 5;
            this.textGSmall.Click += new System.EventHandler(this.textGSmall_Click);
            this.textGSmall.TextChanged += new System.EventHandler(this.textGSmall_TextChanged);
            this.textGSmall.Leave += new System.EventHandler(this.textGSmall_Leave);
            // 
            // checkGLarge
            // 
            this.checkGLarge.AutoSize = true;
            this.checkGLarge.Location = new System.Drawing.Point(191, 16);
            this.checkGLarge.Name = "checkGLarge";
            this.checkGLarge.Size = new System.Drawing.Size(53, 17);
            this.checkGLarge.TabIndex = 4;
            this.checkGLarge.Text = "Large";
            this.checkGLarge.UseVisualStyleBackColor = true;
            this.checkGLarge.CheckedChanged += new System.EventHandler(this.checkGLarge_CheckedChanged);
            // 
            // checkGMedium
            // 
            this.checkGMedium.AutoSize = true;
            this.checkGMedium.Location = new System.Drawing.Point(132, 15);
            this.checkGMedium.Name = "checkGMedium";
            this.checkGMedium.Size = new System.Drawing.Size(63, 17);
            this.checkGMedium.TabIndex = 3;
            this.checkGMedium.Text = "Medium";
            this.checkGMedium.UseVisualStyleBackColor = true;
            this.checkGMedium.CheckedChanged += new System.EventHandler(this.checkGMedium_CheckedChanged);
            // 
            // checkGSmall
            // 
            this.checkGSmall.AutoSize = true;
            this.checkGSmall.Location = new System.Drawing.Point(75, 15);
            this.checkGSmall.Name = "checkGSmall";
            this.checkGSmall.Size = new System.Drawing.Size(51, 17);
            this.checkGSmall.TabIndex = 2;
            this.checkGSmall.Text = "Small";
            this.checkGSmall.UseVisualStyleBackColor = true;
            this.checkGSmall.CheckedChanged += new System.EventHandler(this.checkGSmall_CheckedChanged);
            this.checkGSmall.Click += new System.EventHandler(this.checkGSmall_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 16);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // WagOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 325);
            this.Controls.Add(this.grGadget);
            this.Controls.Add(this.grWidget);
            this.Controls.Add(this.lblItemOrdered);
            this.Controls.Add(this.comboItem);
            this.Controls.Add(this.textBillingInfo);
            this.Controls.Add(this.texAdress);
            this.Controls.Add(this.textCustomerName);
            this.Controls.Add(this.lblBillingInfo);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.lblAdress);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WagOrderForm";
            this.Text = "Wag Corporation ";
            this.grWidget.ResumeLayout(false);
            this.grWidget.PerformLayout();
            this.grGadget.ResumeLayout(false);
            this.grGadget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblBillingInfo;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.TextBox texAdress;
        private System.Windows.Forms.TextBox textBillingInfo;
        private System.Windows.Forms.ComboBox comboItem;
        private System.Windows.Forms.Label lblItemOrdered;
        private System.Windows.Forms.GroupBox grWidget;
        private System.Windows.Forms.TextBox textWLargeQ;
        private System.Windows.Forms.TextBox textWMediumQ;
        private System.Windows.Forms.TextBox txtWSmallQ;
        private System.Windows.Forms.CheckBox chkWLarge;
        private System.Windows.Forms.CheckBox chkWMedium;
        private System.Windows.Forms.CheckBox chkWSmall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grGadget;
        private System.Windows.Forms.TextBox textGLarge;
        private System.Windows.Forms.TextBox textGMedium;
        private System.Windows.Forms.TextBox textGSmall;
        private System.Windows.Forms.CheckBox checkGLarge;
        private System.Windows.Forms.CheckBox checkGMedium;
        private System.Windows.Forms.CheckBox checkGSmall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboWLarge;
        private System.Windows.Forms.ComboBox comboWMedium;
        private System.Windows.Forms.ComboBox comboWSmall;
        private System.Windows.Forms.ComboBox comboGlarge;
        private System.Windows.Forms.ComboBox comboGMedium;
        private System.Windows.Forms.ComboBox comboGSmall;
        private System.Windows.Forms.Label label8;
    }
}

