using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleMigrationCenterPreferenceSet.
/// Nesting mode: single
/// </summary>
public class GoogleMigrationCenterPreferenceSetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for virtual_machine_preferences in GoogleMigrationCenterPreferenceSet.
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine_preferences";

    /// <summary>
    /// Commitment plan to consider when calculating costs for virtual machine insights and recommendations. If you are unsure which value to set, a 3 year commitment plan is often a good value to start with. Possible values: &#39;COMMITMENT_PLAN_UNSPECIFIED&#39;, &#39;COMMITMENT_PLAN_NONE&#39;, &#39;COMMITMENT_PLAN_ONE_YEAR&#39;, &#39;COMMITMENT_PLAN_THREE_YEARS&#39;
    /// </summary>
    public TerraformValue<string>? CommitmentPlan
    {
        get => new TerraformReference<string>(this, "commitment_plan");
        set => SetArgument("commitment_plan", value);
    }

    /// <summary>
    /// Sizing optimization strategy specifies the preferred strategy used when extrapolating usage data to calculate insights and recommendations for a virtual machine. If you are unsure which value to set, a moderate sizing optimization strategy is often a good value to start with. Possible values: &#39;SIZING_OPTIMIZATION_STRATEGY_UNSPECIFIED&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_SAME_AS_SOURCE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_MODERATE&#39;, &#39;SIZING_OPTIMIZATION_STRATEGY_AGGRESSIVE&#39;
    /// </summary>
    public TerraformValue<string>? SizingOptimizationStrategy
    {
        get => new TerraformReference<string>(this, "sizing_optimization_strategy");
        set => SetArgument("sizing_optimization_strategy", value);
    }

    /// <summary>
    /// Target product for assets using this preference set. Specify either target product or business goal, but not both. Possible values: &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_UNSPECIFIED&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_COMPUTE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_VMWARE_ENGINE&#39;, &#39;COMPUTE_MIGRATION_TARGET_PRODUCT_SOLE_TENANCY&#39;
    /// </summary>
    public TerraformValue<string>? TargetProduct
    {
        get => new TerraformReference<string>(this, "target_product");
        set => SetArgument("target_product", value);
    }

    /// <summary>
    /// ComputeEnginePreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeEnginePreferences block(s) allowed")]
    public TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlock>? ComputeEnginePreferences
    {
        get => GetArgument<TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlock>>("compute_engine_preferences");
        set => SetArgument("compute_engine_preferences", value);
    }

    /// <summary>
    /// RegionPreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegionPreferences block(s) allowed")]
    public TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockRegionPreferencesBlock>? RegionPreferences
    {
        get => GetArgument<TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockRegionPreferencesBlock>>("region_preferences");
        set => SetArgument("region_preferences", value);
    }

    /// <summary>
    /// SoleTenancyPreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoleTenancyPreferences block(s) allowed")]
    public TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockSoleTenancyPreferencesBlock>? SoleTenancyPreferences
    {
        get => GetArgument<TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockSoleTenancyPreferencesBlock>>("sole_tenancy_preferences");
        set => SetArgument("sole_tenancy_preferences", value);
    }

    /// <summary>
    /// VmwareEnginePreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmwareEnginePreferences block(s) allowed")]
    public TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockVmwareEnginePreferencesBlock>? VmwareEnginePreferences
    {
        get => GetArgument<TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockVmwareEnginePreferencesBlock>>("vmware_engine_preferences");
        set => SetArgument("vmware_engine_preferences", value);
    }

}

/// <summary>
/// Block type for compute_engine_preferences in GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_engine_preferences";

    /// <summary>
    /// License type to consider when calculating costs for virtual machine insights and recommendations. If unspecified, costs are calculated based on the default licensing plan. Possible values: &#39;LICENSE_TYPE_UNSPECIFIED&#39;, &#39;LICENSE_TYPE_DEFAULT&#39;, &#39;LICENSE_TYPE_BRING_YOUR_OWN_LICENSE&#39;
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// MachinePreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachinePreferences block(s) allowed")]
    public TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlockMachinePreferencesBlock>? MachinePreferences
    {
        get => GetArgument<TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlockMachinePreferencesBlock>>("machine_preferences");
        set => SetArgument("machine_preferences", value);
    }

}

/// <summary>
/// Block type for machine_preferences in GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlockMachinePreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "machine_preferences";

    /// <summary>
    /// AllowedMachineSeries block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlockMachinePreferencesBlockAllowedMachineSeriesBlock>? AllowedMachineSeries
    {
        get => GetArgument<TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlockMachinePreferencesBlockAllowedMachineSeriesBlock>>("allowed_machine_series");
        set => SetArgument("allowed_machine_series", value);
    }

}

/// <summary>
/// Block type for allowed_machine_series in GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlockMachinePreferencesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockComputeEnginePreferencesBlockMachinePreferencesBlockAllowedMachineSeriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_machine_series";

    /// <summary>
    /// Code to identify a Compute Engine machine series. Consult https://cloud.google.com/compute/docs/machine-resource#machine_type_comparison for more details on the available series.
    /// </summary>
    public TerraformValue<string>? Code
    {
        get => new TerraformReference<string>(this, "code");
        set => SetArgument("code", value);
    }

}

/// <summary>
/// Block type for region_preferences in GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockRegionPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "region_preferences";

    /// <summary>
    /// A list of preferred regions, ordered by the most preferred region first. Set only valid Google Cloud region names. See https://cloud.google.com/compute/docs/regions-zones for available regions.
    /// </summary>
    public TerraformList<string>? PreferredRegions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_regions").ResolveNodes(ctx));
        set => SetArgument("preferred_regions", value);
    }

}

/// <summary>
/// Block type for sole_tenancy_preferences in GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockSoleTenancyPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sole_tenancy_preferences";

    /// <summary>
    /// Commitment plan to consider when calculating costs for virtual machine insights and recommendations. If you are unsure which value to set, a 3 year commitment plan is often a good value to start with. Possible values: &#39;COMMITMENT_PLAN_UNSPECIFIED&#39;, &#39;ON_DEMAND&#39;, &#39;COMMITMENT_1_YEAR&#39;, &#39;COMMITMENT_3_YEAR&#39;
    /// </summary>
    public TerraformValue<string>? CommitmentPlan
    {
        get => new TerraformReference<string>(this, "commitment_plan");
        set => SetArgument("commitment_plan", value);
    }

    /// <summary>
    /// CPU overcommit ratio. Acceptable values are between 1.0 and 2.0 inclusive.
    /// </summary>
    public TerraformValue<double>? CpuOvercommitRatio
    {
        get => new TerraformReference<double>(this, "cpu_overcommit_ratio");
        set => SetArgument("cpu_overcommit_ratio", value);
    }

    /// <summary>
    /// Sole Tenancy nodes maintenance policy. Possible values: &#39;HOST_MAINTENANCE_POLICY_UNSPECIFIED&#39;, &#39;HOST_MAINTENANCE_POLICY_DEFAULT&#39;, &#39;HOST_MAINTENANCE_POLICY_RESTART_IN_PLACE&#39;, &#39;HOST_MAINTENANCE_POLICY_MIGRATE_WITHIN_NODE_GROUP&#39;
    /// </summary>
    public TerraformValue<string>? HostMaintenancePolicy
    {
        get => new TerraformReference<string>(this, "host_maintenance_policy");
        set => SetArgument("host_maintenance_policy", value);
    }

    /// <summary>
    /// NodeTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockSoleTenancyPreferencesBlockNodeTypesBlock>? NodeTypes
    {
        get => GetArgument<TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockSoleTenancyPreferencesBlockNodeTypesBlock>>("node_types");
        set => SetArgument("node_types", value);
    }

}

/// <summary>
/// Block type for node_types in GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockSoleTenancyPreferencesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockSoleTenancyPreferencesBlockNodeTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_types";

    /// <summary>
    /// Name of the Sole Tenant node. Consult https://cloud.google.com/compute/docs/nodes/sole-tenant-nodes
    /// </summary>
    public TerraformValue<string>? NodeName
    {
        get => new TerraformReference<string>(this, "node_name");
        set => SetArgument("node_name", value);
    }

}

/// <summary>
/// Block type for vmware_engine_preferences in GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlockVmwareEnginePreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vmware_engine_preferences";

    /// <summary>
    /// Commitment plan to consider when calculating costs for virtual machine insights and recommendations. If you are unsure which value to set, a 3 year commitment plan is often a good value to start with. Possible values: &#39;COMMITMENT_PLAN_UNSPECIFIED&#39;, &#39;ON_DEMAND&#39;, &#39;COMMITMENT_1_YEAR_MONTHLY_PAYMENTS&#39;, &#39;COMMITMENT_3_YEAR_MONTHLY_PAYMENTS&#39;, &#39;COMMITMENT_1_YEAR_UPFRONT_PAYMENT&#39;, &#39;COMMITMENT_3_YEAR_UPFRONT_PAYMENT&#39;,
    /// </summary>
    public TerraformValue<string>? CommitmentPlan
    {
        get => new TerraformReference<string>(this, "commitment_plan");
        set => SetArgument("commitment_plan", value);
    }

    /// <summary>
    /// CPU overcommit ratio. Acceptable values are between 1.0 and 8.0, with 0.1 increment.
    /// </summary>
    public TerraformValue<double>? CpuOvercommitRatio
    {
        get => new TerraformReference<double>(this, "cpu_overcommit_ratio");
        set => SetArgument("cpu_overcommit_ratio", value);
    }

    /// <summary>
    /// Memory overcommit ratio. Acceptable values are 1.0, 1.25, 1.5, 1.75 and 2.0.
    /// </summary>
    public TerraformValue<double>? MemoryOvercommitRatio
    {
        get => new TerraformReference<double>(this, "memory_overcommit_ratio");
        set => SetArgument("memory_overcommit_ratio", value);
    }

    /// <summary>
    /// The Deduplication and Compression ratio is based on the logical (Used Before) space required to store data before applying deduplication and compression, in relation to the physical (Used After) space required after applying deduplication and compression. Specifically, the ratio is the Used Before space divided by the Used After space. For example, if the Used Before space is 3 GB, but the physical Used After space is 1 GB, the deduplication and compression ratio is 3x. Acceptable values are between 1.0 and 4.0.
    /// </summary>
    public TerraformValue<double>? StorageDeduplicationCompressionRatio
    {
        get => new TerraformReference<double>(this, "storage_deduplication_compression_ratio");
        set => SetArgument("storage_deduplication_compression_ratio", value);
    }

}


/// <summary>
/// Represents a google_migration_center_preference_set Terraform resource.
/// Manages a google_migration_center_preference_set resource.
/// </summary>
public partial class GoogleMigrationCenterPreferenceSet(string name) : TerraformResource("google_migration_center_preference_set", name)
{
    /// <summary>
    /// A description of the preference set.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User-friendly display name. Maximum length is 63 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Required. User specified ID for the preference set. It will become the last component of the preference set name. The ID must be unique within the project, must conform with RFC-1034, is restricted to lower-cased letters, and has a maximum length of 63 characters. The ID must match the regular expression &#39;[a-z]([a-z0-9-]{0,61}[a-z0-9])?&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferenceSetId is required")]
    public required TerraformValue<string> PreferenceSetId
    {
        get => new TerraformReference<string>(this, "preference_set_id");
        set => SetArgument("preference_set_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The timestamp when the preference set was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. Name of the preference set.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. The timestamp when the preference set was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMigrationCenterPreferenceSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMigrationCenterPreferenceSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VirtualMachinePreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachinePreferences block(s) allowed")]
    public TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock>? VirtualMachinePreferences
    {
        get => GetArgument<TerraformList<GoogleMigrationCenterPreferenceSetVirtualMachinePreferencesBlock>>("virtual_machine_preferences");
        set => SetArgument("virtual_machine_preferences", value);
    }

}
