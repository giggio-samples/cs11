// structs initialize
Console.WriteLine(new StructsInitialize(5));  // 5 (Ordinary measurement)
Console.WriteLine(new StructsInitialize());  // 0 ()
Console.WriteLine(default(StructsInitialize)); // 0

// file scoped types

Console.WriteLine(FileScopedTypes.Method());
//new PrivateToTheFile(1, "Giovanni") // does not compile

// string literals
Console.WriteLine(StringLiterals.M());

//list patterns
ListPatterns.M();

// generic math (static abstract interface members)
#if NET7_0_OR_GREATER
Console.WriteLine(GenericMath.Sum(1, 2, 3));
Console.WriteLine(GenericMath.Sum(1.1, 2.2, 3.3));
Console.WriteLine(GenericMath.Sum(1.1m, 2.2m, 3.3m));

// required members
var joao = new Person { Id = 1, FirstName = "João" };
var giovanni = new Person { Id = 1, FirstName = "Giovanni", LastName = "Bassi" };
//var unnamed = new Person(); // does not compile
//var personWithId = new Person { Id = 1 }; // does not compile
var dog = new Pet("Dog") { Nickname = "Doggy" };
var otherDog = dog with { Nickname = "OtherDog" };
var otherDog2 = dog with { Nickname = "OtherDog2", LastName = "Last Name" };
#endif
