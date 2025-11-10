using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermPimActiveRoleAssignmentScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The start date/time of the role assignment
    /// </summary>
    public TerraformProperty<string>? StartDateTime
    {
        set => SetProperty("start_date_time", value);
    }

}

/// <summary>
/// Block type for ticket in .
/// Nesting mode: list
/// </summary>
public class AzurermPimActiveRoleAssignmentTicketBlock : TerraformBlock
{
    /// <summary>
    /// User-supplied ticket number to be included with the request
    /// </summary>
    public TerraformProperty<string>? Number
    {
        set => SetProperty("number", value);
    }

    /// <summary>
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    public TerraformProperty<string>? System
    {
        set => SetProperty("system", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPimActiveRoleAssignmentTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_pim_active_role_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPimActiveRoleAssignment : TerraformResource
{
    public AzurermPimActiveRoleAssignment(string name) : base("azurerm_pim_active_role_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("principal_type");
        SetOutput("id");
        SetOutput("justification");
        SetOutput("principal_id");
        SetOutput("role_definition_id");
        SetOutput("scope");
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
    /// The justification for this role assignment
    /// </summary>
    public TerraformProperty<string> Justification
    {
        get => GetRequiredOutput<TerraformProperty<string>>("justification");
        set => SetProperty("justification", value);
    }

    /// <summary>
    /// Object ID of the principal for this role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_id");
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// Role definition ID for this role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformProperty<string> RoleDefinitionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_definition_id");
        set => SetProperty("role_definition_id", value);
    }

    /// <summary>
    /// Scope for this role assignment, should be a valid resource ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<AzurermPimActiveRoleAssignmentScheduleBlock>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// Block for ticket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ticket block(s) allowed")]
    public List<AzurermPimActiveRoleAssignmentTicketBlock>? Ticket
    {
        set => SetProperty("ticket", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPimActiveRoleAssignmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Type of principal to which the role will be assigned
    /// </summary>
    public TerraformExpression PrincipalType => this["principal_type"];

}
