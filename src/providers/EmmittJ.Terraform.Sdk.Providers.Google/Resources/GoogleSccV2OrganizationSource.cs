using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSccV2OrganizationSourceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_scc_v2_organization_source resource.
/// </summary>
public partial class GoogleSccV2OrganizationSource : TerraformResource
{
    public GoogleSccV2OrganizationSource(string name) : base("google_scc_v2_organization_source", name)
    {
    }

    /// <summary>
    /// The description of the source (max of 1024 characters).
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The source’s display name. A source’s display name must be unique
    /// amongst its siblings, for example, two sources with the same parent
    /// can&#39;t share the same display name. The display name must start and end
    /// with a letter or digit, may contain letters, digits, spaces, hyphens,
    /// and underscores, and can be no longer than 32 characters.
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
    /// The organization whose Cloud Security Command Center the Source
    /// lives in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformProperty("organization")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Organization { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleSccV2OrganizationSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The resource name of this source, in the format
    /// &#39;organizations/{{organization}}/sources/{{source}}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
