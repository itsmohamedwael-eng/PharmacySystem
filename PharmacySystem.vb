Imports System.Data.SqlClient

Public Class PharmacyForm
    ' متغيرة الاتصال بقاعدة البيانات SQL Server
    Dim connectionString As String = "Server=YOUR_SERVER_NAME;Database=PharmacyDB;Trusted_Connection=True;"
    Dim conn As New SqlConnection(connectionString)

    ' إجراء لإضافة دواء جديد إلى قاعدة البيانات
    Public Sub AddMedicine(id As Integer, name As String, price As Decimal, quantity As Integer)
        Try
            conn.Open()
            Dim query As String = "INSERT INTO Medicines (ID, Name, Price, Quantity) VALUES (@id, @name, @price, @quantity)"
            Dim cmd As New SqlCommand(query, conn)
            
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@price", price)
            cmd.Parameters.AddWithValue("@quantity", quantity)
            
            cmd.ExecuteNonQuery()
            Console.WriteLine("تمت إضافة الدواء بنجاح!")
        Catch ex As Exception
            Console.WriteLine("حدث خطأ: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' إجراء لعرض وتحديث بيانات المبيعات
    Public Sub ProcessSale(medicineId As Integer, soldQuantity As Integer)
        ' كود خصم الكمية المباعة من المخزن
    End Sub
End Class
