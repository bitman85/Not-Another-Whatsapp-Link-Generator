<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tb_tel = New System.Windows.Forms.TextBox()
        Me.bt_genLink = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_country = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_tel
        '
        Me.tb_tel.Location = New System.Drawing.Point(139, 37)
        Me.tb_tel.Name = "tb_tel"
        Me.tb_tel.Size = New System.Drawing.Size(168, 20)
        Me.tb_tel.TabIndex = 0
        '
        'bt_genLink
        '
        Me.bt_genLink.Location = New System.Drawing.Point(329, 35)
        Me.bt_genLink.Name = "bt_genLink"
        Me.bt_genLink.Size = New System.Drawing.Size(75, 23)
        Me.bt_genLink.TabIndex = 1
        Me.bt_genLink.Text = "Open"
        Me.bt_genLink.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter phone number"
        '
        'cb_country
        '
        Me.cb_country.FormattingEnabled = True
        Me.cb_country.Location = New System.Drawing.Point(13, 37)
        Me.cb_country.Name = "cb_country"
        Me.cb_country.Size = New System.Drawing.Size(120, 21)
        Me.cb_country.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Country"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 93)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_country)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_genLink)
        Me.Controls.Add(Me.tb_tel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "NAWLG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_tel As TextBox
    Friend WithEvents bt_genLink As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_country As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label2 As Label
End Class
