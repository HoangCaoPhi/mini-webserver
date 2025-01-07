using Microsoft.Extensions.DependencyInjection;
using MiniWebServer.Abstraction;

namespace MiniWebServer.Server;

public class MiniWebServerBuilder : IServerBuilder
{
    public IServiceCollection Services { get; } = new ServiceCollection();

    public IServerBuilder Build()
    {
        
        return null;
    }
}
