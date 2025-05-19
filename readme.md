# Practica C#

> Introducing Functional Programming Using C# Leveraging a New Perspective for OOP Developers (Vaskaran Sarcar) (Z-Library)


## Delegados

* Un Action es un delegado: encapsula un metodo void:
```csharp
public static Action<int> myAct = (x) => 
  Console.WriteLine($"\n{DateTime.Now.AddDays(x)}\n");
```

* Un Func es un delegado: encapsula un metodo con retorno:
```csharp
public static Func<int, double> myFunc = (x) => x * Math.PI;
```

## Foreach para listas

```csharp
List<int> numsAleatorios = new();
Random numale = new();
for (int i = 0; i < 10; i++)
{
  numsAleatorios.Add(numale.Next(0, 10));
}
numsAleatorios.ForEach(Console.WriteLine);
```

## Func y captura por consola
```csharp
Func<int, int> myFunc = (z) => z * 2;

Console.Write($"Ingresa un numeró: ");
var tmp = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"Resultado: {myFunc(tmp)}");
```
## Fin

> Test Your Skills in C Programming Review and Analyze Important Features of C# (Vaskaran Sarcar)

## Estructura
* Es un tipo de dato y al igual que las clases tienen campos, propiedades y metodos. 
* No permite herencia. La estructura es tipo valor(stack), las clases son de tipo referencia(heap). 
* Es más rápida que la clase.
* No pueden ser nulos a menos que se declaren como tal.
```csharp
public struct Empleados
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Empleados(int id, string name)
        {
            this.Id = id;
            this.Nombre = name;
        }
    }

// Implementación
    List<Empleados> empleados = new();
        empleados.Add(new Empleados(1, "Gabriela"));
        empleados.Add(new Empleados(2, "Stephanie"));
        empleados.Add(new Empleados(3, "Diana"));

        empleados
        .ForEach(
            x =>
            Console.WriteLine(
                $"Id: {x.Id} - Nombre: {x.Nombre}"
                ));
```
Los record tambien son estructuras:
```csharp
record MiEmpleado(int Id, string Nombre, DateTime FecCont);

// Implementación
List<MiEmpleado> misEmpleados = new();

misEmpleados.Add(new MiEmpleado(1, "Karen", DateTime.Now));
misEmpleados.Add(new MiEmpleado(2, "Liliana", DateTime.Now));

misEmpleados
  .ForEach(
    i =>
    Console.WriteLine(
      $"id: {i.Id} - Nombre: {i.Nombre} - Fecha: {i.FecCont}")
    );
```

## Clases y Objetos
* Una clase es una plantilla y un objeto es una instancia de una clase.
* Un constructor se usa para inicializar un objeto.


## sealed (Sellado)

## overloading (Sobrecarga)

## overriding (Anulación)

## covariancia y contravariancia

## Polimorfismo
* Significa muchas formas. Un mismo metodo puede tener diferentes comportamientos. Se basa en que permite que las clases derivadas implementen el mismo metodo de formas diferentes.
* Un metodo virtual puede ser sobre-escrito (overridden) en una clase derivada en donde se debe usar override.

## Abstracciones
* Un metodo es abstracto si solo tiene firma y no tiene definición.
* El modificador abstract en la clase se refire a que hay al menos un método con información incompleta.
* Como esta incompleta no es posible crear instancias de ella.
* Una clase hija debe completar la información faltante en los metodos de lo contrario tambien sería otra clase abstracta.
* La clase y el metodo padre deben ser mmarcados como abstract. La clase hija deben usar override.

## Inteface
* Define funcionalidades sin especificar su implementación.
* Solo los miembros privados tiene implementación por defecto.
* La abstraccion si tiene implementaciones, la interfaz colo firmas.
* Una interfaz no puede heredar de una clase abstracta, lo contrario si es posible.
* Si se tiene comportamientos por defecto o se requieren campos en común usar una clase abstracta.
* Interfaz siempre que se tenga herencia multiple.
* Permite escribir codigo polimorfico.
* Desarrollar sistemas debilmente acoplados.
* Da soporte para programación paralela.


## Fin