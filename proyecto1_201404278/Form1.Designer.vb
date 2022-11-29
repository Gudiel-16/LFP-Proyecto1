<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuabrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuguardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuguardarcomo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menusalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalizarLexicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrafoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeLaAplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.areaAnalizar = New System.Windows.Forms.RichTextBox()
        Me.dgvbuena = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lexema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgverror = New System.Windows.Forms.DataGridView()
        Me.NumeroE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineaE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bttanalizar = New System.Windows.Forms.Button()
        Me.bttlimpiar = New System.Windows.Forms.Button()
        Me.tablagrafo = New System.Windows.Forms.DataGridView()
        Me.datos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tablagrafo2 = New System.Windows.Forms.DataGridView()
        Me.datos2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgverror2 = New System.Windows.Forms.DataGridView()
        Me.lexema2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvbuena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgverror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablagrafo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablagrafo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgverror2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdicionToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.AyudaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuabrir, Me.menuguardar, Me.menuguardarcomo, Me.menusalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'menuabrir
        '
        Me.menuabrir.Name = "menuabrir"
        Me.menuabrir.Size = New System.Drawing.Size(173, 24)
        Me.menuabrir.Text = "Abrir"
        '
        'menuguardar
        '
        Me.menuguardar.Name = "menuguardar"
        Me.menuguardar.Size = New System.Drawing.Size(173, 24)
        Me.menuguardar.Text = "Guardar"
        '
        'menuguardarcomo
        '
        Me.menuguardarcomo.Name = "menuguardarcomo"
        Me.menuguardarcomo.Size = New System.Drawing.Size(173, 24)
        Me.menuguardarcomo.Text = "Guardar como"
        '
        'menusalir
        '
        Me.menusalir.Name = "menusalir"
        Me.menusalir.Size = New System.Drawing.Size(173, 24)
        Me.menusalir.Text = "Salir"
        '
        'EdicionToolStripMenuItem
        '
        Me.EdicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalizarLexicoToolStripMenuItem})
        Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.EdicionToolStripMenuItem.Text = "Analizar"
        '
        'AnalizarLexicoToolStripMenuItem
        '
        Me.AnalizarLexicoToolStripMenuItem.Name = "AnalizarLexicoToolStripMenuItem"
        Me.AnalizarLexicoToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.AnalizarLexicoToolStripMenuItem.Text = "Analizar Lexico"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DdToolStripMenuItem, Me.ErroresToolStripMenuItem, Me.GrafoToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.AyudaToolStripMenuItem.Text = "Reportes"
        '
        'DdToolStripMenuItem
        '
        Me.DdToolStripMenuItem.Name = "DdToolStripMenuItem"
        Me.DdToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.DdToolStripMenuItem.Text = "Tokens"
        '
        'ErroresToolStripMenuItem
        '
        Me.ErroresToolStripMenuItem.Name = "ErroresToolStripMenuItem"
        Me.ErroresToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.ErroresToolStripMenuItem.Text = "Errores"
        '
        'GrafoToolStripMenuItem
        '
        Me.GrafoToolStripMenuItem.Name = "GrafoToolStripMenuItem"
        Me.GrafoToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.GrafoToolStripMenuItem.Text = "Grafo"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeLaAplicacionToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(63, 24)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        '
        'ManualDeLaAplicacionToolStripMenuItem
        '
        Me.ManualDeLaAplicacionToolStripMenuItem.Name = "ManualDeLaAplicacionToolStripMenuItem"
        Me.ManualDeLaAplicacionToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.ManualDeLaAplicacionToolStripMenuItem.Text = "Manual de la Aplicacion"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'areaAnalizar
        '
        Me.areaAnalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.areaAnalizar.Location = New System.Drawing.Point(12, 38)
        Me.areaAnalizar.Name = "areaAnalizar"
        Me.areaAnalizar.Size = New System.Drawing.Size(372, 656)
        Me.areaAnalizar.TabIndex = 1
        Me.areaAnalizar.Text = ""
        '
        'dgvbuena
        '
        Me.dgvbuena.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvbuena.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvbuena.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvbuena.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvbuena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbuena.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.Lexema, Me.Tipo, Me.Columna, Me.Linea})
        Me.dgvbuena.EnableHeadersVisualStyles = False
        Me.dgvbuena.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgvbuena.Location = New System.Drawing.Point(407, 73)
        Me.dgvbuena.Name = "dgvbuena"
        Me.dgvbuena.Size = New System.Drawing.Size(544, 150)
        Me.dgvbuena.TabIndex = 2
        '
        'Numero
        '
        Me.Numero.HeaderText = "No."
        Me.Numero.Name = "Numero"
        '
        'Lexema
        '
        Me.Lexema.HeaderText = "Lexema"
        Me.Lexema.Name = "Lexema"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Columna
        '
        Me.Columna.HeaderText = "Columna"
        Me.Columna.Name = "Columna"
        '
        'Linea
        '
        Me.Linea.HeaderText = "Linea"
        Me.Linea.Name = "Linea"
        '
        'dgverror
        '
        Me.dgverror.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgverror.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgverror.BackgroundColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgverror.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgverror.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgverror.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroE, Me.ErrorE, Me.ColumnaE, Me.LineaE})
        Me.dgverror.EnableHeadersVisualStyles = False
        Me.dgverror.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgverror.Location = New System.Drawing.Point(407, 269)
        Me.dgverror.Name = "dgverror"
        Me.dgverror.Size = New System.Drawing.Size(544, 152)
        Me.dgverror.TabIndex = 3
        '
        'NumeroE
        '
        Me.NumeroE.HeaderText = "No."
        Me.NumeroE.Name = "NumeroE"
        '
        'ErrorE
        '
        Me.ErrorE.HeaderText = "Error"
        Me.ErrorE.Name = "ErrorE"
        '
        'ColumnaE
        '
        Me.ColumnaE.HeaderText = "Columna"
        Me.ColumnaE.Name = "ColumnaE"
        '
        'LineaE
        '
        Me.LineaE.HeaderText = "Linea"
        Me.LineaE.Name = "LineaE"
        '
        'bttanalizar
        '
        Me.bttanalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttanalizar.Location = New System.Drawing.Point(523, 645)
        Me.bttanalizar.Name = "bttanalizar"
        Me.bttanalizar.Size = New System.Drawing.Size(138, 49)
        Me.bttanalizar.TabIndex = 4
        Me.bttanalizar.Text = "ANALIZAR"
        Me.bttanalizar.UseVisualStyleBackColor = True
        '
        'bttlimpiar
        '
        Me.bttlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttlimpiar.Location = New System.Drawing.Point(706, 645)
        Me.bttlimpiar.Name = "bttlimpiar"
        Me.bttlimpiar.Size = New System.Drawing.Size(126, 49)
        Me.bttlimpiar.TabIndex = 7
        Me.bttlimpiar.Text = "LIMPIAR"
        Me.bttlimpiar.UseVisualStyleBackColor = True
        '
        'tablagrafo
        '
        Me.tablagrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablagrafo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.datos})
        Me.tablagrafo.Location = New System.Drawing.Point(15, 740)
        Me.tablagrafo.Name = "tablagrafo"
        Me.tablagrafo.Size = New System.Drawing.Size(891, 55)
        Me.tablagrafo.TabIndex = 8
        '
        'datos
        '
        Me.datos.HeaderText = "datos"
        Me.datos.Name = "datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 724)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Para las clases"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 807)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Para las relaciones"
        '
        'tablagrafo2
        '
        Me.tablagrafo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablagrafo2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.datos2})
        Me.tablagrafo2.Location = New System.Drawing.Point(12, 823)
        Me.tablagrafo2.Name = "tablagrafo2"
        Me.tablagrafo2.Size = New System.Drawing.Size(888, 47)
        Me.tablagrafo2.TabIndex = 11
        '
        'datos2
        '
        Me.datos2.HeaderText = "datos2"
        Me.datos2.Name = "datos2"
        '
        'dgverror2
        '
        Me.dgverror2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgverror2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgverror2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgverror2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgverror2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgverror2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lexema2, Me.descripcion, Me.Tipo2})
        Me.dgverror2.EnableHeadersVisualStyles = False
        Me.dgverror2.GridColor = System.Drawing.SystemColors.Highlight
        Me.dgverror2.Location = New System.Drawing.Point(407, 479)
        Me.dgverror2.Name = "dgverror2"
        Me.dgverror2.Size = New System.Drawing.Size(544, 124)
        Me.dgverror2.TabIndex = 12
        '
        'lexema2
        '
        Me.lexema2.HeaderText = "Error"
        Me.lexema2.Name = "lexema2"
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        '
        'Tipo2
        '
        Me.Tipo2.HeaderText = "Tipo"
        Me.Tipo2.Name = "Tipo2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(631, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tokens"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(597, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Errores Lexicos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(597, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 29)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Otros Errores"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(964, 712)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgverror2)
        Me.Controls.Add(Me.tablagrafo2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tablagrafo)
        Me.Controls.Add(Me.bttlimpiar)
        Me.Controls.Add(Me.bttanalizar)
        Me.Controls.Add(Me.dgverror)
        Me.Controls.Add(Me.dgvbuena)
        Me.Controls.Add(Me.areaAnalizar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ANALIZADOR LEXICO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvbuena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgverror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablagrafo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablagrafo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgverror2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuabrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuguardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuguardarcomo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menusalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents areaAnalizar As System.Windows.Forms.RichTextBox
    Friend WithEvents dgvbuena As System.Windows.Forms.DataGridView
    Friend WithEvents Numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lexema As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Columna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgverror As System.Windows.Forms.DataGridView
    Friend WithEvents bttanalizar As System.Windows.Forms.Button
    Friend WithEvents DdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErroresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrafoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bttlimpiar As System.Windows.Forms.Button
    Friend WithEvents AnalizarLexicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeLaAplicacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumeroE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineaE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tablagrafo As System.Windows.Forms.DataGridView
    Friend WithEvents datos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tablagrafo2 As System.Windows.Forms.DataGridView
    Friend WithEvents datos2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgverror2 As System.Windows.Forms.DataGridView
    Friend WithEvents lexema2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
