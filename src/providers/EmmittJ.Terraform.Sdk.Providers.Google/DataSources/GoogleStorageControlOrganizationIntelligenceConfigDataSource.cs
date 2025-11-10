using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_control_organization_intelligence_config.
/// </summary>
public class GoogleStorageControlOrganizationIntelligenceConfigDataSource : TerraformDataSource
{
    public GoogleStorageControlOrganizationIntelligenceConfigDataSource(string name) : base("google_storage_control_organization_intelligence_config", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Identifier of the GCP Organization. For GCP org, this field should be organization number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, DISABLED, TRIAL and STANDARD.
    /// </summary>
    [TerraformPropertyName("edition_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EditionConfig => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edition_config");

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    [TerraformPropertyName("effective_intelligence_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EffectiveIntelligenceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "effective_intelligence_config");

    /// <summary>
    /// Filter over location and bucket using include or exclude semantics. Resources that match the include or exclude filter are exclusively included or excluded from the Storage Intelligence plan.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Filter => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "filter");

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
