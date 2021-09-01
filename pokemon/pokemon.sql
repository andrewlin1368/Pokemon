create table Pokemon(
PokemonID int primary key,
PokemonType varchar(20),
PokemonName varchar(20),
PokemonGender varchar(20),
constraint checkgender check (PokemonGender in('Male','Female')))

select * from Pokemon