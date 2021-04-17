Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class FORM2
    Dim pic As Integer
    Dim drop As Integer
    Dim picloc As String
    Dim droploc As String
    Dim chk As Integer
    Dim line1 As String
    Dim line2 As String

    Private Sub CHURCHGATE_Click(sender As Object, e As EventArgs) Handles CHURCHGATE.Click
        If (chk = 0) Then
            picloc = "CHURCHGATE"
            pic = 0 - 114
            chk = 1
            line1 = "W"
            CHURCHGATE.BackColor = Color.Red

        ElseIf (chk = 1) Then
            droploc = "CHURCHGATE"
            drop = 0 - 114
            chk = 2
            line2 = "W"
            CHURCHGATE.BackColor = Color.Green
        End If
    End Sub

    Private Sub MUM_CEN_Click(sender As Object, e As EventArgs) Handles MUM_CEN.Click
        If (chk = 0) Then
            picloc = "MUM-CENTRAL"
            pic = 5 - 114
            chk = 1
            line1 = "W"
            MUM_CEN.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "MUM-CENTRAL"
            drop = 5 - 114
            chk = 2
            line2 = "W"
            MUM_CEN.BackColor = Color.Green
        End If
    End Sub

    Private Sub DADAR_W_Click(sender As Object, e As EventArgs) Handles DADAR_W.Click
        If (chk = 0) Then
            picloc = "DADAR"
            pic = 10 - 114
            chk = 1
            line1 = "W"
            DADAR_W.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "DADAR"
            drop = 10 - 114
            chk = 2
            line2 = "W"
            DADAR_W.BackColor = Color.Green
        End If
    End Sub

    Private Sub BANDRA_Click(sender As Object, e As EventArgs) Handles BANDRA.Click
        If (chk = 0) Then
            picloc = "DADAR"
            pic = 15 - 114
            chk = 1
            line1 = "W"
            BANDRA.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "DADAR"
            drop = 15 - 114
            chk = 2
            line2 = "W"
            BANDRA.BackColor = Color.Green
        End If

    End Sub

    Private Sub ANDHERI_Click(sender As Object, e As EventArgs) Handles ANDHERI.Click
        If (chk = 0) Then
            picloc = "ANDHERI"
            pic = 22 - 114
            chk = 1
            line1 = "W"
            ANDHERI.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "ANDHERI"
            drop = 22 - 114
            chk = 2
            line2 = "W"
            ANDHERI.BackColor = Color.Green
        End If
    End Sub

    Private Sub BOR_Click(sender As Object, e As EventArgs) Handles BOR.Click
        If (chk = 0) Then
            picloc = "BORIVILI"
            pic = 28 - 114
            chk = 1
            line1 = "W"
            BOR.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "BORIVILI"
            drop = 28 - 114
            chk = 2
            line2 = "W"
            BOR.BackColor = Color.Green
        End If
    End Sub

    Private Sub VASAI_Click(sender As Object, e As EventArgs) Handles VASAI.Click
        If (chk = 0) Then
            picloc = "VASAI"
            pic = 45 - 114
            chk = 1
            line1 = "W"
            VASAI.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "VASAI"
            drop = 45 - 114
            chk = 2
            line2 = "W"
            VASAI.BackColor = Color.Green
        End If
    End Sub

    Private Sub DAHANU_Click(sender As Object, e As EventArgs) Handles DAHANU.Click
        If (chk = 0) Then
            picloc = "DAHANU"
            pic = 114 - 114
            chk = 1
            line1 = "W"
            DAHANU.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "DAHANU"
            drop = 114 - 114
            chk = 2
            line2 = "W"
            DAHANU.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim temp As Integer
        Dim temp2 As Integer

        If line1 = "W" And line2 = "W" Then
            pic = pic - drop
            If pic < 0 Then
                pic = 0 - pic
            End If
            MessageBox.Show(pic)
        ElseIf line1 = "C" And line2 = "C" Then
            pic = pic - drop
            If pic < 0 Then
                pic = 0 - pic
            End If
            MessageBox.Show(pic)
        ElseIf line1 = "H" And line2 = "H" Then
            pic = pic - drop
            If pic < 0 Then
                pic = 0 - pic
            End If
            MessageBox.Show(pic)
        ElseIf line1 = "W" And line2 = "C" Then
            temp = 114 - 10
            pic = pic - temp
            temp2 = 110 - 10
            drop = drop - temp2

            pic = pic - drop
            If pic < 0 Then
                pic = 0 - pic
            End If
            MessageBox.Show(pic)
        ElseIf line1 = "C" And line2 = "W" Then
            temp = 114 - 10
            pic = pic - temp
            temp2 = 110 - 10
            drop = drop - temp2

            pic = pic - drop
            If pic < 0 Then
                pic = 0 - pic
            End If
            MessageBox.Show(pic)
        ElseIf line1 = "C" And line2 = "H" Then
            If pic < 0 Then
                pic = 0 - pic
            End If
            If drop < 0 Then
                drop = 0 - drop
            End If
            temp = 110 - 13
            pic = pic - temp
            temp2 = 53 - 15
            drop = drop - temp2
            If pic < 0 Then
                pic = 0 - pic
            End If
            If drop < 0 Then
                drop = 0 - drop
            End If
            pic = pic + drop
            MessageBox.Show(pic)
        ElseIf line1 = "H" And line2 = "C" Then

            If pic < 0 Then
                pic = 0 - pic
            End If
            If drop < 0 Then
                drop = 0 - drop
            End If
            temp = 53 - 15
            pic = pic - temp
            temp2 = 110 - 13
            drop = drop - temp2
            If pic < 0 Then
                pic = 0 - pic
            End If
            If drop < 0 Then
                drop = 0 - drop
            End If
            pic = pic + drop
            MessageBox.Show(pic)
        ElseIf line1 = "W" And line2 = "H" Then

            If pic < 0 Then
                pic = 0 - pic
            End If
            If drop < 0 Then
                drop = 0 - drop
            End If
            temp = 114 - 10
            pic = pic - temp
            temp2 = 53 - 15
            drop = drop - temp2
            If pic < 0 Then
                pic = 0 - pic
            End If
            If drop < 0 Then
                drop = 0 - drop
            End If
            pic = pic + drop + 3
            MessageBox.Show(pic)
        End If
        Button3.Visible = True
        Ticket.Visible = True
        FROM.Text = picloc
        TOO.Text = droploc
        dist.Text = pic

        If sing.Checked = True Then
            jt.Text = "Single"
            If fst.Checked = True Then
                cls.Text = "I"
                temp = pic * 3
                If temp > 200 Then
                    temp2 = pic * 20 / 100
                    temp = pic - temp2
                End If
                rs.Text = temp
            End If
            If secd.Checked = True Then
                cls.Text = "II"

                temp = pic * 1
                If temp > 80 Then
                    temp2 = pic * 20 / 100
                    temp = pic - temp2
                End If
                rs.Text = temp



            End If
        End If
        If retu.Checked = True Then
            jt.Text = "Return"
            If fst.Checked = True Then
                cls.Text = "I"
                temp = pic * 6
                If temp > 500 Then
                    temp2 = pic * 20 / 100
                    temp = pic - temp2
                End If
                rs.Text = temp

            End If
            If secd.Checked = True Then
                cls.Text = "II"
                temp = pic * 2
                If temp > 125 Then
                    temp2 = pic * 20 / 100
                    pic = pic - temp2
                End If
                rs.Text = temp

            End If
        End If

        'If duration.SelectedItem.Text = "" Then
        '    MessageBox.Show("No")
        'ElseIf duration.SelectedItem.Text = "One Month" Then
        '    MessageBox.Show("one")
        'ElseIf duration.SelectedItem.Text = "Three Month" Then
        '    MessageBox.Show("two")
        'ElseIf duration.SelectedItem.Text = "Six Month" Then
        '    MessageBox.Show("three")
        'End If


    End Sub


    Private Sub CSMT_Click(sender As Object, e As EventArgs) Handles CSMT.Click
        If (chk = 0) Then
            picloc = "CSMT"
            pic = 0 - 118
            chk = 1
            line1 = "C"
            CSMT.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "CSMT"
            drop = 0 - 118
            chk = 2
            line2 = "C"
            CSMT.BackColor = Color.Green
        End If
    End Sub

    Private Sub BYC_Click(sender As Object, e As EventArgs) Handles BYC.Click
        If (chk = 0) Then
            picloc = "BYCALLA"
            pic = 5 - 118
            chk = 1
            line1 = "C"
            BYC.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "BYCULLA"
            drop = 5 - 118
            chk = 2
            line2 = "C"
            BYC.BackColor = Color.Green
        End If
    End Sub

    Private Sub DADAR_C_Click(sender As Object, e As EventArgs) Handles DADAR_C.Click
        If (chk = 0) Then
            picloc = "DADAR"
            pic = 10 - 118
            chk = 1
            line1 = "C"
            DADAR_C.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "DADAR"
            drop = 10 - 118
            chk = 2
            line2 = "C"
            DADAR_C.BackColor = Color.Green
        End If
    End Sub

    Private Sub KU_Click(sender As Object, e As EventArgs) Handles KU.Click
        If (chk = 0) Then
            picloc = "KURLA"
            pic = 13 - 118
            chk = 1
            line1 = "C"
            KU.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "KURLA"
            drop = 13 - 118
            chk = 2
            line2 = "C"
            KU.BackColor = Color.Green
        End If
    End Sub

    Private Sub GHAT_Click(sender As Object, e As EventArgs) Handles GHAT.Click
        If (chk = 0) Then
            picloc = "GHATKOPAR"
            pic = 17 - 118
            chk = 1
            line1 = "C"
            GHAT.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "GHATKOPAR"
            drop = 17 - 118
            chk = 2
            line2 = "C"
            GHAT.BackColor = Color.Green
        End If
    End Sub

    Private Sub TH_Click(sender As Object, e As EventArgs) Handles TH.Click
        If (chk = 0) Then
            picloc = "THANE"
            pic = 30 - 118
            chk = 1
            line1 = "C"
            TH.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "THANE"
            drop = 30 - 118
            chk = 2
            line2 = "C"
            TH.BackColor = Color.Green
        End If
    End Sub

    Private Sub DIVA_Click(sender As Object, e As EventArgs) Handles DIVA.Click
        If (chk = 0) Then
            picloc = "DIVA"
            pic = 38 - 118
            chk = 1
            line1 = "C"
            DIVA.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "DIVA"
            drop = 38 - 118
            chk = 2
            line2 = "C"
            DIVA.BackColor = Color.Green
        End If
    End Sub

    Private Sub KLY_Click(sender As Object, e As EventArgs) Handles KLY.Click
        If (chk = 0) Then
            picloc = "KALYAN"
            pic = 51 - 118
            chk = 1
            line1 = "C"
            KLY.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "KALYAN"
            drop = 51 - 118
            chk = 2
            line2 = "C"
            KLY.BackColor = Color.Green
        End If
    End Sub

    Private Sub TL_Click(sender As Object, e As EventArgs) Handles TL.Click
        If (chk = 0) Then
            picloc = "TITWALA"
            pic = 62 - 118
            chk = 1
            line1 = "C"
            TL.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "TITWALA"
            drop = 62 - 118
            chk = 2
            line2 = "C"
            TL.BackColor = Color.Green
        End If
    End Sub

    Private Sub AN_Click(sender As Object, e As EventArgs) Handles AN.Click
        If (chk = 0) Then
            picloc = "ASONGOVN"
            pic = 83 - 118
            chk = 1
            line1 = "C"
            AN.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "ASONGOVN"
            drop = 83 - 118
            chk = 2
            line2 = "C"
            AN.BackColor = Color.Green
        End If
    End Sub

    Private Sub N_Click(sender As Object, e As EventArgs) Handles N.Click
        If (chk = 0) Then
            picloc = "KASARA"
            pic = 118 - 118
            chk = 1
            line1 = "C"
            N.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "KASARA"
            drop = 118 - 118
            chk = 2
            line2 = "C"
            N.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles NERU.Click
        If (chk = 0) Then
            picloc = "NERUL"
            pic = 36 - 53
            chk = 1
            line1 = "H"
            NERU.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "NERUL"
            drop = 36 - 53
            chk = 2
            line2 = "H"
            NERU.BackColor = Color.Green
        End If
    End Sub

    Private Sub CSMTH_Click(sender As Object, e As EventArgs) Handles CSMTH.Click
        If (chk = 0) Then
            picloc = "CSMT"
            pic = 0 - 53
            chk = 1
            line1 = "H"
            CSMTH.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "CSMT"
            drop = 0 - 53
            chk = 2
            line2 = "H"
            CSMTH.BackColor = Color.Green
        End If
    End Sub

    Private Sub WAD_Click(sender As Object, e As EventArgs) Handles WAD.Click
        If (chk = 0) Then
            picloc = "WADALA"
            pic = 9 - 53
            chk = 1
            line1 = "H"
            WAD.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "WADALA"
            drop = 9 - 53
            chk = 2
            line2 = "H"
            WAD.BackColor = Color.Green
        End If
    End Sub

    Private Sub KUH_Click(sender As Object, e As EventArgs) Handles KUH.Click
        If (chk = 0) Then
            picloc = "KURLA"
            pic = 15 - 53
            chk = 1
            line1 = "H"
            KUH.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "KURLA"
            drop = 15 - 53
            chk = 2
            line2 = "H"
            KUH.BackColor = Color.Green
        End If
    End Sub

    Private Sub VASH_Click(sender As Object, e As EventArgs) Handles VASH.Click
        If (chk = 0) Then
            picloc = "VASHI"
            pic = 27 - 53
            chk = 1
            line1 = "H"
            VASH.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "VASHI"
            drop = 27 - 53
            chk = 2
            line2 = "H"
            VASH.BackColor = Color.Green
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DT.Text = Date.Now.ToString("dd-MM-yy  hh:mm")
    End Sub

    Private Sub FORM2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub PAN_Click(sender As Object, e As EventArgs) Handles PAN.Click
        If (chk = 0) Then
            picloc = "PANVEL"
            pic = 53 - 53
            chk = 1
            line1 = "H"
            PAN.BackColor = Color.Red
        ElseIf (chk = 1) Then
            droploc = "PANVEL"
            drop = 53 - 53
            chk = 2
            line2 = "H"
            PAN.BackColor = Color.Green
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pic = 0
        drop = 0
        picloc = ""
        droploc = ""
        line1 = ""
        line2 = ""
        chk = 1
        PAN.BackColor = DefaultBackColor
        suname.sinname.Text = ""
        suname.pass.Text = ""
        Ticket.Visible = False

        Me.Close()
        suname.Show()
    End Sub

    Private Sub Ticket_Enter(sender As Object, e As EventArgs) Handles Ticket.Enter

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim bmp As New Bitmap(Me.Ticket.Width, Me.Ticket.Height)
        Me.Ticket.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Ticket.Width, Me.Ticket.Height))

        bmp = New Bitmap(Ticket.Width, Ticket.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        Ticket.DrawToBitmap(bmp, New Rectangle(0, 0, Ticket.Width, Ticket.Height))
        Dim pd As New PrintDocument
        Dim pdialog As New PrintDialog
        AddHandler pd.PrintPage, (Sub(s, args)
                                      args.Graphics.DrawImage(bmp, 0, 0)
                                      args.HasMorePages = False
                                  End Sub)
        pdialog.ShowDialog()
        pd.PrinterSettings.PrinterName = pdialog.PrinterSettings.PrinterName
        pd.Print()
    End Sub

    Private Sub retu_CheckedChanged(sender As Object, e As EventArgs) Handles retu.CheckedChanged

    End Sub
End Class
