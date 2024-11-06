using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPersonnel.Models.Fonctions;
using GestionPersonnel.Models.TypeDePaiment;
using GestionPersonnel.Storages.FonctionsStorages;
using GestionPersonnel.Storages.TypeDePaimentStorages;

namespace Implementation.Services.TypeDePaiment
{
	public class TypeDePaimentService : ITypeDePaimentService

	{
		private readonly TypeDePaiementStorage _TypeDePaimentStorage;

		public TypeDePaimentService(TypeDePaiementStorage TypeDePaimentStorage)
		{
			_TypeDePaimentStorage = TypeDePaimentStorage;
		}


		public async Task<List<TypeDePaiement>> GetAllasync()
		{
			return await _TypeDePaimentStorage.GetAll();
		}

	}
}
