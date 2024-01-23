Imports System.Diagnostics.Eventing
Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient
Public Class Sales
    Dim sqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles save_Button.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=Emmy@241200;database=mydb"
        Dim READER As MySqlDataReader

        Try
            sqlconn.Open()
            Dim query As String
            query = "insert into sales (N_sale,product_sale,quantity,amount_sold,total,date_sold) values ('" & TextBox_no.Text & "','" & ComboBox1.SelectedItem & "','" & TextBox_quantity.Text & "','" & TextBox_amount.Text & "','" & TextBox_quantity.Text * TextBox_amount.Text & "','" & DateTimePicker1.Text & "')"
            COMMAND = New MySqlCommand(query, sqlconn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("successful")
            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
        load_table()



    End Sub

    Private Sub update_Button_Click(sender As Object, e As EventArgs) Handles update_Button.Click

        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=Emmy@241200;database=mydb"
        Dim READER As MySqlDataReader
        Try
            sqlconn.Open()
            Dim query As String
            query = "update sales set product_sale ='" & ComboBox1.SelectedItem & "',quantity = '" & TextBox_quantity.Text & "', amount_sold ='" & TextBox_quantity.Text & "', total = '" & TextBox_quantity.Text * TextBox_amount.Text & "', date_sold = '" & DateTimePicker1.Text & "' where N_sale = '" & TextBox_no.Text & "' "
            COMMAND = New MySqlCommand(query, sqlconn)
            Reader = COMMAND.ExecuteReader
            MessageBox.Show("successfully updated!")
            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
        load_table()

    End Sub

    Private Sub Del_Button_Click(sender As Object, e As EventArgs) Handles Del_Button.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=Emmy@241200;database=mydb"
        Dim READER As MySqlDataReader
        Try
            sqlconn.Open()
            Dim query As String
            query = "delete from sales where N_sale = '" & TextBox_no.Text & "' "
            COMMAND = New MySqlCommand(query, sqlconn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("data deleted!")
            sqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub Button_retreive_Click(sender As Object, e As EventArgs) Handles Button_retreive.Click
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=Emmy@241200;database=mydb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDATASET As New DataTable
        Dim bSource As New BindingSource
        Dim COMMAND As MySqlCommand

        Try
            Dim Query As String
            Query = "select * from sales where date_sold = '" & DateTimePicker1.Text & "' "
            COMMAND = New MySqlCommand(Query, sqlconn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDATASET)
            bSource.DataSource = dbDATASET
            DataGridView1.DataSource = bSource
            SDA.Update(dbDATASET)

            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()

        End Try


    End Sub

    Private Sub load_table()
        sqlconn = New MySqlConnection
        sqlconn.ConnectionString = "server=localhost;userid=root;password=Emmy@241200;database=mydb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDATASET As New DataTable
        Dim bSource As New BindingSource
        Dim COMMAND As MySqlCommand

        Try
            Dim Query As String
            Query = "select * from sales"
            COMMAND = New MySqlCommand(Query, sqlconn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDATASET)
            bSource.DataSource = dbDATASET
            DataGridView1.DataSource = bSource
            SDA.Update(dbDATASET)

            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()

        End Try
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
    End Sub

End Class