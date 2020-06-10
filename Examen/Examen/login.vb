Imports System.ComponentModel

Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cadena, contraseña As String
        cadena = TextBox1.Text
        contraseña = TextBox2.Text

        Try
            If Me.ValidateChildren And TextBox1.Text <> String.Empty And TextBox2.Text <> String.Empty = 0 Then
                MessageBox.Show("revise los datos ingresados", "error en INGRESO DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
            End If

            TextBox1.Text = cadena.ToUpper

            If TextBox1.Text = "ADMINISTRADOR" And TextBox2.Text = "SinHacer2020" Then
                programaprincipal.Show()
                Me.Hide()
            Else
                MsgBox("ingrese el usuario y contraseña correcta")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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
            Me.ErrorProvider1.SetError(sender, "Ingrese una usuario")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese una contraseña")
        End If
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip1.SetToolTip(TextBox1, "ingresar un usuario")
        ToolTip1.ToolTipTitle = "usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class