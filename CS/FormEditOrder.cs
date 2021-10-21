using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;

namespace XpoEditForm {
    public partial class FormEditOrder : Form {
        private Order sourceOrder, theOrder;
        private readonly XPCollection sourceCollection;

        public FormEditOrder(Order order, XPCollection collection) {
            sourceOrder = order;
            sourceCollection = collection;

            InitializeComponent();

            if(sourceOrder == null)
                theOrder = new Order(unitOfWork);
            else
                theOrder = unitOfWork.GetObjectByKey<Order>(sourceOrder.Oid);

            xpCollection1.Add(theOrder);
            gridControlOrderDetails.DataSource = theOrder.OrderDetails;
        }

        private bool DeleteOrderDetailsPermanently {
            get { return ceDeelteOrderDetailsPermanently.Checked; }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void cnOrderDetails_ButtonClick(object sender, NavigatorButtonClickEventArgs e) {
            switch(e.Button.ButtonType) {
                case NavigatorButtonType.Remove:
                    e.Handled = true;
                    if(gvOrderDetails.IsValidRowHandle(gvOrderDetails.FocusedRowHandle)) {
                        DeleteOrderDetail(gvOrderDetails.FocusedRowHandle);
                    }
                    break;
            }
        }

        private void DeleteOrderDetail(int rowHandle) {
            if(DeleteOrderDetailsPermanently) {
                unitOfWork.Delete(gvOrderDetails.GetRow(rowHandle));
            } else {
                gvOrderDetails.DeleteRow(rowHandle);
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            gvOrderDetails.UpdateCurrentRow();
            BindingContext[xpCollection1].EndCurrentEdit();

            if(unitOfWork.InTransaction) {
                unitOfWork.CommitChanges();
                if(sourceOrder == null)
                    sourceCollection.Reload();
                else
                    sourceOrder.Reload();
            }
            Close();
        }
    }
}