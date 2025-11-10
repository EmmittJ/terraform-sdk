using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadPrivilegedAccessGroupAssignmentScheduleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_privileged_access_group_assignment_schedule resource.
/// </summary>
public class AzureadPrivilegedAccessGroupAssignmentSchedule : TerraformResource
{
    public AzureadPrivilegedAccessGroupAssignmentSchedule(string name) : base("azuread_privileged_access_group_assignment_schedule", name)
    {
    }

    /// <summary>
    /// The ID of the assignment to the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentType is required")]
    [TerraformPropertyName("assignment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AssignmentType { get; set; }

    /// <summary>
    /// The duration of the assignment, formatted as an ISO8601 duration string (e.g. P3D for 3 days)
    /// </summary>
    [TerraformPropertyName("duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Duration { get; set; }

    /// <summary>
    /// The date that this assignment expires, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExpirationDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_date");

    /// <summary>
    /// The ID of the Group representing the scope of the assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    [TerraformPropertyName("group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The justification for the assignment
    /// </summary>
    [TerraformPropertyName("justification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Justification { get; set; }

    /// <summary>
    /// Is the assignment permanent
    /// </summary>
    [TerraformPropertyName("permanent_assignment")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PermanentAssignment { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "permanent_assignment");

    /// <summary>
    /// The ID of the Principal assigned to the schedule
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformPropertyName("principal_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrincipalId { get; set; }

    /// <summary>
    /// The date that this assignment starts, formatted as an RFC3339 date string in UTC (e.g. 2018-01-01T01:02:03Z)
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_date");

    /// <summary>
    /// The ticket number authorising the assignment
    /// </summary>
    [TerraformPropertyName("ticket_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TicketNumber { get; set; }

    /// <summary>
    /// The ticket system authorising the assignment
    /// </summary>
    [TerraformPropertyName("ticket_system")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TicketSystem { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadPrivilegedAccessGroupAssignmentScheduleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The status of the schedule
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
