
using Containers.Models;
namespace Containers.Application;

public interface IContainerService
{
    IEnumerable<Container> GetAllContainers();

    bool Create(Container container)
    {
        return container is null;
    }
}