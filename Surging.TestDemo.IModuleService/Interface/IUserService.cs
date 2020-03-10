using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.DBModel.Models;
using System.Threading.Tasks;

namespace Surging.TestDemo.IModuleService
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceBundle("api/{Service}")]
    public interface IUserService : IServiceKey
    {
        /// <summary>
        /// SayHello
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Service(Name = "SayHello", Date = "2019-08-30", Director = "Sephiroth")]
        Task<string> SayHello(string name);

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [Service(Name = "GetUserAsync", Date = "2019-08-30", Director = "lutao")]
        Task<User> GetUserAsync(string name);
    }
}