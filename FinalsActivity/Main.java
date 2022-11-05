package FinalsActivity;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int choice;
        System.out.print("Please Choose on the following: \n"
                + "[1]BDO \n"
                + "[2]BPI \n"
                + "[3]HSBC \n"
                + "Enter Choice: ");
        choice = sc.nextInt();
        
            if(choice == 1){
            BDO object1 = new BDO(0);
            System.out.print("Enter Outstanding Balance: ");
            object1.setBalance(sc.nextDouble());
            object1.computeInterest();
            System.out.println("BDO Interest: " + object1.getInterest());
        } else if(choice == 2){
            BPI object2 = new BPI(0);
            System.out.print("Enter Outstanding Balance: ");
            object2.setBalance(sc.nextDouble());
            object2.computeInterest();
            System.out.println("BPI Interest: " + object2.getInterest());
        } else if(choice == 3){
            HSBC object3 = new HSBC(0);
            System.out.print("Enter Outstanding Balance: ");
            object3.setBalance(sc.nextDouble());
            object3.computeInterest();
            System.out.println("HSBC Interest: " + object3.getInterest());
        } else{
            System.out.println("Invalid Choice!");
        }
    }
}
