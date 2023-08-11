# Welcome

This project will explore code examples related to renewing my Microsoft AZ-204 certification.

## Examples

### AZ-204 auth

```sh
# Create a new application registration in the Azure portal
# Add your _clientId and _tenantId to az204-auth/Program.cs

% cd az204-auth
% dotnet build
MSBuild version 17.6.8+c70978d4d for .NET
  Determining projects to restore...
  All projects are up-to-date for restore.
  az204-auth -> /Users/rob/repos/microsoft-az-204-renewal/az204-auth/bin/Debug/net7.0/az204-auth.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:00.54

% dotnet run
Token:	eyJ0eXAiOiJKV1QiLCJub25jZSI6IlNCNG83VU1HV2VXWUhmc3dTM3JRYkdIX2E5TTlrTmRSU1oxcXZfWkVqVFkiLCJhbGciOiJSUzI1NiIsIng1dCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyIsImtpZCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyJ9.eyJhdWQiOiIwMDAwMDAwMy0wMDAwLTAwMDAtYzAwMC0wMDAwMDAwMDAwMDAiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8wYWVlYzNlYS1hMDNkLTRmM2MtODE2MS01OGZjNTg4YzM2MTEvIiwiaWF0IjoxNjkwMzA3OTY0LCJuYmYiOjE2OTAzMDc5NjQsImV4cCI6MTY5MDMxMjQzMSwiYWNjdCI6MCwiYWNyIjoiMSIsImFpbyI6IkFZUUFlLzhUQUFBQWJLUXpWSitNMlJlbk5Xb1FBNFNzaW81dzdOcFNlTW9sOHVXWUV1OGRiTzZWUnVySEZtYjUwTzVxRkp6V1BWcndHUGoyVlJJci9USThYbVhIcisxekFxSFlQR2QvdlordnB6cUw1RG90MllkMzFuWDZTTjJ2ZThXSTcrR2h2R2pLanRGd2YvcnpGek9Sd2RtNmprMDFjQU9ZajJXYWUzalRueC9acFA4UFp4az0iLCJhbHRzZWNpZCI6IjE6bGl2ZS5jb206MDAwMzAwMDBEMzdFQjBCQiIsImFtciI6WyJwd2QiLCJtZmEiXSwiYXBwX2Rpc3BsYXluYW1lIjoiYXoyMDRhcHByZWciLCJhcHBpZCI6IjVmOGZiOWUxLTg1ZDgtNGMyZC1iYWFhLTJhMzQ1ZDlhM2VhNCIsImFwcGlkYWNyIjoiMCIsImVtYWlsIjoicm9iQHRoZXJvYmJyZW5uYW4uY29tIiwiZmFtaWx5X25hbWUiOiJCcmVubmFuIiwiZ2l2ZW5fbmFtZSI6IlJvYiIsImlkcCI6ImxpdmUuY29tIiwiaWR0eXAiOiJ1c2VyIiwiaXBhZGRyIjoiOTcuMTI2LjE5LjExMCIsIm5hbWUiOiJSb2IgQnJlbm5hbiIsIm9pZCI6IjRhMzYyZmRiLWQxYWMtNDI1YS05NGZjLWRhMjhlYzc5NmVjYyIsInBsYXRmIjoiNSIsInB1aWQiOiIxMDAzMjAwMDRDOUIxMDNGIiwicmgiOiIwLkFUWUE2c1B1Q2oyZ1BFLUJZVmo4V0l3MkVRTUFBQUFBQUFBQXdBQUFBQUFBQUFBMkFPRS4iLCJzY3AiOiJvcGVuaWQgcHJvZmlsZSBVc2VyLlJlYWQgZW1haWwiLCJzaWduaW5fc3RhdGUiOlsia21zaSJdLCJzdWIiOiJubUI3N01MeXhFQTlVNzFLRXBQb2hNLXpmbmlKMXMwOTAzU1pIQi1DNVJJIiwidGVuYW50X3JlZ2lvbl9zY29wZSI6Ik5BIiwidGlkIjoiMGFlZWMzZWEtYTAzZC00ZjNjLTgxNjEtNThmYzU4OGMzNjExIiwidW5pcXVlX25hbWUiOiJsaXZlLmNvbSNyb2JAdGhlcm9iYnJlbm5hbi5jb20iLCJ1dGkiOiJhRktpVVd1aGlFT3oyX1FlR2ZrQUFBIiwidmVyIjoiMS4wIiwid2lkcyI6WyI2MmU5MDM5NC02OWY1LTQyMzctOTE5MC0wMTIxNzcxNDVlMTAiLCJiNzlmYmY0ZC0zZWY5LTQ2ODktODE0My03NmIxOTRlODU1MDkiXSwieG1zX3N0Ijp7InN1YiI6Ik1MdXZOc0dFdDU1dmxVYW5OdElDbFd5dnpSaUtKMVlMTG5JVHVTRzJ6aTAifSwieG1zX3RjZHQiOjE1NjAzOTMxMjN9.Zj3XDt45wBpiHuryVpYKL1AekLr1sG4_Cf5PcgR6DF-8UROgm46Vr0XX46ibwpYaCixaLrTLC-5JUro0Vhvsr1oQmzxgmcJQf5qhqwtN3JrIJCFIuMy0RHCv_2EvOjkZwq4RxlwrjONpdN7YoP-oO-ZfyBm2B66wxY0o75x9Z0X1vcaShqcEzAi9DI3OG49qY5dfECf6Qc42zTexQLP_1HEw2bhTqA6xB3sXo9D92MbTh6bHGeE9v3645JfOd6SPQ0BoQgdr0N4O7po96D2XYPrW-nOYpJmOo4FDgKbGSzn6M7ZY_qJDfp_ehVw5k0SwuBy7yjFpW0nzxy4vLjB3HA
```

### Azure Cosmos DB: Create a database and container

See `az204-cosmosdb` after you are confident the prerequisites below have been satisfied for your development environment.

#### Prerequisites

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
