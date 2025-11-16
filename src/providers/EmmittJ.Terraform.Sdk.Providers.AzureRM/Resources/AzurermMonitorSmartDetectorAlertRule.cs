using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for action_group in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorSmartDetectorAlertRuleActionGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_group";

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformValue<string>? EmailSubject
    {
        get => new TerraformReference<string>(this, "email_subject");
        set => SetArgument("email_subject", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ids is required")]
    public required TerraformSet<string> Ids
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ids").ResolveNodes(ctx));
        set => SetArgument("ids", value);
    }

    /// <summary>
    /// The webhook_payload attribute.
    /// </summary>
    public TerraformValue<string>? WebhookPayload
    {
        get => new TerraformReference<string>(this, "webhook_payload");
        set => SetArgument("webhook_payload", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorSmartDetectorAlertRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_smart_detector_alert_rule Terraform resource.
/// Manages a azurerm_monitor_smart_detector_alert_rule resource.
/// </summary>
public partial class AzurermMonitorSmartDetectorAlertRule(string name) : TerraformResource("azurerm_monitor_smart_detector_alert_rule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The detector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorType is required")]
    public required TerraformValue<string> DetectorType
    {
        get => new TerraformReference<string>(this, "detector_type");
        set => SetArgument("detector_type", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
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
    /// The scope_resource_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeResourceIds is required")]
    public required TerraformSet<string> ScopeResourceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scope_resource_ids").ResolveNodes(ctx));
        set => SetArgument("scope_resource_ids", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformValue<string> Severity
    {
        get => new TerraformReference<string>(this, "severity");
        set => SetArgument("severity", value);
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
    /// The throttling_duration attribute.
    /// </summary>
    public TerraformValue<string>? ThrottlingDuration
    {
        get => new TerraformReference<string>(this, "throttling_duration");
        set => SetArgument("throttling_duration", value);
    }

    /// <summary>
    /// ActionGroup block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ActionGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionGroup block(s) allowed")]
    public required TerraformList<AzurermMonitorSmartDetectorAlertRuleActionGroupBlock> ActionGroup
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorSmartDetectorAlertRuleActionGroupBlock>>("action_group");
        set => SetArgument("action_group", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorSmartDetectorAlertRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorSmartDetectorAlertRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
