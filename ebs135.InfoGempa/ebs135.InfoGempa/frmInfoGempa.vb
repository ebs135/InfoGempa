Imports System.Xml

Public Class frmInfoGempa
    ''' <summary>
    ''' Baca informasi gempa dari BMKG
    ''' </summary>
    ''' <returns>Tabel informasi gempa, format DataTable</returns>
    ''' <remarks>Fungsi pembaca informasi gempa dari xml feed BMKG
    ''' di "http://data.bmkg.go.id/gempaterkini.xml".</remarks>
    Private Function BacaInfoBMKG() As DataTable
        ' Set tabel
        Dim info As New DataTable("infoGempa")
        With info.Columns
            .Add("tanggal", GetType(System.String))
            .Add("jam", GetType(System.String))
            .Add("lintang", GetType(System.String))
            .Add("bujur", GetType(System.String))
            .Add("magnitude", GetType(System.String))
            .Add("kedalaman", GetType(System.String))
            .Add("wilayah", GetType(System.String))
        End With

        ' Deklarasi variabel
        Dim doc As XmlDocument
        Dim listGempa As XmlNodeList

        ' Xml operation
        doc = New XmlDocument

        ' Load Xml Info Gempa
        doc.Load("http://data.bmkg.go.id/gempaterkini.xml")

        ' Ambil daftar info gempa
        listGempa = doc.SelectNodes("/Infogempa/gempa")

        ' Ambil info gempa terkini
        For Each gempa As XmlNode In listGempa
            ' Tambahkan baris baru di tabel info
            Dim baris As DataRow = info.NewRow

            ' Isi info gempa ke tabel info
            ' Info tanggal
            baris("tanggal") = gempa.ChildNodes.Item(0).InnerText
            ' Info jam
            baris("jam") = gempa.ChildNodes.Item(1).InnerText
            ' Info lintang
            baris("lintang") = gempa.ChildNodes.Item(3).InnerText
            ' Info bujur
            baris("bujur") = gempa.ChildNodes.Item(4).InnerText
            ' Info magnitude
            baris("magnitude") = gempa.ChildNodes.Item(5).InnerText
            ' Info kedalaman
            baris("kedalaman") = gempa.ChildNodes.Item(6).InnerText
            ' Info wilayah
            baris("wilayah") = gempa.ChildNodes.Item(8).InnerText

            info.Rows.Add(baris)

            ' Keluar dari iterasi,
            ' karena kita hanya mengambil data gempa terkini saja.
            Exit For
        Next

        ' Kembalikan info gempa
        Return info
    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        ' Variabel
        Dim info As DataTable = BacaInfoBMKG()

        ' Load data info
        For Each baris As DataRow In info.Rows
            txtTanggal.Text = baris("tanggal")
            txtJam.Text = baris("jam")
            txtLintang.Text = baris("lintang")
            txtBujur.Text = baris("bujur")
            txtMagnitude.Text = baris("magnitude")
            txtKedalaman.Text = baris("kedalaman")
            txtWilayah.Text = baris("wilayah")
        Next
    End Sub
End Class
