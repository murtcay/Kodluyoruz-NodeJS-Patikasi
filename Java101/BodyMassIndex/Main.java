import java.util.Scanner;

/**
 * Main
 */
public class Main {
  public static void main(String[] args) {
    double weight = 0, height = 0, bmi = 0;
    Scanner input = new Scanner(System.in);

    System.out.print("Please enter your weight in (kg): ");
    weight = input.nextDouble();
    
    System.out.print("Please enter your height in (m): ");
    height = input.nextDouble();
    input.close();

    bmi = weight / (height * height);

    System.out.format("Body Mass Index: %.2f\n", bmi);
  }
}