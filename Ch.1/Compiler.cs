//int a = 5;
//int b = a + 2; // OK

//bool test = true;

//// Error
//int c = a + test;

// 변수선언에 형식 지정 

//float temperature;
//string name;
//MyClass myClass;

//char firstLetter = 'c';
//var limit = 3;
//int[] source = [0, 1, 2, 3, 4, 5];
//var query = from item in source
//            where item <= limit
//            select item;

// int 문자열 반환

//string name;

//public string GetName(int ID);
//{
//    if (ID < name.Length)
//        return name[ID];
//    else
//        return String.Empty;
//}

//private string[] names = ["Spencer", "Sally", "Doug"];

// 값 형식
//byte b = byte.MaxValue;

//Console.WriteLine(b);

//byte num = 0xA;
//int i = 5;
//char c = '2';

// struct 키워드

//public struct Cords
//{
//    public int x, y;

//    public Cords(int p1, int p2)
//    {
//        x = p1;
//        y = p2;
//    }
//}

// 상수 집합
//public enum FileMod
//{
//    CreateNew = 1,
//    Create = 2,
//    Open = 3,
//    OpenOrCreate = 4,
//    Truecate = 5,
//    Append = 6,
//}

//// 참조 형식 
//MyClass myClass = new MyClass();
////myClass myClass = myClass;

//IMyInterface myInterface = myClass;

//IMyInterface myInterFace2 = new MyClass();


//int[] nums = [1, 2, 3, 4, 5, 6];

//int len = nums.Length;

// 리터럴 값 형식
//string s = "The answer is" + 5.ToString();

//Console.WriteLine(s);

//Type type = 12345.GetType();
//Console.WriteLine(type);

// 제네릭 형식

//List<string> stringList = new List<string>();
//stringList.Add("String example");

//stringList.Add(4);

// 컴파일 형식 및 런타임 형식

//string message = "string runtime";

//object anotherMessage = "This is another string of characters";
//IEnumerable<char> someCharacters = "abcdefghijkmnopqrstuvwxyz";
