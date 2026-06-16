Public Class Form1
    Dim total, harga, diskon As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tgl As Integer = 0
        Do Until tgl = 31
            tgl += 1
            cbxtgl.Items.Add(tgl)
        Loop

        For i = 1 To 12
            cbxbulan.Items.Add(i)
        Next

        Dim thn = Date.Today.Year
        Do While thn < Date.Today.Year + 5
            cbxtahun.Items.Add(thn)
            thn += 1
        Loop
        cbxtgl.Text = Date.Today.Day
        cbxbulan.Text = Date.Today.Month
        cbxtahun.Text = Date.Today.Year

    End Sub

    Private Sub listlayanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listlayanan.SelectedIndexChanged
        Select Case listlayanan.SelectedIndex
            Case 0 : harga = 10000
            Case 1 : harga = 50000
            Case 2 : harga = 5000
        End Select
        txtharga.Text = Format(harga, "Rp #,###,###.00")

    End Sub

    Private Sub btnpesan_Click(sender As Object, e As EventArgs) Handles btnpesan.Click
        Dim tanggal As New DateTime(CInt(cbxtahun.Text), CInt(cbxbulan.Text), CInt(cbxtgl.Text))
        If tanggal < Date.Today Then
            MsgBox("TANGGAL SUDAH BERLALU", MsgBoxStyle.Exclamation, "PERINGATAN")
            cbxtgl.Focus()
            Exit Sub
        End If

        If cbxasal.Text = cbxtujuan.Text Then
            MsgBox("Gedung Asal dan Gedung Tujuan tidak boleh sama", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            total = harga * NumericUpDown1.Value
        End If


        If (total > 100000) Then
            diskon = total * 0.1
        ElseIf (listlayanan.SelectedItem = "Dokumen" And NumericUpDown1.Value >= 5) Then
            diskon = total * 0.05
        ElseIf (listlayanan.SelectedItem = "Makanan" And total > 50000) Then
            diskon = total * 0.07
        Else
            diskon = 0
        End If

        txtdiskon.Text = Format(diskon, "Rp #,###,###.00")
        txttotal.Text = Format(total - diskon, "Rp #,###,###.00")

        Dim tanggalpesan As String = cbxtgl.Text & "/" & cbxbulan.Text & "/" & cbxtahun.Text
        MessageBox.Show("PESANAN BERHASIL DIBUAT" & vbCrLf &
            "TANGGAL :" & tanggalpesan & vbCrLf &
                    "GEDUNG ASAL :" & cbxasal.Text & vbCrLf &
                    "GEDUNG TUJUAN :" & cbxtujuan.Text & vbCrLf &
                    "LAYANAN :" & listlayanan.SelectedItem.ToString & Chr(13) &
                    "DISKON : Rp" & diskon & vbCrLf &
                    "JUMLAH :" & NumericUpDown1.Value & Chr(13) &
                    "TOTAL BAYAR : Rp" & txttotal.Text,
                    "INFO PESANAN LUR", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class
