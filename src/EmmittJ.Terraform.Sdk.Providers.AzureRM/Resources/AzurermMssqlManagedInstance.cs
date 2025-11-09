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
    public TerraformProperty<string>? AdministratorLogin
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login");
        set => this.WithProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLoginPassword
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login_password");
        set => this.WithProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformProperty<string>? Collation
    {
        get => GetProperty<TerraformProperty<string>>("collation");
        set => this.WithProperty("collation", value);
    }

    /// <summary>
    /// The database_format attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseFormat
    {
        get => GetProperty<TerraformProperty<string>>("database_format");
        set => this.WithProperty("database_format", value);
    }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public TerraformProperty<string>? DnsZonePartnerId
    {
        get => GetProperty<TerraformProperty<string>>("dns_zone_partner_id");
        set => this.WithProperty("dns_zone_partner_id", value);
    }

    /// <summary>
    /// The hybrid_secondary_usage attribute.
    /// </summary>
    public TerraformProperty<string>? HybridSecondaryUsage
    {
        get => GetProperty<TerraformProperty<string>>("hybrid_secondary_usage");
        set => this.WithProperty("hybrid_secondary_usage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_configuration_name");
        set => this.WithProperty("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("minimum_tls_version");
        set => this.WithProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    public TerraformProperty<string>? ProxyOverride
    {
        get => GetProperty<TerraformProperty<string>>("proxy_override");
        set => this.WithProperty("proxy_override", value);
    }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicDataEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_data_endpoint_enabled");
        set => this.WithProperty("public_data_endpoint_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_principal_type attribute.
    /// </summary>
    public TerraformProperty<string>? ServicePrincipalType
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_type");
        set => this.WithProperty("service_principal_type", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => this.WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? StorageSizeInGb
    {
        get => GetProperty<TerraformProperty<double>>("storage_size_in_gb");
        set => this.WithProperty("storage_size_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformProperty<string>? TimezoneId
    {
        get => GetProperty<TerraformProperty<string>>("timezone_id");
        set => this.WithProperty("timezone_id", value);
    }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    public TerraformProperty<double>? Vcores
    {
        get => GetProperty<TerraformProperty<double>>("vcores");
        set => this.WithProperty("vcores", value);
    }

    /// <summary>
    /// The zone_redundant_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundantEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundant_enabled");
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
