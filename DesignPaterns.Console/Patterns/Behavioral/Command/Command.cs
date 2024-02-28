using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.Console.Patterns.Behavioral.Command
{
    /// <summary>
    /// Command Pattern: This pattern encapsulates a request as an object, thereby allowing parameterization of clients with different requests, queuing of requests, and logging of requests.
    /// </summary>
    public static class Command
    {
        public static void Start()
        {
            var remoteControl = new RemoteControl();
            var light = new Light();

            // Set commands
            remoteControl.SetCommand(new TurnOnLightCommand(light));
            remoteControl.SetCommand(new TurnOffLightCommand(light));

            // Execute commands
            remoteControl.ExecuteCommands();
        }
    }

}
