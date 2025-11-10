using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for delete_after_duration in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationDeleteAfterDurationBlock : TerraformBlock
{
    /// <summary>
    /// Number of nanoseconds for the auto-delete duration.
    /// </summary>
    public TerraformProperty<double>? Nanos
    {
        get => GetProperty<TerraformProperty<double>>("nanos");
        set => WithProperty("nanos", value);
    }

    /// <summary>
    /// Number of seconds for the auto-delete duration.
    /// </summary>
    public TerraformProperty<string>? Seconds
    {
        get => GetProperty<TerraformProperty<string>>("seconds");
        set => WithProperty("seconds", value);
    }

}

/// <summary>
/// Block type for reservation_sharing_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationReservationSharingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Sharing config for all Google Cloud services. Possible values: [&amp;quot;ALLOW_ALL&amp;quot;, &amp;quot;DISALLOW_ALL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ServiceShareType
    {
        get => GetProperty<TerraformProperty<string>>("service_share_type");
        set => WithProperty("service_share_type", value);
    }

}

/// <summary>
/// Block type for share_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationShareSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Type of sharing for this shared-reservation Possible values: [&amp;quot;LOCAL&amp;quot;, &amp;quot;SPECIFIC_PROJECTS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ShareType
    {
        get => GetProperty<TerraformProperty<string>>("share_type");
        set => WithProperty("share_type", value);
    }

}

/// <summary>
/// Block type for specific_reservation in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationSpecificReservationBlock : TerraformBlock
{
    /// <summary>
    /// The number of resources that are allocated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    public required TerraformProperty<double> Count
    {
        get => GetRequiredProperty<TerraformProperty<double>>("count");
        set => WithProperty("count", value);
    }

    /// <summary>
    /// How many instances are in use.
    /// </summary>
    public TerraformProperty<double>? InUseCount
    {
        get => GetProperty<TerraformProperty<double>>("in_use_count");
        set => WithProperty("in_use_count", value);
    }

    /// <summary>
    /// Specifies the instance template to create the reservation. If you use this field, you must exclude the
    /// instanceProperties field.
    /// </summary>
    public TerraformProperty<string>? SourceInstanceTemplate
    {
        get => GetProperty<TerraformProperty<string>>("source_instance_template");
        set => WithProperty("source_instance_template", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeReservationTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_reservation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeReservation : TerraformResource
{
    public GoogleComputeReservation(string name) : base("google_compute_reservation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("commitment");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("self_link");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    public TerraformProperty<string>? DeleteAtTime
    {
        get => GetProperty<TerraformProperty<string>>("delete_at_time");
        set => this.WithProperty("delete_at_time", value);
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
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? SpecificReservationRequired
    {
        get => GetProperty<TerraformProperty<bool>>("specific_reservation_required");
        set => this.WithProperty("specific_reservation_required", value);
    }

    /// <summary>
    /// The zone where the reservation is made.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformProperty<string> Zone
    {
        get => GetRequiredProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for delete_after_duration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteAfterDuration block(s) allowed")]
    public List<GoogleComputeReservationDeleteAfterDurationBlock>? DeleteAfterDuration
    {
        get => GetProperty<List<GoogleComputeReservationDeleteAfterDurationBlock>>("delete_after_duration");
        set => this.WithProperty("delete_after_duration", value);
    }

    /// <summary>
    /// Block for reservation_sharing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationSharingPolicy block(s) allowed")]
    public List<GoogleComputeReservationReservationSharingPolicyBlock>? ReservationSharingPolicy
    {
        get => GetProperty<List<GoogleComputeReservationReservationSharingPolicyBlock>>("reservation_sharing_policy");
        set => this.WithProperty("reservation_sharing_policy", value);
    }

    /// <summary>
    /// Block for share_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    public List<GoogleComputeReservationShareSettingsBlock>? ShareSettings
    {
        get => GetProperty<List<GoogleComputeReservationShareSettingsBlock>>("share_settings");
        set => this.WithProperty("share_settings", value);
    }

    /// <summary>
    /// Block for specific_reservation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpecificReservation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpecificReservation block(s) allowed")]
    public List<GoogleComputeReservationSpecificReservationBlock>? SpecificReservation
    {
        get => GetProperty<List<GoogleComputeReservationSpecificReservationBlock>>("specific_reservation");
        set => this.WithProperty("specific_reservation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeReservationTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeReservationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Full or partial URL to a parent commitment. This field displays for
    /// reservations that are tied to a commitment.
    /// </summary>
    public TerraformExpression Commitment => this["commitment"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The status of the reservation.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
