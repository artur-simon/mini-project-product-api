# mini-project-product-api

Avaliable on `https://simpleprojectproductapi.herokuapp.com/`

Requests can be made to the following endpoint:
`https://simpleprojectproductapi.herokuapp.com/graphql`

This is a simple project using NET.Core EntityFramework and GraphQl to enable an API with CRUD functionalities.

I took a code-first approach, so the DB should be configured to reflect the given context.

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
