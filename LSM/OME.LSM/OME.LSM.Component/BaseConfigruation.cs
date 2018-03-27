using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OME.Unity;
using Orleans;
namespace OME.LSM.Component
{
    public interface IBaseConfigruation : IDisposable
    {
        Task Configurations();
    }

    public class BaseConfigruation : Grain, IBaseConfigruation
    {
        public async Task Configurations()
        {
            await Task.Run(() =>
            {
                UnityIoc.containerName = "MyContainer";
                UnityIoc.filepath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "") + "Unity.config";
            });

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
