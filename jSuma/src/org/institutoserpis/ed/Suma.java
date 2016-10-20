package org.institutoserpis.ed;

import java.math.BigDecimal;
import java.util.Scanner;

public class Suma {
	
	public static void main(String[] args){
		
		Scanner scanner = new Scanner(System.in);
		System.out.print("Introduce 2 números para sumar:");
		String numero1 = scanner.nextLine();
		BigDecimal primero = new BigDecimal(numero1);
		System.out.print("Introduce el segundo número:");
		String numero2 = scanner.nextLine();
		BigDecimal segundo = new BigDecimal(numero2);
		BigDecimal suma = BigDecimal.ZERO;
		suma = suma.add(primero).add(segundo);
		System.out.print("La suma da: "+suma);
	
	}
}
