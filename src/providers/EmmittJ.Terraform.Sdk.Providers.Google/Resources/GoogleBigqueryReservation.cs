using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscale in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryReservationAutoscaleBlock : ITerraformBlock
{
    /// <summary>
    /// The slot capacity added to this reservation when autoscale happens. Will be between [0, max_slots].
    /// </summary>
    [TerraformPropertyName("current_slots")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CurrentSlots => new TerraformReferenceProperty<TerraformProperty<double>>("", "current_slots");

    /// <summary>
    /// Number of slots to be scaled when needed.
    /// </summary>
    [TerraformPropertyName("max_slots")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxSlots { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryReservationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_reservation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryReservation : TerraformResource
{
    public GoogleBigqueryReservation(string name) : base("google_bigquery_reservation", name)
    {
    }

    /// <summary>
    /// Maximum number of queries that are allowed to run concurrently in this reservation. This is a soft limit due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency will be automatically set based on the reservation size.
    /// </summary>
    [TerraformPropertyName("concurrency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Concurrency { get; set; }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    [TerraformPropertyName("edition")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Edition { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edition");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// If false, any query using this reservation will use idle slots from other reservations within
    /// the same admin project. If true, a query using this reservation will execute with the slot
    /// capacity specified above at most.
    /// </summary>
    [TerraformPropertyName("ignore_idle_slots")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreIdleSlots { get; set; }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The name of the reservation. This field must only contain alphanumeric characters or dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The current location of the reservation&#39;s secondary replica. This field is only set for
    /// reservations using the managed disaster recovery feature. Users can set this in create
    /// reservation calls to create a failover reservation or in update reservation calls to convert
    /// a non-failover reservation to a failover reservation(or vice versa).
    /// </summary>
    [TerraformPropertyName("secondary_location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecondaryLocation { get; set; }

    /// <summary>
    /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the
    /// unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotCapacity is required")]
    [TerraformPropertyName("slot_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> SlotCapacity { get; set; }

    /// <summary>
    /// Block for autoscale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscale block(s) allowed")]
    [TerraformPropertyName("autoscale")]
    public TerraformList<TerraformBlock<GoogleBigqueryReservationAutoscaleBlock>>? Autoscale { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryReservationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The location where the reservation was originally created. This is set only during the
    /// failover reservation&#39;s creation. All billing charges for the failover reservation will be
    /// applied to this location.
    /// </summary>
    [TerraformPropertyName("original_primary_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OriginalPrimaryLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "original_primary_location");

    /// <summary>
    /// The current location of the reservation&#39;s primary replica. This field is only set for
    /// reservations using the managed disaster recovery feature.
    /// </summary>
    [TerraformPropertyName("primary_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_location");

    /// <summary>
    /// The Disaster Recovery(DR) replication status of the reservation. This is only available for
    /// the primary replicas of DR/failover reservations and provides information about the both the
    /// staleness of the secondary and the last error encountered while trying to replicate changes
    /// from the primary to the secondary. If this field is blank, it means that the reservation is
    /// either not a DR reservation or the reservation is a DR secondary or that any replication
    /// operations on the reservation have succeeded.
    /// </summary>
    [TerraformPropertyName("replication_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReplicationStatus => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "replication_status");

}
