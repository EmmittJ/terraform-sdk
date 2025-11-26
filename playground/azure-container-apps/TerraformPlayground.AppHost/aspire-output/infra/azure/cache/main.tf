resource "azurerm_redis_cache" "cache" {
  capacity            = 0
  family              = "C"
  location            = "eastus"
  minimum_tls_version = "1.2"
  name                = "aspire-cache"
  resource_group_name = "aspire-playground-rg"
  sku_name            = "Basic"
  tags = {
    Environment = "Development"
    ManagedBy   = "Aspire"
  }
}

output "redis-connection-string" {
  sensitive = true
  value     = azurerm_redis_cache.cache.primary_connection_string
}

output "redis_hostname" {
  value = azurerm_redis_cache.cache.hostname
}
