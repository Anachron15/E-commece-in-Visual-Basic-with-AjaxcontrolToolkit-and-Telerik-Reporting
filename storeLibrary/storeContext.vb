Imports System.Data.Entity
Public Class storeContext : Inherits DbContext
    Property User As DbSet(Of User)
    Property Product As DbSet(Of Product)

End Class
