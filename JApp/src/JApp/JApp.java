package JApp;

import java.util.*;

public class JApp {

	public static void main(String[] args) {
		
		int premio = 0;
		System.out.println("¿Cómo te llamas?");
		Scanner sc = new Scanner(System.in);
		String nombre = sc.nextLine();
		System.out.println("Hola " + nombre + " bienvenido a Quién quiere ser millonario!");
		System.out.println("Primera pregunta por 100€: ");
		System.out.println("¿Cuántos huesos hay en el cuerpo de un humano adulto?");
		System.out.println("a) 206");
		System.out.println("b) 278");
		System.out.println("c) 144");
		System.out.println("d) 313");
		String respuesta = sc.nextLine();
		if(respuesta.equals("a")){
			System.out.println("Respuesta correcta!");
		}else {System.out.println("Respuesta incorrecta! :(");
			  System.out.println("Te llevas: " + premio + "€");
			  System.out.println("Para volver a jugar ejecutar JApp");
			  System.exit(0);}
		
		System.out.println("Segunda pregunta por 250€: ");
		System.out.println("¿Cuantos años son un quinquenio?");
		System.out.println("a) 50");
		System.out.println("b) 15");
		System.out.println("c) 500");
		System.out.println("d) 5");
		String respuesta2 = sc.nextLine();
		if(respuesta2.equals("d")){
			System.out.println("Respuesta correcta " + nombre);
		}else {System.out.println("Respuesta incorrecta! :(");
		      System.out.println("Te llevas: " + premio + "€");
			  System.out.println("Para volver a jugar ejecutar JApp");
			  System.exit(0);}
		
		System.out.println("Tercera pregunta por 500€: ");
		System.out.println("¿En que año empezó la Revolución francesa?");
		System.out.println("a) 2002");
		System.out.println("b) 1932");
		System.out.println("c) 1789");
		System.out.println("d) 1974");
		String respuesta3 = sc.nextLine();
		if(respuesta3.equals("c")){
			System.out.println("Respuesta correcta");
		}else {System.out.println("Respuesta incorrecta! :(");
			  System.out.println("Te llevas: " + premio + "€");
			  System.out.println("Para volver a jugar ejecutar JApp");
			  System.exit(0);}
		
		System.out.println("Cuarta pregunta por 1000€: ");
		System.out.println("¿Quién pinto el cuadro 'La Vie'?");
		System.out.println("a) Da Vinci");
		System.out.println("b) Rembrandt");
		System.out.println("c) Picasso");
		System.out.println("d) Monet");
		String respuesta4 = sc.nextLine();
		if(respuesta4.equals("c")){
			System.out.println("Respuesta correcta!");
			System.out.println("Lo que significa que ya tienes 1000€ asegurados!");
			premio=1000;
		}else {System.out.println("Respuesta incorrecta! :(");
			  System.out.println("Te llevas: " + premio + "€");
			  System.out.println("Para volver a jugar ejecutar JApp");
			  System.exit(0);}
		
		System.out.println("Quinta pregunta por 5000€: ");
		System.out.println("¿Donde se originó el vino?");
		System.out.println("a) Francia");
		System.out.println("b) Grecia");
		System.out.println("c) Irak");
		System.out.println("d) Egipto");
		String respuesta5 = sc.nextLine();
		if(respuesta5.equals("c")){
			System.out.println("Respuesta correcta!");
		}else {System.out.println("Respuesta incorrecta! :(");
			  System.out.println("Te llevas: " + premio + "€");
			  System.out.println("Para volver a jugar ejecutar JApp");
			  System.exit(0);}
	
		System.out.println("Sexta pregunta por 10.000€: ");
		System.out.println("¿Quién descubrió el elemento químico 'Radón'?");
		System.out.println("a) Fritz");
		System.out.println("b) Newton");
		System.out.println("c) Rein-Hikker");
		System.out.println("d) Dorn");
		String respuesta6 = sc.nextLine();
		if(respuesta6.equals("d")){
			System.out.println("Respuesta correcta!");
			System.out.println("Lo que significa que ya tienes 10.000€ asegurados!");
			premio=10000;
		}else {System.out.println("Respuesta incorrecta! :(");
			  System.out.println("Te llevas: " + premio + "€");
			  System.out.println("Para volver a jugar ejecutar JApp");
			  System.exit(0);}
		
		System.out.println("Séptima pregunta por 100.000€: ");
		System.out.println("¿Quién ganó el nobel de la paz en 2010?");
		System.out.println("a) Barack Obama");
		System.out.println("b) Nuck Chorris");
		System.out.println("c) Liu Xiaobo");
		System.out.println("d) Al Gore");
		String respuesta7 = sc.nextLine();
		if(respuesta7.equals("c")){
			System.out.println("Respuesta correcta!");
			System.out.println("Lo que significa que ya tienes los 100.000€ asegurados!");
			premio=100000;
		}else {System.out.println("Respuesta incorrecta! :(");
			  System.out.println("Te llevas: " + premio + "€");
			  System.out.println("Para volver a jugar ejecutar JApp");
			  System.exit(0);}
		
		System.out.println("ÚLTIMA PREGUNTA POR 1 MILLÓN: ");
		System.out.println("¿Cúal fué el dinosaurio más grande que existió?");
		System.out.println("a) Amphicoelias");
		System.out.println("b) Argentinosaurus");
		System.out.println("c) Godzilla");
		System.out.println("d) Titanosaurio");
		String respuesta8 = sc.nextLine();
		if(respuesta8.equals("a")){
			System.out.println("¡¡¡FELICIDADES, ERES MILLONARIO!!!");
			premio=10000;
		}else {System.out.println("Respuesta incorrecta! :(");
			  System.out.println("Te llevas: " + premio + "€");
			  System.out.println("Para volver a jugar ejecutar JApp");
			  System.exit(0);}
	}

}





























