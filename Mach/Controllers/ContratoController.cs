using Mach.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mach.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContratoController:ControllerBase
    {
        public ContratoController()
        {

        }

        //test controller
        [HttpGet]
        public async Task<ActionResult<List<Contrato>>> Get()
        {
            return new List<Contrato>() {
                new Contrato(){ 
                    FechaInicio = new DateTime(),
                    FechaFin = new DateTime(),
                    IsCombustible=false, 
                    IsTransporte=true, 
                    Observaciones="ninguna obs"
                },
                new Contrato(){
                    FechaInicio = new DateTime(),
                    FechaFin = new DateTime(),
                    IsCombustible=false,
                    IsTransporte=true,
                    Observaciones="alguna obs"
                },
                new Contrato(){
                    FechaInicio = new DateTime(),
                    FechaFin = new DateTime(),
                    IsCombustible=false,
                    IsTransporte=true,
                    Observaciones="finalmente obs"
                },
                new Contrato(){
                    FechaInicio = new DateTime(),
                    FechaFin = new DateTime(),
                    IsCombustible=false,
                    IsTransporte=true,
                    Observaciones="un obs desde master"
                },
            };
        }

        //development branch


    }
}
