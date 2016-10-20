import java.util.Scanner;

public class HolaMundo {
	
	public static void main(String[] args){
		Scanner scanner = new Scanner(System.in);
		System.out.print("Dime tu nombre");
		String nombre = scanner.nextLine();
		System.out.print("Dime tu edad");
		String edad = scanner.nextLine();
		int edadSiguiente = Integer.parseInt(edad)+1;
		System.out.print("Hola " + nombre + " el año que viene tendras "+ edad + " años.");
		
		
		
		
	}
}
