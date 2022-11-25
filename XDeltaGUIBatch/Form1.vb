Imports System.DirectoryServices.ActiveDirectory
Imports System.IO
Imports System.Security.Permissions
Imports System.Security.Policy
Imports System.Threading

Public Class Form1
    Dim UnmodifiedDirectory
    Dim ModifiedDirectory
    Dim ModifiedFiles As New List(Of String)
    Dim UnmodifiedFiles As New List(Of String)
    Dim XDeltaPatchFolder
    Dim XDeltaPatchFiles As New List(Of String)
    Dim FilestoPatchFolder
    Dim FilestoPatchFiles As New List(Of String)
    Dim SingleOrignalFile
    Dim SingleModifiedFile
    Dim SingleXDeltaPatch


    ''Batch Create Functions
    Private Sub btnGeneratePatchList_Click(sender As Object, e As EventArgs) Handles btnGeneratePatchList.Click
        Dim PatchFileOutput = "patchlist.txt"
        If File.Exists(PatchFileOutput) = True Then
            Dim result As DialogResult = MessageBox.Show("Current patch file will be overwritten are you sure you wish to continue?", "Overwrite?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                File.Delete(PatchFileOutput)
            End If
        End If

        MessageBox.Show("Select the location of the orginal/unmodified files you wish to patch")
        If fbdOldGeneratePatchList.ShowDialog() = DialogResult.OK Then
            Dim OldCount = 0
            Using sw As StreamWriter = New StreamWriter(File.Open(PatchFileOutput, FileMode.Create))
                sw.WriteLine("----UNMODIFIED FILES----")
                sw.WriteLine(fbdOldGeneratePatchList.SelectedPath)
                For Each f In Directory.GetFiles(fbdOldGeneratePatchList.SelectedPath)
                    OldCount = OldCount + 1
                    sw.WriteLine(Path.GetFileName(f))
                Next
                lbxBatchCreatePatchLog.Items.Add(OldCount.ToString & " Added to Unmodified Patch List")
            End Using

            MessageBox.Show("Select the location of the modified files")
            If fbdNewGeneratePatchList.ShowDialog() = DialogResult.OK Then
                Dim NewCount = 0
                Using sw As StreamWriter = New StreamWriter(File.Open(PatchFileOutput, FileMode.Append))
                    sw.WriteLine("----MODIFIED FILES----")
                    sw.WriteLine(fbdNewGeneratePatchList.SelectedPath)
                    For Each f In Directory.GetFiles(fbdNewGeneratePatchList.SelectedPath)
                        NewCount = NewCount + 1
                        sw.WriteLine(Path.GetFileName(f))
                    Next
                    lbxBatchCreatePatchLog.Items.Add(NewCount.ToString & " Added to Modified Patch List")
                End Using
                MessageBox.Show("Created Patch List that can be used to create XDelta Patch Files.")
                If NewCount <> OldCount Then
                    MessageBox.Show("Detected uneven amount of unmodified to modified file counts. We will attempt to find the modified files unmodied source upon patching.")
                End If
            End If
        End If
    End Sub

    Private Sub btnLoadPatchList_Click(sender As Object, e As EventArgs) Handles btnLoadPatchList.Click
        Dim PatchFileListPath As String
        Dim PatchFileListLines
        Dim PatchFileListLineCount
        If ofdPatchFileList.ShowDialog = DialogResult.OK Then
            PatchFileListPath = ofdPatchFileList.FileName
            PatchFileListLines = File.ReadAllLines(PatchFileListPath)
            PatchFileListLineCount = File.ReadAllLines(PatchFileListPath).Length
            Using sr As New StreamReader(File.Open(PatchFileListPath, FileMode.Open))
                Dim LineCount = 0
                Dim GetUnmodified = False
                Dim GetModified = False
                While True
                    Dim Line = sr.ReadLine
                    If Line = "----UNMODIFIED FILES----" Then
                        LineCount = LineCount + 1
                        UnmodifiedDirectory = sr.ReadLine
                        lbxBatchCreatePatchLog.Items.Add("Unmodified Dir: " & UnmodifiedDirectory.ToString)
                        GetUnmodified = True
                        GetModified = False

                    ElseIf Line = "----MODIFIED FILES----" Then
                        LineCount = LineCount + 1
                        ModifiedDirectory = sr.ReadLine
                        lbxBatchCreatePatchLog.Items.Add("Modified Dir: " & ModifiedDirectory.ToString)
                        GetModified = True
                        GetUnmodified = False

                    ElseIf LineCount = PatchFileListLineCount Then
                        Exit While

                    ElseIf GetUnmodified = True And GetModified = False Then
                        LineCount = LineCount + 1
                        If Not Line = Nothing Then
                            UnmodifiedFiles.Add(Line)
                        End If


                    ElseIf GetModified = True And GetUnmodified = False Then
                        LineCount = LineCount + 1
                        If Not Line = Nothing Then
                            ModifiedFiles.Add(Line)
                        End If
                    End If
                End While
            End Using
            lbxBatchCreatePatchLog.Items.Add("Unmodified Loaded: " & UnmodifiedFiles.Count)
            lbxBatchCreatePatchLog.Items.Add("Modified Loaded: " & ModifiedFiles.Count)
            btnCreatePatchs.Enabled = True
        End If
    End Sub

    Private Sub btnCreatePatchs_Click(sender As Object, e As EventArgs) Handles btnCreatePatchs.Click
        Dim PatchCreateCount = 0
        Dim SkippedPatches As New List(Of String)

        If Directory.Exists("Created_Patches") = False Then
            Directory.CreateDirectory("Created_Patches")
        End If

        If File.Exists("xdelta.exe") = False Then
            MessageBox.Show("Unable to lcoated xdelta.exe in root dir. Please add and try again")
            Exit Sub
        End If

        For Each f In ModifiedFiles
            If UnmodifiedFiles.Contains(f) Then
                Dim unmodifiedFilepath = UnmodifiedDirectory & "\" & f
                Dim ModifiedFilePath = ModifiedDirectory & "\" & f
                Dim OutputXDelta = "Created_Patches\" & f & ".xdelta"
                Dim xdapp = "xdelta.exe"
                Dim argu = "-e -s """ & unmodifiedFilepath & """ """ & ModifiedFilePath & """ """ & OutputXDelta & """"
                If File.Exists(OutputXDelta) Then
                    File.Delete(OutputXDelta)
                End If
                Process.Start(xdapp, argu)
                Thread.Sleep(500)
                If File.Exists(OutputXDelta) Then
                    lbxBatchCreatePatchLog.Items.Add("Created Patch: " & f)
                    PatchCreateCount = PatchCreateCount + 1
                Else
                    lbxBatchCreatePatchLog.Items.Add("failed to create Patch: " & f)
                End If
            Else
                SkippedPatches.Add(f)
            End If
        Next
        For Each s In SkippedPatches
            lbxBatchCreatePatchLog.Items.Add("Skipped File (no match): " & s)
        Next
        lbxBatchCreatePatchLog.Items.Add("Created " & PatchCreateCount.ToString & "XDeltas to Created_Patches Folder")
        lbxBatchCreatePatchLog.SelectedIndex = lbxBatchCreatePatchLog.Items.Count - 1
    End Sub

    ''Batch Patch Function
    Private Sub btnBatchPatchFileList_Click(sender As Object, e As EventArgs) Handles btnBatchPatchFileList.Click
        If fbdFilestoPatchFolder.ShowDialog = DialogResult.OK Then
            FilestoPatchFolder = fbdFilestoPatchFolder.SelectedPath
            lbxBatchPatchLog.Items.Add("DIR to Patch: " & FilestoPatchFolder)

            For Each f In Directory.GetFiles(FilestoPatchFolder)
                FilestoPatchFiles.Add(Path.GetFileName(f))
            Next

            If Not XDeltaPatchFolder = "" Then
                btnStartBatchPatching.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSelectXDeltaFolder_Click(sender As Object, e As EventArgs) Handles btnSelectXDeltaFolder.Click
        Dim FoundXdeltaCount = 0
        If fbdXDeltaPatchFolder.ShowDialog = DialogResult.OK Then
            XDeltaPatchFolder = fbdXDeltaPatchFolder.SelectedPath
        End If

        For Each f In Directory.GetFiles(XDeltaPatchFolder, "*.xdelta")
            XDeltaPatchFiles.Add(Path.GetFileName(f))
            FoundXdeltaCount = FoundXdeltaCount + 1
        Next
        lbxBatchPatchLog.Items.Add("XDelta Dir: " & XDeltaPatchFolder)
        lbxBatchPatchLog.Items.Add("XDelta Patch Found: " & FoundXdeltaCount.ToString)

        If Not FilestoPatchFolder = "" Then
            btnStartBatchPatching.Enabled = True
        End If
    End Sub

    Private Sub btnStartBatchPatching_Click(sender As Object, e As EventArgs) Handles btnStartBatchPatching.Click
        Dim PatchCount = 0
        Dim OutputFolder = "Built_Files"

        If Directory.Exists(OutputFolder) = False Then
            Directory.CreateDirectory(OutputFolder)
        End If

        If File.Exists("xdelta.exe") = False Then
            MessageBox.Show("Unable to lcoated xdelta.exe in root dir. Please add and try again")
            Exit Sub
        End If


        For Each f In XDeltaPatchFiles
            Dim CheckFile = Path.GetFileNameWithoutExtension(f)

            If FilestoPatchFiles.Contains(CheckFile) Then
                Dim SourceFile = FilestoPatchFolder & "\" & CheckFile
                Dim XDeltaPatchFile = XDeltaPatchFolder & "\" & f
                Dim OutputFile = OutputFolder & "\" & CheckFile
                Dim xdapp = "xdelta.exe"
                Dim argu = "-d -s """ & SourceFile & """ """ & XDeltaPatchFile & """ """ & OutputFile & """"

                If File.Exists(OutputFile) Then
                    File.Delete(OutputFile)
                End If

                Process.Start(xdapp, argu)
                Thread.Sleep(500)
                If File.Exists(OutputFile) Then
                    lbxBatchPatchLog.Items.Add("Patched " & CheckFile)
                    PatchCount = PatchCount + 1
                Else
                    lbxBatchPatchLog.Items.Add("Failed to create Patch: " & CheckFile)
                End If
            End If
        Next

        lbxBatchPatchLog.Items.Add("Created " & PatchCount.ToString & " Patched Files to Built_Files")
        lbxBatchPatchLog.SelectedIndex = lbxBatchPatchLog.Items.Count - 1
    End Sub



    ''Single Create Function
    Private Sub btnSourceFile_Click(sender As Object, e As EventArgs) Handles btnSourceFile.Click
        If ofdSingleOriginalFile.ShowDialog = DialogResult.OK Then
            SingleOrignalFile = ofdSingleOriginalFile.FileName
            lbxSingleCreatePatchLog.Items.Add("Original File: " & SingleOrignalFile)
        End If
    End Sub

    Private Sub btnModifiedFile_Click(sender As Object, e As EventArgs) Handles btnModifiedFile.Click
        If ofdSingleModifiedFile.ShowDialog = DialogResult.OK Then
            SingleModifiedFile = ofdSingleModifiedFile.FileName
            lbxSingleCreatePatchLog.Items.Add("Modified File: " & SingleModifiedFile)
            btnCreatePatch.Enabled = True
        End If
    End Sub

    Private Sub btnCreatePatch_Click(sender As Object, e As EventArgs) Handles btnCreatePatch.Click
        If Directory.Exists("Created_Patches") = False Then
            Directory.CreateDirectory("Created_Patches")
        End If
        If File.Exists("xdelta.exe") = False Then
            MessageBox.Show("Unable to lcoated xdelta.exe in root dir. Please add and try again")
            Exit Sub
        End If

        Dim OutputXDelta = "Created_Patches\" & Path.GetFileName(SingleModifiedFile) & ".xdelta"
        Dim xdapp = "xdelta.exe"
        Dim argu = "-e -s """ & SingleOrignalFile & """ """ & SingleModifiedFile & """ """ & OutputXDelta & """"
        Process.Start(xdapp, argu)
        Thread.Sleep(500)
        If File.Exists(OutputXDelta) Then
            lbxSingleCreatePatchLog.Items.Add("Created Patch: " & OutputXDelta)
        Else
            lbxSingleCreatePatchLog.Items.Add("Failed to create Patch: " & OutputXDelta)
        End If
    End Sub

    ''Single Patch Function
    Private Sub btnSelectOrignalPatch_Click(sender As Object, e As EventArgs) Handles btnSelectOrignalPatch.Click
        If ofdSingleOriginalFile.ShowDialog = DialogResult.OK Then
            SingleOrignalFile = ofdSingleOriginalFile.FileName
            lbxSinglePatchFileLog.Items.Add("Original File: " & SingleOrignalFile)
        End If
    End Sub

    Private Sub btnSelectXDeltaPatch_Click(sender As Object, e As EventArgs) Handles btnSelectXDeltaPatch.Click
        If ofdSingleXDeltaPatch.ShowDialog = DialogResult.OK Then
            SingleXDeltaPatch = ofdSingleXDeltaPatch.FileName
            lbxSinglePatchFileLog.Items.Add("XDelta Patch: " & SingleXDeltaPatch)
            btnSinglePatchFile.Enabled = True
        End If
    End Sub

    Private Sub btnSinglePatchFile_Click(sender As Object, e As EventArgs) Handles btnSinglePatchFile.Click
        If Directory.Exists("Built_Files") = False Then
            Directory.CreateDirectory("Built_Files")
        End If
        If File.Exists("xdelta.exe") = False Then
            MessageBox.Show("Unable to lcoated xdelta.exe in root dir. Please add and try again")
            Exit Sub
        End If

        Dim OutputFile = "Built_Files\" & Path.GetFileName(SingleOrignalFile)
        Dim xdapp = "xdelta.exe"
        Dim argu = "-d -s """ & SingleOrignalFile & """ """ & SingleXDeltaPatch & """ """ & OutputFile & """"
        Process.Start(xdapp, argu)
        Thread.Sleep(500)
        If File.Exists(OutputFile) Then
            lbxSinglePatchFileLog.Items.Add("Created Patched File: " & OutputFile)
        Else
            lbxSinglePatchFileLog.Items.Add("Failed to Create XDelta Patch: " & OutputFile)
        End If
    End Sub
End Class
