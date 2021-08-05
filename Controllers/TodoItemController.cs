﻿using System.Collections.Generic;
using System.Linq;
using Core.Models.EfModels;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PostgreSQL_Playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly PostgreContext postgreContext;

        public TodoItemController(PostgreContext postgreContext)
        {
            this.postgreContext = postgreContext;
        }

        // GET: api/<TodoItemController>
        [HttpGet]
        public List<TodoItem> Get()
        {
            return postgreContext.TodoItems.ToList();
        }

        // GET api/<TodoItemController>/5
        [HttpGet("{id}")]
        public TodoItem Get(int id)
        {
            return postgreContext.TodoItems.FirstOrDefault(e => e.Id == id);
        }

        // POST api/<TodoItemController>
        [HttpPost]
        public int Post([FromBody] TodoItem value)
        {
            postgreContext.TodoItems.Add(value);
            postgreContext.SaveChanges();
            return value.Id;
        }

        // PUT api/<TodoItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
