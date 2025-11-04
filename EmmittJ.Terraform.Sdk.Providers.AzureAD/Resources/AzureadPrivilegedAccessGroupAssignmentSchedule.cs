using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_privileged_access_group_assignment_schedule resource.
/// </summary>
public class AzureadPrivilegedAccessGroupAssignmentSchedule : TerraformResource
{
    public AzureadPrivilegedAccessGroupAssignmentSchedule(string name) : base("azuread_privileged_access_group_assignment_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The ID of the assignment to the group
    /// </summary>
    public string? AssignmentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assignment_type")?.Value;
        set => this.WithProperty("assignment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)
    /// </summary>
    public string? Duration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("duration")?.Value;
        set => this.WithProperty("duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public string? ExpirationDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_date")?.Value;
        set => this.WithProperty("expiration_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the Group representing the scope of the assignment
    /// </summary>
    public string? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id")?.Value;
        set => this.WithProperty("group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The justification for the assignment
    /// </summary>
    public string? Justification
    {
        get => GetProperty<TerraformLiteralProperty<string>>("justification")?.Value;
        set => this.WithProperty("justification", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Is the assignment permanent
    /// </summary>
    public bool? PermanentAssignment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("permanent_assignment")?.Value;
        set => this.WithProperty("permanent_assignment", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ID of the Principal assigned to the schedule
    /// </summary>
    public string? PrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_id")?.Value;
        set => this.WithProperty("principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public string? StartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_date")?.Value;
        set => this.WithProperty("start_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ticket number authorising the assignment
    /// </summary>
    public string? TicketNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ticket_number")?.Value;
        set => this.WithProperty("ticket_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ticket system authorising the assignment
    /// </summary>
    public string? TicketSystem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ticket_system")?.Value;
        set => this.WithProperty("ticket_system", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status of the schedule
    /// </summary>
    public TerraformExpression Status => this["status"];

}
