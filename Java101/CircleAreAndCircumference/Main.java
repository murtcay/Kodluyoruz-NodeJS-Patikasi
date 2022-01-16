import java.util.Scanner;

/**
 * Main
 */
public class Main {
  public static void main(String[] args) {
    final double PI = 3.14;
    double radius = 0, angle = 0, area = 0;
    Scanner input  = new Scanner(System.in);

    System.out.print("Please enter radius of the circle in cm: ");
    radius = input.nextDouble();
    
    System.out.print("Please enter ange of the circle slice in degree: ");
    angle = input.nextDouble();

    input.close();

    area = PI * radius * radius * angle / 360;

    System.out.format("Area: %.2f cm2\n", area);
  }
}