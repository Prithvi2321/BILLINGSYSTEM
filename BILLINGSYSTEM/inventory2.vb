
Imports System.Data.OleDb

Public Class inventory2
    'Dim Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Prithviraj\Desktop\GAD MICRO\Databasebilling.mdf;Integrated Security=True;Connect Timeout=30")
    Dim Con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Prithviraj\Desktop\GAD MICRO\ShopBilling.mdb")

    Private Sub inventory2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con.Open()
        Dim quer = "select * from  additem order by iname desc"
        Dim adapter As OleDb.OleDbDataAdapter
        Dim cmd = New OleDbCommand(quer, Con)
        adapter = New OleDb.OleDbDataAdapter(cmd)
        Dim builder = New OleDb.OleDbCommandBuilder(adapter)
        Dim ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Hide()
        Inventory.Show()
    End Sub
End Class