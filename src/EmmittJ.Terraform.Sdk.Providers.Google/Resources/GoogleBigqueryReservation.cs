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
    public TerraformProperty<double>? Concurrency
    {
        get => GetProperty<TerraformProperty<double>>("concurrency");
        set => this.WithProperty("concurrency", value);
    }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    public TerraformProperty<string>? Edition
    {
        get => GetProperty<TerraformProperty<string>>("edition");
        set => this.WithProperty("edition", value);
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
    /// If false, any query using this reservation will use idle slots from other reservations within
    /// the same admin project. If true, a query using this reservation will execute with the slot
    /// capacity specified above at most.
    /// </summary>
    public TerraformProperty<bool>? IgnoreIdleSlots
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_idle_slots");
        set => this.WithProperty("ignore_idle_slots", value);
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the reservation. This field must only contain alphanumeric characters or dash.
    /// </summary>
    public TerraformProperty<string>? Name
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
    /// The current location of the reservation&#39;s secondary replica. This field is only set for
    /// reservations using the managed disaster recovery feature. Users can set this in create
    /// reservation calls to create a failover reservation or in update reservation calls to convert
    /// a non-failover reservation to a failover reservation(or vice versa).
    /// </summary>
    public TerraformProperty<string>? SecondaryLocation
    {
        get => GetProperty<TerraformProperty<string>>("secondary_location");
        set => this.WithProperty("secondary_location", value);
    }

    /// <summary>
    /// Minimum slots available to this reservation. A slot is a unit of computational power in BigQuery, and serves as the
    /// unit of parallelism. Queries using this reservation might use more slots during runtime if ignoreIdleSlots is set to false.
    /// </summary>
    public TerraformProperty<double>? SlotCapacity
    {
        get => GetProperty<TerraformProperty<double>>("slot_capacity");
        set => this.WithProperty("slot_capacity", value);
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
