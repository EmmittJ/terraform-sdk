using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_reservation Terraform data source.
/// Retrieves information about a google_compute_reservation.
/// </summary>
public partial class GoogleComputeReservationDataSource(string name) : TerraformDataSource("google_compute_reservation", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The zone where the reservation is made.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Full or partial URL to a parent commitment. This field displays for
    /// reservations that are tied to a commitment.
    /// </summary>
    public TerraformValue<string> Commitment
    {
        get => new TerraformReference<string>(this, "commitment");
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeleteAfterDuration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "delete_after_duration").ResolveNodes(ctx));
    }

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    public TerraformValue<string> DeleteAtTime
    {
        get => new TerraformReference<string>(this, "delete_at_time");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Sharing policy for reservations with Google Cloud managed services.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReservationSharingPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "reservation_sharing_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The share setting for reservations.
    /// </summary>
    public TerraformList<TerraformMap<object>> ShareSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "share_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// Reservation for instances with specific machine shapes.
    /// </summary>
    public TerraformList<TerraformMap<object>> SpecificReservation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "specific_reservation").ResolveNodes(ctx));
    }

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    public TerraformValue<bool> SpecificReservationRequired
    {
        get => new TerraformReference<bool>(this, "specific_reservation_required");
    }

    /// <summary>
    /// The status of the reservation.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
