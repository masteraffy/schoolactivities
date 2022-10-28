
package MidtermExam;

public class Rectangle extends Shape {
    
    private int length, width, area, perimeter;
    public Rectangle(int data1, int data2) {
        super(data1, data2);
        this.length = data1;
        this.width = data2;
    }
    public void computeArea(){
        area = length * width;
    }
    public void computePerimeter(){
        perimeter = 2 * (area + width);
    }
    public int getArea(){
        return area;
    }
    public int getPerimeter(){
        return perimeter;
    }
    
}
