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
public class AzurermVpnServerConfigurationDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_vpn_server_configuration.
/// </summary>
public class AzurermVpnServerConfigurationDataSource : TerraformDataSource
{
    public AzurermVpnServerConfigurationDataSource(string name) : base("azurerm_vpn_server_configuration", name)
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
    public AzurermVpnServerConfigurationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The azure_active_directory_authentication attribute.
    /// </summary>
    [TerraformArgument("azure_active_directory_authentication")]
    public TerraformList<object> AzureActiveDirectoryAuthentication
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "azure_active_directory_authentication").ResolveNodes(ctx));
    }

    /// <summary>
    /// The client_revoked_certificate attribute.
    /// </summary>
    [TerraformArgument("client_revoked_certificate")]
    public TerraformSet<object> ClientRevokedCertificate
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "client_revoked_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The client_root_certificate attribute.
    /// </summary>
    [TerraformArgument("client_root_certificate")]
    public TerraformSet<object> ClientRootCertificate
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "client_root_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    [TerraformArgument("ipsec_policy")]
    public TerraformList<object> IpsecPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ipsec_policy").ResolveNodes(ctx));
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
    /// The radius attribute.
    /// </summary>
    [TerraformArgument("radius")]
    public TerraformList<object> Radius
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "radius").ResolveNodes(ctx));
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
    /// The vpn_authentication_types attribute.
    /// </summary>
    [TerraformArgument("vpn_authentication_types")]
    public TerraformList<string> VpnAuthenticationTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vpn_authentication_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    [TerraformArgument("vpn_protocols")]
    public TerraformSet<string> VpnProtocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpn_protocols").ResolveNodes(ctx));
    }

}
