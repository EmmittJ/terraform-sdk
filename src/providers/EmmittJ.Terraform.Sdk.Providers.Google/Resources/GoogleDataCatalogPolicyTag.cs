using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataCatalogPolicyTagTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_catalog_policy_tag resource.
/// </summary>
public partial class GoogleDataCatalogPolicyTag : TerraformResource
{
    public GoogleDataCatalogPolicyTag(string name) : base("google_data_catalog_policy_tag", name)
    {
    }

    /// <summary>
    /// Description of this policy tag. It must: contain only unicode characters, tabs,
    /// newlines, carriage returns and page breaks; and be at most 2000 bytes long when
    /// encoded in UTF-8. If not set, defaults to an empty description.
    /// If not set, defaults to an empty description.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User defined name of this policy tag. It must: be unique within the parent
    /// taxonomy; contain only unicode letters, numbers, underscores, dashes and spaces;
    /// not start or end with spaces; and be at most 200 bytes long when encoded in UTF-8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource name of this policy tag&#39;s parent policy tag.
    /// If empty, it means this policy tag is a top level policy tag.
    /// If not set, defaults to an empty string.
    /// </summary>
    [TerraformProperty("parent_policy_tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ParentPolicyTag { get; set; }

    /// <summary>
    /// Taxonomy the policy tag is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Taxonomy is required")]
    [TerraformProperty("taxonomy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Taxonomy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDataCatalogPolicyTagTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Resource names of child policy tags of this policy tag.
    /// </summary>
    [TerraformProperty("child_policy_tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ChildPolicyTags { get; }

    /// <summary>
    /// Resource name of this policy tag, whose format is:
    /// &amp;quot;projects/{project}/locations/{region}/taxonomies/{taxonomy}/policyTags/{policytag}&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
