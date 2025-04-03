# 🔠 Detect Capital

Este é um projeto em C# que verifica se o uso de letras maiúsculas em uma palavra está correto. O programa segue três regras principais para considerar uma palavra válida:

1️⃣ Todas as letras são maiúsculas (exemplo: `"USA"`).  
2️⃣ Todas as letras são minúsculas (exemplo: `"hello"`).  
3️⃣ Apenas a primeira letra é maiúscula (exemplo: `"Hello"`).  

## 🚀 Como Funciona?

A função `DetectCapitalUse(string word)` analisa a palavra fornecida e retorna `true` se a formatação estiver correta de acordo com as regras acima. Caso contrário, retorna `false`.

## 📌 Exemplo de Uso

```csharp
Solution solution = new Solution();

Console.WriteLine(solution.DetectCapitalUse("USA"));   // true
Console.WriteLine(solution.DetectCapitalUse("FlaG"));  // false
Console.WriteLine(solution.DetectCapitalUse("Hello")); // true
Console.WriteLine(solution.DetectCapitalUse("java"));  // true
```

## 🛠️ Tecnologias Utilizadas

- C#
- .NET 5

## 📜 Licença  

Este projeto está sob a licença MIT. Sinta-se à vontade para usar e modificar.  
