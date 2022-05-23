# mini-project-product-api

This is a simple project using NET.Core EntityFramework and GraphQl to enable an API with CRUD functionalities.

I took a code-first approach, so the DB should be configured to reflect the given context.

# Installing and running

clone repository

`git clone https://github.com/artur-simon/mini-project-product-api.git`

install framework

`cd .SimpleProjectProduct/`

`dotnet restore`

execute a migration command using in the project folder

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
