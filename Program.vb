Imports System

Module Program

    Sub Main()
        Dim toCompress As String = "ASK NOT WHAT YOUR COUNTRY CAN DO FOR YOU ASK WHAT YOU CAN DO FOR YOUR COUNTRY"
        Dim words() As String
        Dim uniqueWords As New List(Of String)
        Dim numstring As String = ""
        Dim a As Integer
        Dim numsUWords As String
        Dim unCompress As String
        'Splits words into an array
        words = toCompress.Split(" ")


        'Creates a list with a unique set of words
        For i = 0 To words.Length - 1
            If Not (uniqueWords.Contains(words(i))) Then
                uniqueWords.Add(words(i))
            End If
        Next
        Console.WriteLine("*******************")
        For i = 0 To words.Length - 1
            Console.WriteLine(i & words(i))
        Next

        'Outputs the list of unique words on the screen
        Console.WriteLine("*******************")
        For i = 0 To uniqueWords.Count - 1
            Console.WriteLine(i & uniqueWords(i))
        Next

        'compare words with unique words, if a word = a unique word, add the key to a string
        For i = 0 To uniqueWords.Count - 1

            If words(i) = uniqueWords(i) Then
                numstring = numstring & i
            End If
        Next
        a = 0


        For i = uniqueWords.Count To words.Length - 1

            For a = 0 To uniqueWords.Count - 1
                If words(i) = uniqueWords(a) Then
                    numstring = numstring & a
                End If


            Next
        Next

        For i = 0 To uniqueWords.Count - 1

            numsUWords = numsUWords & " " & uniqueWords(i)
        Next
        numsUWords = numsUWords & " # " & numstring
        Console.WriteLine(numsUWords)

        For i = 0 To numstring.Length - 1
            For a = 0 To uniqueWords.Count - 1
                If words(i) = uniqueWords(a) Then
                    unCompress = unCompress & " " & uniqueWords(a)
                End If
            Next
        Next
        Console.WriteLine(unCompress)
        Console.ReadLine()
    End Sub

End Module
