using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleOrgPolicyCustomConstraintTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_org_policy_custom_constraint resource.
/// </summary>
public partial class GoogleOrgPolicyCustomConstraint : TerraformResource
{
    public GoogleOrgPolicyCustomConstraint(string name) : base("google_org_policy_custom_constraint", name)
    {
    }

    /// <summary>
    /// The action to take if the condition is met. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    [TerraformProperty("action_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ActionType { get; set; }

    /// <summary>
    /// A CEL condition that refers to a supported service resource, for example &#39;resource.management.autoUpgrade == false&#39;. For details about CEL usage, see [Common Expression Language](https://cloud.google.com/resource-manager/docs/organization-policy/creating-managing-custom-constraints#common_expression_language).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    [TerraformProperty("condition")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Condition { get; set; }

    /// <summary>
    /// A human-friendly description of the constraint to display as an error message when the policy is violated.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A human-friendly name for the constraint.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A list of RESTful methods for which to enforce the constraint. Can be &#39;CREATE&#39;, &#39;UPDATE&#39;, or both. Not all Google Cloud services support both methods. To see supported methods for each service, find the service in [Supported services](https://cloud.google.com/resource-manager/docs/organization-policy/custom-constraint-supported-services).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodTypes is required")]
    [TerraformProperty("method_types")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? MethodTypes { get; set; }

    /// <summary>
    /// Immutable. The name of the custom constraint. This is unique within the organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Immutable. The fully qualified name of the Google Cloud REST resource containing the object and field you want to restrict. For example, &#39;container.googleapis.com/NodePool&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    [TerraformProperty("resource_types")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? ResourceTypes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleOrgPolicyCustomConstraintTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The timestamp representing when the constraint was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
