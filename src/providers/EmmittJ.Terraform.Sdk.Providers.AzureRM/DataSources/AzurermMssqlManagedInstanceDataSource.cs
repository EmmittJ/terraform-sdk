using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_mssql_managed_instance Terraform data source.
/// Retrieves information about a azurerm_mssql_managed_instance.
/// </summary>
public partial class AzurermMssqlManagedInstanceDataSource(string name) : TerraformDataSource("azurerm_mssql_managed_instance", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
    }

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string> Collation
    {
        get => new TerraformReference<string>(this, "collation");
    }

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    public TerraformValue<string> CustomerManagedKeyId
    {
        get => new TerraformReference<string>(this, "customer_managed_key_id");
    }

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    public TerraformValue<string> DnsZone
    {
        get => new TerraformReference<string>(this, "dns_zone");
    }

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public TerraformValue<string> DnsZonePartnerId
    {
        get => new TerraformReference<string>(this, "dns_zone_partner_id");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
    }

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    public TerraformValue<string> ProxyOverride
    {
        get => new TerraformReference<string>(this, "proxy_override");
    }

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicDataEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "public_data_endpoint_enabled");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> StorageSizeInGb
    {
        get => new TerraformReference<double>(this, "storage_size_in_gb");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformValue<string> TimezoneId
    {
        get => new TerraformReference<string>(this, "timezone_id");
    }

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    public TerraformValue<double> Vcores
    {
        get => new TerraformReference<double>(this, "vcores");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedInstanceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedInstanceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
