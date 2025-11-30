using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVpnServerConfigurationDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_vpn_server_configuration Terraform data source.
/// Retrieves information about a azurerm_vpn_server_configuration.
/// </summary>
public partial class AzurermVpnServerConfigurationDataSource(string name) : TerraformDataSource("azurerm_vpn_server_configuration", name)
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
    /// The azure_active_directory_authentication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureActiveDirectoryAuthentication
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "azure_active_directory_authentication").ResolveNodes(ctx));
    }

    /// <summary>
    /// The client_revoked_certificate attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ClientRevokedCertificate
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "client_revoked_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The client_root_certificate attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ClientRootCertificate
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "client_root_certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpsecPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ipsec_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The radius attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Radius
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "radius").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    public TerraformList<string> VpnAuthenticationTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vpn_authentication_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    public TerraformSet<string> VpnProtocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpn_protocols").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVpnServerConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVpnServerConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
