using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_reservation resource.
/// </summary>
public class GoogleBigqueryReservation : TerraformResource
{
    public GoogleBigqueryReservation(string name) : base("google_bigquery_reservation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("original_primary_location");
        this.DeclareOutput("primary_location");
        this.DeclareOutput("replication_status");
    }

    /// <summary>
    /// Maximum number of queries that are allowed to run concurrently in this reservation. This is a soft limit due to asynchronous nature of the system and various optimizations for small queries. Default value is 0 which means that concurrency will be automatically set based on the reservation size.
    /// </summary>
    public double? Concurrency
    {
        get => GetProperty<TerraformLiteralProperty<double>>("concurrency")?.Value;
        set => this.WithProperty("concurrency", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    public string? Edition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edition")?.Value;
        set => this.WithProperty("edition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If false, any query using this reservation will use idle slots from other reservations within
    /// the same admin project. If true, a query using this reservation will execute with the slot
    /// capacity specified above at most.
    /// </summary>
    public bool? IgnoreIdleSlots
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_idle_slots")?.Value;
        set => this.WithProperty("ignore_idle_slots", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the reservation. This field must only contain alphanumeric characters or dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The current location of the reservation&#39;s secondary replica. This field is only set for
    /// reservations using the managed disaster recovery feature. Users can set this in create
    /// reservation calls to create a failover reservation or in update reservation calls to convert
    /// a non-failover reservation to a failover reservation(or vice versa).
    /// </summary>
    public string? SecondaryLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secondary_location")?.Value;
        set => this.WithProperty("secondary_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the
    /// unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.
    /// </summary>
    public double? SlotCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("slot_capacity")?.Value;
        set => this.WithProperty("slot_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
