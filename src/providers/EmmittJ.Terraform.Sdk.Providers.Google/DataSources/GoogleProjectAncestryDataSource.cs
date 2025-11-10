using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_ancestry.
/// </summary>
public class GoogleProjectAncestryDataSource : TerraformDataSource
{
    public GoogleProjectAncestryDataSource(string name) : base("google_project_ancestry", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The ancestors attribute.
    /// </summary>
    [TerraformPropertyName("ancestors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Ancestors => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ancestors");

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformPropertyName("org_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OrgId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "org_id");

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_id");

    /// <summary>
    /// The parent_type attribute.
    /// </summary>
    [TerraformPropertyName("parent_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_type");

}
