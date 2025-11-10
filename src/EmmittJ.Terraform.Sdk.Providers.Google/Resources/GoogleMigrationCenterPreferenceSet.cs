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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetProperty<TerraformProperty<string>>("commitment_plan");
        set => WithProperty("commitment_plan", value);
    }

    /// <summary>
    /// Sizing optimization strategy specifies the preferred strategy used when extrapolating usage data to calculate insights and recommendations for a virtual machine. If you are unsure which value to set, a moderate sizing optimization strategy is often a good value to start with. Possible values: &#39;SIZING_OPTIMIZATION_STRATEGY_UNSPECIFIED&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_SAME_AS_SOURCE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_MODERATE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_AGGRESSIVE&#39;
    /// </summary>
    public TerraformProperty<string>? SizingOptimizationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("sizing_optimization_strategy");
        set => WithProperty("sizing_optimization_strategy", value);
    }

    /// <summary>
    /// Target product for assets using this preference set. Specify either target product or business goal, but not both. Possible values: &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_UNSPECIFIED&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_COMPUTE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_VMWARE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_SOLE_TENANCY&#39;
    /// </summary>
    public TerraformProperty<string>? TargetProduct
    {
        get => GetProperty<TerraformProperty<string>>("target_product");
        set => WithProperty("target_product", value);
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
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// A description of the preference set.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// User-friendly display name. Maximum length is 63 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Required. User specified ID for the preference set. It will become the last component of the preference set name. The ID must be unique within the project, must conform with RFC-1034, is restricted to lower-cased letters, and has a maximum length of 63 characters. The ID must match the regular expression &#39;[a-z]([a-z0-9-]{0,61}[a-z0-9])?&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferenceSetId is required")]
    public required TerraformProperty<string> PreferenceSetId
    {
        get => GetProperty<TerraformProperty<string>>("preference_set_id");
        set => this.WithProperty("preference_set_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMigrationCenterPreferenceSetTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleMigrationCenterPreferenceSetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_machine_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachinePreferences block(s) allowed")]
    public List<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock>? VirtualMachinePreferences
    {
        get => GetProperty<List<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock>>("virtual_machine_preferences");
        set => this.WithProperty("virtual_machine_preferences", value);
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
