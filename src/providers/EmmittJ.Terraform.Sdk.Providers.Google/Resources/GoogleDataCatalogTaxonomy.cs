using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataCatalogTaxonomyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_catalog_taxonomy resource.
/// </summary>
public partial class GoogleDataCatalogTaxonomy : TerraformResource
{
    public GoogleDataCatalogTaxonomy(string name) : base("google_data_catalog_taxonomy", name)
    {
    }

    /// <summary>
    /// A list of policy types that are activated for this taxonomy. If not set,
    /// defaults to an empty list. Possible values: [&amp;quot;POLICY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;FINE_GRAINED_ACCESS_CONTROL&amp;quot;]
    /// </summary>
    [TerraformProperty("activated_policy_types")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ActivatedPolicyTypes { get; set; }

    /// <summary>
    /// Description of this taxonomy. It must: contain only unicode characters,
    /// tabs, newlines, carriage returns and page breaks; and be at most 2000 bytes
    /// long when encoded in UTF-8. If not set, defaults to an empty description.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User defined name of this taxonomy.
    /// The taxonomy display name must be unique within an organization.
    /// It must: contain only unicode letters, numbers, underscores, dashes
    /// and spaces; not start or end with spaces; and be at most 200 bytes
    /// long when encoded in UTF-8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Taxonomy location region.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataCatalogTaxonomyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Resource name of this taxonomy, whose format is:
    /// &amp;quot;projects/{project}/locations/{region}/taxonomies/{taxonomy}&amp;quot;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
