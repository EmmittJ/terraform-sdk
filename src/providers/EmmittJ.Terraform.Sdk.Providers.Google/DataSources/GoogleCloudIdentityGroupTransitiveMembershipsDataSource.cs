using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_identity_group_transitive_memberships.
/// </summary>
public class GoogleCloudIdentityGroupTransitiveMembershipsDataSource : TerraformDataSource
{
    public GoogleCloudIdentityGroupTransitiveMembershipsDataSource(string name) : base("google_cloud_identity_group_transitive_memberships", name)
    {
    }

    /// <summary>
    /// The name of the Group to get memberships from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    [TerraformPropertyName("group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// List of Cloud Identity group memberships.
    /// </summary>
    [TerraformPropertyName("memberships")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Memberships => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "memberships");

}
