<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_AktivitasTransaksi
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_AktivitasTransaksi))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvHistoryTrans = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GradientButton4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Shapes3 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgvHistoryTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.dgvHistoryTrans)
        Me.Guna2Panel2.Location = New System.Drawing.Point(239, 65)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.BorderRadius = 13
        Me.Guna2Panel2.ShadowDecoration.Depth = 15
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel2.Size = New System.Drawing.Size(664, 424)
        Me.Guna2Panel2.TabIndex = 93
        '
        'dgvHistoryTrans
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvHistoryTrans.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvHistoryTrans.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistoryTrans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvHistoryTrans.ColumnHeadersHeight = 4
        Me.dgvHistoryTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistoryTrans.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvHistoryTrans.GridColor = System.Drawing.Color.White
        Me.dgvHistoryTrans.Location = New System.Drawing.Point(36, 27)
        Me.dgvHistoryTrans.Name = "dgvHistoryTrans"
        Me.dgvHistoryTrans.RowHeadersVisible = False
        Me.dgvHistoryTrans.Size = New System.Drawing.Size(593, 297)
        Me.dgvHistoryTrans.TabIndex = 79
        Me.dgvHistoryTrans.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHistoryTrans.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvHistoryTrans.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvHistoryTrans.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvHistoryTrans.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvHistoryTrans.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvHistoryTrans.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvHistoryTrans.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistoryTrans.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHistoryTrans.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistoryTrans.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvHistoryTrans.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvHistoryTrans.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvHistoryTrans.ThemeStyle.ReadOnly = False
        Me.dgvHistoryTrans.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHistoryTrans.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistoryTrans.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistoryTrans.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvHistoryTrans.ThemeStyle.RowsStyle.Height = 22
        Me.dgvHistoryTrans.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistoryTrans.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2GradientButton4
        '
        Me.Guna2GradientButton4.AutoRoundedCorners = True
        Me.Guna2GradientButton4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton4.BorderColor = System.Drawing.Color.Silver
        Me.Guna2GradientButton4.BorderRadius = 18
        Me.Guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton4.FillColor = System.Drawing.Color.Orange
        Me.Guna2GradientButton4.FillColor2 = System.Drawing.Color.Orange
        Me.Guna2GradientButton4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton4.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.Orange
        Me.Guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.OldLace
        Me.Guna2GradientButton4.HoverState.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton4.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton4.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2GradientButton4.Image = CType(resources.GetObject("Guna2GradientButton4.Image"), System.Drawing.Image)
        Me.Guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton4.Location = New System.Drawing.Point(11, 639)
        Me.Guna2GradientButton4.Name = "Guna2GradientButton4"
        Me.Guna2GradientButton4.ShadowDecoration.Depth = 10
        Me.Guna2GradientButton4.Size = New System.Drawing.Size(205, 39)
        Me.Guna2GradientButton4.TabIndex = 4
        Me.Guna2GradientButton4.Text = "Log Out"
        Me.Guna2GradientButton4.UseTransparentBackground = True
        '
        'Guna2GradientButton3
        '
        Me.Guna2GradientButton3.AutoRoundedCorners = True
        Me.Guna2GradientButton3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton3.BorderColor = System.Drawing.Color.Silver
        Me.Guna2GradientButton3.BorderRadius = 18
        Me.Guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton3.FillColor = System.Drawing.Color.Orange
        Me.Guna2GradientButton3.FillColor2 = System.Drawing.Color.Orange
        Me.Guna2GradientButton3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton3.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.Orange
        Me.Guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.OldLace
        Me.Guna2GradientButton3.HoverState.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton3.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton3.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2GradientButton3.Image = CType(resources.GetObject("Guna2GradientButton3.Image"), System.Drawing.Image)
        Me.Guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton3.Location = New System.Drawing.Point(11, 187)
        Me.Guna2GradientButton3.Name = "Guna2GradientButton3"
        Me.Guna2GradientButton3.ShadowDecoration.Depth = 10
        Me.Guna2GradientButton3.Size = New System.Drawing.Size(205, 39)
        Me.Guna2GradientButton3.TabIndex = 3
        Me.Guna2GradientButton3.Text = "History Transaksi"
        Me.Guna2GradientButton3.UseTransparentBackground = True
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.BorderThickness = 1
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.White
        Me.Guna2Shapes1.LineThickness = 1
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-10, 565)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes1.Size = New System.Drawing.Size(215, 10)
        Me.Guna2Shapes1.TabIndex = 1
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2GradientButton1.BorderRadius = 18
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.Orange
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Orange
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Orange
        Me.Guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.OldLace
        Me.Guna2GradientButton1.HoverState.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.Guna2GradientButton1.Image = CType(resources.GetObject("Guna2GradientButton1.Image"), System.Drawing.Image)
        Me.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(11, 142)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Depth = 10
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(205, 39)
        Me.Guna2GradientButton1.TabIndex = 1
        Me.Guna2GradientButton1.Text = "Transaksi"
        Me.Guna2GradientButton1.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(30, 24)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(136, 33)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.DarkOrange
        Me.Guna2Shapes2.Location = New System.Drawing.Point(233, 43)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes2.Size = New System.Drawing.Size(239, 17)
        Me.Guna2Shapes2.TabIndex = 96
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.UseTransparentBackground = True
        Me.Guna2Shapes2.Zoom = 80
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me.Guna2Panel2
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Animated = True
        Me.Guna2DateTimePicker1.AutoRoundedCorners = True
        Me.Guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2DateTimePicker1.BorderColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.BorderRadius = 17
        Me.Guna2DateTimePicker1.BorderThickness = 2
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(688, 19)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(215, 36)
        Me.Guna2DateTimePicker1.TabIndex = 97
        Me.Guna2DateTimePicker1.UseTransparentBackground = True
        Me.Guna2DateTimePicker1.Value = New Date(2024, 12, 12, 10, 59, 37, 953)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(257, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 32)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Hasil Transaksi"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Orange
        Me.Guna2Panel1.Controls.Add(Me.Guna2Shapes3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GradientButton4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GradientButton3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Shapes1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GradientButton1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Depth = 10
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 5, 5, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(200, 714)
        Me.Guna2Panel1.TabIndex = 92
        '
        'Guna2Shapes3
        '
        Me.Guna2Shapes3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes3.BorderThickness = 1
        Me.Guna2Shapes3.FillColor = System.Drawing.Color.White
        Me.Guna2Shapes3.LineThickness = 1
        Me.Guna2Shapes3.Location = New System.Drawing.Point(-7, 123)
        Me.Guna2Shapes3.Name = "Guna2Shapes3"
        Me.Guna2Shapes3.PolygonSkip = 1
        Me.Guna2Shapes3.Rotate = 0!
        Me.Guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes3.Size = New System.Drawing.Size(215, 10)
        Me.Guna2Shapes3.TabIndex = 99
        Me.Guna2Shapes3.Text = "Guna2Shapes3"
        Me.Guna2Shapes3.Zoom = 80
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(56, 102)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(85, 22)
        Me.Guna2HtmlLabel1.TabIndex = 98
        Me.Guna2HtmlLabel1.Text = "Menu Kasir"
        '
        'Menu_AktivitasTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 715)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Menu_AktivitasTransaksi"
        Me.Text = "Menu_AktivitasTransaksi"
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.dgvHistoryTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GradientButton4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvHistoryTrans As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Shapes3 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
