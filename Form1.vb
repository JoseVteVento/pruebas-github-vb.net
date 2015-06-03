Public Class Form1
    Private numeroMensaje As Integer = 0
    Private mensaje1 As String = "Primer mensaje"
    Private mensaje2 As String = "Segundo mensaje"
    Private mensaje3 As String = "Tercer mensaje"
    Private mensaje4 As String = "Ya no me quedan más mensajes. Tendremos que volver a empezar"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'colocar el texto de los botones y labels
        btn_mostrar_mensaje.Text = "Mostrar mensaje"
        btn_cambiar_mensaje.Text = "Cambiar mensaje"
        Label1.Text = "Mensaje"

        Label1.Visible = False
        Label2.Visible = False
        btn_cambiar_mensaje.Visible = False
        TextBox1.Visible = False



    End Sub


    Private Sub btn_mostrar_mensaje_Click(sender As Object, e As EventArgs) Handles btn_mostrar_mensaje.Click

        'mostrar los elementos que mostrarán los mensajes
        Label1.Visible = True
        Label2.Visible = True
        btn_cambiar_mensaje.Visible = True


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

    Private Sub btn_cambiar_mensaje_Click(sender As Object, e As EventArgs) Handles btn_cambiar_mensaje.Click

        TextBox1.Visible = True
        
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Select Case numeroMensaje
            Case 0
                mensaje1 = TextBox1.Text
            Case 1
                mensaje2 = TextBox1.Text
            Case 2
                mensaje3 = TextBox1.Text
            Case 3
                mensaje4 = TextBox1.Text
        End Select
    End Sub
End Class
