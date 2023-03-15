
Option Explicit On
Option Infer Off
Option Strict On

'Imports System.Diagnostics.Eventing
Imports System.IO
'Imports System.Runtime.Remoting
'Imports System.Security.Cryptography
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Public Class FrmMain
    Dim lineCount As Integer
    Private people As String()
    Private skipLines As Integer = 3
    Dim indexOfPerson As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub FILE1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILE1ToolStripMenuItem.Click
        OpenFileDialog1.Title = "Please select a DB file"
        OpenFileDialog1.InitialDirectory = "C:\Users\griff\OneDrive\Documents\Visual Studio 2022\PAIN Solution\PAIN project\bin\Debug"
        OpenFileDialog1.Filter = "DB Files|*.txt"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim lines() As String = File.ReadAllLines(OpenFileDialog1.FileName)
            lstHide.Items.Clear()
            lstHide.Items.AddRange(lines)
        End If

        skipLines = 3
        people = File.ReadAllLines(OpenFileDialog1.FileName)
        For line As Integer = 0 To people.Length - 1
            If line Mod skipLines = 0 Then
                lstData.Items.Add(people(line))
            End If
        Next

        lineCount = File.ReadAllLines(OpenFileDialog1.FileName).Length
        lblNumber.Text = CStr(lineCount / 3)

        lstData.SelectedIndex = 0
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        For counter As Integer = 0 To lstData.Items.Count - 1
            Dim item As String = lstData.Items(counter).ToString()
            Dim containsText As Boolean = item.IndexOf(txtFind.Text, StringComparison.CurrentCultureIgnoreCase) >= 0
            If containsText Then
                lstPerson.Items.Clear()
                lstPerson.Items.Add(item)
            End If
        Next

        lstPerson.Visible = True
    End Sub
    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged
        Dim indexOfPerson As Integer = lstData.Items.IndexOf(lstData.SelectedItem)

        GroupBox1.Visible = True
        Dim StartIndex As Integer = lstData.SelectedIndex * skipLines
        lblInvestments.Text = people(StartIndex + 1)
        lblPercentage.Text = people(StartIndex + 2)

        If lstHide.Items.Contains(lstData.SelectedItem) Then
            indexOfPerson = indexOfPerson * 3
            lstHide.SelectedIndex = indexOfPerson
        End If

        lineCount = File.ReadAllLines(OpenFileDialog1.FileName).Length
        lblNumber.Text = CStr(lineCount / 3)
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFind.KeyPress

        If (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True

        txtInvest.Visible = True
        txtPercent.Visible = True
        txtPerson.Visible = True
        btnConfirm.Visible = True

        txtFind.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        lblNumber.Visible = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim FileName As String = OpenFileDialog1.FileName
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False

        txtInvest.Visible = False
        txtPercent.Visible = False
        txtPerson.Visible = False
        btnConfirm.Visible = False

        txtFind.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        lblNumber.Visible = True

        Dim outFile As IO.StreamWriter

        outFile = IO.File.AppendText(OpenFileDialog1.FileName)
        outFile.WriteLine(txtPerson.Text)
        outFile.WriteLine(txtInvest.Text)
        outFile.WriteLine(txtPercent.Text)
        outFile.Close()

        lstData.Items.Clear()

        Dim lines() As String = IO.File.ReadAllLines(OpenFileDialog1.FileName)
        lstHide.Items.AddRange(lines)
        outFile.Close()

        skipLines = 3
        people = File.ReadAllLines(OpenFileDialog1.FileName)
        For line As Integer = 0 To people.Length - 1
            If line Mod skipLines = 0 Then
                lstData.Items.Add(people(line))
            End If
        Next

        lineCount = File.ReadAllLines(OpenFileDialog1.FileName).Length
        lblNumber.Text = lstData.Items.Count.ToString()

        lblInvestments.Text = ""
        lblPercentage.Text = ""
    End Sub
    Private Sub lstPerson_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPerson.SelectedIndexChanged
        Dim indexOfPerson As Integer = lstData.Items.IndexOf(lstPerson.SelectedItem)
        If lstData.Items.Contains(lstPerson.SelectedItem) Then
            lstData.SelectedIndex = indexOfPerson
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim FileName As String = OpenFileDialog1.FileName
        Dim Remove As Integer
        Remove = lstHide.SelectedIndex

        lstHide.Items.RemoveAt(Remove + 2)
        lstHide.Items.RemoveAt(Remove + 1)
        lstHide.Items.RemoveAt(Remove)

        My.Computer.FileSystem.DeleteFile(FileName)

        Dim w As New IO.StreamWriter(FileName)
        Dim i As Integer
        For i = 0 To lstHide.Items.Count - 1
            w.WriteLine(CType(lstHide.Items.Item(i), String))
        Next
        w.Close()
        lstHide.Items.Clear()
        lstData.Items.Clear()

        Dim lines() As String = IO.File.ReadAllLines(OpenFileDialog1.FileName)
        lstHide.Items.AddRange(lines)

        skipLines = 3
        people = File.ReadAllLines(OpenFileDialog1.FileName)
        For line As Integer = 0 To people.Length - 1
            If line Mod skipLines = 0 Then
                lstData.Items.Add(people(line))
            End If
        Next

        lstData.SelectedIndex = 0

    End Sub
    Private Sub FrmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        lblNumber.Text = lstData.Items.Count.ToString()
    End Sub
End Class