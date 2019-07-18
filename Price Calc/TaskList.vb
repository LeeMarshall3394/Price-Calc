Public Class TaskList

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'this line adds whatever's in the textbox to the listbox
        ListBox1.Items.Add(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'the next two lines close this form and open the menu
        Menu1.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'this line deletes the selected in the listbox
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'this line clears ever line of the listbox
        ListBox1.Items.Clear()

    End Sub
End Class