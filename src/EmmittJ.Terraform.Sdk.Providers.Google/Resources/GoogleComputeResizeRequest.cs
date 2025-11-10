using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for requested_run_duration in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeResizeRequestRequestedRunDurationBlock : TerraformBlock
{
    /// <summary>
    /// Span of time that&#39;s a fraction of a second at nanosecond resolution. Durations less than one second are represented with a 0 seconds field and a positive nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    public TerraformProperty<double>? Nanos
    {
        get => GetProperty<TerraformProperty<double>>("nanos");
        set => WithProperty("nanos", value);
    }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 600 to 604800 inclusive. Note: minimum and maximum allowed range for requestedRunDuration is 10 minutes (600 seconds) and 7 days(604800 seconds) correspondingly.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformProperty<string> Seconds
    {
        get => GetProperty<TerraformProperty<string>>("seconds");
        set => WithProperty("seconds", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeResizeRequestTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_compute_resize_request resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeResizeRequest : TerraformResource
{
    public GoogleComputeResizeRequest(string name) : base("google_compute_resize_request", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("state");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// An optional description of this resize-request.
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
    /// The reference of the instance group manager this ResizeRequest is a part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceGroupManager is required")]
    public required TerraformProperty<string> InstanceGroupManager
    {
        get => GetProperty<TerraformProperty<string>>("instance_group_manager");
        set => this.WithProperty("instance_group_manager", value);
    }

    /// <summary>
    /// The name of this resize request. The name must be 1-63 characters long, and comply with RFC1035.
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
    /// The number of instances to be created by this resize request. The group&#39;s target size will be increased by this number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResizeBy is required")]
    public required TerraformProperty<double> ResizeBy
    {
        get => GetProperty<TerraformProperty<double>>("resize_by");
        set => this.WithProperty("resize_by", value);
    }

    /// <summary>
    /// The reference of the compute zone scoping this request. If it is not provided, the provider zone is used.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for requested_run_duration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestedRunDuration block(s) allowed")]
    public List<GoogleComputeResizeRequestRequestedRunDurationBlock>? RequestedRunDuration
    {
        get => GetProperty<List<GoogleComputeResizeRequestRequestedRunDurationBlock>>("requested_run_duration");
        set => this.WithProperty("requested_run_duration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeResizeRequestTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeResizeRequestTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The creation timestamp for this resize request in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Current state of the request.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Status of the request.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
