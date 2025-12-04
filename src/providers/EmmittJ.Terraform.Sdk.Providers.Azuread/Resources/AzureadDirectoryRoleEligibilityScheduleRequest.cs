using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadDirectoryRoleEligibilityScheduleRequest.
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleEligibilityScheduleRequestTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_directory_role_eligibility_schedule_request Terraform resource.
/// Manages a azuread_directory_role_eligibility_schedule_request resource.
/// </summary>
public partial class AzureadDirectoryRoleEligibilityScheduleRequest(string name) : TerraformResource("azuread_directory_role_eligibility_schedule_request", name)
{
    /// <summary>
    /// Identifier of the directory object representing the scope of the role eligibility schedule request
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryScopeId is required")]
    public required TerraformValue<string> DirectoryScopeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("directory_scope_id");
        set => SetArgument("directory_scope_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Justification for why the role is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Justification is required")]
    public required TerraformValue<string> Justification
    {
        get => GetRequiredArgument<TerraformValue<string>>("justification");
        set => SetArgument("justification", value);
    }

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The object ID of the directory role for this role eligibility schedule request
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadDirectoryRoleEligibilityScheduleRequestTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadDirectoryRoleEligibilityScheduleRequestTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
