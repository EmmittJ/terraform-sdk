using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBastionHostDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermBastionHostDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_bastion_host Terraform data source.
/// Retrieves information about a azurerm_bastion_host.
/// </summary>
public partial class AzurermBastionHostDataSource(string name) : TerraformDataSource("azurerm_bastion_host", name)
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
    /// The copy_paste_enabled attribute.
    /// </summary>
    public TerraformValue<bool> CopyPasteEnabled
        => CreateReference("copy_paste_enabled");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FileCopyEnabled
        => CreateReference("file_copy_enabled");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
        => CreateReference("ip_configuration");

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IpConnectEnabled
        => CreateReference("ip_connect_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    public TerraformValue<double> ScaleUnits
        => CreateReference("scale_units");

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SessionRecordingEnabled
        => CreateReference("session_recording_enabled");

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ShareableLinkEnabled
        => CreateReference("shareable_link_enabled");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => CreateReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TunnelingEnabled
        => CreateReference("tunneling_enabled");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => CreateReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBastionHostDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBastionHostDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
