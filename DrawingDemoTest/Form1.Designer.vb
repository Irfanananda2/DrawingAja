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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadMidPoint = New System.Windows.Forms.RadioButton()
        Me.RadDDA = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumY1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumY2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxColour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(11, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 400)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(664, 366)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(197, 60)
        Me.btnDraw.TabIndex = 1
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'NumY1
        '
        Me.NumY1.Location = New System.Drawing.Point(737, 253)
        Me.NumY1.Maximum = New Decimal(New Integer() {399, 0, 0, 0})
        Me.NumY1.Name = "NumY1"
        Me.NumY1.Size = New System.Drawing.Size(120, 27)
        Me.NumY1.TabIndex = 2
        '
        'NumX2
        '
        Me.NumX2.Location = New System.Drawing.Point(737, 286)
        Me.NumX2.Maximum = New Decimal(New Integer() {499, 0, 0, 0})
        Me.NumX2.Name = "NumX2"
        Me.NumX2.Size = New System.Drawing.Size(120, 27)
        Me.NumX2.TabIndex = 3
        '
        'NumY2
        '
        Me.NumY2.Location = New System.Drawing.Point(737, 319)
        Me.NumY2.Maximum = New Decimal(New Integer() {399, 0, 0, 0})
        Me.NumY2.Name = "NumY2"
        Me.NumY2.Size = New System.Drawing.Size(120, 27)
        Me.NumY2.TabIndex = 4
        '
        'NumX1
        '
        Me.NumX1.Location = New System.Drawing.Point(737, 220)
        Me.NumX1.Maximum = New Decimal(New Integer() {499, 0, 0, 0})
        Me.NumX1.Name = "NumX1"
        Me.NumX1.Size = New System.Drawing.Size(120, 27)
        Me.NumX1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(676, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "X1 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(676, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Y1 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(676, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "X2 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(676, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Y2 :"
        '
        'NumGreen
        '
        Me.NumGreen.Location = New System.Drawing.Point(737, 78)
        Me.NumGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumGreen.Name = "NumGreen"
        Me.NumGreen.Size = New System.Drawing.Size(120, 27)
        Me.NumGreen.TabIndex = 2
        '
        'NumBlue
        '
        Me.NumBlue.Location = New System.Drawing.Point(737, 111)
        Me.NumBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumBlue.Name = "NumBlue"
        Me.NumBlue.Size = New System.Drawing.Size(120, 27)
        Me.NumBlue.TabIndex = 3
        '
        'NumRed
        '
        Me.NumRed.Location = New System.Drawing.Point(737, 45)
        Me.NumRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumRed.Name = "NumRed"
        Me.NumRed.Size = New System.Drawing.Size(120, 27)
        Me.NumRed.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(676, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Red :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(676, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Green :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(676, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Blue :"
        '
        'PicBoxColour
        '
        Me.PicBoxColour.BackColor = System.Drawing.SystemColors.Control
        Me.PicBoxColour.Location = New System.Drawing.Point(556, 47)
        Me.PicBoxColour.Name = "PicBoxColour"
        Me.PicBoxColour.Size = New System.Drawing.Size(63, 58)
        Me.PicBoxColour.TabIndex = 7
        Me.PicBoxColour.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(556, 366)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 60)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(11, 457)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(111, 45)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(136, 457)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(111, 45)
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
        Me.TextBox1.Location = New System.Drawing.Point(266, 466)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 27)
        Me.TextBox1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadMidPoint)
        Me.GroupBox1.Controls.Add(Me.RadDDA)
        Me.GroupBox1.Location = New System.Drawing.Point(556, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 131)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadMidPoint
        '
        Me.RadMidPoint.AutoSize = True
        Me.RadMidPoint.Location = New System.Drawing.Point(16, 61)
        Me.RadMidPoint.Name = "RadMidPoint"
        Me.RadMidPoint.Size = New System.Drawing.Size(89, 24)
        Me.RadMidPoint.TabIndex = 1
        Me.RadMidPoint.TabStop = True
        Me.RadMidPoint.Text = "MidPoint"
        Me.RadMidPoint.UseVisualStyleBackColor = True
        '
        'RadDDA
        '
        Me.RadDDA.AutoSize = True
        Me.RadDDA.Location = New System.Drawing.Point(16, 31)
        Me.RadDDA.Name = "RadDDA"
        Me.RadDDA.Size = New System.Drawing.Size(62, 24)
        Me.RadDDA.TabIndex = 0
        Me.RadDDA.TabStop = True
        Me.RadDDA.Text = "DDA"
        Me.RadDDA.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 621)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadMidPoint As RadioButton
    Friend WithEvents RadDDA As RadioButton
End Class
