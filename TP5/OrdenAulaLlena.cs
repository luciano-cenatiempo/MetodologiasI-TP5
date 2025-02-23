﻿/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 8/11/2024
 * Hora: 00:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP5
{
	/// <summary>
	/// Description of OrdenAulaLlena.
	/// </summary>
	public class OrdenAulaLlena : OrdenEnAula1
	{
		private Aula aula;
		public OrdenAulaLlena(Aula aula)
		{
			this.aula = aula;
		}
		
		#region OrdenEnAula1 implementation
		public void ejecutar()
		{
			aula.claseLista();
		}
		#endregion
	}
}
