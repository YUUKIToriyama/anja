<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.label_1 = New System.Windows.Forms.Label()
        Me.label_2 = New System.Windows.Forms.Label()
        Me.label_3 = New System.Windows.Forms.Label()
        Me.label_4 = New System.Windows.Forms.Label()
        Me.button_1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label_1
        '
        Me.label_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_1.Font = New System.Drawing.Font("MS UI Gothic", 50.0!)
        Me.label_1.Location = New System.Drawing.Point(27, 31)
        Me.label_1.Name = "label_1"
        Me.label_1.Size = New System.Drawing.Size(70, 70)
        Me.label_1.TabIndex = 0
        Me.label_1.Text = "0"
        Me.label_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label_2
        '
        Me.label_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_2.Font = New System.Drawing.Font("MS UI Gothic", 50.0!)
        Me.label_2.Location = New System.Drawing.Point(103, 31)
        Me.label_2.Name = "label_2"
        Me.label_2.Size = New System.Drawing.Size(70, 70)
        Me.label_2.TabIndex = 1
        Me.label_2.Text = "0"
        Me.label_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label_3
        '
        Me.label_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_3.Font = New System.Drawing.Font("MS UI Gothic", 50.0!)
        Me.label_3.Location = New System.Drawing.Point(179, 31)
        Me.label_3.Name = "label_3"
        Me.label_3.Size = New System.Drawing.Size(70, 70)
        Me.label_3.TabIndex = 2
        Me.label_3.Text = "0"
        Me.label_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label_4
        '
        Me.label_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label_4.Font = New System.Drawing.Font("MS UI Gothic", 50.0!)
        Me.label_4.Location = New System.Drawing.Point(255, 31)
        Me.label_4.Name = "label_4"
        Me.label_4.Size = New System.Drawing.Size(70, 70)
        Me.label_4.TabIndex = 3
        Me.label_4.Text = "0"
        Me.label_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'button_1
        '
        Me.button_1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.button_1.Location = New System.Drawing.Point(364, 31)
        Me.button_1.Name = "button_1"
        Me.button_1.Size = New System.Drawing.Size(137, 70)
        Me.button_1.TabIndex = 4
        Me.button_1.Text = "increment"
        Me.button_1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(507, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 70)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 131)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.button_1)
        Me.Controls.Add(Me.label_4)
        Me.Controls.Add(Me.label_3)
        Me.Controls.Add(Me.label_2)
        Me.Controls.Add(Me.label_1)
        Me.Name = "Form1"
        Me.Text = "number_winder"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents label_1 As Label
    Friend WithEvents label_2 As Label
    Friend WithEvents label_3 As Label
    Friend WithEvents label_4 As Label
    Friend WithEvents button_1 As Button
    Friend WithEvents Button1 As Button
End Class
