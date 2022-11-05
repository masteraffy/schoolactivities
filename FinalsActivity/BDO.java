
package FinalsActivity;
public class BDO extends Bank {
    private double interest;
    //constructor
    public BDO(double balance) {
        super(balance);
    }
    //compute
    @Override
    public void computeInterest(){
        interest = super.getBalance() * 0.02;
    }
    @Override
    public double getInterest(){
        return interest;
    }
    
}
