# mini-project-product-api

Avaliable on `https://simpleprojectproductapi.herokuapp.com/`

Requests can be made to the following endpoint:
`https://simpleprojectproductapi.herokuapp.com/graphql`

This is a simple project using NET.Core EntityFramework and GraphQl to enable an API\n
that is able to fully CRUD.

I took a code-first approach, so the DB should be configured to reflect the given context.

# Installing and running

clone repository
`git clone https://github.com/artur-simon/mini-project-product-api.git`

execute a migration command using in the project folder
`dotnet ef database update`


# GraphQl
I used mostly Postman to run queries, using the given sintax:
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
