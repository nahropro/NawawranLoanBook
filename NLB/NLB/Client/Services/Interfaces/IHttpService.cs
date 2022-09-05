
namespace NLB.Client.Services
{
    public interface IHttpService
    {
        Task<TResult> PostAsync<TResult, TValue>(string route, TValue value);
        Task<TResult> GetAsync<TResult>(string url, object query=null);
        Task<TResult> PutAsync<TResult, TValue>(string url, TValue value);
        Task<bool> DeleteAsync(string url);
    }
}