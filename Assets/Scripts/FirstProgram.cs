using UnityEngine;

public class FirstProgram : MonoBehaviour
{
    void Start()
    {
       #region Задание 1

int myInt = 10;
float myFloat = 20.5f;
bool myBool = true;
string myString = "Hello, World!";

const int myConstInt = 100;
const float myConstFloat = 200.5f;
const bool myConstBool = false;
const string myConstString = "Hello, Universe!";

Debug.Log(myConstString);
Debug.Log(myFloat);

#region Задание 3

double sqrtResult = Math.Sqrt(myInt);
double powResult = Math.Pow(myFloat, 2);

#region Задание 2

int resultInt = myInt + myConstInt;
float resultFloat = myFloat - myConstFloat;
string resultString = myString + " " + myConstString;

Debug.Log (resultString);

#region Задание 4

double myDouble = myInt;
Debug.Log(myDouble);

int myNewInt = (int)myFloat;
Debug.Log(myNewInt);


#region Задание 5

string[] myArray = new string[3] {"One", "Two", "Three"};
Debug.Log(myArray[0]);
Debug.Log(myArray[1]);
Debug.Log(myArray[2]);

#region Задание 6

List<int> myList = new List<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);
Debug.Log(myList[0]);
Debug.Log(myList[1]);
Debug.Log(myList[2]);
myList.Remove(2);
myList.RemoveAt(0);

#region Задание 7

struct MyStruct
{
    public int X;
    public int Y;
}

MyStruct myStruct;
myStruct.X=10;
myStruct.Y=20;
Debug.log(myStruct.X);
Debug.log(myStruct.Y);

#region Задание 8

if (myInt > 0)
{
    Debug.Log("myInt is positive.");
}
else
{
    Debug.Log("myInt is not positive.");
}

#region Задание 9

switch (myString)
{
    case "Hello, World!":
        Debug.Log("Greeting the world.");
        break;
    case "Hello, Universe!":
        Debug.Log("Greeting the universe.");
        break;
    default:
        Debug.Log("Unknown greeting.");
        break;
}

#region Задание 10

for (int i = 0; i < myArray.Length; i++) { 
    Debug.Log(myArray[i]);
} 
while (myList.Count > 0) { 
    Debug.Log(myList[0]);
    myList.RemoveAt(0);
} 
do { 
    Debug.Log(myInt);
    myInt--;
} while (myInt > 0); 

#region Задание 11

void MyFunction() { 
    Debug.Log("This is my function.");
} 
MyFunction();

#region Задание 12

void MyFunctionWithParameters(int param1, string param2) { 
    Debug.Log("This is my function with parameters: " + param1 + ", " + param2);
MyFunctionWithParameters(myInt, myString);

#region Задание 13

int MyFunctionWithReturnValueAndParameters(int param1, int param2) { 
    return param1 + param2;
} 
int result = MyFunctionWithReturnValueAndParameters(myInt, myConstInt);
Debug.Log(result);
