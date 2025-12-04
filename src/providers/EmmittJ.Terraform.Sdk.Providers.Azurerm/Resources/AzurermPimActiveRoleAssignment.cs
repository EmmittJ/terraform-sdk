using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for schedule in AzurermPimActiveRoleAssignment.
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
    public TerraformValue<string> StartDateTime
    {
        get => GetArgument<TerraformValue<string>>("start_date_time") ?? AsReference("start_date_time");
        set => SetArgument("start_date_time", value);
    }

    /// <summary>
    /// Expiration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expiration block(s) allowed")]
    public TerraformList<AzurermPimActiveRoleAssignmentScheduleBlockExpirationBlock>? Expiration
    {
        get => GetArgument<TerraformList<AzurermPimActiveRoleAssignmentScheduleBlockExpirationBlock>>("expiration");
        set => SetArgument("expiration", value);
    }

}

/// <summary>
/// Block type for expiration in AzurermPimActiveRoleAssignmentScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermPimActiveRoleAssignmentScheduleBlockExpirationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expiration";

    /// <summary>
    /// The duration of the role assignment in days
    /// </summary>
    public TerraformValue<double> DurationDays
    {
        get => GetArgument<TerraformValue<double>>("duration_days") ?? AsReference("duration_days");
        set => SetArgument("duration_days", value);
    }

    /// <summary>
    /// The duration of the role assignment in hours
    /// </summary>
    public TerraformValue<double> DurationHours
    {
        get => GetArgument<TerraformValue<double>>("duration_hours") ?? AsReference("duration_hours");
        set => SetArgument("duration_hours", value);
    }

    /// <summary>
    /// The end date/time of the role assignment
    /// </summary>
    public TerraformValue<string> EndDateTime
    {
        get => GetArgument<TerraformValue<string>>("end_date_time") ?? AsReference("end_date_time");
        set => SetArgument("end_date_time", value);
    }

}


/// <summary>
/// Block type for ticket in AzurermPimActiveRoleAssignment.
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
    public TerraformValue<string>? Number
    {
        get => GetArgument<TerraformValue<string>>("number");
        set => SetArgument("number", value);
    }

    /// <summary>
    /// User-supplied ticket system name to be included with the request
    /// </summary>
    public TerraformValue<string>? System
    {
        get => GetArgument<TerraformValue<string>>("system");
        set => SetArgument("system", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPimActiveRoleAssignment.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_pim_active_role_assignment Terraform resource.
/// Manages a azurerm_pim_active_role_assignment resource.
/// </summary>
public partial class AzurermPimActiveRoleAssignment(string name) : TerraformResource("azurerm_pim_active_role_assignment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The justification for this role assignment
    /// </summary>
    public TerraformValue<string> Justification
    {
        get => GetArgument<TerraformValue<string>>("justification") ?? AsReference("justification");
        set => SetArgument("justification", value);
    }

    /// <summary>
    /// Object ID of the principal for this role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// Role definition ID for this role assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// Scope for this role assignment, should be a valid resource ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Type of principal to which the role will be assigned
    /// </summary>
    public TerraformValue<string> PrincipalType
        => AsReference("principal_type");

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<AzurermPimActiveRoleAssignmentScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AzurermPimActiveRoleAssignmentScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Ticket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ticket block(s) allowed")]
    public TerraformList<AzurermPimActiveRoleAssignmentTicketBlock>? Ticket
    {
        get => GetArgument<TerraformList<AzurermPimActiveRoleAssignmentTicketBlock>>("ticket");
        set => SetArgument("ticket", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPimActiveRoleAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPimActiveRoleAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
