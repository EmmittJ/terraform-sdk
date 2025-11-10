using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogPolicyTagTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_catalog_policy_tag resource.
/// </summary>
public class GoogleDataCatalogPolicyTag : TerraformResource
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
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// User defined name of this policy tag. It must: be unique within the parent
    /// taxonomy; contain only unicode letters, numbers, underscores, dashes and spaces;
    /// not start or end with spaces; and be at most 200 bytes long when encoded in UTF-8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource name of this policy tag&#39;s parent policy tag.
    /// If empty, it means this policy tag is a top level policy tag.
    /// If not set, defaults to an empty string.
    /// </summary>
    [TerraformPropertyName("parent_policy_tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ParentPolicyTag { get; set; }

    /// <summary>
    /// Taxonomy the policy tag is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Taxonomy is required")]
    [TerraformPropertyName("taxonomy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Taxonomy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataCatalogPolicyTagTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Resource names of child policy tags of this policy tag.
    /// </summary>
    [TerraformPropertyName("child_policy_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ChildPolicyTags => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "child_policy_tags");

    /// <summary>
    /// Resource name of this policy tag, whose format is:
    /// &amp;quot;projects/{project}/locations/{region}/taxonomies/{taxonomy}/policyTags/{policytag}&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
