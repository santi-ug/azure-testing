# How to create Resource Group via Azure SDK with C Sharp

## 1. Install Dotnet

Install via the Dotnet installation website, depending on your OS (I'm on Mac)

## 2. Make folder where code will live

```
mkdir create-resource-group
```

## 3. Start dotnet project

```
dotnet new console
```

## 4. Install Azure CLI

```
brew update && brew install azure-cli
```

## 5. Login to Azure

```
az login --use-device-code
```

## 6. Install neccessary Azure packages

```
dotnet add package Azure.Identity
dotnet add package Azure.ResourceManager
dotnet add package Azure.ResourceManager.Resources
```

## 7. Run Program.cs code

```
dotnet run
```
