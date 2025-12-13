using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var imagesDirectory = "/Users/mathiasbrevik/Documents/VScode Projects/daniel_eksamen/frontend/public/players";
        var imageBasePath = "/players";

        var files = Directory.GetFiles(imagesDirectory, "*.jpg");
        var random = new Random();

        string[] positions = { "Point Guard", "Shooting Guard", "Small Forward", "Power Forward", "Center" };

        string[] otherCountries = {
            "France", "Canada", "Netherlands", "Serbia",
            "Slovakia", "Ukraine", "Australia", "China"
        };

        Console.WriteLine("new Athlete[]");
        Console.WriteLine("{");

        foreach (var file in files)
        {
            var fileName = Path.GetFileName(file);
            var nameWithoutExt = Path.GetFileNameWithoutExtension(file);
            var parts = nameWithoutExt.Split('-', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 0)
                continue;

            var firstName = parts[0];
            var lastName = parts.Length > 1 ? string.Join(" ", parts.Skip(1)) : "";
            var fullName = (firstName + " " + lastName).Trim();

            var price = random.Next(1_000_000, 15_000_001);

            var position = positions[random.Next(positions.Length)];

            string country;
            if (random.NextDouble() < 0.8)
            {
                country = "USA";
            }
            else
            {
                country = otherCountries[random.Next(otherCountries.Length)];
            }

            int feet, inches;

            switch (position)
            {
                case "Point Guard":
                case "Shooting Guard":
                    feet = 6;
                    inches = random.Next(1, 6);      // 6'1–6'5
                    break;

                case "Small Forward":
                    feet = 6;
                    inches = random.Next(4, 9);      // 6'4–6'8
                    break;

                case "Power Forward":
                    feet = 6;
                    inches = random.Next(7, 12);     // 6'7–6'11
                    break;

                case "Center":
                    feet = random.Next(6, 8);        // 6'10–7'3 ca
                    if (feet == 6)
                        inches = random.Next(10, 12);
                    else
                        inches = random.Next(0, 4);  // 7'0–7'3
                    break;

                default:
                    feet = 6;
                    inches = random.Next(1, 11);
                    break;
            }

            // Uten tommetegn for å holde C#-koden ren: f.eks. "7'3"
            string height = $"{feet}'{inches}";

            int age = random.Next(19, 39);

            int weight = position switch
            {
                "Point Guard"      => random.Next(170, 200),
                "Shooting Guard"   => random.Next(185, 220),
                "Small Forward"    => random.Next(200, 240),
                "Power Forward"    => random.Next(220, 260),
                "Center"           => random.Next(240, 290),
                _                  => random.Next(180, 230)
            };

            var imagePath = $"{imageBasePath}/{fileName}";

            Console.WriteLine("    new Athlete");
            Console.WriteLine("    {");
            Console.WriteLine($@"        Name = ""{fullName}"",");
            Console.WriteLine(@"        Gender = ""Male"",");
            Console.WriteLine($@"        Price = {price},");
            Console.WriteLine($@"        Image = ""{imagePath}"",");
            Console.WriteLine(@"        PurchaseStatus = false,");
            Console.WriteLine($@"        Position = ""{position}"",");
            Console.WriteLine($@"        Country = ""{country}"",");
            Console.WriteLine($@"        Height = ""{height}"",");
            Console.WriteLine($@"        Age = {age},");
            Console.WriteLine($@"        Weight = {weight}");
            Console.WriteLine("    },");
        }

        Console.WriteLine("};");
    }
}
