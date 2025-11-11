using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_folder_organization_policy.
/// </summary>
public class GoogleFolderOrganizationPolicyDataSource : TerraformDataSource
{
    public GoogleFolderOrganizationPolicyDataSource(string name) : base("google_folder_organization_policy", name)
    {
    }

    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    [TerraformPropertyName("constraint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Constraint { get; set; }

    /// <summary>
    /// The resource name of the folder to set the policy for. Its format is folders/{folder_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    [TerraformPropertyName("folder")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Folder { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// A boolean policy is a constraint that is either enforced or not.
    /// </summary>
    [TerraformPropertyName("boolean_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BooleanPolicy => new TerraformReference(this, "boolean_policy");

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// A policy that can define specific values that are allowed or denied for the given constraint. It can also be used to allow or deny all values. 
    /// </summary>
    [TerraformPropertyName("list_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ListPolicy => new TerraformReference(this, "list_policy");

    /// <summary>
    /// A restore policy is a constraint to restore the default policy.
    /// </summary>
    [TerraformPropertyName("restore_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RestorePolicy => new TerraformReference(this, "restore_policy");

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Version => new TerraformReference(this, "version");

}
