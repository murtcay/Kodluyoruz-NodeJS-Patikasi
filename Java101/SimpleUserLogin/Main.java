import java.util.Scanner;

/**
 * Main
 */
public class Main {

  public static void main(String[] args) {
    Scanner input = new Scanner(System.in);

    String USER_NAME = "patika";
    String userName, password, oldPassword = "java101";

    System.out.print("Username: ");
    userName = input.nextLine();
    
    System.out.print("Password: ");
    password = input.nextLine();


    if(userName.equals(USER_NAME) && password.equals(oldPassword)) {
      System.out.println("Loged in.");
    }
    else if(userName.equals(USER_NAME) && !password.equals(oldPassword)) {
      // ask reset or close
      System.out.println("Wrong Password.");
      System.out.println("Possible Operations:");
      System.out.println("Press 1 to reset the password");
      System.out.println("Press any key, except 1, to quit from the program: ");
      System.out.print("Operation: ");
      
      int selection = input.nextInt();

      if(selection == 1) {
        System.out.print("New Password: ");
        Scanner npInput = new Scanner(System.in);
        password = npInput.nextLine();
        npInput.close();
        if(password.equals(oldPassword)) {
          System.out.println("Could not create password.");
        }
        else {
          oldPassword = password;
          System.out.println("Password created.");
        }
      }
      else {
        System.out.println("Successfully Quit.");
      }
    }
    else {
      System.out.println("Invalid User Credentials.");
    }
    input.close();
  }
}