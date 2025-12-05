using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_policy in GoogleComputeRegionAutoscaler.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionAutoscalerAutoscalingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_policy";

    /// <summary>
    /// The number of seconds that the autoscaler should wait before it
    /// starts collecting information from a new instance. This prevents
    /// the autoscaler from collecting information when the instance is
    /// initializing, during which the collected usage would not be
    /// reliable. The default time autoscaler waits is 60 seconds.
    /// 
    /// Virtual machine initialization times might vary because of
    /// numerous factors. We recommend that you test how long an
    /// instance may take to initialize. To do this, create an instance
    /// and time the startup process.
    /// </summary>
    public TerraformValue<double>? CooldownPeriod
    {
        get => GetArgument<TerraformValue<double>>("cooldown_period");
        set => SetArgument("cooldown_period", value);
    }

    /// <summary>
    /// The maximum number of instances that the autoscaler can scale up
    /// to. This is required when creating or updating an autoscaler. The
    /// maximum number of replicas should not be lower than minimal number
    /// of replicas.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReplicas is required")]
    public required TerraformValue<double> MaxReplicas
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_replicas");
        set => SetArgument("max_replicas", value);
    }

    /// <summary>
    /// The minimum number of replicas that the autoscaler can scale down
    /// to. This cannot be less than 0. If not provided, autoscaler will
    /// choose a default value depending on maximum number of instances
    /// allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicas is required")]
    public required TerraformValue<double> MinReplicas
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_replicas");
        set => SetArgument("min_replicas", value);
    }

    /// <summary>
    /// Defines operating mode for this policy.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// CpuUtilization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuUtilization block(s) allowed")]
    public TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockCpuUtilizationBlock>? CpuUtilization
    {
        get => GetArgument<TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockCpuUtilizationBlock>>("cpu_utilization");
        set => SetArgument("cpu_utilization", value);
    }

    /// <summary>
    /// LoadBalancingUtilization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancingUtilization block(s) allowed")]
    public TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockLoadBalancingUtilizationBlock>? LoadBalancingUtilization
    {
        get => GetArgument<TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockLoadBalancingUtilizationBlock>>("load_balancing_utilization");
        set => SetArgument("load_balancing_utilization", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockMetricBlock>? Metric
    {
        get => GetArgument<TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

    /// <summary>
    /// ScaleInControl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleInControl block(s) allowed")]
    public TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScaleInControlBlock>? ScaleInControl
    {
        get => GetArgument<TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScaleInControlBlock>>("scale_in_control");
        set => SetArgument("scale_in_control", value);
    }

    /// <summary>
    /// ScalingSchedules block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScalingSchedulesBlock>? ScalingSchedules
    {
        get => GetArgument<TerraformSet<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScalingSchedulesBlock>>("scaling_schedules");
        set => SetArgument("scaling_schedules", value);
    }

}

/// <summary>
/// Block type for cpu_utilization in GoogleComputeRegionAutoscalerAutoscalingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionAutoscalerAutoscalingPolicyBlockCpuUtilizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cpu_utilization";

    /// <summary>
    /// Indicates whether predictive autoscaling based on CPU metric is enabled. Valid values are:
    /// 
    /// - NONE (default). No predictive method is used. The autoscaler scales the group to meet current demand based on real-time metrics.
    /// 
    /// - OPTIMIZE_AVAILABILITY. Predictive autoscaling improves availability by monitoring daily and weekly load patterns and scaling out ahead of anticipated demand.
    /// </summary>
    public TerraformValue<string>? PredictiveMethod
    {
        get => GetArgument<TerraformValue<string>>("predictive_method");
        set => SetArgument("predictive_method", value);
    }

    /// <summary>
    /// The target CPU utilization that the autoscaler should maintain.
    /// Must be a float value in the range (0, 1]. If not specified, the
    /// default is 0.6.
    /// 
    /// If the CPU level is below the target utilization, the autoscaler
    /// scales down the number of instances until it reaches the minimum
    /// number of instances you specified or until the average CPU of
    /// your instances reaches the target utilization.
    /// 
    /// If the average CPU is above the target utilization, the autoscaler
    /// scales up until it reaches the maximum number of instances you
    /// specified or until the average utilization reaches the target
    /// utilization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<double> Target
    {
        get => GetRequiredArgument<TerraformValue<double>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for load_balancing_utilization in GoogleComputeRegionAutoscalerAutoscalingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionAutoscalerAutoscalingPolicyBlockLoadBalancingUtilizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancing_utilization";

    /// <summary>
    /// Fraction of backend capacity utilization (set in HTTP(s) load
    /// balancing configuration) that autoscaler should maintain. Must
    /// be a positive float value. If not defined, the default is 0.8.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<double> Target
    {
        get => GetRequiredArgument<TerraformValue<double>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for metric in GoogleComputeRegionAutoscalerAutoscalingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionAutoscalerAutoscalingPolicyBlockMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric";

    /// <summary>
    /// A filter string to be used as the filter string for
    /// a Stackdriver Monitoring TimeSeries.list API call.
    /// This filter is used to select a specific TimeSeries for
    /// the purpose of autoscaling and to determine whether the metric
    /// is exporting per-instance or per-group data.
    /// 
    /// You can only use the AND operator for joining selectors.
    /// You can only use direct equality comparison operator (=) without
    /// any functions for each selector.
    /// You can specify the metric in both the filter string and in the
    /// metric field. However, if specified in both places, the metric must
    /// be identical.
    /// 
    /// The monitored resource type determines what kind of values are
    /// expected for the metric. If it is a gce_instance, the autoscaler
    /// expects the metric to include a separate TimeSeries for each
    /// instance in a group. In such a case, you cannot filter on resource
    /// labels.
    /// 
    /// If the resource type is any other value, the autoscaler expects
    /// this metric to contain values that apply to the entire autoscaled
    /// instance group and resource label filtering can be performed to
    /// point autoscaler at the correct TimeSeries to scale upon.
    /// This is called a per-group metric for the purpose of autoscaling.
    /// 
    /// If not specified, the type defaults to gce_instance.
    /// 
    /// You should provide a filter that is selective enough to pick just
    /// one TimeSeries for the autoscaled group or for each of the instances
    /// (if you are using gce_instance resource type). If multiple
    /// TimeSeries are returned upon the query execution, the autoscaler
    /// will sum their respective values to obtain its scaling value.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The identifier (type) of the Stackdriver Monitoring metric.
    /// The metric cannot have negative values.
    /// 
    /// The metric must have a value type of INT64 or DOUBLE.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// If scaling is based on a per-group metric value that represents the
    /// total amount of work to be done or resource usage, set this value to
    /// an amount assigned for a single instance of the scaled group.
    /// The autoscaler will keep the number of instances proportional to the
    /// value of this metric, the metric itself should not change value due
    /// to group resizing.
    /// 
    /// For example, a good metric to use with the target is
    /// &#39;pubsub.googleapis.com/subscription/num_undelivered_messages&#39;
    /// or a custom metric exporting the total number of requests coming to
    /// your instances.
    /// 
    /// A bad example would be a metric exporting an average or median
    /// latency, since this value can&#39;t include a chunk assignable to a
    /// single instance, it could be better used with utilization_target
    /// instead.
    /// </summary>
    public TerraformValue<double>? SingleInstanceAssignment
    {
        get => GetArgument<TerraformValue<double>>("single_instance_assignment");
        set => SetArgument("single_instance_assignment", value);
    }

    /// <summary>
    /// The target value of the metric that autoscaler should
    /// maintain. This must be a positive value. A utilization
    /// metric scales number of virtual machines handling requests
    /// to increase or decrease proportionally to the metric.
    /// 
    /// For example, a good metric to use as a utilizationTarget is
    /// www.googleapis.com/compute/instance/network/received_bytes_count.
    /// The autoscaler will work to keep this value constant for each
    /// of the instances.
    /// </summary>
    public TerraformValue<double>? Target
    {
        get => GetArgument<TerraformValue<double>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Defines how target utilization value is expressed for a
    /// Stackdriver Monitoring metric. Possible values: [&amp;quot;GAUGE&amp;quot;, &amp;quot;DELTA_PER_SECOND&amp;quot;, &amp;quot;DELTA_PER_MINUTE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for scale_in_control in GoogleComputeRegionAutoscalerAutoscalingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScaleInControlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale_in_control";

    /// <summary>
    /// How long back autoscaling should look when computing recommendations
    /// to include directives regarding slower scale down, as described above.
    /// </summary>
    public TerraformValue<double>? TimeWindowSec
    {
        get => GetArgument<TerraformValue<double>>("time_window_sec");
        set => SetArgument("time_window_sec", value);
    }

    /// <summary>
    /// MaxScaledInReplicas block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaxScaledInReplicas block(s) allowed")]
    public TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScaleInControlBlockMaxScaledInReplicasBlock>? MaxScaledInReplicas
    {
        get => GetArgument<TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScaleInControlBlockMaxScaledInReplicasBlock>>("max_scaled_in_replicas");
        set => SetArgument("max_scaled_in_replicas", value);
    }

}

/// <summary>
/// Block type for max_scaled_in_replicas in GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScaleInControlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScaleInControlBlockMaxScaledInReplicasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_scaled_in_replicas";

    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive
    /// integer.
    /// </summary>
    public TerraformValue<double>? FixedAttribute
    {
        get => GetArgument<TerraformValue<double>>("fixed");
        set => SetArgument("fixed", value);
    }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive.
    /// For example, specify 80 for 80%.
    /// </summary>
    public TerraformValue<double>? Percent
    {
        get => GetArgument<TerraformValue<double>>("percent");
        set => SetArgument("percent", value);
    }

}

/// <summary>
/// Block type for scaling_schedules in GoogleComputeRegionAutoscalerAutoscalingPolicyBlock.
/// Nesting mode: set
/// </summary>
public class GoogleComputeRegionAutoscalerAutoscalingPolicyBlockScalingSchedulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling_schedules";

    /// <summary>
    /// A description of a scaling schedule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A boolean value that specifies if a scaling schedule can influence autoscaler recommendations. If set to true, then a scaling schedule has no effect.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The duration of time intervals (in seconds) for which this scaling schedule will be running. The minimum allowed value is 300.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DurationSec is required")]
    public required TerraformValue<double> DurationSec
    {
        get => GetRequiredArgument<TerraformValue<double>>("duration_sec");
        set => SetArgument("duration_sec", value);
    }

    /// <summary>
    /// Minimum number of VM instances that autoscaler will recommend in time intervals starting according to schedule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinRequiredReplicas is required")]
    public required TerraformValue<double> MinRequiredReplicas
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_required_replicas");
        set => SetArgument("min_required_replicas", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The start timestamps of time intervals when this scaling schedule should provide a scaling signal. This field uses the extended cron format (with an optional year field).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => GetRequiredArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRegionAutoscaler.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionAutoscalerTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_region_autoscaler Terraform resource.
/// Manages a google_compute_region_autoscaler resource.
/// </summary>
public partial class GoogleComputeRegionAutoscaler(string name) : TerraformResource("google_compute_region_autoscaler", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Name of the resource. The name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// URL of the region where the instance group resides.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// URL of the managed instance group that this autoscaler will scale.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => GetRequiredArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// AutoscalingPolicy block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoscalingPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoscalingPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingPolicy block(s) allowed")]
    public required TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlock> AutoscalingPolicy
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeRegionAutoscalerAutoscalingPolicyBlock>>("autoscaling_policy");
        set => SetArgument("autoscaling_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionAutoscalerTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionAutoscalerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
