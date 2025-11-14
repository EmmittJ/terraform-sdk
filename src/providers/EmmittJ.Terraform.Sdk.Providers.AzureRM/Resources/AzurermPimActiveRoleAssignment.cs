using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermPimActiveRoleAssignmentScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The start date/time of the role assignment
    /// </summary>
    [TerraformArgument("start_date_time")]
    public TerraformValue<string> StartDateTime
    {
        get => new TerraformReference<string>(this, "start_date_time");
        set => SetArgument("start_date_time", value);
    }

}

/// <summary>
/// Block type for ticket in .
/// Nesting mode: list
/// </summary>
public class AzurermPimActiveRoleAssignmentTicketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ticket";

    /// <summary>
    /// User-supplied ticket number to be included with the request
    /// </summary>
    [TerraformArgument("number")]
    public TerraformValue<string>? Number
    {
        get => new TerraformReference<string>(this, "number");
        set => SetArgument("number", value);
    }

    /// <summary>
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    [TerraformArgument("system")]
    public TerraformValue<string>? System
    {
        get => new TerraformReference<string>(this, "system");
        set => SetArgument("system", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPimActiveRoleAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The justification for this role assignment
    /// </summary>
    [TerraformArgument("justification")]
    public TerraformValue<string> Justification
    {
        get => new TerraformReference<string>(this, "justification");
        set => SetArgument("justification", value);
    }

    /// <summary>
    /// Object ID of the principal for this role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformArgument("principal_id")]
    public required TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// Role definition ID for this role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformArgument("role_definition_id")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => new TerraformReference<string>(this, "role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// Scope for this role assignment, should be a valid resource ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformArgument("scope")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformArgument("schedule")]
    public TerraformList<AzurermPimActiveRoleAssignmentScheduleBlock> Schedule { get; set; } = new();

    /// <summary>
    /// Block for ticket.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ticket block(s) allowed")]
    [TerraformArgument("ticket")]
    public TerraformList<AzurermPimActiveRoleAssignmentTicketBlock> Ticket { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPimActiveRoleAssignmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Type of principal to which the role will be assigned
    /// </summary>
    [TerraformArgument("principal_type")]
    public TerraformValue<string> PrincipalType
    {
        get => new TerraformReference<string>(this, "principal_type");
    }

}
