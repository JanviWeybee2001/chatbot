using System;
using System.Linq;
using System.Reflection.Emit;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class QuetionsBank
    {
        public int id { get; set; }
        public string ? quetion { get; set; }
        public string ? quetionType { get; set; }
        public int gotoNextQuetion { get; set; }
    }

    public class OptionsOfChoice
    {
        public int quetionId { get; set; }
        public int optionId { get; set; }
        public string OptionsDescription { get; set; }
        public int gotoNextQuetionId { get; set; }
    }

    public class userReply
    {
        public int quetionId { get; set; }
        public string ? userReplys { get; set; }
    }

    internal class Program
    {   
        static void Main(string[] args)
        {
            List<QuetionsBank> quetionsBanks = new List<QuetionsBank>();
            List<OptionsOfChoice> optionsOfChoices = new List<OptionsOfChoice>();


            //-------------------------------------------------------Make Your Bot's work Flow-------------------------------------------------------
            Console.WriteLine("Make a Your bot :");
            Console.WriteLine("1. Message \n2. Quetions \n3. Single choice \n4.End");
            int n = Convert.ToInt32(Console.ReadLine());
            int index = 0,Id = 0, gotonext;
            while (n!=4)
            {
                switch(n)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter your Message");
                            forMessage:
                            string tempMessage = Console.ReadLine();
                            if (tempMessage != "" && tempMessage != null)
                            {
                                Id++;
                                Console.WriteLine("Do you want to decide which message will show after this ? if yes, then write YES. else NO");
                                if (Console.ReadLine().ToUpper() == "YES")
                                {
                                    foreach(QuetionsBank item in quetionsBanks)
                                    {
                                        Console.WriteLine(item.id.ToString() + " = " +  item.quetion);
                                    }
                                    Console.WriteLine("Enter Id");
                                    string gotoid =  Console.ReadLine();
                                    if (gotoid != "" && gotoid != null)
                                    {
                                        gotonext = Convert.ToInt32(gotoid);
                                    }
                                    else
                                    {
                                        gotonext = 0;
                                    }
                                    quetionsBanks.Add(new QuetionsBank() { id = Id, quetion = tempMessage, quetionType = "Message", gotoNextQuetion = gotonext });
                                }
                                else
                                {
                                    quetionsBanks.Add(new QuetionsBank() { id = Id, quetion = tempMessage, quetionType = "Message", gotoNextQuetion = 0 });
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please Write Message first");
                                goto forMessage;
                            }
                        }
                        break;                      
                    case 2:
                        {
                            Console.WriteLine("Enter Your quetion");
                            forQuetion:
                            string tempQuetion = Console.ReadLine();
                            if (tempQuetion != "" && tempQuetion!=null)
                            {
                                Id++;
                                Console.WriteLine("Do you want to decide which message/Quetion will show after this ? if yes, then write YES. else NO");
                                if (Console.ReadLine().ToUpper() == "YES")
                                {
                                    foreach (QuetionsBank item in quetionsBanks)
                                    {
                                        Console.WriteLine(item.id.ToString() + " = " + item.quetion);
                                    }
                                    Console.WriteLine("Enter Id");
                                    string gotoid = Console.ReadLine();
                                    if(gotoid != "" && gotoid!=null)
                                    {
                                        gotonext = Convert.ToInt32(gotoid);
                                    }
                                    else
                                    {
                                        gotonext = 0;
                                    }
                                    quetionsBanks.Add(new QuetionsBank() { id = Id, quetion = tempQuetion, quetionType = "Quetion", gotoNextQuetion = gotonext });
                                }
                                else
                                {
                                    quetionsBanks.Add(new QuetionsBank() { id = Id, quetion = tempQuetion, quetionType = "Quetion", gotoNextQuetion = 0 });
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please Write Quetion first");
                                goto forQuetion;
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter Your Single choice quetion");
                            forSingleChoice:
                            string tempSinglechoice = Console.ReadLine();
                            if (tempSinglechoice != "" && tempSinglechoice != null)
                            {
                                Id++;
                                addOption:
                                Console.WriteLine("Add an option's value");
                                string options = Console.ReadLine();
                                if (options != "" && options != null)
                                {
                                    index++;
                                    Console.WriteLine("Do you want to decide which message/Quetion will show on select this option ? if yes, then write YES. else NO");
                                    if (Console.ReadLine().ToUpper() == "YES")
                                    {
                                        foreach (QuetionsBank item in quetionsBanks)
                                        {
                                            Console.WriteLine(item.id.ToString() + " = " + item.quetion);
                                        }
                                        Console.WriteLine("Enter Id");
                                        string gotoid = Console.ReadLine();
                                        if (gotoid != "" && gotoid != null)
                                        {
                                            gotonext = Convert.ToInt32(gotoid);
                                        }
                                        else
                                        {
                                            gotonext = 0;
                                        }
                                        optionsOfChoices.Add(new OptionsOfChoice() { optionId = index, OptionsDescription = options, quetionId = Id, gotoNextQuetionId = gotonext });
                                    }
                                    else
                                    {
                                        optionsOfChoices.Add(new OptionsOfChoice() { optionId = index, OptionsDescription = options, quetionId = Id, gotoNextQuetionId = 0 });
                                    }
                                    Console.WriteLine("Do you want to add another options ? if yes, then write YES. else NO");
                                    if (Console.ReadLine().ToUpper() == "YES")
                                    {
                                        goto addOption;
                                    }
                                    quetionsBanks.Add(new QuetionsBank() { id = Id, quetion = tempSinglechoice, quetionType = "SingleChoice", gotoNextQuetion = 0 });
                                }
                                else
                                {
                                    Console.WriteLine("Enter a option value");
                                    goto addOption;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please Write Single choice Quetion first");
                                goto forSingleChoice;
                            }
                        }
                        break;
                    case 4:
                        {
                            Id++;
                            quetionsBanks.Add(new QuetionsBank() { id = Id, quetion = "End Chat", quetionType = "endChat", gotoNextQuetion = 0 });
                        }
                        break;
                    default:
                        Console.WriteLine("Enter valid Choice");
                        break;
                }
                Console.WriteLine("\n1. Message \n2. Quetions \n3. Single choice \n4.End");
                string choice = Console.ReadLine();
                if(choice == null)
                {
                    Console.WriteLine("Enter Choice");
                }
                else
                {
                   n =  Convert.ToInt32(choice);
                }
            }

            //-------------------------------------------------------Your Bot's work Flow-------------------------------------------------------
            for (int i=0; i< quetionsBanks.Count(); i++)
            {
                Console.WriteLine(quetionsBanks[i].quetion);
                if (quetionsBanks[i].quetionType == "SingleChoice")
                {
                    List<string> options = optionsOfChoices.Where(option => option.quetionId == quetionsBanks[i].id).Select(option => option.OptionsDescription).ToList();

                    foreach (string option in options)
                    {
                        Console.WriteLine(option);
                    }
                }
            }

            //-------------------------------------------------------Test Your BOT-------------------------------------------------------

            List<userReply> userReplies = new List<userReply>();

            Console.WriteLine("\nNow, It's time to Check your BOT ;)");
            string sayBye = " ";
            while (sayBye != "Bye")
            {
                for (int i = 0; i < quetionsBanks.Count(); i++)
                {
                    Console.WriteLine(quetionsBanks[i].quetion);
                    if (quetionsBanks[i].quetionType == "Message")
                    {
                        if (quetionsBanks[i].gotoNextQuetion != 0)
                        {
                            i = quetionsBanks[i].gotoNextQuetion - 2;
                        }
                    }
                    else if (quetionsBanks[i].quetionType == "Quetion")
                    {
                    foruserReply:
                        string reply = Console.ReadLine();
                        if (reply != null && reply != "")
                            userReplies.Add(new userReply() { quetionId = quetionsBanks[i].id, userReplys = reply });
                        else
                        {
                            Console.WriteLine("Enter correct value");
                            goto foruserReply;
                        }
                        if (quetionsBanks[i].gotoNextQuetion != 0)
                        {
                            i = quetionsBanks[i].gotoNextQuetion - 2;
                        }
                    }
                    else if (quetionsBanks[i].quetionType == "SingleChoice")
                    {
                        Console.WriteLine("Select One option");
                        List<string> options = optionsOfChoices.Where(option => option.quetionId == quetionsBanks[i].id).Select(option => option.OptionsDescription).ToList();

                        foreach (string option in options)
                        {
                            Console.WriteLine(option);
                        }
                        string reply = Console.ReadLine();
                        int replyId = optionsOfChoices.Where(option => option.OptionsDescription.ToLower() == reply.ToLower() && option.quetionId == quetionsBanks[i].id).Select(id => id.optionId).FirstOrDefault();
                        userReplies.Add(new userReply() { quetionId = quetionsBanks[i].id, userReplys = reply });
                        int goTo = optionsOfChoices.Where(option => option.optionId == replyId).Select(gotonext => gotonext.gotoNextQuetionId).FirstOrDefault();
                        if (goTo != 0)
                        {
                            i = goTo - 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ending your Chat");
                    }
                }
                Console.WriteLine("Close converation with chatbot say 'Bye'");
                sayBye = Console.ReadLine();
            }
        }
    }
}