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
    public TerraformLiteralProperty<string>? AssignmentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("assignment_type");
        set => this.WithProperty("assignment_type", value);
    }

    /// <summary>
    /// The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)
    /// </summary>
    public TerraformLiteralProperty<string>? Duration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("duration");
        set => this.WithProperty("duration", value);
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformLiteralProperty<string>? ExpirationDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_date");
        set => this.WithProperty("expiration_date", value);
    }

    /// <summary>
    /// The ID of the Group representing the scope of the assignment
    /// </summary>
    public TerraformLiteralProperty<string>? GroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
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
    /// The justification for the assignment
    /// </summary>
    public TerraformLiteralProperty<string>? Justification
    {
        get => GetProperty<TerraformLiteralProperty<string>>("justification");
        set => this.WithProperty("justification", value);
    }

    /// <summary>
    /// Is the assignment permanent
    /// </summary>
    public TerraformLiteralProperty<bool>? PermanentAssignment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("permanent_assignment");
        set => this.WithProperty("permanent_assignment", value);
    }

    /// <summary>
    /// The ID of the Principal assigned to the schedule
    /// </summary>
    public TerraformLiteralProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_id");
        set => this.WithProperty("principal_id", value);
    }

    /// <summary>
    /// The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformLiteralProperty<string>? StartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_date");
        set => this.WithProperty("start_date", value);
    }

    /// <summary>
    /// The ticket number authorising the assignment
    /// </summary>
    public TerraformLiteralProperty<string>? TicketNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ticket_number");
        set => this.WithProperty("ticket_number", value);
    }

    /// <summary>
    /// The ticket system authorising the assignment
    /// </summary>
    public TerraformLiteralProperty<string>? TicketSystem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ticket_system");
        set => this.WithProperty("ticket_system", value);
    }

    /// <summary>
    /// The status of the schedule
    /// </summary>
    public TerraformExpression Status => this["status"];

}
