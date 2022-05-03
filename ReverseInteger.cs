using System;

namespace Data_Structures
{
    public static class ReverseIntegers
    {

        public static int Reverse(int x) {
        int returnNumber = 0;
        
        while(x != 0)
        {
            // 123
            returnNumber = returnNumber * 10 + x % 10;
            Console.WriteLine ($"return ,{returnNumber}");
            x= x/10;
            if(returnNumber > Int32.MaxValue) return 0;
            else if(returnNumber < Int32.MinValue) return 0;
            Console.WriteLine ($"Reverse Integer: {returnNumber}");
        }
        return returnNumber;
        }

        public static int ReverseInt(int x){ 
        string reverse = "";
        string y = x.ToString();
        bool isNagativeFlag = false;
        
        if(y[0] =='-')
        {
            isNagativeFlag= true;
        }
       
        for(int i = y.Length-1; i >= 0; i--)
        {
            if(isNagativeFlag && i ==0) break;
            else
            reverse += y[i];
        }
        var result = (isNagativeFlag)?$"-{reverse}":reverse;
        
        long retVal = Convert.ToInt64(result);
        if(retVal >= Int32.MaxValue || retVal <= Int32.MinValue) retVal=0;
        Console.WriteLine ($"Reverse Integer: {retVal}");
        return (int)retVal;
        
       }

        public static int ReverseInteger(int x)
        {
            string y= x.ToString();
            char[] charArr = y.ToCharArray();
            string revStr = "";
            for(int i = charArr.Length-1; i >= 0; i--)
            {
                 revStr+= charArr[i];
            }
            Console.WriteLine ($"Reverse Integer: {revStr}");
            return Convert.ToInt32(revStr);
        }

    }
}    
    
