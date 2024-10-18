



namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool f = false;

            int GulleSayi;
            int GulleninLimiti;
            bool AtmaqucunMod;


               
                      Weapon weapon = new Weapon();
            do
            {
                Console.WriteLine("0:Informasiya almaq ucun;1:shoot metodu ucun;2:GetRemainBulletCount metodu ucun;3:Reload metodu ucun ; 4:ChangeFireMode metodu ucun;5:proqramdan dayandirmaq ucun");
                int operation;
                int.TryParse(Console.ReadLine(), out operation);    
           


                switch(operation)
                {
                    case 0:
                        
                        do {
                            Console.WriteLine("gulle sayi daxil edin");
                         a=int.TryParse(Console.ReadLine(), out GulleSayi);
                        
                            if (a=true)
                            {
                                int.Parse(GulleSayi)

                            }
                         Console.WriteLine("gulle limiti daxil edin");
                            b=int.TryParse(Console.ReadLine(),out GulleninLimiti);
                            if (b = true)
                            {
                                int.Parse(GulleninLimiti)
    
                            }
                            Console.WriteLine("gulle atmaq modu:");
                            bool.TryParse(Console.ReadLine(), out AtmaqucunMod);
                            
                           
                        } while (false);

                        weapon = new Weapon(GulleninLimiti,GulleSayi,AtmaqucunMod);

                        

                        break;

                    case 1:
                        weapon.Shoot();
                        break;

                        case 2:
                        weapon.Reload();
                            break;

                        case 3:
                        weapon.GetRemainBulletCount();
                            break;

                        case 4:
                        weapon.ChangeFireMode();
                            break;

                        case 5:
                        f = true;
                        break ;


                        default:
                        break;

                }
            } while (!f); 


        }
    }
}
