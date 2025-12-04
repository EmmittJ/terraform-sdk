using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMarketplaceRoleAssignment.
/// Nesting mode: single
/// </summary>
public class AzurermMarketplaceRoleAssignmentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_marketplace_role_assignment Terraform resource.
/// Manages a azurerm_marketplace_role_assignment resource.
/// </summary>
public partial class AzurermMarketplaceRoleAssignment(string name) : TerraformResource("azurerm_marketplace_role_assignment", name)
{
    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformValue<string>? Condition
    {
        get => GetArgument<TerraformValue<string>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    public TerraformValue<string>? ConditionVersion
    {
        get => GetArgument<TerraformValue<string>>("condition_version");
        set => SetArgument("condition_version", value);
    }

    /// <summary>
    /// The delegated_managed_identity_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? DelegatedManagedIdentityResourceId
    {
        get => GetArgument<TerraformValue<string>>("delegated_managed_identity_resource_id");
        set => SetArgument("delegated_managed_identity_resource_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => GetArgument<TerraformValue<string>>("principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    public TerraformValue<string>? RoleDefinitionId
    {
        get => GetArgument<TerraformValue<string>>("role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The role_definition_name attribute.
    /// </summary>
    public TerraformValue<string>? RoleDefinitionName
    {
        get => GetArgument<TerraformValue<string>>("role_definition_name");
        set => SetArgument("role_definition_name", value);
    }

    /// <summary>
    /// The skip_service_principal_aad_check attribute.
    /// </summary>
    public TerraformValue<bool>? SkipServicePrincipalAadCheck
    {
        get => GetArgument<TerraformValue<bool>>("skip_service_principal_aad_check");
        set => SetArgument("skip_service_principal_aad_check", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformValue<string> PrincipalType
        => AsReference("principal_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMarketplaceRoleAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMarketplaceRoleAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
