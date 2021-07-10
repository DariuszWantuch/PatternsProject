
namespace PatternsProject.View.InvoiceForms
{
    partial class AddContractorForm
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.addButtonProduct = new DevExpress.XtraEditors.SimpleButton();
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlContractor = new DevExpress.XtraGrid.GridControl();
            this.contractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewContractor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.addButtonProduct);
            this.layoutControl1.Controls.Add(this.backButton);
            this.layoutControl1.Controls.Add(this.gridControlContractor);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(898, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // addButtonProduct
            // 
            this.addButtonProduct.Location = new System.Drawing.Point(451, 434);
            this.addButtonProduct.Name = "addButtonProduct";
            this.addButtonProduct.Size = new System.Drawing.Size(435, 22);
            this.addButtonProduct.StyleController = this.layoutControl1;
            this.addButtonProduct.TabIndex = 6;
            this.addButtonProduct.Text = "Dodaj kontrahenta";
            this.addButtonProduct.Click += new System.EventHandler(this.addButtonProduct_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 434);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(435, 22);
            this.backButton.StyleController = this.layoutControl1;
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Powrót";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gridControlContractor
            // 
            this.gridControlContractor.DataSource = this.contractorBindingSource;
            this.gridControlContractor.Location = new System.Drawing.Point(12, 12);
            this.gridControlContractor.MainView = this.gridViewContractor;
            this.gridControlContractor.Name = "gridControlContractor";
            this.gridControlContractor.Size = new System.Drawing.Size(874, 418);
            this.gridControlContractor.TabIndex = 4;
            this.gridControlContractor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContractor});
            // 
            // gridViewContractor
            // 
            this.gridViewContractor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNIP,
            this.colName,
            this.colEmail,
            this.colPostalCode,
            this.colCity,
            this.colStreet,
            this.colPhone,
            this.colInvoices});
            this.gridViewContractor.GridControl = this.gridControlContractor;
            this.gridViewContractor.GroupPanelText = "Przeciągnij kolumnę tutaj aby po niej posegregować";
            this.gridViewContractor.Name = "gridViewContractor";
            this.gridViewContractor.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colNIP
            // 
            this.colNIP.FieldName = "NIP";
            this.colNIP.Name = "colNIP";
            this.colNIP.Visible = true;
            this.colNIP.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Akronim";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            // 
            // colPostalCode
            // 
            this.colPostalCode.Caption = "Kod pocztowy";
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Visible = true;
            this.colPostalCode.VisibleIndex = 3;
            // 
            // colCity
            // 
            this.colCity.Caption = "Miasto";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 4;
            // 
            // colStreet
            // 
            this.colStreet.Caption = "Ulica";
            this.colStreet.FieldName = "Street";
            this.colStreet.Name = "colStreet";
            this.colStreet.Visible = true;
            this.colStreet.VisibleIndex = 5;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Telefon";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 6;
            // 
            // colInvoices
            // 
            this.colInvoices.FieldName = "Invoices";
            this.colInvoices.Name = "colInvoices";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(898, 468);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlContractor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(878, 422);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.backButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 422);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(439, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.addButtonProduct;
            this.layoutControlItem3.Location = new System.Drawing.Point(439, 422);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(439, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // AddContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 468);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddContractorForm";
            this.Text = "Dodawanie kontrahenta";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton addButtonProduct;
        private DevExpress.XtraEditors.SimpleButton backButton;
        private DevExpress.XtraGrid.GridControl gridControlContractor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContractor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource contractorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNIP;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colStreet;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoices;
    }
}