using Microsoft.Extensions.Logging;
using OPISDatabrowser.Domain.Entities.Common;
using OPISDatabrowser.EntityContextKeeper.DatabaseContexts;
using OPISDatabrowser.Infrastructure.BaseEntities;
using OPISDatabrowser.Infrastructure.Entitlement.UserIdKeeper;
using OPISDatabrowser.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPISDatabrowser.Service.Metadata
{
    public class ODataMetadataService : BaseService, IMetadataService
    {
        private readonly PostgresContext _database;

        public ODataMetadataService(ILogger<ODataMetadataService> logger,
                                                 PostgresContext database,
                                                 IUserIdKeeper? idKeeper) : base(logger, idKeeper)
        {
            _database = database;
        }

        public IQueryable<EntityODataMetadata?> Get()
        {
            return _database.EntityODataMetadata.AsQueryable();
        }
        public IQueryable<EntityODataMetadata> GetByRoleNameAsync(string role_name)
        {
            var result = Get();

            return result.Where(record => record.Role_name == role_name);
        }
    }

    public class ODataMetadataServiceHardcoded : BaseService, IMetadataService
    {
        public ODataMetadataServiceHardcoded(ILogger<BaseService> logger, IUserIdKeeper userIdKeeper) : base(logger, userIdKeeper)
        {
        }

        public IQueryable<EntityODataMetadata> GetByRoleNameAsync(string roleName)
        {
            return new List<EntityODataMetadata>()
            {
                new EntityODataMetadata()
                {
                    Entity_name = "BCI_OpSchedules",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "BCI_OpSchedules_Concept",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "BCI_OpSchedules_Connect",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "CapsChemAssets",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "ChemicalCapacityByCompany_CapacityToProduce_API_Data",
                },
                 new EntityODataMetadata()
                {
                    Entity_name = "ChemicalCapacityByCompany_CapacityToProduce_API_Data_Simplified",
                },
                 new EntityODataMetadata()
                {
                    Entity_name = "ChemicalCapacityByCompany_ExpandClose_API_Data",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "ChemicalCapacityByCompany_ExpandClose_API_Data_Simplified",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "ChemicalCapacityByShareholder_CapacityToProduce_API_Data",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "ChemicalCapacityByShareholder_CapacityToProduce_API_Data_Simplified",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "ChemicalCapacityByShareholder_ExpandClose_API_Data",
                },
                 new EntityODataMetadata()
                {
                    Entity_name = "ChemicalCapacityByShareholder_ExpandClose_API_Data_Simplified",
                },
                 new EntityODataMetadata()
                {
                    Entity_name = "Mas",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "Mas_ReportSelector",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "OMDC_AssetsCapacity",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "OMDC_CapacitySnapshots",
                },
                new EntityODataMetadata()
                {
                    Entity_name = "OMDC_SD_Balances",
                },
                 new EntityODataMetadata()
                {
                    Entity_name = "OMDC_SimBal",
                },
            }.AsQueryable();
        }
    }
}
