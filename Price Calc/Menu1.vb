Public Class Menu1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'these two lines close this form and open the newcustomer form
        NewCustomer.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'these two lines close this form and open the costcalc form
        CostCalc.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'these two lines close this form and open the tasklist form
        TaskList.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'these two lines close this form and open the login form
        Login.Show()
        Me.Hide()

    End Sub
End Class