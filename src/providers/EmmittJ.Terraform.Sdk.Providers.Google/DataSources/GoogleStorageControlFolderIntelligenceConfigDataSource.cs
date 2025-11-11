using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_control_folder_intelligence_config.
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigDataSource : TerraformDataSource
{
    public GoogleStorageControlFolderIntelligenceConfigDataSource(string name) : base("google_storage_control_folder_intelligence_config", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Identifier of the GCP Folder. For GCP Folder, this field can be folder number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, TRIAL, DISABLED and STANDARD.
    /// </summary>
    [TerraformPropertyName("edition_config")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EditionConfig => new TerraformReference(this, "edition_config");

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    [TerraformPropertyName("effective_intelligence_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EffectiveIntelligenceConfig => new TerraformReference(this, "effective_intelligence_config");

    /// <summary>
    /// Filter over location and bucket using include or exclude semantics. Resources that match the include or exclude filter are exclusively included or excluded from the Storage Intelligence plan.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Filter => new TerraformReference(this, "filter");

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    [TerraformPropertyName("trial_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrialConfig => new TerraformReference(this, "trial_config");

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
