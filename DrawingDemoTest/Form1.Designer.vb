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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.NumY1 = New System.Windows.Forms.NumericUpDown()
        Me.NumX2 = New System.Windows.Forms.NumericUpDown()
        Me.NumY2 = New System.Windows.Forms.NumericUpDown()
        Me.NumX1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumGreen = New System.Windows.Forms.NumericUpDown()
        Me.NumBlue = New System.Windows.Forms.NumericUpDown()
        Me.NumRed = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PicBoxColour = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumY1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumY2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxColour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(562, 380)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(747, 348)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(222, 57)
        Me.btnDraw.TabIndex = 1
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'NumY1
        '
        Me.NumY1.Location = New System.Drawing.Point(829, 240)
        Me.NumY1.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.NumY1.Name = "NumY1"
        Me.NumY1.Size = New System.Drawing.Size(135, 29)
        Me.NumY1.TabIndex = 2
        '
        'NumX2
        '
        Me.NumX2.Location = New System.Drawing.Point(829, 272)
        Me.NumX2.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumX2.Name = "NumX2"
        Me.NumX2.Size = New System.Drawing.Size(135, 29)
        Me.NumX2.TabIndex = 3
        '
        'NumY2
        '
        Me.NumY2.Location = New System.Drawing.Point(829, 303)
        Me.NumY2.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.NumY2.Name = "NumY2"
        Me.NumY2.Size = New System.Drawing.Size(135, 29)
        Me.NumY2.TabIndex = 4
        '
        'NumX1
        '
        Me.NumX1.Location = New System.Drawing.Point(829, 209)
        Me.NumX1.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumX1.Name = "NumX1"
        Me.NumX1.Size = New System.Drawing.Size(135, 29)
        Me.NumX1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(742, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "X1 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(742, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Y1 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(742, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "X2 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(742, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Y2 :"
        '
        'NumGreen
        '
        Me.NumGreen.Location = New System.Drawing.Point(829, 74)
        Me.NumGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumGreen.Name = "NumGreen"
        Me.NumGreen.Size = New System.Drawing.Size(135, 29)
        Me.NumGreen.TabIndex = 2
        '
        'NumBlue
        '
        Me.NumBlue.Location = New System.Drawing.Point(829, 105)
        Me.NumBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumBlue.Name = "NumBlue"
        Me.NumBlue.Size = New System.Drawing.Size(135, 29)
        Me.NumBlue.TabIndex = 3
        '
        'NumRed
        '
        Me.NumRed.Location = New System.Drawing.Point(829, 43)
        Me.NumRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumRed.Name = "NumRed"
        Me.NumRed.Size = New System.Drawing.Size(135, 29)
        Me.NumRed.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(742, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Red :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(742, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Green :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(742, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Blue :"
        '
        'PicBoxColour
        '
        Me.PicBoxColour.BackColor = System.Drawing.SystemColors.Control
        Me.PicBoxColour.Location = New System.Drawing.Point(626, 45)
        Me.PicBoxColour.Name = "PicBoxColour"
        Me.PicBoxColour.Size = New System.Drawing.Size(71, 55)
        Me.PicBoxColour.TabIndex = 7
        Me.PicBoxColour.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(626, 348)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 57)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(12, 434)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(125, 43)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(153, 434)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(125, 43)
        Me.BtnLoad.TabIndex = 9
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(299, 443)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 29)
        Me.TextBox1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 590)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.PicBoxColour)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumRed)
        Me.Controls.Add(Me.NumX1)
        Me.Controls.Add(Me.NumY2)
        Me.Controls.Add(Me.NumBlue)
        Me.Controls.Add(Me.NumGreen)
        Me.Controls.Add(Me.NumX2)
        Me.Controls.Add(Me.NumY1)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumY1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumY2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxColour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDraw As Button
    Friend WithEvents NumY1 As NumericUpDown
    Friend WithEvents NumX2 As NumericUpDown
    Friend WithEvents NumY2 As NumericUpDown
    Friend WithEvents NumX1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumGreen As NumericUpDown
    Friend WithEvents NumBlue As NumericUpDown
    Friend WithEvents NumRed As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PicBoxColour As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnLoad As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
End Class
