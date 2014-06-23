Public Class MainForm
    'http://rohara.x10.mx/smbxpublisher/appfiles/SMBXInstaller_Latest.exe
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CurrentExe As String = Environment.CurrentDirectory + "\SMBXEpisodeManager.exe"
        Dim BackupExe As String = Environment.CurrentDirectory + "\SMBXEpisodeManager_Old.exe"

        If My.Computer.FileSystem.FileExists(BackupExe) Then
            My.Computer.FileSystem.DeleteFile(BackupExe)
        End If
        If My.Computer.FileSystem.FileExists(CurrentExe) Then
            My.Computer.FileSystem.CopyFile(CurrentExe, BackupExe)
        End If
        My.Computer.Network.DownloadFile("http://mrmiketheripper.x10.mx/epmanager3/SMBXEpisodeManager_Latest.exe", CurrentExe, vbNull, vbNull, True, vbNull, True, FileIO.UICancelOption.DoNothing)
        'Dim sw As New System.IO.StreamWriter(Environment.CurrentDirectory + "\settings.ini")
        'sw.WriteLine("dlServers=pixels")
        If MsgBox("Update complete! Do you wish to launch?", MsgBoxStyle.YesNo, "Update Complete") = DialogResult.Yes Then
            Process.Start(CurrentExe)
            Me.Close()
        Else
            Me.Close()
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
