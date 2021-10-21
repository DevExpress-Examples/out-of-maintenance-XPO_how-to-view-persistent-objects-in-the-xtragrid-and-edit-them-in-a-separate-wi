// Developer Express Code Central Example:
// How to view persistent objects in the XtraGrid and edit them in a separate window
// 
// This example demonstrates how to edit XPO objects in the scope of a UnitOfWork,
// so that the changes made to the object's properties can be saved or
// canceled.
// See Also:
// http://www.devexpress.com/scid=A2944
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E771

namespace XpoEditForm
{
    partial class FormEditOrder
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textEditOID = new DevExpress.XtraEditors.TextEdit();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditCustomer = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlOrderDetails = new DevExpress.XtraGrid.GridControl();
            this.gvOrderDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.cnOrderDetails = new DevExpress.XtraEditors.ControlNavigator();
            this.ceDeelteOrderDetailsPermanently = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDeelteOrderDetailsPermanently.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditOID
            // 
            this.textEditOID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Oid", true));
            this.textEditOID.Location = new System.Drawing.Point(101, 11);
            this.textEditOID.Margin = new System.Windows.Forms.Padding(4);
            this.textEditOID.Name = "textEditOID";
            this.textEditOID.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Control;
            this.textEditOID.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.textEditOID.Properties.ReadOnly = true;
            this.textEditOID.Size = new System.Drawing.Size(133, 22);
            this.textEditOID.TabIndex = 1;
            // 
            // xpCollection1
            // 
            this.xpCollection1.LoadingEnabled = false;
            this.xpCollection1.ObjectType = typeof(XpoEditForm.Order);
            this.xpCollection1.Session = this.unitOfWork;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "OID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(263, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Customer:";
            // 
            // textEditCustomer
            // 
            this.textEditCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Customer", true));
            this.textEditCustomer.Location = new System.Drawing.Point(383, 11);
            this.textEditCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.textEditCustomer.Name = "textEditCustomer";
            this.textEditCustomer.Size = new System.Drawing.Size(281, 22);
            this.textEditCustomer.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(456, 380);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(564, 380);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gridControlOrderDetails
            // 
            this.gridControlOrderDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlOrderDetails.Location = new System.Drawing.Point(16, 129);
            this.gridControlOrderDetails.MainView = this.gvOrderDetails;
            this.gridControlOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlOrderDetails.Name = "gridControlOrderDetails";
            this.gridControlOrderDetails.ShowOnlyPredefinedDetails = true;
            this.gridControlOrderDetails.Size = new System.Drawing.Size(648, 240);
            this.gridControlOrderDetails.TabIndex = 6;
            this.gridControlOrderDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderDetails});
            // 
            // gvOrderDetails
            // 
            this.gvOrderDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colPrice,
            this.colQuantity});
            this.gvOrderDetails.DetailHeight = 431;
            this.gvOrderDetails.GridControl = this.gridControlOrderDetails;
            this.gvOrderDetails.Name = "gvOrderDetails";
            // 
            // colProductName
            // 
            this.colProductName.Caption = "ProductName";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 27;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 100;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 27;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            this.colPrice.Width = 100;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 27;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 100;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 47);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Date:";
            // 
            // dateEditOrderDate
            // 
            this.dateEditOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "OrderDate", true));
            this.dateEditOrderDate.EditValue = null;
            this.dateEditOrderDate.Location = new System.Drawing.Point(101, 43);
            this.dateEditOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateEditOrderDate.Name = "dateEditOrderDate";
            this.dateEditOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditOrderDate.Size = new System.Drawing.Size(133, 22);
            this.dateEditOrderDate.TabIndex = 9;
            // 
            // cnOrderDetails
            // 
            this.cnOrderDetails.Location = new System.Drawing.Point(16, 92);
            this.cnOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.cnOrderDetails.Name = "cnOrderDetails";
            this.cnOrderDetails.NavigatableControl = this.gridControlOrderDetails;
            this.cnOrderDetails.Size = new System.Drawing.Size(648, 30);
            this.cnOrderDetails.TabIndex = 10;
            this.cnOrderDetails.Text = "controlNavigator1";
            this.cnOrderDetails.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.cnOrderDetails_ButtonClick);
            // 
            // ceDeelteOrderDetailsPermanently
            // 
            this.ceDeelteOrderDetailsPermanently.Location = new System.Drawing.Point(16, 389);
            this.ceDeelteOrderDetailsPermanently.Name = "ceDeelteOrderDetailsPermanently";
            this.ceDeelteOrderDetailsPermanently.Properties.Caption = "Delete Order Details Permanently";
            this.ceDeelteOrderDetailsPermanently.Size = new System.Drawing.Size(218, 24);
            this.ceDeelteOrderDetailsPermanently.TabIndex = 11;
            // 
            // FormEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 425);
            this.Controls.Add(this.ceDeelteOrderDetailsPermanently);
            this.Controls.Add(this.cnOrderDetails);
            this.Controls.Add(this.dateEditOrderDate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControlOrderDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textEditCustomer);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditOID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.textEditOID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDeelteOrderDetailsPermanently.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditOID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditCustomer;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl gridControlOrderDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrderDetails;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateEditOrderDate;
        private DevExpress.XtraEditors.ControlNavigator cnOrderDetails;
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.CheckEdit ceDeelteOrderDetailsPermanently;
    }
}