
Alumno alumno1 =new Alumno(); 
// CUANDO HACEMOS EL NEW LLAMAMOS AL CONSTRUCTOR.
// TIPO ALUMNO1(NOMBRE OBJETO) = NEW ALUMNO (INSTANCIA DE UNA CLASE (LE ASIGNA ESPACIO DE MEMORIA) / DE NUEVO EL TIPO)
// CREA UNA NUEVA INSTANCIA DE LA CLASE ALUMNO 
// FORMA CLASICA/ ORIGINAL / ESQUEMA CLASICO.
// CREA UNA NUEVA INSTANCIA DE LA CLASE ALUMNO, PERO CON ESTE COSTRUCTOR ()
// ALUMNO1 ES EL OBJETO. (OBJETO --> INSTANCIA DE CLASE)

alumno1.Nombre="Laura"; 
alumno1.Apellido="Alonso";


var alumno2=new Alumno(); // FORMA TRADICIONAL (CON EL VAR ADELANTE) VARIABLE AUTOINFERIDA (INFIERA LO QUE VA
// AL LADO) INFIERE LO QUE HAY DE ESTE LADO. DETECTA/INFIERA. DETECTA LO QUE HAY DEL OTRO LADO DEL IGUAL.
alumno2.Nombre="Marina";
alumno2.Apellido="Lopez";
 
alumno1.Metodo1(); // NO ME DEVUELVE NADA (VOID) ASIGNAR VALOR
//Console.WriteLine( alumno1.Metodo2()); (ME DEVUELVE STRING/ "esto es una clave") DEVUELVE VALOR
alumno1.Clave="nueva clave"; //set  documento=value
Console.WriteLine(alumno1.Clave); //get return claveguardada
alumno1.DNI=222222; //set
Console.WriteLine(alumno1.DNI); //get

var alumno3=new Alumno(); // new = lLamo al constructor = en este caso no tiene parametros
Console.WriteLine(alumno3.Apellido); // GET (OBTENGO)

var alumno4=new Alumno("Lucas"); // ESPERA UN STRING, CUANDO EL STRING SE LO ASIGNA AL NOMBRE.
Console.WriteLine(alumno4.Nombre);

var alumno5=new Alumno(44444);
Console.WriteLine(alumno5.DNI);

var Alumno20 = new Alumno(456677);
Console.WriteLine("Numero de documento del Alumno 20: " + Alumno20.DNI);

var alumno6=new Alumno("Micaela","Martinez");
var alumno7=new Alumno("Luciano","Rosas",32831);
Console.WriteLine($"nombre: {alumno7.Nombre} apellido {alumno7.Apellido} dni: {alumno7.DNI}");

class Alumno{
    public Alumno(){ // PUBLIC Y EL NOMBRE DE LA CLASE // CONSTRUCTOR DEFAULT.
        Apellido="Rosso"; // CONSTRUCTUR POR DEFAULT LE ASIGNE EL VALOR.
    }

    public Alumno(string nombreinicial){// CONSTRUCTOR CON PARAMETRO --  
        Nombre=nombreinicial;
        /*
        var alumno4=new Alumno("Lucas"); 
        Console.WriteLine(alumno4.Nombre);
        */
    }

    // REUTILIZACION DE CODIGO EN LOS CONSTRUCTORES (DE UNA MANERA MAS RESUMIDA)
    // UTILIZAMOS EL MODIFICADOR THIS.

    
    public Alumno(int documentooriginal){
        documento=documentooriginal; // SE PUEDEN ASIGNAR TANTO A CAMPOS (QUE SON PRIVADOS) COMO PROPIEDADES
    }

    public Alumno(string nombreinicial,string apellidoinicial){ // OTRO CONSTRUCTOR CON OTRA SOBRECARGA.
        Nombre=nombreinicial;
        Apellido=apellidoinicial; 
    }
    public Alumno(string nombreinicial,string apellidoinicial,int doc) :this(nombreinicial,apellidoinicial) {
 
        documento=doc;
    }
    public Alumno(string nombre,string apell,string domic,int dni):this(nombre,apell,dni){ 
        Domicilio=domic;
    }
    public Alumno(string nombre,string apell,string domic){
        Apellido=apell;
        Nombre=nombre;
        Domicilio=domic;
    }
    // ATRIBUTOS.
    // CAMPOS ALMACENAN ESE ESTADO (POR DEFINICION LOS CAMPOS SON PRIVADOS) PRIVADO DESDE AFUERA NO LO PUEDO VER.
    public string Domicilio {get;set;}
    private string claveguardada; // PRIVADO DESDE AFUERA NO LO PUEDO VER / PRIVADO AL AMBITO DE DONDE LO DECLARO.
    // SI CREO OTRA CLASE TAMPOCO LA VOY A PODER VER, NI TAMPOCO DESDE FUERA DE LA CLASE, NI DESDE EL PROGRAMA
    // SU UTILIZACION SOLO DENTRO DE ESTA CLASE (private string claveguarda; SOLO DESDE CLASE ALUMNO)
    private int documento;
    public int DNI {
        get{ return documento;}
        set{ documento=value;} // Ejmplo de una propiedad con cuerpo.
    }

    public string Clave{
        get{ return claveguardada;} // GET (OBTENER VALOR) Console.WriteLine(alumno1.Clave); //get return claveguardada
        set{ claveguardada=value;} // SET ( SETEAR EL VALOR ) alumno1.Clave="nueva clave"; //set  documento=value
        // CREAMOS METODOS DE ACCESO QUE ES UNA PROPIEDAD PARA PODER DESDE AFUERA A ESE CAMPO QUE ES PRIVADO.
    }
    public string Nombre{get;set;} // Un ejemplo de una propiedad autoimentada sin definir una campo privado con minuscula.

    public string Apellido {get;set;} // MIEMBROS DE CLASE QUE SE LLAMAN PROPIEDADES.

/*  TODO LO QUE DENTRO DE CLASE (MIEMBROS DE LA CLASE)

    private string apellido;
    public string Apellido{
        get{return apellido;}
        set{apellido=value;}
    }
*/
    public void Metodo1(){
        claveguardada="esta es una clave";
        // PRIVADO EN ESTA CLASE.
    }

    public string Metodo2(){
        return claveguardada;
        // YO ESPECIFIQUE QUE LA QUIERO DEVOLVER.
        // AHORA SI MOSTRARLO
        // AL DECLARAR ESTE METODO SI ME PERMITE ACCEDER DESDE AFUERA Y ME DEVUELVE UN STRING.
    }

}

//Acciones interactuar con ese objeto (metodo 1 y metodo 2) por ejemplo acelerar frenar (metodos)
// en el objeto auto.

/*

CLASE MOLDE (--> CREACION DE DISTINTOS OBJETOS)

OBJETO --> INSTANCIA DE UNA CLASE.

--HERENCIA. PADRE E (DERIVADAS) HIJAS.

--POLIMORFISMO. AUTO ES UN TRANSPORTE, COHETE ES UN TRANSPORTE, CABALLO ES UN TRANSPORTE, CADA UNO TENDRA
SU FORMA DE COMPORTAMIENTO, CADA UNO A SU MANERA.

--ENCAPSULAMIENTO. (METER DENTRO UN BLOQUE, LO TRATAMOS COMO CAJA NEGRA (ENTRE Y SALIDA, NO SABEMOS
LO QUE PASA ADENTRO.))
ACELERACION DE UN AUTO (NO SABEMOS CUALES SON LAS ACCIONES INTERNAS) ACCION DE ACELERAR PERO OCULTA
LA IMPLEMENTACION / OCULTAR EL FUNCIONAMIENTO INTERNO DE UNA COSA / MTERLA EN UNA CASA NEGRA)

--ABSTRACCION. (DECIDE QUE ES IMPORTANTE Y QUE NO)
--> SE ENFOCA EN LO QUE ES IMPORTANTE // IGNORA DE LO QUE NO ES IMPORTANTE.

---------------------
MIEMBROS DE UNA CLASE
---------------------
csproj (informacion de todo el proyecto)

PRIVADO PUBLICO (MODIFICADORES DE ACCESIBILIDAD)
PUBLICO : DESDE TODOS LOS LUGARES
PRIVADO : SOLO SE PUEDE VER DESDE EL AMBITO DONDE LO CREE.

PRIVATE STRING NOMBRE (PRIVADO (MODIFICADOR DE ACCES.), TIPO, Y EL NOMBRE) POR DEFINICION SON PRIVADOS.

VOID : NO ME DEVUELVE NADA.

getters y setters (propiedades) me sirve para acceder a campos que por definicion son privados.

PARA ACCEDER A UN CAMPO QUE ES PRIVADO DEBO HACERLO A TRAVES DE LA PROPIEDAD
---> POR ESO CREAMOS UN METODO DE ACCESO CON LA PROPIEDAD.

CREAMOS PROPIEDADES PARA PODER ACCEDER A LOS CAMPOS QUE POR DEFINICION SON PRIVADOS

-----------------

PARA ACCEDER DESDE AFUERA AL CAMPO PRIVADO TENGO QUE PASAR POR LA PROPIEDAD.
get (desde afuera) hace un llamado a la propiedad (intermediador) DNI. ---DNI SE ENCARGAR DE IR AL
CAMPO donde esta lo que quiero obtener. Vuelve a la propiedad y de la propiedad se va a la parte
de afuera (donde esta el get).


///////////////////////////////////////////////////////////////////////////////////////////////////////////////
PROPIEDADES ES INTERMEDIARIO PARA QUE DESDE AFUERA PUEDAN ACCEDER A LOS COMPOS QUE PON DEFINICION SON PRIVADOS
///////////////////////////////////////////////////////////////////////////////////////////////////////////////

IDEM SET.

 CAMPOS PRIVADOS POR DEFINICION  //// PROPIEDADES (INTERMEDIARIO) ///  (((GET / SET))))
 MANERA CLASICA (ES SOLO PARA ENTERDER QUE SE ESTA HACIENDO)


 PUBLIC STRING ALUMNO (PROPIEDAD AUTOIMPLEMENTADA)

--------------------------
 CONSTRUCTOR SIRVE PARA INICILIZAR VALORES
 CUANDO HACEMOS EL NEW LLAMAMOS AL CONSTRUCTOR.

 CONSTRUCTOR SIN PARAMETROS (DEFAULT)
 CONSTRUCTORES CON PARAMETROS.

 ----------------
 CONSTRUCTORES (SIEMPRE VA A MACHEAR POR TIPO)

 --------------------
 REUTILIZACION DE CONSTRUCTORES {----,-----,-----} this {-----,------}
 this hace referencia a la misma clase.

*/