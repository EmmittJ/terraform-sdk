using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleEligibilityScheduleRequestTimeoutsBlock : TerraformBlock
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
/// Manages a azuread_directory_role_eligibility_schedule_request resource.
/// </summary>
public class AzureadDirectoryRoleEligibilityScheduleRequest : TerraformResource
{
    public AzureadDirectoryRoleEligibilityScheduleRequest(string name) : base("azuread_directory_role_eligibility_schedule_request", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("directory_scope_id");
        SetOutput("id");
        SetOutput("justification");
        SetOutput("principal_id");
        SetOutput("role_definition_id");
    }

    /// <summary>
    /// Identifier of the directory object representing the scope of the role eligibility schedule request
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryScopeId is required")]
    public required TerraformProperty<string> DirectoryScopeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_scope_id");
        set => SetProperty("directory_scope_id", value);
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
    /// Justification for why the role is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Justification is required")]
    public required TerraformProperty<string> Justification
    {
        get => GetRequiredOutput<TerraformProperty<string>>("justification");
        set => SetProperty("justification", value);
    }

    /// <summary>
    /// The object ID of the member principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_id");
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The object ID of the directory role for this role eligibility schedule request
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformProperty<string> RoleDefinitionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_definition_id");
        set => SetProperty("role_definition_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadDirectoryRoleEligibilityScheduleRequestTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
