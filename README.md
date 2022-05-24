# mini-project-product-api

This is a simple project using NET.Core EntityFramework and GraphQl to enable an API with CRUD functionalities.

I took a code-first approach, so the DB should be configured to reflect the given context.

GraphQL.NET SDK uses the builder pattern to configure the required GraphQL services.

I intented on making a repository layer to decouple the database but found this
`https://pt.stackoverflow.com/questions/51536/quando-usar-entity-framework-com-repository-pattern`
and so i took it back.

# Installing and running

clone repository

`git clone https://github.com/artur-simon/mini-project-product-api.git`

install framework

`cd .SimpleProjectProduct/`

`dotnet restore`

edit .appsetings' ConnectionStrings to reflect the local MSSQL, execute a migration command in the project folder

`dotnet ef database update`

run project framework

`dotnet run`


# GraphQl
I used mostly Postman or Altair to run queries, using the given sintax:

Select:
`{
  product {
    estoque,
    nome,
    preco
  }
}`

Create:
`mutation {
  create(nome: "Green Fruits", preco: 1.2, estoque : 123) {
      id
  }
}`

Edit:
`mutation {
  edit(id: 12, nome: "Green Fruits", preco: 1.2, estoque : 123) {
      nome,
      preco,
      estoque
  }
}`

Delete:
`mutation {
  delete(id: 12) {
      id
  }
}` 
