import java.util.Scanner;

/**
 * Main
 */
public class Main {

  public static void main(String[] args) {
    Scanner inputPrice = new Scanner(System.in);
    
    System.out.print("Please enter total price: ");
    double price = inputPrice.nextDouble();

    double vatRatio = (price < 1000) ? 0.18 : 0.08;
    double fee = vatRatio * price;
    double totalPrice = price + fee;

    inputPrice.close();

    System.out.println("Price: " + price);
    System.out.println("VAT ratio: " + vatRatio);
    System.out.println("Fee: " + fee);
    System.out.println("Total Amount: " + totalPrice);

  }
}