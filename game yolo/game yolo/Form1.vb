Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Halang0.BackColor = Color.Gray
        Halang1.BackColor = Color.Gray
        Halang2.BackColor = Color.Gray
        Halang3.BackColor = Color.Gray
        Halang4.BackColor = Color.Gray
        Halang5.BackColor = Color.Gray
        Player.BackColor = Color.Red
        tmrTOP.Enabled = False
        tmrBOTTOM.Enabled = False
        tmrLEFT.Enabled = False
        tmrRIGHT.Enabled = False
        tmrHALANG1.Enabled = False
        lblSCORE.Text = 0
        lblhasil.Text = ""
        Finish.BackColor = Color.Yellow
        btnRIGHT.Enabled = False
        btnLEFT.Enabled = False
    End Sub

    Private Sub tmrHALANG_Tick(sender As Object, e As EventArgs) Handles tmrHALANG1.Tick
        Dim b As String
        Dim kec As Integer
        b = cmbLEVEL.Items(cmbLEVEL.SelectedIndex).ToString
        Select Case b
            Case "Easy"
                kec = 1
                Halang0.Top = Halang0.Top - kec
                Halang1.Top = Halang1.Top - kec
                Halang2.Top = Halang2.Top - kec
                Halang3.Top = Halang3.Top - kec
                Halang4.Top = Halang4.Top - kec
                Halang5.Top = Halang5.Top - kec
                Halang6.Top = Halang6.Top - kec
                Halang7.Top = Halang7.Top - kec
                lblMENANG.Top = lblMENANG.Top - kec
                Finish.Top = Finish.Top - kec
            Case "Hard"
                kec = 3
                Halang0.Top = Halang0.Top - kec
                Halang1.Top = Halang1.Top - kec
                Halang2.Top = Halang2.Top - kec
                Halang3.Top = Halang3.Top - kec
                Halang4.Top = Halang4.Top - kec
                Halang5.Top = Halang5.Top - kec
                Halang6.Top = Halang6.Top - kec
                Halang7.Top = Halang7.Top - kec
                lblMENANG.Top = lblMENANG.Top - kec
                Finish.Top = Finish.Top - kec
        End Select
        Dim a As String
        If lblMENANG.Top = 20 Then
            tmrHALANG1.Enabled = False
        ElseIf Halang4.Top = 51 Then
            If Player.Left = 340 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 338 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 336 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 334 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            Else
                lblhasil.Text = "Failed"
                lblhasil.ForeColor = Color.Red
                tmrHALANG1.Stop()
                tmrRIGHT.Stop()
                tmrLEFT.Stop()
                a = MessageBox.Show("Anda Kalah!!!", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If a = vbOK Then
                    Me.Close()
                End If
            End If
        ElseIf Halang6.Top = 51 Then
            If Player.Left = 340 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 338 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 336 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 334 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            Else
                lblhasil.Text = "Failed"
                lblhasil.ForeColor = Color.Red
                tmrHALANG1.Stop()
                tmrRIGHT.Stop()
                tmrLEFT.Stop()
                a = MessageBox.Show("Anda Kalah!!!", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If a = vbOK Then
                    Me.Close()
                End If
            End If
        ElseIf Halang3.Top = 51 Then
            If Player.Left = 230 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 232 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 234 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 236 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            Else
                lblhasil.Text = "Failed"
                lblhasil.ForeColor = Color.Red
                tmrHALANG1.Stop()
                tmrRIGHT.Stop()
                tmrLEFT.Stop()
                a = MessageBox.Show("Anda Kalah!!!", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If a = vbOK Then
                    Me.Close()
                End If
            End If
        ElseIf Halang7.Top = 51 Then
            If Player.Left = 230 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 232 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 234 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 236 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            Else
                lblhasil.Text = "Failed"
                lblhasil.ForeColor = Color.Red
                tmrHALANG1.Stop()
                tmrRIGHT.Stop()
                tmrLEFT.Stop()
                a = MessageBox.Show("Anda Kalah!!!", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If a = vbOK Then
                    Me.Close()
                End If
            End If
        ElseIf Halang2.Top = 51 Then
            If Player.Left = 340 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 338 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 336 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 334 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            Else
                lblhasil.Text = "Failed"
                lblhasil.ForeColor = Color.Red
                tmrHALANG1.Stop()
                tmrRIGHT.Stop()
                tmrLEFT.Stop()
                a = MessageBox.Show("Anda Kalah!!!", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If a = vbOK Then
                    Me.Close()
                End If
            End If
        ElseIf Halang1.Top = 51 Then
            If Player.Left = 230 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 232 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 234 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 236 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            Else
                lblhasil.Text = "Failed"
                lblhasil.ForeColor = Color.Red
                tmrHALANG1.Stop()
                tmrRIGHT.Stop()
                tmrLEFT.Stop()
                a = MessageBox.Show("Anda Kalah!!!", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If a = vbOK Then
                    Me.Close()
                End If
            End If
        ElseIf Halang0.Top = 51 Then
            If Player.Left = 340 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 338 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 336 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 334 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            Else
                lblhasil.Text = "Failed"
                lblhasil.ForeColor = Color.Red
                tmrHALANG1.Stop()
                tmrRIGHT.Stop()
                tmrLEFT.Stop()
                a = MessageBox.Show("Anda Kalah!!!", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If a = vbOK Then
                    Me.Close()
                End If
            End If
        ElseIf Halang5.Top = 51 Then
            If Player.Left = 230 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 232 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 234 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            ElseIf Player.Left = 236 Then
                lblhasil.Text = "success"
                lblSCORE.Text = lblSCORE.Text + 1
                lblhasil.ForeColor = Color.Green
            Else
                lblhasil.Text = "Failed"
                lblhasil.ForeColor = Color.Red
                tmrHALANG1.Stop()
                tmrRIGHT.Stop()
                tmrLEFT.Stop()
                a = MessageBox.Show("Anda Kalah!!!", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If a = vbOK Then
                    Me.Close()
                End If
            End If
        ElseIf lblMENANG.Top = 38 Then
            a = MessageBox.Show("Selamat anda menang!!!!", "You Win", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If a = vbOK Then
                Me.Close()
            End If
        Else

        End If
    End Sub

    Private Sub tmrHALANG4_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub tmrMENANG_Tick(sender As Object, e As EventArgs)

    End Sub
    Private Sub tmrTOP_Tick(sender As Object, e As EventArgs) Handles tmrTOP.Tick

        Player.Top = Player.Top - 1
        If Player.Top = 30 Then
            tmrTOP.Enabled = False
            tmrBOTTOM.Enabled = False
            tmrLEFT.Enabled = False
            tmrRIGHT.Enabled = False
        End If
    End Sub

    Private Sub tmrLEFT_Tick(sender As Object, e As EventArgs) Handles tmrLEFT.Tick
        Dim b As String
        Dim kec As Integer
        b = cmbLEVEL.Items(cmbLEVEL.SelectedIndex).ToString
        Select Case b
            Case "Easy"
                kec = 2
                Player.Left = Player.Left - kec
            Case "Hard"
                kec = 4
                Player.Left = Player.Left - kec
        End Select
        If Player.Left = 232 Then
            tmrTOP.Enabled = False
            tmrBOTTOM.Enabled = False
            tmrLEFT.Enabled = False
            tmrRIGHT.Enabled = False
        End If
    End Sub

    Private Sub tmrRIGHT_Tick(sender As Object, e As EventArgs) Handles tmrRIGHT.Tick
        Dim b As String
        Dim kec As Integer
        b = cmbLEVEL.Items(cmbLEVEL.SelectedIndex).ToString
        Select Case b
            Case "Easy"
                kec = 2
                Player.Left = Player.Left + kec
            Case "Hard"
                kec = 4
                Player.Left = Player.Left + kec
        End Select

        If Player.Left = 340 Then
            tmrTOP.Enabled = False
            tmrBOTTOM.Enabled = False
            tmrLEFT.Enabled = False
            tmrRIGHT.Enabled = False
        End If
    End Sub

    Private Sub tmrBOTTOM_Tick(sender As Object, e As EventArgs) Handles tmrBOTTOM.Tick
        Player.Top = Player.Top + 1
        If Player.Top = 60 Then
            tmrTOP.Enabled = False
            tmrBOTTOM.Enabled = False
            tmrLEFT.Enabled = False
            tmrRIGHT.Enabled = False
        End If
    End Sub

    Private Sub btnLEFT_Click(sender As Object, e As EventArgs) Handles btnLEFT.Click
        tmrLEFT.Enabled = True
    End Sub

    Private Sub btnRIGHT_Click(sender As Object, e As EventArgs) Handles btnRIGHT.Click
        tmrRIGHT.Enabled = True
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        tmrHALANG1.Enabled = True
        btnRIGHT.Enabled = True
        btnLEFT.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
