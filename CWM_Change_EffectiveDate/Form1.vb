
Imports System.Data.SqlClient
Public Class Form1
    Dim Xds As New DataSet()
    Dim ds As New DataSet()
    Dim ds1 As New DataSet()
    Dim ds2 As New DataSet()
    Dim ds3 As New DataSet()
    Dim ds4 As New DataSet()
    Dim ds5 As New DataSet()
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.Open()
        LoadCombo(GetDataSQL("p1", "p2", "p3", "p4", "p5", "@rd", "pn2", "pn3", "pn4", "pn5", "SELECT CompanyCode FROM DisGroupType GROUP BY CompanyCode  ORDER BY CompanyCode"), ComboBoxCompany, "CompanyCode")
        LoadCombo(GetDataSQL("p1", "p2", "p3", "p4", "p5", "@rd", "pn2", "pn3", "pn4", "pn5", "SELECT DivCode FROM DisGroupType GROUP BY DivCode  ORDER BY DivCode"), ComboBoxDiv, "DivCode")
        ComboBoxCompany.SelectedIndex = 0
        ComboBoxDiv.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        'Dim com19 As New SqlCommand("UPDATE Product SET EffectiveDate = @a1 where  PDAProductCode = '" & TextBox1.Text & "' AND CompanyCode='" & ComboBoxCompany.Text & "' AND DivCode= '" & ComboBoxDiv.Text & "' ", con)
        'com19.Parameters.AddWithValue("@a1", DateTimePicker1.Value.Date.ToString("yyyy-MM-dd"))
        'com19.ExecuteNonQuery()


        '' '' ''        ds = GetDataSQL("", "p2", "p3", "p4", "p5", "@dt", "pn2", "pn3", "pn4", "pn5",
        '' '' ''"select * from Test_1 ")
        '' '' ''        If ds.Tables(0).Rows.Count > 0 Then
        '' '' ''            For a As Integer = 0 To ds.Tables(0).Rows.Count - 1


        '' '' ''                '                ds1 = GetDataSQL("", "p2", "p3", "p4", "p5", "@dt", "pn2", "pn3", "pn4", "pn5",
        '' '' ''                '"select * from MaterialMaster where  MaterialNumber = '" & ds.Tables(0).Rows(a)("PID").ToString() & "' AND SalesOrg='2000'  ")
        '' '' ''                '                If ds1.Tables(0).Rows.Count > 0 Then
        '' '' ''                '                    MsgBox(ds.Tables(0).Rows(a)("PID").ToString() & "  " & ds1.Tables(0).Rows.Count)
        '' '' ''                '                End If

        '' '' ''                Dim com19 As New SqlCommand("UPDATE MaterialMaster SET StorageLocation = @a1,SUpdated='False' where plant='2003' AND  MaterialNumber = '" & ds.Tables(0).Rows(a)("PID").ToString() & "' AND SalesOrg='2000' ", con)
        '' '' ''                com19.Parameters.AddWithValue("@a1", "1630")
        '' '' ''                com19.ExecuteNonQuery()

        '' '' ''            Next
        '' '' ''        End If


       

        MsgBox("Done...!")


    End Sub
End Class
