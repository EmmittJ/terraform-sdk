using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_managed_instance.
/// </summary>
public class AzurermMssqlManagedInstanceDataSource : TerraformDataSource
{
    public AzurermMssqlManagedInstanceDataSource(string name) : base("azurerm_mssql_managed_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("administrator_login");
        SetOutput("collation");
        SetOutput("customer_managed_key_id");
        SetOutput("dns_zone");
        SetOutput("dns_zone_partner_id");
        SetOutput("fqdn");
        SetOutput("identity");
        SetOutput("license_type");
        SetOutput("location");
        SetOutput("minimum_tls_version");
        SetOutput("proxy_override");
        SetOutput("public_data_endpoint_enabled");
        SetOutput("sku_name");
        SetOutput("storage_account_type");
        SetOutput("storage_size_in_gb");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("timezone_id");
        SetOutput("vcores");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedInstanceDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformExpression AdministratorLogin => this["administrator_login"];

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformExpression Collation => this["collation"];

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    public TerraformExpression CustomerManagedKeyId => this["customer_managed_key_id"];

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    public TerraformExpression DnsZone => this["dns_zone"];

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public TerraformExpression DnsZonePartnerId => this["dns_zone_partner_id"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformExpression LicenseType => this["license_type"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformExpression MinimumTlsVersion => this["minimum_tls_version"];

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    public TerraformExpression ProxyOverride => this["proxy_override"];

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public TerraformExpression PublicDataEndpointEnabled => this["public_data_endpoint_enabled"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformExpression StorageAccountType => this["storage_account_type"];

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformExpression StorageSizeInGb => this["storage_size_in_gb"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformExpression TimezoneId => this["timezone_id"];

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    public TerraformExpression Vcores => this["vcores"];

}
