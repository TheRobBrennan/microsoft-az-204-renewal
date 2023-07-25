using System.Threading.Tasks;
using Microsoft.Identity.Client;

public static async Task Main(string[] args)

// Add code for the interactive authentication
private const string _clientId = "APPLICATION_CLIENT_ID";
private const string _tenantId = "DIRECTORY_TENANT_ID";

var app = PublicClientApplicationBuilder
    .Create(_clientId)
    .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
    .WithRedirectUri("http://localhost")
    .Build();

// Acquire a token
string[] scopes = { "user.read" };
