using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlManagedInstanceDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string> AdministratorLogin
        => CreateReference("administrator_login");

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string> Collation
        => CreateReference("collation");

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    public TerraformValue<string> CustomerManagedKeyId
        => CreateReference("customer_managed_key_id");

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    public TerraformValue<string> DnsZone
        => CreateReference("dns_zone");

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public TerraformValue<string> DnsZonePartnerId
        => CreateReference("dns_zone_partner_id");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => CreateReference("fqdn");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
        => CreateReference("license_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumTlsVersion
        => CreateReference("minimum_tls_version");

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    public TerraformValue<string> ProxyOverride
        => CreateReference("proxy_override");

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicDataEndpointEnabled
        => CreateReference("public_data_endpoint_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => CreateReference("sku_name");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountType
        => CreateReference("storage_account_type");

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> StorageSizeInGb
        => CreateReference("storage_size_in_gb");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => CreateReference("subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformValue<string> TimezoneId
        => CreateReference("timezone_id");

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    public TerraformValue<double> Vcores
        => CreateReference("vcores");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedInstanceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedInstanceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
