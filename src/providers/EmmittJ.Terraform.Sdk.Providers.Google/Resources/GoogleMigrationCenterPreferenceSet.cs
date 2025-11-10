using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMigrationCenterPreferenceSetTimeoutsBlock : ITerraformBlock
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
/// Block type for virtual_machine_preferences in .
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock : ITerraformBlock
{
    /// <summary>
    /// Commitment plan to consider when calculating costs for virtual machine insights and recommendations. If you are unsure which value to set, a 3 year commitment plan is often a good value to start with. Possible values: &#39;COMMITMENT_PLAN_UNSPECIFIED&#39;, &#39;COMMITMENT_PLAN_NONE&#39;, &#39;COMMITMENT_PLAN_ONE_YEAR&#39;, &#39;COMMITMENT_PLAN_THREE_YEARS&#39;
    /// </summary>
    [TerraformPropertyName("commitment_plan")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CommitmentPlan { get; set; }

    /// <summary>
    /// Sizing optimization strategy specifies the preferred strategy used when extrapolating usage data to calculate insights and recommendations for a virtual machine. If you are unsure which value to set, a moderate sizing optimization strategy is often a good value to start with. Possible values: &#39;SIZING_OPTIMIZATION_STRATEGY_UNSPECIFIED&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_SAME_AS_SOURCE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_MODERATE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_AGGRESSIVE&#39;
    /// </summary>
    [TerraformPropertyName("sizing_optimization_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SizingOptimizationStrategy { get; set; }

    /// <summary>
    /// Target product for assets using this preference set. Specify either target product or business goal, but not both. Possible values: &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_UNSPECIFIED&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_COMPUTE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_VMWARE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_SOLE_TENANCY&#39;
    /// </summary>
    [TerraformPropertyName("target_product")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetProduct { get; set; }

}

/// <summary>
/// Manages a google_migration_center_preference_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMigrationCenterPreferenceSet : TerraformResource
{
    public GoogleMigrationCenterPreferenceSet(string name) : base("google_migration_center_preference_set", name)
    {
    }

    /// <summary>
    /// A description of the preference set.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// User-friendly display name. Maximum length is 63 characters.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Required. User specified ID for the preference set. It will become the last component of the preference set name. The ID must be unique within the project, must conform with RFC-1034, is restricted to lower-cased letters, and has a maximum length of 63 characters. The ID must match the regular expression &#39;[a-z]([a-z0-9-]{0,61}[a-z0-9])?&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferenceSetId is required")]
    [TerraformPropertyName("preference_set_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PreferenceSetId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleMigrationCenterPreferenceSetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_machine_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachinePreferences block(s) allowed")]
    [TerraformPropertyName("virtual_machine_preferences")]
    public TerraformList<TerraformBlock<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock>>? VirtualMachinePreferences { get; set; } = new();

    /// <summary>
    /// Output only. The timestamp when the preference set was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Output only. Name of the preference set.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. The timestamp when the preference set was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
