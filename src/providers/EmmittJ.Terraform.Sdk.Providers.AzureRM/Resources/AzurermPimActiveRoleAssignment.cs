using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermPimActiveRoleAssignmentScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// The start date/time of the role assignment
    /// </summary>
    [TerraformPropertyName("start_date_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StartDateTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "start_date_time");

}

/// <summary>
/// Block type for ticket in .
/// Nesting mode: list
/// </summary>
public class AzurermPimActiveRoleAssignmentTicketBlock : ITerraformBlock
{
    /// <summary>
    /// User-supplied ticket number to be included with the request
    /// </summary>
    [TerraformPropertyName("number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Number { get; set; }

    /// <summary>
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    [TerraformPropertyName("system")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? System { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPimActiveRoleAssignmentTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a azurerm_pim_active_role_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPimActiveRoleAssignment : TerraformResource
{
    public AzurermPimActiveRoleAssignment(string name) : base("azurerm_pim_active_role_assignment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The justification for this role assignment
    /// </summary>
    [TerraformPropertyName("justification")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Justification { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "justification");

    /// <summary>
    /// Object ID of the principal for this role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformPropertyName("principal_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrincipalId { get; set; }

    /// <summary>
    /// Role definition ID for this role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformPropertyName("role_definition_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleDefinitionId { get; set; }

    /// <summary>
    /// Scope for this role assignment, should be a valid resource ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AzurermPimActiveRoleAssignmentScheduleBlock>>? Schedule { get; set; } = new();

    /// <summary>
    /// Block for ticket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ticket block(s) allowed")]
    [TerraformPropertyName("ticket")]
    public TerraformList<TerraformBlock<AzurermPimActiveRoleAssignmentTicketBlock>>? Ticket { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPimActiveRoleAssignmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Type of principal to which the role will be assigned
    /// </summary>
    [TerraformPropertyName("principal_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "principal_type");

}
