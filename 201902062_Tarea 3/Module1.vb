Imports System.Math


Module Module1
    Public mios As Byte
    Public otros As Byte
    Public cash As Byte

    Public Const i1 = 0.015, i2 = 0.025, i3 = 0.075, i4 = 0.1
    Public Const p1 = 0.025, p2 = 0.03, p3 = 0.045
    Public intereses As Double
    Public anterior As Double
    Public nuevo As Double
    Public parcial As Double



    Sub LIMPIAR()
        Form1.TextBox1.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form2.TextBox1.Clear()
        Form2.TextBox2.Clear()

    End Sub


    Sub Resultados()
        Form2.TextBox1.Text = "Q." & Str(Round(intereses, 2))
        Form2.TextBox2.Text = "Q." & Str(Round(nuevo, 2))



    End Sub

End Module
