using System;
using System.Collections.Generic;
using System.Text;


namespace TheLipBar
{
    public static class Inventory
    {
        public static Dictionary<int, Product> InventoryDic = new Dictionary<int, Product>()
        {
            { 1, (new Product("Bawse Lady", 13.00, "The best red you'll ever meet. Period." ))},
            { 2, (new Product("Man Eater", 13.00, "She is a man eater. She is intimidating. But deep inside she is just a mild taupe colored matte lip waiting to be worn and loved Enriched with Shea butter, avocado oil and jojoba oil to soften the lips" )) },
            { 3, (new Product("Know It All", 13.00, "She's subtle, no she's bold, oh no she's sweet, mixed with a little sass. Ultimately, she's everything. That color you can't quite figure out. This purple brown with a hint of red liquid matte is for the Know it All - the woman who has done her research. She has checked her facts. You can’t tell this lady shit, she’s a Know It All!" )) },
            { 4, (new Product("Prom Queen ", 13.00, "Reign on queen with this perfect blend of pink and purple...I'm a queen, you're a queen, everyone's a queen, queen. Enriched with Shea butter, avocado oil and jojoba oil to soften the lips." )) },
            { 5, (new Product("Crown Me", 13.00, "Never be afraid to fix another queen's crown. #crownme" )) },
            { 6, (new Product("Minimalist", 14.00, "Ultralight and packed with lip nourishing ingredients, our latest drop \"Minimalist\" is the BEST way to pamper your pout. Apply as much or as little as you'd like, Babe — we promise not to judge. ;)" )) },
            { 7, (new Product("Trophy Wife", 14.00, "This organic lip gloss is the perfect everyday shade. Wear it on to the grocery store or on a date when you're going for that no-makeup, makeup look. This is a clear gloss with a hint of shimmer. Enjoy, babes! " )) },
            { 8, (new Product("Ms. Independent", 14.00, "She has her own and doesn’t need ANYONE for ANYTHING. She runs shit and loves it that way. This organic brown lipgloss is literally the perfect shade of nude from brown girls who have been in search for their shade or fair girls who like a deeper nude." )) },
            { 9, (new Product("Party Girl", 10.00, "This girl knows how to have a good time while never forgetting to make sure that her lipgloss is popping! It's the perfect pink to get any party started." )) },
            { 10, (new Product("Straight No Chaser Lip Liner", 10.00, "We'll have what she's having — STRAIGHT NO CHASER. Whether you prefer to line your lips or fill them all the way in, there's no doubt that this deep, matte purple shade offers an intoxicating shot of color that'll keep you coming back for more. Enriched with nourishing ingredients like Jojoba Oil and Aloe Vera, its smooth formula does wonders to keep your lips hydrated without dragging or skipping a beat." )) },
            { 11, (new Product("Straight Partying Lip Liner", 10.00, "Every Lip Bar Babe knows the party doesn't really start until we arrive, and STRAIGHT PARTYING is ready to rage! Dial-up the fun and make every day a celebration with lips lined or filled in with this hot pink matte hue. Enriched with nourishing ingredients like Jojoba Oil and Aloe Vera, its smooth formula does wonders to keep your lips hydrated without dragging or skipping a beat." )) },
            { 12, (new Product("Merlot", 13.00, "Vamp is Life! You ever just wanted to feel like a total badass? Like no one could get in your way of greatness, like the world is in the palm of your hand? That's what this color does for me. Life has been given." )) },
        };
        

        static public void PrintBasicInventory()
        {
            foreach (KeyValuePair<int, Product> entry in InventoryDic)
            {
                // do something with entry.Value or entry.Key
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
        static public void PrintInventory()
        {
            foreach (KeyValuePair<int, Product> entry in InventoryDic)
            {
                // do something with entry.Value or entry.Key
                Console.WriteLine($"{entry.Key}: {entry.Value} \n{entry.Value.Description}\n");
            }
        }
    } 
}
