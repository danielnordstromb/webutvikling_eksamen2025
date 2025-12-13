using backend.Models;

namespace backend.Data;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        // Sørg for at DB finnes
        context.Database.EnsureCreated();

        // Hvis det allerede finnes data, gjør ingenting
        if (!context.Finances.Any())
        {
            context.Finances.Add(new Finance
            {
                MoneyLeft = 1_000_000,
                MoneySpent = 0,
                NumberOfPurchases = 0
            });
        }

        if (!context.Athletes.Any())
        {
            context.Athletes.AddRange(
                new Athlete
                {
                    Name = "Clint Ndumbacapela",
                    Gender = "Male",
                    Price = 2562188,
                    Image = "/players/Clint-Ndumbacapela.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 22,
                    Weight = 226
                },
                new Athlete
                {
                    Name = "Max Strus",
                    Gender = "Male",
                    Price = 2699504,
                    Image = "/players/Max-Strus.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "Slovakia",
                    Height = "6'10",
                    Age = 25,
                    Weight = 272
                },
                new Athlete
                {
                    Name = "Tyler Herro",
                    Gender = "Male",
                    Price = 11520884,
                    Image = "/players/Tyler-Herro.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'1",
                    Age = 32,
                    Weight = 277
                },
                new Athlete
                {
                    Name = "Mouhamed Gueye",
                    Gender = "Male",
                    Price = 14849461,
                    Image = "/players/Mouhamed-Gueye.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "Slovakia",
                    Height = "6'7",
                    Age = 26,
                    Weight = 222
                },
                new Athlete
                {
                    Name = "Deandre Hunter",
                    Gender = "Male",
                    Price = 8885600,
                    Image = "/players/Deandre-Hunter.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 27,
                    Weight = 177
                },
                new Athlete
                {
                    Name = "Leaky Black",
                    Gender = "Male",
                    Price = 14167109,
                    Image = "/players/Leaky-Black.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 33,
                    Weight = 176
                },
                new Athlete
                {
                    Name = "Dejounte Murray",
                    Gender = "Male",
                    Price = 8538258,
                    Image = "/players/Dejounte-Murray.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 37,
                    Weight = 198
                },
                new Athlete
                {
                    Name = "Deaaron Fox",
                    Gender = "Male",
                    Price = 8354742,
                    Image = "/players/Deaaron-Fox.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'3",
                    Age = 31,
                    Weight = 248
                },
                new Athlete
                {
                    Name = "Zion Williamson",
                    Gender = "Male",
                    Price = 5914838,
                    Image = "/players/Zion-Williamson.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 37,
                    Weight = 218
                },
                new Athlete
                {
                    Name = "Amen Thompson",
                    Gender = "Male",
                    Price = 4845171,
                    Image = "/players/Amen-Thompson.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 32,
                    Weight = 232
                },
                new Athlete
                {
                    Name = "Walker Kessler",
                    Gender = "Male",
                    Price = 13446471,
                    Image = "/players/Walker-Kessler.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "France",
                    Height = "6'5",
                    Age = 26,
                    Weight = 211
                },
                new Athlete
                {
                    Name = "Shai Gilgeousalexander",
                    Gender = "Male",
                    Price = 1133398,
                    Image = "/players/Shai-Gilgeousalexander.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 35,
                    Weight = 204
                },
                new Athlete
                {
                    Name = "Russell Westbrook",
                    Gender = "Male",
                    Price = 7874161,
                    Image = "/players/Russell-Westbrook.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 36,
                    Weight = 246
                },
                new Athlete
                {
                    Name = "Mamadi Diakite",
                    Gender = "Male",
                    Price = 9832375,
                    Image = "/players/Mamadi-Diakite.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 35,
                    Weight = 195
                },
                new Athlete
                {
                    Name = "Domantas Sabonis",
                    Gender = "Male",
                    Price = 3168978,
                    Image = "/players/Domantas-Sabonis.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 34,
                    Weight = 212
                },
                new Athlete
                {
                    Name = "Kyrie Irving",
                    Gender = "Male",
                    Price = 14659228,
                    Image = "/players/Kyrie-Irving.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Canada",
                    Height = "6'4",
                    Age = 36,
                    Weight = 206
                },
                new Athlete
                {
                    Name = "Malaki Branham",
                    Gender = "Male",
                    Price = 1168213,
                    Image = "/players/Malaki-Branham.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 28,
                    Weight = 216
                },
                new Athlete
                {
                    Name = "Josh Giddey",
                    Gender = "Male",
                    Price = 10766983,
                    Image = "/players/Josh-Giddey.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Australia",
                    Height = "6'4",
                    Age = 35,
                    Weight = 225
                },
                new Athlete
                {
                    Name = "Julian Champaignie",
                    Gender = "Male",
                    Price = 12171823,
                    Image = "/players/Julian-Champaignie.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 20,
                    Weight = 203
                },
                new Athlete
                {
                    Name = "Bruce Brown",
                    Gender = "Male",
                    Price = 11998262,
                    Image = "/players/Bruce-Brown.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 36,
                    Weight = 206
                },
                new Athlete
                {
                    Name = "Charles Bassey",
                    Gender = "Male",
                    Price = 8625482,
                    Image = "/players/Charles-Bassey.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 27,
                    Weight = 226
                },
                new Athlete
                {
                    Name = "Jalen Green",
                    Gender = "Male",
                    Price = 8605472,
                    Image = "/players/Jalen-Green.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 38,
                    Weight = 258
                },
                new Athlete
                {
                    Name = "Jaden Mcdaniels",
                    Gender = "Male",
                    Price = 3032301,
                    Image = "/players/Jaden-Mcdaniels.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 22,
                    Weight = 222
                },
                new Athlete
                {
                    Name = "Gradey Dick",
                    Gender = "Male",
                    Price = 7844693,
                    Image = "/players/Gradey-Dick.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 33,
                    Weight = 256
                },
                new Athlete
                {
                    Name = "Jonathan Isaac",
                    Gender = "Male",
                    Price = 10022510,
                    Image = "/players/Jonathan-Isaac.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 32,
                    Weight = 199
                },
                new Athlete
                {
                    Name = "Collin Sexton",
                    Gender = "Male",
                    Price = 1307215,
                    Image = "/players/Collin-Sexton.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'1",
                    Age = 37,
                    Weight = 258
                },
                new Athlete
                {
                    Name = "Stephen Curry",
                    Gender = "Male",
                    Price = 5690372,
                    Image = "/players/Stephen-Curry.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Australia",
                    Height = "6'5",
                    Age = 21,
                    Weight = 222
                },
                new Athlete
                {
                    Name = "Mike Conley",
                    Gender = "Male",
                    Price = 7572683,
                    Image = "/players/Mike-Conley.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "Serbia",
                    Height = "6'10",
                    Age = 33,
                    Weight = 242
                },
                new Athlete
                {
                    Name = "Jalen Johnson",
                    Gender = "Male",
                    Price = 5635949,
                    Image = "/players/Jalen-Johnson.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 37,
                    Weight = 241
                },
                new Athlete
                {
                    Name = "Javon Freemanliberty",
                    Gender = "Male",
                    Price = 4313549,
                    Image = "/players/Javon-Freemanliberty.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 38,
                    Weight = 192
                },
                new Athlete
                {
                    Name = "Julian Phillips",
                    Gender = "Male",
                    Price = 5956151,
                    Image = "/players/Julian-Phillips.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 19,
                    Weight = 199
                },
                new Athlete
                {
                    Name = "Peyton Watson",
                    Gender = "Male",
                    Price = 10258781,
                    Image = "/players/Peyton-Watson.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 34,
                    Weight = 239
                },
                new Athlete
                {
                    Name = "Torrey Craig",
                    Gender = "Male",
                    Price = 5296412,
                    Image = "/players/Torrey-Craig.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 38,
                    Weight = 188
                },
                new Athlete
                {
                    Name = "Lindy Waters",
                    Gender = "Male",
                    Price = 5417140,
                    Image = "/players/Lindy-Waters.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 28,
                    Weight = 282
                },
                new Athlete
                {
                    Name = "Jaden Hardy",
                    Gender = "Male",
                    Price = 6444957,
                    Image = "/players/Jaden-Hardy.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Australia",
                    Height = "6'8",
                    Age = 23,
                    Weight = 216
                },
                new Athlete
                {
                    Name = "Keyonte George",
                    Gender = "Male",
                    Price = 6342794,
                    Image = "/players/Keyonte-George.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'3",
                    Age = 26,
                    Weight = 265
                },
                new Athlete
                {
                    Name = "Ja Morant",
                    Gender = "Male",
                    Price = 4608866,
                    Image = "/players/Ja-Morant.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'3",
                    Age = 19,
                    Weight = 271
                },
                new Athlete
                {
                    Name = "Kris Murray",
                    Gender = "Male",
                    Price = 7912455,
                    Image = "/players/Kris-Murray.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 38,
                    Weight = 240
                },
                new Athlete
                {
                    Name = "PJ Washington",
                    Gender = "Male",
                    Price = 6940498,
                    Image = "/players/PJ-Washington.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 21,
                    Weight = 183
                },
                new Athlete
                {
                    Name = "Trayce Jacksondavis",
                    Gender = "Male",
                    Price = 1899542,
                    Image = "/players/Trayce-Jacksondavis.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 26,
                    Weight = 180
                },
                new Athlete
                {
                    Name = "David Roddy",
                    Gender = "Male",
                    Price = 2520465,
                    Image = "/players/David-Roddy.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "China",
                    Height = "7'1",
                    Age = 22,
                    Weight = 276
                },
                new Athlete
                {
                    Name = "Ricky Council",
                    Gender = "Male",
                    Price = 6117847,
                    Image = "/players/Ricky-Council.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "France",
                    Height = "6'5",
                    Age = 33,
                    Weight = 188
                },
                new Athlete
                {
                    Name = "Jett Howard",
                    Gender = "Male",
                    Price = 8108551,
                    Image = "/players/Jett-Howard.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 24,
                    Weight = 189
                },
                new Athlete
                {
                    Name = "Maxi Kleber",
                    Gender = "Male",
                    Price = 14283470,
                    Image = "/players/Maxi-Kleber.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "Serbia",
                    Height = "6'5",
                    Age = 21,
                    Weight = 197
                },
                new Athlete
                {
                    Name = "Leonard Miller",
                    Gender = "Male",
                    Price = 8496283,
                    Image = "/players/Leonard-Miller.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'1",
                    Age = 31,
                    Weight = 282
                },
                new Athlete
                {
                    Name = "Wendell Moore",
                    Gender = "Male",
                    Price = 1648142,
                    Image = "/players/Wendell-Moore.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 34,
                    Weight = 188
                },
                new Athlete
                {
                    Name = "Jalen Bridges",
                    Gender = "Male",
                    Price = 8988259,
                    Image = "/players/Jalen-Bridges.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 29,
                    Weight = 187
                },
                new Athlete
                {
                    Name = "Kevin Durant",
                    Gender = "Male",
                    Price = 12402302,
                    Image = "/players/Kevin-Durant.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 29,
                    Weight = 224
                },
                new Athlete
                {
                    Name = "Mikal Bridges",
                    Gender = "Male",
                    Price = 1767204,
                    Image = "/players/Mikal-Bridges.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 30,
                    Weight = 285
                },
                new Athlete
                {
                    Name = "Ochai Agbaji",
                    Gender = "Male",
                    Price = 11001359,
                    Image = "/players/Ochai-Agbaji.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 37,
                    Weight = 214
                },
                new Athlete
                {
                    Name = "Kyle Kuzma",
                    Gender = "Male",
                    Price = 12305852,
                    Image = "/players/Kyle-Kuzma.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'10",
                    Age = 20,
                    Weight = 231
                },
                new Athlete
                {
                    Name = "Deandre Ayton",
                    Gender = "Male",
                    Price = 13824267,
                    Image = "/players/Deandre-Ayton.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'3",
                    Age = 34,
                    Weight = 281
                },
                new Athlete
                {
                    Name = "Ousmane Dieng",
                    Gender = "Male",
                    Price = 10087761,
                    Image = "/players/Ousmane-Dieng.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 35,
                    Weight = 230
                },
                new Athlete
                {
                    Name = "Cody Martin",
                    Gender = "Male",
                    Price = 12720088,
                    Image = "/players/Cody-Martin.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 28,
                    Weight = 182
                },
                new Athlete
                {
                    Name = "Duop Reath",
                    Gender = "Male",
                    Price = 9522012,
                    Image = "/players/Duop-Reath.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "China",
                    Height = "6'11",
                    Age = 26,
                    Weight = 232
                },
                new Athlete
                {
                    Name = "Isaiah Collier",
                    Gender = "Male",
                    Price = 1481837,
                    Image = "/players/Isaiah-Collier.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 23,
                    Weight = 195
                },
                new Athlete
                {
                    Name = "Nassir Little",
                    Gender = "Male",
                    Price = 1648792,
                    Image = "/players/Nassir-Little.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "Serbia",
                    Height = "6'3",
                    Age = 29,
                    Weight = 181
                },
                new Athlete
                {
                    Name = "Moses Moody",
                    Gender = "Male",
                    Price = 3794872,
                    Image = "/players/Moses-Moody.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 26,
                    Weight = 229
                },
                new Athlete
                {
                    Name = "Jalen McDaniels",
                    Gender = "Male",
                    Price = 6183771,
                    Image = "/players/Jalen-McDaniels.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "France",
                    Height = "6'5",
                    Age = 23,
                    Weight = 199
                },
                new Athlete
                {
                    Name = "OlivierMaxence Prosper",
                    Gender = "Male",
                    Price = 9502403,
                    Image = "/players/OlivierMaxence-Prosper.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 25,
                    Weight = 189
                },
                new Athlete
                {
                    Name = "Mason Jones",
                    Gender = "Male",
                    Price = 13104672,
                    Image = "/players/Mason-Jones.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 23,
                    Weight = 198
                },
                new Athlete
                {
                    Name = "Dyson Daniels",
                    Gender = "Male",
                    Price = 10942186,
                    Image = "/players/Dyson-Daniels.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 23,
                    Weight = 187
                },
                new Athlete
                {
                    Name = "Dalano Banton",
                    Gender = "Male",
                    Price = 12813587,
                    Image = "/players/Dalano-Banton.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 26,
                    Weight = 194
                },
                new Athlete
                {
                    Name = "Adam Flagler",
                    Gender = "Male",
                    Price = 14677058,
                    Image = "/players/Adam-Flagler.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 21,
                    Weight = 242
                },
                new Athlete
                {
                    Name = "AJ Lawson",
                    Gender = "Male",
                    Price = 10633556,
                    Image = "/players/AJ-Lawson.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 37,
                    Weight = 249
                },
                new Athlete
                {
                    Name = "Jericho Sims",
                    Gender = "Male",
                    Price = 3826377,
                    Image = "/players/Jericho-Sims.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 25,
                    Weight = 178
                },
                new Athlete
                {
                    Name = "Marcus Sasser",
                    Gender = "Male",
                    Price = 13426910,
                    Image = "/players/Marcus-Sasser.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'10",
                    Age = 37,
                    Weight = 228
                },
                new Athlete
                {
                    Name = "Darius Garland",
                    Gender = "Male",
                    Price = 14383058,
                    Image = "/players/Darius-Garland.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 24,
                    Weight = 254
                },
                new Athlete
                {
                    Name = "Donte Divincenzo",
                    Gender = "Male",
                    Price = 9513186,
                    Image = "/players/Donte-Divincenzo.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 34,
                    Weight = 226
                },
                new Athlete
                {
                    Name = "Sam Merrill",
                    Gender = "Male",
                    Price = 2746261,
                    Image = "/players/Sam-Merrill.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 28,
                    Weight = 224
                },
                new Athlete
                {
                    Name = "Bradley Beal",
                    Gender = "Male",
                    Price = 7512934,
                    Image = "/players/Bradley-Beal.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "France",
                    Height = "6'2",
                    Age = 34,
                    Weight = 178
                },
                new Athlete
                {
                    Name = "Jabari Walker",
                    Gender = "Male",
                    Price = 4918019,
                    Image = "/players/Jabari-Walker.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 36,
                    Weight = 191
                },
                new Athlete
                {
                    Name = "Dariq Whitehead",
                    Gender = "Male",
                    Price = 5036969,
                    Image = "/players/Dariq-Whitehead.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 26,
                    Weight = 234
                },
                new Athlete
                {
                    Name = "Ivica Zubac",
                    Gender = "Male",
                    Price = 11443090,
                    Image = "/players/Ivica-Zubac.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 37,
                    Weight = 176
                },
                new Athlete
                {
                    Name = "Tre Jones",
                    Gender = "Male",
                    Price = 5468543,
                    Image = "/players/Tre-Jones.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 35,
                    Weight = 224
                },
                new Athlete
                {
                    Name = "Trae Young",
                    Gender = "Male",
                    Price = 1345136,
                    Image = "/players/Trae-Young.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "France",
                    Height = "6'4",
                    Age = 32,
                    Weight = 184
                },
                new Athlete
                {
                    Name = "Ayo Dosunmu",
                    Gender = "Male",
                    Price = 8108229,
                    Image = "/players/Ayo-Dosunmu.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 36,
                    Weight = 275
                },
                new Athlete
                {
                    Name = "Jaxson Hayes",
                    Gender = "Male",
                    Price = 2251995,
                    Image = "/players/Jaxson-Hayes.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 34,
                    Weight = 218
                },
                new Athlete
                {
                    Name = "Duncan Robinson",
                    Gender = "Male",
                    Price = 2494912,
                    Image = "/players/Duncan-Robinson.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 34,
                    Weight = 185
                },
                new Athlete
                {
                    Name = "Dean Wade",
                    Gender = "Male",
                    Price = 10764821,
                    Image = "/players/Dean-Wade.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 37,
                    Weight = 190
                },
                new Athlete
                {
                    Name = "Dillon Brooks",
                    Gender = "Male",
                    Price = 12975304,
                    Image = "/players/Dillon-Brooks.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "China",
                    Height = "6'1",
                    Age = 36,
                    Weight = 217
                },
                new Athlete
                {
                    Name = "TJ McConnell",
                    Gender = "Male",
                    Price = 1657042,
                    Image = "/players/TJ-McConnell.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 25,
                    Weight = 243
                },
                new Athlete
                {
                    Name = "Scottie Barnes",
                    Gender = "Male",
                    Price = 1123993,
                    Image = "/players/Scottie-Barnes.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 25,
                    Weight = 204
                },
                new Athlete
                {
                    Name = "Andre Jackson",
                    Gender = "Male",
                    Price = 10741700,
                    Image = "/players/Andre-Jackson.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 27,
                    Weight = 258
                },
                new Athlete
                {
                    Name = "Reggie Jackson",
                    Gender = "Male",
                    Price = 5972576,
                    Image = "/players/Reggie-Jackson.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 20,
                    Weight = 229
                },
                new Athlete
                {
                    Name = "Steven Adams",
                    Gender = "Male",
                    Price = 2862210,
                    Image = "/players/Steven-Adams.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "Ukraine",
                    Height = "6'2",
                    Age = 30,
                    Weight = 192
                },
                new Athlete
                {
                    Name = "Jaime Jaquez",
                    Gender = "Male",
                    Price = 5402795,
                    Image = "/players/Jaime-Jaquez.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 21,
                    Weight = 243
                },
                new Athlete
                {
                    Name = "Lamelo Ball",
                    Gender = "Male",
                    Price = 6858130,
                    Image = "/players/Lamelo-Ball.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 20,
                    Weight = 219
                },
                new Athlete
                {
                    Name = "Keita Batesdiop",
                    Gender = "Male",
                    Price = 14883696,
                    Image = "/players/Keita-Batesdiop.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 35,
                    Weight = 186
                },
                new Athlete
                {
                    Name = "Damian Lillard",
                    Gender = "Male",
                    Price = 5327124,
                    Image = "/players/Damian-Lillard.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 24,
                    Weight = 221
                },
                new Athlete
                {
                    Name = "Marcus Smart",
                    Gender = "Male",
                    Price = 11126437,
                    Image = "/players/Marcus-Smart.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 31,
                    Weight = 214
                },
                new Athlete
                {
                    Name = "Dru Smith",
                    Gender = "Male",
                    Price = 4590861,
                    Image = "/players/Dru-Smith.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 31,
                    Weight = 194
                },
                new Athlete
                {
                    Name = "Jarrett Allen",
                    Gender = "Male",
                    Price = 12115912,
                    Image = "/players/Jarrett-Allen.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 35,
                    Weight = 211
                },
                new Athlete
                {
                    Name = "Naz Reid",
                    Gender = "Male",
                    Price = 11125752,
                    Image = "/players/Naz-Reid.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "Australia",
                    Height = "6'4",
                    Age = 30,
                    Weight = 202
                },
                new Athlete
                {
                    Name = "Jason Preston",
                    Gender = "Male",
                    Price = 11167101,
                    Image = "/players/Jason-Preston.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 36,
                    Weight = 243
                },
                new Athlete
                {
                    Name = "Bobby Portis",
                    Gender = "Male",
                    Price = 2297338,
                    Image = "/players/Bobby-Portis.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 25,
                    Weight = 189
                },
                new Athlete
                {
                    Name = "Robert Williams",
                    Gender = "Male",
                    Price = 6202011,
                    Image = "/players/Robert-Williams.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 24,
                    Weight = 288
                },
                new Athlete
                {
                    Name = "Keldon Johnson",
                    Gender = "Male",
                    Price = 10725599,
                    Image = "/players/Keldon-Johnson.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 38,
                    Weight = 256
                },
                new Athlete
                {
                    Name = "Rui Hachimura",
                    Gender = "Male",
                    Price = 1017045,
                    Image = "/players/Rui-Hachimura.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 27,
                    Weight = 197
                },
                new Athlete
                {
                    Name = "Jalen Brunson",
                    Gender = "Male",
                    Price = 13123831,
                    Image = "/players/Jalen-Brunson.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 21,
                    Weight = 211
                },
                new Athlete
                {
                    Name = "Nick Walker",
                    Gender = "Male",
                    Price = 7821679,
                    Image = "/players/Nick-Walker.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 29,
                    Weight = 222
                },
                new Athlete
                {
                    Name = "Kobe Bufkin",
                    Gender = "Male",
                    Price = 4471208,
                    Image = "/players/Kobe-Bufkin.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 26,
                    Weight = 210
                },
                new Athlete
                {
                    Name = "Pat Connaughton",
                    Gender = "Male",
                    Price = 1738039,
                    Image = "/players/Pat-Connaughton.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 28,
                    Weight = 228
                },
                new Athlete
                {
                    Name = "Dalen Terry",
                    Gender = "Male",
                    Price = 2025051,
                    Image = "/players/Dalen-Terry.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 24,
                    Weight = 217
                },
                new Athlete
                {
                    Name = "Jock Landale",
                    Gender = "Male",
                    Price = 11468338,
                    Image = "/players/Jock-Landale.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 36,
                    Weight = 185
                },
                new Athlete
                {
                    Name = "Giannis Antetokounmpo",
                    Gender = "Male",
                    Price = 11105184,
                    Image = "/players/Giannis-Antetokounmpo.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 23,
                    Weight = 252
                },
                new Athlete
                {
                    Name = "Grant Williams",
                    Gender = "Male",
                    Price = 1348259,
                    Image = "/players/Grant-Williams.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 25,
                    Weight = 186
                },
                new Athlete
                {
                    Name = "Andrew Nembhard",
                    Gender = "Male",
                    Price = 12231638,
                    Image = "/players/Andrew-Nembhard.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 32,
                    Weight = 177
                },
                new Athlete
                {
                    Name = "Jamal Murray",
                    Gender = "Male",
                    Price = 8554443,
                    Image = "/players/Jamal-Murray.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 36,
                    Weight = 187
                },
                new Athlete
                {
                    Name = "Trey Lyles",
                    Gender = "Male",
                    Price = 13944970,
                    Image = "/players/Trey-Lyles.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 35,
                    Weight = 255
                },
                new Athlete
                {
                    Name = "Nikola Jovic",
                    Gender = "Male",
                    Price = 9743405,
                    Image = "/players/Nikola-Jovic.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 31,
                    Weight = 219
                },
                new Athlete
                {
                    Name = "Trey Jemison",
                    Gender = "Male",
                    Price = 6039754,
                    Image = "/players/Trey-Jemison.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 22,
                    Weight = 196
                },
                new Athlete
                {
                    Name = "Cam Whitmore",
                    Gender = "Male",
                    Price = 6380447,
                    Image = "/players/Cam-Whitmore.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Canada",
                    Height = "6'8",
                    Age = 35,
                    Weight = 239
                },
                new Athlete
                {
                    Name = "Jeremy Sochan",
                    Gender = "Male",
                    Price = 3204048,
                    Image = "/players/Jeremy-Sochan.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 23,
                    Weight = 212
                },
                new Athlete
                {
                    Name = "Noah Clowney",
                    Gender = "Male",
                    Price = 5323800,
                    Image = "/players/Noah-Clowney.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 27,
                    Weight = 218
                },
                new Athlete
                {
                    Name = "Aaron Nesmith",
                    Gender = "Male",
                    Price = 10284946,
                    Image = "/players/Aaron-Nesmith.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 23,
                    Weight = 203
                },
                new Athlete
                {
                    Name = "Jalen Hoodschifino",
                    Gender = "Male",
                    Price = 7130799,
                    Image = "/players/Jalen-Hoodschifino.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 30,
                    Weight = 249
                },
                new Athlete
                {
                    Name = "Alex Caruso",
                    Gender = "Male",
                    Price = 3175539,
                    Image = "/players/Alex-Caruso.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 33,
                    Weight = 216
                },
                new Athlete
                {
                    Name = "DJ Carton",
                    Gender = "Male",
                    Price = 4331160,
                    Image = "/players/DJ-Carton.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 28,
                    Weight = 232
                },
                new Athlete
                {
                    Name = "Jared Butler",
                    Gender = "Male",
                    Price = 10764028,
                    Image = "/players/Jared-Butler.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 31,
                    Weight = 194
                },
                new Athlete
                {
                    Name = "Grayson Allen",
                    Gender = "Male",
                    Price = 8972570,
                    Image = "/players/Grayson-Allen.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 25,
                    Weight = 251
                },
                new Athlete
                {
                    Name = "Bones Hyland",
                    Gender = "Male",
                    Price = 1220597,
                    Image = "/players/Bones-Hyland.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 24,
                    Weight = 217
                },
                new Athlete
                {
                    Name = "Bryce McGowens",
                    Gender = "Male",
                    Price = 3479606,
                    Image = "/players/Bryce-McGowens.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 19,
                    Weight = 199
                },
                new Athlete
                {
                    Name = "Hunter Tyson",
                    Gender = "Male",
                    Price = 1920780,
                    Image = "/players/Hunter-Tyson.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 36,
                    Weight = 249
                },
                new Athlete
                {
                    Name = "Austin Reaves",
                    Gender = "Male",
                    Price = 7009789,
                    Image = "/players/Austin-Reaves.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "France",
                    Height = "6'4",
                    Age = 21,
                    Weight = 215
                },
                new Athlete
                {
                    Name = "John Collins",
                    Gender = "Male",
                    Price = 8389109,
                    Image = "/players/John-Collins.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 36,
                    Weight = 210
                },
                new Athlete
                {
                    Name = "Kenrich Williams",
                    Gender = "Male",
                    Price = 14483954,
                    Image = "/players/Kenrich-Williams.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "Australia",
                    Height = "7'1",
                    Age = 20,
                    Weight = 248
                },
                new Athlete
                {
                    Name = "Nick Richards",
                    Gender = "Male",
                    Price = 2583656,
                    Image = "/players/Nick-Richards.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 36,
                    Weight = 238
                },
                new Athlete
                {
                    Name = "Brook Lopez",
                    Gender = "Male",
                    Price = 1737736,
                    Image = "/players/Brook-Lopez.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 24,
                    Weight = 173
                },
                new Athlete
                {
                    Name = "Jalen Duren",
                    Gender = "Male",
                    Price = 2741274,
                    Image = "/players/Jalen-Duren.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "China",
                    Height = "6'1",
                    Age = 36,
                    Weight = 179
                },
                new Athlete
                {
                    Name = "Daniel Gafford",
                    Gender = "Male",
                    Price = 2922367,
                    Image = "/players/Daniel-Gafford.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 26,
                    Weight = 174
                },
                new Athlete
                {
                    Name = "Donovan Mitchell",
                    Gender = "Male",
                    Price = 10027675,
                    Image = "/players/Donovan-Mitchell.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 24,
                    Weight = 234
                },
                new Athlete
                {
                    Name = "Davis Bertans",
                    Gender = "Male",
                    Price = 12103142,
                    Image = "/players/Davis-Bertans.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "Ukraine",
                    Height = "6'3",
                    Age = 29,
                    Weight = 196
                },
                new Athlete
                {
                    Name = "Ziaire Williams",
                    Gender = "Male",
                    Price = 2532078,
                    Image = "/players/Ziaire-Williams.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 24,
                    Weight = 170
                },
                new Athlete
                {
                    Name = "Cam Thomas",
                    Gender = "Male",
                    Price = 11720773,
                    Image = "/players/Cam-Thomas.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "China",
                    Height = "6'5",
                    Age = 22,
                    Weight = 198
                },
                new Athlete
                {
                    Name = "Dorian Finneysmith",
                    Gender = "Male",
                    Price = 7209958,
                    Image = "/players/Dorian-Finneysmith.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 27,
                    Weight = 238
                },
                new Athlete
                {
                    Name = "Sidy Cissoko",
                    Gender = "Male",
                    Price = 13378850,
                    Image = "/players/Sidy-Cissoko.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 36,
                    Weight = 248
                },
                new Athlete
                {
                    Name = "Kelel Ware",
                    Gender = "Male",
                    Price = 2754736,
                    Image = "/players/Kelel-Ware.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Slovakia",
                    Height = "6'6",
                    Age = 27,
                    Weight = 225
                },
                new Athlete
                {
                    Name = "GG Jackson",
                    Gender = "Male",
                    Price = 9637246,
                    Image = "/players/GG-Jackson.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 30,
                    Weight = 171
                },
                new Athlete
                {
                    Name = "Johnny Davis",
                    Gender = "Male",
                    Price = 9653453,
                    Image = "/players/Johnny-Davis.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 38,
                    Weight = 215
                },
                new Athlete
                {
                    Name = "Ty Jerome",
                    Gender = "Male",
                    Price = 9670379,
                    Image = "/players/Ty-Jerome.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 24,
                    Weight = 267
                },
                new Athlete
                {
                    Name = "Payton Pritchard",
                    Gender = "Male",
                    Price = 6715289,
                    Image = "/players/Payton-Pritchard.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 38,
                    Weight = 206
                },
                new Athlete
                {
                    Name = "Nikola Jokic",
                    Gender = "Male",
                    Price = 5583783,
                    Image = "/players/Nikola-Jokic.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 20,
                    Weight = 180
                },
                new Athlete
                {
                    Name = "Dwight Powell",
                    Gender = "Male",
                    Price = 1484881,
                    Image = "/players/Dwight-Powell.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "Australia",
                    Height = "6'1",
                    Age = 29,
                    Weight = 186
                },
                new Athlete
                {
                    Name = "Aleksej Pokusevski",
                    Gender = "Male",
                    Price = 2456188,
                    Image = "/players/Aleksej-Pokusevski.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 22,
                    Weight = 239
                },
                new Athlete
                {
                    Name = "Chet Holmgren",
                    Gender = "Male",
                    Price = 11682731,
                    Image = "/players/Chet-Holmgren.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 27,
                    Weight = 246
                },
                new Athlete
                {
                    Name = "Zeke Nnaji",
                    Gender = "Male",
                    Price = 4227788,
                    Image = "/players/Zeke-Nnaji.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 23,
                    Weight = 207
                },
                new Athlete
                {
                    Name = "Dangelo Russell",
                    Gender = "Male",
                    Price = 11682785,
                    Image = "/players/Dangelo-Russell.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 27,
                    Weight = 195
                },
                new Athlete
                {
                    Name = "Aaron Gordon",
                    Gender = "Male",
                    Price = 3340597,
                    Image = "/players/Aaron-Gordon.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 34,
                    Weight = 175
                },
                new Athlete
                {
                    Name = "PJ Tucker",
                    Gender = "Male",
                    Price = 8884360,
                    Image = "/players/PJ-Tucker.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 31,
                    Weight = 234
                },
                new Athlete
                {
                    Name = "Colby Jones",
                    Gender = "Male",
                    Price = 8787925,
                    Image = "/players/Colby-Jones.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 31,
                    Weight = 191
                },
                new Athlete
                {
                    Name = "Corey Kispert",
                    Gender = "Male",
                    Price = 11474002,
                    Image = "/players/Corey-Kispert.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 23,
                    Weight = 194
                },
                new Athlete
                {
                    Name = "Paul Reed",
                    Gender = "Male",
                    Price = 10832788,
                    Image = "/players/Paul-Reed.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 29,
                    Weight = 199
                },
                new Athlete
                {
                    Name = "Mitchell Robinson",
                    Gender = "Male",
                    Price = 10214623,
                    Image = "/players/Mitchell-Robinson.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "Netherlands",
                    Height = "6'10",
                    Age = 34,
                    Weight = 275
                },
                new Athlete
                {
                    Name = "Ben Simmons",
                    Gender = "Male",
                    Price = 8612463,
                    Image = "/players/Ben-Simmons.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 31,
                    Weight = 240
                },
                new Athlete
                {
                    Name = "Myles Turner",
                    Gender = "Male",
                    Price = 1846725,
                    Image = "/players/Myles-Turner.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 24,
                    Weight = 233
                },
                new Athlete
                {
                    Name = "Marques Bolden",
                    Gender = "Male",
                    Price = 6206698,
                    Image = "/players/Marques-Bolden.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 38,
                    Weight = 251
                },
                new Athlete
                {
                    Name = "Alperin Sengun",
                    Gender = "Male",
                    Price = 8680748,
                    Image = "/players/Alperin-Sengun.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Serbia",
                    Height = "6'7",
                    Age = 30,
                    Weight = 227
                },
                new Athlete
                {
                    Name = "Zach Lavine",
                    Gender = "Male",
                    Price = 1175159,
                    Image = "/players/Zach-Lavine.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 33,
                    Weight = 223
                },
                new Athlete
                {
                    Name = "Victor Wembanayma",
                    Gender = "Male",
                    Price = 9889021,
                    Image = "/players/Victor-Wembanayma.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 38,
                    Weight = 193
                },
                new Athlete
                {
                    Name = "Terry Rozier",
                    Gender = "Male",
                    Price = 1224724,
                    Image = "/players/Terry-Rozier.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 19,
                    Weight = 205
                },
                new Athlete
                {
                    Name = "Jose Alvarado",
                    Gender = "Male",
                    Price = 5165170,
                    Image = "/players/Jose-Alvarado.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Netherlands",
                    Height = "6'6",
                    Age = 30,
                    Weight = 219
                },
                new Athlete
                {
                    Name = "Chris Duarte",
                    Gender = "Male",
                    Price = 12488711,
                    Image = "/players/Chris-Duarte.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 21,
                    Weight = 182
                },
                new Athlete
                {
                    Name = "Keshad Johnson",
                    Gender = "Male",
                    Price = 13857021,
                    Image = "/players/Keshad-Johnson.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 36,
                    Weight = 194
                },
                new Athlete
                {
                    Name = "Lauri Markkanen",
                    Gender = "Male",
                    Price = 1911626,
                    Image = "/players/Lauri-Markkanen.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 30,
                    Weight = 217
                },
                new Athlete
                {
                    Name = "Onuralp Bitim",
                    Gender = "Male",
                    Price = 11612798,
                    Image = "/players/Onuralp-Bitim.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 37,
                    Weight = 200
                },
                new Athlete
                {
                    Name = "Patrick Baldwin",
                    Gender = "Male",
                    Price = 1281467,
                    Image = "/players/Patrick-Baldwin.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'2",
                    Age = 29,
                    Weight = 265
                },
                new Athlete
                {
                    Name = "Jaylin Williams",
                    Gender = "Male",
                    Price = 2202546,
                    Image = "/players/Jaylin-Williams.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "China",
                    Height = "6'10",
                    Age = 28,
                    Weight = 261
                },
                new Athlete
                {
                    Name = "Cole Anthony",
                    Gender = "Male",
                    Price = 4710566,
                    Image = "/players/Cole-Anthony.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 29,
                    Weight = 183
                },
                new Athlete
                {
                    Name = "Malcolm Brogdon",
                    Gender = "Male",
                    Price = 10080493,
                    Image = "/players/Malcolm-Brogdon.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 28,
                    Weight = 176
                },
                new Athlete
                {
                    Name = "Bilal Coulibaly",
                    Gender = "Male",
                    Price = 13503595,
                    Image = "/players/Bilal-Coulibaly.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Ukraine",
                    Height = "6'7",
                    Age = 37,
                    Weight = 201
                },
                new Athlete
                {
                    Name = "Ryan Dunn",
                    Gender = "Male",
                    Price = 14491499,
                    Image = "/players/Ryan-Dunn.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'2",
                    Age = 23,
                    Weight = 253
                },
                new Athlete
                {
                    Name = "Landry Shamet",
                    Gender = "Male",
                    Price = 13925989,
                    Image = "/players/Landry-Shamet.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 33,
                    Weight = 170
                },
                new Athlete
                {
                    Name = "Josh Richardson",
                    Gender = "Male",
                    Price = 13229537,
                    Image = "/players/Josh-Richardson.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "France",
                    Height = "6'1",
                    Age = 25,
                    Weight = 189
                },
                new Athlete
                {
                    Name = "Jakob Poeltl",
                    Gender = "Male",
                    Price = 1644876,
                    Image = "/players/Jakob-Poeltl.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 23,
                    Weight = 195
                },
                new Athlete
                {
                    Name = "Onyeka Okongwu",
                    Gender = "Male",
                    Price = 13752530,
                    Image = "/players/Onyeka-Okongwu.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'1",
                    Age = 35,
                    Weight = 256
                },
                new Athlete
                {
                    Name = "Luka Doncic",
                    Gender = "Male",
                    Price = 10127205,
                    Image = "/players/Luka-Doncic.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 28,
                    Weight = 241
                },
                new Athlete
                {
                    Name = "Amir Coffey",
                    Gender = "Male",
                    Price = 4365770,
                    Image = "/players/Amir-Coffey.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "Ukraine",
                    Height = "6'11",
                    Age = 26,
                    Weight = 220
                },
                new Athlete
                {
                    Name = "Brandan Ingram",
                    Gender = "Male",
                    Price = 9862671,
                    Image = "/players/Brandan-Ingram.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'1",
                    Age = 35,
                    Weight = 258
                },
                new Athlete
                {
                    Name = "Alex Fudge",
                    Gender = "Male",
                    Price = 14232053,
                    Image = "/players/Alex-Fudge.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 22,
                    Weight = 256
                },
                new Athlete
                {
                    Name = "Anthony Black",
                    Gender = "Male",
                    Price = 7276740,
                    Image = "/players/Anthony-Black.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "China",
                    Height = "6'7",
                    Age = 33,
                    Weight = 224
                },
                new Athlete
                {
                    Name = "Tim Hardaway",
                    Gender = "Male",
                    Price = 14593329,
                    Image = "/players/Tim-Hardaway.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 21,
                    Weight = 186
                },
                new Athlete
                {
                    Name = "Cade Cunningham",
                    Gender = "Male",
                    Price = 8742159,
                    Image = "/players/Cade-Cunningham.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 31,
                    Weight = 188
                },
                new Athlete
                {
                    Name = "Tyrese Haliburton",
                    Gender = "Male",
                    Price = 6600487,
                    Image = "/players/Tyrese-Haliburton.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 34,
                    Weight = 241
                },
                new Athlete
                {
                    Name = "Tre Mann",
                    Gender = "Male",
                    Price = 11310420,
                    Image = "/players/Tre-Mann.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 37,
                    Weight = 229
                },
                new Athlete
                {
                    Name = "Caleb Houstan",
                    Gender = "Male",
                    Price = 9720848,
                    Image = "/players/Caleb-Houstan.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 38,
                    Weight = 239
                },
                new Athlete
                {
                    Name = "Cameron Johnson",
                    Gender = "Male",
                    Price = 8862780,
                    Image = "/players/Cameron-Johnson.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 38,
                    Weight = 259
                },
                new Athlete
                {
                    Name = "Jeremiah Robinsonearl",
                    Gender = "Male",
                    Price = 3018072,
                    Image = "/players/Jeremiah-Robinsonearl.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 27,
                    Weight = 226
                },
                new Athlete
                {
                    Name = "Franz Wagner",
                    Gender = "Male",
                    Price = 1258249,
                    Image = "/players/Franz-Wagner.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 23,
                    Weight = 180
                },
                new Athlete
                {
                    Name = "Ben Sheppard",
                    Gender = "Male",
                    Price = 6116349,
                    Image = "/players/Ben-Sheppard.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 35,
                    Weight = 280
                },
                new Athlete
                {
                    Name = "Jonathan Kuminga",
                    Gender = "Male",
                    Price = 11282409,
                    Image = "/players/Jonathan-Kuminga.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 28,
                    Weight = 265
                },
                new Athlete
                {
                    Name = "Ausar Thompson",
                    Gender = "Male",
                    Price = 4094103,
                    Image = "/players/Ausar-Thompson.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 27,
                    Weight = 243
                },
                new Athlete
                {
                    Name = "Scotty Pippen",
                    Gender = "Male",
                    Price = 5556292,
                    Image = "/players/Scotty-Pippen.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 32,
                    Weight = 233
                },
                new Athlete
                {
                    Name = "Jarace Walker",
                    Gender = "Male",
                    Price = 5816665,
                    Image = "/players/Jarace-Walker.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 38,
                    Weight = 200
                },
                new Athlete
                {
                    Name = "Malcolm Hill",
                    Gender = "Male",
                    Price = 4454458,
                    Image = "/players/Malcolm-Hill.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 26,
                    Weight = 233
                },
                new Athlete
                {
                    Name = "Luka Kornet",
                    Gender = "Male",
                    Price = 9115419,
                    Image = "/players/Luka-Kornet.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 25,
                    Weight = 183
                },
                new Athlete
                {
                    Name = "Matisse Thybulle",
                    Gender = "Male",
                    Price = 9570408,
                    Image = "/players/Matisse-Thybulle.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 35,
                    Weight = 241
                },
                new Athlete
                {
                    Name = "Trey Murphy",
                    Gender = "Male",
                    Price = 5791459,
                    Image = "/players/Trey-Murphy.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "Slovakia",
                    Height = "6'2",
                    Age = 28,
                    Weight = 173
                },
                new Athlete
                {
                    Name = "Jordan Poole",
                    Gender = "Male",
                    Price = 9457273,
                    Image = "/players/Jordan-Poole.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 31,
                    Weight = 187
                },
                new Athlete
                {
                    Name = "Dayron Sharpe",
                    Gender = "Male",
                    Price = 12021092,
                    Image = "/players/Dayron-Sharpe.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 21,
                    Weight = 245
                },
                new Athlete
                {
                    Name = "Matt Ryan",
                    Gender = "Male",
                    Price = 11478730,
                    Image = "/players/Matt-Ryan.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 30,
                    Weight = 252
                },
                new Athlete
                {
                    Name = "Jerami Grant",
                    Gender = "Male",
                    Price = 13882004,
                    Image = "/players/Jerami-Grant.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "Australia",
                    Height = "6'2",
                    Age = 29,
                    Weight = 198
                },
                new Athlete
                {
                    Name = "Anthony Edwards",
                    Gender = "Male",
                    Price = 3523476,
                    Image = "/players/Anthony-Edwards.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 37,
                    Weight = 239
                },
                new Athlete
                {
                    Name = "Jordan Hawkins",
                    Gender = "Male",
                    Price = 11256313,
                    Image = "/players/Jordan-Hawkins.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "Canada",
                    Height = "6'10",
                    Age = 27,
                    Weight = 263
                },
                new Athlete
                {
                    Name = "Devin Booker",
                    Gender = "Male",
                    Price = 5779624,
                    Image = "/players/Devin-Booker.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 26,
                    Weight = 214
                },
                new Athlete
                {
                    Name = "George Niang",
                    Gender = "Male",
                    Price = 14838747,
                    Image = "/players/George-Niang.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 30,
                    Weight = 264
                },
                new Athlete
                {
                    Name = "Jalen Wilson",
                    Gender = "Male",
                    Price = 10829149,
                    Image = "/players/Jalen-Wilson.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 28,
                    Weight = 188
                },
                new Athlete
                {
                    Name = "Keegan Murray",
                    Gender = "Male",
                    Price = 6813472,
                    Image = "/players/Keegan-Murray.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 32,
                    Weight = 185
                },
                new Athlete
                {
                    Name = "Keon Ellis",
                    Gender = "Male",
                    Price = 12572419,
                    Image = "/players/Keon-Ellis.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'2",
                    Age = 37,
                    Weight = 263
                },
                new Athlete
                {
                    Name = "Gary Payton",
                    Gender = "Male",
                    Price = 11410784,
                    Image = "/players/Gary-Payton.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 28,
                    Weight = 279
                },
                new Athlete
                {
                    Name = "Christian Braun",
                    Gender = "Male",
                    Price = 14797258,
                    Image = "/players/Christian-Braun.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 20,
                    Weight = 181
                },
                new Athlete
                {
                    Name = "Norman Powell",
                    Gender = "Male",
                    Price = 7037925,
                    Image = "/players/Norman-Powell.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 29,
                    Weight = 171
                },
                new Athlete
                {
                    Name = "Scoot Henderson",
                    Gender = "Male",
                    Price = 9574032,
                    Image = "/players/Scoot-Henderson.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 19,
                    Weight = 203
                },
                new Athlete
                {
                    Name = "Gabe Vincent",
                    Gender = "Male",
                    Price = 12907129,
                    Image = "/players/Gabe-Vincent.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 30,
                    Weight = 251
                },
                new Athlete
                {
                    Name = "Stephon Castle",
                    Gender = "Male",
                    Price = 8848134,
                    Image = "/players/Stephon-Castle.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 35,
                    Weight = 203
                },
                new Athlete
                {
                    Name = "Toumani Camara",
                    Gender = "Male",
                    Price = 1636195,
                    Image = "/players/Toumani-Camara.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 32,
                    Weight = 256
                },
                new Athlete
                {
                    Name = "Jamaree Bouyea",
                    Gender = "Male",
                    Price = 10514085,
                    Image = "/players/Jamaree-Bouyea.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'10",
                    Age = 26,
                    Weight = 235
                },
                new Athlete
                {
                    Name = "Julius Randle",
                    Gender = "Male",
                    Price = 8660579,
                    Image = "/players/Julius-Randle.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 30,
                    Weight = 200
                },
                new Athlete
                {
                    Name = "Cam Reddish",
                    Gender = "Male",
                    Price = 10340652,
                    Image = "/players/Cam-Reddish.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 36,
                    Weight = 216
                },
                new Athlete
                {
                    Name = "Jimmy Butler",
                    Gender = "Male",
                    Price = 8875195,
                    Image = "/players/Jimmy-Butler.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Canada",
                    Height = "6'7",
                    Age = 27,
                    Weight = 207
                },
                new Athlete
                {
                    Name = "Chris Boucher",
                    Gender = "Male",
                    Price = 10842085,
                    Image = "/players/Chris-Boucher.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 34,
                    Weight = 244
                },
                new Athlete
                {
                    Name = "Jarred Vanderbilt",
                    Gender = "Male",
                    Price = 1763202,
                    Image = "/players/Jarred-Vanderbilt.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'10",
                    Age = 29,
                    Weight = 244
                },
                new Athlete
                {
                    Name = "Josh Hart",
                    Gender = "Male",
                    Price = 7968760,
                    Image = "/players/Josh-Hart.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 30,
                    Weight = 195
                },
                new Athlete
                {
                    Name = "Zach Collins",
                    Gender = "Male",
                    Price = 14366298,
                    Image = "/players/Zach-Collins.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 37,
                    Weight = 197
                },
                new Athlete
                {
                    Name = "Josh Minott",
                    Gender = "Male",
                    Price = 12538810,
                    Image = "/players/Josh-Minott.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 35,
                    Weight = 283
                },
                new Athlete
                {
                    Name = "Dennis Schroder",
                    Gender = "Male",
                    Price = 6185217,
                    Image = "/players/Dennis-Schroder.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 23,
                    Weight = 247
                },
                new Athlete
                {
                    Name = "Jeff Green",
                    Gender = "Male",
                    Price = 14556539,
                    Image = "/players/Jeff-Green.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 28,
                    Weight = 197
                },
                new Athlete
                {
                    Name = "Davion Mitchell",
                    Gender = "Male",
                    Price = 14345134,
                    Image = "/players/Davion-Mitchell.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 32,
                    Weight = 190
                },
                new Athlete
                {
                    Name = "Tosan Evbuomwan",
                    Gender = "Male",
                    Price = 8428394,
                    Image = "/players/Tosan-Evbuomwan.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 26,
                    Weight = 275
                },
                new Athlete
                {
                    Name = "Derrick White",
                    Gender = "Male",
                    Price = 14025736,
                    Image = "/players/Derrick-White.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 20,
                    Weight = 257
                },
                new Athlete
                {
                    Name = "Rayan Rupert",
                    Gender = "Male",
                    Price = 5148384,
                    Image = "/players/Rayan-Rupert.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 21,
                    Weight = 236
                },
                new Athlete
                {
                    Name = "Vince Williams",
                    Gender = "Male",
                    Price = 2890290,
                    Image = "/players/Vince-Williams.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'10",
                    Age = 32,
                    Weight = 257
                },
                new Athlete
                {
                    Name = "Andrew Funk",
                    Gender = "Male",
                    Price = 5890269,
                    Image = "/players/Andrew-Funk.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 37,
                    Weight = 289
                },
                new Athlete
                {
                    Name = "Bam Adebayo",
                    Gender = "Male",
                    Price = 12455592,
                    Image = "/players/Bam-Adebayo.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'10",
                    Age = 31,
                    Weight = 252
                },
                new Athlete
                {
                    Name = "Chris Livingston",
                    Gender = "Male",
                    Price = 13317909,
                    Image = "/players/Chris-Livingston.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 33,
                    Weight = 205
                },
                new Athlete
                {
                    Name = "Devin Vassell",
                    Gender = "Male",
                    Price = 1303514,
                    Image = "/players/Devin-Vassell.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'10",
                    Age = 34,
                    Weight = 240
                },
                new Athlete
                {
                    Name = "Al Horford",
                    Gender = "Male",
                    Price = 12327495,
                    Image = "/players/Al-Horford.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 33,
                    Weight = 171
                },
                new Athlete
                {
                    Name = "Tari Eason",
                    Gender = "Male",
                    Price = 5028045,
                    Image = "/players/Tari-Eason.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 23,
                    Weight = 220
                },
                new Athlete
                {
                    Name = "Lonzo Ball",
                    Gender = "Male",
                    Price = 11116940,
                    Image = "/players/Lonzo-Ball.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 19,
                    Weight = 225
                },
                new Athlete
                {
                    Name = "Reed Sheppard",
                    Gender = "Male",
                    Price = 2491496,
                    Image = "/players/Reed-Sheppard.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'10",
                    Age = 28,
                    Weight = 227
                },
                new Athlete
                {
                    Name = "Jrue Holiday",
                    Gender = "Male",
                    Price = 2329933,
                    Image = "/players/Jrue-Holiday.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 31,
                    Weight = 198
                },
                new Athlete
                {
                    Name = "Bojan Bogdanovic",
                    Gender = "Male",
                    Price = 8809772,
                    Image = "/players/Bojan-Bogdanovic.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 21,
                    Weight = 216
                },
                new Athlete
                {
                    Name = "Devonte Graham",
                    Gender = "Male",
                    Price = 10339250,
                    Image = "/players/Devonte-Graham.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 22,
                    Weight = 186
                },
                new Athlete
                {
                    Name = "Nikola Vucevic",
                    Gender = "Male",
                    Price = 14234753,
                    Image = "/players/Nikola-Vucevic.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 29,
                    Weight = 188
                },
                new Athlete
                {
                    Name = "Orlando Robinson",
                    Gender = "Male",
                    Price = 14835789,
                    Image = "/players/Orlando-Robinson.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 36,
                    Weight = 233
                },
                new Athlete
                {
                    Name = "Jaylin Galloyway",
                    Gender = "Male",
                    Price = 13964996,
                    Image = "/players/Jaylin-Galloyway.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 28,
                    Weight = 204
                },
                new Athlete
                {
                    Name = "RJ Barrett",
                    Gender = "Male",
                    Price = 6491740,
                    Image = "/players/RJ-Barrett.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 35,
                    Weight = 249
                },
                new Athlete
                {
                    Name = "Jaylen Martin",
                    Gender = "Male",
                    Price = 3959675,
                    Image = "/players/Jaylen-Martin.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "Ukraine",
                    Height = "6'9",
                    Age = 32,
                    Weight = 236
                },
                new Athlete
                {
                    Name = "Jabari Smith",
                    Gender = "Male",
                    Price = 14476612,
                    Image = "/players/Jabari-Smith.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 29,
                    Weight = 258
                },
                new Athlete
                {
                    Name = "Draymond Green",
                    Gender = "Male",
                    Price = 9140929,
                    Image = "/players/Draymond-Green.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'3",
                    Age = 26,
                    Weight = 273
                },
                new Athlete
                {
                    Name = "Jevon Carter",
                    Gender = "Male",
                    Price = 9130198,
                    Image = "/players/Jevon-Carter.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'1",
                    Age = 30,
                    Weight = 249
                },
                new Athlete
                {
                    Name = "Sam Hauser",
                    Gender = "Male",
                    Price = 2773669,
                    Image = "/players/Sam-Hauser.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 37,
                    Weight = 200
                },
                new Athlete
                {
                    Name = "Caris Levert",
                    Gender = "Male",
                    Price = 4085888,
                    Image = "/players/Caris-Levert.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 19,
                    Weight = 212
                },
                new Athlete
                {
                    Name = "Larry Nance",
                    Gender = "Male",
                    Price = 6604430,
                    Image = "/players/Larry-Nance.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 26,
                    Weight = 252
                },
                new Athlete
                {
                    Name = "Lu Dort",
                    Gender = "Male",
                    Price = 1475828,
                    Image = "/players/Lu-Dort.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'3",
                    Age = 26,
                    Weight = 249
                },
                new Athlete
                {
                    Name = "Jalen Williams",
                    Gender = "Male",
                    Price = 11763415,
                    Image = "/players/Jalen-Williams.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 33,
                    Weight = 286
                },
                new Athlete
                {
                    Name = "Xavier Tillman",
                    Gender = "Male",
                    Price = 10274516,
                    Image = "/players/Xavier-Tillman.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 27,
                    Weight = 171
                },
                new Athlete
                {
                    Name = "Kevon Looney",
                    Gender = "Male",
                    Price = 14869854,
                    Image = "/players/Kevon-Looney.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 37,
                    Weight = 271
                },
                new Athlete
                {
                    Name = "Isaiah Stewart",
                    Gender = "Male",
                    Price = 8406719,
                    Image = "/players/Isaiah-Stewart.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 33,
                    Weight = 248
                },
                new Athlete
                {
                    Name = "Justin Champagnie",
                    Gender = "Male",
                    Price = 5394967,
                    Image = "/players/Justin-Champagnie.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 27,
                    Weight = 193
                },
                new Athlete
                {
                    Name = "Kristaps Porzingis",
                    Gender = "Male",
                    Price = 10648766,
                    Image = "/players/Kristaps-Porzingis.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 28,
                    Weight = 204
                },
                new Athlete
                {
                    Name = "Maxwell Lewis",
                    Gender = "Male",
                    Price = 12411775,
                    Image = "/players/Maxwell-Lewis.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 27,
                    Weight = 217
                },
                new Athlete
                {
                    Name = "Santi Aldama",
                    Gender = "Male",
                    Price = 13070092,
                    Image = "/players/Santi-Aldama.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "Canada",
                    Height = "7'3",
                    Age = 21,
                    Weight = 245
                },
                new Athlete
                {
                    Name = "Marvin Bagley",
                    Gender = "Male",
                    Price = 8271531,
                    Image = "/players/Marvin-Bagley.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 31,
                    Weight = 190
                },
                new Athlete
                {
                    Name = "Evan Mobley",
                    Gender = "Male",
                    Price = 7012565,
                    Image = "/players/Evan-Mobley.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 29,
                    Weight = 247
                },
                new Athlete
                {
                    Name = "Kevin Huerter",
                    Gender = "Male",
                    Price = 6441240,
                    Image = "/players/Kevin-Huerter.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "Serbia",
                    Height = "6'5",
                    Age = 25,
                    Weight = 190
                },
                new Athlete
                {
                    Name = "Jayson Tatum",
                    Gender = "Male",
                    Price = 12409451,
                    Image = "/players/Jayson-Tatum.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 30,
                    Weight = 229
                },
                new Athlete
                {
                    Name = "Khris Middleton",
                    Gender = "Male",
                    Price = 10085579,
                    Image = "/players/Khris-Middleton.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 19,
                    Weight = 258
                },
                new Athlete
                {
                    Name = "Rudy Gobert",
                    Gender = "Male",
                    Price = 12035588,
                    Image = "/players/Rudy-Gobert.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "France",
                    Height = "7'3",
                    Age = 28,
                    Weight = 255
                },
                new Athlete
                {
                    Name = "Craig Porter",
                    Gender = "Male",
                    Price = 1613412,
                    Image = "/players/Craig-Porter.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 24,
                    Weight = 183
                },
                new Athlete
                {
                    Name = "Jordan Walsh",
                    Gender = "Male",
                    Price = 6224220,
                    Image = "/players/Jordan-Walsh.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "Ukraine",
                    Height = "6'10",
                    Age = 28,
                    Weight = 268
                },
                new Athlete
                {
                    Name = "Marjon Beauchamp",
                    Gender = "Male",
                    Price = 5907295,
                    Image = "/players/Marjon-Beauchamp.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 35,
                    Weight = 251
                },
                new Athlete
                {
                    Name = "Joel Embiid",
                    Gender = "Male",
                    Price = 11972070,
                    Image = "/players/Joel-Embiid.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 36,
                    Weight = 172
                },
                new Athlete
                {
                    Name = "Derrick Rose",
                    Gender = "Male",
                    Price = 3523682,
                    Image = "/players/Derrick-Rose.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 20,
                    Weight = 215
                },
                new Athlete
                {
                    Name = "Brandon Clarke",
                    Gender = "Male",
                    Price = 10477177,
                    Image = "/players/Brandon-Clarke.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 33,
                    Weight = 190
                },
                new Athlete
                {
                    Name = "Zyon Pullin",
                    Gender = "Male",
                    Price = 7800868,
                    Image = "/players/Zyon-Pullin.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 31,
                    Weight = 189
                },
                new Athlete
                {
                    Name = "Richaun Holmes",
                    Gender = "Male",
                    Price = 4367638,
                    Image = "/players/Richaun-Holmes.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 26,
                    Weight = 170
                },
                new Athlete
                {
                    Name = "Eugene Omoruyi",
                    Gender = "Male",
                    Price = 13553712,
                    Image = "/players/Eugene-Omoruyi.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 38,
                    Weight = 228
                },
                new Athlete
                {
                    Name = "CJ McCollum",
                    Gender = "Male",
                    Price = 13099818,
                    Image = "/players/CJ-McCollum.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "China",
                    Height = "6'1",
                    Age = 26,
                    Weight = 196
                },
                new Athlete
                {
                    Name = "Cason Wallace",
                    Gender = "Male",
                    Price = 6207172,
                    Image = "/players/Cason-Wallace.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 20,
                    Weight = 209
                },
                new Athlete
                {
                    Name = "Dante Exum",
                    Gender = "Male",
                    Price = 13358159,
                    Image = "/players/Dante-Exum.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 28,
                    Weight = 176
                },
                new Athlete
                {
                    Name = "Wendell Carter",
                    Gender = "Male",
                    Price = 8573672,
                    Image = "/players/Wendell-Carter.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "Slovakia",
                    Height = "6'11",
                    Age = 27,
                    Weight = 279
                },
                new Athlete
                {
                    Name = "Josh Green",
                    Gender = "Male",
                    Price = 14069080,
                    Image = "/players/Josh-Green.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 33,
                    Weight = 227
                },
                new Athlete
                {
                    Name = "Jaden Springer",
                    Gender = "Male",
                    Price = 8831844,
                    Image = "/players/Jaden-Springer.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'2",
                    Age = 21,
                    Weight = 253
                },
                new Athlete
                {
                    Name = "Terrance Mann",
                    Gender = "Male",
                    Price = 14960864,
                    Image = "/players/Terrance-Mann.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 19,
                    Weight = 255
                },
                new Athlete
                {
                    Name = "Jake Laravia",
                    Gender = "Male",
                    Price = 6242805,
                    Image = "/players/Jake-Laravia.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "Slovakia",
                    Height = "7'0",
                    Age = 27,
                    Weight = 254
                },
                new Athlete
                {
                    Name = "Michael Porter",
                    Gender = "Male",
                    Price = 9070273,
                    Image = "/players/Michael-Porter.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "Serbia",
                    Height = "6'1",
                    Age = 33,
                    Weight = 186
                },
                new Athlete
                {
                    Name = "Brice Sensabaugh",
                    Gender = "Male",
                    Price = 8036476,
                    Image = "/players/Brice-Sensabaugh.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 38,
                    Weight = 282
                },
                new Athlete
                {
                    Name = "Shaedon Sharpe",
                    Gender = "Male",
                    Price = 13917158,
                    Image = "/players/Shaedon-Sharpe.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 22,
                    Weight = 244
                },
                new Athlete
                {
                    Name = "Jaren Jackson",
                    Gender = "Male",
                    Price = 1055903,
                    Image = "/players/Jaren-Jackson.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "France",
                    Height = "6'4",
                    Age = 37,
                    Weight = 193
                },
                new Athlete
                {
                    Name = "Nick Smith",
                    Gender = "Male",
                    Price = 8431416,
                    Image = "/players/Nick-Smith.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "Ukraine",
                    Height = "6'9",
                    Age = 28,
                    Weight = 252
                },
                new Athlete
                {
                    Name = "Kenneth Lofton",
                    Gender = "Male",
                    Price = 6270429,
                    Image = "/players/Kenneth-Lofton.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 38,
                    Weight = 251
                },
                new Athlete
                {
                    Name = "Brandon Miller",
                    Gender = "Male",
                    Price = 9417959,
                    Image = "/players/Brandon-Miller.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 38,
                    Weight = 190
                },
                new Athlete
                {
                    Name = "Garrison Mathews",
                    Gender = "Male",
                    Price = 9043182,
                    Image = "/players/Garrison-Mathews.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'10",
                    Age = 31,
                    Weight = 266
                },
                new Athlete
                {
                    Name = "Blake Wesley",
                    Gender = "Male",
                    Price = 5209434,
                    Image = "/players/Blake-Wesley.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'3",
                    Age = 27,
                    Weight = 262
                },
                new Athlete
                {
                    Name = "Bruno Fernando",
                    Gender = "Male",
                    Price = 13513640,
                    Image = "/players/Bruno-Fernando.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'2",
                    Age = 27,
                    Weight = 242
                },
                new Athlete
                {
                    Name = "Anthony Davis",
                    Gender = "Male",
                    Price = 14281579,
                    Image = "/players/Anthony-Davis.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'6",
                    Age = 35,
                    Weight = 227
                },
                new Athlete
                {
                    Name = "Christian Wood",
                    Gender = "Male",
                    Price = 12582173,
                    Image = "/players/Christian-Wood.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 36,
                    Weight = 212
                },
                new Athlete
                {
                    Name = "John Konchar",
                    Gender = "Male",
                    Price = 1105853,
                    Image = "/players/John-Konchar.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 31,
                    Weight = 206
                },
                new Athlete
                {
                    Name = "Jordan Miller",
                    Gender = "Male",
                    Price = 14939736,
                    Image = "/players/Jordan-Miller.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "Serbia",
                    Height = "6'9",
                    Age = 38,
                    Weight = 228
                },
                new Athlete
                {
                    Name = "Deni Avdija",
                    Gender = "Male",
                    Price = 6415977,
                    Image = "/players/Deni-Avdija.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 33,
                    Weight = 214
                },
                new Athlete
                {
                    Name = "Kendall Brown",
                    Gender = "Male",
                    Price = 2578731,
                    Image = "/players/Kendall-Brown.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 22,
                    Weight = 209
                },
                new Athlete
                {
                    Name = "Andrew Wiggins",
                    Gender = "Male",
                    Price = 7464432,
                    Image = "/players/Andrew-Wiggins.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "Serbia",
                    Height = "6'10",
                    Age = 33,
                    Weight = 225
                },
                new Athlete
                {
                    Name = "Justin Minaya",
                    Gender = "Male",
                    Price = 1515324,
                    Image = "/players/Justin-Minaya.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 32,
                    Weight = 260
                },
                new Athlete
                {
                    Name = "Harrison Barnes",
                    Gender = "Male",
                    Price = 6726687,
                    Image = "/players/Harrison-Barnes.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 31,
                    Weight = 188
                },
                new Athlete
                {
                    Name = "Desmond Bane",
                    Gender = "Male",
                    Price = 1964647,
                    Image = "/players/Desmond-Bane.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 32,
                    Weight = 190
                },
                new Athlete
                {
                    Name = "Collin Gillespie",
                    Gender = "Male",
                    Price = 1594742,
                    Image = "/players/Collin-Gillespie.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 34,
                    Weight = 178
                },
                new Athlete
                {
                    Name = "Jalen Pickett",
                    Gender = "Male",
                    Price = 8688544,
                    Image = "/players/Jalen-Pickett.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "China",
                    Height = "6'5",
                    Age = 21,
                    Weight = 189
                },
                new Athlete
                {
                    Name = "Bogdan Bogdanovic",
                    Gender = "Male",
                    Price = 5097794,
                    Image = "/players/Bogdan-Bogdanovic.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 35,
                    Weight = 185
                },
                new Athlete
                {
                    Name = "EJ Liddell",
                    Gender = "Male",
                    Price = 13429462,
                    Image = "/players/EJ-Liddell.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "China",
                    Height = "6'10",
                    Age = 28,
                    Weight = 275
                },
                new Athlete
                {
                    Name = "Dalton Knecht",
                    Gender = "Male",
                    Price = 4720510,
                    Image = "/players/Dalton-Knecht.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "Slovakia",
                    Height = "6'1",
                    Age = 24,
                    Weight = 186
                },
                new Athlete
                {
                    Name = "AJ Griffin",
                    Gender = "Male",
                    Price = 8829698,
                    Image = "/players/AJ-Griffin.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'3",
                    Age = 25,
                    Weight = 242
                },
                new Athlete
                {
                    Name = "Brandin Podziemski",
                    Gender = "Male",
                    Price = 5955853,
                    Image = "/players/Brandin-Podziemski.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 32,
                    Weight = 251
                },
                new Athlete
                {
                    Name = "Coby White",
                    Gender = "Male",
                    Price = 1999112,
                    Image = "/players/Coby-White.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 30,
                    Weight = 207
                },
                new Athlete
                {
                    Name = "Cody Williams",
                    Gender = "Male",
                    Price = 4972097,
                    Image = "/players/Cody-Williams.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 29,
                    Weight = 210
                },
                new Athlete
                {
                    Name = "Jaden Ivey",
                    Gender = "Male",
                    Price = 9264207,
                    Image = "/players/Jaden-Ivey.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 33,
                    Weight = 282
                },
                new Athlete
                {
                    Name = "Kelly Olynyk",
                    Gender = "Male",
                    Price = 10540423,
                    Image = "/players/Kelly-Olynyk.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 24,
                    Weight = 229
                },
                new Athlete
                {
                    Name = "Jaesean Tate",
                    Gender = "Male",
                    Price = 14798188,
                    Image = "/players/Jaesean-Tate.jpg",
                    PurchaseStatus = false,
                    Position = "Point Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 26,
                    Weight = 190
                },
                new Athlete
                {
                    Name = "Taylor Hendricks",
                    Gender = "Male",
                    Price = 12813918,
                    Image = "/players/Taylor-Hendricks.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'2",
                    Age = 28,
                    Weight = 210
                },
                new Athlete
                {
                    Name = "AJ Green",
                    Gender = "Male",
                    Price = 13479929,
                    Image = "/players/AJ-Green.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 38,
                    Weight = 189
                },
                new Athlete
                {
                    Name = "Isaiah Jackson",
                    Gender = "Male",
                    Price = 1150022,
                    Image = "/players/Isaiah-Jackson.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Canada",
                    Height = "6'7",
                    Age = 25,
                    Weight = 216
                },
                new Athlete
                {
                    Name = "Anfernee Simons",
                    Gender = "Male",
                    Price = 12270632,
                    Image = "/players/Anfernee-Simons.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 22,
                    Weight = 221
                },
                new Athlete
                {
                    Name = "Jaylen Brown",
                    Gender = "Male",
                    Price = 9850116,
                    Image = "/players/Jaylen-Brown.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 32,
                    Weight = 237
                },
                new Athlete
                {
                    Name = "Gui Dossantos",
                    Gender = "Male",
                    Price = 11407121,
                    Image = "/players/Gui-Dossantos.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 30,
                    Weight = 228
                },
                new Athlete
                {
                    Name = "Kawhi Leonard",
                    Gender = "Male",
                    Price = 2097980,
                    Image = "/players/Kawhi-Leonard.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 19,
                    Weight = 217
                },
                new Athlete
                {
                    Name = "Mark Williams",
                    Gender = "Male",
                    Price = 10944727,
                    Image = "/players/Mark-Williams.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Ukraine",
                    Height = "6'8",
                    Age = 37,
                    Weight = 236
                },
                new Athlete
                {
                    Name = "Karlanthony Towns",
                    Gender = "Male",
                    Price = 6596590,
                    Image = "/players/Karlanthony-Towns.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'1",
                    Age = 30,
                    Weight = 286
                },
                new Athlete
                {
                    Name = "Fred Vanvleet",
                    Gender = "Male",
                    Price = 2224593,
                    Image = "/players/Fred-Vanvleet.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'9",
                    Age = 28,
                    Weight = 234
                },
                new Athlete
                {
                    Name = "Raiquan Gray",
                    Gender = "Male",
                    Price = 6989022,
                    Image = "/players/Raiquan-Gray.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "7'0",
                    Age = 26,
                    Weight = 247
                },
                new Athlete
                {
                    Name = "Miles McBridge",
                    Gender = "Male",
                    Price = 12890455,
                    Image = "/players/Miles-McBridge.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 28,
                    Weight = 233
                },
                new Athlete
                {
                    Name = "Vasilije Micic",
                    Gender = "Male",
                    Price = 12390983,
                    Image = "/players/Vasilije-Micic.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 25,
                    Weight = 236
                },
                new Athlete
                {
                    Name = "Pat Spencer",
                    Gender = "Male",
                    Price = 1972640,
                    Image = "/players/Pat-Spencer.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'4",
                    Age = 36,
                    Weight = 237
                },
                new Athlete
                {
                    Name = "Quintin Grimes",
                    Gender = "Male",
                    Price = 12173509,
                    Image = "/players/Quintin-Grimes.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 31,
                    Weight = 227
                },
                new Athlete
                {
                    Name = "Bennedict Mathurin",
                    Gender = "Male",
                    Price = 1150050,
                    Image = "/players/Bennedict-Mathurin.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 33,
                    Weight = 249
                },
                new Athlete
                {
                    Name = "Jusuf Nurkic",
                    Gender = "Male",
                    Price = 8717292,
                    Image = "/players/Jusuf-Nurkic.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'5",
                    Age = 31,
                    Weight = 191
                },
                new Athlete
                {
                    Name = "Ryan Rollins",
                    Gender = "Male",
                    Price = 7525222,
                    Image = "/players/Ryan-Rollins.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'7",
                    Age = 22,
                    Weight = 254
                },
                new Athlete
                {
                    Name = "Dereck Lively",
                    Gender = "Male",
                    Price = 9960490,
                    Image = "/players/Dereck-Lively.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "USA",
                    Height = "6'5",
                    Age = 26,
                    Weight = 226
                },
                new Athlete
                {
                    Name = "Paolo Banchero",
                    Gender = "Male",
                    Price = 4931849,
                    Image = "/players/Paolo-Banchero.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 20,
                    Weight = 189
                },
                new Athlete
                {
                    Name = "Sasha Vezenkov",
                    Gender = "Male",
                    Price = 6701945,
                    Image = "/players/Sasha-Vezenkov.jpg",
                    PurchaseStatus = false,
                    Position = "Center",
                    Country = "USA",
                    Height = "6'11",
                    Age = 22,
                    Weight = 252
                },
                new Athlete
                {
                    Name = "Jaylen Clark",
                    Gender = "Male",
                    Price = 9368330,
                    Image = "/players/Jaylen-Clark.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 22,
                    Weight = 192
                },
                new Athlete
                {
                    Name = "Jalen Suggs",
                    Gender = "Male",
                    Price = 8306411,
                    Image = "/players/Jalen-Suggs.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'11",
                    Age = 30,
                    Weight = 236
                },
                new Athlete
                {
                    Name = "Julian Strawther",
                    Gender = "Male",
                    Price = 6294952,
                    Image = "/players/Julian-Strawther.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'1",
                    Age = 31,
                    Weight = 187
                },
                new Athlete
                {
                    Name = "Herb Jones",
                    Gender = "Male",
                    Price = 9585875,
                    Image = "/players/Herb-Jones.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'3",
                    Age = 22,
                    Weight = 198
                },
                new Athlete
                {
                    Name = "Darius Bazley",
                    Gender = "Male",
                    Price = 2475627,
                    Image = "/players/Darius-Bazley.jpg",
                    PurchaseStatus = false,
                    Position = "Power Forward",
                    Country = "USA",
                    Height = "6'8",
                    Age = 30,
                    Weight = 224
                },
                new Athlete
                {
                    Name = "Kobe Brown",
                    Gender = "Male",
                    Price = 7843290,
                    Image = "/players/Kobe-Brown.jpg",
                    PurchaseStatus = false,
                    Position = "Shooting Guard",
                    Country = "USA",
                    Height = "6'4",
                    Age = 27,
                    Weight = 200
                },
                new Athlete
                {
                    Name = "Jordan Clarkson",
                    Gender = "Male",
                    Price = 6730016,
                    Image = "/players/Jordan-Clarkson.jpg",
                    PurchaseStatus = false,
                    Position = "Small Forward",
                    Country = "Canada",
                    Height = "6'4",
                    Age = 31,
                    Weight = 232
                }
            );
        }

        if (!context.Venues.Any())
        {
            context.Venues.AddRange(
                new Venue
                {
                    Name = "Downtown Arena",
                    Capacity = 15000,
                    Image = ""
                },
                new Venue
                {
                    Name = "City Court",
                    Capacity = 12000,
                    Image = ""
                }
            );
        }

        context.SaveChanges();
    }
}
