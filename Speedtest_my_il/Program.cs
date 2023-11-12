using System.Timers;

namespace  Speedtest_my_il;

class Program
{
    static void Main()
    {
        string[] texts = new[] { "Разум — это свойство, отличающее человека от других живых существ. Он позволяет нам мыслить, анализировать, решать проблемы и принимать решения. Разум помогает нам учиться, развиваться и прогрессировать." +
                                 "\nЧеловеческий разум способен сотворить великие идеи, произвести достижения в науке, искусстве и технологии, создать сложные общества и формировать культуру. Разум также помогает нам понимать других людей, сочувствовать и сотрудничать." +
                                 "\nОднако разум необходимо развивать и улучшать. Это происходит через образование, самообразование, опыт и постоянное стремление к росту. Развитый разум способен видеть вещи со множества точек зрения, мыслить критически, принимать информированные решения и понимать сложные концепции." };
        Console.WriteLine("Нажмите Enter если вы готовы начать тест!!!");
        ConsoleKeyInfo key = Console.ReadKey();
        
        ThreadStart timer_ = new ThreadStart(timer);
        Thread timers = new Thread(timer_);
        Text_in text_ = new Text_in();
        timers.IsBackground = true;
        if (key.Key == ConsoleKey.Enter)
        {
            
            text_.Text_Soll(texts[0]);
            
            timers.Start();
            
            
        }
        
        
        static void timer()
        { 
            int time = 60;
            while (time != 0)
            {
               Thread.Sleep(100);
                Console.SetCursorPosition(0,6);
                Console.Write(time);
                time--; 
            }
            
        }

       

    }
    
    
}