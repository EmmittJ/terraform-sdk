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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("status");
        SetOutput("assignment_type");
        SetOutput("duration");
        SetOutput("expiration_date");
        SetOutput("group_id");
        SetOutput("id");
        SetOutput("justification");
        SetOutput("permanent_assignment");
        SetOutput("principal_id");
        SetOutput("start_date");
        SetOutput("ticket_number");
        SetOutput("ticket_system");
    }

    /// <summary>
    /// The ID of the assignment to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentType is required")]
    public required TerraformProperty<string> AssignmentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("assignment_type");
        set => SetProperty("assignment_type", value);
    }

    /// <summary>
    /// The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)
    /// </summary>
    public TerraformProperty<string> Duration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("duration");
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformProperty<string> ExpirationDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiration_date");
        set => SetProperty("expiration_date", value);
    }

    /// <summary>
    /// The ID of the Group representing the scope of the assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformProperty<string> GroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_id");
        set => SetProperty("group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The justification for the assignment
    /// </summary>
    public TerraformProperty<string> Justification
    {
        get => GetRequiredOutput<TerraformProperty<string>>("justification");
        set => SetProperty("justification", value);
    }

    /// <summary>
    /// Is the assignment permanent
    /// </summary>
    public TerraformProperty<bool> PermanentAssignment
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("permanent_assignment");
        set => SetProperty("permanent_assignment", value);
    }

    /// <summary>
    /// The ID of the Principal assigned to the schedule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_id");
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformProperty<string> StartDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_date");
        set => SetProperty("start_date", value);
    }

    /// <summary>
    /// The ticket number authorising the assignment
    /// </summary>
    public TerraformProperty<string> TicketNumber
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ticket_number");
        set => SetProperty("ticket_number", value);
    }

    /// <summary>
    /// The ticket system authorising the assignment
    /// </summary>
    public TerraformProperty<string> TicketSystem
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ticket_system");
        set => SetProperty("ticket_system", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadPrivilegedAccessGroupEligibilityScheduleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The status of the schedule
    /// </summary>
    public TerraformExpression Status => this["status"];

}
