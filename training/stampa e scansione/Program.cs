// per stampare bisogna scrivere questo comando, in questo caso WriteLine oltre a stampare manda a capo la riga
Console.WriteLine("ciao mondo");



// per stampare senza andare a capo bisogna scrivere solo console.Write come qui sotto
Console.Write("hello barille");




// per stampare una variabile si fa in questo modo
int a = 5;
Console.WriteLine(a); //5



// si possono stampare variabile e frase nella stessa riga di codice in questi 2 modi
// per poter stampare qualcosa che contenga altro senza fare altre righe di codice bisogna scrivere nel seguente modo
// primo metodo brutto e poco usato che si chiama string concatenation
Console.WriteLine("giglo " + a + " giglo.com");

//se volessimo stampare accanto una variabile (contenuta in una frase) un numero, si fa in questo modo
Console.WriteLine("ciao " + a + 5 + "gigolo");

// se invece dovessimo sommare una variabile dentro una stampa si fa cosi
Console.WriteLine(a + 5);


//il secondo metodo è il piu utilizzato e si chiama macro
Console.WriteLine("giglo {0}",a);