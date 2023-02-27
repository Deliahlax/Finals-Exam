using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Claims;

public class ReadingUserInput

{
    public static void Main(string[] args)
    {
        string story, recommend;
        List<string> items = new List<string>();
        do

        {

            Console.WriteLine("Welcome to Bibliophile's Corner!\n");
            Console.WriteLine("Book Recommendations\n");
            Console.WriteLine("Enter 1 to add book in your Reading List");
            Console.WriteLine("Enter 2 to remove book in your Reading List");
            Console.WriteLine("Enter 3 to review the books in your Reading List");
            Console.WriteLine("Enter x to exit App");
            story = Console.ReadLine();

            if (story == "1")
            {

                Console.WriteLine("Stories suggestion for you\n");
                string book = Story();
                if (book == "1")
                {
                    Console.WriteLine("Here are some of the Book Recommendation for Fiction/Fantasy:\n");
                    Console.WriteLine("Titan Academy of Special Abilities | April_Avery");
                    Console.WriteLine("Charm Academy: School of Magic | April_avery");
                    Console.WriteLine("The Devil's Trap | April_Avery\n");
                    Console.WriteLine("Would you like to read the Synopsis?");
                    Console.WriteLine("Enter 1 for Titan Academy of Special Abilities");
                    Console.WriteLine("Enter 2 for Charm Academy: School of Magic");
                    Console.WriteLine("Enter 3 for The Devil's Trap\n");
                    recommend = Console.ReadLine();

                    if (recommend == "1")
                    {
                        Console.WriteLine("Titan Academy is an esteemed school where students train to improve their specials abilities.");
                        Console.WriteLine("However, for seventeen-year-old village girl Shia Sheridan, it's nothing mire than a despicable place where wealth speaks the loudest.");
                        Console.WriteLine("Fate plays a joke on her when her bestfriend, Lucas, beconmes part of a crime committed within the academy, and owning that crime in his stead leads shia to the headmaster and principal. ");
                        Console.WriteLine("Who then offers her a proposal she dare not refuse in exchange for her freedom, she must became one of the special group of students joining the annual survival game called Linus Cup.");
                        Console.WriteLine("Now, not only is she fighting for a spot she did not want in the very academy she hated, but also for her dear life as well.");
                        Console.WriteLine("Can Shia survive till the end?");
                        Console.WriteLine("55,3M Reads | 1.76M Votes | 53 Parts\n");
                    }
                    else if (recommend == "2")
                    {
                        Console.WriteLine("She is Ariela Davis, an ordinary girl with an ordinary life.");
                        Console.WriteLine("Pero dahil sa isang insidente kinailangan niyang lumipat sa bagong school sa gitna ng kaniyang Senior year.");
                        Console.WriteLine("Sa isang Magic School kung saan dating nagtuturo ang kaniyang lola. This story is about magic, adventure, fantasy, romance.");
                        Console.WriteLine("Welcome to CHARM ACADEMY: School of Magic. Where every charm is power.");
                        Console.WriteLine("60.5m Reads | 1.75M Votes | 41 Parts\n");
                    }
                    else if (recommend == "3")
                    {
                        Console.WriteLine("She's my best friend, and she's the thirteenth victim.");
                        Console.WriteLine("Nangako si Althea Denise Limerick at ang best friend nitong si elyse na hindi sila magiging biktima ng kumakalat na serial crime.");
                        Console.WriteLine("But when her bestfriend never came back one night, napagtanto ni Denise na maaring nangyari na ang kinatatakutan niya.");
                        Console.WriteLine("Now it's too late and everything is a mess. Lalo na noong nasangkot sa insidente ang pngalan ng lalakeng yan-Landon Clifford Monaghan, the guy she did everything to avoid.");
                        Console.WriteLine("Subalit dahil sa nangyari mukhang mapipilitan siya na muling harapin ito at masangkot sa mga bagay na matagal niyang iniwasan.");
                        Console.WriteLine("12.6M Reads | 612k Votes | 48 Parts\n");

                    }
                    Console.WriteLine("Enter book you're interested to add:");
                    items.Add(Console.ReadLine());
                    Console.WriteLine("Successfully added  in your Reading List!\n");
                }
                else if (book == "2")
                {
                    Console.WriteLine("Here are some of the Book Recommendations for Romance % Non-Fiction:\n");
                    Console.WriteLine("Something Spectacular | April_avery");
                    Console.WriteLine("Good Night, Enemy | Serialsleeper");
                    Console.WriteLine("Game Series: Book one, Play the Game | Beeyotch\n");
                    Console.WriteLine("Would you like to read the Synopsis?");
                    Console.WriteLine("Enter 1 for Something Spectacular");
                    Console.WriteLine("Enter 2 for Good Night, Enemy");
                    Console.WriteLine("Enter 3 for Game Series: Book one, Play the Game\n");
                    recommend = Console.ReadLine();

                    if (recommend == "1")
                    {
                        Console.WriteLine("Isabelle Dizon was perfect. A straight A business course student, a sensible lady, a responsible daughter any parent would wished for.");
                        Console.WriteLine("But she felt something lacking. She often felt she was living to her parents idea of what she would be, and she started to doubt if that was what she really wanted.");
                        Console.WriteLine("As her uncertainty and longing continued, she met a group of people from a poorly funded, nearly dissolved, university organization.");
                        Console.WriteLine("A group of six university students who taught her the value of friendship, the courage that comes with pursuing her dreams,");
                        Console.WriteLine("and the importance of living in the moment and creating something spectacular.");
                        Console.WriteLine("15.8M Reads | 691k Votes | 41 Parts\n");

                    }
                    if (recommend == "2")
                    {
                        Console.WriteLine("Braylee wants to make her friends happy, Denver wants to get some sleep. She's hell bent on making the world a better place while he's desperate for some rest.");
                        Console.WriteLine("When their paths crossed on a midnight bus ride, he finally found the remedy in her. But it just happens that he's the captain of their rival");
                        Console.WriteLine("basketball team, and the enemy of her friends!");
                        Console.WriteLine("14.6M Reads | 659k Votes | 75 Parts\n");
                    }
                    if (recommend == "3")
                    {
                        Console.WriteLine("For as long as katherine could remeber, Juan Alexandro Yuchengco has always been her dream guy. He's smart, kind, and could be funny when he wanted to...");
                        Console.WriteLine("But the problem was, he never saw her as more than his sister's friend. And she's determined to change that.");
                        Console.WriteLine("She followed him to law school. She made sure that he's aware of her presence and thankfully, her efforts paid off. Finally, Jax was looking her way.");
                        Console.WriteLine("But life is never simple, Life is a game. It's either you win or lose. It's either you get it all or you lose it all.");
                        Console.WriteLine("Kapag alam mong nandyan na, biglang mawawala pala. Kapag akala mong iyon na, may iba pa pala.");
                        Console.WriteLine("29.8M Reads | 996k Votes | 48 Parts\n");
                    }

                    Console.WriteLine("Enter book you're interested to add:");
                    items.Add(Console.ReadLine());
                    Console.WriteLine("Successfully added  in your Reading List!\n");
                }
                else if (book == "3")
                {
                    Console.WriteLine("Here are some of the Book Recommendations for Sci-Fiction/Adventure:\n");
                    Console.WriteLine("Taste of Sky | VentreCanard");
                    Console.WriteLine("Tantei High | Purpleyhan");
                    Console.WriteLine("Lucid Dream | Alyloony\n");

                    Console.WriteLine("Would you like to read the Synopsis?");
                    Console.WriteLine("Enter 1 for Taste of Sky");
                    Console.WriteLine("Enter 2 for Tantei High");
                    Console.WriteLine("Enter 3 for Lucid Dream\n");
                    recommend = Console.ReadLine();

                    if (recommend == "1")
                    {
                        Console.WriteLine("Most women fall for engineers, doctors, lawyers, architects and businessmen but in my case?");
                        Console.WriteLine("I fell inlove with an astronaut.");
                        Console.WriteLine("53.9M Reads| 2.21 Votes | 79 Parts\n");
                    }

                    if (recommend == "2")
                    {
                        Console.WriteLine("Do you have a special talent?\n Do you have a great mind?\n Do you have the courage to fight?\n If you do, then our school is perfect for you.");
                        Console.WriteLine("Talent. Courage. Intellectual mind. The only requirements for enrolling.\n We are the creme of the crop. A school for great people. A school meant for you. TANTEI HIGH.");
                        Console.WriteLine("79.8M Reads | 2.36M Votes | 73 Parts\n");
                    }
                    if (recommend == "3")
                    {
                        Console.WriteLine("Meron iba't ibang paraan ang mga tao para makatakas sa reyalidad. Iyong iba nagbabasa ng libro, nanonood ng mga drama sa tv, nakikinig ng music.");
                        Console.WriteLine("Meron namang nagsusulat, nag drawing, nag p-paint at nag ko-compose ng kanta. Pero si angelique, ang paraan niya ng pagtakas sa reyalidad ay tuwing nanaginip siya.");
                        Console.WriteLine("Dahil meron siyang ibang kakayahan. Ang kakayahan na kontrolin at i-manipulate ang sarili niyang panaginip.");
                        Console.WriteLine("13.6M Reads | 557k Votes | 22 Parts\n");
                    }

                    Console.WriteLine("Enter book you're interested to add:");
                    items.Add(Console.ReadLine());
                    Console.WriteLine("Successfully added  in your Reading List!\n");
                }
                else if (book == "4")
                {
                    Console.WriteLine("Here are some of the Book Recommendations for Mystery, Horror & Thriller:\n");
                    Console.WriteLine("Hell University | KnightInBlack");
                    Console.WriteLine("Project Loki Parts 1-3 | Akosiibarra");
                    Console.WriteLine("Our Deadly Pact | Serialsleeper\n");

                    Console.WriteLine("Would you like to read the Synopsis?");
                    Console.WriteLine("Enter 1 for Hell University");
                    Console.WriteLine("Enter 2 for Project Loki Parts 1-3");
                    Console.WriteLine("Enter 3 for Our Deadly Pact\n");
                    recommend = Console.ReadLine();

                    if (recommend == "1")
                    {
                        Console.WriteLine("A place where everything is mysterious, enchanting, bloody, and shitty. Entering is the other way of suicidal.");
                        Console.WriteLine("Just one wrong move and everything will blur. A lot of secrets are being hid.");
                        Console.WriteLine("Not the typical school to have fun. Death is everywhere. Bad, worse, worst, monster and evil are scattered.\nMust shut your mouth, never against to anyone.");
                        Console.WriteLine("Once you enter, There's no turning back. Never trust your curiosity, it could just drive you straight to hell.\nWELCOME TO HELL UNIVERSITY!");
                        Console.WriteLine("162M Reads | 5.36M Votes | 67 Parts\n");
                    }

                    if (recommend == "2")
                    {
                        Console.WriteLine("Join Lorelei and Loki as they unravel the threads of mystery, unveil the masks of evil intentions ");
                        Console.WriteLine("and put together the pieces of the puzzle in their adventures.");
                        Console.WriteLine("55M REads | 963k Votes | 32 Parts | Book one of Three\n");
                    }
                    if (recommend == "3")
                    {
                        Console.WriteLine("One by one each person who joined the suicide pact gets killed and now its up to the wannabe-detective casper and his crazy friends");
                        Console.WriteLine("to find out the murderer is before they fall victim to their own deadly pact.");
                        Console.WriteLine("5.76M Reads | 183K VOtes | 55 Parts\n ");
                    }

                    Console.WriteLine("Enter book you're interested to add:");
                    items.Add(Console.ReadLine());
                    Console.WriteLine("Successfully added  in your Reading List!\n");
                }
                else if (book == "5")
                {
                    Console.WriteLine("Here are some of the Book Recommendations for Anime Manga:\n");
                    Console.WriteLine("Kimetsu No Yaiba (Demon Slayer) | Gotouge Koyoharu");
                    Console.WriteLine("Promise Neverland | Kaiu Shirai - Demizu Posuka");
                    Console.WriteLine("Dr. Stone | Inagaki Riichiro - Boichi\n");

                    Console.WriteLine("Would you like to read the Synopsis?");
                    Console.WriteLine("Enter 1 for Kimetsu No Yaiba (Demon Slayer)");
                    Console.WriteLine("Enter 2 for Promise Neverland");
                    Console.WriteLine("Enter 3 for Dr. Stone\n");
                    recommend = Console.ReadLine();

                    if (recommend == "1")
                    {
                        Console.WriteLine("Tanjiro is the oldest son in his family who has lost his father. One day, Tanjiro ventures off to another town to sell charcoal.");
                        Console.WriteLine("Instead of going home, he ends up staying the night at someone else's house due to rumors of a demon nearby in the mountains.");
                        Console.WriteLine("When he gets home the following day, a terrible tragedy awaits him.");
                        Console.WriteLine("213.7M Reads | 13,391 Votes | 206 Chapters\n");
                    }

                    if (recommend == "2")
                    {
                        Console.WriteLine("Emma and the other kids have a pretty good life at the orphanage they grew up in. ");
                        Console.WriteLine("Though the rules are strict, their caretaker is kind, and all the children are good friends with each other.");
                        Console.WriteLine("But why are they forbidden from ever leaving?");
                        Console.WriteLine("64.5M Reads | 3,624 Votes | 181 Chapters\n");
                    }
                    if (recommend == "3")
                    {
                        Console.WriteLine("The science-fiction adventure series follows what happens when suddenly the world's biggest-ever 'crisis' arrives.");
                        Console.WriteLine("87.6M Reads | 4,778 Votes | 232 Chapters\n");
                    }

                    Console.WriteLine("Enter book you're interested to add:");
                    items.Add(Console.ReadLine());
                    Console.WriteLine("Successfully added  in your Reading List!\n");
                }

            }
            else if (story == "2")
            {
                Console.WriteLine("Enter book you want to remove:\n");
                items.Remove(Console.ReadLine());
                Console.WriteLine("Successfully removed  in your Reading List!\n");
            }
            else if (story == "3")
            {
                Console.WriteLine("Here's your Reading List:\n");
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            else if (story == "x")
            {
                Console.WriteLine("Closing program");
            }
        }
        while (story == "1" || story == "3" || story == "2");
        Console.WriteLine("");

    }
    static string Story()
    {
        Console.WriteLine("\nWelcome to Bibliophile's Corner!\n");
        Console.WriteLine("Book Recommendations\n");
        Console.WriteLine("Choose your Genre Preference:");
        Console.WriteLine("Enter 1 for Fiction/Fantasy");
        Console.WriteLine("Enter 2 for Romance % Non-Fiction");
        Console.WriteLine("Enter 3 for Sci-Fiction/Adventure");
        Console.WriteLine("Enter 4 for Mystery, Horror & Thriller");
        Console.WriteLine("Enter 5 for Anime Manga\n");
        string num = Console.ReadLine();
        return num;
    }
}
