using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleOrgPolicyCustomConstraint.
/// Nesting mode: single
/// </summary>
public class GoogleOrgPolicyCustomConstraintTimeoutsBlock : TerraformBlock
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
/// Represents a google_org_policy_custom_constraint Terraform resource.
/// Manages a google_org_policy_custom_constraint resource.
/// </summary>
public partial class GoogleOrgPolicyCustomConstraint(string name) : TerraformResource("google_org_policy_custom_constraint", name)
{
    /// <summary>
    /// The action to take if the condition is met. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    public required TerraformValue<string> ActionType
    {
        get => new TerraformReference<string>(this, "action_type");
        set => SetArgument("action_type", value);
    }

    /// <summary>
    /// A CEL condition that refers to a supported service resource, for example &#39;resource.management.autoUpgrade == false&#39;. For details about CEL usage, see [Common Expression Language](https://cloud.google.com/resource-manager/docs/organization-policy/creating-managing-custom-constraints#common_expression_language).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    public required TerraformValue<string> Condition
    {
        get => new TerraformReference<string>(this, "condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// A human-friendly description of the constraint to display as an error message when the policy is violated.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A human-friendly name for the constraint.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// A list of RESTful methods for which to enforce the constraint. Can be &#39;CREATE&#39;, &#39;UPDATE&#39;, or both. Not all Google Cloud services support both methods. To see supported methods for each service, find the service in [Supported services](https://cloud.google.com/resource-manager/docs/organization-policy/custom-constraint-supported-services).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodTypes is required")]
    public TerraformList<string>? MethodTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "method_types").ResolveNodes(ctx));
        set => SetArgument("method_types", value);
    }

    /// <summary>
    /// Immutable. The name of the custom constraint. This is unique within the organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Immutable. The fully qualified name of the Google Cloud REST resource containing the object and field you want to restrict. For example, &#39;container.googleapis.com/NodePool&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// Output only. The timestamp representing when the constraint was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOrgPolicyCustomConstraintTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOrgPolicyCustomConstraintTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
