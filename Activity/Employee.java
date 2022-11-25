
package Activity;
public abstract class Employee {
    private String empNo, name, position, department;
    private double gross, tax, sss, deduction, net, days, sales;
    
    public void setEmpNo(String value){
        empNo = value;
    }
    
    public void setName(String value){
        name = value;
    }
    
    public void setPosition(String value){
        position = value;
    }
    
    public void setDepartment(String value){
        department = value;
    }
    
    public void setDaysWork(double value){
        days = value;
    }
    
    public void setSales(double value){
        sales = value;
    }
    
    public double getSales(){
        return sales;
    }
    
    public double getDaysWork(){
        return days;
    }
    
    public String getEmpNo(){
        return empNo;
    }
    
    public String getPosition(){
        return position;
    }
    
    public String getDepartment(){
        return department;
    }
    
    public double getGrosspay(){
        return gross;
    }
    
    public double getTax(){
        return tax;
    }
    
    public double getDeduction(){
        return deduction;
    }
    
    public double getNetpay(){
        return net;
    }
    
    public double getSSS(){
        return sss;
    }
    
    public void displayAll(){
        System.out.println("Employee Number: " + empNo);
        System.out.println("Name: " + name);
        System.out.println("Position: " + position);
        System.out.print("Department: " + department);
    }
    
    public abstract void computeGrossPay();
    public abstract void computeSSS();
    public abstract void computeTax();
    public abstract void computeDeduction();
    public abstract void computeNetPay();
    
    
    
}

