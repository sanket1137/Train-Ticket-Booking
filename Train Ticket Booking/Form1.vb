Imports System.Data.SqlClient

Public Class suname
    Dim Connection1 As String = "Data Source=DESKTOP-I0V1I2D\\SQLEXPRESS;Initial Catalog=inrail;Integrated Security=True"
    Dim a As Integer = 0
    Dim id As Integer = 100
    Dim value As Integer
    Dim p, u As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sin1_Click(sender As Object, e As EventArgs) Handles sin1.Click

        GroupBox1.Visible = False
        sup.Visible = False
        sin.Visible = True

    End Sub

    Private Sub sup1_Click(sender As Object, e As EventArgs) Handles sup1.Click
        sin.Visible = False
        sup.Visible = True
        GroupBox1.Visible = False

        Dim connection As New SqlConnection(Connection1)
        connection.Open()


        Dim cmd As New SqlCommand("insert into Employee values('" & TextBox1.Text & "','" & TextBox2.Text & "')", connection)
        cmd.ExecuteNonQuery()
        Dim command As New SqlCommand("select MAX(User_id) from  userinfo", connection)
        Dim dr As SqlDataReader = command.ExecuteReader()
        If dr.HasRows Then
            While (dr.Read())

                ' supid.Text = dr.Item("user_id")

            End While

            MessageBox.Show(p)

        End If
        Dim a As Integer = command.ExecuteScalar
        connection.Close()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub

    Private Sub showp_Click(sender As Object, e As EventArgs) Handles showp.Click

        If a = 0 Then
            pass.UseSystemPasswordChar = False
            a = 2
        ElseIf a = 2 Then
            pass.UseSystemPasswordChar = True
            a = 0
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim s1() As String
        Dim s2() As String
        s1 = Split(suppass.Text, " ")
        s2 = Split(suppass1.Text, " ")
        Dim a As Integer
        If s1(a) <> "" Then
            If s1(a) <> s2(a) Then
                MessageBox.Show("Password Incorrect")

            Else

                Dim connection As New SqlConnection(Connection1)
                connection.Open()



                Dim cmd As New SqlCommand("insert into userinfo values('" & supname.Text & "','" & suppass.Text & "','" & TextBox2.Text & "','" & TextBox2.Text & "')", connection)
                cmd.ExecuteNonQuery()
                'Dim command As New SqlCommand("select * from userinfo where Name='" & TextBox1.Text & "' and Pass='" & pass.Text & "'", connection)
                'Dim dr As SqlDataReader = command.ExecuteReader()
                ' If dr.HasRows Then
                '   While dr.Read()
                '     p = dr("Acc_Password").ToString()
                '     u = dr("Emp_name").ToString()
                '  End While
                ' End If
                '  If u = TextBox1.Text And p = TextBox2.Text Then
                MessageBox.Show("Siging in")
                sin.Visible = True
                sup.Visible = False
                GroupBox1.Visible = False
                MessageBox.Show("Login Now pls")
                ' Else
                '    MessageBox.Show("Siging in Fail")

                ' End If
                sup.Visible = False
                sin.Visible = True

            End If

        Else
            MessageBox.Show("Enter the details first")

        End If




    End Sub

    Private Sub entr_Click(sender As Object, e As EventArgs) Handles entr.Click

        Dim connection As New SqlConnection(Connection1)
        connection.Open()

        'Dim cmd As New SqlCommand("insert into Employee values('" & TextBox1.Text & "','" & TextBox2.Text & "')", connection)
        ' cmd.ExecuteNonQuery()
        Dim command As New SqlCommand("select * from userinfo where Name='" & sinname.Text & "' and Pass='" & pass.Text & "'", connection)
        Dim dr As SqlDataReader = command.ExecuteReader()

        If dr.HasRows Then

            MessageBox.Show("login successful")

            FORM2.Show()


        Else
            MessageBox.Show("login Fail")


        End If
        dr.Close()

        Dim command1 As New SqlCommand("select User_id from userinfo where Name='" & sinname.Text & "' and Pass='" & pass.Text & "'", connection)
        Dim dr1 As SqlDataReader = command.ExecuteReader()

            While (dr1.Read())

            Label12.Text = dr1("User_id").ToString()


        End While


        dr1.Close()
        connection.Close()

        FORM2.Label9.Text = sinname.Text
        FORM2.Label11.Text = Label12.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If a = 0 Then
            suppass1.UseSystemPasswordChar = False
            a = 2
        ElseIf a = 2 Then
            suppass1.UseSystemPasswordChar = True
            a = 0
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        sin.Visible = False
        sup.Visible = False
        GroupBox1.Visible = True



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Visible = True
        Dim connection As New SqlConnection(Connection1)
        connection.Open()

        'Dim cmd As New SqlCommand("insert into Employee values('" & TextBox1.Text & "','" & TextBox2.Text & "')", connection)
        ' cmd.ExecuteNonQuery()
        Dim command As New SqlCommand("select Pass from userinfo where Name='" & TextBox3.Text & "' and Sqes='" & TextBox1.Text & "'", connection)
        'Dim dr As SqlDataReader = command.ExecuteReader()
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sin.Visible = True
        sup.Visible = False
        GroupBox1.Visible = False
        DataGridView1.Visible = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles TextBox2.MouseEnter
        TextBox2.Text = " "
    End Sub
End Class
