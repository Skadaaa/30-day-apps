/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package eratostene.pkg2;

import java.util.Vector;

/**
 *
 * @author Skadaa
 */
public class Eratostene2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Vector v = new Vector(100);
        int i;
        for(i=0;i<100;i++)
        {
            v.add(i);
        }
        for(i=0;i<100;i++)
        {   int a=(int) v.get(i);
            
        
        if(a%3==0&&a%5==0)
            {
             v.set(i, "FizzBuzz");
            }
        else if(a%3==0)
        {
            v.set(i,"Fizz");
        }
        else if(a%5==0)
        {
            v.set(i,"Buzz");
        }
        }
        
        System.out.println(v);
        
    }
    
}
