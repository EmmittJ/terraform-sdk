using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageControlOrganizationIntelligenceConfigFilterBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleStorageControlOrganizationIntelligenceConfigTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_storage_control_organization_intelligence_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleStorageControlOrganizationIntelligenceConfig : TerraformResource
{
    public GoogleStorageControlOrganizationIntelligenceConfig(string name) : base("google_storage_control_organization_intelligence_config", name)
    {
    }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, DISABLED, TRIAL and STANDARD.
    /// </summary>
    [TerraformProperty("edition_config")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EditionConfig { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Identifier of the GCP Organization. For GCP org, this field should be organization number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformProperty("filter")]
    public TerraformList<TerraformBlock<GoogleStorageControlOrganizationIntelligenceConfigFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleStorageControlOrganizationIntelligenceConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    [TerraformProperty("effective_intelligence_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EffectiveIntelligenceConfig { get; }

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    [TerraformProperty("trial_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TrialConfig { get; }

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
