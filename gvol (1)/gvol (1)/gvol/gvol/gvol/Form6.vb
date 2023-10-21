Public Class Form6

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Hide()
            TextBox1.Show()
            TextBox2.Show()
            TextBox3.Show()
            Label2.Show()
            Label3.Show()
            Label4.Show()
        Else
            CheckBox1.Show()
            CheckBox2.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            TextBox3.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Hide()
            TextBox1.Show()
            TextBox2.Show()
            TextBox3.Show()
            Label2.Show()
            Label3.Show()
            Label4.Show()
        Else
            CheckBox1.Show()
            CheckBox2.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            TextBox3.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        MonthCalendar1.Hide()
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        MonthCalendar1.Show()

    End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim nhar As Date
        nhar = MonthCalendar1.SelectionRange.End
        If nhar > Today Then
            TextBox2.Text = nhar
        ElseIf nhar <= Today Then
            nhar = MonthCalendar1.SelectionRange.End
            MsgBox("date invalide")
        End If


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) Then
            TextBox1.Text = ""
            TextBox1.Focus()


        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("tous les champs doit etre remplis")
        Else
            MsgBox("felicitation reservation avec Succès")
            Me.Hide()
            Form4.Show()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class