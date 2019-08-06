using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace WebApplication1.ServiceModel
{
	[Api("Datos de mi Aritmetica")]
	[Route("/Aritmetica/Suma", "GET")]
	public class HelloResponse
	{
		[ApiMember(Name = "sumaa", Description = "Numero1", ParameterType = "query", DataType = "integer", Format = "int32")]
		public int sumaa { get; set; }
		[ApiMember(Name = "sumab", Description = "Numero2", ParameterType = "query", DataType = "integer", Format = "int32")]
		public int sumab { get; set; }
	}
	[Api("Datos de mi Aritmetica")]
	[Route("/Aritmetica/Resta", "GET")]

	public class RestaResponse
	{
		[ApiMember(Name = "restaa", Description = "numero1", ParameterType = "query", DataType = "integer", Format = "int32")]

		public int restaa { get; set; }

		[ApiMember(Name = "restab", Description = "numero2", ParameterType = "query", DataType = "integer", Format = "int32")]
		public int restab { get; set; }

	}

	[Api("Datos de mi Aritmetica")]
	[Route("/Aritmetica/Multiplicacion", "GET")]

	public class MultiplicacionResponse
	{
		[ApiMember(Name = "valora", Description = "numero1", ParameterType = "query", DataType = "integer", Format = "int32")]
		public int valora { get; set; }
		 [ApiMember(Name ="valorb", Description ="numero2",ParameterType ="query", DataType = "integer", Format = "int32")]
		 public int valorb { get; set;}
	}
	[Api("Datos de mi Aritmetica")]
	[Route("/Aritmetica/Division", "GET")]

	public class DivisionResponse
	{
		[ApiMember(Name = "Divisiona", Description = "numero1", ParameterType = "query", DataType = "integer", Format = "int32")]
		public int Divisiona { get; set; }
		[ApiMember(Name = "Divisionb", Description = "numero2", ParameterType = "query", DataType = "integer", Format = "int32")]
		public int Divisionb { get; set; }
	}

}