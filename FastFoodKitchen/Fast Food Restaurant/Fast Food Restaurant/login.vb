Imports MySql.Data.MySqlClient

Public Class login


    Dim conn As New MySqlConnection

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'conn.Open()
        ' cmd = New MySqlCommand("INSERT INTO `user_login`(`id`, `username`, `password` ) VALUES (@id,@username,@password)", conn)

        Form1.Show()
        'conn.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub username_Click(sender As Object, e As EventArgs) Handles username.Click

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub
End Class