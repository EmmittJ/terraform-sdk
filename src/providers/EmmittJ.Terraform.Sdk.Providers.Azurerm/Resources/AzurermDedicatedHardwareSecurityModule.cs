using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for management_network_profile in AzurermDedicatedHardwareSecurityModule.
/// Nesting mode: list
/// </summary>
public class AzurermDedicatedHardwareSecurityModuleManagementNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management_network_profile";

    /// <summary>
    /// The network_interface_private_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfacePrivateIpAddresses is required")]
    public required TerraformSet<string> NetworkInterfacePrivateIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "network_interface_private_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("network_interface_private_ip_addresses", value);
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
/// Block type for network_profile in AzurermDedicatedHardwareSecurityModule.
/// Nesting mode: list
/// </summary>
public class AzurermDedicatedHardwareSecurityModuleNetworkProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_profile";

    /// <summary>
    /// The network_interface_private_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfacePrivateIpAddresses is required")]
    public required TerraformSet<string> NetworkInterfacePrivateIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "network_interface_private_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("network_interface_private_ip_addresses", value);
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
/// Block type for timeouts in AzurermDedicatedHardwareSecurityModule.
/// Nesting mode: single
/// </summary>
public class AzurermDedicatedHardwareSecurityModuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_dedicated_hardware_security_module Terraform resource.
/// Manages a azurerm_dedicated_hardware_security_module resource.
/// </summary>
public partial class AzurermDedicatedHardwareSecurityModule(string name) : TerraformResource("azurerm_dedicated_hardware_security_module", name)
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The stamp_id attribute.
    /// </summary>
    public TerraformValue<string>? StampId
    {
        get => new TerraformReference<string>(this, "stamp_id");
        set => SetArgument("stamp_id", value);
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
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// ManagementNetworkProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementNetworkProfile block(s) allowed")]
    public TerraformList<AzurermDedicatedHardwareSecurityModuleManagementNetworkProfileBlock>? ManagementNetworkProfile
    {
        get => GetArgument<TerraformList<AzurermDedicatedHardwareSecurityModuleManagementNetworkProfileBlock>>("management_network_profile");
        set => SetArgument("management_network_profile", value);
    }

    /// <summary>
    /// NetworkProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    public required TerraformList<AzurermDedicatedHardwareSecurityModuleNetworkProfileBlock> NetworkProfile
    {
        get => GetRequiredArgument<TerraformList<AzurermDedicatedHardwareSecurityModuleNetworkProfileBlock>>("network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDedicatedHardwareSecurityModuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDedicatedHardwareSecurityModuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
