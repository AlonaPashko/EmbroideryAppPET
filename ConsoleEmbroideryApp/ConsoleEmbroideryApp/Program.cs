

using ConsoleEmbroideryApp;
using FileOperationsLibrary;

Console.WriteLine("Hello, World!");

//search from threads (find if that exist and where)
SearchThread.Search(ThreadsList.Gamma, "4195");
Console.WriteLine();

//make a equivalent table manually
Dictionary<string, string> eqDMCToGamma = new Dictionary<string, string>();
eqDMCToGamma.Add("310", "0420");
eqDMCToGamma.Add("347", "0708");
eqDMCToGamma.Add("349", "0024");
eqDMCToGamma.Add("666", "0012");
eqDMCToGamma.Add("300", "0002");
eqDMCToGamma.Add("3866", "0034");
eqDMCToGamma.Add("554", "0727");
eqDMCToGamma.Add("930", "0971");
eqDMCToGamma.Add("223", "3015");
eqDMCToGamma.Add("3803", "3094");
eqDMCToGamma.Add("3834", "3102");
eqDMCToGamma.Add("327", "3108");
eqDMCToGamma.Add("939", "3120");
eqDMCToGamma.Add("154", "3237");
eqDMCToGamma.Add("161", "3242");
eqDMCToGamma.Add("647", "0152");

Console.WriteLine();
Console.WriteLine("Equivalents DMC --> Gamma:");
Console.WriteLine(Print.PrintDictionary(eqDMCToGamma));
