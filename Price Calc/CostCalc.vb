Public Class CostCalc

    'these lines declare all the variables
    Dim cost As Long
    Dim area As Long
    Dim vat As Long
    Dim finalcostnovat As Long

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        'this line checks to see if the value in textbox1 is numeric
        If Not IsNumeric(TextBox1.Text) Then
            'this brings up a message box if the value isn't numeric 
            MsgBox("Please enter a numeric value for the area")
        Else

            'this makes one of the variables equal to the value in textbox1
            area = TextBox1.Text

            'this section checks to see what is selected in the combobox and 
            'changes a variable based on it
            If ComboBox1.Text = "Oak" Then
                cost = 10
            ElseIf ComboBox1.Text = "Beach" Then
                cost = 8
            ElseIf ComboBox1.Text = "Pine" Then
                cost = 6
            ElseIf ComboBox1.Text = "Laminated" Then
                cost = 12
            End If

            'these are the calculations which figure out the vat as well as 
            'the final cost of the flooring.
            vat = FormatNumber((cost * area) / 5, 2)
            finalcostnovat = FormatNumber(cost * area, 2)

            'these lines write the vat, price without vat and price with vat
            'into labels for them to be seen on the form.
            VATtxt.Text = "£" & vat
            Price.Text = "£" & finalcostnovat
            TotalPrice.Text = "£" & (finalcostnovat + vat)

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Menu1.Show()
        Me.Hide()

    End Sub

    Private Sub CostCalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cost = 0
        area = 0
        vat = 0
        finalcostnovat = 0

    End Sub
End Class