/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package prime.facts.pkg3;

import static java.lang.Math.sqrt;
import java.util.Scanner;
import java.util.Vector;

/**
 *
 * @author Skadaa
 */
public class PrimeFacts3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        boolean state = false;
         Scanner x = new Scanner(System.in);
           int i;
          int divnr = 0;
        Vector v = new Vector();
        do{
            
       
        System.out.println("Add a number: ");
        
       
        
        int nr = x.nextInt();
        
        
       
       
        
        
      
        

    
            
        
        
        if(nr>2)
        {   
            for(i=2;i<=nr/2;i++)
            {
                if(nr%i==0)
                {
                  
                   divnr++; 
                    
                
                }
            
               
               
            
            }
             if(divnr==0)
            {
                v.add(nr);
            }
           
        }
            System.out.println("Add another number?");
        String dec = x.next();
        if("Yes".equals(dec))
        {
            state=true;
            
        }
        else state=false;
        }while(state==true);
        System.out.println(v);
        
    }
}
        
    
        
        
        
        
        
        
    
    

