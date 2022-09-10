Friend Class CellClass
    Private possibiles As New List(Of Char)
    Private answer As Char
    Private r As Char
    Private c As Char
    Private b As Char
    Public name As String


    Public Property row() As Char
        Get
            Return r
        End Get
        Set(ByVal value As Char)
            r = value
        End Set
    End Property

    Public Property column() As Char
        Get
            Return c
        End Get
        Set(ByVal value As Char)
            c = value
        End Set
    End Property

    Public Property block() As Char
        Get
            Return b
        End Get
        Set(ByVal value As Char)
            b = value
        End Set
    End Property

    Public Property cellAnswer() As Char
        Get
            Return answer
        End Get
        Set(ByVal value As Char)
            answer = value
        End Set
    End Property


    Public Property poss() As List(Of Char)
        Get
            Return possibiles
        End Get
        Set(ByVal value As List(Of Char))
            possibiles = value
        End Set
    End Property

    Public Sub New(ByVal nRow As Char, ByVal nCol As Char, ByVal nBlock As Char)

        Me.row = nRow
        Me.column = nCol
        Me.block = nBlock
        Me.name = nRow + nCol

        reset()



    End Sub

    Public Sub reset()
        Me.answer = ""
        Me.possibiles.Clear()

        For i As Int16 = 49 To 57
            Me.poss.Add(ChrW(i))
        Next
    End Sub

End Class
