using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_ancestry.
/// </summary>
public partial class GoogleProjectAncestryDataSource : TerraformDataSource
{
    public GoogleProjectAncestryDataSource(string name) : base("google_project_ancestry", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The ancestors attribute.
    /// </summary>
    [TerraformProperty("ancestors")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Ancestors { get; }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformProperty("org_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OrgId { get; }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [TerraformProperty("parent_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ParentId { get; }

    /// <summary>
    /// The parent_type attribute.
    /// </summary>
    [TerraformProperty("parent_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ParentType { get; }

}
