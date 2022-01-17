import java.util.Scanner;

/**
 * Main
 */
public class Main {

  public static void main(String[] args) {
    Scanner input = new Scanner(System.in);
    int num1 = 0, num2 = 0, selection = 0;

    System.out.println("Math Operations:\n");
    System.out.println("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n");
    
    System.out.print("1st Number: ");
    num1 = input.nextInt();
    
    System.out.print("2nd Number: ");
    num2 = input.nextInt();
    
    System.out.print("\nOperation: ");
    selection = input.nextInt();
    
    input.close();

    switch (selection) {
      case 1:
        System.out.println("Result: " + (num1 + num2));
        break;
      case 2:
        System.out.println("Result: " + (num1 - num2));
        break;
      case 3:
        System.out.println("Result: " + (num1 * num2));
        break;
      case 4:
        System.out.println("Result: " + ((num2 != 0) ? (num1 / num2) : "Infinite"));
        break;
      default:
        System.out.println("Wrong Choice of Math Operation.");
        break;
    }
  }
}