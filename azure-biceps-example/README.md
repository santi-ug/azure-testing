# Steps to deploy storage using Azure Bicep

## 1. Assuming we already have the Azure CLI, and have logged in, we create the bicep config file.

```
main.bicep
```

## 2. We build the file with the following command

```
az bicep build --file main.bicep
```

This creates the main.json ARM Template

## 3. Deploy the storage group using the template, into an existing resource group.

For this part, we used the resource group we made with C Sharp from the previous tutorial.

```
az deployment group create --resource-group my-sdk-rg --template-file main.json
```

Dont forget to delete resources so they don't waste money.
