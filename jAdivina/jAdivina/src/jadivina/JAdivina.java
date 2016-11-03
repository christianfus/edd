package jadivina;

import java.io.InputStream;
import java.util.Scanner;
import java.util.Random;
        
public class JAdivina {

    public static void main(String[] args) {
        
        Random random = new Random();
        int numeroAleatorio = random.nextInt(1000)+1;
        System.out.println("Adivina un número del 1 al 1000");
        System.out.println("numeroAleatorio=" + numeroAleatorio);
        Scanner scanner = new Scanner(System.in);
        boolean acertado;
        int contadorIntentos = 0;
        do {
        
        contadorIntentos++;
        System.out.printf("Introduce el número intento nº %d: ", contadorIntentos);
        String line = scanner.nextLine();
        int numero = Integer.parseInt(line);
        if(numero<numeroAleatorio){System.out.println("El número a adivinar es mayor.");}
        if(numero>numeroAleatorio){System.out.println("El número a adivinar es menor.");}
        acertado = numeroAleatorio == numero;
        }
        while(!acertado);
        System.out.printf("Has acertado al intento nº %d. \n", contadorIntentos);   
    }
}
