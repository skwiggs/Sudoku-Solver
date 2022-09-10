
Imports Sudoku_Solver

Public Class frmMain

    Dim validInput As New List(Of Char)

    'makes a cell and assigns it's "address"
    'wanted to assign it's textbox but it appears they don't exist yet..

    Dim a1 As New CellClass("a", "1", "1")
    Dim a2 As New CellClass("a", "2", "1")
    Dim a3 As New CellClass("a", "3", "1")
    Dim a4 As New CellClass("a", "4", "2")
    Dim a5 As New CellClass("a", "5", "2")
    Dim a6 As New CellClass("a", "6", "2")
    Dim a7 As New CellClass("a", "7", "3")
    Dim a8 As New CellClass("a", "8", "3")
    Dim a9 As New CellClass("a", "9", "3")
    Dim b1 As New CellClass("b", "1", "1")
    Dim b2 As New CellClass("b", "2", "1")
    Dim b3 As New CellClass("b", "3", "1")
    Dim b4 As New CellClass("b", "4", "2")
    Dim b5 As New CellClass("b", "5", "2")
    Dim b6 As New CellClass("b", "6", "2")
    Dim b7 As New CellClass("b", "7", "3")
    Dim b8 As New CellClass("b", "8", "3")
    Dim b9 As New CellClass("b", "9", "3")
    Dim c1 As New CellClass("c", "1", "1")
    Dim c2 As New CellClass("c", "2", "1")
    Dim c3 As New CellClass("c", "3", "1")
    Dim c4 As New CellClass("c", "4", "2")
    Dim c5 As New CellClass("c", "5", "2")
    Dim c6 As New CellClass("c", "6", "2")
    Dim c7 As New CellClass("c", "7", "3")
    Dim c8 As New CellClass("c", "8", "3")
    Dim c9 As New CellClass("c", "9", "3")
    Dim d1 As New CellClass("d", "1", "4")
    Dim d2 As New CellClass("d", "2", "4")
    Dim d3 As New CellClass("d", "3", "4")
    Dim d4 As New CellClass("d", "4", "5")
    Dim d5 As New CellClass("d", "5", "5")
    Dim d6 As New CellClass("d", "6", "5")
    Dim d7 As New CellClass("d", "7", "6")
    Dim d8 As New CellClass("d", "8", "6")
    Dim d9 As New CellClass("d", "9", "6")
    Dim e1 As New CellClass("e", "1", "4")
    Dim e2 As New CellClass("e", "2", "4")
    Dim e3 As New CellClass("e", "3", "4")
    Dim e4 As New CellClass("e", "4", "5")
    Dim e5 As New CellClass("e", "5", "5")
    Dim e6 As New CellClass("e", "6", "5")
    Dim e7 As New CellClass("e", "7", "6")
    Dim e8 As New CellClass("e", "8", "6")
    Dim e9 As New CellClass("e", "9", "6")
    Dim f1 As New CellClass("f", "1", "4")
    Dim f2 As New CellClass("f", "2", "4")
    Dim f3 As New CellClass("f", "3", "4")
    Dim f4 As New CellClass("f", "4", "5")
    Dim f5 As New CellClass("f", "5", "5")
    Dim f6 As New CellClass("f", "6", "5")
    Dim f7 As New CellClass("f", "7", "6")
    Dim f8 As New CellClass("f", "8", "6")
    Dim f9 As New CellClass("f", "9", "6")
    Dim g1 As New CellClass("g", "1", "7")
    Dim g2 As New CellClass("g", "2", "7")
    Dim g3 As New CellClass("g", "3", "7")
    Dim g4 As New CellClass("g", "4", "8")
    Dim g5 As New CellClass("g", "5", "8")
    Dim g6 As New CellClass("g", "6", "8")
    Dim g7 As New CellClass("g", "7", "9")
    Dim g8 As New CellClass("g", "8", "9")
    Dim g9 As New CellClass("g", "9", "9")
    Dim h1 As New CellClass("h", "1", "7")
    Dim h2 As New CellClass("h", "2", "7")
    Dim h3 As New CellClass("h", "3", "7")
    Dim h4 As New CellClass("h", "4", "8")
    Dim h5 As New CellClass("h", "5", "8")
    Dim h6 As New CellClass("h", "6", "8")
    Dim h7 As New CellClass("h", "7", "9")
    Dim h8 As New CellClass("h", "8", "9")
    Dim h9 As New CellClass("h", "9", "9")
    Dim i1 As New CellClass("i", "1", "7")
    Dim i2 As New CellClass("i", "2", "7")
    Dim i3 As New CellClass("i", "3", "7")
    Dim i4 As New CellClass("i", "4", "8")
    Dim i5 As New CellClass("i", "5", "8")
    Dim i6 As New CellClass("i", "6", "8")
    Dim i7 As New CellClass("i", "7", "9")
    Dim i8 As New CellClass("i", "8", "9")
    Dim i9 As New CellClass("i", "9", "9")

    'now an object to hold them all

    Dim answerGrid As New List(Of CellClass)





    'rows have same letter
    Dim row1 As New List(Of CellClass)
    Dim row2 As New List(Of CellClass)
    Dim row3 As New List(Of CellClass)
    Dim row4 As New List(Of CellClass)
    Dim row5 As New List(Of CellClass)
    Dim row6 As New List(Of CellClass)
    Dim row7 As New List(Of CellClass)
    Dim row8 As New List(Of CellClass)
    Dim row9 As New List(Of CellClass)

    'cols have same number
    Dim col1 As New List(Of CellClass)
    Dim col2 As New List(Of CellClass)
    Dim col3 As New List(Of CellClass)
    Dim col4 As New List(Of CellClass)
    Dim col5 As New List(Of CellClass)
    Dim col6 As New List(Of CellClass)
    Dim col7 As New List(Of CellClass)
    Dim col8 As New List(Of CellClass)
    Dim col9 As New List(Of CellClass)

    'blocks are ordered with top left is 1st, bottom right is 9
    Dim blk1 As New List(Of CellClass)
    Dim blk2 As New List(Of CellClass)
    Dim blk3 As New List(Of CellClass)
    Dim blk4 As New List(Of CellClass)
    Dim blk5 As New List(Of CellClass)
    Dim blk6 As New List(Of CellClass)
    Dim blk7 As New List(Of CellClass)
    Dim blk8 As New List(Of CellClass)
    Dim blk9 As New List(Of CellClass)






    Public Sub PreloadStuff() Handles Me.Load

        validInput.Add("1")
        validInput.Add("2")
        validInput.Add("3")
        validInput.Add("4")
        validInput.Add("5")
        validInput.Add("6")
        validInput.Add("7")
        validInput.Add("8")
        validInput.Add("9")


        'put all in answer grid  (should grid be it's own class?....)

        answerGrid.Add(a1)
        answerGrid.Add(a2)
        answerGrid.Add(a3)
        answerGrid.Add(a4)
        answerGrid.Add(a5)
        answerGrid.Add(a6)
        answerGrid.Add(a7)
        answerGrid.Add(a8)
        answerGrid.Add(a9)

        answerGrid.Add(b1)
        answerGrid.Add(b2)
        answerGrid.Add(b3)
        answerGrid.Add(b4)
        answerGrid.Add(b5)
        answerGrid.Add(b6)
        answerGrid.Add(b7)
        answerGrid.Add(b8)
        answerGrid.Add(b9)

        answerGrid.Add(c1)
        answerGrid.Add(c2)
        answerGrid.Add(c3)
        answerGrid.Add(c4)
        answerGrid.Add(c5)
        answerGrid.Add(c6)
        answerGrid.Add(c7)
        answerGrid.Add(c8)
        answerGrid.Add(c9)

        answerGrid.Add(d1)
        answerGrid.Add(d2)
        answerGrid.Add(d3)
        answerGrid.Add(d4)
        answerGrid.Add(d5)
        answerGrid.Add(d6)
        answerGrid.Add(d7)
        answerGrid.Add(d8)
        answerGrid.Add(d9)

        answerGrid.Add(e1)
        answerGrid.Add(e2)
        answerGrid.Add(e3)
        answerGrid.Add(e4)
        answerGrid.Add(e5)
        answerGrid.Add(e6)
        answerGrid.Add(e7)
        answerGrid.Add(e8)
        answerGrid.Add(e9)

        answerGrid.Add(f1)
        answerGrid.Add(f2)
        answerGrid.Add(f3)
        answerGrid.Add(f4)
        answerGrid.Add(f5)
        answerGrid.Add(f6)
        answerGrid.Add(f7)
        answerGrid.Add(f8)
        answerGrid.Add(f9)

        answerGrid.Add(g1)
        answerGrid.Add(g2)
        answerGrid.Add(g3)
        answerGrid.Add(g4)
        answerGrid.Add(g5)
        answerGrid.Add(g6)
        answerGrid.Add(g7)
        answerGrid.Add(g8)
        answerGrid.Add(g9)

        answerGrid.Add(h1)
        answerGrid.Add(h2)
        answerGrid.Add(h3)
        answerGrid.Add(h4)
        answerGrid.Add(h5)
        answerGrid.Add(h6)
        answerGrid.Add(h7)
        answerGrid.Add(h8)
        answerGrid.Add(h9)

        answerGrid.Add(i1)
        answerGrid.Add(i2)
        answerGrid.Add(i3)
        answerGrid.Add(i4)
        answerGrid.Add(i5)
        answerGrid.Add(i6)
        answerGrid.Add(i7)
        answerGrid.Add(i8)
        answerGrid.Add(i9)

        'commented out as this is part of Cell class now.  #todo

        'a1.name = “a1“
        'a2.name = “a2“
        'a3.name = “a3“
        'a4.name = “a4“
        'a5.name = “a5“
        'a6.name = “a6“
        'a7.name = “a7“
        'a8.name = “a8“
        'a9.name = “a9“
        'b1.name = “b1“
        'b2.name = “b2“
        'b3.name = “b3“
        'b4.name = “b4“
        'b5.name = “b5“
        'b6.name = “b6“
        'b7.name = “b7“
        'b8.name = “b8“
        'b9.name = “b9“
        'c1.name = “c1“
        'c2.name = “c2“
        'c3.name = “c3“
        'c4.name = “c4“
        'c5.name = “c5“
        'c6.name = “c6“
        'c7.name = “c7“
        'c8.name = “c8“
        'c9.name = “c9“
        'd1.name = “d1“
        'd2.name = “d2“
        'd3.name = “d3“
        'd4.name = “d4“
        'd5.name = “d5“
        'd6.name = “d6“
        'd7.name = “d7“
        'd8.name = “d8“
        'd9.name = “d9“
        'e1.name = “e1“
        'e2.name = “e2“
        'e3.name = “e3“
        'e4.name = “e4“
        'e5.name = “e5“
        'e6.name = “e6“
        'e7.name = “e7“
        'e8.name = “e8“
        'e9.name = “e9“
        'f1.name = “f1“
        'f2.name = “f2“
        'f3.name = “f3“
        'f4.name = “f4“
        'f5.name = “f5“
        'f6.name = “f6“
        'f7.name = “f7“
        'f8.name = “f8“
        'f9.name = “f9“
        'g1.name = “g1“
        'g2.name = “g2“
        'g3.name = “g3“
        'g4.name = “g4“
        'g5.name = “g5“
        'g6.name = “g6“
        'g7.name = “g7“
        'g8.name = “g8“
        'g9.name = “g9“
        'h1.name = “h1“
        'h2.name = “h2“
        'h3.name = “h3“
        'h4.name = “h4“
        'h5.name = “h5“
        'h6.name = “h6“
        'h7.name = “h7“
        'h8.name = “h8“
        'h9.name = “h9“
        'i1.name = “i1“
        'i2.name = “i2“
        'i3.name = “i3“
        'i4.name = “i4“
        'i5.name = “i5“
        'i6.name = “i6“
        'i7.name = “i7“
        'i8.name = “i8“
        'i9.name = “i9“



        'applies handeler to all txtboxes  (this is beautiful btw)

        For Each txt In Me.Controls.OfType(Of TextBox)()
            AddHandler txt.TextChanged, AddressOf newlyAnswered
        Next


        For Each cell In answerGrid
            Select Case cell.row
                Case "a"
                    row1.Add(cell)
                Case "b"
                    row2.Add(cell)
                Case "c"
                    row3.Add(cell)
                Case "d"
                    row4.Add(cell)
                Case "e"
                    row5.Add(cell)
                Case "f"
                    row6.Add(cell)
                Case "g"
                    row7.Add(cell)
                Case "h"
                    row8.Add(cell)
                Case "i"
                    row9.Add(cell)

            End Select

            Select Case cell.column
                Case "1"
                    col1.Add(cell)
                Case "2"
                    col2.Add(cell)
                Case "3"
                    col3.Add(cell)
                Case "4"
                    col4.Add(cell)
                Case "5"
                    col5.Add(cell)
                Case "6"
                    col6.Add(cell)
                Case "7"
                    col7.Add(cell)
                Case "8"
                    col8.Add(cell)
                Case "9"
                    col9.Add(cell)
            End Select

            Select Case cell.block
                Case "1"
                    blk1.Add(cell)
                Case "2"
                    blk2.Add(cell)
                Case "3"
                    blk3.Add(cell)
                Case "4"
                    blk4.Add(cell)
                Case "5"
                    blk5.Add(cell)
                Case "6"
                    blk6.Add(cell)
                Case "7"
                    blk7.Add(cell)
                Case "8"
                    blk8.Add(cell)
                Case "9"
                    blk9.Add(cell)
            End Select

        Next




    End Sub


    'sub to attach txt to answergrid
    Private Sub newlyAnswered(ByVal sender As TextBox, ByVal e As System.EventArgs)

        'please please please let this work!!
        For Each cell In answerGrid
            If sender.Name = "txt" + cell.name Then
                cell.cellAnswer = sender.Text
                cell.poss.Clear()
            End If
        Next


    End Sub


    'keeps input to answer grid numeric (even though they are chars XD  )

    Private Sub autoFilterNonNumerics(ByVal sender As Object,
    ByVal e As KeyPressEventArgs) Handles Me.KeyPress


        If Not validInput.Contains(e.KeyChar) Then
            If Not e.KeyChar = ChrW(8) Then  'oops forgot backspace
                e.Handled = True
            End If
        End If


    End Sub


    'checks every cell for rule 1 (remove possibilites in same row, col, and block if a cell has an answer)
    Private Sub Rule1(sender As Object, e As EventArgs) Handles btnRule1.Click
        Dim cRow As Char = ""
        Dim cCol As Char = ""
        Dim cBlock As Char = ""

        For Each cell In answerGrid
            If cell.cellAnswer = "" Then
                'answer was blank, nothing to do so NEXT!
                Continue For
            Else

                'these declarations might not be needed...
                cRow = cell.row
                cCol = cell.column
                cBlock = cell.block

                For Each workingCell In answerGrid
                    Try
                        If workingCell.row = cRow Then
                            workingCell.poss.Remove(cell.cellAnswer)
                        End If
                        If workingCell.column = cCol Then
                            workingCell.poss.Remove(cell.cellAnswer)
                        End If
                        If workingCell.block = cBlock Then
                            workingCell.poss.Remove(cell.cellAnswer)
                        End If
                    Catch except As Exception
                        MessageBox.Show(except.Message)
                    End Try

                Next 'working cell

            End If
        Next 'cell
        updateAnswersOnGrid()
    End Sub

    'If only 1 possible updateGrid places in textbox.. hopefully this triggers textChanged.
    Private Sub updateAnswersOnGrid()
        For Each cell In answerGrid
            If cell.poss.Count = 1 Then
                cell.cellAnswer = cell.poss.Item(0)
                setTxtFrom1Poss(cell)
                cell.poss.Clear()
            End If
        Next
    End Sub

    Private Sub setTxtFrom1Poss(ByRef cell As CellClass)


        For Each txt In Me.Controls.OfType(Of TextBox)()
            If txt.Name = "txt" + cell.name Then
                txt.Text = cell.cellAnswer
            End If
        Next

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        For Each txt In Me.Controls.OfType(Of TextBox)
            txt.Text = ""
        Next

        For Each cell In answerGrid
            cell.reset()
        Next

    End Sub

    Private Sub btnRule2_Click(sender As Object, e As EventArgs) Handles btnRule2.Click
        'looks at possiblites and sees if only one of them can be a certain number.
        'Dim workinglist As New List(Of String)
        Dim curCellName As String
        'lets try just first row.
        For Each cell In row1
            curCellName = cell.name
            For Each poss In cell.poss
                For Each tempCell In row1
                    If tempCell.name = cell.name Then
                        Continue For
                    End If

                Next
            Next
        Next

        'For i As Int16 = 1 To workinglist.Count()
        '    If workinglist.i("1") Then

        '    End If
        'Next



    End Sub
End Class
