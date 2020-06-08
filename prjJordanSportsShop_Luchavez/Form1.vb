Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim wholeSalary As Decimal = Val(txtYearlySalary.Text)
        Dim weeklySalary As Decimal = wholeSalary / 52
        Dim biweeklySalary As Decimal = wholeSalary / 26
        txtWeeklySalary.Text = FormatCurrency(weeklySalary, 2)
        txtBiweeklySalary.Text = FormatCurrency(biweeklySalary, 2)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtYearlySalary.Clear()
        txtWeeklySalary.Clear()
        txtBiweeklySalary.Clear()
        txtYearlySalary.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnCalculate.Hide()
        btnPrint.Hide()
        btnClear.Hide()
        printMain.Print()
        btnCalculate.Show()
        btnPrint.Show()
        btnClear.Show()
    End Sub
End Class
