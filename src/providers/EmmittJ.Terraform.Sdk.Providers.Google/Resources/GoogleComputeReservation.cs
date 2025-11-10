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
        set => SetProperty("nanos", value);
    }

    /// <summary>
    /// Number of seconds for the auto-delete duration.
    /// </summary>
    public TerraformProperty<string>? Seconds
    {
        set => SetProperty("seconds", value);
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
        set => SetProperty("service_share_type", value);
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
        set => SetProperty("share_type", value);
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
        set => SetProperty("count", value);
    }

    /// <summary>
    /// How many instances are in use.
    /// </summary>
    public TerraformProperty<double>? InUseCount
    {
        set => SetProperty("in_use_count", value);
    }

    /// <summary>
    /// Specifies the instance template to create the reservation. If you use this field, you must exclude the
    /// instanceProperties field.
    /// </summary>
    public TerraformProperty<string>? SourceInstanceTemplate
    {
        set => SetProperty("source_instance_template", value);
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
        SetOutput("commitment");
        SetOutput("creation_timestamp");
        SetOutput("self_link");
        SetOutput("status");
        SetOutput("delete_at_time");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("specific_reservation_required");
        SetOutput("zone");
    }

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    public TerraformProperty<string> DeleteAtTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delete_at_time");
        set => SetProperty("delete_at_time", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    public TerraformProperty<bool> SpecificReservationRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("specific_reservation_required");
        set => SetProperty("specific_reservation_required", value);
    }

    /// <summary>
    /// The zone where the reservation is made.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for delete_after_duration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteAfterDuration block(s) allowed")]
    public List<GoogleComputeReservationDeleteAfterDurationBlock>? DeleteAfterDuration
    {
        set => SetProperty("delete_after_duration", value);
    }

    /// <summary>
    /// Block for reservation_sharing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationSharingPolicy block(s) allowed")]
    public List<GoogleComputeReservationReservationSharingPolicyBlock>? ReservationSharingPolicy
    {
        set => SetProperty("reservation_sharing_policy", value);
    }

    /// <summary>
    /// Block for share_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    public List<GoogleComputeReservationShareSettingsBlock>? ShareSettings
    {
        set => SetProperty("share_settings", value);
    }

    /// <summary>
    /// Block for specific_reservation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpecificReservation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpecificReservation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpecificReservation block(s) allowed")]
    public List<GoogleComputeReservationSpecificReservationBlock>? SpecificReservation
    {
        set => SetProperty("specific_reservation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeReservationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
