Imports System
Imports System.Threading
Imports System.ComponentModel
Imports System.IO.Ports



Public Class Form1
    Public WithEvents port As New clsSynchronizedSerialPort()

    'this declares the user32.dll call to SendMessageW we are making
    Declare Auto Function SendMessageW Lib "user32.dll" Alias "SendMessageW" (
    ByVal hWnd As Integer,
    ByVal Msg As Integer,
    ByVal wParam As Integer,
    ByVal lParam As Integer) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cbb_portas.Items.Add(sp)
        Next
    End Sub

    Private Sub bt_conectar_Click(sender As Object, e As EventArgs) Handles bt_conectar.Click
        port.open(cbb_portas.SelectedItem, 9600)
    End Sub
    Private Sub cont_MsgReceived(ByVal msgString As String) Handles port.MsgReceived
        'lbl_status.Text = SerialPort1.ReadExisting
        'this constant represents the hex value for the key to send to user32.dll
        Const APPCOMMAND_MEDIA_PLAY_PAUSE = &HE0000
        'this constant represents which command. Sort of like the function in user32.dll we are calling.
        Const WM_APPCOMMAND = &H319
        SendMessageW(Handle, WM_APPCOMMAND, Handle, APPCOMMAND_MEDIA_PLAY_PAUSE)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub bt_Desconectar_Click(sender As Object, e As EventArgs) Handles bt_Desconectar.Click
        port.close()
    End Sub
End Class



Public Class clsSynchronizedSerialPort

    Private WithEvents Connection As New SerialPort
    Public Event MsgReceived(ByVal msg As String)
    Private asynOp As AsyncOperation

    Public Sub New()

        asynOp = AsyncOperationManager.CreateOperation(Nothing)

    End Sub
    Public Sub open(ByVal portName As String, ByVal baud As Integer)

        'asynOp = AsyncOperationManager.CreateOperation(Nothing)
        Try
            With Connection
                .PortName = portName
                .BaudRate = baud
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = StopBits.One
            End With
            Connection.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub close()
        Connection.Close()
    End Sub


    Private Sub Connection_DataReceived(ByVal sender As Object,
            ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Connection.DataReceived

        Dim MsgString As String = Nothing
        If Connection.BytesToRead > 0 Then
            Do
                MsgString &= Chr(Connection.ReadByte)
                If Connection.BytesToRead = 0 Then
                    Exit Do
                End If
            Loop
            asynOp.Post(New SendOrPostCallback(AddressOf CallbackDelegate), MsgString)
        End If


    End Sub

    Private Sub CallbackDelegate(ByVal MsgString As Object)

        RaiseEvent MsgReceived(CStr(MsgString))

    End Sub

    Public Sub SendMsg(ByVal msg As String)

        Connection.Write(msg)

    End Sub

End Class