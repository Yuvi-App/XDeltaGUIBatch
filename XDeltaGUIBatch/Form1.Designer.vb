<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnStartBatchPatching = New System.Windows.Forms.Button()
        Me.btnSelectXDeltaFolder = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbxBatchPatchLog = New System.Windows.Forms.ListBox()
        Me.btnBatchPatchFileList = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCreatePatchs = New System.Windows.Forms.Button()
        Me.lbxBatchCreatePatchLog = New System.Windows.Forms.ListBox()
        Me.btnLoadPatchList = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGeneratePatchList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fbdOldGeneratePatchList = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdNewGeneratePatchList = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofdPatchFileList = New System.Windows.Forms.OpenFileDialog()
        Me.fbdXDeltaPatchFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdFilestoPatchFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCreatePatch = New System.Windows.Forms.Button()
        Me.lbxSingleCreatePatchLog = New System.Windows.Forms.ListBox()
        Me.btnSourceFile = New System.Windows.Forms.Button()
        Me.btnModifiedFile = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ofdSingleOriginalFile = New System.Windows.Forms.OpenFileDialog()
        Me.ofdSingleModifiedFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSelectXDeltaPatch = New System.Windows.Forms.Button()
        Me.btnSelectOrignalPatch = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSinglePatchFile = New System.Windows.Forms.Button()
        Me.lbxSinglePatchFileLog = New System.Windows.Forms.ListBox()
        Me.ofdSingleXDeltaPatch = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(522, 300)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.btnSelectXDeltaPatch)
        Me.TabPage1.Controls.Add(Me.btnSelectOrignalPatch)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.btnSinglePatchFile)
        Me.TabPage1.Controls.Add(Me.lbxSinglePatchFileLog)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(514, 272)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Patch"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.btnModifiedFile)
        Me.TabPage3.Controls.Add(Me.btnSourceFile)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.btnCreatePatch)
        Me.TabPage3.Controls.Add(Me.lbxSingleCreatePatchLog)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(514, 272)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Create"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnStartBatchPatching)
        Me.TabPage4.Controls.Add(Me.btnSelectXDeltaFolder)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.lbxBatchPatchLog)
        Me.TabPage4.Controls.Add(Me.btnBatchPatchFileList)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(514, 272)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Batch Patch"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnStartBatchPatching
        '
        Me.btnStartBatchPatching.Enabled = False
        Me.btnStartBatchPatching.Location = New System.Drawing.Point(44, 77)
        Me.btnStartBatchPatching.Name = "btnStartBatchPatching"
        Me.btnStartBatchPatching.Size = New System.Drawing.Size(172, 23)
        Me.btnStartBatchPatching.TabIndex = 10
        Me.btnStartBatchPatching.Text = "Start Patching"
        Me.btnStartBatchPatching.UseVisualStyleBackColor = True
        '
        'btnSelectXDeltaFolder
        '
        Me.btnSelectXDeltaFolder.Location = New System.Drawing.Point(176, 44)
        Me.btnSelectXDeltaFolder.Name = "btnSelectXDeltaFolder"
        Me.btnSelectXDeltaFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectXDeltaFolder.TabIndex = 9
        Me.btnSelectXDeltaFolder.Text = "Select"
        Me.btnSelectXDeltaFolder.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "XDelta Patch Location"
        '
        'lbxBatchPatchLog
        '
        Me.lbxBatchPatchLog.FormattingEnabled = True
        Me.lbxBatchPatchLog.ItemHeight = 15
        Me.lbxBatchPatchLog.Location = New System.Drawing.Point(3, 115)
        Me.lbxBatchPatchLog.Name = "lbxBatchPatchLog"
        Me.lbxBatchPatchLog.Size = New System.Drawing.Size(502, 154)
        Me.lbxBatchPatchLog.TabIndex = 7
        '
        'btnBatchPatchFileList
        '
        Me.btnBatchPatchFileList.Location = New System.Drawing.Point(176, 7)
        Me.btnBatchPatchFileList.Name = "btnBatchPatchFileList"
        Me.btnBatchPatchFileList.Size = New System.Drawing.Size(75, 23)
        Me.btnBatchPatchFileList.TabIndex = 6
        Me.btnBatchPatchFileList.Text = "Select"
        Me.btnBatchPatchFileList.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Location of Files to Patch"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.btnCreatePatchs)
        Me.TabPage2.Controls.Add(Me.lbxBatchCreatePatchLog)
        Me.TabPage2.Controls.Add(Me.btnLoadPatchList)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btnGeneratePatchList)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(514, 272)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Batch Create"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Create XDelta Patches"
        '
        'btnCreatePatchs
        '
        Me.btnCreatePatchs.Enabled = False
        Me.btnCreatePatchs.Location = New System.Drawing.Point(141, 68)
        Me.btnCreatePatchs.Name = "btnCreatePatchs"
        Me.btnCreatePatchs.Size = New System.Drawing.Size(75, 23)
        Me.btnCreatePatchs.TabIndex = 5
        Me.btnCreatePatchs.Text = "Create"
        Me.btnCreatePatchs.UseVisualStyleBackColor = True
        '
        'lbxBatchCreatePatchLog
        '
        Me.lbxBatchCreatePatchLog.FormattingEnabled = True
        Me.lbxBatchCreatePatchLog.ItemHeight = 15
        Me.lbxBatchCreatePatchLog.Location = New System.Drawing.Point(6, 106)
        Me.lbxBatchCreatePatchLog.Name = "lbxBatchCreatePatchLog"
        Me.lbxBatchCreatePatchLog.Size = New System.Drawing.Size(502, 154)
        Me.lbxBatchCreatePatchLog.TabIndex = 4
        '
        'btnLoadPatchList
        '
        Me.btnLoadPatchList.Location = New System.Drawing.Point(141, 39)
        Me.btnLoadPatchList.Name = "btnLoadPatchList"
        Me.btnLoadPatchList.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadPatchList.TabIndex = 3
        Me.btnLoadPatchList.Text = "Load"
        Me.btnLoadPatchList.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Load File Patch List"
        '
        'btnGeneratePatchList
        '
        Me.btnGeneratePatchList.Location = New System.Drawing.Point(141, 10)
        Me.btnGeneratePatchList.Name = "btnGeneratePatchList"
        Me.btnGeneratePatchList.Size = New System.Drawing.Size(75, 23)
        Me.btnGeneratePatchList.TabIndex = 1
        Me.btnGeneratePatchList.Text = "Generate"
        Me.btnGeneratePatchList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generate File Patch List"
        '
        'fbdOldGeneratePatchList
        '
        Me.fbdOldGeneratePatchList.Description = "Select folder that contains unmodified files"
        '
        'fbdNewGeneratePatchList
        '
        Me.fbdNewGeneratePatchList.Description = "Select folder that contains modified files"
        '
        'ofdPatchFileList
        '
        Me.ofdPatchFileList.FileName = "OpenFileDialog1"
        Me.ofdPatchFileList.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        Me.ofdPatchFileList.Title = "Select Generated Patch File List"
        '
        'fbdXDeltaPatchFolder
        '
        Me.fbdXDeltaPatchFolder.Description = "Select the folder that contains all your Xdelta Patches"
        '
        'fbdFilestoPatchFolder
        '
        Me.fbdFilestoPatchFolder.Description = "Select the folder which contains the files you wish to patch"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Create Patch"
        '
        'btnCreatePatch
        '
        Me.btnCreatePatch.Enabled = False
        Me.btnCreatePatch.Location = New System.Drawing.Point(118, 66)
        Me.btnCreatePatch.Name = "btnCreatePatch"
        Me.btnCreatePatch.Size = New System.Drawing.Size(75, 23)
        Me.btnCreatePatch.TabIndex = 8
        Me.btnCreatePatch.Text = "Create"
        Me.btnCreatePatch.UseVisualStyleBackColor = True
        '
        'lbxSingleCreatePatchLog
        '
        Me.lbxSingleCreatePatchLog.FormattingEnabled = True
        Me.lbxSingleCreatePatchLog.ItemHeight = 15
        Me.lbxSingleCreatePatchLog.Location = New System.Drawing.Point(3, 115)
        Me.lbxSingleCreatePatchLog.Name = "lbxSingleCreatePatchLog"
        Me.lbxSingleCreatePatchLog.Size = New System.Drawing.Size(502, 154)
        Me.lbxSingleCreatePatchLog.TabIndex = 7
        '
        'btnSourceFile
        '
        Me.btnSourceFile.Location = New System.Drawing.Point(118, 8)
        Me.btnSourceFile.Name = "btnSourceFile"
        Me.btnSourceFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSourceFile.TabIndex = 10
        Me.btnSourceFile.Text = "Select"
        Me.btnSourceFile.UseVisualStyleBackColor = True
        '
        'btnModifiedFile
        '
        Me.btnModifiedFile.Location = New System.Drawing.Point(118, 37)
        Me.btnModifiedFile.Name = "btnModifiedFile"
        Me.btnModifiedFile.Size = New System.Drawing.Size(75, 23)
        Me.btnModifiedFile.TabIndex = 11
        Me.btnModifiedFile.Text = "Select"
        Me.btnModifiedFile.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Select Original File"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Select Modified File"
        '
        'ofdSingleOriginalFile
        '
        Me.ofdSingleOriginalFile.FileName = "OpenFileDialog1"
        '
        'ofdSingleModifiedFile
        '
        Me.ofdSingleModifiedFile.FileName = "OpenFileDialog1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Select XDelta Patch"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Select Original File"
        '
        'btnSelectXDeltaPatch
        '
        Me.btnSelectXDeltaPatch.Location = New System.Drawing.Point(121, 35)
        Me.btnSelectXDeltaPatch.Name = "btnSelectXDeltaPatch"
        Me.btnSelectXDeltaPatch.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectXDeltaPatch.TabIndex = 18
        Me.btnSelectXDeltaPatch.Text = "Select"
        Me.btnSelectXDeltaPatch.UseVisualStyleBackColor = True
        '
        'btnSelectOrignalPatch
        '
        Me.btnSelectOrignalPatch.Location = New System.Drawing.Point(121, 6)
        Me.btnSelectOrignalPatch.Name = "btnSelectOrignalPatch"
        Me.btnSelectOrignalPatch.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectOrignalPatch.TabIndex = 17
        Me.btnSelectOrignalPatch.Text = "Select"
        Me.btnSelectOrignalPatch.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Patch File"
        '
        'btnSinglePatchFile
        '
        Me.btnSinglePatchFile.Enabled = False
        Me.btnSinglePatchFile.Location = New System.Drawing.Point(121, 64)
        Me.btnSinglePatchFile.Name = "btnSinglePatchFile"
        Me.btnSinglePatchFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSinglePatchFile.TabIndex = 15
        Me.btnSinglePatchFile.Text = "Patch"
        Me.btnSinglePatchFile.UseVisualStyleBackColor = True
        '
        'lbxSinglePatchFileLog
        '
        Me.lbxSinglePatchFileLog.FormattingEnabled = True
        Me.lbxSinglePatchFileLog.ItemHeight = 15
        Me.lbxSinglePatchFileLog.Location = New System.Drawing.Point(6, 113)
        Me.lbxSinglePatchFileLog.Name = "lbxSinglePatchFileLog"
        Me.lbxSinglePatchFileLog.Size = New System.Drawing.Size(502, 154)
        Me.lbxSinglePatchFileLog.TabIndex = 14
        '
        'ofdSingleXDeltaPatch
        '
        Me.ofdSingleXDeltaPatch.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 324)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "XDelta Batch GUI"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbxBatchCreatePatchLog As ListBox
    Friend WithEvents btnLoadPatchList As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGeneratePatchList As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents fbdOldGeneratePatchList As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents fbdNewGeneratePatchList As FolderBrowserDialog
    Friend WithEvents ofdPatchFileList As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCreatePatchs As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lbxBatchPatchLog As ListBox
    Friend WithEvents btnBatchPatchFileList As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSelectXDeltaFolder As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents fbdXDeltaPatchFolder As FolderBrowserDialog
    Friend WithEvents fbdFilestoPatchFolder As FolderBrowserDialog
    Friend WithEvents btnStartBatchPatching As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnModifiedFile As Button
    Friend WithEvents btnSourceFile As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCreatePatch As Button
    Friend WithEvents lbxSingleCreatePatchLog As ListBox
    Friend WithEvents ofdSingleOriginalFile As OpenFileDialog
    Friend WithEvents ofdSingleModifiedFile As OpenFileDialog
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSelectXDeltaPatch As Button
    Friend WithEvents btnSelectOrignalPatch As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSinglePatchFile As Button
    Friend WithEvents lbxSinglePatchFileLog As ListBox
    Friend WithEvents ofdSingleXDeltaPatch As OpenFileDialog
End Class
