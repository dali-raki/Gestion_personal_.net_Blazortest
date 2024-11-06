using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPersonnel.Models.TypeDePaiment;

namespace Implementation.Services.TypeDePaiment
{
	public interface ITypeDePaimentService
	{
		Task<List<TypeDePaiement>> GetAllasync();
	}
}
