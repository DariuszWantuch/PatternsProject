
namespace PatternsProject.View.InvoiceForms
{
    partial class InvoiceForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlInvoiceElement = new DevExpress.XtraGrid.GridControl();
            this.gridViewInvoiceElement = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEditAddContractor = new DevExpress.XtraEditors.TextEdit();
            this.Kontrahent = new DevExpress.XtraLayout.LayoutControlItem();
            this.addButtonContractor = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.addButtonProduct = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.resetButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoiceElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoiceElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddContractor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kontrahent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.deleteButton);
            this.layoutControl1.Controls.Add(this.resetButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.backButton);
            this.layoutControl1.Controls.Add(this.addButtonProduct);
            this.layoutControl1.Controls.Add(this.addButtonContractor);
            this.layoutControl1.Controls.Add(this.textEditAddContractor);
            this.layoutControl1.Controls.Add(this.gridControlInvoiceElement);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(498, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.Kontrahent,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(498, 468);
            this.Root.TextVisible = false;
            // 
            // gridControlInvoiceElement
            // 
            this.gridControlInvoiceElement.Location = new System.Drawing.Point(12, 62);
            this.gridControlInvoiceElement.MainView = this.gridViewInvoiceElement;
            this.gridControlInvoiceElement.Name = "gridControlInvoiceElement";
            this.gridControlInvoiceElement.Size = new System.Drawing.Size(474, 368);
            this.gridControlInvoiceElement.TabIndex = 4;
            this.gridControlInvoiceElement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvoiceElement});
            // 
            // gridViewInvoiceElement
            // 
            this.gridViewInvoiceElement.GridControl = this.gridControlInvoiceElement;
            this.gridViewInvoiceElement.GroupPanelText = "Przeciągnij tutaj kolumne aby po niej posegregować";
            this.gridViewInvoiceElement.Name = "gridViewInvoiceElement";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlInvoiceElement;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(478, 372);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // textEditAddContractor
            // 
            this.textEditAddContractor.Location = new System.Drawing.Point(78, 12);
            this.textEditAddContractor.Name = "textEditAddContractor";
            this.textEditAddContractor.Size = new System.Drawing.Size(408, 20);
            this.textEditAddContractor.StyleController = this.layoutControl1;
            this.textEditAddContractor.TabIndex = 5;
            // 
            // Kontrahent
            // 
            this.Kontrahent.Control = this.textEditAddContractor;
            this.Kontrahent.Location = new System.Drawing.Point(0, 0);
            this.Kontrahent.Name = "Kontrahent";
            this.Kontrahent.Size = new System.Drawing.Size(478, 24);
            this.Kontrahent.TextSize = new System.Drawing.Size(54, 13);
            // 
            // addButtonContractor
            // 
            this.addButtonContractor.Location = new System.Drawing.Point(12, 36);
            this.addButtonContractor.Name = "addButtonContractor";
            this.addButtonContractor.Size = new System.Drawing.Size(235, 22);
            this.addButtonContractor.StyleController = this.layoutControl1;
            this.addButtonContractor.TabIndex = 6;
            this.addButtonContractor.Text = "Dodaj kontrahenta";
            this.addButtonContractor.Click += new System.EventHandler(this.addButtonContractor_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.addButtonContractor;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(239, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // addButtonProduct
            // 
            this.addButtonProduct.Location = new System.Drawing.Point(251, 36);
            this.addButtonProduct.Name = "addButtonProduct";
            this.addButtonProduct.Size = new System.Drawing.Size(235, 22);
            this.addButtonProduct.StyleController = this.layoutControl1;
            this.addButtonProduct.TabIndex = 7;
            this.addButtonProduct.Text = "Dodaj produkt";
            this.addButtonProduct.Click += new System.EventHandler(this.addButtonProduct_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.addButtonProduct;
            this.layoutControlItem3.Location = new System.Drawing.Point(239, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(239, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 434);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 22);
            this.backButton.StyleController = this.layoutControl1;
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Powrót";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.backButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 422);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(119, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(370, 434);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Zapisz";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.saveButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(358, 422);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(131, 434);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(116, 22);
            this.resetButton.StyleController = this.layoutControl1;
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Resetuj";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.resetButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(119, 422);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(251, 434);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 22);
            this.deleteButton.StyleController = this.layoutControl1;
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Usuń produkt";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.deleteButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(239, 422);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(119, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 468);
            this.Controls.Add(this.layoutControl1);
            this.Name = "InvoiceForm";
            this.Text = "Dodawanie faktury";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoiceElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoiceElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddContractor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kontrahent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton resetButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton backButton;
        private DevExpress.XtraEditors.SimpleButton addButtonProduct;
        private DevExpress.XtraEditors.SimpleButton addButtonContractor;
        private DevExpress.XtraEditors.TextEdit textEditAddContractor;
        private DevExpress.XtraGrid.GridControl gridControlInvoiceElement;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvoiceElement;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem Kontrahent;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}