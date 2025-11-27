using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in AwsVpclatticeListenerRule.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// FixedResponse block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedResponse block(s) allowed")]
    public TerraformList<AwsVpclatticeListenerRuleActionBlockFixedResponseBlock>? FixedResponse
    {
        get => GetArgument<TerraformList<AwsVpclatticeListenerRuleActionBlockFixedResponseBlock>>("fixed_response");
        set => SetArgument("fixed_response", value);
    }

    /// <summary>
    /// Forward block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Forward block(s) allowed")]
    public TerraformList<AwsVpclatticeListenerRuleActionBlockForwardBlock>? Forward
    {
        get => GetArgument<TerraformList<AwsVpclatticeListenerRuleActionBlockForwardBlock>>("forward");
        set => SetArgument("forward", value);
    }

}

/// <summary>
/// Block type for fixed_response in AwsVpclatticeListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleActionBlockFixedResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_response";

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<double> StatusCode
    {
        get => new TerraformReference<double>(this, "status_code");
        set => SetArgument("status_code", value);
    }

}

/// <summary>
/// Block type for forward in AwsVpclatticeListenerRuleActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleActionBlockForwardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward";

    /// <summary>
    /// TargetGroups block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroups is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetGroups block(s) required")]
    public required TerraformList<AwsVpclatticeListenerRuleActionBlockForwardBlockTargetGroupsBlock> TargetGroups
    {
        get => GetRequiredArgument<TerraformList<AwsVpclatticeListenerRuleActionBlockForwardBlockTargetGroupsBlock>>("target_groups");
        set => SetArgument("target_groups", value);
    }

}

/// <summary>
/// Block type for target_groups in AwsVpclatticeListenerRuleActionBlockForwardBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleActionBlockForwardBlockTargetGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_groups";

    /// <summary>
    /// The target_group_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupIdentifier is required")]
    public required TerraformValue<string> TargetGroupIdentifier
    {
        get => new TerraformReference<string>(this, "target_group_identifier");
        set => SetArgument("target_group_identifier", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Block type for match in AwsVpclatticeListenerRule.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// HttpMatch block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMatch is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HttpMatch block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpMatch block(s) allowed")]
    public required TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlock> HttpMatch
    {
        get => GetRequiredArgument<TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlock>>("http_match");
        set => SetArgument("http_match", value);
    }

}

/// <summary>
/// Block type for http_match in AwsVpclatticeListenerRuleMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleMatchBlockHttpMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_match";

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformValue<string>? Method
    {
        get => new TerraformReference<string>(this, "method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// HeaderMatches block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 HeaderMatches block(s) allowed")]
    public TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockHeaderMatchesBlock>? HeaderMatches
    {
        get => GetArgument<TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockHeaderMatchesBlock>>("header_matches");
        set => SetArgument("header_matches", value);
    }

    /// <summary>
    /// PathMatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PathMatch block(s) allowed")]
    public TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockPathMatchBlock>? PathMatch
    {
        get => GetArgument<TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockPathMatchBlock>>("path_match");
        set => SetArgument("path_match", value);
    }

}

/// <summary>
/// Block type for header_matches in AwsVpclatticeListenerRuleMatchBlockHttpMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockHeaderMatchesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_matches";

    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    public TerraformValue<bool>? CaseSensitive
    {
        get => new TerraformReference<bool>(this, "case_sensitive");
        set => SetArgument("case_sensitive", value);
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
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockHeaderMatchesBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockHeaderMatchesBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockHeaderMatchesBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockHeaderMatchesBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The contains attribute.
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => new TerraformReference<string>(this, "contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => new TerraformReference<string>(this, "exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

}

/// <summary>
/// Block type for path_match in AwsVpclatticeListenerRuleMatchBlockHttpMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockPathMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path_match";

    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    public TerraformValue<bool>? CaseSensitive
    {
        get => new TerraformReference<bool>(this, "case_sensitive");
        set => SetArgument("case_sensitive", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockPathMatchBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockPathMatchBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockPathMatchBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerRuleMatchBlockHttpMatchBlockPathMatchBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => new TerraformReference<string>(this, "exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpclatticeListenerRule.
/// Nesting mode: single
/// </summary>
public class AwsVpclatticeListenerRuleTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_vpclattice_listener_rule Terraform resource.
/// Manages a aws_vpclattice_listener_rule resource.
/// </summary>
public partial class AwsVpclatticeListenerRule(string name) : TerraformResource("aws_vpclattice_listener_rule", name)
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
    /// The listener_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerIdentifier is required")]
    public required TerraformValue<string> ListenerIdentifier
    {
        get => new TerraformReference<string>(this, "listener_identifier");
        set => SetArgument("listener_identifier", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceIdentifier is required")]
    public required TerraformValue<string> ServiceIdentifier
    {
        get => new TerraformReference<string>(this, "service_identifier");
        set => SetArgument("service_identifier", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    public TerraformValue<string> RuleId
    {
        get => new TerraformReference<string>(this, "rule_id");
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<AwsVpclatticeListenerRuleActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsVpclatticeListenerRuleActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsVpclatticeListenerRuleMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsVpclatticeListenerRuleMatchBlock>>("match");
        set => SetArgument("match", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpclatticeListenerRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpclatticeListenerRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
