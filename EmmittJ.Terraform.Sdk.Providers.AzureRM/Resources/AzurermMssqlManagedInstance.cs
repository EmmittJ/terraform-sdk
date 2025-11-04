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
    public string? AdministratorLogin
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login")?.Value;
        set => this.WithProperty("administrator_login", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public string? AdministratorLoginPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login_password")?.Value;
        set => this.WithProperty("administrator_login_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public string? Collation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collation")?.Value;
        set => this.WithProperty("collation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_format attribute.
    /// </summary>
    public string? DatabaseFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_format")?.Value;
        set => this.WithProperty("database_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public string? DnsZonePartnerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_zone_partner_id")?.Value;
        set => this.WithProperty("dns_zone_partner_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hybrid_secondary_usage attribute.
    /// </summary>
    public string? HybridSecondaryUsage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hybrid_secondary_usage")?.Value;
        set => this.WithProperty("hybrid_secondary_usage", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public string? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type")?.Value;
        set => this.WithProperty("license_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public string? MaintenanceConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_configuration_name")?.Value;
        set => this.WithProperty("maintenance_configuration_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public string? MinimumTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimum_tls_version")?.Value;
        set => this.WithProperty("minimum_tls_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    public string? ProxyOverride
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proxy_override")?.Value;
        set => this.WithProperty("proxy_override", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public bool? PublicDataEndpointEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_data_endpoint_enabled")?.Value;
        set => this.WithProperty("public_data_endpoint_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_principal_type attribute.
    /// </summary>
    public string? ServicePrincipalType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_type")?.Value;
        set => this.WithProperty("service_principal_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public string? StorageAccountType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_type")?.Value;
        set => this.WithProperty("storage_account_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public double? StorageSizeInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_size_in_gb")?.Value;
        set => this.WithProperty("storage_size_in_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public string? TimezoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone_id")?.Value;
        set => this.WithProperty("timezone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    public double? Vcores
    {
        get => GetProperty<TerraformLiteralProperty<double>>("vcores")?.Value;
        set => this.WithProperty("vcores", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The zone_redundant_enabled attribute.
    /// </summary>
    public bool? ZoneRedundantEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundant_enabled")?.Value;
        set => this.WithProperty("zone_redundant_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
