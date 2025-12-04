using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleBigqueryReservationAssignment.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryReservationAssignmentTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_bigquery_reservation_assignment Terraform resource.
/// Manages a google_bigquery_reservation_assignment resource.
/// </summary>
public partial class GoogleBigqueryReservationAssignment(string name) : TerraformResource("google_bigquery_reservation_assignment", name)
{
    /// <summary>
    /// The resource which will use the reservation. E.g. projects/myproject, folders/123, organizations/456.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Assignee is required")]
    public required TerraformValue<string> Assignee
    {
        get => GetArgument<TerraformValue<string>>("assignee");
        set => SetArgument("assignee", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Types of job, which could be specified when using the reservation. Possible values: JOB_TYPE_UNSPECIFIED, PIPELINE, QUERY, CONTINUOUS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobType is required")]
    public required TerraformValue<string> JobType
    {
        get => GetArgument<TerraformValue<string>>("job_type");
        set => SetArgument("job_type", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The reservation for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reservation is required")]
    public required TerraformValue<string> Reservation
    {
        get => GetArgument<TerraformValue<string>>("reservation");
        set => SetArgument("reservation", value);
    }

    /// <summary>
    /// Output only. The resource name of the assignment.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Assignment will remain in PENDING state if no active capacity commitment is present. It will become ACTIVE when some capacity commitment becomes active.
    /// Possible values: STATE_UNSPECIFIED, PENDING, ACTIVE
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryReservationAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryReservationAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
