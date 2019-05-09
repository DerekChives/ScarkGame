﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Scark.ast;

namespace Scark.ast.start
{
    public class CC
    {
        //NewPlayer function
        public string[] NewPlayer()
        {
            //declare The New T's And C's Of The New Player
            string[] CharacterInfo = new string[3];

            //Story Line
            wd("You carefully aim your crossbow directly at the King's chest.");
                
            wd("A bloodstained crossbow loaded with a lead bolt sits in your sweaty hand as you observe the speech from a ramshackle building.");

            wd("Your finger pulls the trigger.");
                
            wd("You hear an instant uproar as the King's body topples down the stone stairs.");
                
            wd("In the midst of all the confusion, you begin running.");
                
            wd("Suddenly, a baton bludgeons you from behind.");
            if (!Menu.dev)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Thread.Sleep(3000);
            }

            wd("You wake up in a mysterious place and realize where you are...");
                
            wd("You have been arrested for treason to the king. You are walked up to the gallows to which you will be executed.");
                
            wd("The executioner firms his grasp around the lever. Before he pulls the lever he mumbles a quick prayer.");
               
            wd("[EXECUTIONER] Does anybody object to this her' hanging?");
                
            wd("Silence.");
                
            wd("As the executioner moves his hand towards the lever, a voice shouts out.");
                
            wd("[VOICE] I object!");
                
            wd("The executioner's eyes fix upon the man who called.");
                
            wd("[EXECUTIONER] Arr, an' who d'ya think you ar'?");
                
            wd("[VOICE] Lord Wakehart, the explorer.");
                
            wd("[LORD WAKEHART] I wish to pardon this kid.");
                
            wd("The executioner has no choice but to obey the laws, Wakehart's lordship grants him power to pardon anyone he wishes.");
                
            wd("The rope is loosened around your neck as you are escorted into the disappointed audience by Lord Wakehart.");
                

            wd("[LORD WAKEHART] Hey kid, what's your name?");
            Console.Write("> ");
            CharacterInfo[0] = Console.ReadLine();
            
            wd($"[LORD WAKEHART] Hey, {CharacterInfo[0]}. Don't think I'm pardoning you for nothing, nah.");
                
            wd("[LORD WAKEHART] I've a quest for you, and if you succeed, you'll be a very rich man.");
                
            wd("[LORD WAKEHART] Ha ha, I'm guessing you want to know what this quest involves!");
                
            wd("[LORD WAKEHART] Well, I need a brave adventurer to go to the island of Scark.");
                
            wd("[LORD WAKEHART] I'll tell you more when we get there, kid.");
                
            wd("Before you can say anything, you are rushed off to a training fort...");

            Console.Clear();

            //Training Fort
            

            wd("[TRAINER] So.");
            wd("[TRAINER] I see that the idiot Wakehead or whatever the hell his name is has pardoned you.");
            wd("[TRAINER] Well, I guess I'll have to obey.");
            wd("[TRAINER] So kid, how'll your flimsy little limbs fight, eh?");
            wd("[TRAINER] Don't know what I'm talking about?");
            wd("[TRAINER] Not surprised, from some wanna-be revolutionist like yourself.");
            wd("[TRAINER] Forgive me, but your attempt on the glorious King's life was futile at best.");
            wd("[TRAINER] At worst?");
            wd("[TRAINER] Ha ha ha ha.");
            wd("[TRAINER] Well anyways, I can train you in four classes.");
            wd("[TRAINER] Rouge, warrior, ranger or mage.");

            Console.WriteLine(
                "\nThe trainer asks you how you like to fight \n" +
                "[1] Rouge\n[2] Warrior\n[3] Ranger\n[4] Mage\n" +
                "Please select a role by inputting a number\n");

            bool userPickedOption = false;
            while (userPickedOption == false)
            {
                Console.Write("> ");
                CharacterInfo[1] = Console.ReadLine();
                switch (CharacterInfo[1])
                {
                    case "1": // Rouge
                        CharacterInfo[1] = "Rouge";
                        Console.WriteLine("You are trained in basic Stealth and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        Thread.Sleep(1500);
                        break;
                    case "2": // Warrior
                        CharacterInfo[1] = "Warrior";
                        Console.WriteLine("You are trained in basic Combat and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        Thread.Sleep(1500);
                        break;
                    case "3": // Ranger
                        CharacterInfo[1] = "Ranger";
                        Console.WriteLine("You are trained in basic Archery and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        Thread.Sleep(1500);
                        break;
                    case "4": // Mage
                        CharacterInfo[1] = "Mage";
                        Console.WriteLine("You are trained in basic Magery and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        Thread.Sleep(1500);
                        break;

                    default:
                        Console.WriteLine("Please input a valid number between 1 and 4!");
                        break;
                }
            }

            //Sean Write Some More Story
            CharacterInfo[2] = "1";
            return CharacterInfo;
        }

        public void wd(string text) // write dialogue and wait 1.5 s
        {
            Console.WriteLine("\n"+text);
            if (!start.Menu.dev)
            {
                // Console.Write("[DEV: {0}]", start.Menu.dev);
                Thread.Sleep(SettingsMenu.dialogueSpeed);
            }

        }
    }
}
