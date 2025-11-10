using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_organization_policy.
/// </summary>
public class GoogleProjectOrganizationPolicyDataSource : TerraformDataSource
{
    public GoogleProjectOrganizationPolicyDataSource(string name) : base("google_project_organization_policy", name)
    {
    }

    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    [TerraformPropertyName("constraint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Constraint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformPropertyName("project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Project { get; set; }

    /// <summary>
    /// A boolean policy is a constraint that is either enforced or not.
    /// </summary>
    [TerraformPropertyName("boolean_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BooleanPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "boolean_policy");

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// A policy that can define specific values that are allowed or denied for the given constraint. It can also be used to allow or deny all values. 
    /// </summary>
    [TerraformPropertyName("list_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ListPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "list_policy");

    /// <summary>
    /// A restore policy is a constraint to restore the default policy.
    /// </summary>
    [TerraformPropertyName("restore_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RestorePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "restore_policy");

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Version => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "version");

}
