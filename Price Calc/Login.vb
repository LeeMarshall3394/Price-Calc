Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'this line checks to see whether the first textbox contains the 
        'correct(Username)
        If Username.Text = "login" Then
            'this line checks to see whether the first textbox contains
            'the correct password
            If Password.Text = "password" Then
                'this line brings up a message box to tell you you've 
                'logged in successfully.
                MsgBox("Successful login")
                'the next two lines close this form and open the menu form
                Me.Hide()
                Menu1.Show()
            Else
                'this brings up a message box saying you've entered the wrong 
                'username/password
                MsgBox("Invalid username or password")
            End If
        Else
            'this line also brings up a message box saying you've entered the
            'wrong(Username / Password)
            MsgBox("Invalid username or password")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Help.Show()
        Me.Hide()

    End Sub
End Class
