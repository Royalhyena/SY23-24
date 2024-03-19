Public Class productcontrol
    Public Property productid As String
    Public Property productprice As Decimal
    Public Property productpicture As Image
    Public Property productcount As Integer

    Private Sub productcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDLabel.Text = productid
        PriceLabel.Text = productprice.ToString("c2")
        Picturebox1.Image = productpicture

    End Sub
    Sub buy()
        If productcount > 0 Then
            productcount = productcount - 1
        End If
        If productcount = 0 Then
            Picturebox1.Image = Nothing
        End If
    End Sub
End Class
