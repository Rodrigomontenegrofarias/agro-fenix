using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using trifenix.agro.functions.Helper;
using trifenix.agro.db.model.agro;

namespace trifenix.agro.functions
{
    public static class MainAgroFunction
    {
        [FunctionName("PhenologicalEventV2")]
        public static async Task<IActionResult> PhenologicalEventV2(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "v2/phenological_events")] HttpRequest req,
            ILogger log)
        {
            if (req.Method.ToLower().Equals("post")) {
                return await ContainerMethods.ApiPostOperations(req.Body, log, async (db, model) =>
                {
                    var name = (string)model["name"];
                    var initDate = (DateTime)model["startDate"];
                    var endDate = (DateTime)model["endDate"];

                    
                    return await db.PhenologicalEvents.SaveNewPhenologicalEvent(name, initDate, endDate);
                });
            }

            if (req.Method.ToLower().Equals("put"))
            {
                return await ContainerMethods.ApiPostOperations(req.Body, log, async (db, model) =>
                {
                    var id = (string)model["id"];
                    var name = (string)model["name"];
                    var initDate = (DateTime)model["startDate"];
                    var endDate = (DateTime)model["endDate"];

                    return await db.PhenologicalEvents.SaveEditPhenologicalEvent(id, name, initDate, endDate);
                });
            }

            var result = await ContainerMethods.AgroManager.PhenologicalEvents.GetPhenologicalEvents();
            return ContainerMethods.GetJsonGetContainer(result, log);
        }

        [FunctionName("SeasonV2")]
        public static async Task<IActionResult> SeasonV2(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "v2/seasons")] HttpRequest req,
            ILogger log)
        {
            if (req.Method.ToLower().Equals("post"))
            {
                return await ContainerMethods.ApiPostOperations(req.Body, log, async (db, model) =>
                {
                    
                    var initDate = (DateTime)model["startDate"];
                    var endDate = (DateTime)model["endDate"];


                    return await db.Seasons.SaveNewSeason(initDate, endDate);
                });
            }

            if (req.Method.ToLower().Equals("put"))
            {
                return await ContainerMethods.ApiPostOperations(req.Body, log, async (db, model) =>
                {
                    var id = (string)model["id"];
                    
                    var initDate = (DateTime)model["startDate"];
                    var endDate = (DateTime)model["endDate"];
                    var current = (bool)model["current"];

                    return await db.Seasons.SaveEditSeason(id, initDate, endDate, current);
                });
            }

            var result = await ContainerMethods.AgroManager.Seasons.GetSeasons();
            return ContainerMethods.GetJsonGetContainer(result, log);
        }



    }
}
