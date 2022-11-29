Imports System.IO
Imports System.Drawing

Public Class Form1

    Dim contador_token As Integer = 0
    Dim contador_error_1 As Integer = 0
    Dim contadorLlaves As Integer = 0
    Dim contadorLlaves2 As Integer = 0
   

    Public Sub metodo_abrir()
        Dim OpenFileDialog1 As New OpenFileDialog()
        Dim Alltext As String = "", LineOfText As String = ""
        OpenFileDialog1.Filter = "Text files (*.lfp)|*.lfp"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Try
                FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
                Do Until EOF(1)
                    LineOfText = LineInput(1)
                    Alltext = Alltext & LineOfText & vbCrLf
                Loop
                'ArchivoToolStripMenuItem.Text = OpenFileDialog1.FileName'
                areaAnalizar.Text = Alltext
                areaAnalizar.Enabled = True
                'ToolStripMenuItem.Close.Enabled = True'

            Catch ex As Exception
                MsgBox("Error")
            Finally
                FileClose(1)
            End Try
        End If
    End Sub

    Public Sub metodo_guardar()
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.Filter = "Documento LFP [*.LFP*]|*.LFP*|Todos los archivos [*,*]|*,*"
        Save.CheckPathExists = True
        Save.Title = "Guardar"
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Save.FileName & ".lfp")
            myStreamWriter.Write(areaAnalizar.Text)
            myStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub metodo_guardarcomo()
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.Filter = "Documento LFP [*.lfprec*]|*.lfprec*|Todos los archivos [*,*]|*,*"
        Save.CheckPathExists = True
        Save.Title = "Guardar"
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Save.FileName & ".lfp")
            myStreamWriter.Write(areaAnalizar.Text)
            myStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub metodo_salir()
        Close()
    End Sub

    Private Sub menuabrir_Click(sender As Object, e As EventArgs) Handles menuabrir.Click
        metodo_abrir()
    End Sub

    Private Sub menuguardar_Click(sender As Object, e As EventArgs) Handles menuguardar.Click
        metodo_guardar()
    End Sub

    Private Sub menuguardarcomo_Click(sender As Object, e As EventArgs) Handles menuguardarcomo.Click
        metodo_guardarcomo()
    End Sub

    Private Sub menusalir_Click(sender As Object, e As EventArgs) Handles menusalir.Click
        metodo_salir()
    End Sub

    Public Sub metodo_analizar()
        Dim caracterAUX_1 As String = ""
        Dim caracterAUX_2 As String = ""
        Dim caracter_1 As String = ""
        Dim columna_1 As Integer = 1
        Dim fila_1 As Integer = 1
        Dim examinar_ascii_1 As Integer = 0
        Dim estado As Integer = 0
        Dim examinar_1 As String = ""
        Dim texto_1 As String = areaAnalizar.Text.ToCharArray 'me sapara todos los caracter del area analizar para que vaya analizando caracter por caracter

        For puntero_1 As Integer = 0 To areaAnalizar.TextLength - 1 'ciclo para que vaya anilizando cada caracter y me de el codigo ascii
            examinar_1 = texto_1(puntero_1)
            examinar_ascii_1 = Asc(examinar_1)
            'Console.WriteLine(examinar_ascii_1)

            Select Case estado

                Case 0
                    If examinar_ascii_1 = 10 Then  'salto de linea'
                        fila_1 = fila_1 + 1
                        columna_1 = 1
                        estado = 0
                    ElseIf examinar_ascii_1 = 32 Then   'espacio en blanco'
                        columna_1 = columna_1 + 1
                        estado = 0
                    ElseIf examinar_ascii_1 = 9 Then 'tabulacion'
                        columna_1 = columna_1 + 1
                        estado = 0
                    ElseIf (examinar_ascii_1 > 64 And examinar_ascii_1 < 91) Or (examinar_ascii_1 > 96 And examinar_ascii_1 < 123) Then 'letras'
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 1
                    ElseIf (examinar_ascii_1 > 47 And examinar_ascii_1 < 58) Then 'numeros'
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 1
                    ElseIf examinar_ascii_1 = 91 Or examinar_ascii_1 = 93 Then ' [  ]
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 6
                    ElseIf examinar_ascii_1 = 123 Or examinar_ascii_1 = 125 Then ' { }
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 2
                    ElseIf examinar_ascii_1 = 59 Then ' ;
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 3
                    ElseIf examinar_ascii_1 = 61 Then ' =
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 4
                    ElseIf examinar_ascii_1 = 58 Then ' :
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 5
                    ElseIf examinar_ascii_1 = 40 Or examinar_ascii_1 = 41 Then ' ( )
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 7
                    ElseIf examinar_ascii_1 = 43 Then ' +
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 7
                    ElseIf examinar_ascii_1 = 45 Then ' -
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 7
                    ElseIf examinar_ascii_1 = 35 Then ' #
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 7
                    Else
                        Metodo_Errores(examinar_1, fila_1, columna_1)

                    End If



                Case 1
                    If (examinar_ascii_1 > 64 And examinar_ascii_1 < 91) Or (examinar_ascii_1 > 96 And examinar_ascii_1 < 123) Then 'letras'
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 1
                    ElseIf (examinar_ascii_1 > 47 And examinar_ascii_1 < 58) Then  'numeros'
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 1
                    
                    Else
                        Metodo2_tokens(caracter_1, fila_1, columna_1, caracterAUX_1, caracterAUX_2) 'llenar campos de envio lexico'
                        caracter_1 = ""
                        puntero_1 = puntero_1 - 1
                        estado = 0

                    End If

                Case 2 'para signos { } como es signo lo agrega a la tabla 
                    Metodo2_tokens(caracter_1, fila_1, columna_1, caracterAUX_1, caracterAUX_2) 'llenar campos de envio lexico'
                    caracter_1 = ""
                    puntero_1 = puntero_1 - 1
                    estado = 0

                Case 3
                    Metodo2_tokens(caracter_1, fila_1, columna_1, caracterAUX_1, caracterAUX_2) 'llenar campos de envio lexico'
                    caracter_1 = ""
                    puntero_1 = puntero_1 - 1
                    estado = 0

                Case 4
                    Metodo2_tokens(caracter_1, fila_1, columna_1, caracterAUX_1, caracterAUX_2) 'llenar campos de envio lexico'
                    caracter_1 = ""
                    puntero_1 = puntero_1 - 1
                    estado = 0

                Case 5
                    Metodo2_tokens(caracter_1, fila_1, columna_1, caracterAUX_1, caracterAUX_2) 'llenar campos de envio lexico'
                    caracter_1 = ""
                    puntero_1 = puntero_1 - 1
                    estado = 0

                Case 6
                    Metodo2_tokens(caracter_1, fila_1, columna_1, caracterAUX_1, caracterAUX_2) 'llenar campos de envio lexico'
                    caracter_1 = ""
                    puntero_1 = puntero_1 - 1
                    estado = 0
                Case 7
                    If examinar_ascii_1 = 40 Or examinar_ascii_1 = 41 Or examinar_ascii_1 = 43 Or examinar_ascii_1 = 45 Or examinar_ascii_1 = 35 Then
                        columna_1 = columna_1 + 1
                        caracter_1 = caracter_1 & examinar_1
                        estado = 7
                    Else
                        Metodo2_tokens(caracter_1, fila_1, columna_1, caracterAUX_1, caracterAUX_2) 'llenar campos de envio lexico'
                        caracter_1 = ""
                        puntero_1 = puntero_1 - 1
                        estado = 0
                    End If

            End Select


        Next
    End Sub

    Public Sub Metodo2_tokens(ByVal caracter_1 As String, ByVal fila_1 As Integer, ByVal columna_1 As Integer, ByVal caracterAUX_1 As String, ByVal caracterAUX_2 As String)


        Dim no_token As Integer = 0
        Dim eltoken As String = ""   'tipo token'

        Dim token_1 As String = "{"
        Dim token_2 As String = "}"
        Dim token_3 As String = "Clase"
        Dim token_4 As String = "Nombre"
        Dim token_5 As String = ";"
        Dim token_6 As String = "="
        Dim token_7 As String = "Atributos"
        Dim token_8 As String = ":"
        Dim token_9 As String = "(+)"
        Dim token_10 As String = "(-)"
        Dim token_11 As String = "(#)"
        Dim token_12 As String = "Metodos"
        Dim token_13 As String = "Asociacion"
        Dim token_14 As String = "Agregacion"
        Dim token_15 As String = "Composicion"
        Dim token_16 As String = "Herencia"
        Dim token_17 As String = "AsociacionSimple"
        Dim token_18 As String = "["
        Dim token_19 As String = "]"
        Dim token_20 As String = ")"
        Dim token_21 As String = "("
        Dim token_22 As String = "+"
        Dim token_23 As String = "-"
        Dim token_24 As String = "#"


        ' Dim token_13 As String = "ID"

        Dim var_caracter As String = ""
        Dim var_tipotoke As String = ""
        Dim var_notoken As Integer = 0
        Dim var_posicion As String = ""
        
        Select Case caracter_1
            Case token_1
                eltoken = "{"
                no_token = 1
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo {"
                var_notoken = 1
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_2
                eltoken = "}"
                no_token = 2
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo }"
                var_notoken = 2
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_3
                eltoken = "Clase"
                no_token = 3
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Palabra Reservada"
                var_notoken = 3
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_4
                eltoken = "Nombre"
                no_token = 4
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Palabra Reservada"
                var_notoken = 4
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_5
                eltoken = ";"
                no_token = 5
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo ;"
                var_notoken = 5
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_6
                eltoken = "="
                no_token = 6
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo ="
                var_notoken = 6
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_7
                eltoken = "Atributos"
                no_token = 7
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Palabra Reservada"
                var_notoken = 7
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_8
                eltoken = ":"
                no_token = 8
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo :"
                var_notoken = 8
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_9
                eltoken = "(+)"
                no_token = 9
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Visibilidad"
                var_notoken = 9
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_10
                eltoken = "(-)"
                no_token = 10
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Visibilidad"
                var_notoken = 10
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_11
                eltoken = "(#)"
                no_token = 11
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Visibilidad"
                var_notoken = 11
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_12
                eltoken = "Metodos"
                no_token = 12
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Palabra Reservada"
                var_notoken = 12
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_13
                eltoken = "Asociacion"
                no_token = 13
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Palabra Reservada"
                var_notoken = 13
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_14
                eltoken = "Agregacion"
                no_token = 14
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Palabra Reservada"
                var_notoken = 14
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_15
                eltoken = "Composicion"
                no_token = 15
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Palabra Reservada"
                var_notoken = 15
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_16
                eltoken = "Herencia"
                no_token = 16
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Palabra Reservada"
                var_notoken = 16
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_17
                eltoken = "AsociacionSimple"
                no_token = 17
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Palabra Reservada"
                var_notoken = 17
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_18
                eltoken = "["
                no_token = 18
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo ["
                var_notoken = 18
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_19
                eltoken = "]"
                no_token = 17
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo ]"
                var_notoken = 17
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_20
                eltoken = ")"
                no_token = 20
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo )"
                var_notoken = 15
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_21
                eltoken = "("
                no_token = 16
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo ("
                var_notoken = 16
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_22
                eltoken = "AsociacionSimple"
                no_token = 17
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo +"
                var_notoken = 17
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_23
                eltoken = "-"
                no_token = 18
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo -"
                var_notoken = 18
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case token_24
                eltoken = "#"
                no_token = 17
                contador_token = contador_token + 1

                var_caracter = caracter_1
                var_tipotoke = "Signo #"
                var_notoken = 17
                var_posicion = "fila" & fila_1 & "columna" & columna_1

            Case Else
                contador_token = contador_token + 1
                var_caracter = caracter_1
                var_tipotoke = "Identificador"
                var_notoken = 6
                var_posicion = "fila" & fila_1 & "columna" & columna_1

        End Select

       
        dgvbuena.Rows.Add(contador_token, caracter_1, var_tipotoke, columna_1, fila_1)

    End Sub

    Public Sub Metodo_Errores(ByVal examinar_1 As String, ByVal fila_1 As Integer, ByVal columna_1 As Integer)

        contador_error_1 = contador_error_1 + 1
        dgverror.Rows.Add(contador_error_1, examinar_1, columna_1, fila_1)

    End Sub

    Public Sub MetodoHTML_bueno()


        Dim ii As Integer = 0
        Dim DireccionDocumento As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        My.Computer.FileSystem.CreateDirectory(DireccionDocumento & "\Reportes")
        Dim Path As String = DireccionDocumento & "\Reportes\Reporte_Tokens.html"
        Dim Archivo As FileInfo = New FileInfo(Path)
        Dim Escribir As StreamWriter
        Escribir = File.CreateText(Path)
        Escribir.WriteLine("<html>")
        Escribir.WriteLine("<head><title>Reporte De Tokens</title></head>")
        Escribir.WriteLine("<body bgcolor=white text=Black background=FondoEj3.gif >")
        Escribir.WriteLine("<h1><center>Reporte Tokens</center></h1>")
        Escribir.WriteLine("<br>")
        Escribir.WriteLine("<center>")
        Escribir.WriteLine("<table border= 1 width= 500 bgcolor= SILVER>")
        Escribir.WriteLine("<tr>")
        Escribir.WriteLine("<th>No.</th>")
        Escribir.WriteLine("<th>Lexema</th>")
        Escribir.WriteLine("<th>Tipo</th>")
        Escribir.WriteLine("<th>Columna</th>")
        Escribir.WriteLine("<th>Linea</th>")

        Escribir.WriteLine("</tr>")
        Dim PosicionError As Integer = 0
        For Each row As DataGridViewRow In dgvbuena.Rows

            Escribir.WriteLine("<tr>")
            Escribir.WriteLine("<th>" & row.Cells(0).Value & "</th>")
            Escribir.WriteLine("<th>" & row.Cells(1).Value & "</th>")
            Escribir.WriteLine("<th>" & row.Cells(2).Value & "</th>")
            Escribir.WriteLine("<th>" & row.Cells(3).Value & "</th>")
            Escribir.WriteLine("<th>" & row.Cells(4).Value & "</th>")

            Escribir.WriteLine("</tr>")

        Next
        Escribir.WriteLine("</table><br>")
        Escribir.WriteLine("</center></body></html>")
        Escribir.Flush()
        Escribir.Close()

        Dim proceso As New System.Diagnostics.Process
        With proceso
            .StartInfo.FileName = Path
            .Start()
        End With


    End Sub

    Public Sub MetodoHTML_Errores()


        Dim ii As Integer = 0
        Dim DireccionDocumento As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        My.Computer.FileSystem.CreateDirectory(DireccionDocumento & "\Reportes")
        Dim Path As String = DireccionDocumento & "\Reportes\Reporte_Errores.html"
        Dim Archivo As FileInfo = New FileInfo(Path)
        Dim Escribir As StreamWriter
        Escribir = File.CreateText(Path)

        Escribir.WriteLine("<html>")
        Escribir.WriteLine("<head><title>Reporte De Tokens</title></head>")
        Escribir.WriteLine("<body bgcolor=white text=Black background=FondoEj3.gif >")

        'para tabla errores
        Escribir.WriteLine("<h1><center>Reporte Errores</center></h1>")
        Escribir.WriteLine("<br>")
        Escribir.WriteLine("<center>")
        Escribir.WriteLine("<table border= 1 width= 500 bgcolor= SILVER>")
        Escribir.WriteLine("<tr>")
        Escribir.WriteLine("<th>No.</th>")
        Escribir.WriteLine("<th>Error</th>")
        Escribir.WriteLine("<th>Columna</th>")
        Escribir.WriteLine("<th>Fila</th>")

        Escribir.WriteLine("</tr>")

        For Each row As DataGridViewRow In dgverror.Rows

            Escribir.WriteLine("<tr>")
            Escribir.WriteLine("<th>" & row.Cells(0).Value & "</th>")
            Escribir.WriteLine("<th>" & row.Cells(1).Value & "</th>")
            Escribir.WriteLine("<th>" & row.Cells(2).Value & "</th>")
            Escribir.WriteLine("<th>" & row.Cells(3).Value & "</th>")


            Escribir.WriteLine("</tr>")

        Next
        Escribir.WriteLine("</table><br>")

        Escribir.WriteLine("<p></p>")

        'para la tabla otros errores
        Escribir.WriteLine("<h1><center>Reporte Otros Errores</center></h1>")
        Escribir.WriteLine("<br>")
        Escribir.WriteLine("<center>")
        Escribir.WriteLine("<table border= 1 width= 500 bgcolor= SILVER>")
        Escribir.WriteLine("<tr>")
        Escribir.WriteLine("<th>No.</th>")
        Escribir.WriteLine("<th>Error</th>")
        Escribir.WriteLine("<th>Columna</th>")
        Escribir.WriteLine("<th>Fila</th>")

        Escribir.WriteLine("</tr>")

        For Each row As DataGridViewRow In dgverror2.Rows

            Escribir.WriteLine("<tr>")
            Escribir.WriteLine("<th>" & row.Cells(0).Value & "</th>")
            Escribir.WriteLine("<th>" & row.Cells(1).Value & "</th>")
            Escribir.WriteLine("<th>" & row.Cells(2).Value & "</th>")

            Escribir.WriteLine("</tr>")

        Next
        Escribir.WriteLine("</table><br>")

        Escribir.WriteLine("</center></body></html>")
        Escribir.Flush()
        Escribir.Close()

        Dim proceso As New System.Diagnostics.Process
        With proceso
            .StartInfo.FileName = Path
            .Start()
        End With


    End Sub

    Private Sub bttanalizar_Click(sender As Object, e As EventArgs) Handles bttanalizar.Click
        iniciarAnalisis()
    End Sub

    Public Sub iniciarAnalisis()

        'limpiar tablas para que me genere nuevo grafo
        tablagrafo.Rows.Clear()
        tablagrafo2.Rows.Clear()
        dgvbuena.Rows.Clear()
        dgverror.Rows.Clear()
        dgverror2.Rows.Clear()

        'para que el contador se reinicie
        contador_token = 0
        contador_error_1 = 0
        contadorLlaves = 0
        contadorLlaves2 = 0

        metodo_analizar()
        llenarCola()
        MetodoHTML_bueno()
        MetodoHTML_Errores()
        contarLlaves()

        If dgverror.Rows.Count >= 2 Or dgverror2.Rows.Count >= 2 Then
            MessageBox.Show("No se puede generar GRAFO, Por errorres Lexicos.")
        Else
            graficar()
            abrirGrafo()
        End If


    End Sub

    Public Sub graficar()
        Dim sw As New System.IO.StreamWriter("grafo.txt")
        sw.WriteLine(generarGrafo())
        sw.Close()
        Dim prog As VariantType
        prog = Shell("C:\Program Files (x86)\Graphviz2.38\bin\dot.exe -Tjpg grafo.txt -o grafo.jpg", 1)

    End Sub


    Public Sub llenarCola()

        Dim contador As Integer = 2 'contador para ver en que fila me encuentro
        Dim bloqueclase As Boolean = False 'para saber donde abre y cierra bloque clase
        Dim bloqueatributos As Boolean = False 'para saber donde abre y cierra bloque atributos
        Dim bloquemetodos As Boolean = False 'para saber donde abre y cierra bloque metodos
        Dim bloqueasociacion As Boolean = False
        Dim colaClase As New Queue(Of String)
        Dim colaAtributos As New Queue(Of String)
        Dim colaMetodos As New Queue(Of String)
        Dim contadorCola As Integer = 0

        For Each row As DataGridViewRow In dgvbuena.Rows 'para recorrer todas las filas de mi tabla
            contador += 1 'contador aumenta en 1

            If contador >= 4 And contador <= dgvbuena.Rows.Count Then '>=4 porque al contador se le tiene que restar y no tiene que ser menor a 0
                ' si columna 2 es igual a palabra reservada y columna 1 es igual a Clase y el anterior es igual [ y el siguiente es igual a ] y bloque clase = false
                If row.Cells(2).Value = "Palabra Reservada" And row.Cells(1).Value = "Clase" And dgvbuena.Rows(contador - 4).Cells(1).Value = "[" And dgvbuena.Rows(contador - 2).Cells(1).Value = "]" And bloqueclase = False Then
                    Console.WriteLine("RESERVADO clase: -----> " & dgvbuena.Rows(contador - 3).Cells(1).Value) 'me imprime el valor de la columna 1
                    If dgvbuena.Rows(contador - 1).Cells(1).Value = "{" Then 'if para verificar si se abre el bloque clase
                        bloqueclase = False
                        Console.WriteLine("-----------se abrio bloque clase------------")

                    End If

                End If

                'if para que me de el nombre de mi clase
                'if columna 2 es igual a identificador y anterior es igual a = y siguiente es igual a ;
                If row.Cells(2).Value = "Identificador" And dgvbuena.Rows(contador - 4).Cells(1).Value = "=" And dgvbuena.Rows(contador - 2).Cells(1).Value = ";" Then
                    Console.WriteLine("Nombre de mi clase: " & dgvbuena.Rows(contador - 3).Cells(1).Value) ' entonces me imprime el nombre de mi clase
                    colaClase.Enqueue("node [shape = record];" & dgvbuena.Rows(contador - 3).Cells(1).Value & " [label = " & Chr(34) & dgvbuena.Rows(contador - 3).Cells(1).Value & "|")
                    If dgvbuena.Rows(contador - 1).Cells(1).Value = "}" Then

                        'if por si las clases no tienen atributos o metodos
                        If colaMetodos.Count = 0 And colaAtributos.Count = 0 Then
                            colaAtributos.Enqueue("-----")
                            colaMetodos.Enqueue("-----")
                            llenarCola2(colaClase, colaAtributos, colaMetodos)
                            colaClase.Clear()
                            colaAtributos.Clear()
                            colaMetodos.Clear()

                        ElseIf colaMetodos.Count = 0 Then
                            colaMetodos.Enqueue("-----")
                            llenarCola2(colaClase, colaAtributos, colaMetodos)
                            colaClase.Clear()
                            colaAtributos.Clear()
                            colaMetodos.Clear()
                        ElseIf colaAtributos.Count = 0 Then
                            colaAtributos.Enqueue("---")
                            llenarCola2(colaClase, colaAtributos, colaMetodos)
                            colaClase.Clear()
                            colaAtributos.Clear()
                            colaMetodos.Clear()
                        Else
                            llenarCola2(colaClase, colaAtributos, colaMetodos)
                            colaClase.Clear()
                            colaAtributos.Clear()
                            colaMetodos.Clear()
                        End If

                        Console.WriteLine("-----------se cerro bloque Clase-------------")
                    End If
                End If

                'if para que busque la palabra reservada atributos
                If row.Cells(2).Value = "Palabra Reservada" And row.Cells(1).Value = "Atributos" And dgvbuena.Rows(contador - 4).Cells(1).Value = "[" And dgvbuena.Rows(contador - 2).Cells(1).Value = "]" Then
                    Console.WriteLine("RESERVADO atributos: -----> " & dgvbuena.Rows(contador - 3).Cells(1).Value)
                    If dgvbuena.Rows(contador - 1).Cells(1).Value = "{" Then 'if para verificar si abre el bloque atributos
                        bloqueatributos = True
                        Console.WriteLine("-----------se abrio bloque atributos------------")
                    End If

                End If

                'if para ver si mi atributo tiene nombre de alguna palabra reservada
                If row.Cells(2).Value = "Palabra Reservada" And (dgvbuena.Rows(contador - 3).Cells(1).Value = "Clase" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Nombre" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Atributos" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Metodos" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Asociacion" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Agregacion" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Composicion" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Herencia" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "AsociacionSimple") And (dgvbuena.Rows(contador - 4).Cells(1).Value = "(+)" Or dgvbuena.Rows(contador - 4).Cells(1).Value = "(-)" Or dgvbuena.Rows(contador - 4).Cells(1).Value = "(#)") And (dgvbuena.Rows(contador - 2).Cells(1).Value = ":" Or dgvbuena.Rows(contador - 2).Cells(1).Value = ";") And bloqueatributos = True Then
                    contador_error_1 = contador_error_1 + 1
                    dgverror2.Rows.Add(dgvbuena.Rows(contador - 3).Cells(1).Value, "Esta tratando de utilizar una palabra reservada como nombre de atributo.", "Palabra Reservada")
                End If

                'if para que me vaya imprimiendo los nombres de mis atributos
                If row.Cells(2).Value = "Identificador" And (dgvbuena.Rows(contador - 4).Cells(1).Value = "(+)" Or dgvbuena.Rows(contador - 4).Cells(1).Value = "(-)" Or dgvbuena.Rows(contador - 4).Cells(1).Value = "(#)") And (dgvbuena.Rows(contador - 2).Cells(1).Value = ":" Or dgvbuena.Rows(contador - 2).Cells(1).Value = ";") And bloqueatributos = True Then

                    If dgvbuena.Rows(contador - 2).Cells(1).Value = ":" Then 'if para ver si tiene tipo de dato
                        Console.WriteLine("Nombre de mi atributo: " & dgvbuena.Rows(contador - 3).Cells(1).Value & " Tipo: " & dgvbuena.Rows(contador - 1).Cells(1).Value)
                        colaAtributos.Enqueue("\n" & dgvbuena.Rows(contador - 3).Cells(1).Value & ":" & dgvbuena.Rows(contador - 1).Cells(1).Value & ";")
                    ElseIf dgvbuena.Rows(contador - 2).Cells(1).Value <> ":" Then 'if para vpara cuando no tiene tipo de dato
                        Console.WriteLine("Nombre de mi atributo: " & dgvbuena.Rows(contador - 3).Cells(1).Value)
                        colaAtributos.Enqueue("\n" & dgvbuena.Rows(contador - 3).Cells(1).Value & ":")
                    End If

                    If dgvbuena.Rows(contador + 1).Cells(1).Value = "}" Or dgvbuena.Rows(contador - 1).Cells(1).Value = "}" Then 'si hay } entonces cierra bloque atributos, el or es cuando no tiene tipo de dato
                        bloqueatributos = False
                        Console.WriteLine("-----------se cerro bloque atributos-------------")
                        If dgvbuena.Rows(contador + 2).Cells(1).Value = "}" Then ' si hay otra } entonces cierra bloque clase
                            bloqueatributos = False

                            'if por si las clases no tienen atributos o metodos
                            If colaAtributos.Count = 0 Then
                                colaAtributos.Enqueue("---")
                                llenarCola2(colaClase, colaAtributos, colaMetodos)
                                colaClase.Clear()
                                colaAtributos.Clear()
                                colaMetodos.Clear()
                            ElseIf colaMetodos.Count = 0 Then
                                colaMetodos.Enqueue("-----")
                                llenarCola2(colaClase, colaAtributos, colaMetodos)
                                colaClase.Clear()
                                colaAtributos.Clear()
                                colaMetodos.Clear()
                            Else
                                llenarCola2(colaClase, colaAtributos, colaMetodos)
                                colaClase.Clear()
                                colaAtributos.Clear()
                                colaMetodos.Clear()
                            End If

                            Console.WriteLine("-----------se cerro bloque Clase-------------")

                        End If

                    Else 'si no hay otra llave entonces bloque atributos sigue abierto
                        bloqueatributos = True
                    End If

                End If
                'if para que me busque la palabra reservada metodos
                If row.Cells(2).Value = "Palabra Reservada" And row.Cells(1).Value = "Metodos" And dgvbuena.Rows(contador - 4).Cells(1).Value = "[" And dgvbuena.Rows(contador - 2).Cells(1).Value = "]" And bloqueatributos = False Then
                    Console.WriteLine("RESERVADO metodos: -----> " & dgvbuena.Rows(contador - 3).Cells(1).Value)
                    If dgvbuena.Rows(contador - 1).Cells(1).Value = "{" Then 'si hay una llave abre bloque metodos
                        bloquemetodos = True
                        Console.WriteLine("-----------se abrio bloque Metodos------------")
                    End If
                End If

                'if para ver si mi metodo tiene nombre de alguna palabra reservada
                If row.Cells(2).Value = "Palabra Reservada" And (dgvbuena.Rows(contador - 4).Cells(1).Value = "(+)" Or dgvbuena.Rows(contador - 4).Cells(1).Value = "(-)" Or dgvbuena.Rows(contador - 4).Cells(1).Value = "(#)") And (dgvbuena.Rows(contador - 2).Cells(1).Value = ":" Or dgvbuena.Rows(contador - 2).Cells(1).Value = ";") And bloquemetodos = True And (dgvbuena.Rows(contador - 3).Cells(1).Value = "Clase" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Nombre" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Atributos" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Metodos" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Asociacion" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Agregacion" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Composicion" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "Herencia" Or dgvbuena.Rows(contador - 3).Cells(1).Value = "AsociacionSimple") Then
                    contador_error_1 = contador_error_1 + 1
                    dgverror2.Rows.Add(dgvbuena.Rows(contador - 3).Cells(1).Value, "Esta tratando de utilizar una palabra reservada como nombre de Metodo.", "Palabra Reservada")

                End If

                'para que me vaya imprimiendo nombre de mis metodos
                If row.Cells(2).Value = "Identificador" And (dgvbuena.Rows(contador - 4).Cells(1).Value = "(+)" Or dgvbuena.Rows(contador - 4).Cells(1).Value = "(-)" Or dgvbuena.Rows(contador - 4).Cells(1).Value = "(#)") And (dgvbuena.Rows(contador - 2).Cells(1).Value = ":" Or dgvbuena.Rows(contador - 2).Cells(1).Value = ";") And bloquemetodos = True Then

                    If dgvbuena.Rows(contador - 2).Cells(1).Value = ":" Then 'if para ver si tiene tipo de dato
                        Console.WriteLine("Nombre de mi Metodo: " & dgvbuena.Rows(contador - 3).Cells(1).Value & " Tipo: " & dgvbuena.Rows(contador - 1).Cells(1).Value)
                        colaMetodos.Enqueue("\n" & dgvbuena.Rows(contador - 3).Cells(1).Value & ":" & dgvbuena.Rows(contador - 1).Cells(1).Value & ";")
                    ElseIf dgvbuena.Rows(contador - 2).Cells(1).Value <> ":" Then 'if para vpara cuando no tiene tipo de dato
                        Console.WriteLine("Nombre de mi Metodo: " & dgvbuena.Rows(contador - 3).Cells(1).Value)
                        colaMetodos.Enqueue("\n" & dgvbuena.Rows(contador - 3).Cells(1).Value & ";")
                    End If

                    If dgvbuena.Rows(contador + 1).Cells(1).Value = "}" Or dgvbuena.Rows(contador - 1).Cells(1).Value = "}" Then ' si hay llave cierra bloque metodos, or cuando no tiene tipo de dato
                        bloquemetodos = False
                        Console.WriteLine("----------------se cerro bloque Metodos----------------")
                        If dgvbuena.Rows(contador + 2).Cells(1).Value = "}" Then ' si hay otra llave cierra bloque clase
                            bloqueatributos = False
                            'if por si las clases no tienen atributos o metodos
                            If colaAtributos.Count = 0 Then
                                colaAtributos.Enqueue("---")
                                llenarCola2(colaClase, colaAtributos, colaMetodos)
                                colaClase.Clear()
                                colaAtributos.Clear()
                                colaMetodos.Clear()
                            ElseIf colaMetodos.Count = 0 Then
                                colaMetodos.Enqueue("-----")
                                llenarCola2(colaClase, colaAtributos, colaMetodos)
                                colaClase.Clear()
                                colaAtributos.Clear()
                                colaMetodos.Clear()
                            Else
                                llenarCola2(colaClase, colaAtributos, colaMetodos)
                                colaClase.Clear()
                                colaAtributos.Clear()
                                colaMetodos.Clear()
                            End If


                            Console.WriteLine("-----------se cerro bloque Clase-------------")

                        End If
                    Else
                        bloquemetodos = True ' si no hay otra llave entonces bloque metodos sigue abierta
                    End If
                End If

                'if para que me me imprima la palabra reservada Asociacion
                If row.Cells(2).Value = "Palabra Reservada" And row.Cells(1).Value = "Asociacion" And dgvbuena.Rows(contador - 4).Cells(1).Value = "[" And dgvbuena.Rows(contador - 2).Cells(1).Value = "]" And bloqueclase = False Then
                    Console.WriteLine("RESERVADO Asociacion: -----> " & dgvbuena.Rows(contador - 3).Cells(1).Value) 'me imprime el valor de la columna 1
                    If dgvbuena.Rows(contador - 1).Cells(1).Value = "{" Then 'if para verificar si se abre el bloque asociacion
                        bloqueasociacion = True
                        Console.WriteLine("-----------se abrio bloque Asociacion------------")

                        If dgvbuena.Rows(contador).Cells(1).Value = "}" Then 'if para verificar si se cierra el bloque asociacion
                            bloqueasociacion = False
                            Console.WriteLine("-----------se cerro bloque Asociacion------------")

                        End If


                    End If

                End If

                'ifs para que me identificando las relaciones de clases
                'if para agregacion
                If contador >= 6 Then
                    If dgvbuena.Rows(contador - 1).Cells(1).Value = ";" And (bloqueasociacion = True) Then
                        If (dgvbuena.Rows(contador - 2).Cells(2).Value = "Identificador") And dgvbuena.Rows(contador - 3).Cells(1).Value = ":" And (dgvbuena.Rows(contador - 4).Cells(2).Value = "Palabra Reservada" And (dgvbuena.Rows(contador - 4).Cells(1).Value = "Agregacion")) And (dgvbuena.Rows(contador - 5).Cells(1).Value = ":") And (dgvbuena.Rows(contador - 6).Cells(2).Value = "Identificador") Then
                            Console.WriteLine(dgvbuena.Rows(contador - 6).Cells(1).Value & dgvbuena.Rows(contador - 5).Cells(1).Value & dgvbuena.Rows(contador - 4).Cells(1).Value & dgvbuena.Rows(contador - 3).Cells(1).Value & dgvbuena.Rows(contador - 2).Cells(1).Value & dgvbuena.Rows(contador - 1).Cells(1).Value)
                            tablagrafo2.Rows.Add(Chr(34) & dgvbuena.Rows(contador - 6).Cells(1).Value & Chr(34) & " -> " & Chr(34) & dgvbuena.Rows(contador - 2).Cells(1).Value & Chr(34) & " [arrowhead=" & Chr(34) & "odiamond" & Chr(34) & "]")
                            If dgvbuena.Rows(contador).Cells(1).Value = "}" Then
                                bloqueasociacion = False
                                Console.WriteLine("-----------se cerro bloque Asociacion------------")
                            End If
                        End If
                    End If
                End If

                'if para composicion
                If contador >= 6 Then
                    If dgvbuena.Rows(contador - 1).Cells(1).Value = ";" And (bloqueasociacion = True) Then
                        If (dgvbuena.Rows(contador - 2).Cells(2).Value = "Identificador") And dgvbuena.Rows(contador - 3).Cells(1).Value = ":" And (dgvbuena.Rows(contador - 4).Cells(2).Value = "Palabra Reservada" And (dgvbuena.Rows(contador - 4).Cells(1).Value = "Composicion")) And (dgvbuena.Rows(contador - 5).Cells(1).Value = ":") And (dgvbuena.Rows(contador - 6).Cells(2).Value = "Identificador") Then
                            Console.WriteLine(dgvbuena.Rows(contador - 6).Cells(1).Value & dgvbuena.Rows(contador - 5).Cells(1).Value & dgvbuena.Rows(contador - 4).Cells(1).Value & dgvbuena.Rows(contador - 3).Cells(1).Value & dgvbuena.Rows(contador - 2).Cells(1).Value & dgvbuena.Rows(contador - 1).Cells(1).Value)
                            tablagrafo2.Rows.Add(Chr(34) & dgvbuena.Rows(contador - 6).Cells(1).Value & Chr(34) & " -> " & Chr(34) & dgvbuena.Rows(contador - 2).Cells(1).Value & Chr(34) & " [arrowhead=" & Chr(34) & "diamond" & Chr(34) & "]")
                            If dgvbuena.Rows(contador).Cells(1).Value = "}" Then
                                bloqueasociacion = False
                                Console.WriteLine("-----------se cerro bloque Asociacion------------")
                            End If
                        End If
                    End If
                End If

                'if para herencia
                If contador >= 6 Then
                    If dgvbuena.Rows(contador - 1).Cells(1).Value = ";" And (bloqueasociacion = True) Then
                        If (dgvbuena.Rows(contador - 2).Cells(2).Value = "Identificador") And dgvbuena.Rows(contador - 3).Cells(1).Value = ":" And (dgvbuena.Rows(contador - 4).Cells(2).Value = "Palabra Reservada" And (dgvbuena.Rows(contador - 4).Cells(1).Value = "Herencia")) And (dgvbuena.Rows(contador - 5).Cells(1).Value = ":") And (dgvbuena.Rows(contador - 6).Cells(2).Value = "Identificador") Then
                            Console.WriteLine(dgvbuena.Rows(contador - 6).Cells(1).Value & dgvbuena.Rows(contador - 5).Cells(1).Value & dgvbuena.Rows(contador - 4).Cells(1).Value & dgvbuena.Rows(contador - 3).Cells(1).Value & dgvbuena.Rows(contador - 2).Cells(1).Value & dgvbuena.Rows(contador - 1).Cells(1).Value)
                            tablagrafo2.Rows.Add(Chr(34) & dgvbuena.Rows(contador - 6).Cells(1).Value & Chr(34) & " -> " & Chr(34) & dgvbuena.Rows(contador - 2).Cells(1).Value & Chr(34) & " [arrowhead=" & Chr(34) & "onormal" & Chr(34) & "]")
                            If dgvbuena.Rows(contador).Cells(1).Value = "}" Then
                                bloqueasociacion = False
                                Console.WriteLine("-----------se cerro bloque Asociacion------------")
                            End If
                        End If
                    End If
                End If

                'if para asociacionSimple
                If contador >= 6 Then
                    If dgvbuena.Rows(contador - 1).Cells(1).Value = ";" And (bloqueasociacion = True) Then
                        If (dgvbuena.Rows(contador - 2).Cells(2).Value = "Identificador") And dgvbuena.Rows(contador - 3).Cells(1).Value = ":" And (dgvbuena.Rows(contador - 4).Cells(2).Value = "Palabra Reservada" And (dgvbuena.Rows(contador - 4).Cells(1).Value = "AsociacionSimple")) And (dgvbuena.Rows(contador - 5).Cells(1).Value = ":") And (dgvbuena.Rows(contador - 6).Cells(2).Value = "Identificador") Then
                            Console.WriteLine(dgvbuena.Rows(contador - 6).Cells(1).Value & dgvbuena.Rows(contador - 5).Cells(1).Value & dgvbuena.Rows(contador - 4).Cells(1).Value & dgvbuena.Rows(contador - 3).Cells(1).Value & dgvbuena.Rows(contador - 2).Cells(1).Value & dgvbuena.Rows(contador - 1).Cells(1).Value)
                            tablagrafo2.Rows.Add(Chr(34) & dgvbuena.Rows(contador - 6).Cells(1).Value & Chr(34) & " -> " & Chr(34) & dgvbuena.Rows(contador - 2).Cells(1).Value & Chr(34) & " [arrowhead=" & Chr(34) & "none" & Chr(34) & "]")
                            If dgvbuena.Rows(contador).Cells(1).Value = "}" Then
                                bloqueasociacion = False
                                Console.WriteLine("-----------se cerro bloque Asociacion------------")
                            End If
                        End If
                    End If
                End If

            End If
        Next


    End Sub

    Public Sub llenarCola2(ByVal clase As Queue(Of String), ByVal atributos As Queue(Of String), ByVal metodos As Queue(Of String))


        Dim codigoGraph As String = ""
       
        For Each colaCla As String In clase
            codigoGraph += colaCla
        Next
        For Each colaAtri As String In atributos
            codigoGraph += colaAtri
        Next
        codigoGraph += "|"
        For Each colaMet As String In metodos
            codigoGraph += colaMet
        Next
        codigoGraph += (Chr(34) & "];")

        tablagrafo.Rows.Add(codigoGraph)

    End Sub


    Private Sub bttprueba_Click(sender As Object, e As EventArgs)
        llenarCola()
    End Sub

    Private Sub bttlimpiar_Click(sender As Object, e As EventArgs) Handles bttlimpiar.Click
        areaAnalizar.Text = ""
        tablagrafo.Rows.Clear()
        tablagrafo2.Rows.Clear()
        dgvbuena.Rows.Clear()
        dgverror.Rows.Clear()
        dgverror2.Rows.Clear()

    End Sub

    Private Sub ManualDeLaAplicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeLaAplicacionToolStripMenuItem.Click
        Dim loPSI As New ProcessStartInfo
        Dim loPSI2 As New ProcessStartInfo
        Dim proceso As New Process
        Dim proceso2 As New Process
        loPSI.FileName = "manual_usuario.pdf"
        loPSI2.FileName = "manual_tecnico.pdf"
        Try
            proceso = Process.Start(loPSI)
            proceso2 = Process.Start(loPSI2)
        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim info As String = "Que es Analilisis lexico?" + vbLf + "El analizador léxico es la primera fase de un compilador." + vbLf + "Su principal función consiste en leer los caracteres de entrada y elaborar como salida una secuencia de componentes léxicos que utiliza el analizador sintáctico para hacer el análisis."
        Dim info2 As String = "Version de app: 1.0" + vbLf + "Desarrollado en Visual Basic, utilizando Visual Estudio 2013"
        MessageBox.Show("Realizado por: Christopher Alexander Acajabon Gudiel" + vbLf + vbLf + "Carnet: 201404278" + vbLf + vbLf + info2 + vbLf + vbLf + info)
    End Sub

    Private Sub DdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DdToolStripMenuItem.Click

        Dim loPSI As New ProcessStartInfo
        Dim proceso As New Process
        loPSI.FileName = "C:\Users\GUDIEL\Desktop\Reportes\Reporte_Tokens.html"

        Try
            proceso = Process.Start(loPSI)

        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErroresToolStripMenuItem.Click
        Dim loPSI As New ProcessStartInfo
        Dim proceso As New Process
        loPSI.FileName = "C:\Users\GUDIEL\Desktop\Reportes\Reporte_Errores.html"

        Try
            proceso = Process.Start(loPSI)

        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GrafoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrafoToolStripMenuItem.Click

        Dim loPSI As New ProcessStartInfo
        Dim proceso As New Process
        loPSI.FileName = "grafo.jpg"

        Try
            proceso = Process.Start(loPSI)

        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Function generarGrafo() As String
        Dim generar As String = ""

        generar += "digraph grafica{" & vbCrLf
        generar += "rankdir=LR;"
        generar += "size=" & Chr(34) & "8,5" & Chr(34)


        For Each row As DataGridViewRow In tablagrafo.Rows

            generar = generar + row.Cells(0).Value

        Next

        generar += vbCrLf

        For Each row2 As DataGridViewRow In tablagrafo2.Rows

            generar = generar + row2.Cells(0).Value

        Next

        generar += "}"
        Console.WriteLine(generar)
        Return generar
    End Function

    Public Sub abrirGrafo()
        Dim loPSI As New ProcessStartInfo
        Dim proceso As New Process
        loPSI.FileName = "grafo.jpg"

        Try
            proceso = Process.Start(loPSI)

        Catch Exp As Exception
            MessageBox.Show(Exp.Message, "XXXX", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub contarLlaves()
        

        For Each row As DataGridViewRow In dgvbuena.Rows
            If row.Cells(1).Value = "{" Then
                contadorLlaves += 1
            End If
        Next

        For Each row2 As DataGridViewRow In dgvbuena.Rows
            If row2.Cells(1).Value = "}" Then
                contadorLlaves2 += 1
            End If
        Next

        If contadorLlaves > contadorLlaves2 Then
            Console.WriteLine("Falta de }")
            dgverror2.Rows.Add("}", "Signo }", "Error, falta llave de cierre: }")
        ElseIf contadorLlaves < contadorLlaves2 Then
            Console.WriteLine("Falta de {")
            dgverror2.Rows.Add("{", "Signo {", "Error, falta llave de apertura {")
        End If


    End Sub

    Private Sub AnalizarLexicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalizarLexicoToolStripMenuItem.Click
        iniciarAnalisis()
    End Sub
End Class
