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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radTest = New System.Windows.Forms.RadioButton()
        Me.RadMidPoint = New System.Windows.Forms.RadioButton()
        Me.RadDDA = New System.Windows.Forms.RadioButton()
        Me.btnOrange = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnBrown = New System.Windows.Forms.Button()
        Me.btnBlack = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnPink = New System.Windows.Forms.Button()
        Me.BtnWhite = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnLGray = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnAqua = New System.Windows.Forms.Button()
        Me.btnDGray = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkbxPattern = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
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
        Me.GroupBox2.SuspendLayout()
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
        Me.btnDraw.Location = New System.Drawing.Point(664, 433)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(197, 60)
        Me.btnDraw.TabIndex = 1
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'NumY1
        '
        Me.NumY1.Location = New System.Drawing.Point(737, 320)
        Me.NumY1.Maximum = New Decimal(New Integer() {399, 0, 0, 0})
        Me.NumY1.Name = "NumY1"
        Me.NumY1.Size = New System.Drawing.Size(120, 27)
        Me.NumY1.TabIndex = 1
        '
        'NumX2
        '
        Me.NumX2.Location = New System.Drawing.Point(737, 353)
        Me.NumX2.Maximum = New Decimal(New Integer() {499, 0, 0, 0})
        Me.NumX2.Name = "NumX2"
        Me.NumX2.Size = New System.Drawing.Size(120, 27)
        Me.NumX2.TabIndex = 2
        '
        'NumY2
        '
        Me.NumY2.Location = New System.Drawing.Point(737, 386)
        Me.NumY2.Maximum = New Decimal(New Integer() {399, 0, 0, 0})
        Me.NumY2.Name = "NumY2"
        Me.NumY2.Size = New System.Drawing.Size(120, 27)
        Me.NumY2.TabIndex = 3
        '
        'NumX1
        '
        Me.NumX1.Location = New System.Drawing.Point(737, 287)
        Me.NumX1.Maximum = New Decimal(New Integer() {499, 0, 0, 0})
        Me.NumX1.Name = "NumX1"
        Me.NumX1.Size = New System.Drawing.Size(120, 27)
        Me.NumX1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(676, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "X1 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(676, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Y1 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(676, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "X2 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(676, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Y2 :"
        '
        'NumGreen
        '
        Me.NumGreen.Location = New System.Drawing.Point(71, 107)
        Me.NumGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumGreen.Name = "NumGreen"
        Me.NumGreen.Size = New System.Drawing.Size(120, 27)
        Me.NumGreen.TabIndex = 2
        '
        'NumBlue
        '
        Me.NumBlue.Location = New System.Drawing.Point(71, 140)
        Me.NumBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumBlue.Name = "NumBlue"
        Me.NumBlue.Size = New System.Drawing.Size(120, 27)
        Me.NumBlue.TabIndex = 3
        '
        'NumRed
        '
        Me.NumRed.Location = New System.Drawing.Point(71, 74)
        Me.NumRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumRed.Name = "NumRed"
        Me.NumRed.Size = New System.Drawing.Size(120, 27)
        Me.NumRed.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Red :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Green :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Blue :"
        '
        'PicBoxColour
        '
        Me.PicBoxColour.BackColor = System.Drawing.SystemColors.Control
        Me.PicBoxColour.Location = New System.Drawing.Point(12, 29)
        Me.PicBoxColour.Name = "PicBoxColour"
        Me.PicBoxColour.Size = New System.Drawing.Size(178, 33)
        Me.PicBoxColour.TabIndex = 7
        Me.PicBoxColour.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(556, 433)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(266, 466)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 27)
        Me.TextBox1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radTest)
        Me.GroupBox1.Controls.Add(Me.RadMidPoint)
        Me.GroupBox1.Controls.Add(Me.RadDDA)
        Me.GroupBox1.Location = New System.Drawing.Point(556, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 131)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algorithm"
        '
        'radTest
        '
        Me.radTest.AutoSize = True
        Me.radTest.Location = New System.Drawing.Point(16, 91)
        Me.radTest.Name = "radTest"
        Me.radTest.Size = New System.Drawing.Size(56, 24)
        Me.radTest.TabIndex = 2
        Me.radTest.TabStop = True
        Me.radTest.Text = "Test"
        Me.radTest.UseVisualStyleBackColor = True
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
        'btnOrange
        '
        Me.btnOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrange.Location = New System.Drawing.Point(196, 65)
        Me.btnOrange.Name = "btnOrange"
        Me.btnOrange.Size = New System.Drawing.Size(30, 30)
        Me.btnOrange.TabIndex = 12
        Me.btnOrange.UseVisualStyleBackColor = False
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.Color.Blue
        Me.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlue.Location = New System.Drawing.Point(232, 65)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(30, 30)
        Me.btnBlue.TabIndex = 12
        Me.btnBlue.UseVisualStyleBackColor = False
        '
        'btnBrown
        '
        Me.btnBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrown.Location = New System.Drawing.Point(268, 65)
        Me.btnBrown.Name = "btnBrown"
        Me.btnBrown.Size = New System.Drawing.Size(30, 30)
        Me.btnBrown.TabIndex = 12
        Me.btnBrown.UseVisualStyleBackColor = False
        '
        'btnBlack
        '
        Me.btnBlack.BackColor = System.Drawing.Color.Black
        Me.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlack.Location = New System.Drawing.Point(268, 101)
        Me.btnBlack.Name = "btnBlack"
        Me.btnBlack.Size = New System.Drawing.Size(30, 30)
        Me.btnBlack.TabIndex = 12
        Me.btnBlack.UseVisualStyleBackColor = False
        '
        'btnYellow
        '
        Me.btnYellow.BackColor = System.Drawing.Color.Yellow
        Me.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYellow.Location = New System.Drawing.Point(196, 101)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(30, 30)
        Me.btnYellow.TabIndex = 12
        Me.btnYellow.UseVisualStyleBackColor = False
        '
        'btnPink
        '
        Me.btnPink.BackColor = System.Drawing.Color.Fuchsia
        Me.btnPink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPink.Location = New System.Drawing.Point(232, 101)
        Me.btnPink.Name = "btnPink"
        Me.btnPink.Size = New System.Drawing.Size(30, 30)
        Me.btnPink.TabIndex = 12
        Me.btnPink.UseVisualStyleBackColor = False
        '
        'BtnWhite
        '
        Me.BtnWhite.BackColor = System.Drawing.Color.White
        Me.BtnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWhite.Location = New System.Drawing.Point(268, 137)
        Me.BtnWhite.Name = "BtnWhite"
        Me.BtnWhite.Size = New System.Drawing.Size(30, 30)
        Me.BtnWhite.TabIndex = 12
        Me.BtnWhite.UseVisualStyleBackColor = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.Lime
        Me.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGreen.Location = New System.Drawing.Point(196, 137)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(30, 30)
        Me.btnGreen.TabIndex = 12
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'btnLGray
        '
        Me.btnLGray.BackColor = System.Drawing.Color.Silver
        Me.btnLGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLGray.Location = New System.Drawing.Point(232, 137)
        Me.btnLGray.Name = "btnLGray"
        Me.btnLGray.Size = New System.Drawing.Size(30, 30)
        Me.btnLGray.TabIndex = 12
        Me.btnLGray.UseVisualStyleBackColor = False
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRed.Location = New System.Drawing.Point(196, 29)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(30, 30)
        Me.btnRed.TabIndex = 12
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'btnAqua
        '
        Me.btnAqua.BackColor = System.Drawing.Color.Aqua
        Me.btnAqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAqua.Location = New System.Drawing.Point(232, 29)
        Me.btnAqua.Name = "btnAqua"
        Me.btnAqua.Size = New System.Drawing.Size(30, 30)
        Me.btnAqua.TabIndex = 12
        Me.btnAqua.UseVisualStyleBackColor = False
        '
        'btnDGray
        '
        Me.btnDGray.BackColor = System.Drawing.Color.Gray
        Me.btnDGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDGray.Location = New System.Drawing.Point(268, 29)
        Me.btnDGray.Name = "btnDGray"
        Me.btnDGray.Size = New System.Drawing.Size(30, 30)
        Me.btnDGray.TabIndex = 12
        Me.btnDGray.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLGray)
        Me.GroupBox2.Controls.Add(Me.PicBoxColour)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnPink)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnGreen)
        Me.GroupBox2.Controls.Add(Me.NumRed)
        Me.GroupBox2.Controls.Add(Me.NumBlue)
        Me.GroupBox2.Controls.Add(Me.btnYellow)
        Me.GroupBox2.Controls.Add(Me.NumGreen)
        Me.GroupBox2.Controls.Add(Me.BtnWhite)
        Me.GroupBox2.Controls.Add(Me.btnDGray)
        Me.GroupBox2.Controls.Add(Me.btnOrange)
        Me.GroupBox2.Controls.Add(Me.btnBlue)
        Me.GroupBox2.Controls.Add(Me.btnBrown)
        Me.GroupBox2.Controls.Add(Me.btnRed)
        Me.GroupBox2.Controls.Add(Me.btnAqua)
        Me.GroupBox2.Controls.Add(Me.btnBlack)
        Me.GroupBox2.Location = New System.Drawing.Point(556, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 177)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color Setting"
        '
        'chkbxPattern
        '
        Me.chkbxPattern.AutoSize = True
        Me.chkbxPattern.Location = New System.Drawing.Point(566, 247)
        Me.chkbxPattern.Name = "chkbxPattern"
        Me.chkbxPattern.Size = New System.Drawing.Size(123, 24)
        Me.chkbxPattern.TabIndex = 14
        Me.chkbxPattern.Text = "Dotted Patern"
        Me.chkbxPattern.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 621)
        Me.Controls.Add(Me.chkbxPattern)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumX1)
        Me.Controls.Add(Me.NumY2)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadMidPoint As RadioButton
    Friend WithEvents RadDDA As RadioButton
    Friend WithEvents radTest As RadioButton
    Friend WithEvents btnOrange As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnBrown As Button
    Friend WithEvents btnBlack As Button
    Friend WithEvents btnYellow As Button
    Friend WithEvents btnPink As Button
    Friend WithEvents BtnWhite As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnLGray As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents btnAqua As Button
    Friend WithEvents btnDGray As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkbxPattern As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
