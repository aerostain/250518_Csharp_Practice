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
