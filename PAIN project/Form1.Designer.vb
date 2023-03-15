<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FILE1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenOriginalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lstPerson = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.txtInvest = New System.Windows.Forms.TextBox()
        Me.txtPercent = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lstHide = New System.Windows.Forms.ListBox()
        Me.lblInvestments = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIlesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(985, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIlesToolStripMenuItem
        '
        Me.FIlesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILE1ToolStripMenuItem, Me.OpenOriginalToolStripMenuItem})
        Me.FIlesToolStripMenuItem.Name = "FIlesToolStripMenuItem"
        Me.FIlesToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.FIlesToolStripMenuItem.Text = "FIles"
        '
        'FILE1ToolStripMenuItem
        '
        Me.FILE1ToolStripMenuItem.Name = "FILE1ToolStripMenuItem"
        Me.FILE1ToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.FILE1ToolStripMenuItem.Text = "Chose File"
        '
        'OpenOriginalToolStripMenuItem
        '
        Me.OpenOriginalToolStripMenuItem.Name = "OpenOriginalToolStripMenuItem"
        Me.OpenOriginalToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.OpenOriginalToolStripMenuItem.Text = "Open Original"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(835, 72)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 91)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Person"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(835, 201)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(123, 91)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove person"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(835, 332)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 91)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Number of Investors:"
        '
        'lstData
        '
        Me.lstData.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 16
        Me.lstData.Location = New System.Drawing.Point(12, 38)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(256, 404)
        Me.lstData.TabIndex = 5
        '
        'lblNumber
        '
        Me.lblNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumber.Location = New System.Drawing.Point(363, 146)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(83, 25)
        Me.lblNumber.TabIndex = 6
        '
        'lstPerson
        '
        Me.lstPerson.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstPerson.FormattingEnabled = True
        Me.lstPerson.ItemHeight = 16
        Me.lstPerson.Location = New System.Drawing.Point(294, 323)
        Me.lstPerson.Name = "lstPerson"
        Me.lstPerson.Size = New System.Drawing.Size(251, 100)
        Me.lstPerson.TabIndex = 7
        Me.lstPerson.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Selected Person"
        Me.Label3.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtFind
        '
        Me.txtFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFind.Location = New System.Drawing.Point(347, 72)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(110, 22)
        Me.txtFind.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Find Investor:"
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(357, 106)
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(100, 22)
        Me.txtPerson.TabIndex = 15
        Me.txtPerson.Visible = False
        '
        'txtInvest
        '
        Me.txtInvest.Location = New System.Drawing.Point(357, 174)
        Me.txtInvest.Name = "txtInvest"
        Me.txtInvest.Size = New System.Drawing.Size(100, 22)
        Me.txtInvest.TabIndex = 16
        Me.txtInvest.Visible = False
        '
        'txtPercent
        '
        Me.txtPercent.Location = New System.Drawing.Point(357, 235)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(100, 22)
        Me.txtPercent.TabIndex = 17
        Me.txtPercent.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(382, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Name:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Investment amount"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Investment Percentage"
        Me.Label6.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirm.Location = New System.Drawing.Point(835, 72)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(123, 91)
        Me.btnConfirm.TabIndex = 21
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        Me.btnConfirm.Visible = False
        '
        'lstHide
        '
        Me.lstHide.FormattingEnabled = True
        Me.lstHide.ItemHeight = 16
        Me.lstHide.Location = New System.Drawing.Point(501, 38)
        Me.lstHide.Name = "lstHide"
        Me.lstHide.Size = New System.Drawing.Size(308, 260)
        Me.lstHide.TabIndex = 22
        Me.lstHide.Visible = False
        '
        'lblInvestments
        '
        Me.lblInvestments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvestments.Location = New System.Drawing.Point(9, 50)
        Me.lblInvestments.Name = "lblInvestments"
        Me.lblInvestments.Size = New System.Drawing.Size(100, 33)
        Me.lblInvestments.TabIndex = 23
        '
        'lblPercentage
        '
        Me.lblPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercentage.Location = New System.Drawing.Point(125, 50)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(100, 33)
        Me.lblPercentage.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(115, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Percentage"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Investments"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPercentage)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblInvestments)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(584, 332)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 86)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected Person"
        Me.GroupBox1.Visible = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(985, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstHide)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPercent)
        Me.Controls.Add(Me.txtInvest)
        Me.Controls.Add(Me.txtPerson)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstPerson)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "IDkMan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FILE1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstData As ListBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents lstPerson As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPerson As TextBox
    Friend WithEvents txtInvest As TextBox
    Friend WithEvents txtPercent As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lstHide As ListBox
    Friend WithEvents lblInvestments As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents OpenOriginalToolStripMenuItem As ToolStripMenuItem
End Class
