using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppConfigurationDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_app_configuration Terraform data source.
/// Retrieves information about a azurerm_app_configuration.
/// </summary>
public partial class AzurermAppConfigurationDataSource(string name) : TerraformDataSource("azurerm_app_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    public TerraformValue<string> DataPlaneProxyAuthenticationMode
        => AsReference("data_plane_proxy_authentication_mode");

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DataPlaneProxyPrivateLinkDelegationEnabled
        => AsReference("data_plane_proxy_private_link_delegation_enabled");

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Encryption
        => AsReference("encryption");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalAuthEnabled
        => AsReference("local_auth_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The primary_read_key attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrimaryReadKey
        => AsReference("primary_read_key");

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrimaryWriteKey
        => AsReference("primary_write_key");

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformValue<string> PublicNetworkAccess
        => AsReference("public_network_access");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PurgeProtectionEnabled
        => AsReference("purge_protection_enabled");

    /// <summary>
    /// The replica attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Replica
        => AsReference("replica");

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecondaryReadKey
        => AsReference("secondary_read_key");

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecondaryWriteKey
        => AsReference("secondary_write_key");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public TerraformValue<double> SoftDeleteRetentionDays
        => AsReference("soft_delete_retention_days");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
