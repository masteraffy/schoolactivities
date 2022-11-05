
package FinalsActivity;
public class Bank {
    private double balance, interest;
    //constructor
    public Bank(double balance){
        this.balance = balance;
    }
    //setter
    public void setBalance(double value){
        balance = value;
    }
    //compute
    public void computeInterest(){
        interest = balance * 0.01;
    }
    //getter
    public double getBalance(){
        return balance;
    }
    public double getInterest(){
        return interest;
    }
}
