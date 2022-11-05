
package FinalsActivity;
public class HSBC extends Bank {
    private double interest;
    //constructor
    public HSBC(double balance) {
        super(balance);
    }
    //compute
    @Override
    public void computeInterest(){
        interest = super.getBalance() * 0.04;
    }
    @Override
    public double getInterest(){
        return interest;
    }
}
