using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_control_organization_intelligence_config.
/// </summary>
public partial class GoogleStorageControlOrganizationIntelligenceConfigDataSource : TerraformDataSource
{
    public GoogleStorageControlOrganizationIntelligenceConfigDataSource(string name) : base("google_storage_control_organization_intelligence_config", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Identifier of the GCP Organization. For GCP org, this field should be organization number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, DISABLED, TRIAL and STANDARD.
    /// </summary>
    [TerraformProperty("edition_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EditionConfig { get; }

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    [TerraformProperty("effective_intelligence_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EffectiveIntelligenceConfig { get; }

    /// <summary>
    /// Filter over location and bucket using include or exclude semantics. Resources that match the include or exclude filter are exclusively included or excluded from the Storage Intelligence plan.
    /// </summary>
    [TerraformProperty("filter")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Filter { get; }

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    [TerraformProperty("trial_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TrialConfig { get; }

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
