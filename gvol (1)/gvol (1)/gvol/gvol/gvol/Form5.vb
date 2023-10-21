Imports System.IO

Public Class Form5



    Private tt() As String
    Dim dates As Date = Format(Date.Now, "short date")
    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_LostFocus(sender As System.Object, e As System.EventArgs) Handles ComboBox1.LostFocus

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim nhar As Date
        nhar = MonthCalendar1.SelectionRange.End
        If nhar > Today Then
            TextBox1.Text = nhar
        ElseIf nhar <= Today Then
            nhar = MonthCalendar1.SelectionRange.End
            MsgBox("date invalide")
        End If



    End Sub

    Private Sub TextBox1_gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        MonthCalendar1.Visible = True

    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus

        MonthCalendar1.Visible = False

    End Sub

    Private Sub TextBox2_GotFocus(sender As System.Object, e As System.EventArgs) Handles TextBox2.GotFocus
        MonthCalendar2.Visible = True
    End Sub
    Private Sub TextBox2_LostFocus(sender As System.Object, e As System.EventArgs) Handles TextBox2.LostFocus
        MonthCalendar2.Visible = False
    End Sub



    Private Sub MonthCalendar2_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        Dim nhar1 As Date
        Dim nhar11 As Date
        nhar1 = MonthCalendar2.SelectionRange.End
        nhar11 = MonthCalendar1.SelectionRange.End
        If nhar1 > nhar11 Then
            TextBox2.Text = nhar1
        ElseIf nhar1 <= TextBox1.Text Then
            nhar1 = MonthCalendar2.SelectionRange.End
            MsgBox("date invalide")
        End If



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If ComboBox1.SelectedText = "" And ComboBox2.SelectedText = "" And TextBox1.Text = "" Then
            MsgBox("tous les elements doit etre remplis")
        End If
        Dim fs1 As New FileStream("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\recherche.txt", FileMode.Truncate, FileAccess.ReadWrite)
        Dim sw As New StreamWriter(fs1)
        Dim sr1 As New StreamReader(fs1)
        Dim research As String
        sw.WriteLine(ComboBox1.Text + "#" + ComboBox2.Text + "#" + TextBox1.Text)
        research = ComboBox1.Text + "#" + ComboBox2.Text + "#" + TextBox1.Text

        sw.Close()
        sr1.Close()
        fs1.Close()

        Dim fs As New FileStream("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\vols.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim tr As Integer
        Dim jj As String

        While sr.Peek > -1 And tr = 0
            tt = sr.ReadLine.Split(";")
            jj = tt(0)

            If jj = research Then
                tr = 1
                ListBox1.Items.Add(tt(3) + "#" + jj + "#" + tt(1))
            End If
        End While
        sr.Close()
        fs.Close()
        If tr = 0 Then
            MsgBox("Désolé aucun vol n’est disponible pour les dates sélectionnées")
        End If



    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs)
        TextBox2.Show()
        Label5.Show()

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.Show()
            Label5.Show()
        Else
            TextBox2.Hide()
            Label5.Hide()
        End If


    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs)
        TextBox2.Hide()
        Label5.Hide()

    End Sub

    Private Sub ComboBox2_LostFocus(sender As System.Object, e As System.EventArgs) Handles ComboBox2.LostFocus
        If ComboBox1.Text = ComboBox2.Text Then
            ComboBox2.Text = ""
            MsgBox("Le Pays D'arriver doit etre different")

        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Label6.Show()
        Label7.Show()
        ComboBox3.Show()
        ComboBox4.Show()
        Button2.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim fs As New FileStream("C:\Users\Ayoub\Desktop\gvol (1)\gvol\gvol\reservations.txt", FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        sw.WriteLine(Form3.tab(5) + "#" + ListBox1.SelectedItem + "#" + ComboBox3.SelectedItem + "#" + ComboBox4.SelectedItem + "#" + Label8.Text)
        sw.Close()
        fs.Close()

        ListBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label8.Text = "0"

        Form6.Show()





    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

        Dim priks As Integer
        Dim jett() As String
        jett = tt(2).Split("\")
        priks = Convert.ToInt32(jett(0))

        If ComboBox3.SelectedItem = "Classe Affaires" Then
            priks = priks * 1.5

        ElseIf ComboBox3.SelectedItem = "Premiére Classe " Then

            priks = priks * 2.5

        End If

        If ComboBox4.SelectedItem = "2" Then
            priks = priks * 2

        End If
        If ComboBox4.SelectedItem = "3" Then
            priks = priks * 3

        End If
        If ComboBox4.SelectedItem = "4" Then
            priks = priks * 4

        End If
        If ComboBox4.SelectedItem = "5" Then
            priks = priks * 5

        End If
        If ComboBox4.SelectedItem = "6" Then
            priks = priks * 6

        End If

        Label8.Text = priks.ToString + jett(1).ToString


        Label9.Show()
        Label8.Show()
        

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox4.Text = ""
        Label9.Hide()
        Label8.Hide()
    End Sub
End Class

