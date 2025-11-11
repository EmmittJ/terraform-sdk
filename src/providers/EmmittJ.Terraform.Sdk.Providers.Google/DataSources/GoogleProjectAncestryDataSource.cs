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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The ancestors attribute.
    /// </summary>
    [TerraformPropertyName("ancestors")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Ancestors => new TerraformReference(this, "ancestors");

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformPropertyName("org_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OrgId => new TerraformReference(this, "org_id");

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParentId => new TerraformReference(this, "parent_id");

    /// <summary>
    /// The parent_type attribute.
    /// </summary>
    [TerraformPropertyName("parent_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParentType => new TerraformReference(this, "parent_type");

}
