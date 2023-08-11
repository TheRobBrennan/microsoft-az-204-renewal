# Welcome

## Create resources by using the Microsoft .NET SDK v3

This is based off the AZ-204 exercise at [https://learn.microsoft.com/en-us/training/modules/work-with-cosmos-db/3-exercise-work-cosmos-db-dotnet](https://learn.microsoft.com/en-us/training/modules/work-with-cosmos-db/3-exercise-work-cosmos-db-dotnet)

### Prerequisites

- Install the Azure CLI on your local development environment
  - macOS - Use homebrew to install it per the guide [here](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli-macos) - `brew update && brew install azure-cli`
    - OPTIONAL: Configure completions in `zsh` on macOS - [https://docs.brew.sh/Shell-Completion#configuring-completions-in-zsh](https://docs.brew.sh/Shell-Completion#configuring-completions-in-zsh)
      - Follow the steps at [https://learn.microsoft.com/en-us/cli/azure/install-azure-cli-macos#completion-isnt-working](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli-macos#completion-isnt-working) to configure autocompletion for the `az` and other command-line tools
        - Step 1 - [https://docs.brew.sh/Shell-Completion](https://docs.brew.sh/Shell-Completion)
        - Step 2 - For Zsh, add the following two lines to the bottom of your .zshrc file, then save and reload your Zsh profile.

```sh
# Example ~/.zshrc file with autocompletion defined after configuring completions in zsh
...
# 2023.08.11 Configure completions in zsh - https://docs.brew.sh/Shell-Completion#configuring-completions-in-zsh
if type brew &>/dev/null
then
  FPATH="$(brew --prefix)/share/zsh/site-functions:${FPATH}"

  autoload -Uz compinit
  compinit
fi

autoload bashcompinit && bashcompinit
source $(brew --prefix)/etc/bash_completion.d/az
```

### Setting up

```sh
# Sign in to Azure using the Azure CLI
% az login
[
  {
    "cloudName": "AzureCloud",
    "homeTenantId": "...",
    "id": "...",
    "isDefault": true,
    "managedByTenants": [],
    "name": "Rob Brennan - Personal",
    "state": "Enabled",
    "tenantId": "...",
    "user": {
      "name": "rob@therobbrennan.com",
      "type": "user"
    }
  }
]
```

### Create resources in Azure

```sh
# Create a resource group
% az group create --location westus --name az204-cosmos-rg
{
  "id": "/subscriptions/.../resourceGroups/az204-cosmos-rg",
  "location": "westus",
  "managedBy": null,
  "name": "az204-cosmos-rg",
  "properties": {
    "provisioningState": "Succeeded"
  },
  "tags": null,
  "type": "Microsoft.Resources/resourceGroups"
}

# Create an Azure CosmosDB account with a unique name (this may take several minutes to complete)
% az cosmosdb create --name demo-rb-az204 --resource-group az204-cosmos-rg
Resource provider 'Microsoft.DocumentDB' used by this operation is not registered. We are registering for you.
Registration succeeded.
{
  "analyticalStorageConfiguration": {
    "schemaType": "WellDefined"
  },
  "apiProperties": null,
  "backupPolicy": {
    "migrationState": null,
    "periodicModeProperties": {
      "backupIntervalInMinutes": 240,
      "backupRetentionIntervalInHours": 8,
      "backupStorageRedundancy": "Geo"
    },
    "type": "Periodic"
  },
  "capabilities": [],
  "capacity": null,
  "connectorOffer": null,
  "consistencyPolicy": {
    "defaultConsistencyLevel": "Session",
    "maxIntervalInSeconds": 5,
    "maxStalenessPrefix": 100
  },
  "cors": [],
  "createMode": null,
  "databaseAccountOfferType": "Standard",
  "defaultIdentity": "FirstPartyIdentity",
  "disableKeyBasedMetadataWriteAccess": false,
  "disableLocalAuth": false,
  "documentEndpoint": "https://demo-rb-az204.documents.azure.com:443/",
  "enableAnalyticalStorage": false,
  "enableAutomaticFailover": false,
  "enableCassandraConnector": null,
  "enableFreeTier": false,
  "enableMultipleWriteLocations": false,
  "enablePartitionMerge": false,
  "failoverPolicies": [
    {
      "failoverPriority": 0,
      "id": "demo-rb-az204-westus",
      "locationName": "West US"
    }
  ],
  "id": "/subscriptions/124739a1-9b4a-4c47-9cfc-3cdd13195d3a/resourceGroups/az204-cosmos-rg/providers/Microsoft.DocumentDB/databaseAccounts/demo-rb-az204",
  "identity": {
    "principalId": null,
    "tenantId": null,
    "type": "None",
    "userAssignedIdentities": null
  },
  "instanceId": "b68798f2-3699-409f-a308-d087529277aa",
  "ipRules": [],
  "isVirtualNetworkFilterEnabled": false,
  "keyVaultKeyUri": null,
  "keysMetadata": {
    "primaryMasterKey": {
      "generationTime": "2023-08-11T16:57:58.149191+00:00"
    },
    "primaryReadonlyMasterKey": {
      "generationTime": "2023-08-11T16:57:58.149191+00:00"
    },
    "secondaryMasterKey": {
      "generationTime": "2023-08-11T16:57:58.149191+00:00"
    },
    "secondaryReadonlyMasterKey": {
      "generationTime": "2023-08-11T16:57:58.149191+00:00"
    }
  },
  "kind": "GlobalDocumentDB",
  "location": "West US",
  "locations": [
    {
      "documentEndpoint": "https://demo-rb-az204-westus.documents.azure.com:443/",
      "failoverPriority": 0,
      "id": "demo-rb-az204-westus",
      "isZoneRedundant": false,
      "locationName": "West US",
      "provisioningState": "Succeeded"
    }
  ],
  "minimalTlsVersion": "Tls12",
  "name": "demo-rb-az204",
  "networkAclBypass": "None",
  "networkAclBypassResourceIds": [],
  "privateEndpointConnections": null,
  "provisioningState": "Succeeded",
  "publicNetworkAccess": "Enabled",
  "readLocations": [
    {
      "documentEndpoint": "https://demo-rb-az204-westus.documents.azure.com:443/",
      "failoverPriority": 0,
      "id": "demo-rb-az204-westus",
      "isZoneRedundant": false,
      "locationName": "West US",
      "provisioningState": "Succeeded"
    }
  ],
  "resourceGroup": "az204-cosmos-rg",
  "restoreParameters": null,
  "systemData": {
    "createdAt": "2023-08-11T16:57:58.149191+00:00",
    "createdBy": null,
    "createdByType": null,
    "lastModifiedAt": null,
    "lastModifiedBy": null,
    "lastModifiedByType": null
  },
  "tags": {},
  "type": "Microsoft.DocumentDB/databaseAccounts",
  "virtualNetworkRules": [],
  "writeLocations": [
    {
      "documentEndpoint": "https://demo-rb-az204-westus.documents.azure.com:443/",
      "failoverPriority": 0,
      "id": "demo-rb-az204-westus",
      "isZoneRedundant": false,
      "locationName": "West US",
      "provisioningState": "Succeeded"
    }
  ]
}
time az cosmosdb create --name demo-rb-az204 --resource-group az204-cosmos-rg  0.52s user 0.12s system 0% cpu 3:18.69 total
```

Take note of the `documentEndpoint` from the JSON response - we will need that later:
`"documentEndpoint": "https://demo-rb-az204.documents.azure.com:443/",`

Retrieve the primary key for the account:

```sh
% az cosmosdb keys list --name demo-rb-az204 --resource-group az204-cosmos-rg
{
  "primaryMasterKey": "zyfS0tzyW9fkIkSp68SDxdWgPjkMINymx62UOk43KVd74ehJlh9fmF6NYVC5VvXgqLOb9klq6513ACDbwgvGeg==",
  "primaryReadonlyMasterKey": "WMWTFHBLpf3C4Np1hjOEvdFbsqSVAFyxwq2pJr0pqCY8wSUw7vdjEXN7490dZIq8GYlQHP8aXmaqACDbYTHv0g==",
  "secondaryMasterKey": "eYpRYS4jwjLKpHu7FXa2PeYSHuElAjVnuqorBUqf302yFEThqS6muV14CbGMNtHAvCizXqangYocACDbGn2PBQ==",
  "secondaryReadonlyMasterKey": "5OjyIIBkIaJT7nLgvwPNMEWKXoNasPURLdtCubAf3rWpVeDN6RedeOL3YSbq0aPPqT1VlbZx9uvLACDbQdKssw=="
}
```

### Set up the console application

```sh
# Make sure we're in the appropriate directory
% cd az204-cosmosdb

# Create the .NET console app
% dotnet new console
The template "Console App" was created successfully.

Processing post-creation actions...
Restoring /Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/az204-cosmosdb.csproj:
  Determining projects to restore...
  Restored /Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/az204-cosmosdb.csproj (in 31 ms).
Restore succeeded.

# Open up Program.cs in VS Code 🤓
```

### Build the console app

```sh
# Add packages and using statements
% dotnet add package Microsoft.Azure.Cosmos

# Create the application in Program.cs

# Build the application
% dotnet build
MSBuild version 17.6.8+c70978d4d for .NET
  Determining projects to restore...
  All projects are up-to-date for restore.
/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/Program.cs(12,24): warning CS8618: Non-nullable field 'cosmosClient' must contain a non-null value when exiting constructor. Consider declaring the field as nullable. [/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/az204-cosmosdb.csproj]
/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/Program.cs(15,20): warning CS8618: Non-nullable field 'database' must contain a non-null value when exiting constructor. Consider declaring the field as nullable. [/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/az204-cosmosdb.csproj]
/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/Program.cs(18,21): warning CS8618: Non-nullable field 'container' must contain a non-null value when exiting constructor. Consider declaring the field as nullable. [/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/az204-cosmosdb.csproj]
  az204-cosmosdb -> /Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/bin/Debug/net7.0/az204-cosmosdb.dll

Build succeeded.

/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/Program.cs(12,24): warning CS8618: Non-nullable field 'cosmosClient' must contain a non-null value when exiting constructor. Consider declaring the field as nullable. [/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/az204-cosmosdb.csproj]
/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/Program.cs(15,20): warning CS8618: Non-nullable field 'database' must contain a non-null value when exiting constructor. Consider declaring the field as nullable. [/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/az204-cosmosdb.csproj]
/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/Program.cs(18,21): warning CS8618: Non-nullable field 'container' must contain a non-null value when exiting constructor. Consider declaring the field as nullable. [/Users/rob/repos/microsoft-az-204-renewal/az204-cosmosdb/az204-cosmosdb.csproj]
    3 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.04

# Run the application
% dotnet run
Beginning operations...

Created Database: az204Database

Created Container: az204Container

End of program, press any key to exit.

```

### Clean up Azure resources

Time to delete the resource group. Example keys and IDs above now no longer work.

```sh
% az group delete --name az204-cosmos-rg --no-wait
```
