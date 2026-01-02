# Steps on how to create a Azure Storage Account and Resource Group via Terraform 

## 1. Install terraform CLI

```
brew tap hashicorp/tap
brew install hashicorp/tap/terraform
```

## 2. Go to Terraform Registry, and search for the corresponding (Azure) provider

## 3. Click `use provider` and copy the code.

## 4. Create the `main.tf` file.
### 4.1. Add the terraform recommended gitignore for safety

## 5. Make the features existing, but empty.

```
provider "azurerm" {
  features {}
}
```

## 6. Add the code to create a storage account and replace the name and location variables

## 7. Run the terraform plan

`terraform plan`

## 8. Apply the terraform plan after no errors were found.

`terraform apply`

## 9. After finishing, remember to destroy the terraform resources

`terraform destroy`
