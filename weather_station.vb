Sub Main()
        Dim P(4) As String
        Dim D(4, 6) As Integer

        For i As Integer = 0 To D.GetLength(0) - 1
            P(i) = InputBox("Give it a city name")
            For j As Integer = 0 To D.GetLength(1) - 1
                D(i, j) = Int((40 - 0 + 1) * Rnd() + 0) 'Int((upperbound - lowerbound + 1) * Rnd + lowerbound)

            Next

        Next

        Dim average_temperature(4) As Integer
        Dim below_10(4) As Integer
        Dim max_temperature As Integer
        Dim max_month As Integer
        Dim average_city_temperature As Integer

        max_temperature = -1
        average_city_temperature = 0

        For i As Integer = 0 To D.GetLength(0) - 1
            average_temperature(i) = 0
            below_10(i) = 0
            For j As Integer = 0 To D.GetLength(1) - 1
                average_temperature(i) = average_temperature(i) + D(i, j)
                average_city_temperature = average_city_temperature + D(i, j)
                If D(i, j) < 10 Then
                    below_10(i) = below_10(i) + 1
                End If

                If D(i, j) > max_temperature Then
                    max_temperature = D(i, j)
                    max_month = j
                End If
            Next
            average_temperature(i) = average_temperature(i) / 6
            MsgBox("Average temperatures for the city " & P(i) & " is " & average_temperature(i))
            MsgBox("The city " & P(i) & " had for " & below_10(i) & " months, temperatures below 10 degrees")

        Next
        average_city_temperature = average_city_temperature / 24
        MsgBox("Average temperatures for all cities are " & average_city_temperature)

        MsgBox("The month with the highest temperatures " & max_temperature & " degrees, it was the month " & max_month)

        For i As Integer = 0 To D.GetLength(0) - 1
            If average_temperature(i) > average_city_temperature Then
                MsgBox("The city " & P(i) & " had higher average annual temperatures than the average temperatures of all cities")
            End If
        Next


End Sub