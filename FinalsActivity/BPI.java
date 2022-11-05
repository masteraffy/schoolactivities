
package FinalsActivity;
public class BPI extends Bank{
    private double interest;
    //constructor
    public BPI(double balance) {
        super(balance);
    }
    //compute
    @Override
    public void computeInterest(){
        interest = super.getBalance() * 0.03;
    }
    //getter
    @Override
    public double getInterest(){
        return interest;
    }
}
