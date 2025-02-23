﻿/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 25/10/2024
 * Hora: 10:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP5
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		public const int ALUMNO = 1;
		public const int NUMERO = 2;
		public const int PROFESOR = 3;
		public const int ALUMNO_ESTUDIOSO = 4;
		
		
		protected GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
		protected LectorDeDatos lector = new LectorDeDatos();
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
		
		public static Comparable crearAleatorio(int opcion){
			FabricaDeComparables fabrica = null;
			switch(opcion){
					case 1: fabrica = new FabricaDeAlumnos();break;
					case 2: fabrica = new FabricaDeNumeros();break;
					case 3: fabrica = new FabricaDeProfesores();break;
					case 4: fabrica = new FabricaDeAlumnosEstudiosos();break;
					
			}
			
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion){
			FabricaDeComparables fabrica = null;
			switch(opcion){
					case 1: fabrica = new FabricaDeAlumnos();break;
					case 2: fabrica = new FabricaDeNumeros();break;	
					case 3: fabrica = new FabricaDeProfesores();break;
					case 4: fabrica = new FabricaDeAlumnosEstudiosos();break;
					
			}
			
			return fabrica.crearPorTeclado();
		}
		
		
	}
}
