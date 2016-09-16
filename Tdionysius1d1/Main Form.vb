Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblStraw.Text = Val(txtStraw.Text) * Val(txtProjIncrease.Text) + Val(txtStraw.Text)
        lblBlue.Text = Val(txtBlue.Text) * Val(txtProjIncrease.Text) + Val(txtBlue.Text)
        lblRasp.Text = Val(txtRasp.Text) * Val(txtProjIncrease.Text) + Val(txtRasp.Text)
        lblStraw.Text = Format(lblStraw.Text, "currency")
        lblBlue.Text = Format(lblBlue.Text, "currency")
        lblRasp.Text = Format(lblRasp.Text, "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblStraw.Text = String.Empty
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
    End Sub
End Class
