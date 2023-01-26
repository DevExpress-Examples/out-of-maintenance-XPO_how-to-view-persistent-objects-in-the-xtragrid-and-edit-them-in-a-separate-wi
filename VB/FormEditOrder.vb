Imports System
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors

Namespace XpoEditForm

    Public Partial Class FormEditOrder
        Inherits Form

        Private sourceOrder, theOrder As Order

        Private ReadOnly sourceCollection As XPCollection

        Public Sub New(ByVal order As Order, ByVal collection As XPCollection)
            sourceOrder = order
            sourceCollection = collection
            InitializeComponent()
            If sourceOrder Is Nothing Then
                theOrder = New Order(unitOfWork)
            Else
                theOrder = unitOfWork.GetObjectByKey(Of Order)(sourceOrder.Oid)
            End If

            xpCollection1.Add(theOrder)
            gridControlOrderDetails.DataSource = theOrder.OrderDetails
        End Sub

        Private ReadOnly Property DeleteOrderDetailsPermanently As Boolean
            Get
                Return ceDeelteOrderDetailsPermanently.Checked
            End Get
        End Property

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub cnOrderDetails_ButtonClick(ByVal sender As Object, ByVal e As NavigatorButtonClickEventArgs)
            Select Case e.Button.ButtonType
                Case NavigatorButtonType.Remove
                    e.Handled = True
                    If gvOrderDetails.IsValidRowHandle(gvOrderDetails.FocusedRowHandle) Then
                        DeleteOrderDetail(gvOrderDetails.FocusedRowHandle)
                    End If

            End Select
        End Sub

        Private Sub DeleteOrderDetail(ByVal rowHandle As Integer)
            If DeleteOrderDetailsPermanently Then
                unitOfWork.Delete(gvOrderDetails.GetRow(rowHandle))
            Else
                gvOrderDetails.DeleteRow(rowHandle)
            End If
        End Sub

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            gvOrderDetails.UpdateCurrentRow()
            BindingContext(xpCollection1).EndCurrentEdit()
            If unitOfWork.InTransaction Then
                unitOfWork.CommitChanges()
                If sourceOrder Is Nothing Then
                    sourceCollection.Reload()
                Else
                    sourceOrder.Reload()
                End If
            End If

            Close()
        End Sub
    End Class
End Namespace
