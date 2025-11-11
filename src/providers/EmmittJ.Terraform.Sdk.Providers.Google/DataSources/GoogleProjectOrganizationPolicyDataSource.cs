using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_organization_policy.
/// </summary>
public partial class GoogleProjectOrganizationPolicyDataSource : TerraformDataSource
{
    public GoogleProjectOrganizationPolicyDataSource(string name) : base("google_project_organization_policy", name)
    {
    }

    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    [TerraformProperty("constraint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Constraint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// A boolean policy is a constraint that is either enforced or not.
    /// </summary>
    [TerraformProperty("boolean_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BooleanPolicy { get; }

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// A policy that can define specific values that are allowed or denied for the given constraint. It can also be used to allow or deny all values. 
    /// </summary>
    [TerraformProperty("list_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ListPolicy { get; }

    /// <summary>
    /// A restore policy is a constraint to restore the default policy.
    /// </summary>
    [TerraformProperty("restore_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RestorePolicy { get; }

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Version { get; }

}
