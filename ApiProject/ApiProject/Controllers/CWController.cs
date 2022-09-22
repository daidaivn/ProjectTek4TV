﻿using ApiProject.IServices;
using ApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CWController : ControllerBase
    {
        private readonly ICWService _cwservice;
        public CWController(ICWService cwservice)
        {
            _cwservice = cwservice;
        }
        [Route("getall-cw")]
        [HttpGet]
        public dynamic GetAllCW()
        {
            try
            {
                var data = _cwservice.GetAllCW();
                return data;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("update-cw")]
        [HttpPut]
        public dynamic UpdateCW(Working working)
        {
            try
            {
                var data = _cwservice.UpdateCW(working);
                return data;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("creat-cw")]
        [HttpPost]
        public dynamic CreateCW(Working working)
        {
            try
            {
                var data = _cwservice.CreateCW(working);
                return data;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}