namespace ConsignmentShopUI
{
  partial class ConsignmentShop
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
      this.headerText = new System.Windows.Forms.Label();
      this.itemsListBox = new System.Windows.Forms.ListBox();
      this.itemsListBoxLabel = new System.Windows.Forms.Label();
      this.addToCartButton = new System.Windows.Forms.Button();
      this.shoppingCartListBoxLabel = new System.Windows.Forms.Label();
      this.shoppingCartListBox = new System.Windows.Forms.ListBox();
      this.makePurchaseButton = new System.Windows.Forms.Button();
      this.vendorListBoxLabel = new System.Windows.Forms.Label();
      this.vendorListBox = new System.Windows.Forms.ListBox();
      this.storeProfitLabel = new System.Windows.Forms.Label();
      this.storeProfitValue = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // headerText
      // 
      this.headerText.AutoSize = true;
      this.headerText.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.headerText.Location = new System.Drawing.Point(61, 43);
      this.headerText.Name = "headerText";
      this.headerText.Size = new System.Drawing.Size(334, 32);
      this.headerText.TabIndex = 0;
      this.headerText.Text = "Consignment Shop";
      // 
      // itemsListBox
      // 
      this.itemsListBox.FormattingEnabled = true;
      this.itemsListBox.ItemHeight = 24;
      this.itemsListBox.Location = new System.Drawing.Point(61, 160);
      this.itemsListBox.Name = "itemsListBox";
      this.itemsListBox.Size = new System.Drawing.Size(502, 364);
      this.itemsListBox.TabIndex = 1;
      // 
      // itemsListBoxLabel
      // 
      this.itemsListBoxLabel.AutoSize = true;
      this.itemsListBoxLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.itemsListBoxLabel.Location = new System.Drawing.Point(61, 133);
      this.itemsListBoxLabel.Name = "itemsListBoxLabel";
      this.itemsListBoxLabel.Size = new System.Drawing.Size(175, 24);
      this.itemsListBoxLabel.TabIndex = 2;
      this.itemsListBoxLabel.Text = "Store Items";
      // 
      // addToCartButton
      // 
      this.addToCartButton.Location = new System.Drawing.Point(584, 301);
      this.addToCartButton.Name = "addToCartButton";
      this.addToCartButton.Size = new System.Drawing.Size(216, 34);
      this.addToCartButton.TabIndex = 3;
      this.addToCartButton.Text = "Add To Cart ->";
      this.addToCartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.addToCartButton.UseVisualStyleBackColor = true;
      this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
      // 
      // shoppingCartListBoxLabel
      // 
      this.shoppingCartListBoxLabel.AutoSize = true;
      this.shoppingCartListBoxLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.shoppingCartListBoxLabel.Location = new System.Drawing.Point(821, 133);
      this.shoppingCartListBoxLabel.Name = "shoppingCartListBoxLabel";
      this.shoppingCartListBoxLabel.Size = new System.Drawing.Size(205, 24);
      this.shoppingCartListBoxLabel.TabIndex = 5;
      this.shoppingCartListBoxLabel.Text = "Shopping Cart";
      // 
      // shoppingCartListBox
      // 
      this.shoppingCartListBox.FormattingEnabled = true;
      this.shoppingCartListBox.ItemHeight = 24;
      this.shoppingCartListBox.Location = new System.Drawing.Point(821, 160);
      this.shoppingCartListBox.Name = "shoppingCartListBox";
      this.shoppingCartListBox.Size = new System.Drawing.Size(502, 364);
      this.shoppingCartListBox.TabIndex = 4;
      // 
      // makePurchaseButton
      // 
      this.makePurchaseButton.Location = new System.Drawing.Point(1122, 551);
      this.makePurchaseButton.Name = "makePurchaseButton";
      this.makePurchaseButton.Size = new System.Drawing.Size(201, 34);
      this.makePurchaseButton.TabIndex = 6;
      this.makePurchaseButton.Text = "Make Purchase";
      this.makePurchaseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.makePurchaseButton.UseVisualStyleBackColor = true;
      this.makePurchaseButton.Click += new System.EventHandler(this.makePurchaseButton_Click);
      // 
      // vendorListBoxLabel
      // 
      this.vendorListBoxLabel.AutoSize = true;
      this.vendorListBoxLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.vendorListBoxLabel.Location = new System.Drawing.Point(61, 624);
      this.vendorListBoxLabel.Name = "vendorListBoxLabel";
      this.vendorListBoxLabel.Size = new System.Drawing.Size(115, 24);
      this.vendorListBoxLabel.TabIndex = 8;
      this.vendorListBoxLabel.Text = "Vendors";
      // 
      // vendorListBox
      // 
      this.vendorListBox.FormattingEnabled = true;
      this.vendorListBox.ItemHeight = 24;
      this.vendorListBox.Location = new System.Drawing.Point(61, 651);
      this.vendorListBox.Name = "vendorListBox";
      this.vendorListBox.Size = new System.Drawing.Size(502, 364);
      this.vendorListBox.TabIndex = 7;
      // 
      // storeProfitLabel
      // 
      this.storeProfitLabel.AutoSize = true;
      this.storeProfitLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.storeProfitLabel.Location = new System.Drawing.Point(821, 624);
      this.storeProfitLabel.Name = "storeProfitLabel";
      this.storeProfitLabel.Size = new System.Drawing.Size(205, 24);
      this.storeProfitLabel.TabIndex = 10;
      this.storeProfitLabel.Text = "Store Profit:";
      // 
      // storeProfitValue
      // 
      this.storeProfitValue.AutoSize = true;
      this.storeProfitValue.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.storeProfitValue.Location = new System.Drawing.Point(1051, 624);
      this.storeProfitValue.Name = "storeProfitValue";
      this.storeProfitValue.Size = new System.Drawing.Size(85, 24);
      this.storeProfitValue.TabIndex = 11;
      this.storeProfitValue.Text = "$0.00";
      // 
      // ConsignmentShop
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1390, 1027);
      this.Controls.Add(this.storeProfitValue);
      this.Controls.Add(this.storeProfitLabel);
      this.Controls.Add(this.vendorListBoxLabel);
      this.Controls.Add(this.vendorListBox);
      this.Controls.Add(this.makePurchaseButton);
      this.Controls.Add(this.shoppingCartListBoxLabel);
      this.Controls.Add(this.shoppingCartListBox);
      this.Controls.Add(this.addToCartButton);
      this.Controls.Add(this.itemsListBoxLabel);
      this.Controls.Add(this.itemsListBox);
      this.Controls.Add(this.headerText);
      this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "ConsignmentShop";
      this.Text = "Consignment Shop";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label headerText;
    private ListBox itemsListBox;
    private Label itemsListBoxLabel;
    private Button addToCartButton;
    private Label shoppingCartListBoxLabel;
    private ListBox shoppingCartListBox;
    private Button makePurchaseButton;
    private Label vendorListBoxLabel;
    private ListBox vendorListBox;
    private Label storeProfitLabel;
    private Label storeProfitValue;
  }
}