using System;

class Punto {  //objeto
  private int x, y;

	//var tiop static ejemplo
	private static int contadorDeobjetos = 0;

//cuando hay una variable tipo const no es necesario utilizar el nombre static, el lenguaje asume que toda variable const es de tipo static.

    //destino
    public Punto(int x, int y){//constructor
    this.x = x;
    this.y = y;
		contadorDeobjetos++;
  }  
  //origen
  public Punto(){//constructor por defecto
    this.x = 0;
    this.y = 0;
		contadorDeobjetos++;
  }

  public double DistanciaHasta(Punto otroPunto){
    int xDif = this.x - otroPunto.x;
    int yDif = this.y - otroPunto.y;

    double distanciaPuntos = Math.Sqrt(Math.Pow(xDif,2) + Math.Pow(yDif, 2));

		return distanciaPuntos;
  }
	
	public static int ContadorDeObjetos() => contadorDeobjetos;

}
