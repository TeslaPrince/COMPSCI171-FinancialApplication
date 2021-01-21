Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim p As Integer
        Dim i As Double
        Dim y As Integer
        Dim c As Integer
        Dim total As Double
        Dim p2 As String
        Dim i2 As String
        Dim y2 As String
        Dim c2 As String
        Dim p3 As String
        Dim i3 As String
        Dim total2 As String
        Dim total3 As String
        total = p * (1 + (i / c)) ^ (c * y)
        p2 = CStr(p)
        p3 = String.Format("{0:C}", p2)
        i2 = CStr(i)
        i3 = String.Format("{0:P}", i2)
        c2 = CStr(c)
        y2 = CStr(y)
        total2 = CStr(total)
        total3 = String.Format("{0:C}", total2)
        ListBox1.Items.Add("An investment of " & p3 & " is put in an account paying " & i3 & " annual interest compounded " & y2 & " times per year.")
        ListBox1.Items.Add("the balance of the acocound after " & y2 & " years is " & total3)
    End Sub
End Class
