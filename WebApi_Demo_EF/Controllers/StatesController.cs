using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Demo_EF.Models;

namespace WebApi_Demo_EF.Controllers
{
    public class StatesController : ApiController
    {
        public IEnumerable<States> Get()
        {
            using (TrainingManagementEntities entities = new TrainingManagementEntities())
            {
                var states = entities.States.ToList();
                var stateData = new List<States>();
                foreach (var item in states)
                {
                    States stateData1 = new States
                    {
                        StateId = Int32.Parse(item.StateId.ToString()),
                        StateName = item.StateName.ToString()
                    };
                    stateData.Add(stateData1);
                }
                return stateData;
            }
        }
    }
}
