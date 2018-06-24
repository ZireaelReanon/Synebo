using System;

class Solution { public int solution(int A, int B); }

{
    int count = 0;

    
    if (A < B)
    {
      
        if (A < 0 && B < 0) return count;

        
        if (A <= 0) A = 1;
        
        int sqrtA = (int)Math.Sqrt(A);
        int sqrtB = (int)Math.Sqrt(B);
        count = sqrtB - sqrtA;
       
        if (A == sqrtA * sqrtA)
        {
            count++;
        }
    }

    return count;
}
