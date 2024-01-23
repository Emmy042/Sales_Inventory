<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Label1 = New Label()
        save_Button = New Button()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        TextBox_quantity = New TextBox()
        TextBox_no = New TextBox()
        Label3 = New Label()
        Button3 = New Button()
        update_Button = New Button()
        Del_Button = New Button()
        DataGridView1 = New DataGridView()
        TextBox_amount = New TextBox()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button_retreive = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(49, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 17)
        Label1.TabIndex = 3
        Label1.Text = " Items" & vbCrLf
        ' 
        ' save_Button
        ' 
        save_Button.BackColor = Color.Lime
        save_Button.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        save_Button.Location = New Point(132, 272)
        save_Button.Name = "save_Button"
        save_Button.Size = New Size(97, 42)
        save_Button.TabIndex = 5
        save_Button.Text = "Save"
        save_Button.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(35, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 17)
        Label2.TabIndex = 6
        Label2.Text = "Quantity"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ControlDarkDark
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Iphone 12 pro max", "Iphone 13", "iphone 14 pro", "samsung galaxy s20", "samsung galaxy s24", "samsung galaxy s21", "redimi note 8", "redimi note 12 pro"})
        ComboBox1.Location = New Point(110, 96)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(174, 23)
        ComboBox1.TabIndex = 7
        ' 
        ' TextBox_quantity
        ' 
        TextBox_quantity.Location = New Point(110, 128)
        TextBox_quantity.Name = "TextBox_quantity"
        TextBox_quantity.Size = New Size(174, 23)
        TextBox_quantity.TabIndex = 8
        ' 
        ' TextBox_no
        ' 
        TextBox_no.Location = New Point(110, 67)
        TextBox_no.Name = "TextBox_no"
        TextBox_no.Size = New Size(174, 23)
        TextBox_no.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(68, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 17)
        Label3.TabIndex = 10
        Label3.Text = "No "
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(-108, -65)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 43)
        Button3.TabIndex = 14
        Button3.Text = "SAVE "
        Button3.UseVisualStyleBackColor = True
        ' 
        ' update_Button
        ' 
        update_Button.BackColor = Color.Blue
        update_Button.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        update_Button.Location = New Point(32, 327)
        update_Button.Name = "update_Button"
        update_Button.Size = New Size(97, 42)
        update_Button.TabIndex = 15
        update_Button.Text = "Update"
        update_Button.UseVisualStyleBackColor = False
        ' 
        ' Del_Button
        ' 
        Del_Button.BackColor = Color.Red
        Del_Button.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Del_Button.Location = New Point(232, 327)
        Del_Button.Name = "Del_Button"
        Del_Button.Size = New Size(97, 42)
        Del_Button.TabIndex = 16
        Del_Button.Text = "Delete"
        Del_Button.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Tan
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        DataGridView1.Location = New Point(591, 1)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(482, 365)
        DataGridView1.TabIndex = 17
        ' 
        ' TextBox_amount
        ' 
        TextBox_amount.Location = New Point(110, 157)
        TextBox_amount.Name = "TextBox_amount"
        TextBox_amount.Size = New Size(174, 23)
        TextBox_amount.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(10, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 17)
        Label4.TabIndex = 18
        Label4.Text = "Amount sold"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.Location = New Point(296, 12)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(193, 23)
        DateTimePicker1.TabIndex = 20
        ' 
        ' Button_retreive
        ' 
        Button_retreive.BackColor = Color.Yellow
        Button_retreive.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button_retreive.Location = New Point(332, 272)
        Button_retreive.Name = "Button_retreive"
        Button_retreive.Size = New Size(97, 42)
        Button_retreive.TabIndex = 21
        Button_retreive.Text = "Retrieve"
        Button_retreive.UseVisualStyleBackColor = False
        ' 
        ' Sales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1076, 555)
        Controls.Add(Button_retreive)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox_amount)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(Del_Button)
        Controls.Add(update_Button)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(TextBox_no)
        Controls.Add(TextBox_quantity)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(save_Button)
        Controls.Add(Label1)
        Name = "Sales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "sales_inventory"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents save_Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox_quantity As TextBox
    Friend WithEvents TextBox_no As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents update_Button As Button
    Friend WithEvents Del_Button As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox_amount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button_retreive As Button
End Class
