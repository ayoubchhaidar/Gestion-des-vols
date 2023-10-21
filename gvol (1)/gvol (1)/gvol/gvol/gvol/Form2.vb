Imports System.IO

Public Class Form2
    Dim dates As Date = Format(Date.Now, "short date")
    Dim nhar As Boolean = True
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
        Me.Hide()
        

    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If Not IsNumeric(TextBox3.Text) Then

            TextBox3.Text = ""
            TextBox3.Focus()
            MsgBox("doit etre numerique")
        End If

    End Sub

    Private Sub TextBox4_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("doit etre numerique")
            TextBox4.Text = ""
            TextBox4.Focus()

        End If
    End Sub

    Private Sub TextBox6_lostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        If TextBox6.Text.Contains("@") And TextBox6.Text.Contains(".com") Then
        Else
            MsgBox("email doit contenir au moin @ est un  point ", vbCritical, "format de email incorrecte")
        End If
    End Sub






    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim fs As New FileStream("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\nom&prenom.txt", FileMode.Open, FileAccess.ReadWrite)
        Dim sw As New StreamWriter(fs)
        Dim sr1 As New StreamReader(fs)

        Dim tab() As String
        Dim tab2() As String
        Dim ch As String
        Dim ch2 As String
        Dim t As Integer = 0
        ch = TextBox3.Text + "*" + TextBox2.Text + "*" + TextBox1.Text + "*" + TextBox4.Text + "*" + TextBox5.Text + "*" + TextBox6.Text + "*" + TextBox7.Text
        tab = ch.Split("*")
        While (t = 0) And (sr1.Peek > -1)
            ch2 = sr1.ReadLine()
            tab2 = ch2.Split("*")
            If String.Compare(tab(0), tab2(0)) = 0 Then
                t = 1
            End If
        End While
        If TextBox3.Text = "" Or TextBox2.Text = "" Or TextBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Toute le formulaire doit etre remplis")
        End If

        If (t = 1) Then
            MsgBox("Utilisateur existant")


        Else
            Form4.Show()
            Me.Hide()
            sw.WriteLine(ch)
            TextBox3.Text = ""
            TextBox2.Text = ""
            TextBox1.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""

        End If



        sw.Close()
        sr1.Close()

        fs.Close()
    End Sub


    

    Private Sub TextBox5_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.GotFocus

        MonthCalendar1.Visible = True
        TextBox5.ReadOnly = True



    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus

        MonthCalendar1.Visible = False




    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim cher As String
        cher = e.KeyChar
        If ((Asc(cher.ToLower) < 97 Or Asc(cher.ToLower) > 122) And Asc(cher) <> 8) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub MonthCalendar1_Dateselected(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim nhar As Date
        nhar = MonthCalendar1.SelectionRange.End

        If (DateDiff(DateInterval.Year, nhar, dates) >= 18) Then
            TextBox5.Text = Format(MonthCalendar1.SelectionRange.End, "short date")

        Else
            MsgBox("Date de naissance incorrect", vbCritical, "age est inferieure a 18 ans")
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim cher As String
        cher = e.KeyChar
        If ((Asc(cher.ToLower) < 97 Or Asc(cher.ToLower) > 122) And Asc(cher) <> 8) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class