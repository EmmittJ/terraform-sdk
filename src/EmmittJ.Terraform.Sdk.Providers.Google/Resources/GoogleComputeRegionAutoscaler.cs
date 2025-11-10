using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionAutoscalerAutoscalingPolicyBlock : TerraformBlock
{
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
    public TerraformProperty<double>? CooldownPeriod
    {
        get => GetProperty<TerraformProperty<double>>("cooldown_period");
        set => WithProperty("cooldown_period", value);
    }

    /// <summary>
    /// The maximum number of instances that the autoscaler can scale up
    /// to. This is required when creating or updating an autoscaler. The
    /// maximum number of replicas should not be lower than minimal number
    /// of replicas.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReplicas is required")]
    public required TerraformProperty<double> MaxReplicas
    {
        get => GetProperty<TerraformProperty<double>>("max_replicas");
        set => WithProperty("max_replicas", value);
    }

    /// <summary>
    /// The minimum number of replicas that the autoscaler can scale down
    /// to. This cannot be less than 0. If not provided, autoscaler will
    /// choose a default value depending on maximum number of instances
    /// allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReplicas is required")]
    public required TerraformProperty<double> MinReplicas
    {
        get => GetProperty<TerraformProperty<double>>("min_replicas");
        set => WithProperty("min_replicas", value);
    }

    /// <summary>
    /// Defines operating mode for this policy.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionAutoscalerTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_region_autoscaler resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRegionAutoscaler : TerraformResource
{
    public GoogleComputeRegionAutoscaler(string name) : base("google_compute_region_autoscaler", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Name of the resource. The name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// URL of the region where the instance group resides.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// URL of the managed instance group that this autoscaler will scale.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Block for autoscaling_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AutoscalingPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingPolicy block(s) allowed")]
    public List<GoogleComputeRegionAutoscalerAutoscalingPolicyBlock>? AutoscalingPolicy
    {
        get => GetProperty<List<GoogleComputeRegionAutoscalerAutoscalingPolicyBlock>>("autoscaling_policy");
        set => this.WithProperty("autoscaling_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionAutoscalerTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRegionAutoscalerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
