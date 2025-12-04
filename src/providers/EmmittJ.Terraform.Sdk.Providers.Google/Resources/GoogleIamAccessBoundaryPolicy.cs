using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in GoogleIamAccessBoundaryPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleIamAccessBoundaryPolicyRulesBlock : TerraformBlock
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
    /// AccessBoundaryRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessBoundaryRule block(s) allowed")]
    public TerraformList<GoogleIamAccessBoundaryPolicyRulesBlockAccessBoundaryRuleBlock>? AccessBoundaryRule
    {
        get => GetArgument<TerraformList<GoogleIamAccessBoundaryPolicyRulesBlockAccessBoundaryRuleBlock>>("access_boundary_rule");
        set => SetArgument("access_boundary_rule", value);
    }

}

/// <summary>
/// Block type for access_boundary_rule in GoogleIamAccessBoundaryPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamAccessBoundaryPolicyRulesBlockAccessBoundaryRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_boundary_rule";

    /// <summary>
    /// A list of permissions that may be allowed for use on the specified resource.
    /// </summary>
    public TerraformList<string>? AvailablePermissions
    {
        get => GetArgument<TerraformList<string>>("available_permissions");
        set => SetArgument("available_permissions", value);
    }

    /// <summary>
    /// The full resource name of a Google Cloud resource entity.
    /// </summary>
    public TerraformValue<string>? AvailableResource
    {
        get => GetArgument<TerraformValue<string>>("available_resource");
        set => SetArgument("available_resource", value);
    }

    /// <summary>
    /// AvailabilityCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvailabilityCondition block(s) allowed")]
    public TerraformList<GoogleIamAccessBoundaryPolicyRulesBlockAccessBoundaryRuleBlockAvailabilityConditionBlock>? AvailabilityCondition
    {
        get => GetArgument<TerraformList<GoogleIamAccessBoundaryPolicyRulesBlockAccessBoundaryRuleBlockAvailabilityConditionBlock>>("availability_condition");
        set => SetArgument("availability_condition", value);
    }

}

/// <summary>
/// Block type for availability_condition in GoogleIamAccessBoundaryPolicyRulesBlockAccessBoundaryRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamAccessBoundaryPolicyRulesBlockAccessBoundaryRuleBlockAvailabilityConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "availability_condition";

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
/// Block type for timeouts in GoogleIamAccessBoundaryPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleIamAccessBoundaryPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_iam_access_boundary_policy Terraform resource.
/// Manages a google_iam_access_boundary_policy resource.
/// </summary>
public partial class GoogleIamAccessBoundaryPolicy(string name) : TerraformResource("google_iam_access_boundary_policy", name)
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
    public required TerraformList<GoogleIamAccessBoundaryPolicyRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleIamAccessBoundaryPolicyRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIamAccessBoundaryPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIamAccessBoundaryPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
