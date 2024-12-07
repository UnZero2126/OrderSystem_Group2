Public Module SharedData
    Public DiscountPercent As Decimal = 0
    Public VoucherApplied As Boolean = False
    Public AppliedDiscountPercent As Decimal = 0D
    Public AppliedItems As New Dictionary(Of String, Integer)()
    Public AppliedSubtotal As Decimal = 0
    Public LoggedIn As Boolean = False
    Public UserAddress As String = ""
    Public username As String = ""
    Public LastProcessedItems As New Dictionary(Of String, Integer)()
End Module
