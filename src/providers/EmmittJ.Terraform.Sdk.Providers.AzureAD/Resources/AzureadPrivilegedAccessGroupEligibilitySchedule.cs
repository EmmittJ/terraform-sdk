using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadPrivilegedAccessGroupEligibilityScheduleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_privileged_access_group_eligibility_schedule resource.
/// </summary>
public class AzureadPrivilegedAccessGroupEligibilitySchedule : TerraformResource
{
    public AzureadPrivilegedAccessGroupEligibilitySchedule(string name) : base("azuread_privileged_access_group_eligibility_schedule", name)
    {
    }

    /// <summary>
    /// The ID of the assignment to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentType is required")]
    [TerraformPropertyName("assignment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AssignmentType { get; set; }

    /// <summary>
    /// The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)
    /// </summary>
    [TerraformPropertyName("duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Duration { get; set; }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExpirationDate { get; set; } = default!;

    /// <summary>
    /// The ID of the Group representing the scope of the assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    [TerraformPropertyName("group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The justification for the assignment
    /// </summary>
    [TerraformPropertyName("justification")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Justification { get; set; }

    /// <summary>
    /// Is the assignment permanent
    /// </summary>
    [TerraformPropertyName("permanent_assignment")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> PermanentAssignment { get; set; } = default!;

    /// <summary>
    /// The ID of the Principal assigned to the schedule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformPropertyName("principal_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StartDate { get; set; } = default!;

    /// <summary>
    /// The ticket number authorising the assignment
    /// </summary>
    [TerraformPropertyName("ticket_number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TicketNumber { get; set; }

    /// <summary>
    /// The ticket system authorising the assignment
    /// </summary>
    [TerraformPropertyName("ticket_system")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TicketSystem { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadPrivilegedAccessGroupEligibilityScheduleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The status of the schedule
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
