Imports System.Runtime.CompilerServices


Module GridExtensions
    <Extension()>
    Function GetRowGroupIndexByRowHandle(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal rowHandle As Integer) As Integer
        Dim parentRowHandle As Integer = view.GetParentRowHandle(rowHandle)
        Dim childCount As Integer = view.GetChildRowCount(parentRowHandle)
        Dim lastRowHandle As Integer = view.GetChildRowHandle(parentRowHandle, childCount - 1)
        Return (childCount - 1) - Math.Abs(lastRowHandle - rowHandle)
    End Function
End Module