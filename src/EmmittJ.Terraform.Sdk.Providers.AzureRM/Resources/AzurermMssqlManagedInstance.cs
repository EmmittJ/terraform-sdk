using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_managed_instance resource.
/// </summary>
public class AzurermMssqlManagedInstance : TerraformResource
{
    public AzurermMssqlManagedInstance(string name) : base("azurerm_mssql_managed_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dns_zone");
        this.DeclareOutput("fqdn");
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdministratorLogin
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login");
        set => this.WithProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdministratorLoginPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login_password");
        set => this.WithProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Collation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collation");
        set => this.WithProperty("collation", value);
    }

    /// <summary>
    /// The database_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_format");
        set => this.WithProperty("database_format", value);
    }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DnsZonePartnerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_zone_partner_id");
        set => this.WithProperty("dns_zone_partner_id", value);
    }

    /// <summary>
    /// The hybrid_secondary_usage attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HybridSecondaryUsage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hybrid_secondary_usage");
        set => this.WithProperty("hybrid_secondary_usage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MaintenanceConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_configuration_name");
        set => this.WithProperty("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MinimumTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimum_tls_version");
        set => this.WithProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProxyOverride
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proxy_override");
        set => this.WithProperty("proxy_override", value);
    }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PublicDataEndpointEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_data_endpoint_enabled");
        set => this.WithProperty("public_data_endpoint_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_principal_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServicePrincipalType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_type");
        set => this.WithProperty("service_principal_type", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_type");
        set => this.WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StorageSizeInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_size_in_gb");
        set => this.WithProperty("storage_size_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimezoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone_id");
        set => this.WithProperty("timezone_id", value);
    }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Vcores
    {
        get => GetProperty<TerraformLiteralProperty<double>>("vcores");
        set => this.WithProperty("vcores", value);
    }

    /// <summary>
    /// The zone_redundant_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ZoneRedundantEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundant_enabled");
        set => this.WithProperty("zone_redundant_enabled", value);
    }

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    public TerraformExpression DnsZone => this["dns_zone"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
