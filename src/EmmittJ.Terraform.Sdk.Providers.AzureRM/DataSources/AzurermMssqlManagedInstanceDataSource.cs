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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("administrator_login");
        this.DeclareOutput("collation");
        this.DeclareOutput("customer_managed_key_id");
        this.DeclareOutput("dns_zone");
        this.DeclareOutput("dns_zone_partner_id");
        this.DeclareOutput("fqdn");
        this.DeclareOutput("identity");
        this.DeclareOutput("license_type");
        this.DeclareOutput("location");
        this.DeclareOutput("minimum_tls_version");
        this.DeclareOutput("proxy_override");
        this.DeclareOutput("public_data_endpoint_enabled");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("storage_account_type");
        this.DeclareOutput("storage_size_in_gb");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("tags");
        this.DeclareOutput("timezone_id");
        this.DeclareOutput("vcores");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedInstanceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlManagedInstanceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
