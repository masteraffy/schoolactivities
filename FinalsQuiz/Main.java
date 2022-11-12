
package FinalsQuiz;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
         Scanner s = new Scanner(System.in);
         
         int choice = 0;
         
         System.out.print("[1]Square \n"
                 + "[2]Rectangle \n"
                 + "[3]Triangle");
         System.out.print("\nInput Choice: ");
         
         choice = s.nextInt();
         
         if(choice == 1){
             Square object1 = new Square(0);
             
             System.out.print("Input side of the square: ");
             object1.setSide(s.nextDouble());
             object1.computeArea();
             object1.computePerimeter();
             
             System.out.println("Area: "+ object1.getArea());
             System.out.println("Perimeter: "+object1.getPerimeter());
         }
         
         else if(choice == 2){
             Rectangle object2 = new Rectangle(0);
             
             System.out.print("Input length of the triangle");
             object2.setLength(s.nextDouble());
             System.out.print("Input width of the triangle");
             object2.setWidth(s.nextDouble());
             
             object2.computeArea();
             object2.computePerimeter();
             
             System.out.println("Area: "+object2.getArea());
             System.out.println("Perimeter: "+object2.getPerimeter());
         }
         
         else if(choice == 3){
             Triangle object3 = new Triangle(0);
             
             System.out.print("Input sideA of the triangle: ");
             object3.setSideA(s.nextDouble());
             System.out.print("Input sideB of the triangle: ");
             object3.setSideB(s.nextDouble());
             System.out.print("Input sideC of the triangle: ");
             object3.setSideC(s.nextDouble());
             System.out.print("Input height of the triangle: ");
             object3.setHeight(s.nextDouble());
             
             
             object3.computeArea();
             object3.computePerimeter();
             
             System.out.println("Area: "+object3.getArea());
             System.out.println("Perimeter: "+object3.getPerimeter());
         }
    }
    
}
