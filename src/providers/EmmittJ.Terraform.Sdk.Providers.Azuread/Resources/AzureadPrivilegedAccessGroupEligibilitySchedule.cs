using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadPrivilegedAccessGroupEligibilitySchedule.
/// Nesting mode: single
/// </summary>
public class AzureadPrivilegedAccessGroupEligibilityScheduleTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_privileged_access_group_eligibility_schedule Terraform resource.
/// Manages a azuread_privileged_access_group_eligibility_schedule resource.
/// </summary>
public partial class AzureadPrivilegedAccessGroupEligibilitySchedule(string name) : TerraformResource("azuread_privileged_access_group_eligibility_schedule", name)
{
    /// <summary>
    /// The ID of the assignment to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentType is required")]
    public required TerraformValue<string> AssignmentType
    {
        get => new TerraformReference<string>(this, "assignment_type");
        set => SetArgument("assignment_type", value);
    }

    /// <summary>
    /// The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
        set => SetArgument("expiration_date", value);
    }

    /// <summary>
    /// The ID of the Group representing the scope of the assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformValue<string> GroupId
    {
        get => new TerraformReference<string>(this, "group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The justification for the assignment
    /// </summary>
    public TerraformValue<string>? Justification
    {
        get => new TerraformReference<string>(this, "justification");
        set => SetArgument("justification", value);
    }

    /// <summary>
    /// Is the assignment permanent
    /// </summary>
    public TerraformValue<bool> PermanentAssignment
    {
        get => new TerraformReference<bool>(this, "permanent_assignment");
        set => SetArgument("permanent_assignment", value);
    }

    /// <summary>
    /// The ID of the Principal assigned to the schedule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    public TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The ticket number authorising the assignment
    /// </summary>
    public TerraformValue<string>? TicketNumber
    {
        get => new TerraformReference<string>(this, "ticket_number");
        set => SetArgument("ticket_number", value);
    }

    /// <summary>
    /// The ticket system authorising the assignment
    /// </summary>
    public TerraformValue<string>? TicketSystem
    {
        get => new TerraformReference<string>(this, "ticket_system");
        set => SetArgument("ticket_system", value);
    }

    /// <summary>
    /// The status of the schedule
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadPrivilegedAccessGroupEligibilityScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadPrivilegedAccessGroupEligibilityScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
