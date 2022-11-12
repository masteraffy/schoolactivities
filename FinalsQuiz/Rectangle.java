
package FinalsQuiz;

public class Rectangle extends Square {
    
    private double length, width;
    protected double area, perimeter;
   
    public Rectangle(double side) {
        super(side);
    }
    
    public void setLength(double value){
        length = value;
    }
    public void setWidth(double value){
        width = value;
    }
    @Override
    public void computeArea(){
        area = length * width;
    }
    @Override
    public void computePerimeter(){
        perimeter = 2 * (length + width);
    }
    @Override
    public double getArea(){
        return area;
    }
    @Override
    public double getPerimeter(){
        return perimeter;
    }
    public double getLength(){
        return length;
    }
    public double getWiwdth(){
        return width;
    }
    
    
}
