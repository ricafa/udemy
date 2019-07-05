#Database config, for newbees
##Criação das tabelas através do DBSet
dotnet ef migrations add init

##Criação do banco de dados com as alterações
dotnet ef database update

#for sqlite management download https://sqlitebrowser.org/dl/

