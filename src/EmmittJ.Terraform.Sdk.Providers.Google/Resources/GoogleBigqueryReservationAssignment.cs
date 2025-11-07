using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The resource which will use the reservation. E.g. projects/myproject, folders/123, organizations/456.
    /// </summary>
    public TerraformLiteralProperty<string>? Assignee
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assignee");
        set => this.WithProperty("assignee", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Types of job, which could be specified when using the reservation. Possible values: JOB_TYPE_UNSPECIFIED, PIPELINE, QUERY, CONTINUOUS
    /// </summary>
    public TerraformLiteralProperty<string>? JobType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_type");
        set => this.WithProperty("job_type", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The reservation for the resource
    /// </summary>
    public TerraformLiteralProperty<string>? Reservation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reservation");
        set => this.WithProperty("reservation", value);
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
