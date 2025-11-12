using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPimEligibleRoleAssignmentScheduleBlock() : TerraformBlock("schedule")
{
    /// <summary>
    /// The start date/time
    /// </summary>
    [TerraformProperty("start_date_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartDateTime { get; set; }

}

/// <summary>
/// Block type for ticket in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPimEligibleRoleAssignmentTicketBlock() : TerraformBlock("ticket")
{
    /// <summary>
    /// User-supplied ticket number to be included with the request
    /// </summary>
    [TerraformProperty("number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Number { get; set; }

    /// <summary>
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    [TerraformProperty("system")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? System { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPimEligibleRoleAssignmentTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azurerm_pim_eligible_role_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermPimEligibleRoleAssignment : TerraformResource
{
    public AzurermPimEligibleRoleAssignment(string name) : base("azurerm_pim_eligible_role_assignment", name)
    {
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    [TerraformProperty("condition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    [TerraformProperty("condition_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConditionVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The justification for this eligible role assignment
    /// </summary>
    [TerraformProperty("justification")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Justification { get; set; }

    /// <summary>
    /// Object ID of the principal for this eligible role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformProperty("principal_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// Role definition ID for this eligible role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformProperty("role_definition_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleDefinitionId { get; set; }

    /// <summary>
    /// Scope for this eligible role assignment, should be a valid resource ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformProperty("schedule")]
    public TerraformList<AzurermPimEligibleRoleAssignmentScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for ticket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ticket block(s) allowed")]
    [TerraformProperty("ticket")]
    public TerraformList<AzurermPimEligibleRoleAssignmentTicketBlock> Ticket { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPimEligibleRoleAssignmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Type of principal to which the role will be assigned
    /// </summary>
    [TerraformProperty("principal_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrincipalType { get; }

}
