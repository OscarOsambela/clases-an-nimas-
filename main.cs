using System;
using static System.Math;

class MainClass {
  public static void Main (string[] args) {
    //realizarTarea();  c

    //ejemplo de clase anonima
    //no llevan nombre

    //instancia de primer objeto 
    var miVar = new {Nombre = "Juan", Edad = 19};
    //llamada correcta a la clase
    Console.WriteLine(miVar.Nombre + " " + miVar.Edad); 

    //instancia de segundo objeto
    var otraVar = new { Nombre = "Ana", Edad = 20};
    Console.WriteLine(otraVar.Nombre + " " + otraVar.Edad + " " + otraVar.Peso);

    //Como sabe el compilador que los objetos pertenecen a la misma clase?
    //por numero de campos, tipo de campos, orden de campos de cada objeto si son iguales lo tomará de la misma clase
    miVar = otraVar;



    //las clases anónimas:
    //Solo pueden tener campos públicos
    //Todos los campos deben estar iniciados
    //los campos no pueden ser static
    //no se pueden definir métodos
    //son más útiles cuando utilicemos las queries
       
  }


}