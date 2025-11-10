using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMigrationCenterPreferenceSetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for virtual_machine_preferences in .
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Commitment plan to consider when calculating costs for virtual machine insights and recommendations. If you are unsure which value to set, a 3 year commitment plan is often a good value to start with. Possible values: &#39;COMMITMENT_PLAN_UNSPECIFIED&#39;, &#39;COMMITMENT_PLAN_NONE&#39;, &#39;COMMITMENT_PLAN_ONE_YEAR&#39;, &#39;COMMITMENT_PLAN_THREE_YEARS&#39;
    /// </summary>
    public TerraformProperty<string>? CommitmentPlan
    {
        set => SetProperty("commitment_plan", value);
    }

    /// <summary>
    /// Sizing optimization strategy specifies the preferred strategy used when extrapolating usage data to calculate insights and recommendations for a virtual machine. If you are unsure which value to set, a moderate sizing optimization strategy is often a good value to start with. Possible values: &#39;SIZING_OPTIMIZATION_STRATEGY_UNSPECIFIED&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_SAME_AS_SOURCE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_MODERATE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_AGGRESSIVE&#39;
    /// </summary>
    public TerraformProperty<string>? SizingOptimizationStrategy
    {
        set => SetProperty("sizing_optimization_strategy", value);
    }

    /// <summary>
    /// Target product for assets using this preference set. Specify either target product or business goal, but not both. Possible values: &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_UNSPECIFIED&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_COMPUTE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_VMWARE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_SOLE_TENANCY&#39;
    /// </summary>
    public TerraformProperty<string>? TargetProduct
    {
        set => SetProperty("target_product", value);
    }

}

/// <summary>
/// Manages a google_migration_center_preference_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMigrationCenterPreferenceSet : TerraformResource
{
    public GoogleMigrationCenterPreferenceSet(string name) : base("google_migration_center_preference_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("preference_set_id");
        SetOutput("project");
    }

    /// <summary>
    /// A description of the preference set.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// User-friendly display name. Maximum length is 63 characters.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Required. User specified ID for the preference set. It will become the last component of the preference set name. The ID must be unique within the project, must conform with RFC-1034, is restricted to lower-cased letters, and has a maximum length of 63 characters. The ID must match the regular expression &#39;[a-z]([a-z0-9-]{0,61}[a-z0-9])?&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferenceSetId is required")]
    public required TerraformProperty<string> PreferenceSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preference_set_id");
        set => SetProperty("preference_set_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMigrationCenterPreferenceSetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_machine_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachinePreferences block(s) allowed")]
    public List<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock>? VirtualMachinePreferences
    {
        set => SetProperty("virtual_machine_preferences", value);
    }

    /// <summary>
    /// Output only. The timestamp when the preference set was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. Name of the preference set.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The timestamp when the preference set was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
