using System.Collections;

//ask user for input, store input in a string
Console.WriteLine("Enter a string");
string input = Console.ReadLine();

Console.WriteLine(reverse(input));


//method
//create a stack, add into stack, take everything out and reverse

static string reverse(string word)
{   
    string reversedStr = "";
    Stack myStack = new Stack();

    foreach (char s in word)
    {
        myStack.Push(s);
    }

    while (myStack.Count > 0)
    {
        reversedStr += myStack.Pop();
    }
    return reversedStr;
}



















//static String reverse(String str)
//{
//    char[] charArr = str.ToCharArray();
//    int size = charArr.Length;
//    Stack stack = new Stack(size);

    
//    for (int i = 0; i < size; ++i)
//    {
//        stack.Push(charArr[i]);
//    }

//    for (int j = 0; j < size; ++j)
//    {
//        charArr[j] = (char)stack.Pop();
//    }

//    return String.ValueOf(charArr);
//}













//static string reverse (string word)
//{
//    char[] chars = word.ToCharArray ();
//    int arraySize = chars.Length;
//    Stack stack = new System.Collections.Generic.Stack(arraySize);

//    for (int i = 0; i < chars.Length; i++)
//    {
//        stack.Push (chars[i]);
//    }
//    return 
//}