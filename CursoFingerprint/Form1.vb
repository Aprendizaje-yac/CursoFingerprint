Imports DPFP
Imports DPFP.Capture
Public Class Form1
    Implements DPFP.Capture.EventHandler

    Private Captura As DPFP.Capture.Capture

    Protected Overridable Sub Init()
        Try
            Captura = New Capture()
            If Not Captura Is Nothing Then
                Captura.EventHandler = Me
            Else
                MessageBox.Show("No se pudo instanciar la captura")

            End If

        Catch ex As Exception
            MessageBox.Show("no se pudo inicializar la captura")
        End Try
    End Sub

    Protected Sub iniciarCaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StartCapture()

            Catch ex As Exception
                MessageBox.Show("Nose pudo iniciar la captura")
            End Try
        End If
    End Sub

    Protected Sub paraCaptura()
        If Not Captura Is Nothing Then
            Try
                Captura.StopCapture()

            Catch ex As Exception
                MessageBox.Show("no se pudo dentener la captura")
            End Try
        End If
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        MessageBox.Show("entre al complete")
        ponerImagen(ConvertirSampleMapadebit(Sample))

    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        ''' Funcion que esucha el evento del toque del biometrico
        MessageBox.Show("Aprete el biometrico")

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''' Iniciando las funciones para el evento del biometrico
        Init()
        iniciarCaptura()

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        '''Detiene el evento de escucha del biometrico
        paraCaptura()

    End Sub

    Protected Function ConvertirSampleMapadebit(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertidor As New DPFP.Capture.SampleConversion() ' es una variable del tipo conversor de un dpfp.Sample
        Dim mapaBits As Bitmap = Nothing ' Imagen vacia por defecto

        convertidor.ConvertToPicture(Sample, mapaBits)
        Return mapaBits

    End Function

    Private Sub ponerImagen(ByVal bmp)
        'pb_ImagenHuella es un componente de pictureBox, para ponerlo aca la imagen
        pb_ImagenHuella.Image = bmp

    End Sub

End Class
