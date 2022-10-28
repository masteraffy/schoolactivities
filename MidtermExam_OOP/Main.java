
package MidtermExam;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
       Scanner s = new Scanner(System.in);
       int choice;
       System.out.println("Enter Choice: \n1. Prism \n2.Rectangle");
       choice = s.nextInt();
       
       if(choice == 1){
           System.out.println("You have selected Prism");
           Prism p = new Prism(20, 10, 15);
           p.computeArea();
           p.computeVolume();
           
           System.out.println("Area is: "+ p.getArea() + "\n"
                   + "Volume is: "+p.getVolume());
       }
       else if(choice ==2){
           System.out.println("You have selected Rectangle");
           Rectangle r = new Rectangle(20, 10);
           r.computeArea();
           r.computePerimeter();
           
           System.out.println("Area is: "+r.getArea() + "\n"
                   + "Perimeter: "+ r.getPerimeter());
       }
    }
    
}
