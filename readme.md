# Practica C#

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

## Estructura
Es un tipo de dato y al igual que las clases tienen campos, propiedades y metodos. No permite herencia. La estructura es tipo valor(stack), las clases son de tipo referencia(heap). Es más rápida que la clase. Todo es public. No pueden ser nulos a menos que se declaren como tal.
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