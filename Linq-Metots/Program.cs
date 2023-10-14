using System;
using System.Linq;
using System.Collections.Generic;
using Linq_Metots;


// İlk sayı dizisi
int[] numbers1 = { 1, 2, 3, 4, 5, 6 };

        // İkinci sayı dizisi
        int[] numbers2 = { 4, 5, 6, 7, 8, 9 };

        // İki diziyi birleştirme (Concat)
        var combinedNumbers = numbers1.Concat(numbers2);

        // Tekrar eden değerleri kaldırma (Distinct)
        var distinctNumbers = combinedNumbers.Distinct();

        // Belirli bir sayı kadar elemanı atlayarak al (Skip)
        var skippedNumbers = distinctNumbers.Skip(2);

        // Belirli bir sayıda elemanı al (Take)
        var takenNumbers = skippedNumbers.Take(3);

        // Ortalama hesaplama (Average)
        double average = takenNumbers.Average();

        Console.WriteLine("Birleştirilmiş ve benzersiz değerler: " + string.Join(", ", distinctNumbers));
        Console.WriteLine("İlk 2 benzersiz değer atlandı: " + string.Join(", ", skippedNumbers));
        Console.WriteLine("Son 3 değer alındı: " + string.Join(", ", takenNumbers));
        Console.WriteLine("Alınan değerlerin ortalama: " + average);

// Bir kişi listesi oluşturma
List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 35 },
            new Person { Name = "David", Age = 40 },
            new Person { Name = "Eve", Age = 45 },
        };

// Belirli bir pozisyondaki öğeyi alma (ElementAt)
var personAtIndex = people.ElementAt(2); // İndex 2'deki kişi (Charlie)

// Öğeleri bir özelliğe göre gruplama (GroupBy)
var groupedByAge = people.GroupBy(person => person.Age);

// Bir özelliğe göre sıralanmış son öğeyi alma (Last)
var lastPerson = people.OrderBy(person => person.Age).Last(); // Yaşa göre son kişi (Eve)

// Bir özelliğe göre en büyük değeri bulma (Max)
var maxAge = people.Max(person => person.Age); // En büyük yaş (45)

Console.WriteLine("Belirli bir pozisyondaki kişi: " + personAtIndex.Name);
Console.WriteLine("Yaşa göre gruplanmış kişiler:");
foreach (var group in groupedByAge)
{
    Console.WriteLine($"Yaş: {group.Key}");
    foreach (var person in group)
    {
        Console.WriteLine($" - {person.Name}");
    }
}
Console.WriteLine("Yaşa göre son kişi: " + lastPerson.Name);
Console.WriteLine("En büyük yaş: " + maxAge);
    