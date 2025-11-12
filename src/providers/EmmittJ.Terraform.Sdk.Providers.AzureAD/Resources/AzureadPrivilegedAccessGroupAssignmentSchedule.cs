using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadPrivilegedAccessGroupAssignmentScheduleTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_privileged_access_group_assignment_schedule resource.
/// </summary>
public partial class AzureadPrivilegedAccessGroupAssignmentSchedule : TerraformResource
{
    public AzureadPrivilegedAccessGroupAssignmentSchedule(string name) : base("azuread_privileged_access_group_assignment_schedule", name)
    {
    }

    /// <summary>
    /// The ID of the assignment to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentType is required")]
    [TerraformProperty("assignment_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AssignmentType { get; set; }

    /// <summary>
    /// The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)
    /// </summary>
    [TerraformProperty("duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Duration { get; set; }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ExpirationDate { get; set; }

    /// <summary>
    /// The ID of the Group representing the scope of the assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    [TerraformProperty("group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The justification for the assignment
    /// </summary>
    [TerraformProperty("justification")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Justification { get; set; }

    /// <summary>
    /// Is the assignment permanent
    /// </summary>
    [TerraformProperty("permanent_assignment")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> PermanentAssignment { get; set; }

    /// <summary>
    /// The ID of the Principal assigned to the schedule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformProperty("principal_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [TerraformProperty("start_date")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartDate { get; set; }

    /// <summary>
    /// The ticket number authorising the assignment
    /// </summary>
    [TerraformProperty("ticket_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TicketNumber { get; set; }

    /// <summary>
    /// The ticket system authorising the assignment
    /// </summary>
    [TerraformProperty("ticket_system")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TicketSystem { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadPrivilegedAccessGroupAssignmentScheduleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The status of the schedule
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
