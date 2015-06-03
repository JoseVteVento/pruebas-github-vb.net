Public Class Form1
    Private numeroMensaje As Integer = 0
    Private mensaje1 As String = "Primer mensaje"
    Private mensaje2 As String = "Segundo mensaje"
    Private mensaje3 As String = "Tercer mensaje"
    Private mensaje4 As String = "Ya no me quedan más mensajes. Tendremos que volver a empezar"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'colocar el texto de los botones y labels
        btn_mostrar_mensaje.Text = "Mostrar mensaje"
        Label1.Text = "Mensaje"

        Label1.Visible = False
        Label2.Visible = False


    End Sub


    Private Sub btn_mostrar_mensaje_Click(sender As Object, e As EventArgs) Handles btn_mostrar_mensaje.Click

        'mostrar los elementos que mostrarán los mensajes
        Label1.Visible = True
        Label2.Visible = True

        Select Case numeroMensaje
            Case 0
                Label2.Text = mensaje1
                numeroMensaje = +1
            Case 1
                Label2.Text = mensaje2
                numeroMensaje = +2
            Case 2
                Label2.Text = mensaje3
                numeroMensaje = +3
            Case 3
                'en el ultimo, pone la variable en el estado inicial
                Label2.Text = mensaje4
                numeroMensaje = 0
        End Select



    End Sub
End Class
