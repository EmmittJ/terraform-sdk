using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressId is required")]
    public required TerraformValue<string> PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_bastion_host Terraform resource.
/// Manages a azurerm_bastion_host resource.
/// </summary>
public partial class AzurermBastionHost(string name) : TerraformResource("azurerm_bastion_host", name)
{
    /// <summary>
    /// The copy_paste_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CopyPasteEnabled
    {
        get => new TerraformReference<bool>(this, "copy_paste_enabled");
        set => SetArgument("copy_paste_enabled", value);
    }

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FileCopyEnabled
    {
        get => new TerraformReference<bool>(this, "file_copy_enabled");
        set => SetArgument("file_copy_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IpConnectEnabled
    {
        get => new TerraformReference<bool>(this, "ip_connect_enabled");
        set => SetArgument("ip_connect_enabled", value);
    }

    /// <summary>
    /// The kerberos_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? KerberosEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_enabled");
        set => SetArgument("kerberos_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The scale_units attribute.
    /// </summary>
    public TerraformValue<double>? ScaleUnits
    {
        get => new TerraformReference<double>(this, "scale_units");
        set => SetArgument("scale_units", value);
    }

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SessionRecordingEnabled
    {
        get => new TerraformReference<bool>(this, "session_recording_enabled");
        set => SetArgument("session_recording_enabled", value);
    }

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ShareableLinkEnabled
    {
        get => new TerraformReference<bool>(this, "shareable_link_enabled");
        set => SetArgument("shareable_link_enabled", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TunnelingEnabled
    {
        get => new TerraformReference<bool>(this, "tunneling_enabled");
        set => SetArgument("tunneling_enabled", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpConfiguration block(s) allowed")]
    public AzurermBastionHostIpConfigurationBlock? IpConfiguration
    {
        get => GetArgument<AzurermBastionHostIpConfigurationBlock>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBastionHostTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBastionHostTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
