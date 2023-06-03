
Console.WriteLine("name your dog:");
string myDogname = Console.WriteLine();
dog myDog = new dog(myDogname);

dog neighboursdog = new dog("good girl");


Console.WriteLine($"my dogs name is {myDog._name}.");
Console.WriteLine($"my neighbours dogs name is {neighboursdog._name}.");

myDog.rename("bad boy");

while(myDog.levelofhapiness !=5)
{
    myDog.bark();
}

myDog.wagtail();

class dog
{
    public string _name; //field
    public int _levelofhapiness;

    //constructor
    public dog(string name) //name-lets the user name the dog
    {
        _name = name;
        _levelofhapiness = 0;

    }

    //getter

    public string name
    {
        get { return _name; }
    }
    public int levelofhapiness
    {
        get { return _levelofhapiness;}
    }

    public void rename(string newname)
    {
        _name = newname;
        Console.WriteLine($"the dog has been renamed to: {newname}");
    }

    public void bark()
    {
        Console.WriteLine("woof-woof");
        _levelofhapiness++;

    }

    public void wagtail()
    {
        Console.WriteLine("wiggle-wiggle");
    }
}

