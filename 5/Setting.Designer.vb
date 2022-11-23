<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonP5 = New System.Windows.Forms.Button()
        Me.ButtonP4 = New System.Windows.Forms.Button()
        Me.ButtonP3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Player"
        '
        'ButtonP5
        '
        Me.ButtonP5.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.ButtonP5.Location = New System.Drawing.Point(170, 47)
        Me.ButtonP5.Name = "ButtonP5"
        Me.ButtonP5.Size = New System.Drawing.Size(73, 48)
        Me.ButtonP5.TabIndex = 6
        Me.ButtonP5.Text = "5"
        Me.ButtonP5.UseVisualStyleBackColor = True
        '
        'ButtonP4
        '
        Me.ButtonP4.Enabled = False
        Me.ButtonP4.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.ButtonP4.Location = New System.Drawing.Point(91, 47)
        Me.ButtonP4.Name = "ButtonP4"
        Me.ButtonP4.Size = New System.Drawing.Size(73, 48)
        Me.ButtonP4.TabIndex = 5
        Me.ButtonP4.Text = "4"
        Me.ButtonP4.UseVisualStyleBackColor = True
        '
        'ButtonP3
        '
        Me.ButtonP3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.ButtonP3.Location = New System.Drawing.Point(12, 47)
        Me.ButtonP3.Name = "ButtonP3"
        Me.ButtonP3.Size = New System.Drawing.Size(73, 48)
        Me.ButtonP3.TabIndex = 4
        Me.ButtonP3.Text = "3"
        Me.ButtonP3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(249, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 48)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 106)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonP5)
        Me.Controls.Add(Me.ButtonP4)
        Me.Controls.Add(Me.ButtonP3)
        Me.Name = "Setting"
        Me.Text = "Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonP5 As System.Windows.Forms.Button
    Friend WithEvents ButtonP4 As System.Windows.Forms.Button
    Friend WithEvents ButtonP3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
