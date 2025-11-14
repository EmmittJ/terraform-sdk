using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_managed_instance.
/// </summary>
public class AzurermMssqlManagedInstanceDataSource : TerraformDataSource
{
    public AzurermMssqlManagedInstanceDataSource(string name) : base("azurerm_mssql_managed_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlManagedInstanceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformArgument("administrator_login")]
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    [TerraformArgument("collation")]
    public TerraformValue<string> Collation
    {
        get => new TerraformReference<string>(this, "collation");
    }

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    [TerraformArgument("customer_managed_key_id")]
    public TerraformValue<string> CustomerManagedKeyId
    {
        get => new TerraformReference<string>(this, "customer_managed_key_id");
    }

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    [TerraformArgument("dns_zone")]
    public TerraformValue<string> DnsZone
    {
        get => new TerraformReference<string>(this, "dns_zone");
    }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    [TerraformArgument("dns_zone_partner_id")]
    public TerraformValue<string> DnsZonePartnerId
    {
        get => new TerraformReference<string>(this, "dns_zone_partner_id");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformArgument("minimum_tls_version")]
    public TerraformValue<string> MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
    }

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    [TerraformArgument("proxy_override")]
    public TerraformValue<string> ProxyOverride
    {
        get => new TerraformReference<string>(this, "proxy_override");
    }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    [TerraformArgument("public_data_endpoint_enabled")]
    public TerraformValue<bool> PublicDataEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "public_data_endpoint_enabled");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformArgument("storage_account_type")]
    public TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [TerraformArgument("storage_size_in_gb")]
    public TerraformValue<double> StorageSizeInGb
    {
        get => new TerraformReference<double>(this, "storage_size_in_gb");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    [TerraformArgument("timezone_id")]
    public TerraformValue<string> TimezoneId
    {
        get => new TerraformReference<string>(this, "timezone_id");
    }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    [TerraformArgument("vcores")]
    public TerraformValue<double> Vcores
    {
        get => new TerraformReference<double>(this, "vcores");
    }

}
