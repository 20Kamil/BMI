using System;

class Program
{
    static void Main()
    {
        // Dane użytkownika
        Console.Write("Podaj wagę [kg]: ");
        double wagaKg = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wzrost [cm]: ");
        double wzrostCm = Convert.ToDouble(Console.ReadLine());

        // Konwersja wzrostu do metrów
        double wzrostM = wzrostCm / 100;

        // Obliczenia BMI
        double bmi = wagaKg / (wzrostM * wzrostM);

        // Wyświetlenie wyniku w konsoli
        Console.WriteLine($"Twoje BMI wynosi: {bmi:F2}");

        // Interpretacja wyniku
        InterpretujBMI(bmi);

        // Oczekanie na naciśnięcie klawisza przed zamknięciem konsoli
        Console.ReadKey();
    }

    static void InterpretujBMI(double bmi)
    {
        Console.Write("Interpretacja BMI: ");

        if (bmi < 18.5)
            Console.WriteLine("Niedowaga");
        else if (bmi >= 18.5 && bmi < 24.9)
            Console.WriteLine("Prawidłowa waga");
        else if (bmi >= 25 && bmi < 29.9)
            Console.WriteLine("Nadwaga");
        else
            Console.WriteLine("Otyłość");
    }
}
