using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_reservation.
/// </summary>
public class GoogleComputeReservationDataSource : TerraformDataSource
{
    public GoogleComputeReservationDataSource(string name) : base("google_compute_reservation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("commitment");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("delete_after_duration");
        this.DeclareOutput("delete_at_time");
        this.DeclareOutput("description");
        this.DeclareOutput("reservation_sharing_policy");
        this.DeclareOutput("self_link");
        this.DeclareOutput("share_settings");
        this.DeclareOutput("specific_reservation");
        this.DeclareOutput("specific_reservation_required");
        this.DeclareOutput("status");
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
    /// The zone where the reservation is made.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformProperty<string> Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
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
    /// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
    /// </summary>
    public TerraformExpression DeleteAfterDuration => this["delete_after_duration"];

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    public TerraformExpression DeleteAtTime => this["delete_at_time"];

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Sharing policy for reservations with Google Cloud managed services.
    /// </summary>
    public TerraformExpression ReservationSharingPolicy => this["reservation_sharing_policy"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The share setting for reservations.
    /// </summary>
    public TerraformExpression ShareSettings => this["share_settings"];

    /// <summary>
    /// Reservation for instances with specific machine shapes.
    /// </summary>
    public TerraformExpression SpecificReservation => this["specific_reservation"];

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    public TerraformExpression SpecificReservationRequired => this["specific_reservation_required"];

    /// <summary>
    /// The status of the reservation.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
