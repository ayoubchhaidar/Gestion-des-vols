Imports System.IO
Public Class Form3
      Public tab() As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Contains("@") And TextBox1.Text.Contains(".com") Then
        Else
            MsgBox("format de email incorrecte")
        End If
        Dim fs1 As New FileStream("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\nom&prenom.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs1)
        Dim s As String

        Dim trouve As Boolean = False
        While ((sr.Peek > -1) And (trouve = False))
            s = sr.ReadLine
            TAB = s.Split("*")
            If (TAB(5) = TextBox1.Text) Then
                If (TAB(1) = TextBox2.Text) Then
                    trouve = True
                End If
            End If
        End While
        sr.Close()
        fs1.Close()
        If (trouve = True) Then
            Form4.Show()
            Me.Hide()








        Else
            MsgBox("Email ou  mot de passe incorrect", vbCritical, "attention")
        End If




    End Sub



    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_LostFocus(sender As System.Object, e As System.EventArgs) Handles TextBox1.LostFocus
        
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub
End Class