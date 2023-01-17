using BlazorTodoApp.Shared;
using Microsoft.Azure.Cosmos;

namespace BlazorTodoApp.Server.Services
{
    public class TodoService
    {
        private readonly CosmosDbService cosmosDbService;
        private readonly Container container;

        public TodoService(CosmosDbService cosmosDbService)
        {
            this.cosmosDbService = cosmosDbService;
            container = cosmosDbService.GetContainer();
        }

        public async Task CreateTodo(Todo todo)
        {
            todo.Id = Guid.NewGuid().ToString(); // Guid: 고유한 식별키 생성
            todo.Pk = todo.Id;
            await container.AddModel<Todo>(todo);
        }

        public async Task<List<Todo>> GetTodos()
        {
            return await container.GetModelLinqQueryable<Todo>().GetListFromFeedIteratorAsync();
        }

        public async Task UpdateTodo(Todo todo)
        {
            await container.EditModel<Todo>(todo);
        }

        public async Task DeleteTodo(Todo todo)
        {
            await container.RemoveModel<Todo>(todo.Id, todo.Pk);
        }
      
        public async Task DoneTodo(Todo todo)
        {
            await container.EditModel<Todo>(todo);
        }
    }
}
