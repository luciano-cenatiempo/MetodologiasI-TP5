﻿/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 29/10/2024
 * Hora: 12:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP5
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public FabricaDeNumeros()
		{
		}
		
		public  override Comparable crearAleatorio(){
			return new Numero(aleatorio.numeroAleatorio(30));
		}
		
		public override Comparable crearPorTeclado(){
			Numero num =  new Numero();
			num.setValor(lector.numeroPorTeclado());
			
			return num;
		}
	}
}
