using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    interface SmartPhoneDet
    {
        void CallLog();
        void DialLastCall(Stack<double> s);
    }
    class SmartPhone:SmartPhoneDet
    {
        public void CallLog()
        {
            Stack<double> call = new Stack<double>();
            call.Push(1253648393);
            call.Push(2789463475);
            call.Push(3753159222);
            call.Push(4951753121);
            call.Push(4268415783);
            call.Push(6486312969);
            call.Push(7794315753);
            call.Push(9863175733);
            call.Push(9832256487);
            call.Push(9635321452);
        
            foreach(var num in call) { 
                Console.WriteLine(num);
            }
            DialLastCall(call);
        }
        public void DialLastCall(Stack<double> s)
        {
            foreach (var item in s)
            {
                Console.WriteLine("Last Dialled Call: " + item);
                break;
            }
            Console.WriteLine("Call Duration: 00:12:48");            
        }
        
    }

}
