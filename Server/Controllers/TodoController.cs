using BlazorTodoApp.Server.Services;
using BlazorTodoApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorTodoApp.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoService todoService;
        public TodoController(TodoService todoService)
        {
            this.todoService = todoService;
        }

        // Post
        [HttpPost]
        public async Task<ActionResult<Todo>> CreateTodo(Todo todo)
        {
            await todoService.CreateTodo(todo);

            return Ok(todo);
        }

        // Get
        [HttpGet]
        public async Task<List<Todo>> GetTodos()
        {
            return await todoService.GetTodos();
        }

        // Update
        [HttpPost]
        public async Task<ActionResult<Todo>> UpdateTodo(Todo todo)
        {
            await todoService.UpdateTodo(todo);
            return Ok(todo);
        }

        // Delete
        [HttpPost]
        public async Task<ActionResult<Todo>> DeleteTodo(Todo todo)
        {
            await todoService.DeleteTodo(todo);

            return Ok(todo);
        }

        // Done
        [HttpPost]
        public async Task<ActionResult<Todo>> DoneTodo(Todo todo)
        {
            await todoService.DoneTodo(todo);

            return Ok(todo);
        }
    }
}
