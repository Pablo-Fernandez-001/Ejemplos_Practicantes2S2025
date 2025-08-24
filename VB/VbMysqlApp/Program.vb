Imports MySql.Data.MySqlClient

Module Program
    Sub Main(args As String())
        Dim connStr As String = "server=localhost;user=appuser;password=app_pass;database=testdb;port=3306"
        Dim conn As New MySqlConnection(connStr)

        Try
            conn.Open()
            Console.WriteLine("Conexión exitosa!")

            ' Insertar un usuario
            Dim insertCmd As New MySqlCommand("INSERT INTO users (name, email) VALUES (@n, @e)", conn)
            insertCmd.Parameters.AddWithValue("@n", "UsuarioVB")
            insertCmd.Parameters.AddWithValue("@e", "vb@example.com")
            insertCmd.ExecuteNonQuery()
            Console.WriteLine("Usuario insertado.")

            ' Listar usuarios
            Dim cmd As New MySqlCommand("SELECT name, email FROM users", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Console.WriteLine(reader("name") & " - " & reader("email"))
            End While
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Module