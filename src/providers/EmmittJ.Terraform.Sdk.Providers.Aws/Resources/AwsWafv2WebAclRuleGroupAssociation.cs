using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for managed_rule_group in AwsWafv2WebAclRuleGroupAssociation.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_rule_group";

    /// <summary>
    /// Name of the managed rule group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Name of the managed rule group vendor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VendorName is required")]
    public required TerraformValue<string> VendorName
    {
        get => new TerraformReference<string>(this, "vendor_name");
        set => SetArgument("vendor_name", value);
    }

    /// <summary>
    /// Version of the managed rule group. Omit this to use the default version.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// RuleActionOverride block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlock>? RuleActionOverride
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlock>>("rule_action_override");
        set => SetArgument("rule_action_override", value);
    }

}

/// <summary>
/// Block type for rule_action_override in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_action_override";

    /// <summary>
    /// Name of the rule to override.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// ActionToUse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlock>? ActionToUse
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlock>>("action_to_use");
        set => SetArgument("action_to_use", value);
    }

}

/// <summary>
/// Block type for action_to_use in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_to_use";

    /// <summary>
    /// Allow block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlock>? Allow
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlock>>("allow");
        set => SetArgument("allow", value);
    }

    /// <summary>
    /// Block block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlock>? Block
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlock>>("block");
        set => SetArgument("block", value);
    }

    /// <summary>
    /// Captcha block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlock>? Captcha
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlock>>("captcha");
        set => SetArgument("captcha", value);
    }

    /// <summary>
    /// Challenge block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlock>? Challenge
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlock>>("challenge");
        set => SetArgument("challenge", value);
    }

    /// <summary>
    /// CountAttribute block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlock>? CountAttribute
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlock>>("count");
        set => SetArgument("count", value);
    }

}

/// <summary>
/// Block type for allow in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allow";

    /// <summary>
    /// CustomRequestHandling block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlock>? CustomRequestHandling
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlock>>("custom_request_handling");
        set => SetArgument("custom_request_handling", value);
    }

}

/// <summary>
/// Block type for custom_request_handling in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_request_handling";

    /// <summary>
    /// InsertHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlockInsertHeaderBlock>? InsertHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlockInsertHeaderBlock>>("insert_header");
        set => SetArgument("insert_header", value);
    }

}

/// <summary>
/// Block type for insert_header in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlockInsertHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insert_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for block in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "block";

    /// <summary>
    /// CustomResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlock>? CustomResponse
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlock>>("custom_response");
        set => SetArgument("custom_response", value);
    }

}

/// <summary>
/// Block type for custom_response in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_response";

    /// <summary>
    /// The custom_response_body_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomResponseBodyKey
    {
        get => new TerraformReference<string>(this, "custom_response_body_key");
        set => SetArgument("custom_response_body_key", value);
    }

    /// <summary>
    /// The response_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseCode is required")]
    public required TerraformValue<double> ResponseCode
    {
        get => new TerraformReference<double>(this, "response_code");
        set => SetArgument("response_code", value);
    }

    /// <summary>
    /// ResponseHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlockResponseHeaderBlock>? ResponseHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlockResponseHeaderBlock>>("response_header");
        set => SetArgument("response_header", value);
    }

}

/// <summary>
/// Block type for response_header in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlockResponseHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for captcha in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "captcha";

    /// <summary>
    /// CustomRequestHandling block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlock>? CustomRequestHandling
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlock>>("custom_request_handling");
        set => SetArgument("custom_request_handling", value);
    }

}

/// <summary>
/// Block type for custom_request_handling in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_request_handling";

    /// <summary>
    /// InsertHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlockInsertHeaderBlock>? InsertHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlockInsertHeaderBlock>>("insert_header");
        set => SetArgument("insert_header", value);
    }

}

/// <summary>
/// Block type for insert_header in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlockInsertHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insert_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for challenge in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "challenge";

    /// <summary>
    /// CustomRequestHandling block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlock>? CustomRequestHandling
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlock>>("custom_request_handling");
        set => SetArgument("custom_request_handling", value);
    }

}

/// <summary>
/// Block type for custom_request_handling in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_request_handling";

    /// <summary>
    /// InsertHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlockInsertHeaderBlock>? InsertHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlockInsertHeaderBlock>>("insert_header");
        set => SetArgument("insert_header", value);
    }

}

/// <summary>
/// Block type for insert_header in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlockInsertHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insert_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for count in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "count";

    /// <summary>
    /// CustomRequestHandling block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlock>? CustomRequestHandling
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlock>>("custom_request_handling");
        set => SetArgument("custom_request_handling", value);
    }

}

/// <summary>
/// Block type for custom_request_handling in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_request_handling";

    /// <summary>
    /// InsertHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlockInsertHeaderBlock>? InsertHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlockInsertHeaderBlock>>("insert_header");
        set => SetArgument("insert_header", value);
    }

}

/// <summary>
/// Block type for insert_header in AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlockInsertHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insert_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for rule_group_reference in AwsWafv2WebAclRuleGroupAssociation.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_group_reference";

    /// <summary>
    /// ARN of the Rule Group to associate with the Web ACL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// RuleActionOverride block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlock>? RuleActionOverride
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlock>>("rule_action_override");
        set => SetArgument("rule_action_override", value);
    }

}

/// <summary>
/// Block type for rule_action_override in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_action_override";

    /// <summary>
    /// Name of the rule to override.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// ActionToUse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlock>? ActionToUse
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlock>>("action_to_use");
        set => SetArgument("action_to_use", value);
    }

}

/// <summary>
/// Block type for action_to_use in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_to_use";

    /// <summary>
    /// Allow block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlock>? Allow
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlock>>("allow");
        set => SetArgument("allow", value);
    }

    /// <summary>
    /// Block block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlock>? Block
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlock>>("block");
        set => SetArgument("block", value);
    }

    /// <summary>
    /// Captcha block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlock>? Captcha
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlock>>("captcha");
        set => SetArgument("captcha", value);
    }

    /// <summary>
    /// Challenge block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlock>? Challenge
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlock>>("challenge");
        set => SetArgument("challenge", value);
    }

    /// <summary>
    /// CountAttribute block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlock>? CountAttribute
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlock>>("count");
        set => SetArgument("count", value);
    }

}

/// <summary>
/// Block type for allow in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allow";

    /// <summary>
    /// CustomRequestHandling block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlock>? CustomRequestHandling
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlock>>("custom_request_handling");
        set => SetArgument("custom_request_handling", value);
    }

}

/// <summary>
/// Block type for custom_request_handling in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_request_handling";

    /// <summary>
    /// InsertHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlockInsertHeaderBlock>? InsertHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlockInsertHeaderBlock>>("insert_header");
        set => SetArgument("insert_header", value);
    }

}

/// <summary>
/// Block type for insert_header in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockAllowBlockCustomRequestHandlingBlockInsertHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insert_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for block in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "block";

    /// <summary>
    /// CustomResponse block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlock>? CustomResponse
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlock>>("custom_response");
        set => SetArgument("custom_response", value);
    }

}

/// <summary>
/// Block type for custom_response in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_response";

    /// <summary>
    /// The custom_response_body_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomResponseBodyKey
    {
        get => new TerraformReference<string>(this, "custom_response_body_key");
        set => SetArgument("custom_response_body_key", value);
    }

    /// <summary>
    /// The response_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseCode is required")]
    public required TerraformValue<double> ResponseCode
    {
        get => new TerraformReference<double>(this, "response_code");
        set => SetArgument("response_code", value);
    }

    /// <summary>
    /// ResponseHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlockResponseHeaderBlock>? ResponseHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlockResponseHeaderBlock>>("response_header");
        set => SetArgument("response_header", value);
    }

}

/// <summary>
/// Block type for response_header in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockBlockBlockCustomResponseBlockResponseHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for captcha in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "captcha";

    /// <summary>
    /// CustomRequestHandling block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlock>? CustomRequestHandling
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlock>>("custom_request_handling");
        set => SetArgument("custom_request_handling", value);
    }

}

/// <summary>
/// Block type for custom_request_handling in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_request_handling";

    /// <summary>
    /// InsertHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlockInsertHeaderBlock>? InsertHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlockInsertHeaderBlock>>("insert_header");
        set => SetArgument("insert_header", value);
    }

}

/// <summary>
/// Block type for insert_header in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCaptchaBlockCustomRequestHandlingBlockInsertHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insert_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for challenge in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "challenge";

    /// <summary>
    /// CustomRequestHandling block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlock>? CustomRequestHandling
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlock>>("custom_request_handling");
        set => SetArgument("custom_request_handling", value);
    }

}

/// <summary>
/// Block type for custom_request_handling in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_request_handling";

    /// <summary>
    /// InsertHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlockInsertHeaderBlock>? InsertHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlockInsertHeaderBlock>>("insert_header");
        set => SetArgument("insert_header", value);
    }

}

/// <summary>
/// Block type for insert_header in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockChallengeBlockCustomRequestHandlingBlockInsertHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insert_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for count in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "count";

    /// <summary>
    /// CustomRequestHandling block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlock>? CustomRequestHandling
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlock>>("custom_request_handling");
        set => SetArgument("custom_request_handling", value);
    }

}

/// <summary>
/// Block type for custom_request_handling in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_request_handling";

    /// <summary>
    /// InsertHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlockInsertHeaderBlock>? InsertHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlockInsertHeaderBlock>>("insert_header");
        set => SetArgument("insert_header", value);
    }

}

/// <summary>
/// Block type for insert_header in AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlockRuleActionOverrideBlockActionToUseBlockCountAttributeBlockCustomRequestHandlingBlockInsertHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insert_header";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsWafv2WebAclRuleGroupAssociation.
/// Nesting mode: single
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_wafv2_web_acl_rule_group_association Terraform resource.
/// Associates a WAFv2 Rule Group (custom or managed) with a Web ACL by adding a rule that references the Rule Group.
/// </summary>
public partial class AwsWafv2WebAclRuleGroupAssociation(string name) : TerraformResource("aws_wafv2_web_acl_rule_group_association", name)
{
    /// <summary>
    /// Override action for the rule group. Valid values are &#39;none&#39; and &#39;count&#39;. Defaults to &#39;none&#39;.
    /// </summary>
    public TerraformValue<string> OverrideAction
    {
        get => new TerraformReference<string>(this, "override_action");
        set => SetArgument("override_action", value);
    }

    /// <summary>
    /// Priority of the rule within the Web ACL.
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
    /// Name of the rule to create in the Web ACL that references the rule group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformValue<string> RuleName
    {
        get => new TerraformReference<string>(this, "rule_name");
        set => SetArgument("rule_name", value);
    }

    /// <summary>
    /// ARN of the Web ACL to associate the Rule Group with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAclArn is required")]
    public required TerraformValue<string> WebAclArn
    {
        get => new TerraformReference<string>(this, "web_acl_arn");
        set => SetArgument("web_acl_arn", value);
    }

    /// <summary>
    /// ManagedRuleGroup block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock>? ManagedRuleGroup
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock>>("managed_rule_group");
        set => SetArgument("managed_rule_group", value);
    }

    /// <summary>
    /// RuleGroupReference block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock>? RuleGroupReference
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock>>("rule_group_reference");
        set => SetArgument("rule_group_reference", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
