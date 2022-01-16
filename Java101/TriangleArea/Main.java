import java.util.Scanner;

/**
 * Main
 * 
 * Triangle Area Calculator from edge lengths
 * 
 * perimeter = (a+b+c)
 * u = perimeter / 2
 * area * area = (u * (u - a) * (u - b) * (u - c))
 * 
 */
public class Main {

  public static void main(String[] args) {
    Scanner inputEdge = new Scanner(System.in);
    System.out.println("Triangle Area Calculator");
    System.out.print("Please enter the length of edge1 in cm: ");
    double edge1 = inputEdge.nextDouble();
    
    System.out.print("Please enter the length of edge2 in cm: ");
    double edge2 = inputEdge.nextDouble();
    
    System.out.print("Please enter the length of edge3 in cm: ");
    double edge3 = inputEdge.nextDouble();
    
    inputEdge.close();

    double u =  (edge1 + edge2 + edge3)/2;
    double area = Math.sqrt(u * (u - edge1) * (u - edge2) * (u - edge3));
    
    System.out.format("Area: %.2f\n", area);

  }
}