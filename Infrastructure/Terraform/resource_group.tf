terraform {
  required_providers {
    azurerm = {
      source = "hashicorp/azurerm"
      version = "3.70.0"
    }
  }
}

provider "azurerm" {
  
}

resource "azurerm_resource_group" "rg-tf" {
  name = "rg-terraform"
  location = "brazilsouth"
}

