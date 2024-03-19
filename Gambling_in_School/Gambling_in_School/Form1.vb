Imports System.Reflection.Emit
Public Class Form1
    Dim M As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = True
        If M > 3 Then
            WheelControl1.spin()
            WheelControl2.spin()
            WheelControl3.spin()
            Label1.Text = WheelControl1.itemvalue
            Label2.Text = WheelControl2.itemvalue
            Label3.Text = WheelControl3.itemvalue
            M = M - 3
        End If
    End Sub

    Private Sub Money_Click(sender As Object, e As EventArgs) Handles Money.Click
        M = M + 9.99
        TextBox1.Text = M
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = WheelControl1.itemvalue
        Label2.Text = WheelControl2.itemvalue
        Label3.Text = WheelControl3.itemvalue
        TextBox1.Text = M
        If Label1.Text = Label2.Text And Label2.Text = Label3.Text Then
            M = M + 7
            TextBox1.Text = M
        End If
        Timer2.Enabled = False
    End Sub
End Class
