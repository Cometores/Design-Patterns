using Iterator;

Console.Title = "Iterator";

// create the collection
PeopleCollection people = new()
{
    new Person("Tom", "USA"),
    new Person("Bob", "Belgium"),
    new Person("Sam", "The Netherlands"),
    new Person("Kate", "Germany")
};

// create the iterator
var peopleIterator = people.CreateIterator();

// use the iterator to run through the people int he collection
// they should come out in alphabetical order
for (Person person = peopleIterator.First(); !peopleIterator.IsDone; person = peopleIterator.Next())
{
    Console.WriteLine(person?.Name);
}

Console.ReadKey();