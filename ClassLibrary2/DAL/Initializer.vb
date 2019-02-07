Imports System.Data.Entity
Imports System.Data.Entity.DbConfiguration
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Initializer : Inherits DropCreateDatabaseIfModelChanges(Of storeContext)
    Protected Overrides Sub Seed(ByVal context As storeContext)
        ' PRODUCT CATEGORY INITIALIZATION

        Dim category1 = New ProductCategory With {.productCategoryId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed337a"), .productCategoryName = "Shoes"}
        Dim category2 = New ProductCategory With {.productCategoryId = Guid.Parse("7442faf0-a9e3-4073-b06b-b987065dbe8c"), .productCategoryName = "Shirt"}
        Dim category3 = New ProductCategory With {.productCategoryId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed337d"), .productCategoryName = "Electronic Devices"}
        Dim category4 = New ProductCategory With {.productCategoryId = Guid.Parse("7442faf0-a9e3-4073-b06b-b987065dbe8e"), .productCategoryName = "Electronic Accesories"}
        Dim category5 = New ProductCategory With {.productCategoryId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed337f"), .productCategoryName = "Groceries"}

        context.ProductCategory.Add(category1)
        context.ProductCategory.Add(category2)
        context.ProductCategory.Add(category3)
        context.ProductCategory.Add(category4)
        context.ProductCategory.Add(category5)

        ' PRODUCT INIT
        Dim product1 = New Product With {.productId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed332a"), .productImage = "Shoe 1.png", .productName = "Shoe 1", .productPrice = "7000", .productQuantity = 20, .productStatus = "available", .productCategoryId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed337a"), .productDescription = "Product description"}
        Dim product2 = New Product With {.productId = Guid.Parse("7442faf0-a9e3-4073-b06b-b987065dbe7c"), .productImage = "Shoe 2.png", .productName = "Shoe 2", .productPrice = "8000", .productQuantity = 30, .productStatus = "available", .productCategoryId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed337a"), .productDescription = "Product description"}
        Dim product3 = New Product With {.productId = Guid.Parse("f5a53daa-1622-4487-8662-12db065af51d"), .productImage = "Shoe 3.png", .productName = "Shoe 3", .productPrice = "9000", .productQuantity = 10, .productStatus = "available", .productCategoryId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed337a"), .productDescription = "Product description"}
        Dim product4 = New Product With {.productId = Guid.Parse("724ec0cc-fc02-4022-a44a-ec198be6413e"), .productImage = "Shoe 4.png", .productName = "Shoe 4", .productPrice = "10000", .productQuantity = 40, .productStatus = "available", .productCategoryId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed337a"), .productDescription = "Product description"}

        Dim product5 = New Product With {.productId = Guid.Parse("13bdb3ae-8be7-458c-8268-8334e5a02bec"), .productImage = "Shirt 1.png", .productName = "Shirt 1", .productPrice = "7000", .productQuantity = 10, .productStatus = "out of stock", .productCategoryId = Guid.Parse("7442faf0-a9e3-4073-b06b-b987065dbe8c"), .productDescription = "Product description"}
        Dim product6 = New Product With {.productId = Guid.Parse("072453b5-cf32-4ecc-b418-98767dfe1be1"), .productImage = "Shirt 2.png", .productName = "Shirt 2", .productPrice = "8000", .productQuantity = 20, .productStatus = "available", .productCategoryId = Guid.Parse("7442faf0-a9e3-4073-b06b-b987065dbe8c"), .productDescription = "Product description"}
        Dim product7 = New Product With {.productId = Guid.Parse("59a04134-947e-47c7-83b1-a55a34071bae"), .productImage = "Shirt 3.png", .productName = "Shirt 3", .productPrice = "9000", .productQuantity = 30, .productStatus = "available", .productCategoryId = Guid.Parse("7442faf0-a9e3-4073-b06b-b987065dbe8c"), .productDescription = "Product description"}
        Dim product8 = New Product With {.productId = Guid.Parse("52a890e0-457a-4b1f-b70d-aaad4bd9f70d"), .productImage = "Shirt 4.png", .productName = "Shirt 4", .productPrice = "10000", .productQuantity = 40, .productStatus = "out of stock", .productCategoryId = Guid.Parse("7442faf0-a9e3-4073-b06b-b987065dbe8c"), .productDescription = "Product description"}

        context.Product.Add(product1)
        context.Product.Add(product2)
        context.Product.Add(product3)
        context.Product.Add(product4)
        context.Product.Add(product5)
        context.Product.Add(product6)
        context.Product.Add(product7)
        context.Product.Add(product8)

        Dim user1 = New User With {.userId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed332a"), .userFirstName = "Bethoven", .userLastName = "Acha", .userGender = "Male", .userEmail = "bmacha2015@gmail.com", .userPassword = "password", .userRole = "admin", .userStatus = "active", .userBirthDay = DateTime.Now}
        Dim user2 = New User With {.userId = Guid.Parse("52a890e0-457a-4b1f-b70d-aaad4bd9f70d"), .userFirstName = "John", .userLastName = "Doe", .userGender = "Male", .userEmail = "bmacha2016@gmail.com", .userPassword = "password", .userRole = "customer", .userStatus = "active", .userBirthDay = DateTime.Now}
        Dim user3 = New User With {.userId = Guid.Parse("52a890e0-457a-4b1f-b70d-aaad4bd9f70c"), .userFirstName = "Johny", .userLastName = "Doee", .userGender = "Male", .userEmail = "bmacha2017@gmail.com", .userPassword = "password", .userRole = "customer", .userStatus = "active", .userBirthDay = DateTime.Now}

        context.User.Add(user1)
        context.User.Add(user2)

        Dim order1 = New Order With {.orderId = Guid.Parse("52a890e0-457a-4b1f-b70d-aaad4bd9f70d"), .userId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed332a"), .ProductId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed332a"), .orderDate = DateTime.Now}
        Dim order2 = New Order With {.orderId = Guid.Parse("52a890e0-457a-4b1f-b70d-aaad4bd9f70c"), .userId = Guid.Parse("52a890e0-457a-4b1f-b70d-aaad4bd9f70d"), .ProductId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed332a"), .orderDate = DateTime.Now}
        Dim order3 = New Order With {.orderId = Guid.Parse("726962ec-cade-4497-9d45-96bc7113cfcf"), .userId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed332a"), .ProductId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed332a"), .orderDate = DateTime.Now}
        Dim order4 = New Order With {.orderId = Guid.Parse("5bcf2817-c359-4d57-b3b8-3e7c5ef7fc17"), .userId = Guid.Parse("52a890e0-457a-4b1f-b70d-aaad4bd9f70d"), .ProductId = Guid.Parse("7442faf0-a9e3-4073-b06b-b987065dbe7c"), .orderDate = DateTime.Now}
        Dim order5 = New Order With {.orderId = Guid.Parse("f3d4b30d-74b0-40c9-a982-7409924afbd0"), .userId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed332a"), .ProductId = Guid.Parse("63Dbdcd9-e057-4471-bf45-b94c20ed332a"), .orderDate = DateTime.Now}
        Dim order6 = New Order With {.orderId = Guid.Parse("55c11bef-6e8f-49c2-95c6-cc60aec77f06"), .userId = Guid.Parse("52a890e0-457a-4b1f-b70d-aaad4bd9f70d"), .ProductId = Guid.Parse("7442faf0-a9e3-4073-b06b-b987065dbe7c"), .orderDate = DateTime.Now}

        context.Order.Add(order1)
        context.Order.Add(order2)
        context.Order.Add(order3)
        context.Order.Add(order4)
        context.Order.Add(order5)
        context.Order.Add(order6)

        context.SaveChanges()
    End Sub
End Class
