Imports System.Data.SqlClient

Public Class new_signin
    Dim ab = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Prithviraj\Desktop\GAD MICRO\Databasebilling.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub new_signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.Hide()
        Me.Show()

    End Sub

   

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Textbox1.Text = "" Or Textbox2.Text = "" Then
            MsgBox("Cannot input NULL user", 0, "Error")
        Else
            ab.open()
            Dim str As String = "INSERT INTO login VALUES ('" & Textbox1.Text & "','" & Textbox2.Text & "')"
            Dim cn As SqlCommand
            cn = New SqlCommand(str, ab)
            cn.ExecuteNonQuery()
            ab.close()
            MsgBox("User added successfully", 0, "Sign in")
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class