﻿using Business.Abstratct;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CitizenService : IApplicantService
    {
        public void ApplyForMask(Citizen citizen)
        {

        }

        public List<Citizen> GetList()
        {
            return null;
        }

        public bool CheckCitizen(Citizen citizen)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(citizen.NationalIdentity,citizen.FirstName,citizen.LastName,citizen.BirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
