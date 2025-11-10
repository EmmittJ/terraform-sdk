using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadPrivilegedAccessGroupEligibilityScheduleTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_privileged_access_group_eligibility_schedule resource.
/// </summary>
public class AzureadPrivilegedAccessGroupEligibilitySchedule : TerraformResource
{
    public AzureadPrivilegedAccessGroupEligibilitySchedule(string name) : base("azuread_privileged_access_group_eligibility_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("status");
    }

    /// <summary>
    /// The ID of the assignment to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentType is required")]
    public required TerraformProperty<string> AssignmentType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("assignment_type");
        set => this.WithProperty("assignment_type", value);
    }

    /// <summary>
    /// The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        get => GetProperty<TerraformProperty<string>>("duration");
        set => this.WithProperty("duration", value);
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformProperty<string>? ExpirationDate
    {
        get => GetProperty<TerraformProperty<string>>("expiration_date");
        set => this.WithProperty("expiration_date", value);
    }

    /// <summary>
    /// The ID of the Group representing the scope of the assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformProperty<string> GroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
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
    /// The justification for the assignment
    /// </summary>
    public TerraformProperty<string>? Justification
    {
        get => GetProperty<TerraformProperty<string>>("justification");
        set => this.WithProperty("justification", value);
    }

    /// <summary>
    /// Is the assignment permanent
    /// </summary>
    public TerraformProperty<bool>? PermanentAssignment
    {
        get => GetProperty<TerraformProperty<bool>>("permanent_assignment");
        set => this.WithProperty("permanent_assignment", value);
    }

    /// <summary>
    /// The ID of the Principal assigned to the schedule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("principal_id");
        set => this.WithProperty("principal_id", value);
    }

    /// <summary>
    /// The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformProperty<string>? StartDate
    {
        get => GetProperty<TerraformProperty<string>>("start_date");
        set => this.WithProperty("start_date", value);
    }

    /// <summary>
    /// The ticket number authorising the assignment
    /// </summary>
    public TerraformProperty<string>? TicketNumber
    {
        get => GetProperty<TerraformProperty<string>>("ticket_number");
        set => this.WithProperty("ticket_number", value);
    }

    /// <summary>
    /// The ticket system authorising the assignment
    /// </summary>
    public TerraformProperty<string>? TicketSystem
    {
        get => GetProperty<TerraformProperty<string>>("ticket_system");
        set => this.WithProperty("ticket_system", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadPrivilegedAccessGroupEligibilityScheduleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadPrivilegedAccessGroupEligibilityScheduleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The status of the schedule
    /// </summary>
    public TerraformExpression Status => this["status"];

}
