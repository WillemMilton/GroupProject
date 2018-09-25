<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFreeStateGranniesSocialSavings
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
        Me.btnChangeInterest = New System.Windows.Forms.Button()
        Me.btnMembersRecords = New System.Windows.Forms.Button()
        Me.btnRemoveMember = New System.Windows.Forms.Button()
        Me.btnBorrowedMoney = New System.Windows.Forms.Button()
        Me.btnBorrowMoney = New System.Windows.Forms.Button()
        Me.grdSocialSavings = New UJGrid.UJGrid()
        Me.btnSetInterestRate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnWeeklyAmount = New System.Windows.Forms.Button()
        Me.btnPayMoney = New System.Windows.Forms.Button()
        Me.btnInterestRepayments = New System.Windows.Forms.Button()
        Me.btnProfitSpending = New System.Windows.Forms.Button()
        Me.txtTotalMoney = New System.Windows.Forms.TextBox()
        Me.lblTotalMoney = New System.Windows.Forms.Label()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChangeInterest
        '
        Me.btnChangeInterest.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnChangeInterest.Location = New System.Drawing.Point(12, 6)
        Me.btnChangeInterest.Name = "btnChangeInterest"
        Me.btnChangeInterest.Size = New System.Drawing.Size(145, 48)
        Me.btnChangeInterest.TabIndex = 0
        Me.btnChangeInterest.Text = "Change Interest Rate"
        Me.btnChangeInterest.UseVisualStyleBackColor = False
        '
        'btnMembersRecords
        '
        Me.btnMembersRecords.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMembersRecords.Location = New System.Drawing.Point(12, 60)
        Me.btnMembersRecords.Name = "btnMembersRecords"
        Me.btnMembersRecords.Size = New System.Drawing.Size(145, 45)
        Me.btnMembersRecords.TabIndex = 1
        Me.btnMembersRecords.Text = "Add Member"
        Me.btnMembersRecords.UseVisualStyleBackColor = False
        '
        'btnRemoveMember
        '
        Me.btnRemoveMember.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRemoveMember.Location = New System.Drawing.Point(218, 60)
        Me.btnRemoveMember.Name = "btnRemoveMember"
        Me.btnRemoveMember.Size = New System.Drawing.Size(141, 45)
        Me.btnRemoveMember.TabIndex = 2
        Me.btnRemoveMember.Text = "Remove Member"
        Me.btnRemoveMember.UseVisualStyleBackColor = False
        '
        'btnBorrowedMoney
        '
        Me.btnBorrowedMoney.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBorrowedMoney.Location = New System.Drawing.Point(218, 13)
        Me.btnBorrowedMoney.Name = "btnBorrowedMoney"
        Me.btnBorrowedMoney.Size = New System.Drawing.Size(141, 45)
        Me.btnBorrowedMoney.TabIndex = 3
        Me.btnBorrowedMoney.Text = "Check Who Still Owes Money"
        Me.btnBorrowedMoney.UseVisualStyleBackColor = False
        '
        'btnBorrowMoney
        '
        Me.btnBorrowMoney.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBorrowMoney.Location = New System.Drawing.Point(422, 13)
        Me.btnBorrowMoney.Name = "btnBorrowMoney"
        Me.btnBorrowMoney.Size = New System.Drawing.Size(152, 46)
        Me.btnBorrowMoney.TabIndex = 4
        Me.btnBorrowMoney.Text = "Borrow Money"
        Me.btnBorrowMoney.UseVisualStyleBackColor = False
        '
        'grdSocialSavings
        '
        Me.grdSocialSavings.FixedCols = 1
        Me.grdSocialSavings.FixedRows = 1
        Me.grdSocialSavings.Location = New System.Drawing.Point(12, 161)
        Me.grdSocialSavings.Name = "grdSocialSavings"
        Me.grdSocialSavings.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdSocialSavings.Size = New System.Drawing.Size(776, 306)
        Me.grdSocialSavings.TabIndex = 5
        '
        'btnSetInterestRate
        '
        Me.btnSetInterestRate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSetInterestRate.Location = New System.Drawing.Point(12, 473)
        Me.btnSetInterestRate.Name = "btnSetInterestRate"
        Me.btnSetInterestRate.Size = New System.Drawing.Size(145, 57)
        Me.btnSetInterestRate.TabIndex = 6
        Me.btnSetInterestRate.Text = "Set The Interest Rate "
        Me.btnSetInterestRate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(612, 473)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(159, 57)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnWeeklyAmount
        '
        Me.btnWeeklyAmount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnWeeklyAmount.Location = New System.Drawing.Point(12, 111)
        Me.btnWeeklyAmount.Name = "btnWeeklyAmount"
        Me.btnWeeklyAmount.Size = New System.Drawing.Size(145, 44)
        Me.btnWeeklyAmount.TabIndex = 8
        Me.btnWeeklyAmount.Text = "Pay The Weekly Amount"
        Me.btnWeeklyAmount.UseVisualStyleBackColor = False
        '
        'btnPayMoney
        '
        Me.btnPayMoney.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPayMoney.Location = New System.Drawing.Point(422, 65)
        Me.btnPayMoney.Name = "btnPayMoney"
        Me.btnPayMoney.Size = New System.Drawing.Size(152, 40)
        Me.btnPayMoney.TabIndex = 9
        Me.btnPayMoney.Text = "Pay Money Borrowed"
        Me.btnPayMoney.UseVisualStyleBackColor = False
        '
        'btnInterestRepayments
        '
        Me.btnInterestRepayments.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInterestRepayments.Location = New System.Drawing.Point(218, 111)
        Me.btnInterestRepayments.Name = "btnInterestRepayments"
        Me.btnInterestRepayments.Size = New System.Drawing.Size(141, 44)
        Me.btnInterestRepayments.TabIndex = 10
        Me.btnInterestRepayments.Text = "Interest Repayments"
        Me.btnInterestRepayments.UseVisualStyleBackColor = False
        '
        'btnProfitSpending
        '
        Me.btnProfitSpending.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnProfitSpending.Location = New System.Drawing.Point(422, 111)
        Me.btnProfitSpending.Name = "btnProfitSpending"
        Me.btnProfitSpending.Size = New System.Drawing.Size(152, 44)
        Me.btnProfitSpending.TabIndex = 11
        Me.btnProfitSpending.Text = "Profit Spending"
        Me.btnProfitSpending.UseVisualStyleBackColor = False
        '
        'txtTotalMoney
        '
        Me.txtTotalMoney.Location = New System.Drawing.Point(591, 129)
        Me.txtTotalMoney.Name = "txtTotalMoney"
        Me.txtTotalMoney.Size = New System.Drawing.Size(146, 20)
        Me.txtTotalMoney.TabIndex = 12
        '
        'lblTotalMoney
        '
        Me.lblTotalMoney.AutoSize = True
        Me.lblTotalMoney.Location = New System.Drawing.Point(612, 98)
        Me.lblTotalMoney.Name = "lblTotalMoney"
        Me.lblTotalMoney.Size = New System.Drawing.Size(107, 13)
        Me.lblTotalMoney.TabIndex = 13
        Me.lblTotalMoney.Text = "Total Money in Chest"
        '
        'btnVote
        '
        Me.btnVote.Location = New System.Drawing.Point(591, 13)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(152, 46)
        Me.btnVote.TabIndex = 14
        Me.btnVote.Text = "Vote"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'frmFreeStateGranniesSocialSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 542)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.lblTotalMoney)
        Me.Controls.Add(Me.txtTotalMoney)
        Me.Controls.Add(Me.btnProfitSpending)
        Me.Controls.Add(Me.btnInterestRepayments)
        Me.Controls.Add(Me.btnPayMoney)
        Me.Controls.Add(Me.btnWeeklyAmount)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSetInterestRate)
        Me.Controls.Add(Me.grdSocialSavings)
        Me.Controls.Add(Me.btnBorrowMoney)
        Me.Controls.Add(Me.btnBorrowedMoney)
        Me.Controls.Add(Me.btnRemoveMember)
        Me.Controls.Add(Me.btnMembersRecords)
        Me.Controls.Add(Me.btnChangeInterest)
        Me.Name = "frmFreeStateGranniesSocialSavings"
        Me.Text = "The Free State Grannies Social Savings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChangeInterest As Button
    Friend WithEvents btnMembersRecords As Button
    Friend WithEvents btnRemoveMember As Button
    Friend WithEvents btnBorrowedMoney As Button
    Friend WithEvents btnBorrowMoney As Button
    Friend WithEvents grdSocialSavings As UJGrid.UJGrid
    Friend WithEvents btnSetInterestRate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnWeeklyAmount As Button
    Friend WithEvents btnPayMoney As Button
    Friend WithEvents btnInterestRepayments As Button
    Friend WithEvents btnProfitSpending As Button
    Friend WithEvents txtTotalMoney As TextBox
    Friend WithEvents lblTotalMoney As Label
    Friend WithEvents btnVote As Button
End Class
