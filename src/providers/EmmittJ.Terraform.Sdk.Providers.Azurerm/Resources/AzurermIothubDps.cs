using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ip_filter_rule in AzurermIothubDps.
/// Nesting mode: list
/// </summary>
public class AzurermIothubDpsIpFilterRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_filter_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    public required TerraformValue<string> IpMask
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_mask");
        set => SetArgument("ip_mask", value);
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
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

}


/// <summary>
/// Block type for linked_hub in AzurermIothubDps.
/// Nesting mode: list
/// </summary>
public class AzurermIothubDpsLinkedHubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linked_hub";

    /// <summary>
    /// The allocation_weight attribute.
    /// </summary>
    public TerraformValue<double>? AllocationWeight
    {
        get => GetArgument<TerraformValue<double>>("allocation_weight");
        set => SetArgument("allocation_weight", value);
    }

    /// <summary>
    /// The apply_allocation_policy attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyAllocationPolicy
    {
        get => GetArgument<TerraformValue<bool>>("apply_allocation_policy");
        set => SetArgument("apply_allocation_policy", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformValue<string> ConnectionString
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => CreateReference("hostname");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

}


/// <summary>
/// Block type for sku in AzurermIothubDps.
/// Nesting mode: list
/// </summary>
public class AzurermIothubDpsSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformValue<double> Capacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
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

}


/// <summary>
/// Block type for timeouts in AzurermIothubDps.
/// Nesting mode: single
/// </summary>
public class AzurermIothubDpsTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_iothub_dps Terraform resource.
/// Manages a azurerm_iothub_dps resource.
/// </summary>
public partial class AzurermIothubDps(string name) : TerraformResource("azurerm_iothub_dps", name)
{
    /// <summary>
    /// The allocation_policy attribute.
    /// </summary>
    public TerraformValue<string>? AllocationPolicy
    {
        get => GetArgument<TerraformValue<string>>("allocation_policy");
        set => SetArgument("allocation_policy", value);
    }

    /// <summary>
    /// The data_residency_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DataResidencyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("data_residency_enabled");
        set => SetArgument("data_residency_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The device_provisioning_host_name attribute.
    /// </summary>
    public TerraformValue<string> DeviceProvisioningHostName
        => CreateReference("device_provisioning_host_name");

    /// <summary>
    /// The id_scope attribute.
    /// </summary>
    public TerraformValue<string> IdScope
        => CreateReference("id_scope");

    /// <summary>
    /// The service_operations_host_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceOperationsHostName
        => CreateReference("service_operations_host_name");

    /// <summary>
    /// IpFilterRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermIothubDpsIpFilterRuleBlock>? IpFilterRule
    {
        get => GetArgument<TerraformList<AzurermIothubDpsIpFilterRuleBlock>>("ip_filter_rule");
        set => SetArgument("ip_filter_rule", value);
    }

    /// <summary>
    /// LinkedHub block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermIothubDpsLinkedHubBlock>? LinkedHub
    {
        get => GetArgument<TerraformList<AzurermIothubDpsLinkedHubBlock>>("linked_hub");
        set => SetArgument("linked_hub", value);
    }

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermIothubDpsSkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermIothubDpsSkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIothubDpsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIothubDpsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
