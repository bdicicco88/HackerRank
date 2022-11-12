 for(int i =1; i <=n; i++)
        {
         var returnStr = "";
            if (i % 3 == 0)
            {
                returnStr += "Fizz";
            }
            if (i % 5 == 0)
            {
                returnStr += "Buzz";
            }
           
            if (String.IsNullOrEmpty(returnStr))
            {
                Console.WriteLine(i.ToString());
            }
            else{
              Console.WriteLine(returnStr);  
            }
        } 