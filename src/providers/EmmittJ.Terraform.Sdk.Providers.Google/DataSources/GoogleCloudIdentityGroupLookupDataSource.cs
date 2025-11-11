using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for group_key in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The ID of the entity. For Google-managed entities, the id should be the email address of an existing group or user.
    /// For external-identity-mapped entities, the id must be a string conforming to the Identity Source&#39;s requirements.
    /// Must be unique within a namespace.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The namespace in which the entity exists. If not specified, the EntityKey represents a Google-managed entity such as a Google user or a Google Group.
    /// If specified, the EntityKey represents an external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console and must be in the form of identitysources/{identity_source}.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Namespace { get; set; }

}

/// <summary>
/// Retrieves information about a google_cloud_identity_group_lookup.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudIdentityGroupLookupDataSource : TerraformDataSource
{
    public GoogleCloudIdentityGroupLookupDataSource(string name) : base("google_cloud_identity_group_lookup", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for group_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GroupKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupKey block(s) allowed")]
    [TerraformProperty("group_key")]
    public partial TerraformList<TerraformBlock<GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock>>? GroupKey { get; set; }

    /// <summary>
    /// The [resource name](https://cloud.google.com/apis/design/resource_names) of the looked-up Group.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
