using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in GoogleIamDenyPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleIamDenyPolicyRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// The description of the rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// DenyRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DenyRule block(s) allowed")]
    public TerraformList<GoogleIamDenyPolicyRulesBlockDenyRuleBlock>? DenyRule
    {
        get => GetArgument<TerraformList<GoogleIamDenyPolicyRulesBlockDenyRuleBlock>>("deny_rule");
        set => SetArgument("deny_rule", value);
    }

}

/// <summary>
/// Block type for deny_rule in GoogleIamDenyPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamDenyPolicyRulesBlockDenyRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deny_rule";

    /// <summary>
    /// The permissions that are explicitly denied by this rule. Each permission uses the format &#39;{service-fqdn}/{resource}.{verb}&#39;,
    /// where &#39;{service-fqdn}&#39; is the fully qualified domain name for the service. For example, &#39;iam.googleapis.com/roles.list&#39;.
    /// </summary>
    public TerraformList<string>? DeniedPermissions
    {
        get => GetArgument<TerraformList<string>>("denied_permissions");
        set => SetArgument("denied_permissions", value);
    }

    /// <summary>
    /// The identities that are prevented from using one or more permissions on Google Cloud resources.
    /// </summary>
    public TerraformList<string>? DeniedPrincipals
    {
        get => GetArgument<TerraformList<string>>("denied_principals");
        set => SetArgument("denied_principals", value);
    }

    /// <summary>
    /// Specifies the permissions that this rule excludes from the set of denied permissions given by deniedPermissions.
    /// If a permission appears in deniedPermissions and in exceptionPermissions then it will not be denied.
    /// The excluded permissions can be specified using the same syntax as deniedPermissions.
    /// </summary>
    public TerraformList<string>? ExceptionPermissions
    {
        get => GetArgument<TerraformList<string>>("exception_permissions");
        set => SetArgument("exception_permissions", value);
    }

    /// <summary>
    /// The identities that are excluded from the deny rule, even if they are listed in the deniedPrincipals.
    /// For example, you could add a Google group to the deniedPrincipals, then exclude specific users who belong to that group.
    /// </summary>
    public TerraformList<string>? ExceptionPrincipals
    {
        get => GetArgument<TerraformList<string>>("exception_principals");
        set => SetArgument("exception_principals", value);
    }

    /// <summary>
    /// DenialCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DenialCondition block(s) allowed")]
    public TerraformList<GoogleIamDenyPolicyRulesBlockDenyRuleBlockDenialConditionBlock>? DenialCondition
    {
        get => GetArgument<TerraformList<GoogleIamDenyPolicyRulesBlockDenyRuleBlockDenialConditionBlock>>("denial_condition");
        set => SetArgument("denial_condition", value);
    }

}

/// <summary>
/// Block type for denial_condition in GoogleIamDenyPolicyRulesBlockDenyRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamDenyPolicyRulesBlockDenyRuleBlockDenialConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "denial_condition";

    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression,
    /// e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting,
    /// e.g. a file name and a position in the file.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIamDenyPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleIamDenyPolicyTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_iam_deny_policy Terraform resource.
/// Manages a google_iam_deny_policy resource.
/// </summary>
public partial class GoogleIamDenyPolicy(string name) : TerraformResource("google_iam_deny_policy", name)
{
    /// <summary>
    /// The display name of the rule.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The attachment point is identified by its URL-encoded full resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The hash of the resource. Used internally during updates.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleIamDenyPolicyRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleIamDenyPolicyRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIamDenyPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIamDenyPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
