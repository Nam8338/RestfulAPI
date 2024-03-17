using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApiApp.Models;
using System;
using System.Collections.Generic;

namespace MyWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        public static List<HangHoa> hangHoas= new List<HangHoa>();

        [HttpGet]
        [Route("/getAll")]
        public IActionResult GetAll()
        {
            return Ok(hangHoas);
        }

        [HttpPost]
        [Route("/getById")]
        public IActionResult Create(HangHoaVM hangHoaVM)
        {
            var hanghoa = new HangHoa
            {
                MaHangHoa = Guid.NewGuid(),
                TenHangHoa = hangHoaVM.TenHangHoa,
                DonGia = hangHoaVM.DonGia
            };
            hangHoas.Add(hanghoa);
            return Ok(new
            {
                Success = true,
                Data = hanghoa
            });
        }
    }
}
