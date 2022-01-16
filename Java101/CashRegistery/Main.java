import java.util.Scanner;

/**
 * Main
 */
public class Main {
  public static void main(String[] args) {
    final double PEAR_PRICE = 2.14;
    final double APPLE_PRICE = 3.67;
    final double TOMATOES_PRICE = 1.11;
    final double BANANA_PRICE = 0.95;
    final double EGGPLANT_PRICE = 5.0;
    
    double pearKg = 0, pearPrice = 0;
    double appleKg = 0, applePrice = 0;
    double tomatoesKg = 0, tomatoesPrice = 0;
    double bananaKg = 0, bananaPrice = 0;
    double eggplantKg = 0, eggplantPrice = 0;
    double totalPrice = 0;

    Scanner input = new Scanner(System.in);

    System.out.print("How many Kg of Pears: ");
    pearKg = input.nextDouble();
    
    System.out.print("How many Kg of Apples: ");
    appleKg = input.nextDouble();
    
    System.out.print("how many Kg of Tomatoes: ");
    tomatoesKg = input.nextDouble();
    
    System.out.print("how many Kg of Bananas: ");
    bananaKg = input.nextDouble();

    System.out.print("how many Kg of Eggplant: "); 
    eggplantKg = input.nextDouble();

    input.close();

    pearPrice = pearKg * PEAR_PRICE;
    applePrice = appleKg * APPLE_PRICE;
    tomatoesPrice = tomatoesKg * TOMATOES_PRICE;
    bananaPrice = bananaKg * BANANA_PRICE;
    eggplantPrice = eggplantKg * EGGPLANT_PRICE;

    totalPrice = pearPrice + applePrice + tomatoesPrice + bananaPrice + eggplantPrice;

    System.out.format("Total Charge: %.2f\n", totalPrice);
    
  }
}