using System;
using System.Collections.Generic;
using System.Text;


namespace TheLipBar
{
    public static class Inventory
    {
        public static Dictionary<int, Product> InventoryDic = new Dictionary<int, Product>()
        {
            { 1, (new Product("Bawse Lady", 13.00, "\n\tThe best red you'll ever meet. Period." ))},
            { 2, (new Product("Hot Mama", 13.00, "\n\tYour new favorite lippie, Hot Mama, a fire-engine red that'll\n\tset your lips ablazeand bring all the heat to your makeup looks: day and night."))},
            { 3, (new Product("Man Eater", 13.00, "\n\tShe is a man eater. She is intimidating.\n\tBut deep inside she is just a mild taupe colored matte lip waiting to be worn\n\tand loved Enriched with Shea butter, avocado oil and jojoba oil to soften the lips" )) },
            { 4, (new Product("Know It All", 13.00, "\n\tShe's subtle, no she's bold, oh no she's sweet, mixed with a little sass.\n\tUltimately, she's everything. That color you can't quite figure out.\n\tThis purple brown with a hint of red liquid matte is for the\n\tKnow it All - the woman who has done her research.\n\tShe has checked her facts. You can’t tell this lady shit, she’s a Know It All!" )) },
            { 5, (new Product("Prom Queen", 13.00, "\tReign on queen with this perfect blend of pink and purple...\n\tI'm a queen, you're a queen, everyone's a queen, queen.\n\tEnriched with Shea butter, avocado oil and jojoba oil to soften the lips." )) },
            { 6, (new Product("Crown Me", 13.00, "\n\tNever be afraid to fix another queen's crown. #CrownMe" )) },
            { 7, (new Product("Minimalist", 14.00, "\n\tUltralight and packed with lip nourishing ingredients, our latest drop \"Minimalist\"\n\tis the BEST way to pamper your pout. Apply as much or as little as you'd like,\n\tBabe — we promise not to judge. ;)" )) },
            { 8, (new Product("Trophy Wife", 14.00, "\n\tThis organic lip gloss is the perfect everyday shade. Wear it on\n\tto the grocery store or on a date when you're going for that no-makeup,\n\tmakeup look. This is a clear gloss with a hint of shimmer. Enjoy, babes! " )) },
            { 9, (new Product("Ms. Independent", 14.00, "\n\tShe has her own and doesn’t need ANYONE for ANYTHING.\n\tShe runs shit and loves it that way. This organic brown lipgloss\n\tis literally the perfect shade of nude from brown girls who have\n\tbeen in search for their shade or fair girls who like a deeper nude." )) },
            { 10, (new Product("Party Girl", 10.00, "\n\tThis girl knows how to have a good time while never forgetting to make sure\n\tthat her lipgloss is popping! It's the perfect pink to get any party started." ))},
            { 11, (new Product("Straight No Chaser Lip Liner", 10.00, "\n\tWe'll have what she's having — STRAIGHT NO CHASER.\n\tWhether you prefer to line your lips or fill them \n\tall the way in, there's no doubt that this deep,\n\tmatte purple shade offers an intoxicating shot \n\tof color that'll keep you coming back for more.\n\tEnriched with nourishing ingredients like Jojoba\n\tOil and Aloe Vera, its smooth formula does wonders\n\tto keep your lips hydrated without dragging or skipping a beat." )) },
            { 12, (new Product("Straight Partying Lip Liner", 10.00, "\n\tEvery Lip Bar Babe knows the party doesn't really start \n\tuntil we arrive, and STRAIGHT PARTYING is ready to rage!\n\tDial-up the fun and make every day a celebration with \n\tlips lined or filled in with this hot pink matte hue.\n\tEnriched with nourishing ingredients like Jojoba Oil \n\tand Aloe Vera, its smooth formula does wonders to \n\tkeep your lips hydrated without dragging or skipping a beat." )) },
            { 13, (new Product("Merlot", 13.00, "\n\tVamp is Life! You ever just wanted to feel like a total badass?\n\tLike no one could get in your way of greatness, like the world is in the palm of your hand?\n\tThat's what this color does for me. Life has been given." )) },
        };
        

        static public void PrintBasicInventory()
        {
            foreach (KeyValuePair<int, Product> entry in InventoryDic)
            {
                Console.WriteLine($"\n{entry.Key}: {entry.Value}");
                Console.WriteLine(new string('=', 107));
            }
        }
        static public void PrintInventory()
        {
            foreach (KeyValuePair<int, Product> entry in InventoryDic)
            {
                Console.WriteLine($"\n{entry.Key}: {entry.Value} \n{entry.Value.Description}\n");
                Console.WriteLine(new string('=', 107));
            }
        }
    } 
}
