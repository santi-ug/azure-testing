using Azure;
using Azure.Identity;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

class Program 
{
  static async Task Main(string[] args)
  {
    string resourceGroupName = "my-sdk-rg";
    string location = "westus";

    var cred = new DefaultAzureCredential();
    var client = new ArmClient(cred);

    SubscriptionResource subscription = await client.GetDefaultSubscriptionAsync();
    ResourceGroupCollection resourceGroups = subscription.GetResourceGroups();
    ResourceGroupData resourceGroupData = new ResourceGroupData(location);
    ArmOperation<ResourceGroupResource> operation = await resourceGroups.CreateOrUpdateAsync(WaitUntil.Completed, resourceGroupName, resourceGroupData);

    Console.WriteLine("Resource Group Created Successfully");

  }
}
