Imports System.ComponentModel

Public Class Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("porfavor ingrese  los datos en los campos")
            Else
                login.Show()
                Me.Hide()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "crear un usuario")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "crea una contraseña")
        End If
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip1.SetToolTip(TextBox1, "Crear un usuario")
        ToolTip1.ToolTipTitle = "usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        ToolTip1.SetToolTip(TextBox2, "Establecer contraseña")
        ToolTip1.ToolTipTitle = "contraseña"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
