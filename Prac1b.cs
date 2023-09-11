using System;

namespace Practical1b
{
     class prac1b{
	static void Main(string[] args){
	   string s1 ="Gaurav";
	   string s2 ="  Tukrul  ";
	   Console.WriteLine("first String: "+s1);
	   Console.WriteLine("Second String: "+s2);
	   int len = s1.Length;
	   Console.WriteLine("Length of first string: "+len);
	   string joinedString = string.Concat(s1, s2);
     	   Console.WriteLine("Joined string: " + joinedString);
	   string strclone =(String)s1.Clone();
           Console.WriteLine(" Clone of first String :"+ strclone);
	   Console.WriteLine("Comparing Two String:"+string.Compare(s1,s2)); 
	   Console.WriteLine("Copy of Second String :"+string.Copy(s2));
	   String  s3="rul";
	   Console.WriteLine(s2.EndsWith(s3)); 
	   Console.WriteLine("Index of u:"+s1.IndexOf('u'));
	   Console.WriteLine("First String in Lowercase :"+ s1.ToLower()); 
           Console.WriteLine("First String in uppercase :"+ s1.ToUpper()); 
	   Console.WriteLine("Trim :"+ s2.Trim());
	   Console.WriteLine("Trim Start :"+ s2.TrimStart());
	   Console.WriteLine("Trim End :"+ s2.TrimEnd());
	   Console.WriteLine("Replace :"+ s2.Replace("rul","RUL"));  
           Console.WriteLine("Subtring of first String  :"+ s2.Substring(5));
	   Console.WriteLine("Remove  :"+ s2.Remove(4));
	
}
}
}