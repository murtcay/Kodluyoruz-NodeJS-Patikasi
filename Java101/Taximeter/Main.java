import java.util.Scanner;

/**
 * Main
 */
public class Main {

  public static void main(String[] args) {
    Scanner input = new Scanner(System.in);

    double distance = 0, perKm = 2.2, startingPrice = 10, totalCharge = 0;
    
    System.out.print("Please enter the travel distance in km: ");
    distance = input.nextDouble();
    input.close();

    totalCharge = startingPrice + distance * perKm;
    totalCharge = (totalCharge < 20) ? 20 : totalCharge;

    System.out.format("Total Charge: %.2f TL\n", totalCharge);
  }
}