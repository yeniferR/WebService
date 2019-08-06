using ServiceStack;
using WebApplication1.ServiceModel;

namespace WebApplication1.ServiceInterface
{
	
	public class MyServices : Service
	{
		
		public int resultado;

		public object Any(HelloResponse request)
		{
				this.resultado = request.sumaa + request.sumab;
				return  this.resultado;
		}

		public object Any(RestaResponse request)
		{
			this.resultado = request.restaa - request.restab;
			return this.resultado;
		}

		public object Any(MultiplicacionResponse request)
		{
			this.resultado = request.valora * request.valorb;
			return this.resultado;
		}

		public object Any(DivisionResponse request)
		{
			this.resultado = request.Divisiona/request.Divisionb;
			return this.resultado;
		}
			 

	}
}