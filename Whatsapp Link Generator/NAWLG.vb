Imports System.IO

Public Class NAWLG

    ' Ruta del archivo donde se guardará el país seleccionado
    Private Const SelectedCountryFilePath As String = "selected_country.txt"

    ' Bandera para controlar si la aplicación está cargando
    Private isLoading As Boolean = True

    ' Definir una clase para almacenar los países y sus prefijos
    Public Class Country
        Public Property Name As String
        Public Property PhoneCode As String

        Public Sub New(name As String, phoneCode As String)
            Me.Name = name
            Me.PhoneCode = phoneCode
        End Sub

        ' Sobrescribir ToString para que el nombre del país se muestre en el ComboBox
        Public Overrides Function ToString() As String
            Return Me.Name
        End Function
    End Class

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear una lista de países con sus prefijos telefónicos
        Dim countries As New List(Of Country) From {
            New Country("Afghanistan", "93"),
            New Country("Albania", "355"),
            New Country("Algeria", "213"),
            New Country("American Samoa", "1"),
            New Country("Andorra", "376"),
            New Country("Angola", "244"),
            New Country("Anguilla", "1"),
            New Country("Antigua and Barbuda", "1"),
            New Country("Argentina", "54"),
            New Country("Armenia", "374"),
            New Country("Aruba", "297"),
            New Country("Australia", "61"),
            New Country("Austria", "43"),
            New Country("Azerbaijan", "994"),
            New Country("Bahamas", "1"),
            New Country("Bahrain", "973"),
            New Country("Bangladesh", "880"),
            New Country("Barbados", "1"),
            New Country("Belarus", "375"),
            New Country("Belgium", "32"),
            New Country("Belize", "501"),
            New Country("Benin", "229"),
            New Country("Bermuda", "1"),
            New Country("Bhutan", "975"),
            New Country("Bolivia (Plurinational State of)", "591"),
            New Country("Bosnia and Herzegovina", "387"),
            New Country("Botswana", "267"),
            New Country("Brazil", "55"),
            New Country("British Virgin Islands", "1"),
            New Country("Brunei Darussalam", "673"),
            New Country("Bulgaria", "359"),
            New Country("Burkina Faso", "226"),
            New Country("Burundi", "257"),
            New Country("Cambodia", "855"),
            New Country("Cameroon", "237"),
            New Country("Canada", "1"),
            New Country("Cape Verde", "238"),
            New Country("Cayman Islands", "1"),
            New Country("Central African Rep.", "236"),
            New Country("Chad", "235"),
            New Country("Chile", "56"),
            New Country("China", "86"),
            New Country("Colombia", "57"),
            New Country("Comoros", "269"),
            New Country("Congo", "242"),
            New Country("Cook Islands", "682"),
            New Country("Costa Rica", "506"),
            New Country("Côte d'Ivoire", "225"),
            New Country("Croatia", "385"),
            New Country("Cuba", "53"),
            New Country("Curaçao", "599"),
            New Country("Cyprus", "357"),
            New Country("Czech Rep.", "420"),
            New Country("Dem. People's Rep. of Korea", "850"),
            New Country("Dem. Rep. of the Congo", "243"),
            New Country("Denmark", "45"),
            New Country("Diego Garcia", "246"),
            New Country("Djibouti", "253"),
            New Country("Dominica", "1"),
            New Country("Dominican Rep.", "1"),
            New Country("Ecuador", "593"),
            New Country("Egypt", "20"),
            New Country("El Salvador", "503"),
            New Country("Equatorial Guinea", "240"),
            New Country("Eritrea", "291"),
            New Country("Estonia", "372"),
            New Country("Ethiopia", "251"),
            New Country("Falkland Islands (Malvinas)", "500"),
            New Country("Faroe Islands", "298"),
            New Country("Fiji", "679"),
            New Country("Finland", "358"),
            New Country("France", "33"),
            New Country("French Guiana", "594"),
            New Country("French Polynesia", "689"),
            New Country("Gabon", "241"),
            New Country("Gambia", "220"),
            New Country("Georgia", "995"),
            New Country("Germany", "49"),
            New Country("Ghana", "233"),
            New Country("Gibraltar", "350"),
            New Country("Greece", "30"),
            New Country("Greenland", "299"),
            New Country("Grenada", "1"),
            New Country("Guadeloupe", "590"),
            New Country("Guam", "1"),
            New Country("Guatemala", "502"),
            New Country("Guinea", "224"),
            New Country("Guinea-Bissau", "245"),
            New Country("Guyana", "592"),
            New Country("Haiti", "509"),
            New Country("Honduras", "504"),
            New Country("Hong Kong, China", "852"),
            New Country("Hungary", "36"),
            New Country("Iceland", "354"),
            New Country("India", "91"),
            New Country("Indonesia", "62"),
            New Country("Iran (Islamic Republic of)", "98"),
            New Country("Iraq", "964"),
            New Country("Ireland", "353"),
            New Country("Israel", "972"),
            New Country("Italy", "39"),
            New Country("Jamaica", "1"),
            New Country("Japan", "81"),
            New Country("Jordan", "962"),
            New Country("Kazakhstan", "7"),
            New Country("Kenya", "254"),
            New Country("Kiribati", "686"),
            New Country("Korea (Rep. of)", "82"),
            New Country("Kuwait", "965"),
            New Country("Kyrgyzstan", "996"),
            New Country("Lao P.D.R.", "856"),
            New Country("Latvia", "371"),
            New Country("Lebanon", "961"),
            New Country("Lesotho", "266"),
            New Country("Liberia", "231"),
            New Country("Libya", "218"),
            New Country("Liechtenstein", "423"),
            New Country("Lithuania", "370"),
            New Country("Luxembourg", "352"),
            New Country("Macao, China", "853"),
            New Country("Madagascar", "261"),
            New Country("Malawi", "265"),
            New Country("Malaysia", "60"),
            New Country("Maldives", "960"),
            New Country("Mali", "223"),
            New Country("Malta", "356"),
            New Country("Marshall Islands", "692"),
            New Country("Martinique", "596"),
            New Country("Mauritania", "222"),
            New Country("Mauritius", "230"),
            New Country("Mexico", "52"),
            New Country("Micronesia", "691"),
            New Country("Moldova (Republic of)", "373"),
            New Country("Monaco", "377"),
            New Country("Mongolia", "976"),
            New Country("Montenegro", "382"),
            New Country("Montserrat", "1"),
            New Country("Morocco", "212"),
            New Country("Mozambique", "258"),
            New Country("Myanmar", "95"),
            New Country("Namibia", "264"),
            New Country("Nauru", "674"),
            New Country("Nepal", "977"),
            New Country("Netherlands", "31"),
            New Country("New Caledonia", "687"),
            New Country("New Zealand", "64"),
            New Country("Nicaragua", "505"),
            New Country("Niger", "227"),
            New Country("Nigeria", "234"),
            New Country("Niue", "683"),
            New Country("Northern Marianas", "1"),
            New Country("Norway", "47"),
            New Country("Oman", "968"),
            New Country("Pakistan", "92"),
            New Country("Palau", "680"),
            New Country("Panama", "507"),
            New Country("Papua New Guinea", "675"),
            New Country("Paraguay", "595"),
            New Country("Peru", "51"),
            New Country("Philippines", "63"),
            New Country("Poland", "48"),
            New Country("Portugal", "351"),
            New Country("Puerto Rico", "1"),
            New Country("Qatar", "974"),
            New Country("Romania", "40"),
            New Country("Russian Federation", "7"),
            New Country("Rwanda", "250"),
            New Country("Saint Helena, Ascension and Tristan da Cunha", "247"),
            New Country("Saint Kitts and Nevis", "1"),
            New Country("Saint Lucia", "1"),
            New Country("Saint Pierre and Miquelon", "508"),
            New Country("Saint Vincent and the Grenadines", "1"),
            New Country("Samoa", "685"),
            New Country("San Marino", "378"),
            New Country("Sao Tome and Principe", "239"),
            New Country("Saudi Arabia", "966"),
            New Country("Senegal", "221"),
            New Country("Serbia", "381"),
            New Country("Seychelles", "248"),
            New Country("Sierra Leone", "232"),
            New Country("Singapore", "65"),
            New Country("Sint Maarten (Dutch part)", "1"),
            New Country("Slovakia", "421"),
            New Country("Slovenia", "386"),
            New Country("Solomon Islands", "677"),
            New Country("Somalia", "252"),
            New Country("South Africa", "27"),
            New Country("South Sudan", "211"),
            New Country("Spain", "34"),
            New Country("Sri Lanka", "94"),
            New Country("Sudan", "249"),
            New Country("Suriname", "597"),
            New Country("Swaziland", "268"),
            New Country("Sweden", "46"),
            New Country("Switzerland", "41"),
            New Country("Syrian Arab Republic", "963"),
            New Country("Taiwan, China", "886"),
            New Country("Tajikistan", "992"),
            New Country("Tanzania", "255"),
            New Country("Thailand", "66"),
            New Country("The Former Yugoslav Republic of Macedonia", "389"),
            New Country("Timor-Leste", "670"),
            New Country("Togo", "228"),
            New Country("Tokelau", "690"),
            New Country("Tonga", "676"),
            New Country("Trinidad and Tobago", "1"),
            New Country("Tunisia", "216"),
            New Country("Turkey", "90"),
            New Country("Turkmenistan", "993"),
            New Country("Turks and Caicos Islands", "1"),
            New Country("Tuvalu", "688"),
            New Country("Uganda", "256"),
            New Country("Ukraine", "380"),
            New Country("United Arab Emirates", "971"),
            New Country("United Kingdom", "44"),
            New Country("United States", "1"),
            New Country("United States Virgin Islands", "1"),
            New Country("Uruguay", "598"),
            New Country("Uzbekistan", "998"),
            New Country("Vanuatu", "678"),
            New Country("Vatican", "379"),
            New Country("Vatican", "39"),
            New Country("Venezuela (Bolivarian Republic of)", "58"),
            New Country("Viet Nam", "84"),
            New Country("Wallis and Futuna", "681"),
            New Country("Yemen", "967"),
            New Country("Zambia", "260"),
            New Country("Zimbabwe", "263")
        }

        ' Asignar la lista de países al ComboBox
        cb_country.DataSource = countries

        ' Cargar el país seleccionado desde el archivo
        LoadSelectedCountry()

        ' Indicar que la carga ha terminado
        isLoading = False
    End Sub




    ' Guardar el país seleccionado en un archivo de texto
    Private Sub SaveSelectedCountry(countryName As String)
        File.WriteAllText(SelectedCountryFilePath, countryName)
    End Sub

    ' Cargar el país seleccionado desde el archivo de texto
    Private Sub LoadSelectedCountry()
        ' Verificar si el archivo existe
        If File.Exists(SelectedCountryFilePath) Then
            ' Leer el nombre del país guardado
            Dim savedCountryName As String = File.ReadAllText(SelectedCountryFilePath).Trim()

            ' Buscar el país en la lista del ComboBox
            For Each country As Country In cb_country.Items
                If String.Equals(country.Name, savedCountryName, StringComparison.OrdinalIgnoreCase) Then
                    ' Seleccionar el país en el ComboBox
                    cb_country.SelectedItem = country
                    Exit For
                End If
            Next
        End If
    End Sub

    ' Evento para guardar el país seleccionado cuando cambia
    Private Sub cb_country_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_country.SelectedIndexChanged
        ' Solo guardar si la aplicación ya terminó de cargar
        If Not isLoading Then
            Dim selectedCountry As Country = CType(cb_country.SelectedItem, Country)
            If selectedCountry IsNot Nothing Then
                SaveSelectedCountry(selectedCountry.Name)
            End If
        End If
    End Sub

    ' Generar el enlace de WhatsApp
    Private Sub GenerateLink(sender As Object, e As EventArgs) Handles bt_genLink.Click
        Dim selectedCountry As Country = CType(cb_country.SelectedItem, Country)
        Dim telefono As String = tb_tel.Text
        If Len(Trim(telefono)) > 0 Then
            Dim enlace As String = "https://wa.me/" & selectedCountry.PhoneCode & telefono
            Process.Start("chrome.exe", enlace)
        Else
            MessageBox.Show("Introduce un teléfono")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
