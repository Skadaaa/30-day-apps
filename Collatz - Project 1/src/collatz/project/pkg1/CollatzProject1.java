/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package collatz.project.pkg1;

import java.util.Scanner;

/**
 *
 * @author Skadaa
 */
public class CollatzProject1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
       boolean stare=true;
       while(stare){
           

        System.out.println("Add a number:");
        Scanner x = new Scanner(System.in);
        int i=0;
        int a;
        a = x.nextInt();
        if(a>1){
            
    
        while(a>1)
       {
          if(a%2==0){
              a = a/2;
              System.out.println(a);
          }
          else if (a%2!=0)
          {
              a=a*3+1;
              System.out.println(a);
              
          }
        i++; 
       }
       System.out.println("Steps: "+i);
       
            }
        else System.out.println("Number must be bigger than 1!");  
       
               }
        
        
    }
    
}
