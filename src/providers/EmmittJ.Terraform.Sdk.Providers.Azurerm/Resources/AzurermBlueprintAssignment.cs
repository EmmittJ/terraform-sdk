using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermBlueprintAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermBlueprintAssignmentIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermBlueprintAssignment.
/// Nesting mode: single
/// </summary>
public class AzurermBlueprintAssignmentTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_blueprint_assignment Terraform resource.
/// Manages a azurerm_blueprint_assignment resource.
/// </summary>
public partial class AzurermBlueprintAssignment(string name) : TerraformResource("azurerm_blueprint_assignment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The lock_exclude_actions attribute.
    /// </summary>
    public TerraformList<string>? LockExcludeActions
    {
        get => GetArgument<TerraformList<string>>("lock_exclude_actions");
        set => SetArgument("lock_exclude_actions", value);
    }

    /// <summary>
    /// The lock_exclude_principals attribute.
    /// </summary>
    public TerraformList<string>? LockExcludePrincipals
    {
        get => GetArgument<TerraformList<string>>("lock_exclude_principals");
        set => SetArgument("lock_exclude_principals", value);
    }

    /// <summary>
    /// The lock_mode attribute.
    /// </summary>
    public TerraformValue<string>? LockMode
    {
        get => GetArgument<TerraformValue<string>>("lock_mode");
        set => SetArgument("lock_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameter_values attribute.
    /// </summary>
    public TerraformValue<string>? ParameterValues
    {
        get => GetArgument<TerraformValue<string>>("parameter_values");
        set => SetArgument("parameter_values", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public TerraformValue<string>? ResourceGroups
    {
        get => GetArgument<TerraformValue<string>>("resource_groups");
        set => SetArgument("resource_groups", value);
    }

    /// <summary>
    /// The target_subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetSubscriptionId is required")]
    public required TerraformValue<string> TargetSubscriptionId
    {
        get => GetArgument<TerraformValue<string>>("target_subscription_id");
        set => SetArgument("target_subscription_id", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    public required TerraformValue<string> VersionId
    {
        get => GetArgument<TerraformValue<string>>("version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// The blueprint_name attribute.
    /// </summary>
    public TerraformValue<string> BlueprintName
        => AsReference("blueprint_name");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public required TerraformList<AzurermBlueprintAssignmentIdentityBlock> Identity
    {
        get => GetRequiredArgument<TerraformList<AzurermBlueprintAssignmentIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBlueprintAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBlueprintAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
