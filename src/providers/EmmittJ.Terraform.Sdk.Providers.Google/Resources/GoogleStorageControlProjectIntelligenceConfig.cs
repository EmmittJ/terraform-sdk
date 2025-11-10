using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlProjectIntelligenceConfigFilterBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageControlProjectIntelligenceConfigTimeoutsBlock : ITerraformBlock
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
/// Manages a google_storage_control_project_intelligence_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageControlProjectIntelligenceConfig : TerraformResource
{
    public GoogleStorageControlProjectIntelligenceConfig(string name) : base("google_storage_control_project_intelligence_config", name)
    {
    }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, TRIAL, DISABLED and STANDARD.
    /// </summary>
    [TerraformPropertyName("edition_config")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EditionConfig { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edition_config");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Identifier of the GCP project. For GCP project, this field can be project name or project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformPropertyName("filter")]
    public TerraformList<TerraformBlock<GoogleStorageControlProjectIntelligenceConfigFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageControlProjectIntelligenceConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    [TerraformPropertyName("effective_intelligence_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EffectiveIntelligenceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "effective_intelligence_config");

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    [TerraformPropertyName("trial_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrialConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "trial_config");

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
