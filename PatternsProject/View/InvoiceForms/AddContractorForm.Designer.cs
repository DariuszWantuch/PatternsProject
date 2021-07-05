
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlContractor = new DevExpress.XtraGrid.GridControl();
            this.gridViewContractor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.backButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.addButtonProduct = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContractor)).BeginInit();
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
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(498, 468);
            this.Root.TextVisible = false;
            // 
            // gridControlContractor
            // 
            this.gridControlContractor.Location = new System.Drawing.Point(12, 12);
            this.gridControlContractor.MainView = this.gridViewContractor;
            this.gridControlContractor.Name = "gridControlContractor";
            this.gridControlContractor.Size = new System.Drawing.Size(474, 418);
            this.gridControlContractor.TabIndex = 4;
            this.gridControlContractor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContractor});
            // 
            // gridViewContractor
            // 
            this.gridViewContractor.GridControl = this.gridControlContractor;
            this.gridViewContractor.Name = "gridViewContractor";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlContractor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(478, 422);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 434);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(235, 22);
            this.backButton.StyleController = this.layoutControl1;
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Powrót";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.backButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 422);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(239, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // addButtonProduct
            // 
            this.addButtonProduct.Location = new System.Drawing.Point(251, 434);
            this.addButtonProduct.Name = "addButtonProduct";
            this.addButtonProduct.Size = new System.Drawing.Size(235, 22);
            this.addButtonProduct.StyleController = this.layoutControl1;
            this.addButtonProduct.TabIndex = 6;
            this.addButtonProduct.Text = "Dodaj kontrahenta";
            this.addButtonProduct.Click += new System.EventHandler(this.addButtonProduct_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.addButtonProduct;
            this.layoutControlItem3.Location = new System.Drawing.Point(239, 422);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(239, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // AddContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 468);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddContractorForm";
            this.Text = "Dodawanie kontrahenta";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContractor)).EndInit();
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
    }
}