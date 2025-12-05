using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_config in GoogleSpannerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerInstanceAutoscalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_config";

    /// <summary>
    /// AsymmetricAutoscalingOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlock>? AsymmetricAutoscalingOptions
    {
        get => GetArgument<TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlock>>("asymmetric_autoscaling_options");
        set => SetArgument("asymmetric_autoscaling_options", value);
    }

    /// <summary>
    /// AutoscalingLimits block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingLimits block(s) allowed")]
    public TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAutoscalingLimitsBlock>? AutoscalingLimits
    {
        get => GetArgument<TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAutoscalingLimitsBlock>>("autoscaling_limits");
        set => SetArgument("autoscaling_limits", value);
    }

    /// <summary>
    /// AutoscalingTargets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingTargets block(s) allowed")]
    public TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAutoscalingTargetsBlock>? AutoscalingTargets
    {
        get => GetArgument<TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAutoscalingTargetsBlock>>("autoscaling_targets");
        set => SetArgument("autoscaling_targets", value);
    }

}

/// <summary>
/// Block type for asymmetric_autoscaling_options in GoogleSpannerInstanceAutoscalingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "asymmetric_autoscaling_options";

    /// <summary>
    /// Overrides block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Overrides is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Overrides block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Overrides block(s) allowed")]
    public required TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockOverridesBlock> Overrides
    {
        get => GetRequiredArgument<TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockOverridesBlock>>("overrides");
        set => SetArgument("overrides", value);
    }

    /// <summary>
    /// ReplicaSelection block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaSelection is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReplicaSelection block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicaSelection block(s) allowed")]
    public required TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockReplicaSelectionBlock> ReplicaSelection
    {
        get => GetRequiredArgument<TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockReplicaSelectionBlock>>("replica_selection");
        set => SetArgument("replica_selection", value);
    }

}

/// <summary>
/// Block type for overrides in GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "overrides";

    /// <summary>
    /// AutoscalingLimits block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingLimits is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoscalingLimits block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingLimits block(s) allowed")]
    public required TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockOverridesBlockAutoscalingLimitsBlock> AutoscalingLimits
    {
        get => GetRequiredArgument<TerraformList<GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockOverridesBlockAutoscalingLimitsBlock>>("autoscaling_limits");
        set => SetArgument("autoscaling_limits", value);
    }

}

/// <summary>
/// Block type for autoscaling_limits in GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockOverridesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockOverridesBlockAutoscalingLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_limits";

    /// <summary>
    /// The maximum number of nodes for this specific replica.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodes is required")]
    public required TerraformValue<double> MaxNodes
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_nodes");
        set => SetArgument("max_nodes", value);
    }

    /// <summary>
    /// The minimum number of nodes for this specific replica.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodes is required")]
    public required TerraformValue<double> MinNodes
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_nodes");
        set => SetArgument("min_nodes", value);
    }

}

/// <summary>
/// Block type for replica_selection in GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerInstanceAutoscalingConfigBlockAsymmetricAutoscalingOptionsBlockReplicaSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replica_selection";

    /// <summary>
    /// The location of the replica to apply asymmetric autoscaling options.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

}

/// <summary>
/// Block type for autoscaling_limits in GoogleSpannerInstanceAutoscalingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerInstanceAutoscalingConfigBlockAutoscalingLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_limits";

    /// <summary>
    /// Specifies maximum number of nodes allocated to the instance. If set, this number
    /// should be greater than or equal to min_nodes.
    /// </summary>
    public TerraformValue<double>? MaxNodes
    {
        get => GetArgument<TerraformValue<double>>("max_nodes");
        set => SetArgument("max_nodes", value);
    }

    /// <summary>
    /// Specifies maximum number of processing units allocated to the instance.
    /// If set, this number should be multiples of 1000 and be greater than or equal to
    /// min_processing_units.
    /// </summary>
    public TerraformValue<double>? MaxProcessingUnits
    {
        get => GetArgument<TerraformValue<double>>("max_processing_units");
        set => SetArgument("max_processing_units", value);
    }

    /// <summary>
    /// Specifies number of nodes allocated to the instance. If set, this number
    /// should be greater than or equal to 1.
    /// </summary>
    public TerraformValue<double>? MinNodes
    {
        get => GetArgument<TerraformValue<double>>("min_nodes");
        set => SetArgument("min_nodes", value);
    }

    /// <summary>
    /// Specifies minimum number of processing units allocated to the instance.
    /// If set, this number should be multiples of 1000.
    /// </summary>
    public TerraformValue<double>? MinProcessingUnits
    {
        get => GetArgument<TerraformValue<double>>("min_processing_units");
        set => SetArgument("min_processing_units", value);
    }

}

/// <summary>
/// Block type for autoscaling_targets in GoogleSpannerInstanceAutoscalingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSpannerInstanceAutoscalingConfigBlockAutoscalingTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_targets";

    /// <summary>
    /// Specifies the target high priority cpu utilization percentage that the autoscaler
    /// should be trying to achieve for the instance.
    /// This number is on a scale from 0 (no utilization) to 100 (full utilization)..
    /// </summary>
    public TerraformValue<double>? HighPriorityCpuUtilizationPercent
    {
        get => GetArgument<TerraformValue<double>>("high_priority_cpu_utilization_percent");
        set => SetArgument("high_priority_cpu_utilization_percent", value);
    }

    /// <summary>
    /// Specifies the target storage utilization percentage that the autoscaler
    /// should be trying to achieve for the instance.
    /// This number is on a scale from 0 (no utilization) to 100 (full utilization).
    /// </summary>
    public TerraformValue<double>? StorageUtilizationPercent
    {
        get => GetArgument<TerraformValue<double>>("storage_utilization_percent");
        set => SetArgument("storage_utilization_percent", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSpannerInstance.
/// Nesting mode: single
/// </summary>
public class GoogleSpannerInstanceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_spanner_instance Terraform resource.
/// Manages a google_spanner_instance resource.
/// </summary>
public partial class GoogleSpannerInstance(string name) : TerraformResource("google_spanner_instance", name)
{
    /// <summary>
    /// The name of the instance&#39;s configuration (similar but not
    /// quite the same as a region) which defines the geographic placement and
    /// replication of your databases in this instance. It determines where your data
    /// is stored. Values are typically of the form &#39;regional-europe-west1&#39; , &#39;us-central&#39; etc.
    /// In order to obtain a valid list please consult the
    /// [Configuration section of the docs](https://cloud.google.com/spanner/docs/instances).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    public required TerraformValue<string> Config
    {
        get => GetRequiredArgument<TerraformValue<string>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Controls the default backup behavior for new databases within the instance.
    /// Note that &#39;AUTOMATIC&#39; is not permitted for free instances, as backups and backup schedules are not allowed for free instances.
    /// if unset or NONE, no default backup schedule will be created for new databases within the instance. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;AUTOMATIC&amp;quot;]
    /// </summary>
    public TerraformValue<string> DefaultBackupScheduleType
    {
        get => GetArgument<TerraformValue<string>>("default_backup_schedule_type") ?? CreateReference("default_backup_schedule_type");
        set => SetArgument("default_backup_schedule_type", value);
    }

    /// <summary>
    /// The descriptive name for this instance as it appears in UIs. Must be
    /// unique per project and between 4 and 30 characters in length.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The edition selected for this instance. Different editions provide different capabilities at different price points. Possible values: [&amp;quot;EDITION_UNSPECIFIED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;, &amp;quot;ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    public TerraformValue<string> Edition
    {
        get => GetArgument<TerraformValue<string>>("edition") ?? CreateReference("edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// When deleting a spanner instance, this boolean option will delete all backups of this instance.
    /// This must be set to true if you created a backup manually in the console.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The type of this instance. The type can be used to distinguish product variants, that can affect aspects like:
    /// usage restrictions, quotas and billing. Currently this is used to distinguish FREE_INSTANCE vs PROVISIONED instances.
    /// When configured as FREE_INSTANCE, the field &#39;edition&#39; should not be configured. Possible values: [&amp;quot;PROVISIONED&amp;quot;, &amp;quot;FREE_INSTANCE&amp;quot;]
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type") ?? CreateReference("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// A unique identifier for the instance, which cannot be changed after
    /// the instance is created. The name must be between 6 and 30 characters
    /// in length.
    /// If not provided, a random string starting with &#39;tf-&#39; will be selected.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The number of nodes allocated to this instance. Exactly one of either num_nodes, processing_units or
    /// autoscaling_config must be present in terraform except when instance_type = FREE_INSTANCE.
    /// </summary>
    public TerraformValue<double> NumNodes
    {
        get => GetArgument<TerraformValue<double>>("num_nodes") ?? CreateReference("num_nodes");
        set => SetArgument("num_nodes", value);
    }

    /// <summary>
    /// The number of processing units allocated to this instance. Exactly one of either num_nodes,
    /// processing_units or autoscaling_config must be present in terraform except when instance_type = FREE_INSTANCE.
    /// </summary>
    public TerraformValue<double> ProcessingUnits
    {
        get => GetArgument<TerraformValue<double>>("processing_units") ?? CreateReference("processing_units");
        set => SetArgument("processing_units", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Instance status: &#39;CREATING&#39; or &#39;READY&#39;.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// AutoscalingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingConfig block(s) allowed")]
    public TerraformList<GoogleSpannerInstanceAutoscalingConfigBlock>? AutoscalingConfig
    {
        get => GetArgument<TerraformList<GoogleSpannerInstanceAutoscalingConfigBlock>>("autoscaling_config");
        set => SetArgument("autoscaling_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSpannerInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSpannerInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
