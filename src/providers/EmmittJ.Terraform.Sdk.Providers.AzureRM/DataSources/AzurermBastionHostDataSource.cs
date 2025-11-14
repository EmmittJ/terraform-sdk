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
public class AzurermBastionHostDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_bastion_host.
/// </summary>
public class AzurermBastionHostDataSource : TerraformDataSource
{
    public AzurermBastionHostDataSource(string name) : base("azurerm_bastion_host", name)
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
    public AzurermBastionHostDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The copy_paste_enabled attribute.
    /// </summary>
    [TerraformArgument("copy_paste_enabled")]
    public TerraformValue<bool> CopyPasteEnabled
    {
        get => new TerraformReference<bool>(this, "copy_paste_enabled");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformArgument("dns_name")]
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    [TerraformArgument("file_copy_enabled")]
    public TerraformValue<bool> FileCopyEnabled
    {
        get => new TerraformReference<bool>(this, "file_copy_enabled");
    }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformArgument("ip_configuration")]
    public TerraformList<object> IpConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    [TerraformArgument("ip_connect_enabled")]
    public TerraformValue<bool> IpConnectEnabled
    {
        get => new TerraformReference<bool>(this, "ip_connect_enabled");
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
    /// The scale_units attribute.
    /// </summary>
    [TerraformArgument("scale_units")]
    public TerraformValue<double> ScaleUnits
    {
        get => new TerraformReference<double>(this, "scale_units");
    }

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    [TerraformArgument("session_recording_enabled")]
    public TerraformValue<bool> SessionRecordingEnabled
    {
        get => new TerraformReference<bool>(this, "session_recording_enabled");
    }

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    [TerraformArgument("shareable_link_enabled")]
    public TerraformValue<bool> ShareableLinkEnabled
    {
        get => new TerraformReference<bool>(this, "shareable_link_enabled");
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    [TerraformArgument("tunneling_enabled")]
    public TerraformValue<bool> TunnelingEnabled
    {
        get => new TerraformReference<bool>(this, "tunneling_enabled");
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

}
