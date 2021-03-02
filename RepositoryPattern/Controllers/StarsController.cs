using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : GenericController<Star,EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repo):base(repo)
        {
                
        }
    }
}
