using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscale in GoogleBigqueryReservation.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryReservationAutoscaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscale";

    /// <summary>
    /// The slot capacity added to this reservation when autoscale happens. Will be between [0, max_slots].
    /// </summary>
    public TerraformValue<double> CurrentSlots
    {
        get => new TerraformReference<double>(this, "current_slots");
    }

    /// <summary>
    /// Number of slots to be scaled when needed.
    /// </summary>
    public TerraformValue<double>? MaxSlots
    {
        get => new TerraformReference<double>(this, "max_slots");
        set => SetArgument("max_slots", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryReservation.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryReservationTimeoutsBlock : TerraformBlock
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
/// Represents a google_bigquery_reservation Terraform resource.
/// Manages a google_bigquery_reservation resource.
/// </summary>
public partial class GoogleBigqueryReservation(string name) : TerraformResource("google_bigquery_reservation", name)
{
    /// <summary>
    /// Maximum number of queries that are allowed to run concurrently in this reservation. This is a soft limit due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency will be automatically set based on the reservation size.
    /// </summary>
    public TerraformValue<double>? Concurrency
    {
        get => new TerraformReference<double>(this, "concurrency");
        set => SetArgument("concurrency", value);
    }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    public TerraformValue<string> Edition
    {
        get => new TerraformReference<string>(this, "edition");
        set => SetArgument("edition", value);
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
    /// If false, any query using this reservation will use idle slots from other reservations within
    /// the same admin project. If true, a query using this reservation will execute with the slot
    /// capacity specified above at most.
    /// </summary>
    public TerraformValue<bool>? IgnoreIdleSlots
    {
        get => new TerraformReference<bool>(this, "ignore_idle_slots");
        set => SetArgument("ignore_idle_slots", value);
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the reservation. This field must only contain alphanumeric characters or dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The current location of the reservation&#39;s secondary replica. This field is only set for
    /// reservations using the managed disaster recovery feature. Users can set this in create
    /// reservation calls to create a failover reservation or in update reservation calls to convert
    /// a non-failover reservation to a failover reservation(or vice versa).
    /// </summary>
    public TerraformValue<string>? SecondaryLocation
    {
        get => new TerraformReference<string>(this, "secondary_location");
        set => SetArgument("secondary_location", value);
    }

    /// <summary>
    /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the
    /// unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotCapacity is required")]
    public required TerraformValue<double> SlotCapacity
    {
        get => new TerraformReference<double>(this, "slot_capacity");
        set => SetArgument("slot_capacity", value);
    }

    /// <summary>
    /// The location where the reservation was originally created. This is set only during the
    /// failover reservation&#39;s creation. All billing charges for the failover reservation will be
    /// applied to this location.
    /// </summary>
    public TerraformValue<string> OriginalPrimaryLocation
    {
        get => new TerraformReference<string>(this, "original_primary_location");
    }

    /// <summary>
    /// The current location of the reservation&#39;s primary replica. This field is only set for
    /// reservations using the managed disaster recovery feature.
    /// </summary>
    public TerraformValue<string> PrimaryLocation
    {
        get => new TerraformReference<string>(this, "primary_location");
    }

    /// <summary>
    /// The Disaster Recovery(DR) replication status of the reservation. This is only available for
    /// the primary replicas of DR/failover reservations and provides information about the both the
    /// staleness of the secondary and the last error encountered while trying to replicate changes
    /// from the primary to the secondary. If this field is blank, it means that the reservation is
    /// either not a DR reservation or the reservation is a DR secondary or that any replication
    /// operations on the reservation have succeeded.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReplicationStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "replication_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// Autoscale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscale block(s) allowed")]
    public TerraformList<GoogleBigqueryReservationAutoscaleBlock>? Autoscale
    {
        get => GetArgument<TerraformList<GoogleBigqueryReservationAutoscaleBlock>>("autoscale");
        set => SetArgument("autoscale", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryReservationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryReservationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
