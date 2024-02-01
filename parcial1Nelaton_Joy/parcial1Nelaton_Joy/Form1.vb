Public Class Form1
    Dim dia As Integer
    Dim mes As String
    Dim msj As String
    Dim signo As String


    Private Sub btnPredecir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPredecir.Click
        Verificar()
        Destino()



    End Sub




    Sub Verificar()
        If (cbMes.Text = "Seleccione el mes" Or tbDia.Text = "" Or Val(tbDia.Text = 0) Or Val(tbDia.Text < 0) Or Val(tbDia.Text > 31)) Then
            MsgBox("Favor verifique los datos de entrada")


        End If





    End Sub




    Sub Destino()
        dia = Val(tbDia.Text)
        mes = cbMes.SelectedItem

        If (dia >= 21 And dia <= 31 And mes = "Marzo") Then
            signo = "Aries"
            msj = "La suerte te traera Viajes"

        ElseIf (dia >= 1 And dia <= 20 And mes = "Abril") Then
            signo = "Aries"
            msj = "La suerte te traera Viajes"


        ElseIf (dia >= 21 And dia <= 30 And mes = "Abril") Then
            signo = "Tauro"
            msj = "La suerte te traera Dinero"

        ElseIf (dia >= 1 And dia <= 20 And mes = "Mayo") Then
            signo = "Tauro"
            msj = "La suerte te traera Dinero"

        ElseIf (dia >= 21 And dia <= 31 And mes = "Mayo") Then
            signo = "Geminis"
            msj = "La suerte le traera Rumbas"

        ElseIf (dia >= 1 And dia <= 21 And mes = "Junio") Then
            signo = "Geminis"
            msj = "La suerte le traera Rumbas"

        ElseIf (dia >= 22 And dia <= 30 And mes = "Junio") Then
            signo = "Cancer"
            msj = "La suerte le traera Salud"

        ElseIf (dia >= 1 And dia <= 22 And mes = "Julio") Then
            signo = "Cancer"
            msj = "La suerte le traera Salud"

        ElseIf (dia >= 23 And dia <= 31 And mes = "Julio") Then
            signo = "Leo"
            msj = "La suerte le traera Felicidad"

        ElseIf (dia >= 1 And dia <= 23 And mes = "Agosto") Then
            signo = "Leo"
            msj = "La suerte le traera Felicidad"

        ElseIf (dia >= 24 And dia <= 31 And mes = "Agosto") Then
            signo = "Virgo"
            msj = "La suerte le traera Deudas"

        ElseIf (dia >= 1 And dia <= 23 And mes = "Septiembre") Then
            signo = "Virgo"
            msj = "La suerte le traera Deudas"


        ElseIf (dia >= 24 And dia <= 30 And mes = "Septiembre") Then
            signo = "Libra"
            msj = "La suerte le traera Decepcion Amorosa"


        ElseIf (dia >= 1 And dia <= 22 And mes = "Octubre") Then
            signo = "Libra"
            msj = "La suerte le traera Decepcion Amorosa"


        ElseIf (dia >= 23 And dia <= 31 And mes = "Octubre") Then
            signo = "Escorpio"
            msj = "La suerte le traera trabajo"


        ElseIf (dia >= 1 And dia <= 22 And mes = "Noviembre") Then
            signo = "Escorpio"
            msj = "La suerte le traera trabajo"


        ElseIf (dia >= 22 And dia <= 30 And mes = "Noviembre") Then
            signo = "Sagitario"
            msj = "La suerte le traera buenas notas"


        ElseIf (dia >= 1 And dia <= 21 And mes = "Diciembre") Then
            signo = "Sagitario"
            msj = "La suerte le traera buenas notas"


        ElseIf (dia >= 22 And dia <= 31 And mes = "Diciembre") Then
            signo = "Capricornio"
            msj = "La suerte le traera Amor"



        ElseIf (dia >= 1 And dia <= 19 And mes = "Enero") Then
            signo = "Capricornio"
            msj = "La suerte le traera Amor"

        End If

        lbPredic.Text = signo + " " + msj
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnPredecir.Enabled = False
       

    End Sub

    Private Sub tbDia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDia.TextChanged
        If (tbDia.Text <> "") Then
            btnPredecir.Enabled = True
        End If
    End Sub
End Class
