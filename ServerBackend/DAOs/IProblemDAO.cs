using ServerBackend.Models;

namespace ServerBackend.DAOs
{
    public interface IProblemDAO
    {
        List<Problem> selectAllProblems();
    }
}
