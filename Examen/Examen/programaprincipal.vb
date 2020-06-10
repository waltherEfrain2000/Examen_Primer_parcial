Imports System.ComponentModel

Public Class programaprincipal

    Dim aatlantida, ratantida, matlatida, acholuteca, rcholuteca, mcholuteca, acolon, rcolon, mcolon As Integer
    Dim municipio, departamento As String


    Dim acomyagua, rcomayagua, mcomyagua, acopan, rcopan, mcopan, aparaiso, mparaiso, rparaiso, afrancisco, rfrancisco, mfrancisco, acortes, rcortes, mcortes As Integer

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False


    End Sub

    Dim agracias, rgracias, mgracias, aintibuca, rintibuca, mintibuca, aislas, rislas, mislas, apaz, rpaz, mpaz As Integer
    Dim alempira, rlempira, mlempira, aoco, moco, roco, aolancho, rolancho, molancho, abarbara, bbarbara, mbarbara, mvalle, avalle, rvalle, ayoro, ryoro, myoro As Integer


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim seleciondedepartamento As Integer
        ComboBox3.Items.Clear()
        seleciondedepartamento = ComboBox1.SelectedIndex

        Select Case seleciondedepartamento
            Case 0
                ComboBox3.Items.Add("La Ceiba")
                ComboBox3.Items.Add("Tela")
                ComboBox3.Items.Add("Jutiapa")
                ComboBox3.Items.Add("La masica")
                ComboBox3.Items.Add("san francisco")
                ComboBox3.Items.Add("Arizona")
                ComboBox3.Items.Add("Esparta")
                ComboBox3.Items.Add("El porvenir")
                municipio = ComboBox3.SelectedItem

            Case 2
                ComboBox3.Items.Add("trujillo")
                ComboBox3.Items.Add("balfate")
                ComboBox3.Items.Add("iriona")
                ComboBox3.Items.Add("limon")
                ComboBox3.Items.Add("saba")
                ComboBox3.Items.Add("santa fe")
                ComboBox3.Items.Add("santa rosa de aguan")
                ComboBox3.Items.Add("sonaguera")
                ComboBox3.Items.Add("tocoa")
                ComboBox3.Items.Add("bonito oriental")
                municipio = ComboBox3.SelectedItem

            Case 3
                ComboBox3.Items.Add("comyagua")
                ComboBox3.Items.Add("ajuterique")
                ComboBox3.Items.Add("el rosario")
                ComboBox3.Items.Add("Esquias")
                ComboBox3.Items.Add("Humuya")
                ComboBox3.Items.Add("la libertad")
                ComboBox3.Items.Add("la mani")
                ComboBox3.Items.Add("la trinidad")
                ComboBox3.Items.Add("Lejamani")
                ComboBox3.Items.Add("Meambar")
                ComboBox3.Items.Add("minas de oro")
                ComboBox3.Items.Add("ojos de agua")
                ComboBox3.Items.Add("san jeronimo")
                ComboBox3.Items.Add("san jose de comayagua")
                ComboBox3.Items.Add("san jose del potrero")
                ComboBox3.Items.Add("san luis")
                ComboBox3.Items.Add("san sebastian")
                ComboBox3.Items.Add("siguatepeque")
                ComboBox3.Items.Add("villas de san antonio")
                ComboBox3.Items.Add("Las lajas")
                ComboBox3.Items.Add("Taulabe")
                municipio = ComboBox3.SelectedItem
            Case 4
                ComboBox3.Items.Add("Santa Rosa de Copán")
                ComboBox3.Items.Add("Cabañas")
                ComboBox3.Items.Add("Concepción")
                ComboBox3.Items.Add("Copán Ruinas")
                ComboBox3.Items.Add("Corquín")
                ComboBox3.Items.Add("Cucuyagua")
                ComboBox3.Items.Add("Dolores")
                ComboBox3.Items.Add("Dulce Nombre")
                ComboBox3.Items.Add("El Paraíso")
                ComboBox3.Items.Add("Florida")
                ComboBox3.Items.Add("La Jigua")
                ComboBox3.Items.Add("La Unión")
                ComboBox3.Items.Add("Nueva Arcadia")
                ComboBox3.Items.Add("San Agustín")
                ComboBox3.Items.Add("San Antonio")
                ComboBox3.Items.Add("San Jerónimo")
                ComboBox3.Items.Add("San Juan de Opoa")
                ComboBox3.Items.Add("San Nicolás")
                ComboBox3.Items.Add("San Pedro")
                ComboBox3.Items.Add("Santa Rita")
                ComboBox3.Items.Add("Trinidad de Copán")
                ComboBox3.Items.Add("TVeracruz")

                municipio = ComboBox3.SelectedItem
            Case 5
                ComboBox3.Items.Add("San Pedro Sula")
                ComboBox3.Items.Add("Choloma")
                ComboBox3.Items.Add("Omoa")
                ComboBox3.Items.Add("Pimienta")
                ComboBox3.Items.Add("Potrerillos")
                ComboBox3.Items.Add("Puerto Cortés")
                ComboBox3.Items.Add("San Antonio de Cortés")
                ComboBox3.Items.Add("San Francisco de Yojoa")
                ComboBox3.Items.Add("San Manuel")
                ComboBox3.Items.Add("Santa Cruz de Yojoa")
                ComboBox3.Items.Add("Villanueva")
                ComboBox3.Items.Add("La Lima")

                municipio = ComboBox3.SelectedItem

            Case 1
                ComboBox3.Items.Add("Choluteca")
                ComboBox3.Items.Add("Apacilagua")
                ComboBox3.Items.Add("Concepción de María")
                ComboBox3.Items.Add("Duyure")
                ComboBox3.Items.Add("El Corpus")
                ComboBox3.Items.Add("El Triunfo")
                ComboBox3.Items.Add("Marcovia")
                ComboBox3.Items.Add("Morolica")
                ComboBox3.Items.Add("Namasigue")
                ComboBox3.Items.Add("Orocuina")
                ComboBox3.Items.Add("Pespire")
                ComboBox3.Items.Add("San Antonio de Flores")
                ComboBox3.Items.Add("San Isidro")
                ComboBox3.Items.Add("San José")
                ComboBox3.Items.Add("San Marcos de Colón")
                ComboBox3.Items.Add("Santa Ana de Yusguare")

                municipio = ComboBox3.SelectedItem

            Case 6

                ComboBox3.Items.Add("Yuscarán")
                ComboBox3.Items.Add("Alauca")
                ComboBox3.Items.Add("Danlí")
                ComboBox3.Items.Add("El Paraíso")
                ComboBox3.Items.Add("Güinope")
                ComboBox3.Items.Add("Jacaleapa")
                ComboBox3.Items.Add("Liure")
                ComboBox3.Items.Add("Morocelí")
                ComboBox3.Items.Add("Oropolí")
                ComboBox3.Items.Add("Potrerillos")
                ComboBox3.Items.Add("San Antonio de Flores")
                ComboBox3.Items.Add("San Lucas")
                ComboBox3.Items.Add("San Matías")
                ComboBox3.Items.Add("Soledad")
                ComboBox3.Items.Add("Teupasenti")
                ComboBox3.Items.Add("Texiguat")
                ComboBox3.Items.Add("Vado Ancho")
                ComboBox3.Items.Add("Yauyupe")
                ComboBox3.Items.Add("Trojes")

                municipio = ComboBox3.SelectedItem
            Case 7
                ComboBox3.Items.Add("Tegucigalpa")
                ComboBox3.Items.Add("Alubarén")
                ComboBox3.Items.Add("Cedros")
                ComboBox3.Items.Add("Curarén")
                ComboBox3.Items.Add("El Porvenir")
                ComboBox3.Items.Add("Guaimaca")
                ComboBox3.Items.Add("La Libertad")
                ComboBox3.Items.Add("La Venta")
                ComboBox3.Items.Add("Lepaterique")
                ComboBox3.Items.Add("Maraita")
                ComboBox3.Items.Add("Marale")
                ComboBox3.Items.Add("Nueva Armenia")
                ComboBox3.Items.Add("Ojojona")
                ComboBox3.Items.Add("Orica")
                ComboBox3.Items.Add("Reitoca")
                ComboBox3.Items.Add("Sabanagrande")
                ComboBox3.Items.Add("San Antonio de Oriente")
                ComboBox3.Items.Add("San Buenaventura")
                ComboBox3.Items.Add("Trojes")

                municipio = ComboBox3.SelectedItem

            Case 8
                ComboBox3.Items.Add("Puerto Lempira")
                ComboBox3.Items.Add("Brus Laguna")
                ComboBox3.Items.Add("Ahuas")
                ComboBox3.Items.Add("Juan Francisco Bulnes")
                ComboBox3.Items.Add("Ramón Villeda Morales")
                ComboBox3.Items.Add("Wampusirpe")

                municipio = ComboBox3.SelectedItem

            Case 9
                ComboBox3.Items.Add("La Esperanza")
                ComboBox3.Items.Add("Camasca")
                ComboBox3.Items.Add("Colomoncagua")
                ComboBox3.Items.Add("Concepción")
                ComboBox3.Items.Add("Dolores")
                ComboBox3.Items.Add("Intibucá")
                ComboBox3.Items.Add("Jesús de Otoro")
                ComboBox3.Items.Add("Magdalena")
                ComboBox3.Items.Add("Masaguara")
                ComboBox3.Items.Add("San Antonio")
                ComboBox3.Items.Add("San Isidro")
                ComboBox3.Items.Add("San Juan")
                ComboBox3.Items.Add("San Marcos de la Sierra")
                ComboBox3.Items.Add("San Miguel Guancapla")
                ComboBox3.Items.Add("Santa Lucía")
                ComboBox3.Items.Add("Yamaranguila")
                ComboBox3.Items.Add("San Francisco de Opalaca")
                municipio = ComboBox3.SelectedItem


            Case 10
                ComboBox3.Items.Add("Roatán")
                ComboBox3.Items.Add("Guanaja")
                ComboBox3.Items.Add("José Santos Guardiola")
                ComboBox3.Items.Add("Utila")
                municipio = ComboBox3.SelectedItem

            Case 11
                ComboBox3.Items.Add("La Paz")
                ComboBox3.Items.Add("Aguanqueterique")
                ComboBox3.Items.Add("Cabañas")
                ComboBox3.Items.Add("Cane")
                ComboBox3.Items.Add("Chinacla")
                ComboBox3.Items.Add("Guajiquiro")
                ComboBox3.Items.Add("Lauterique")
                ComboBox3.Items.Add("Marcala")
                ComboBox3.Items.Add("Mercedes de Oriente")
                ComboBox3.Items.Add("Opatoro")
                ComboBox3.Items.Add("San Antonio del Norte")
                ComboBox3.Items.Add("San Juan")
                ComboBox3.Items.Add("San José")
                ComboBox3.Items.Add("San Juan")
                ComboBox3.Items.Add("San Pedro de Tutule")
                ComboBox3.Items.Add("Santa Ana")
                ComboBox3.Items.Add("Santa Elena")
                municipio = ComboBox3.SelectedItem


            Case 12
                ComboBox3.Items.Add("Gracias")
                ComboBox3.Items.Add("Belén")
                ComboBox3.Items.Add("Candelaria")
                ComboBox3.Items.Add("Cololaca")
                ComboBox3.Items.Add("Erandique")
                ComboBox3.Items.Add("Guarita")
                ComboBox3.Items.Add("Gualcince")
                ComboBox3.Items.Add("La Campaa")
                ComboBox3.Items.Add("La Iguala")
                ComboBox3.Items.Add("Las Flores")
                ComboBox3.Items.Add("La Unión")
                ComboBox3.Items.Add("La Virtud")
                ComboBox3.Items.Add("San José")
                ComboBox3.Items.Add("San Juan")
                ComboBox3.Items.Add("San Pedro de Tutule")
                ComboBox3.Items.Add("Santa Ana")
                ComboBox3.Items.Add("Santa Elena")
                municipio = ComboBox3.SelectedItem

            Case 13
                ComboBox3.Items.Add("Ocotepeque")
                ComboBox3.Items.Add("Belén Gualcho")
                ComboBox3.Items.Add("Concepción")
                ComboBox3.Items.Add("Dolores Merendón")
                ComboBox3.Items.Add("Fraternidad")
                ComboBox3.Items.Add("La Encarnación")
                ComboBox3.Items.Add("La Labor")
                ComboBox3.Items.Add("Lucerna")
                ComboBox3.Items.Add("Mercedes")
                ComboBox3.Items.Add("San Fernando")
                ComboBox3.Items.Add("San Francisco del Valle")
                ComboBox3.Items.Add("San Jorge")
                ComboBox3.Items.Add("San Marcos")
                ComboBox3.Items.Add("Santa Fe")
                ComboBox3.Items.Add("San Pedro de Tutule")
                ComboBox3.Items.Add("Sensenti")
                ComboBox3.Items.Add("Sinuapa")
                municipio = ComboBox3.SelectedItem

            Case 14
                ComboBox3.Items.Add("Juticalpa")
                ComboBox3.Items.Add("Campamento")
                ComboBox3.Items.Add("Catacamas")
                ComboBox3.Items.Add("Concordia")
                ComboBox3.Items.Add("Dulce Nombre de Culmí")
                ComboBox3.Items.Add("El Rosario")
                ComboBox3.Items.Add("Esquipulas del Norte")
                ComboBox3.Items.Add("Gualaco")
                ComboBox3.Items.Add("Guarizama")
                ComboBox3.Items.Add("Guata")
                ComboBox3.Items.Add("Guayape")
                ComboBox3.Items.Add("Jano")
                ComboBox3.Items.Add("San Marcos")
                ComboBox3.Items.Add("Santa Fe")
                ComboBox3.Items.Add("San Pedro de Tutule")
                ComboBox3.Items.Add("Sensenti")
                ComboBox3.Items.Add("Sinuapa")
                municipio = ComboBox3.SelectedItem

            Case 15

                ComboBox3.Items.Add("Santa Bárbara")
                ComboBox3.Items.Add("Arada")
                ComboBox3.Items.Add("Atima")
                ComboBox3.Items.Add("Azacualpa")
                ComboBox3.Items.Add("Ceguaca")
                ComboBox3.Items.Add("Concepción del Norte")
                ComboBox3.Items.Add("Concepción del Su")
                ComboBox3.Items.Add("Chinda")
                ComboBox3.Items.Add("El Níspero")
                ComboBox3.Items.Add("Gualala")
                ComboBox3.Items.Add("Las Vegas")
                ComboBox3.Items.Add("Macuelizo")
                ComboBox3.Items.Add("Naranjito")
                ComboBox3.Items.Add("Nuevo Celilac")
                ComboBox3.Items.Add("San Pedro de Tutule")
                ComboBox3.Items.Add("Sensenti")
                ComboBox3.Items.Add("Sinuapa")
                municipio = ComboBox3.SelectedItem



            Case 16

                ComboBox3.Items.Add("Nacaome")
                ComboBox3.Items.Add("Alianza")
                ComboBox3.Items.Add("Amapala")
                ComboBox3.Items.Add("Aramecina")
                ComboBox3.Items.Add("Caridad")
                ComboBox3.Items.Add("Goascorán")
                ComboBox3.Items.Add("Langue")
                ComboBox3.Items.Add("San Francisco de Coray")
                ComboBox3.Items.Add("San Lorenzo")
                municipio = ComboBox3.SelectedItem


            Case 17
                ComboBox3.Items.Add("Yoro")
                ComboBox3.Items.Add("Arenal")
                ComboBox3.Items.Add("El Negrito")
                ComboBox3.Items.Add("El Progreso")
                ComboBox3.Items.Add("Jocón")
                ComboBox3.Items.Add("Morazán")
                ComboBox3.Items.Add("Olanchito")
                ComboBox3.Items.Add("Santa Rita")
                ComboBox3.Items.Add("Sulaco")
                municipio = ComboBox3.SelectedItem



        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox5.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim activos, recuperados, muertos, iddepartamento, sumaa, sumar, sumam As Integer
        Dim nombre, des As String
        Dim edad As Integer


        nombre = TextBox1.Text
        edad = Val(TextBox2.Text)
        des = TextBox3.Text
        iddepartamento = ComboBox1.SelectedIndex
        departamento = ComboBox1.SelectedItem
        municipio = ComboBox3.SelectedItem
        Select Case iddepartamento
            Case 0

                If CheckBox1.Checked = True Then
                    MsgBox("el departamento es atlantida")
                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then
                    MsgBox("el departamento es atlantida")
                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    aatlantida = aatlantida + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    ratantida = ratantida + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    matlatida = matlatida + 1
                End If

            Case 1
                If CheckBox1.Checked = True Then
                    MsgBox("el departamento es choluteca")
                    reporte.Items.Add("nombre:" & nombre & "  " & "edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then
                    MsgBox("el departamento es choluteca")
                    reporte.Items.Add("nombre: " & nombre & "   " & "edad :" & edad & "    " & "ESTADO:" & "    " & "negativo" & "  " & departamento & "   " & municipio & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    acholuteca = acholuteca + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rcholuteca = rcholuteca + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mcholuteca = mcholuteca + 1
                End If


            Case 2
                If CheckBox1.Checked = True Then
                    MsgBox("el departamento es colon")
                    reporte.Items.Add("nombre:" & nombre & "  " & "edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_" & des)

                ElseIf CheckBox2.Checked = True Then
                    MsgBox("el departamento es colon")
                    reporte.Items.Add("nombre: " & nombre & "  " & "edad :" & edad & "    " & "ESTADO:" & "negativo" & departamento & "   " & municipio & "    " & "Descripcion: " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    acolon = acolon + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rcolon = rcolon + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mcolon = mcolon + 1
                End If

            Case 3
                If CheckBox1.Checked = True Then
                    MsgBox("el departamento es  comayagua")
                    reporte.Items.Add("nombre:" & nombre & "  " & "edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then
                    MsgBox("el departamento es comayagua")
                    reporte.Items.Add("nombre:" & nombre & "  " & "edad :_" & edad & "    " & "ESTADO:" & "NEGATIVO" & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    acomyagua = acomyagua + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rcomayagua = rcomayagua + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mcomyagua = mcomyagua + 1
                End If

            Case 4
                If CheckBox1.Checked = True Then
                    MsgBox("el departamento es copan")
                    reporte.Items.Add("nombre:" & nombre & "  " & "edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & departamento & "   " & municipio & "   " & "Descripcion: " & des)

                ElseIf CheckBox2.Checked = True Then
                    MsgBox("el departamento es copan")
                    reporte.Items.Add("nombre:" & nombre & "  " & "edad :" & edad & "    " & "ESTADO:" & "negativo" & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    acopan = acopan + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rcopan = rcopan + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mcopan = mcopan + 1
                End If

            Case 5
                If CheckBox1.Checked = True Then
                    MsgBox("el departamento es cortes")
                    reporte.Items.Add("nombre:" & nombre & "   " & "edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then
                    MsgBox("el departamento es  cortes")
                    reporte.Items.Add("nombre:" & nombre & "   " & "edad :" & edad & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    acortes = acortes + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rcortes = rcortes + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mcortes = mcortes + 1
                End If

            Case 6
                If CheckBox1.Checked = True Then
                    MsgBox("el departamento es el paraiso")
                    reporte.Items.Add("nombre:" & nombre & "  " & "edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then
                    MsgBox("el departamento es el paraiso")
                    reporte.Items.Add("nombre:" & nombre & "  " & "edad :" & edad & "    " & "ESTADO:" & "negativo" & departamento & "   " & municipio & "   " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    aparaiso = aparaiso + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rparaiso = rparaiso + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mparaiso = mparaiso + 1
                End If

            Case 7

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    afrancisco = afrancisco + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rfrancisco = rfrancisco + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mfrancisco = mfrancisco + 1

                End If
            Case 8

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    agracias = agracias + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rgracias = rgracias + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mgracias = mgracias + 1

                End If
            Case 9

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    aintibuca = aintibuca + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rintibuca = rintibuca + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mintibuca = mintibuca + 1

                End If

            Case 10

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    aislas = aislas + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rislas = rislas + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mislas = mislas + 1

                End If

            Case 11

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    apaz = apaz + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rpaz = rpaz + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mpaz = mpaz + 1


                End If
            Case 12

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    alempira = alempira + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rlempira = rlempira + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    mlempira = mlempira + 1

                End If

            Case 13

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    aoco = aoco + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    roco = roco + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    moco = moco + 1

                End If
            Case 14

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    aolancho = aolancho + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rolancho = rolancho + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    molancho = molancho + 1

                End If
            Case 15

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    abarbara = abarbara + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    bbarbara = bbarbara + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mbarbara = mbarbara + 1


                End If

            Case 16

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    avalle = avalle + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rvalle = rvalle + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mvalle = mvalle + 1

                End If
            Case 17

                If CheckBox1.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "   " & "Edad :" & edad & "    " & " ESTADO:" & "ACTIVO" & "  " & departamento & "   " & municipio & "     " & "Descripcion:_ " & des)

                ElseIf CheckBox2.Checked = True Then

                    reporte.Items.Add("Nombre:" & nombre & "    " & "Edad :" & edad & "    " & "ESTADO:" & "negativo" & "  " & departamento & "   " & municipio & "    " & "Descripcion:_ " & des)

                End If


                If CheckBox3.Checked = True Then
                    activos = activos + 1
                    sumaa = sumaa + activos
                    ayoro = ayoro + 1
                End If


                If CheckBox4.Checked = True Then
                    recuperados = activos + 1
                    sumar = sumar + recuperados
                    rvalle = rvalle + 1
                End If

                If CheckBox5.Checked = True Then
                    muertos = activos + 1
                    sumam = sumam + muertos
                    mvalle = mvalle + 1
                End If
        End Select

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese un nombre")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim opcion As DialogResult

        opcion = MessageBox.Show("desea sali?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim idecheck As Integer

        idecheck = ComboBox2.SelectedIndex

        Select Case idecheck
            Case 0

                txtactivados.Text = aatlantida
                txtmuertos.Text = matlatida
                txtrecuperados.Text = ratantida

            Case 1

                txtactivados.Text = acholuteca
                txtmuertos.Text = mcholuteca
                txtrecuperados.Text = rcholuteca

            Case 2
                txtactivados.Text = acolon
                txtmuertos.Text = mcolon
                txtrecuperados.Text = rcolon

            Case 3
                txtactivados.Text = acomyagua
                txtmuertos.Text = mcomyagua
                txtrecuperados.Text = rcomayagua
            Case 4
                txtactivados.Text = acopan
                txtmuertos.Text = mcopan
                txtrecuperados.Text = rcopan
            Case 5
                txtactivados.Text = acortes
                txtmuertos.Text = mcortes
                txtrecuperados.Text = rcortes

            Case 6
                txtactivados.Text = aparaiso
                txtmuertos.Text = mparaiso
                txtrecuperados.Text = rparaiso
            Case 7
                txtactivados.Text = afrancisco
                txtmuertos.Text = mfrancisco
                txtrecuperados.Text = rfrancisco

            Case 8
                txtactivados.Text = agracias
                txtmuertos.Text = mgracias
                txtrecuperados.Text = rgracias
            Case 9
                txtactivados.Text = aintibuca
                txtmuertos.Text = mintibuca
                txtrecuperados.Text = rintibuca

            Case 10
                txtactivados.Text = aislas
                txtmuertos.Text = mislas
                txtrecuperados.Text = rislas


            Case 11
                txtactivados.Text = apaz
                txtmuertos.Text = mpaz
                txtrecuperados.Text = rpaz

            Case 12
                txtactivados.Text = alempira
                txtmuertos.Text = mlempira
                txtrecuperados.Text = rlempira

            Case 13
                txtactivados.Text = aoco
                txtmuertos.Text = moco
                txtrecuperados.Text = roco
            Case 14
                txtactivados.Text = aolancho
                txtmuertos.Text = molancho
                txtrecuperados.Text = rolancho

            Case 15
                txtactivados.Text = abarbara
                txtmuertos.Text = mbarbara
                txtrecuperados.Text = bbarbara

            Case 16
                txtactivados.Text = avalle
                txtmuertos.Text = mvalle
                txtrecuperados.Text = rvalle

            Case 17
                txtactivados.Text = ayoro
                txtmuertos.Text = myoro
                txtrecuperados.Text = ryoro






        End Select
    End Sub

    Private Sub txtrecuperados_TextChanged(sender As Object, e As EventArgs) Handles txtrecuperados.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese una edad")
        End If
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip1.SetToolTip(TextBox1, "ingresar un nombre")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        ToolTip1.SetToolTip(TextBox1, "ingresar una edad")
        ToolTip1.ToolTipTitle = "Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class