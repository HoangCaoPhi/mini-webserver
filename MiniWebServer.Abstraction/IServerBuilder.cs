using Microsoft.Extensions.DependencyInjection;

namespace MiniWebServer.Abstraction;

public interface IServerBuilder
{
    IServiceCollection Services { get; }

    IServerBuilder Build();
}
