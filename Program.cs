// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Beep();;
Console.WriteLine("{0} {1}",float.MaxValue,float.MinValue);


//_____Type conversion_____//

int i =1000;
byte b= (byte)i;
//here i will loose data because the byte can only store untel 255
System.Console.WriteLine(b);

//____CONVERT STRING TO NUMBER___//

var number ="1234";
int inte = Convert.ToInt32(number);
System.Console.WriteLine("Number+Number:{0} Inte+inte:{1}",number+number,inte+inte);

//__CURIOSITY ABOUT A++_____/

var a = 1;
var bb = a++; //modifies a but bb takes the value of former a
var c=++a; //modifies a again and takes the value of last a

System.Console.WriteLine("a:{0} b:{1} c:{2}",a,bb,c);