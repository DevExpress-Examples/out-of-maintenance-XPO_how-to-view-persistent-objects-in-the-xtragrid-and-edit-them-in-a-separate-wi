Imports System
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace XpoEditForm

    Friend Module Program

        <STAThread>
        Sub Main()
            Call InitDAL()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New FormViewOrders())
        End Sub

        Private Sub InitDAL()
            XpoDefault.DataLayer = XpoDefault.GetDataLayer("XpoProvider=MSSqlServer;data source=(local);integrated security=SSPI;initial catalog=E771", DB.AutoCreateOption.DatabaseAndSchema)
            XpoDefault.Session = Nothing
        End Sub
    End Module
End Namespace
