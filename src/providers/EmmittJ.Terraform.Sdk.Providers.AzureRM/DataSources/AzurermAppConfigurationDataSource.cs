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
public class AzurermAppConfigurationDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_app_configuration.
/// </summary>
public class AzurermAppConfigurationDataSource : TerraformDataSource
{
    public AzurermAppConfigurationDataSource(string name) : base("azurerm_app_configuration", name)
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
    public AzurermAppConfigurationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The data_plane_proxy_authentication_mode attribute.
    /// </summary>
    [TerraformArgument("data_plane_proxy_authentication_mode")]
    public TerraformValue<string> DataPlaneProxyAuthenticationMode
    {
        get => new TerraformReference<string>(this, "data_plane_proxy_authentication_mode");
    }

    /// <summary>
    /// The data_plane_proxy_private_link_delegation_enabled attribute.
    /// </summary>
    [TerraformArgument("data_plane_proxy_private_link_delegation_enabled")]
    public TerraformValue<bool> DataPlaneProxyPrivateLinkDelegationEnabled
    {
        get => new TerraformReference<bool>(this, "data_plane_proxy_private_link_delegation_enabled");
    }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformArgument("encryption")]
    public TerraformList<object> Encryption
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "encryption").ResolveNodes(ctx));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
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
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformArgument("local_auth_enabled")]
    public TerraformValue<bool> LocalAuthEnabled
    {
        get => new TerraformReference<bool>(this, "local_auth_enabled");
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
    /// The primary_read_key attribute.
    /// </summary>
    [TerraformArgument("primary_read_key")]
    public TerraformList<object> PrimaryReadKey
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "primary_read_key").ResolveNodes(ctx));
    }

    /// <summary>
    /// The primary_write_key attribute.
    /// </summary>
    [TerraformArgument("primary_write_key")]
    public TerraformList<object> PrimaryWriteKey
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "primary_write_key").ResolveNodes(ctx));
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformArgument("public_network_access")]
    public TerraformValue<string> PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    [TerraformArgument("purge_protection_enabled")]
    public TerraformValue<bool> PurgeProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "purge_protection_enabled");
    }

    /// <summary>
    /// The replica attribute.
    /// </summary>
    [TerraformArgument("replica")]
    public TerraformList<object> Replica
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "replica").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_read_key attribute.
    /// </summary>
    [TerraformArgument("secondary_read_key")]
    public TerraformList<object> SecondaryReadKey
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "secondary_read_key").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secondary_write_key attribute.
    /// </summary>
    [TerraformArgument("secondary_write_key")]
    public TerraformList<object> SecondaryWriteKey
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "secondary_write_key").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    [TerraformArgument("soft_delete_retention_days")]
    public TerraformValue<double> SoftDeleteRetentionDays
    {
        get => new TerraformReference<double>(this, "soft_delete_retention_days");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
