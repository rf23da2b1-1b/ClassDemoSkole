// See https://aka.ms/new-console-template for more information
using ClassDemoSkole;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");


int i = 9;
// type variabelnavn lig med værdi

// samme gælder for klasser og objekter

Laerer peter = new Laerer();
//peter.Navn = "Peter";
//peter.Uddannelse = "KU";
//peter.Viden = "Masser";
//peter.Alder = 65;

Console.WriteLine(peter);


Laerer jakob = new Laerer("Jakob","ITU","Masser",41);

//jakob.Navn = "Jakob";
//jakob.Uddannelse = "ITU";
//jakob.Viden = "Masser";
//jakob.Alder = 41;

Console.WriteLine(jakob);