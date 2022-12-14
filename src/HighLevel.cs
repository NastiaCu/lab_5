using System;

namespace c{
    abstract class HighLevel: Person{

        private Waiter waiter;
        private Client client;

        public HighLevel(Waiter waiter, Client client){
            this.waiter = waiter;
            this.client = client;
        }
        
        public virtual void whatSalary(LowLevel lowlevel, string status, int rating){
            if (lowlevel.rating == 1){
                lowlevel.salary -= 100;
            }

            else if (lowlevel.rating == 2){
                lowlevel.salary -= 50;
            }

            else if (lowlevel.rating == 3){
                lowlevel.salary += 0;
            }

            else if (lowlevel.rating == 4){
                lowlevel.salary += 50;
            }

            else if (lowlevel.rating == 5){
                lowlevel.salary += 100;
            }

            Console.WriteLine("The " + status + " got " + lowlevel.salary);
        } 
        
    }
}