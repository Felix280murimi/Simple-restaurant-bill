<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurantBill
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPizza = New System.Windows.Forms.TextBox()
        Me.txtFries = New System.Windows.Forms.TextBox()
        Me.txtDrink = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.ListBoxDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How Many Pizza Slices"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "How many Fries"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "How Many Soft Drinks"
        '
        'txtPizza
        '
        Me.txtPizza.Location = New System.Drawing.Point(195, 39)
        Me.txtPizza.Name = "txtPizza"
        Me.txtPizza.Size = New System.Drawing.Size(47, 22)
        Me.txtPizza.TabIndex = 1
        '
        'txtFries
        '
        Me.txtFries.Location = New System.Drawing.Point(195, 85)
        Me.txtFries.Name = "txtFries"
        Me.txtFries.Size = New System.Drawing.Size(47, 22)
        Me.txtFries.TabIndex = 1
        '
        'txtDrink
        '
        Me.txtDrink.Location = New System.Drawing.Point(195, 120)
        Me.txtDrink.Name = "txtDrink"
        Me.txtDrink.Size = New System.Drawing.Size(47, 22)
        Me.txtDrink.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Historic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(285, 50)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(93, 83)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Total Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'ListBoxDisplay
        '
        Me.ListBoxDisplay.FormattingEnabled = True
        Me.ListBoxDisplay.ItemHeight = 16
        Me.ListBoxDisplay.Location = New System.Drawing.Point(15, 173)
        Me.ListBoxDisplay.Name = "ListBoxDisplay"
        Me.ListBoxDisplay.Size = New System.Drawing.Size(260, 164)
        Me.ListBoxDisplay.TabIndex = 3
        '
        'frmRestaurantBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 370)
        Me.Controls.Add(Me.ListBoxDisplay)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtDrink)
        Me.Controls.Add(Me.txtFries)
        Me.Controls.Add(Me.txtPizza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRestaurantBill"
        Me.Text = "Restaurant bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPizza As TextBox
    Friend WithEvents txtFries As TextBox
    Friend WithEvents txtDrink As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents ListBoxDisplay As ListBox
End Class
