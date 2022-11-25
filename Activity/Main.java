
package Activity;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        //variable declaration
        int stats = 0;
        String status ="";

        
        //loop for menu
        
        do{
            System.out.println("[1]Permanent \n[2]Contractual \n[3]On Commission"
                    + "\n[4]Consultant \nInput Choice: ");
            stats = s.nextInt();
            
            if(stats == 1){
                Permanent p = new Permanent();
                status = "Permanent";
                System.out.print("Employee Number: ");
                p.setEmpNo(s.next());
                System.out.print("Name: ");
                p.setName(s.next());
                System.out.print("Position: ");
                p.setPosition(s.next());
                System.out.print("Department: ");
                p.setDepartment(s.next());
                
                System.out.print("Days of Work: ");
                p.setDaysWork(s.nextDouble());
                
                p.computeGrossPay();
                p.computeSSS();
                p.computeTax();
                p.computeDeduction();
                p.computeNetPay();
                
                p.displayAll();
                
                System.out.println("\nStatus : " + status);
                System.out.println("Net Salary : " + p.getNetpay());
                System.out.println("Gross Salary : " + p.getGrosspay());
                System.out.println("SSS : " + p.getSSS());
                System.out.println("Tax : " + p.getTax());
                System.out.println("Deduction : " + p.getDeduction());
                
            }
            else if(stats == 2){
                Contractual c = new Contractual();
                status = "Contractual";
                System.out.print("Employee Number: ");
                c.setEmpNo(s.next());
                System.out.print("Name: ");
                c.setName(s.next());
                System.out.print("Position: ");
                c.setPosition(s.next());
                System.out.print("Department: ");
                c.setDepartment(s.next());
                
                System.out.print("Days of Work: ");
                c.setDaysWork(s.nextDouble());
                
                c.computeGrossPay();
                c.computeSSS();
                c.computeTax();
                c.computeDeduction();
                c.computeNetPay();
                
                c.displayAll();
                
                System.out.println("\nStatus : " + status);
                System.out.println("Net Salary : " + c.getNetpay());
                System.out.println("Gross Salary : " + c.getGrosspay());
                System.out.println("SSS : " + c.getSSS());
                System.out.println("Tax : " + c.getTax());
                System.out.println("Deduction : " + c.getDeduction());
            }
            else if(stats == 3){
                OnCommision oc = new OnCommision();
                status = "On Commission";
                System.out.print("Employee Number: ");
                oc.setEmpNo(s.next());
                System.out.print("Name: ");
                oc.setName(s.next());
                System.out.print("Position: ");
                oc.setPosition(s.next());
                System.out.print("Department: ");
                oc.setDepartment(s.next());
                
                System.out.print("Sales: ");
                oc.setSales(s.nextDouble());
                
                oc.computeGrossPay();
                oc.computeSSS();
                oc.computeTax();
                oc.computeDeduction();
                oc.computeNetPay();
                
                oc.displayAll();
                
                System.out.println("\nStatus : " + status);
                System.out.println("Net Salary : " + oc.getNetpay());
                System.out.println("Gross Salary : " + oc.getGrosspay());
                System.out.println("SSS : " + oc.getSSS());
                System.out.println("Tax : " + oc.getTax());
                System.out.println("Deduction : " + oc.getDeduction());
            }
            else{
                Consultant cs = new Consultant();
                status = "Contractual";
                System.out.print("Employee Number: ");
                cs.setEmpNo(s.next());
                System.out.print("Name: ");
                cs.setName(s.next());
                System.out.print("Position: ");
                cs.setPosition(s.next());
                System.out.print("Department: ");
                cs.setDepartment(s.next());
                
                System.out.print("Days of Work: ");
                cs.setDaysWork(s.nextDouble());
                
                cs.computeGrossPay();
                cs.computeSSS();
                cs.computeTax();
                cs.computeDeduction();
                cs.computeNetPay();
                
                cs.displayAll();
                
                System.out.println("\nStatus : " + status);
                System.out.println("Net Salary : " + cs.getNetpay());
                System.out.println("Gross Salary : " + cs.getGrosspay());
                System.out.println("SSS : " + cs.getSSS());
                System.out.println("Tax : " + cs.getTax());
                System.out.println("Deduction : " + cs.getDeduction());
            }
            

        }while(stats < 1 || stats > 4);
        
    }
}
 
