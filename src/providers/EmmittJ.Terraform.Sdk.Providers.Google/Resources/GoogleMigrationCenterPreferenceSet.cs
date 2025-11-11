using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleMigrationCenterPreferenceSetTimeoutsBlock : TerraformBlockBase
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
/// Block type for virtual_machine_preferences in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock : TerraformBlockBase
{
    /// <summary>
    /// Commitment plan to consider when calculating costs for virtual machine insights and recommendations. If you are unsure which value to set, a 3 year commitment plan is often a good value to start with. Possible values: &#39;COMMITMENT_PLAN_UNSPECIFIED&#39;, &#39;COMMITMENT_PLAN_NONE&#39;, &#39;COMMITMENT_PLAN_ONE_YEAR&#39;, &#39;COMMITMENT_PLAN_THREE_YEARS&#39;
    /// </summary>
    [TerraformProperty("commitment_plan")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CommitmentPlan { get; set; }

    /// <summary>
    /// Sizing optimization strategy specifies the preferred strategy used when extrapolating usage data to calculate insights and recommendations for a virtual machine. If you are unsure which value to set, a moderate sizing optimization strategy is often a good value to start with. Possible values: &#39;SIZING_OPTIMIZATION_STRATEGY_UNSPECIFIED&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_SAME_AS_SOURCE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_MODERATE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_AGGRESSIVE&#39;
    /// </summary>
    [TerraformProperty("sizing_optimization_strategy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SizingOptimizationStrategy { get; set; }

    /// <summary>
    /// Target product for assets using this preference set. Specify either target product or business goal, but not both. Possible values: &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_UNSPECIFIED&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_COMPUTE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_VMWARE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_SOLE_TENANCY&#39;
    /// </summary>
    [TerraformProperty("target_product")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetProduct { get; set; }

}

/// <summary>
/// Manages a google_migration_center_preference_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleMigrationCenterPreferenceSet : TerraformResource
{
    public GoogleMigrationCenterPreferenceSet(string name) : base("google_migration_center_preference_set", name)
    {
    }

    /// <summary>
    /// A description of the preference set.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User-friendly display name. Maximum length is 63 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Required. User specified ID for the preference set. It will become the last component of the preference set name. The ID must be unique within the project, must conform with RFC-1034, is restricted to lower-cased letters, and has a maximum length of 63 characters. The ID must match the regular expression &#39;[a-z]([a-z0-9-]{0,61}[a-z0-9])?&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferenceSetId is required")]
    [TerraformProperty("preference_set_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PreferenceSetId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleMigrationCenterPreferenceSetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for virtual_machine_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachinePreferences block(s) allowed")]
    [TerraformProperty("virtual_machine_preferences")]
    public TerraformList<TerraformBlock<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock>>? VirtualMachinePreferences { get; set; }

    /// <summary>
    /// Output only. The timestamp when the preference set was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. Name of the preference set.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The timestamp when the preference set was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
