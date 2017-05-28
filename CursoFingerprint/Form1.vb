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
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        MessageBox.Show("aprete el aparato")

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        iniciarCaptura()

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        paraCaptura()

    End Sub
End Class
