using TaskMaster.Data.Dtos;
namespace TaskMaster.Services
{
    public interface ITareaSevice
    {
        Task<Result> Create(TareaRequest tarea);
        Task<Result> Delete(int Id);
        Task<ResultList<TareaDto>> Get(string filtro = "");
        Task<Result<TareaDto>> GetById(int Id);
        Task<Result> Update(TareaRequest tarea);
            

    }
}
