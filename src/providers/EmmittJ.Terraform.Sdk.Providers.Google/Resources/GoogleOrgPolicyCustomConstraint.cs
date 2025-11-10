using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOrgPolicyCustomConstraintTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_org_policy_custom_constraint resource.
/// </summary>
public class GoogleOrgPolicyCustomConstraint : TerraformResource
{
    public GoogleOrgPolicyCustomConstraint(string name) : base("google_org_policy_custom_constraint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("update_time");
        SetOutput("action_type");
        SetOutput("condition");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("method_types");
        SetOutput("name");
        SetOutput("parent");
        SetOutput("resource_types");
    }

    /// <summary>
    /// The action to take if the condition is met. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    public required TerraformProperty<string> ActionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action_type");
        set => SetProperty("action_type", value);
    }

    /// <summary>
    /// A CEL condition that refers to a supported service resource, for example &#39;resource.management.autoUpgrade == false&#39;. For details about CEL usage, see [Common Expression Language](https://cloud.google.com/resource-manager/docs/organization-policy/creating-managing-custom-constraints#common_expression_language).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    public required TerraformProperty<string> Condition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("condition");
        set => SetProperty("condition", value);
    }

    /// <summary>
    /// A human-friendly description of the constraint to display as an error message when the policy is violated.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// A human-friendly name for the constraint.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// A list of RESTful methods for which to enforce the constraint. Can be &#39;CREATE&#39;, &#39;UPDATE&#39;, or both. Not all Google Cloud services support both methods. To see supported methods for each service, find the service in [Supported services](https://cloud.google.com/resource-manager/docs/organization-policy/custom-constraint-supported-services).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodTypes is required")]
    public List<TerraformProperty<string>> MethodTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("method_types");
        set => SetProperty("method_types", value);
    }

    /// <summary>
    /// Immutable. The name of the custom constraint. This is unique within the organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Immutable. The fully qualified name of the Google Cloud REST resource containing the object and field you want to restrict. For example, &#39;container.googleapis.com/NodePool&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    public List<TerraformProperty<string>> ResourceTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("resource_types");
        set => SetProperty("resource_types", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOrgPolicyCustomConstraintTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The timestamp representing when the constraint was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
