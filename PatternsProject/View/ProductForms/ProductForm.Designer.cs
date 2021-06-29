
namespace PatternsProject.View.ProductForms
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEditProductName = new DevExpress.XtraEditors.TextEdit();
            this.textBoxProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditProductCost = new DevExpress.XtraEditors.TextEdit();
            this.textBoxProductCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditProductEAN = new DevExpress.XtraEditors.TextEdit();
            this.textBoxProductEAN = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.backButtonAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.resetButtonAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProductCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProductEAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductEAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.saveButtonAddProduct);
            this.layoutControl1.Controls.Add(this.resetButtonAddProduct);
            this.layoutControl1.Controls.Add(this.backButtonAddProduct);
            this.layoutControl1.Controls.Add(this.textEditProductEAN);
            this.layoutControl1.Controls.Add(this.textEditProductCost);
            this.layoutControl1.Controls.Add(this.textEditProductName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1094, 300, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(348, 168);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.textBoxProductName,
            this.textBoxProductCost,
            this.textBoxProductEAN,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(348, 168);
            this.Root.TextVisible = false;
            // 
            // textEditProductName
            // 
            this.textEditProductName.Location = new System.Drawing.Point(102, 27);
            this.textEditProductName.Name = "textEditProductName";
            this.textEditProductName.Size = new System.Drawing.Size(234, 20);
            this.textEditProductName.StyleController = this.layoutControl1;
            this.textEditProductName.TabIndex = 4;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Control = this.textEditProductName;
            this.textBoxProductName.Location = new System.Drawing.Point(0, 15);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(328, 24);
            this.textBoxProductName.Text = "Nazwa produktu";
            this.textBoxProductName.TextSize = new System.Drawing.Size(78, 13);
            // 
            // textEditProductCost
            // 
            this.textEditProductCost.Location = new System.Drawing.Point(102, 61);
            this.textEditProductCost.Name = "textEditProductCost";
            this.textEditProductCost.Size = new System.Drawing.Size(234, 20);
            this.textEditProductCost.StyleController = this.layoutControl1;
            this.textEditProductCost.TabIndex = 5;
            // 
            // textBoxProductCost
            // 
            this.textBoxProductCost.Control = this.textEditProductCost;
            this.textBoxProductCost.Location = new System.Drawing.Point(0, 49);
            this.textBoxProductCost.Name = "textBoxProductCost";
            this.textBoxProductCost.Size = new System.Drawing.Size(328, 24);
            this.textBoxProductCost.Text = "Koszt produktu";
            this.textBoxProductCost.TextSize = new System.Drawing.Size(78, 13);
            // 
            // textEditProductEAN
            // 
            this.textEditProductEAN.Location = new System.Drawing.Point(102, 95);
            this.textEditProductEAN.Name = "textEditProductEAN";
            this.textEditProductEAN.Size = new System.Drawing.Size(234, 20);
            this.textEditProductEAN.StyleController = this.layoutControl1;
            this.textEditProductEAN.TabIndex = 6;
            // 
            // textBoxProductEAN
            // 
            this.textBoxProductEAN.Control = this.textEditProductEAN;
            this.textBoxProductEAN.Location = new System.Drawing.Point(0, 83);
            this.textBoxProductEAN.Name = "textBoxProductEAN";
            this.textBoxProductEAN.Size = new System.Drawing.Size(328, 24);
            this.textBoxProductEAN.Text = "EAN";
            this.textBoxProductEAN.TextSize = new System.Drawing.Size(78, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 39);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(328, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 73);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(328, 10);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // backButtonAddProduct
            // 
            this.backButtonAddProduct.Location = new System.Drawing.Point(12, 134);
            this.backButtonAddProduct.Name = "backButtonAddProduct";
            this.backButtonAddProduct.Size = new System.Drawing.Size(112, 22);
            this.backButtonAddProduct.StyleController = this.layoutControl1;
            this.backButtonAddProduct.TabIndex = 7;
            this.backButtonAddProduct.Text = "Powrót";
            this.backButtonAddProduct.Click += new System.EventHandler(this.backButtonAddProduct_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.backButtonAddProduct;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(116, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // resetButtonAddProduct
            // 
            this.resetButtonAddProduct.Location = new System.Drawing.Point(128, 134);
            this.resetButtonAddProduct.Name = "resetButtonAddProduct";
            this.resetButtonAddProduct.Size = new System.Drawing.Size(104, 22);
            this.resetButtonAddProduct.StyleController = this.layoutControl1;
            this.resetButtonAddProduct.TabIndex = 8;
            this.resetButtonAddProduct.Text = "Resetuj";
            this.resetButtonAddProduct.Click += new System.EventHandler(this.resetButtonAddProduct_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.resetButtonAddProduct;
            this.layoutControlItem2.Location = new System.Drawing.Point(116, 122);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(108, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // saveButtonAddProduct
            // 
            this.saveButtonAddProduct.Location = new System.Drawing.Point(236, 134);
            this.saveButtonAddProduct.Name = "saveButtonAddProduct";
            this.saveButtonAddProduct.Size = new System.Drawing.Size(100, 22);
            this.saveButtonAddProduct.StyleController = this.layoutControl1;
            this.saveButtonAddProduct.TabIndex = 9;
            this.saveButtonAddProduct.Text = "Zapisz";
            this.saveButtonAddProduct.Click += new System.EventHandler(this.saveButtonAddProduct_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.saveButtonAddProduct;
            this.layoutControlItem3.Location = new System.Drawing.Point(224, 122);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(328, 15);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 107);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(328, 15);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 168);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ProductForm.IconOptions.SvgImage")));
            this.Name = "ProductForm";
            this.Text = "Produkt";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProductCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProductEAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductEAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEditProductEAN;
        private DevExpress.XtraEditors.TextEdit textEditProductCost;
        private DevExpress.XtraEditors.TextEdit textEditProductName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem textBoxProductName;
        private DevExpress.XtraLayout.LayoutControlItem textBoxProductCost;
        private DevExpress.XtraLayout.LayoutControlItem textBoxProductEAN;
        private DevExpress.XtraEditors.SimpleButton saveButtonAddProduct;
        private DevExpress.XtraEditors.SimpleButton resetButtonAddProduct;
        private DevExpress.XtraEditors.SimpleButton backButtonAddProduct;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}