
Imports System.Data.OleDb

Public Class add
    'Dim Con =New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Prithviraj\Desktop\GAD MICRO\Databasebilling.mdf;Integrated Security=True;Connect Timeout=30")
    Dim Con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Prithviraj\Desktop\GAD MICRO\ShopBilling.mdb")
    Dim da As OleDbDataAdapter
    Dim cmd, cmd1 As OleDbCommand
    Dim ds As DataSet


    Private Sub add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inventory.Hide()
        Me.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim a, b, c As Double
            a = Double.Parse(TextBox2.Text)
            b = Double.Parse(TextBox3.Text)
            c = Double.Parse(TextBox4.Text)
           Con.Open()

            '   cmd.Connection = Con
            cmd.CommandText = "INSERT INTO itemadd VALUES ('" & TextBox1.Text & "', '" & a & "', '" & b & "', '" & TextBox4.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Data Saved")

            Dim quer As String = "SELECT * FROM itemadd ORDER BY iname DESC"
            Dim adapter As New OleDbDataAdapter(quer, Con)
            Dim ds As New DataSet()
            adapter.Fill(ds, "itemadd")

            inventory2.DataGridView1.DataSource = Nothing
            inventory2.DataGridView1.DataSource = ds.Tables("itemadd")

            Con.Close()


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""

        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Inventory.Show()
    End Sub
End Class