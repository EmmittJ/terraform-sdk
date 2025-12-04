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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string> AdministratorLogin
        => AsReference("administrator_login");

    /// <summary>
    /// The collation attribute.
    /// </summary>
    public TerraformValue<string> Collation
        => AsReference("collation");

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    public TerraformValue<string> CustomerManagedKeyId
        => AsReference("customer_managed_key_id");

    /// <summary>
    /// The dns_zone attribute.
    /// </summary>
    public TerraformValue<string> DnsZone
        => AsReference("dns_zone");

    /// <summary>
    /// The dns_zone_partner_id attribute.
    /// </summary>
    public TerraformValue<string> DnsZonePartnerId
        => AsReference("dns_zone_partner_id");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
        => AsReference("license_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string> MinimumTlsVersion
        => AsReference("minimum_tls_version");

    /// <summary>
    /// The proxy_override attribute.
    /// </summary>
    public TerraformValue<string> ProxyOverride
        => AsReference("proxy_override");

    /// <summary>
    /// The public_data_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicDataEndpointEnabled
        => AsReference("public_data_endpoint_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => AsReference("sku_name");

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountType
        => AsReference("storage_account_type");

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> StorageSizeInGb
        => AsReference("storage_size_in_gb");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => AsReference("subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformValue<string> TimezoneId
        => AsReference("timezone_id");

    /// <summary>
    /// The vcores attribute.
    /// </summary>
    public TerraformValue<double> Vcores
        => AsReference("vcores");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedInstanceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedInstanceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
