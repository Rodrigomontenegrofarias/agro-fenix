﻿using System.Collections.Generic;
using System.Threading.Tasks;
using trifenix.agro.db.model.agro;
using trifenix.agro.model.external;

namespace trifenix.agro.external.interfaces.entities.main
{
    public interface IJobOperations
    {
        Task<ExtPostContainer<string>> SaveNewJob(string name);

        Task<ExtPostContainer<Job>> SaveEditJob(string id, string name);

        Task<ExtGetContainer<List<Job>>> GetJobs();

        


    }
}
