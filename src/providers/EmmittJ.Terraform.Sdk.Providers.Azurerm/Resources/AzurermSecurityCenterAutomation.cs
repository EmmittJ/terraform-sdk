using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for action in AzurermSecurityCenterAutomation.
/// Nesting mode: list
/// </summary>
public class AzurermSecurityCenterAutomationActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The trigger_url attribute.
    /// </summary>
    public TerraformValue<string>? TriggerUrl
    {
        get => new TerraformReference<string>(this, "trigger_url");
        set => SetArgument("trigger_url", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for source in AzurermSecurityCenterAutomation.
/// Nesting mode: list
/// </summary>
public class AzurermSecurityCenterAutomationSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The event_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventSource is required")]
    public required TerraformValue<string> EventSource
    {
        get => new TerraformReference<string>(this, "event_source");
        set => SetArgument("event_source", value);
    }

    /// <summary>
    /// RuleSet block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSecurityCenterAutomationSourceBlockRuleSetBlock>? RuleSet
    {
        get => GetArgument<TerraformList<AzurermSecurityCenterAutomationSourceBlockRuleSetBlock>>("rule_set");
        set => SetArgument("rule_set", value);
    }

}

/// <summary>
/// Block type for rule_set in AzurermSecurityCenterAutomationSourceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSecurityCenterAutomationSourceBlockRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_set";

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformList<AzurermSecurityCenterAutomationSourceBlockRuleSetBlockRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AzurermSecurityCenterAutomationSourceBlockRuleSetBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AzurermSecurityCenterAutomationSourceBlockRuleSetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSecurityCenterAutomationSourceBlockRuleSetBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The expected_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpectedValue is required")]
    public required TerraformValue<string> ExpectedValue
    {
        get => new TerraformReference<string>(this, "expected_value");
        set => SetArgument("expected_value", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The property_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyPath is required")]
    public required TerraformValue<string> PropertyPath
    {
        get => new TerraformReference<string>(this, "property_path");
        set => SetArgument("property_path", value);
    }

    /// <summary>
    /// The property_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyType is required")]
    public required TerraformValue<string> PropertyType
    {
        get => new TerraformReference<string>(this, "property_type");
        set => SetArgument("property_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSecurityCenterAutomation.
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAutomationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_security_center_automation Terraform resource.
/// Manages a azurerm_security_center_automation resource.
/// </summary>
public partial class AzurermSecurityCenterAutomation(string name) : TerraformResource("azurerm_security_center_automation", name)
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
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public TerraformList<string>? Scopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
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
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    public required TerraformList<AzurermSecurityCenterAutomationActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AzurermSecurityCenterAutomationActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    public required TerraformList<AzurermSecurityCenterAutomationSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AzurermSecurityCenterAutomationSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSecurityCenterAutomationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSecurityCenterAutomationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
