' Joshua Pickenpaugh
' September 11th, 2016
' "Dappers Shipping Calculator"

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares the consts:
        Const ILLINOIS As Decimal = 15.0
        Const INDIANA As Decimal = 25.0
        Const MICHIGAN As Decimal = 30.0
        Const WISCONSIN As Decimal = 20.0
        Const OVERNIGHT_SHIP As Decimal = 10.0
        Const TWO_DAY_SHIP As Decimal = 5.0
        Dim decShippingTotal As Decimal

        'Decision structure:
        Select Case True
            Case rdoIllinois.Checked
                lblTotal.Text = ILLINOIS.ToString("C2")
                If rdoOvernight.Checked Then
                    decShippingTotal = ILLINOIS + OVERNIGHT_SHIP
                    lblTotal.Text = decShippingTotal.ToString("C2")
                ElseIf rdoTwoDay.Checked Then
                    decShippingTotal = ILLINOIS + TWO_DAY_SHIP
                    lblTotal.Text = decShippingTotal.ToString("C2")
                End If

            Case rdoIndiana.Checked
                lblTotal.Text = INDIANA.ToString("C2")
                If rdoOvernight.Checked Then
                    decShippingTotal = INDIANA + OVERNIGHT_SHIP
                    lblTotal.Text = decShippingTotal.ToString("C2")
                ElseIf rdoTwoDay.Checked Then
                    decShippingTotal = INDIANA + TWO_DAY_SHIP
                    lblTotal.Text = decShippingTotal.ToString("C2")
                End If

            Case rdoMichigan.Checked
                lblTotal.Text = MICHIGAN.ToString("C2")
                If rdoOvernight.Checked Then
                    decShippingTotal = MICHIGAN + OVERNIGHT_SHIP
                    lblTotal.Text = decShippingTotal.ToString("C2")
                ElseIf rdoTwoDay.Checked Then
                    decShippingTotal = MICHIGAN + TWO_DAY_SHIP
                    lblTotal.Text = decShippingTotal.ToString("C2")
                End If

            Case rdoWisconsin.Checked
                lblTotal.Text = WISCONSIN.ToString("C2")
                If rdoOvernight.Checked Then
                    decShippingTotal = WISCONSIN + OVERNIGHT_SHIP
                    lblTotal.Text = decShippingTotal.ToString("C2")
                ElseIf rdoTwoDay.Checked Then
                    decShippingTotal = WISCONSIN + TWO_DAY_SHIP
                    lblTotal.Text = decShippingTotal.ToString("C2")
                End If
        End Select

    End Sub
End Class
