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
        get => GetArgument<TerraformValue<string>>("read");
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
    /// The azure_active_directory_authentication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureActiveDirectoryAuthentication
        => CreateReference("azure_active_directory_authentication");

    /// <summary>
    /// The client_revoked_certificate attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ClientRevokedCertificate
        => CreateReference("client_revoked_certificate");

    /// <summary>
    /// The client_root_certificate attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ClientRootCertificate
        => CreateReference("client_root_certificate");

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpsecPolicy
        => CreateReference("ipsec_policy");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The radius attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Radius
        => CreateReference("radius");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The vpn_authentication_types attribute.
    /// </summary>
    public TerraformList<string> VpnAuthenticationTypes
        => CreateReference("vpn_authentication_types");

    /// <summary>
    /// The vpn_protocols attribute.
    /// </summary>
    public TerraformSet<string> VpnProtocols
        => CreateReference("vpn_protocols");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVpnServerConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVpnServerConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
