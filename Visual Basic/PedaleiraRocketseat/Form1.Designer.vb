<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbb_portas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_conectar = New System.Windows.Forms.Button()
        Me.bt_Desconectar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbb_portas
        '
        Me.cbb_portas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_portas.FormattingEnabled = True
        Me.cbb_portas.Location = New System.Drawing.Point(12, 25)
        Me.cbb_portas.Name = "cbb_portas"
        Me.cbb_portas.Size = New System.Drawing.Size(133, 21)
        Me.cbb_portas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecione uma porta"
        '
        'bt_conectar
        '
        Me.bt_conectar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_conectar.Location = New System.Drawing.Point(151, 11)
        Me.bt_conectar.Name = "bt_conectar"
        Me.bt_conectar.Size = New System.Drawing.Size(89, 23)
        Me.bt_conectar.TabIndex = 2
        Me.bt_conectar.Text = "Conectar"
        Me.bt_conectar.UseVisualStyleBackColor = True
        '
        'bt_Desconectar
        '
        Me.bt_Desconectar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Desconectar.Location = New System.Drawing.Point(151, 36)
        Me.bt_Desconectar.Name = "bt_Desconectar"
        Me.bt_Desconectar.Size = New System.Drawing.Size(89, 23)
        Me.bt_Desconectar.TabIndex = 3
        Me.bt_Desconectar.Text = "Desconectar"
        Me.bt_Desconectar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 64)
        Me.Controls.Add(Me.bt_Desconectar)
        Me.Controls.Add(Me.bt_conectar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbb_portas)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Pedaleira RocketSeat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbb_portas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_conectar As Button
    Friend WithEvents bt_Desconectar As Button
End Class
