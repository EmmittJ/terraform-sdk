using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyCustomRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The rate_limit_duration_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? RateLimitDurationInMinutes
    {
        get => new TerraformReference<double>(this, "rate_limit_duration_in_minutes");
        set => SetArgument("rate_limit_duration_in_minutes", value);
    }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    public TerraformValue<double>? RateLimitThreshold
    {
        get => new TerraformReference<double>(this, "rate_limit_threshold");
        set => SetArgument("rate_limit_threshold", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for managed_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyManagedRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_rule";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorFirewallPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_frontdoor_firewall_policy Terraform resource.
/// Manages a azurerm_frontdoor_firewall_policy resource.
/// </summary>
public partial class AzurermFrontdoorFirewallPolicy(string name) : TerraformResource("azurerm_frontdoor_firewall_policy", name)
{
    /// <summary>
    /// The custom_block_response_body attribute.
    /// </summary>
    public TerraformValue<string>? CustomBlockResponseBody
    {
        get => new TerraformReference<string>(this, "custom_block_response_body");
        set => SetArgument("custom_block_response_body", value);
    }

    /// <summary>
    /// The custom_block_response_status_code attribute.
    /// </summary>
    public TerraformValue<double>? CustomBlockResponseStatusCode
    {
        get => new TerraformReference<double>(this, "custom_block_response_status_code");
        set => SetArgument("custom_block_response_status_code", value);
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
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
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
    /// The redirect_url attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUrl
    {
        get => new TerraformReference<string>(this, "redirect_url");
        set => SetArgument("redirect_url", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    public TerraformList<string> FrontendEndpointIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "frontend_endpoint_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// CustomRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CustomRule block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyCustomRuleBlock>? CustomRule
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyCustomRuleBlock>>("custom_rule");
        set => SetArgument("custom_rule", value);
    }

    /// <summary>
    /// ManagedRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ManagedRule block(s) allowed")]
    public TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlock>? ManagedRule
    {
        get => GetArgument<TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlock>>("managed_rule");
        set => SetArgument("managed_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFrontdoorFirewallPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFrontdoorFirewallPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
