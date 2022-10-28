
package MidtermExam;

public class Prism extends Shape {

    private int area, volume, length, width, height;
    
    public Prism(int data1, int data2, int height) {
        super(data1, data2);
        this.height = height;
        this.length = data1;
        this.width = data2;
    }
    public void setHeight(int value){
        height = value;
    }
    public void computeArea(){
        area = 2 * ((length * width) + (height * length) + (height * width));
    }
    public void computeVolume(){
        volume = length * width * height;
    }
    public int getArea(){
        return area;
    }
    public int getVolume(){
        return volume;
    }
}
