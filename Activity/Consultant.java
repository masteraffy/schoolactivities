
package Activity;

public class Consultant extends Employee {
    private double gross = 0, sss = 0, tax = 0, sales =0, deduction = 0, net =0;
    
    @Override
    public void computeGrossPay(){
        gross = 650 * super.getDaysWork();
    }
    @Override
    public void computeSSS(){
        sss = 0;
    }
    @Override
    public void computeTax(){
        tax = 0;
    }
    @Override
    public void computeDeduction(){
        deduction = 0;
    }
    @Override
    public void computeNetPay(){
        net = gross - deduction;
    }
    
    @Override
    public double getGrosspay(){
        return gross;
    }
    @Override
    public double getTax(){
        return tax;
    }
    @Override
    public double getDeduction(){
        return deduction;
    }
    @Override
    public double getNetpay(){
        return net;
    }
}
