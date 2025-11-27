using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in GoogleIapWebForwardingRuleServiceIamMember.
/// Nesting mode: list
/// </summary>
public class GoogleIapWebForwardingRuleServiceIamMemberConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Represents a google_iap_web_forwarding_rule_service_iam_member Terraform resource.
/// Manages a google_iap_web_forwarding_rule_service_iam_member resource.
/// </summary>
public partial class GoogleIapWebForwardingRuleServiceIamMember(string name) : TerraformResource("google_iap_web_forwarding_rule_service_iam_member", name)
{
    /// <summary>
    /// The forwarding_rule_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRuleServiceName is required")]
    public required TerraformValue<string> ForwardingRuleServiceName
    {
        get => new TerraformReference<string>(this, "forwarding_rule_service_name");
        set => SetArgument("forwarding_rule_service_name", value);
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
    /// The member attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Member is required")]
    public required TerraformValue<string> Member
    {
        get => new TerraformReference<string>(this, "member");
        set => SetArgument("member", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleIapWebForwardingRuleServiceIamMemberConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleIapWebForwardingRuleServiceIamMemberConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}
