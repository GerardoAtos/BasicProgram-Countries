using ConsoleApp1;

string path = "C:\\Users\\a847065\\Documents\\C#\\";
string inputFile = "countries.txt";
string outputFile = "coutries "+ DateTime.Now.ToString("yyyy-MMMM-d")+".txt";


ClassMethod obj = new ClassMethod();
obj.GreetCountries(inputFile, outputFile, path);