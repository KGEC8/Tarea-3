Public Class Form1
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If (CheckBox1.Checked) Then
            TextBox1.Visible = True
            TextBox1.Focus()
        Else
            TextBox1.Clear()
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If (CheckBox2.Checked) Then
            TextBox2.Visible = True
            TextBox2.Focus()
        Else
            TextBox2.Clear()
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            TextBox3.Visible = True
            TextBox3.Focus()
        Else
            TextBox3.Clear()
            TextBox3.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        anterior = 0
        anterior = Val(TextBox4.Text)

        If ((CheckBox1.Checked) Or (CheckBox2.Checked) Or (CheckBox3.Checked)) Then
            If (CheckBox1.Checked) Then
                If (IsNumeric(TextBox1.Text) And Val(TextBox1.Text) > 0) Then
                    mios = Val(TextBox1.Text)
                Else
                    MessageBox.Show("ERROR NO INGRESO CORRECTAMENTE EL VALOR DE CHEQUES PROPIOS")
                    TextBox1.Focus()
                    Exit Sub
                End If
            Else
                mios = 0
            End If
            If (CheckBox2.Checked) Then
                If (IsNumeric(TextBox2.Text) And Val(TextBox2.Text) > 0) Then
                    otros = Val(TextBox2.Text)
                Else
                    MessageBox.Show("ERRORNO INGRESO CORRECTAMENTE EL VALOR DE CHEQUES DE OTROS BANCOS") : TextBox2.Focus() : Exit Sub
                End If
            Else
                mios = 0
            End If
            If (CheckBox3.Checked) Then
                If (IsNumeric(TextBox3.Text) And Val(TextBox3.Text) > 0) Then
                    cash = Val(TextBox3.Text)
                Else
                    MessageBox.Show("ERROR NO INGRESO CORRECTAMENTE EL EFECTIVO")
                    TextBox3.Focus()
                    Exit Sub
                End If
            Else
                cash = 0
            End If
        Else
            MessageBox.Show("ERROR, NO SELECCIONO MÉTOOD DE DEPOSITO")
            Exit Sub
        End If

        parcial = cash + mios + otros + anterior

        If (RadioButton1.Checked) Then
            intereses = 0

        ElseIf (RadioButton2.Checked) Then
            If anterior > 1 And anterior < 10001 Then
                intereses = anterior * p1
            ElseIf anterior >= 10001 And anterior < 150001 Then
                intereses = anterior * p2
            ElseIf anterior >= 15001 Then
                intereses = anterior * p3
            End If
        ElseIf (RadioButton3.Checked) Then
            Select Case parcial
                Case 1.00000001 To 1000
                    intereses = parcial * i1
                Case 1001 To 5000
                    intereses = parcial * i2
                Case 5001 To 15001
                    intereses = parcial * i3
                Case Is <= 150001
                    intereses = parcial * i4

            End Select
        Else
            MessageBox.Show("ERROR, NO SELECCIONO QUE TIPO DE DEPÓSITO REALIZARA")
            Exit Sub
        End If

        nuevo = parcial


        Me.Hide()
        Form2.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If msgbox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Me.Close()
            End
        Else
            LIMPIAR()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LIMPIAR()

    End Sub
End Class
