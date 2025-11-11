using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscale in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryReservationAutoscaleBlock : TerraformBlockBase
{

    /// <summary>
    /// Number of slots to be scaled when needed.
    /// </summary>
    [TerraformProperty("max_slots")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxSlots { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryReservationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_reservation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryReservation : TerraformResource
{
    public GoogleBigqueryReservation(string name) : base("google_bigquery_reservation", name)
    {
    }

    /// <summary>
    /// Maximum number of queries that are allowed to run concurrently in this reservation. This is a soft limit due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency will be automatically set based on the reservation size.
    /// </summary>
    [TerraformProperty("concurrency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Concurrency { get; set; }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    [TerraformProperty("edition")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Edition { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// If false, any query using this reservation will use idle slots from other reservations within
    /// the same admin project. If true, a query using this reservation will execute with the slot
    /// capacity specified above at most.
    /// </summary>
    [TerraformProperty("ignore_idle_slots")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreIdleSlots { get; set; }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The name of the reservation. This field must only contain alphanumeric characters or dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The current location of the reservation&#39;s secondary replica. This field is only set for
    /// reservations using the managed disaster recovery feature. Users can set this in create
    /// reservation calls to create a failover reservation or in update reservation calls to convert
    /// a non-failover reservation to a failover reservation(or vice versa).
    /// </summary>
    [TerraformProperty("secondary_location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecondaryLocation { get; set; }

    /// <summary>
    /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the
    /// unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotCapacity is required")]
    [TerraformProperty("slot_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SlotCapacity { get; set; }

    /// <summary>
    /// Block for autoscale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscale block(s) allowed")]
    [TerraformProperty("autoscale")]
    public partial TerraformList<TerraformBlock<GoogleBigqueryReservationAutoscaleBlock>>? Autoscale { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleBigqueryReservationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The location where the reservation was originally created. This is set only during the
    /// failover reservation&#39;s creation. All billing charges for the failover reservation will be
    /// applied to this location.
    /// </summary>
    [TerraformProperty("original_primary_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OriginalPrimaryLocation { get; }

    /// <summary>
    /// The current location of the reservation&#39;s primary replica. This field is only set for
    /// reservations using the managed disaster recovery feature.
    /// </summary>
    [TerraformProperty("primary_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryLocation { get; }

    /// <summary>
    /// The Disaster Recovery(DR) replication status of the reservation. This is only available for
    /// the primary replicas of DR/failover reservations and provides information about the both the
    /// staleness of the secondary and the last error encountered while trying to replicate changes
    /// from the primary to the secondary. If this field is blank, it means that the reservation is
    /// either not a DR reservation or the reservation is a DR secondary or that any replication
    /// operations on the reservation have succeeded.
    /// </summary>
    [TerraformProperty("replication_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ReplicationStatus { get; }

}
