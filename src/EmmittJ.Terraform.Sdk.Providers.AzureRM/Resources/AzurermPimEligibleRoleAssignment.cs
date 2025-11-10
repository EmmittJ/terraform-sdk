using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermPimEligibleRoleAssignmentScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The start date/time
    /// </summary>
    public TerraformProperty<string>? StartDateTime
    {
        get => GetProperty<TerraformProperty<string>>("start_date_time");
        set => WithProperty("start_date_time", value);
    }

}

/// <summary>
/// Block type for ticket in .
/// Nesting mode: list
/// </summary>
public class AzurermPimEligibleRoleAssignmentTicketBlock : TerraformBlock
{
    /// <summary>
    /// User-supplied ticket number to be included with the request
    /// </summary>
    public TerraformProperty<string>? Number
    {
        get => GetProperty<TerraformProperty<string>>("number");
        set => WithProperty("number", value);
    }

    /// <summary>
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    public TerraformProperty<string>? System
    {
        get => GetProperty<TerraformProperty<string>>("system");
        set => WithProperty("system", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPimEligibleRoleAssignmentTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_pim_eligible_role_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPimEligibleRoleAssignment : TerraformResource
{
    public AzurermPimEligibleRoleAssignment(string name) : base("azurerm_pim_eligible_role_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("principal_type");
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformProperty<string>? Condition
    {
        get => GetProperty<TerraformProperty<string>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    public TerraformProperty<string>? ConditionVersion
    {
        get => GetProperty<TerraformProperty<string>>("condition_version");
        set => this.WithProperty("condition_version", value);
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
    /// The justification for this eligible role assignment
    /// </summary>
    public TerraformProperty<string>? Justification
    {
        get => GetProperty<TerraformProperty<string>>("justification");
        set => this.WithProperty("justification", value);
    }

    /// <summary>
    /// Object ID of the principal for this eligible role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => this.WithProperty("principal_id", value);
    }

    /// <summary>
    /// Role definition ID for this eligible role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformProperty<string> RoleDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_id");
        set => this.WithProperty("role_definition_id", value);
    }

    /// <summary>
    /// Scope for this eligible role assignment, should be a valid resource ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AzurermPimEligibleRoleAssignmentScheduleBlock>? Schedule
    {
        get => GetProperty<List<AzurermPimEligibleRoleAssignmentScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for ticket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ticket block(s) allowed")]
    public List<AzurermPimEligibleRoleAssignmentTicketBlock>? Ticket
    {
        get => GetProperty<List<AzurermPimEligibleRoleAssignmentTicketBlock>>("ticket");
        set => this.WithProperty("ticket", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPimEligibleRoleAssignmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPimEligibleRoleAssignmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Type of principal to which the role will be assigned
    /// </summary>
    public TerraformExpression PrincipalType => this["principal_type"];

}
