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
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermBastionHostIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

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
    /// The public_ip_address_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressId is required")]
    [TerraformArgument("public_ip_address_id")]
    public required TerraformValue<string> PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBastionHostTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_bastion_host resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBastionHost : TerraformResource
{
    public AzurermBastionHost(string name) : base("azurerm_bastion_host", name)
    {
    }

    /// <summary>
    /// The copy_paste_enabled attribute.
    /// </summary>
    [TerraformArgument("copy_paste_enabled")]
    public TerraformValue<bool>? CopyPasteEnabled
    {
        get => new TerraformReference<bool>(this, "copy_paste_enabled");
        set => SetArgument("copy_paste_enabled", value);
    }

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    [TerraformArgument("file_copy_enabled")]
    public TerraformValue<bool>? FileCopyEnabled
    {
        get => new TerraformReference<bool>(this, "file_copy_enabled");
        set => SetArgument("file_copy_enabled", value);
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
    /// The ip_connect_enabled attribute.
    /// </summary>
    [TerraformArgument("ip_connect_enabled")]
    public TerraformValue<bool>? IpConnectEnabled
    {
        get => new TerraformReference<bool>(this, "ip_connect_enabled");
        set => SetArgument("ip_connect_enabled", value);
    }

    /// <summary>
    /// The kerberos_enabled attribute.
    /// </summary>
    [TerraformArgument("kerberos_enabled")]
    public TerraformValue<bool>? KerberosEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_enabled");
        set => SetArgument("kerberos_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The scale_units attribute.
    /// </summary>
    [TerraformArgument("scale_units")]
    public TerraformValue<double>? ScaleUnits
    {
        get => new TerraformReference<double>(this, "scale_units");
        set => SetArgument("scale_units", value);
    }

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    [TerraformArgument("session_recording_enabled")]
    public TerraformValue<bool>? SessionRecordingEnabled
    {
        get => new TerraformReference<bool>(this, "session_recording_enabled");
        set => SetArgument("session_recording_enabled", value);
    }

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    [TerraformArgument("shareable_link_enabled")]
    public TerraformValue<bool>? ShareableLinkEnabled
    {
        get => new TerraformReference<bool>(this, "shareable_link_enabled");
        set => SetArgument("shareable_link_enabled", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    [TerraformArgument("tunneling_enabled")]
    public TerraformValue<bool>? TunnelingEnabled
    {
        get => new TerraformReference<bool>(this, "tunneling_enabled");
        set => SetArgument("tunneling_enabled", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformArgument("virtual_network_id")]
    public TerraformValue<string>? VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpConfiguration block(s) allowed")]
    [TerraformArgument("ip_configuration")]
    public TerraformList<AzurermBastionHostIpConfigurationBlock> IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermBastionHostTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformArgument("dns_name")]
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

}
