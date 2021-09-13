using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILPBatchingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            IBatch objBatch = new Batch();
            do
            {
                Console.WriteLine("ILP BATCHING \n ________________ \n 1. Add LG \n 2. Add Associate \n 3.View All Associates \n 4. Edit Associate \n 5. Delete Associate");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Enter the Stream:");
                        string stream = Console.ReadLine();
                        Console.WriteLine("Enter the Date Of Joining (MM/DD/YYYY):");
                        DateTime dateOfJoining = Convert.ToDateTime(Console.ReadLine());
                        try
                        {
                            ILearningGroup ilg = new LearningGroup(stream, dateOfJoining);
                            int newLgId = objBatch.AddLG(ilg);
                            Console.WriteLine("Successfuly Created new Learning Group With ID: " + newLgId + "\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("\n Enter Your Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the LG ID:");
                        int lgID = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            IAssociate assoc = new Associate(name, false, lgID);
                            int ascID = objBatch.AddAssociate(assoc);
                            Console.WriteLine("Successfully Added new Associate With ID: " + ascID);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 3:
                        List<IAssociate> ascList = new List<IAssociate>();
                        ascList = objBatch.ViewAllAssociates();
                        Console.WriteLine("\nThe Associate List is:\n _______________");
                        Console.WriteLine("Name \t Associate ID \t LG ID \t Is GR");
                        ascList.ForEach(asc1 => Console.WriteLine(asc1.Name + "\t" + asc1.AssociateId + "\t" + asc1.LgId + "\t" + asc1.IsGR));
                        //foreach (IAssociate asc1 in ascList)
                        //{
                        //    Console.WriteLine(asc1.Name + "\t" + asc1.AssociateId + "\t" + asc1.LgId + "\t" + asc1.IsGR);
                        //}
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Associate ID");
                        int aid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Do you want tho make this associate GR: (1. Yes 0. No):");
                        int resp = Convert.ToInt32(Console.ReadLine());
                        bool isGR = resp != 0;
                        try
                        {
                            IAssociate asc = objBatch.EditAssociate(aid, isGR);
                            Console.WriteLine("\nAssociate Details ater updation:");
                            Console.WriteLine(asc.AssociateId + "\t" + asc.Name + "\t" + asc.LgId + "\t" + asc.IsGR);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nEnter Learning Group ID to be Deleted:");
                        int lgid = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            int result = objBatch.DeleteLG(lgid);
                            if (result == 1) Console.WriteLine("Successfuly Deleted");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 0: break;

                    default: Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 0);

            Console.ReadLine();
        }
    }
}
