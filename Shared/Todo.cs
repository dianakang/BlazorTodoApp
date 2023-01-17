namespace BlazorTodoApp.Shared
{
    public class Todo : CosmosModelBase
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public bool IsEdited { get; set; } = false;

        public override string ClassType => "Todo"; // 반드시 ClassType의 값과 위 ElementType의 이름이 일치해야 함  
    }
}
