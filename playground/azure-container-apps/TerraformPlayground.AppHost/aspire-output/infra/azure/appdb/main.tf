variable "postgres_password" {
  description = "Parameter 'postgres-password'"
  sensitive   = true
  type        = string
}

resource "azurerm_postgresql_flexible_server" "appdb-server" {
  administrator_login    = "aspireAdmin"
  administrator_password = var.postgres_password
  location               = "eastus"
  name                   = "aspire-appdb-server"
  resource_group_name    = "aspire-playground-rg"
  sku_name               = "B_Standard_B1ms"
  storage_mb             = 32768
  tags = {
    Environment = "Development"
    ManagedBy   = "Aspire"
  }
  version                = "16"
}

resource "azurerm_postgresql_flexible_server_database" "appdb" {
  charset   = "UTF8"
  collation = "en_US.utf8"
  name      = "appdb"
  server_id = azurerm_postgresql_flexible_server.appdb-server.id
}

resource "azurerm_postgresql_flexible_server_firewall_rule" "allow-azure" {
  end_ip_address   = "0.0.0.0"
  name             = "allow-azure-services"
  server_id        = azurerm_postgresql_flexible_server.appdb-server.id
  start_ip_address = "0.0.0.0"
}

output "postgres_fqdn" {
  value = azurerm_postgresql_flexible_server.appdb-server.fqdn
}

output "postgres_database_name" {
  value = azurerm_postgresql_flexible_server_database.appdb.name
}

output "connection-string" {
  sensitive = true
  value     = format("Host=%s;Database=%s;Username=%s;Password=%s", azurerm_postgresql_flexible_server.appdb-server.fqdn, azurerm_postgresql_flexible_server_database.appdb.name, "aspireAdmin", var.postgres_password)
}
