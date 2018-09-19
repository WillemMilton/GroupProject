<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFreeStateGranniesSocialSaving
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdMembersInfo = New UJGrid.UJGrid()
        Me.btnInterestRate = New System.Windows.Forms.Button()
        Me.btnInputData = New System.Windows.Forms.Button()
        Me.btnSetApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdMembersInfo
        '
        Me.grdMembersInfo.FixedCols = 1
        Me.grdMembersInfo.FixedRows = 1
        Me.grdMembersInfo.Location = New System.Drawing.Point(12, 12)
        Me.grdMembersInfo.Name = "grdMembersInfo"
        Me.grdMembersInfo.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdMembersInfo.Size = New System.Drawing.Size(776, 230)
        Me.grdMembersInfo.TabIndex = 0
        '
        'btnInterestRate
        '
        Me.btnInterestRate.Location = New System.Drawing.Point(12, 248)
        Me.btnInterestRate.Name = "btnInterestRate"
        Me.btnInterestRate.Size = New System.Drawing.Size(116, 34)
        Me.btnInterestRate.TabIndex = 2
        Me.btnInterestRate.Text = "Change Interest Rate"
        Me.btnInterestRate.UseVisualStyleBackColor = True
        '
        'btnInputData
        '
        Me.btnInputData.Location = New System.Drawing.Point(12, 334)
        Me.btnInputData.Name = "btnInputData"
        Me.btnInputData.Size = New System.Drawing.Size(116, 39)
        Me.btnInputData.TabIndex = 3
        Me.btnInputData.Text = "Enter Information for Each Member"
        Me.btnInputData.UseVisualStyleBackColor = True
        '
        'btnSetApp
        '
        Me.btnSetApp.Location = New System.Drawing.Point(13, 288)
        Me.btnSetApp.Name = "btnSetApp"
        Me.btnSetApp.Size = New System.Drawing.Size(115, 40)
        Me.btnSetApp.TabIndex = 4
        Me.btnSetApp.Text = "Set Application"
        Me.btnSetApp.UseVisualStyleBackColor = True
        '
        'frmFreeStateGranniesSocialSaving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSetApp)
        Me.Controls.Add(Me.btnInputData)
        Me.Controls.Add(Me.btnInterestRate)
        Me.Controls.Add(Me.grdMembersInfo)
        Me.Name = "frmFreeStateGranniesSocialSaving"
        Me.Text = "The Free State Grannies Social Savings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdMembersInfo As UJGrid.UJGrid
    Friend WithEvents btnInterestRate As Button
    Friend WithEvents btnInputData As Button
    Friend WithEvents btnSetApp As Button
End Class
