using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for pcc_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkServicePccRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pcc_rule";

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
    /// The precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Precedence is required")]
    public required TerraformValue<double> Precedence
    {
        get => new TerraformReference<double>(this, "precedence");
        set => SetArgument("precedence", value);
    }

    /// <summary>
    /// The traffic_control_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TrafficControlEnabled
    {
        get => new TerraformReference<bool>(this, "traffic_control_enabled");
        set => SetArgument("traffic_control_enabled", value);
    }

}

/// <summary>
/// Block type for service_qos_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkServiceServiceQosPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_qos_policy";

    /// <summary>
    /// The allocation_and_retention_priority_level attribute.
    /// </summary>
    public TerraformValue<double>? AllocationAndRetentionPriorityLevel
    {
        get => new TerraformReference<double>(this, "allocation_and_retention_priority_level");
        set => SetArgument("allocation_and_retention_priority_level", value);
    }

    /// <summary>
    /// The preemption_capability attribute.
    /// </summary>
    public TerraformValue<string>? PreemptionCapability
    {
        get => new TerraformReference<string>(this, "preemption_capability");
        set => SetArgument("preemption_capability", value);
    }

    /// <summary>
    /// The preemption_vulnerability attribute.
    /// </summary>
    public TerraformValue<string>? PreemptionVulnerability
    {
        get => new TerraformReference<string>(this, "preemption_vulnerability");
        set => SetArgument("preemption_vulnerability", value);
    }

    /// <summary>
    /// The qos_indicator attribute.
    /// </summary>
    public TerraformValue<double>? QosIndicator
    {
        get => new TerraformReference<double>(this, "qos_indicator");
        set => SetArgument("qos_indicator", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkServiceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mobile_network_service Terraform resource.
/// Manages a azurerm_mobile_network_service resource.
/// </summary>
public partial class AzurermMobileNetworkService(string name) : TerraformResource("azurerm_mobile_network_service", name)
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
    /// The mobile_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkId is required")]
    public required TerraformValue<string> MobileNetworkId
    {
        get => new TerraformReference<string>(this, "mobile_network_id");
        set => SetArgument("mobile_network_id", value);
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
    /// The service_precedence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrecedence is required")]
    public required TerraformValue<double> ServicePrecedence
    {
        get => new TerraformReference<double>(this, "service_precedence");
        set => SetArgument("service_precedence", value);
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
    /// PccRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PccRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PccRule block(s) required")]
    public required TerraformList<AzurermMobileNetworkServicePccRuleBlock> PccRule
    {
        get => GetRequiredArgument<TerraformList<AzurermMobileNetworkServicePccRuleBlock>>("pcc_rule");
        set => SetArgument("pcc_rule", value);
    }

    /// <summary>
    /// ServiceQosPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceQosPolicy block(s) allowed")]
    public TerraformList<AzurermMobileNetworkServiceServiceQosPolicyBlock>? ServiceQosPolicy
    {
        get => GetArgument<TerraformList<AzurermMobileNetworkServiceServiceQosPolicyBlock>>("service_qos_policy");
        set => SetArgument("service_qos_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
