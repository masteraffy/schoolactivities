
package FinalsQuiz;

public class Triangle extends Square {
    
    private double height, sideA, sideB, sideC;
    protected double area, perimeter;
    
    public Triangle(double side) {
        super(side);
        this.sideA = side;
    }
    
    public void setSideA(double value){
        sideA = value;
    }
    public void setSideB(double value){
        sideB = value;
    }
    public void setSideC(double value){
        sideC = value;
    }
    public void setHeight(double value){
        height = value;
    }
    @Override
    public void computeArea(){
        area = (sideB * height) / 2;
    }
    @Override
    public void computePerimeter(){
        perimeter = sideA + sideB + sideC;
    }
    @Override
    public double getArea(){
        return area;
    }
    @Override
    public double getPerimeter(){
        return perimeter;
    }
}
