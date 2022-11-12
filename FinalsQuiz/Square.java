
package FinalsQuiz;

public class Square {
    private double side;
    
    protected double area, perimeter;
    
    public Square(double side){
        this.side = side;
    }
    
    public void setSide(double value){
        side = value;
    }
    
    public void computeArea(){
        area = side * side;
    }
    
    public void computePerimeter(){
        perimeter = 4 * side;
    }
    public double getSide(){
        return side;
    }
    public double getArea(){
        return area;
    }
    public double getPerimeter(){
        return perimeter;
    }
}
