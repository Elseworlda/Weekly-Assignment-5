Public Class Form1
    Dim intGroupSize As Integer = 0
    Dim decRegistration As Decimal
    Dim finalCost As Decimal
    Const SuperheroExperience As Decimal = 380
    Const Autographs As Decimal = 275
    Const Convention As Decimal = 209
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFinalCost.Text = ""
        txtGroupSize.Text = ""
        txtGroupSize.Focus()
        rdoSuperhero.Checked = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        lblFinalCost.Text = ""
        txtGroupSize.Text = ""
        txtGroupSize.Focus()
        rdoSuperhero.Checked = True
        ErrorDisplay.SetError(grpBadgeType, String.Empty)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If (IsNumeric(txtGroupSize.Text)) Then
            ErrorDisplay.SetError(grpBadgeType, String.Empty)
            intGroupSize = txtGroupSize.Text
            If (intGroupSize > 0 And intGroupSize < 20) Then
                If (rdoSuperhero.Checked = True) Then
                    decRegistration = SuperheroExperience
                ElseIf (rdoAutograph.Checked = True) Then
                    decRegistration = Autographs
                ElseIf (rdoConvention.Checked = True) Then
                    decRegistration = Convention
                End If
                finalCost = (intGroupSize * decRegistration)
                lblFinalCost.Text = finalCost.ToString("C")
            Else
                lblFinalCost.Text = ""
                ErrorDisplay.SetError(grpBadgeType, "Value must be between 0 and 20.")
            End If
        Else
            lblFinalCost.Text = ""
            ErrorDisplay.SetError(grpBadgeType, "Value must be a number.")
        End If
    End Sub
End Class
