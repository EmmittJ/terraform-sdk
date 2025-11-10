using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscale in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryReservationAutoscaleBlock : TerraformBlock
{
    /// <summary>
    /// The slot capacity added to this reservation when autoscale happens. Will be between [0, max_slots].
    /// </summary>
    public TerraformProperty<double>? CurrentSlots
    {
        set => SetProperty("current_slots", value);
    }

    /// <summary>
    /// Number of slots to be scaled when needed.
    /// </summary>
    public TerraformProperty<double>? MaxSlots
    {
        set => SetProperty("max_slots", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryReservationTimeoutsBlock : TerraformBlock
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
/// Manages a google_bigquery_reservation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryReservation : TerraformResource
{
    public GoogleBigqueryReservation(string name) : base("google_bigquery_reservation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("original_primary_location");
        SetOutput("primary_location");
        SetOutput("replication_status");
        SetOutput("concurrency");
        SetOutput("edition");
        SetOutput("id");
        SetOutput("ignore_idle_slots");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("secondary_location");
        SetOutput("slot_capacity");
    }

    /// <summary>
    /// Maximum number of queries that are allowed to run concurrently in this reservation. This is a soft limit due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency will be automatically set based on the reservation size.
    /// </summary>
    public TerraformProperty<double> Concurrency
    {
        get => GetRequiredOutput<TerraformProperty<double>>("concurrency");
        set => SetProperty("concurrency", value);
    }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    public TerraformProperty<string> Edition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edition");
        set => SetProperty("edition", value);
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
    /// If false, any query using this reservation will use idle slots from other reservations within
    /// the same admin project. If true, a query using this reservation will execute with the slot
    /// capacity specified above at most.
    /// </summary>
    public TerraformProperty<bool> IgnoreIdleSlots
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_idle_slots");
        set => SetProperty("ignore_idle_slots", value);
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of the reservation. This field must only contain alphanumeric characters or dash.
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
    /// The current location of the reservation&#39;s secondary replica. This field is only set for
    /// reservations using the managed disaster recovery feature. Users can set this in create
    /// reservation calls to create a failover reservation or in update reservation calls to convert
    /// a non-failover reservation to a failover reservation(or vice versa).
    /// </summary>
    public TerraformProperty<string> SecondaryLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secondary_location");
        set => SetProperty("secondary_location", value);
    }

    /// <summary>
    /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the
    /// unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotCapacity is required")]
    public required TerraformProperty<double> SlotCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("slot_capacity");
        set => SetProperty("slot_capacity", value);
    }

    /// <summary>
    /// Block for autoscale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscale block(s) allowed")]
    public List<GoogleBigqueryReservationAutoscaleBlock>? Autoscale
    {
        set => SetProperty("autoscale", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryReservationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The location where the reservation was originally created. This is set only during the
    /// failover reservation&#39;s creation. All billing charges for the failover reservation will be
    /// applied to this location.
    /// </summary>
    public TerraformExpression OriginalPrimaryLocation => this["original_primary_location"];

    /// <summary>
    /// The current location of the reservation&#39;s primary replica. This field is only set for
    /// reservations using the managed disaster recovery feature.
    /// </summary>
    public TerraformExpression PrimaryLocation => this["primary_location"];

    /// <summary>
    /// The Disaster Recovery(DR) replication status of the reservation. This is only available for
    /// the primary replicas of DR/failover reservations and provides information about the both the
    /// staleness of the secondary and the last error encountered while trying to replicate changes
    /// from the primary to the secondary. If this field is blank, it means that the reservation is
    /// either not a DR reservation or the reservation is a DR secondary or that any replication
    /// operations on the reservation have succeeded.
    /// </summary>
    public TerraformExpression ReplicationStatus => this["replication_status"];

}
