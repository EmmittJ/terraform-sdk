using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryReservationAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_bigquery_reservation_assignment resource.
/// </summary>
public class GoogleBigqueryReservationAssignment : TerraformResource
{
    public GoogleBigqueryReservationAssignment(string name) : base("google_bigquery_reservation_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
        this.WithOutput("state");
    }

    /// <summary>
    /// The resource which will use the reservation. E.g. projects/myproject, folders/123, organizations/456.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Assignee is required")]
    public required TerraformProperty<string> Assignee
    {
        get => GetRequiredProperty<TerraformProperty<string>>("assignee");
        set => this.WithProperty("assignee", value);
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
    /// Types of job, which could be specified when using the reservation. Possible values: JOB_TYPE_UNSPECIFIED, PIPELINE, QUERY, CONTINUOUS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobType is required")]
    public required TerraformProperty<string> JobType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("job_type");
        set => this.WithProperty("job_type", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The reservation for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reservation is required")]
    public required TerraformProperty<string> Reservation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("reservation");
        set => this.WithProperty("reservation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryReservationAssignmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryReservationAssignmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The resource name of the assignment.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Assignment will remain in PENDING state if no active capacity commitment is present. It will become ACTIVE when some capacity commitment becomes active.
    /// Possible values: STATE_UNSPECIFIED, PENDING, ACTIVE
    /// </summary>
    public TerraformExpression State => this["state"];

}
