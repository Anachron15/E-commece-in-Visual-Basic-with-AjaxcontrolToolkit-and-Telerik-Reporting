Imports System.Data.Entity
Public Class storeContext : Inherits DbContext
    Property User As DbSet(Of User)
    Property Product As DbSet(Of Product)
    Property Order As DbSet(Of Order)
    Property ProductCategory As DbSet(Of ProductCategory)
    Property ProductAttribute As DbSet(Of ProductAttribute)
End Class
