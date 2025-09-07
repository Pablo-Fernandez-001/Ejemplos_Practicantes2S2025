Imports MySql.Data.MySqlClient

Public Class Form1
    ' DB String
    Private connString As String = "server=localhost;user id=root;password=4rt1ST4001.;database=testdb;SslMode=None;"

    ' Data adapter variables
    Private da As MySqlDataAdapter
    Private dt As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' Carga los datos desde MySQL a un DataTable y lo une al DataGridView
    Private Sub LoadData()
        Try
            Using conn As New MySqlConnection(connString)
                Dim sql As String = "SELECT id, title, done FROM todos"
                da = New MySqlDataAdapter(sql, conn)
                dt = New DataTable()
                da.Fill(dt)                     ' llena el DataTable (equivalente a "dataframe")
                DataGridView1.DataSource = dt   ' bind
                ' Opcional: id sólo lectura
                If DataGridView1.Columns.Contains("id") Then
                    DataGridView1.Columns("id").ReadOnly = True
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar: " & ex.Message)
        End Try
    End Sub

    ' Insert básico con parámetros
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO todos(title, done) VALUES(@t, @d)", conn)
                cmd.Parameters.AddWithValue("@t", txtTitle.Text)
                cmd.Parameters.AddWithValue("@d", If(chkDone.Checked, 1, 0))
                cmd.ExecuteNonQuery()
            End Using
            LoadData() ' refrescar
        Catch ex As Exception
            MessageBox.Show("Error insertar: " & ex.Message)
        End Try
    End Sub

    ' Update simple para la fila seleccionada
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim id As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("id").Value)
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE todos SET title=@t, done=@d WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@t", txtTitle.Text)
                cmd.Parameters.AddWithValue("@d", If(chkDone.Checked, 1, 0))
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error actualizar: " & ex.Message)
        End Try
    End Sub

    ' Delete de la fila seleccionada
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim id As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("id").Value)
        If MessageBox.Show($"Eliminar ID {id}?", "Confirmar", MessageBoxButtons.YesNo) <> DialogResult.Yes Then Return
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM todos WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error eliminar: " & ex.Message)
        End Try
    End Sub

    ' Guardar cambios del DataTable (ediciones hechas directamente en la grilla) hacia la BD
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Try
            ' El DataAdapter 'da' y DataTable 'dt' deben estar cargados por LoadData()
            If da Is Nothing Or dt Is Nothing Then
                MessageBox.Show("Primero cargue los datos (Load).")
                Return
            End If
            Dim builder As New MySqlCommandBuilder(da)
            da.Update(dt) ' aplica INSERT/UPDATE/DELETE automáticos construidos por CommandBuilder
            MessageBox.Show("Cambios guardados en la base.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error guardar cambios: " & ex.Message)
        End Try
    End Sub

    ' Sincronizar controles cuando el usuario selecciona otra fila
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow Is Nothing Then Return
        txtTitle.Text = Convert.ToString(DataGridView1.CurrentRow.Cells("title").Value)
        chkDone.Checked = Convert.ToBoolean(DataGridView1.CurrentRow.Cells("done").Value)
    End Sub

End Class
