


using DailyPractice;
using DailyPractice.AbstractionMiniPRoject;
using System.Collections.Generic;

//int res = SimpleINterest.CalculateSI(); // Static method call without class instance
//Console.WriteLine("Simple interest is {0}", res);

//BoxingUnboxing obj = new BoxingUnboxing(); // Instance method call with class object
//obj.BoxUnbox();

//DateDiff dt = new DateDiff();
//dt.DateDiff1();

//SumofDigits obj1 = new SumofDigits();
//Console.WriteLine("Sum of digits is {0}", obj1.sumofDigits());


//int[] arr = { 1, 2, 3, 4, 5 };
//int[,] TwoDArr = { { 1, 2, 3 }, { 4, 5, 6 } };


//Dictionary<int, string> dictData = new Dictionary<int, string>();
//dictData.Add(1, "One");
//dictData.Add(2, "Two");
//foreach (KeyValuePair<int, string> item in dictData)
//{
//    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
//}
//foreach (var item in dictData)
//{
//    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
//}


//Singleton singleton = Singleton.GetInstance();

//Singleton s1 = Singleton.GetInstance();
//Singleton s2 = Singleton.GetInstance();

//Console.WriteLine($"Are both instances same? {s1} --> " + (s1 == s2)); // Should print True


//Encapsulation enc = new Encapsulation();
//enc.Age = 25; // Using property to set age
//Console.WriteLine($"Age is: {enc.Age}"); // Using property to get age


//// Inheritance with virtual, override, and new keywords
//Parent p1 = new Parent();
//Parent p2 = new Child();
//Parent p3 = new AnotherChild();

//p1.Display();  // Parent Display
//p2.Display();  // Child Override Display ✅ (override works)
//p3.Display();  // Parent Display ❌ (new hides, not overrides)



//OperatorOverloadding obj1 = new OperatorOverloadding(10, 100);  
//OperatorOverloadding obj2 = new OperatorOverloadding(10, 100);
//dynamic SumOfObjects = obj1 + obj2;
//Console.WriteLine("Sum of objects --> "+ SumOfObjects);

//GenericNonGeneric obj = new GenericNonGeneric();
//obj.Show(20); // Compiler chooses simple non generic 
//obj.Show<int>(10); // for calling Generic method we have used it like this 
//obj.Show(10,20,30); // Now this will call params method


//MainClass obj4 = new SubClass();
//obj4.ShowMessage(); // new hides the method
//SubClass obj5 = new SubClass();
//obj5.ShowMessage();
//SubClass obj6 = new GrandSubClass();
//obj6.ShowMessage(); // obj6 type is parent so cant call child method as it hides using new keyword
//GrandSubClass obj7 = new GrandSubClass();
//obj7.ShowMessage(); // only same type of class obj7 can access it.


//IMainInterface classOne = new OneClassForIF();
//classOne.Display(); // Type is same but behaviour changes as per refeance type at time of Runtime and I/F hides the logic
//IMainInterface classTwo = new TwoClassForIF();
//classTwo.Display();


//ExtendsAbstractClass obj = new ExtendsAbstractClass();
//Console.WriteLine(obj.Name);
//obj.MandatoryMethod();
//obj.ConcreteMethod();

//Shape circle = new Circle() { Radius=5, Color="red" };
//Shape rect = new Rectangle() { Width = 10, Height = 6, Color = "Blue" };

//circle.Draw();
//circle.ShowColor();

//rect.Draw();
//rect.ShowColor();

//PartialClassStud s = new PartialClassStud() { RollNo = 101, Name = "Viren" };
//s.Show();
//s.DisplayDetails();


//StaticClasses.DisplayMessage(); // Calling static class method without creating instance
//StaticClasses obj = new StaticClasses(); // Error: Cannot create instance of static class
//obj.DisplayMessage(); // Error: Cannot call static method using instance


//Func<int, int, int> add = delegate (int a, int b)
//{
//    return a + b;
//};

//Console.WriteLine(add(5, 7));  // Output: 12

//Calculator obj = new Calculator();
//obj.Add(10).Multiply(5).Add(20).Show(); // Chained method calls
//new ParentClass(new ParentClass(null));
//new ChildTesting2(new ChildTesting2(null));
//new ChildTesting(new ChildTesting(null));

//Generics obj = new Generics();
//Console.WriteLine(obj.PrintAnyDataType(100));
//Console.WriteLine(obj.PrintAnyDataType("Hello Generics"));
//Console.WriteLine(obj.PrintAnyDataType<double>(99.99));

//LINQ_Methods.LinqExample();

//SortArray.SortArrayAsc(new int[] { 5, 3, 8, 1, 2 });

//EnumsNamedConstants.ShowEnum();


//// Lightweight value type object
//StructNotAClass point = new StructNotAClass(10, 20);
//point.DisplayCoordinates();
//point.X = 30; // If no constructor is defined, then fields can be modified directly

//IndexersInCSharp obj = new IndexersInCSharp();
//obj[0]= 10; // Using indexer to set value
//obj[4]= 20;
//Console.WriteLine("Value at index 4: " + (string.Join(',', obj[4])));// Using indexer to get value
//obj.DisplayArray();

//Interfaces are mainly used for swap the classes as DateOnly one type used in method 

//Student stud = new Student(new College()); // Constructor Injection
//stud.school = new School(); // Property Injection
//stud.Study(new Class()); // Method Injection


SingletoDesingPattern SingleObjForWholeApp= SingletoDesingPattern.GetInstance();

SingleObjForWholeApp.ShowMsg();

