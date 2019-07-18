Public Class NewCustomer

    'these lines declare allt he variables which are needed 
    'in order for the connection to the databse to work
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'the next section of code is used to start a connection to the database
        'this line tells the program which format the database is in
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        'this line telles the program where the databse s and what it's called
        dbSource = "Data source =" & Application.StartupPath & "/Database.mdb"

        con.ConnectionString = dbProvider & dbSource
        'this line oprens the connection to the database
        con.Open()

        'this line checks to see whether the date is valid
        If Not IsDate(DoB.Text) Then
            MsgBox("Invalid date entered for date of birth")
        Else
            'this line is used to add the contents of the etxtboxes into the correct columns within the database
            sql = "insert into tblCustomers (FullName,DoB, TelNo, Email, City, Postcode, Address1, Address2) values ('" & FirstName.Text & "','" & DoB.Text & "','" & TelNo.Text & "','" & Email.Text & "','" & City.Text & "','" & Postcode.Text & "','" & Address1.Text & "','" & Address2.Text & "')"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "AddressBook")
            'this line brings up a message box is the date passwed thw validation check.
            MsgBox("done")
        End If

        'this is the end of the connection to the database
        con.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Menu1.Show()
        Me.Hide()

    End Sub
End Class