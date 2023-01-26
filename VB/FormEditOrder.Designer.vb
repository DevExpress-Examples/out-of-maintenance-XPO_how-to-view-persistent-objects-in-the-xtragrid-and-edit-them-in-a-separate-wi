' Developer Express Code Central Example:
' How to view persistent objects in the XtraGrid and edit them in a separate window
' 
' This example demonstrates how to edit XPO objects in the scope of a UnitOfWork,
' so that the changes made to the object's properties can be saved or
' canceled.
' See Also:
' http://www.devexpress.com/scid=A2944
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E771
Namespace XpoEditForm

    Partial Class FormEditOrder

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Código generado por el Diseñador de Windows Forms"
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.textEditOID = New DevExpress.XtraEditors.TextEdit()
            Me.xpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
            Me.unitOfWork = New DevExpress.Xpo.UnitOfWork(Me.components)
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.textEditCustomer = New DevExpress.XtraEditors.TextEdit()
            Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.gridControlOrderDetails = New DevExpress.XtraGrid.GridControl()
            Me.gvOrderDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.dateEditOrderDate = New DevExpress.XtraEditors.DateEdit()
            Me.cnOrderDetails = New DevExpress.XtraEditors.ControlNavigator()
            Me.ceDeelteOrderDetailsPermanently = New DevExpress.XtraEditors.CheckEdit()
            CType((Me.textEditOID.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xpCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.unitOfWork), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditCustomer.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControlOrderDetails), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gvOrderDetails), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEditOrderDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEditOrderDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceDeelteOrderDetailsPermanently.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' textEditOID
            ' 
            Me.textEditOID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Oid", True))
            Me.textEditOID.Location = New System.Drawing.Point(101, 11)
            Me.textEditOID.Margin = New System.Windows.Forms.Padding(4)
            Me.textEditOID.Name = "textEditOID"
            Me.textEditOID.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Control
            Me.textEditOID.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.textEditOID.Properties.[ReadOnly] = True
            Me.textEditOID.Size = New System.Drawing.Size(133, 22)
            Me.textEditOID.TabIndex = 1
            ' 
            ' xpCollection1
            ' 
            Me.xpCollection1.LoadingEnabled = False
            Me.xpCollection1.ObjectType = GetType(XpoEditForm.Order)
            Me.xpCollection1.Session = Me.unitOfWork
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(16, 15)
            Me.labelControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(26, 16)
            Me.labelControl1.TabIndex = 3
            Me.labelControl1.Text = "OID:"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(263, 15)
            Me.labelControl2.Margin = New System.Windows.Forms.Padding(4)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(60, 16)
            Me.labelControl2.TabIndex = 4
            Me.labelControl2.Text = "Customer:"
            ' 
            ' textEditCustomer
            ' 
            Me.textEditCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Customer", True))
            Me.textEditCustomer.Location = New System.Drawing.Point(383, 11)
            Me.textEditCustomer.Margin = New System.Windows.Forms.Padding(4)
            Me.textEditCustomer.Name = "textEditCustomer"
            Me.textEditCustomer.Size = New System.Drawing.Size(281, 22)
            Me.textEditCustomer.TabIndex = 2
            ' 
            ' btnOK
            ' 
            Me.btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnOK.Location = New System.Drawing.Point(456, 380)
            Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(100, 28)
            Me.btnOK.TabIndex = 4
            Me.btnOK.Text = "OK"
            AddHandler Me.btnOK.Click, New System.EventHandler(AddressOf Me.btnOK_Click)
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(564, 380)
            Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(100, 28)
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "Cancel"
            AddHandler Me.btnCancel.Click, New System.EventHandler(AddressOf Me.btnCancel_Click)
            ' 
            ' gridControlOrderDetails
            ' 
            Me.gridControlOrderDetails.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
            Me.gridControlOrderDetails.Location = New System.Drawing.Point(16, 129)
            Me.gridControlOrderDetails.MainView = Me.gvOrderDetails
            Me.gridControlOrderDetails.Margin = New System.Windows.Forms.Padding(4)
            Me.gridControlOrderDetails.Name = "gridControlOrderDetails"
            Me.gridControlOrderDetails.ShowOnlyPredefinedDetails = True
            Me.gridControlOrderDetails.Size = New System.Drawing.Size(648, 240)
            Me.gridControlOrderDetails.TabIndex = 6
            Me.gridControlOrderDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvOrderDetails})
            ' 
            ' gvOrderDetails
            ' 
            Me.gvOrderDetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colPrice, Me.colQuantity})
            Me.gvOrderDetails.DetailHeight = 431
            Me.gvOrderDetails.GridControl = Me.gridControlOrderDetails
            Me.gvOrderDetails.Name = "gvOrderDetails"
            ' 
            ' colProductName
            ' 
            Me.colProductName.Caption = "ProductName"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.MinWidth = 27
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            Me.colProductName.Width = 100
            ' 
            ' colPrice
            ' 
            Me.colPrice.Caption = "Price"
            Me.colPrice.FieldName = "Price"
            Me.colPrice.MinWidth = 27
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 1
            Me.colPrice.Width = 100
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.Caption = "Quantity"
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.MinWidth = 27
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 2
            Me.colQuantity.Width = 100
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Location = New System.Drawing.Point(16, 47)
            Me.labelControl3.Margin = New System.Windows.Forms.Padding(4)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(31, 16)
            Me.labelControl3.TabIndex = 8
            Me.labelControl3.Text = "Date:"
            ' 
            ' dateEditOrderDate
            ' 
            Me.dateEditOrderDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "OrderDate", True))
            Me.dateEditOrderDate.EditValue = Nothing
            Me.dateEditOrderDate.Location = New System.Drawing.Point(101, 43)
            Me.dateEditOrderDate.Margin = New System.Windows.Forms.Padding(4)
            Me.dateEditOrderDate.Name = "dateEditOrderDate"
            Me.dateEditOrderDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEditOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEditOrderDate.Size = New System.Drawing.Size(133, 22)
            Me.dateEditOrderDate.TabIndex = 9
            ' 
            ' cnOrderDetails
            ' 
            Me.cnOrderDetails.Location = New System.Drawing.Point(16, 92)
            Me.cnOrderDetails.Margin = New System.Windows.Forms.Padding(4)
            Me.cnOrderDetails.Name = "cnOrderDetails"
            Me.cnOrderDetails.NavigatableControl = Me.gridControlOrderDetails
            Me.cnOrderDetails.Size = New System.Drawing.Size(648, 30)
            Me.cnOrderDetails.TabIndex = 10
            Me.cnOrderDetails.Text = "controlNavigator1"
            AddHandler Me.cnOrderDetails.ButtonClick, New DevExpress.XtraEditors.NavigatorButtonClickEventHandler(AddressOf Me.cnOrderDetails_ButtonClick)
            ' 
            ' ceDeelteOrderDetailsPermanently
            ' 
            Me.ceDeelteOrderDetailsPermanently.Location = New System.Drawing.Point(16, 389)
            Me.ceDeelteOrderDetailsPermanently.Name = "ceDeelteOrderDetailsPermanently"
            Me.ceDeelteOrderDetailsPermanently.Properties.Caption = "Delete Order Details Permanently"
            Me.ceDeelteOrderDetailsPermanently.Size = New System.Drawing.Size(218, 24)
            Me.ceDeelteOrderDetailsPermanently.TabIndex = 11
            ' 
            ' FormEditOrder
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(680, 425)
            Me.Controls.Add(Me.ceDeelteOrderDetailsPermanently)
            Me.Controls.Add(Me.cnOrderDetails)
            Me.Controls.Add(Me.dateEditOrderDate)
            Me.Controls.Add(Me.labelControl3)
            Me.Controls.Add(Me.gridControlOrderDetails)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.textEditCustomer)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.textEditOID)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "FormEditOrder"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Order"
            CType((Me.textEditOID.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xpCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.unitOfWork), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditCustomer.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControlOrderDetails), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gvOrderDetails), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEditOrderDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEditOrderDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceDeelteOrderDetailsPermanently.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private textEditOID As DevExpress.XtraEditors.TextEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private textEditCustomer As DevExpress.XtraEditors.TextEdit

        Private btnOK As DevExpress.XtraEditors.SimpleButton

        Private btnCancel As DevExpress.XtraEditors.SimpleButton

        Private gridControlOrderDetails As DevExpress.XtraGrid.GridControl

        Private gvOrderDetails As DevExpress.XtraGrid.Views.Grid.GridView

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private dateEditOrderDate As DevExpress.XtraEditors.DateEdit

        Private cnOrderDetails As DevExpress.XtraEditors.ControlNavigator

        Private unitOfWork As DevExpress.Xpo.UnitOfWork

        Private xpCollection1 As DevExpress.Xpo.XPCollection

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn

        Private ceDeelteOrderDetailsPermanently As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace
