
package Activity;

public class Permanent extends Employee {
    
    private double gross = 0, sss = 0, tax = 0, sales =0, deduction = 0, net =0;
           
    @Override
    public void computeGrossPay(){
        gross = 500 * super.getDaysWork();
    }
    @Override
    public void computeSSS(){
        sss = gross * 0.10;
    }
    @Override
    public void computeTax(){
        tax = gross * 0.12;
    }
    @Override
    public void computeDeduction(){
        deduction = sss + tax;
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
    @Override
    public double getSSS(){
        return sss;
    }
    
    
    
    
}
