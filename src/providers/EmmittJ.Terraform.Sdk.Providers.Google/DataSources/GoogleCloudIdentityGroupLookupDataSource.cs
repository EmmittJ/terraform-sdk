using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for group_key in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock
{
    /// <summary>
    /// The ID of the entity. For Google-managed entities, the id should be the email address of an existing group or user.
    /// For external-identity-mapped entities, the id must be a string conforming to the Identity Source&#39;s requirements.
    /// Must be unique within a namespace.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The namespace in which the entity exists. If not specified, the EntityKey represents a Google-managed entity such as a Google user or a Google Group.
    /// If specified, the EntityKey represents an external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console and must be in the form of identitysources/{identity_source}.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Namespace { get; set; }

}

/// <summary>
/// Retrieves information about a google_cloud_identity_group_lookup.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudIdentityGroupLookupDataSource : TerraformDataSource
{
    public GoogleCloudIdentityGroupLookupDataSource(string name) : base("google_cloud_identity_group_lookup", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for group_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GroupKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupKey block(s) allowed")]
    [TerraformPropertyName("group_key")]
    public TerraformList<TerraformBlock<GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock>>? GroupKey { get; set; }

    /// <summary>
    /// The [resource name](https://cloud.google.com/apis/design/resource_names) of the looked-up Group.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
