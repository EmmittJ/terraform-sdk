using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermPimEligibleRoleAssignmentScheduleBlock
{
    /// <summary>
    /// The start date/time
    /// </summary>
    [TerraformPropertyName("start_date_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StartDateTime { get; set; } = default!;

}

/// <summary>
/// Block type for ticket in .
/// Nesting mode: list
/// </summary>
public class AzurermPimEligibleRoleAssignmentTicketBlock
{
    /// <summary>
    /// User-supplied ticket number to be included with the request
    /// </summary>
    [TerraformPropertyName("number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Number { get; set; }

    /// <summary>
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    [TerraformPropertyName("system")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? System { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPimEligibleRoleAssignmentTimeoutsBlock
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

}

/// <summary>
/// Manages a azurerm_pim_eligible_role_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPimEligibleRoleAssignment : TerraformResource
{
    public AzurermPimEligibleRoleAssignment(string name) : base("azurerm_pim_eligible_role_assignment", name)
    {
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    [TerraformPropertyName("condition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    [TerraformPropertyName("condition_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConditionVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The justification for this eligible role assignment
    /// </summary>
    [TerraformPropertyName("justification")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Justification { get; set; } = default!;

    /// <summary>
    /// Object ID of the principal for this eligible role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformPropertyName("principal_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// Role definition ID for this eligible role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformPropertyName("role_definition_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleDefinitionId { get; set; }

    /// <summary>
    /// Scope for this eligible role assignment, should be a valid resource ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AzurermPimEligibleRoleAssignmentScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for ticket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ticket block(s) allowed")]
    [TerraformPropertyName("ticket")]
    public TerraformList<TerraformBlock<AzurermPimEligibleRoleAssignmentTicketBlock>>? Ticket { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPimEligibleRoleAssignmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Type of principal to which the role will be assigned
    /// </summary>
    [TerraformPropertyName("principal_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrincipalType => new TerraformReference(this, "principal_type");

}
