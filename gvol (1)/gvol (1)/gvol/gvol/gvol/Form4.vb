Imports System.IO
Public Class Form4


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Label5.Hide()
        ListBox1.Hide()
        Label2.Text = "Prenom:" + Form3.tab(6)
        Label2.Show()
        Label3.Text = "Nom:" + Form3.tab(2)
        Label3.Show()
        Label4.Text = "Tel:" + Form3.tab(3)
        Label4.Show()
        Label7.Text = "Email:" + Form3.tab(5)
        Label7.Show()


    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ListBox1.Items.Clear()
        Label6.Show()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label7.Hide()
        ListBox1.Show()
        Label5.Show()
        Dim fs As New FileStream("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\reservations.txt", FileMode.Open, FileAccess.Read)
        Dim sw As New StreamReader(fs)
        Dim s As String
        Dim tab1() As String
        While sw.Peek > -1
            s = sw.ReadLine
            tab1 = s.Split("#")
            If tab1(0) = Form3.tab(5) Then
                ListBox1.Items.Add(s)
            End If



        End While
        sw.Close()
        fs.Close()


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        Button1.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fs As New FileStream("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\reservations.txt", FileMode.Open, FileAccess.Read)
        Dim sw As New StreamReader(fs)
        Dim fs1 As New FileStream("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\reservations1.txt", FileMode.Append, FileAccess.Write)
        Dim sw1 As New StreamWriter(fs1)

        While sw.Peek > -1
            If sw.ReadLine <> (Form3.tab(5) + "#" + ListBox1.SelectedItem) Then
                sw1.WriteLine(sw.ReadLine)

            End If
        End While
        sw1.Close()
        fs1.Close()
        sw.Close()
        fs.Close()
        My.Computer.FileSystem.DeleteFile("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\reservations.txt")
        My.Computer.FileSystem.RenameFile("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\reservations1.txt", "reservations.txt")
        Label6.Hide()
        ListBox1.Hide()
        Label5.Hide()




    End Sub
End Class
