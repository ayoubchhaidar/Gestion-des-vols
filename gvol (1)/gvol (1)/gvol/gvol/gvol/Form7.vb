Imports System.IO
Public Class Form7

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim fs As New FileStream("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\vols.txt", FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        sw.WriteLine(TextBox1.Text + "#" + TextBox2.Text + "#" + TextBox3.Text + ";" + TextBox4.Text + ";" + TextBox5.Text + ";" + TextBox6.Text)
        sw.Close()
        fs.Close()

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class