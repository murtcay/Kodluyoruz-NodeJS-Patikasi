import java.util.Scanner;

/**
 * Main
 */
public class Main {
  public static void main(String[] args) {
    
    Scanner input = new Scanner(System.in);
    int gradeMath = 0, gradePhysics= 0, gradeChemistry = 0;
    int gradeTurkish= 0, gradeHistory= 0, gradeMusic = 0;
    
    System.out.print("Grade of Math Course : ");
    gradeMath = input.nextInt();
    if(gradeMath > 100)  gradeMath = 100;
    
    System.out.print("Grade of Physics Course : ");
    gradePhysics = input.nextInt();
    if(gradePhysics > 100)  gradePhysics = 100;
    
    System.out.print("Grade of Chemistry Course : ");
    gradeChemistry = input.nextInt();
    if(gradeChemistry > 100)  gradeChemistry = 100;
    
    System.out.print("Grade of Turkish Course : ");
    gradeTurkish = input.nextInt();
    if(gradeTurkish > 100)  gradeTurkish = 100;
    
    System.out.print("Grade of History Course : ");
    gradeHistory = input.nextInt();
    if(gradeHistory > 100)  gradeHistory = 100;
    
    System.out.print("Grade of Music Course : ");
    gradeMusic = input.nextInt();
    if(gradeMusic > 100)  gradeMusic = 100;
    
    input.close();

    int avg = (gradeMath + gradePhysics + gradeChemistry + gradeTurkish + gradeHistory + gradeMusic)/6;
    System.out.println("\nAverage: " + avg);
    
    if(avg > 60) {
      System.out.println("Passed.");
    }
    else {
      System.out.println("Failed.");
    }
  }
}