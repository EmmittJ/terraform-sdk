using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    /// The copy_paste_enabled attribute.
    /// </summary>
    public TerraformValue<bool> CopyPasteEnabled
    {
        get => new TerraformReference<bool>(this, "copy_paste_enabled");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FileCopyEnabled
    {
        get => new TerraformReference<bool>(this, "file_copy_enabled");
    }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IpConnectEnabled
    {
        get => new TerraformReference<bool>(this, "ip_connect_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    public TerraformValue<double> ScaleUnits
    {
        get => new TerraformReference<double>(this, "scale_units");
    }

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SessionRecordingEnabled
    {
        get => new TerraformReference<bool>(this, "session_recording_enabled");
    }

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ShareableLinkEnabled
    {
        get => new TerraformReference<bool>(this, "shareable_link_enabled");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TunnelingEnabled
    {
        get => new TerraformReference<bool>(this, "tunneling_enabled");
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBastionHostDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBastionHostDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
