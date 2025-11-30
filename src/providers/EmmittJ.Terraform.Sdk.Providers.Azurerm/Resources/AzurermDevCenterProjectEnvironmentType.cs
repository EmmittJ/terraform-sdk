using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermDevCenterProjectEnvironmentType.
/// Nesting mode: list
/// </summary>
public class AzurermDevCenterProjectEnvironmentTypeIdentityBlock : TerraformBlock
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDevCenterProjectEnvironmentType.
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectEnvironmentTypeTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user_role_assignment in AzurermDevCenterProjectEnvironmentType.
/// Nesting mode: set
/// </summary>
public class AzurermDevCenterProjectEnvironmentTypeUserRoleAssignmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_role_assignment";

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    public required TerraformSet<string> Roles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "roles").ResolveNodes(ctx));
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformValue<string> UserId
    {
        get => new TerraformReference<string>(this, "user_id");
        set => SetArgument("user_id", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_center_project_environment_type Terraform resource.
/// Manages a azurerm_dev_center_project_environment_type resource.
/// </summary>
public partial class AzurermDevCenterProjectEnvironmentType(string name) : TerraformResource("azurerm_dev_center_project_environment_type", name)
{
    /// <summary>
    /// The creator_role_assignment_roles attribute.
    /// </summary>
    public TerraformSet<string>? CreatorRoleAssignmentRoles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "creator_role_assignment_roles").ResolveNodes(ctx));
        set => SetArgument("creator_role_assignment_roles", value);
    }

    /// <summary>
    /// The deployment_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentTargetId is required")]
    public required TerraformValue<string> DeploymentTargetId
    {
        get => new TerraformReference<string>(this, "deployment_target_id");
        set => SetArgument("deployment_target_id", value);
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    public required TerraformValue<string> DevCenterProjectId
    {
        get => new TerraformReference<string>(this, "dev_center_project_id");
        set => SetArgument("dev_center_project_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public required TerraformList<AzurermDevCenterProjectEnvironmentTypeIdentityBlock> Identity
    {
        get => GetRequiredArgument<TerraformList<AzurermDevCenterProjectEnvironmentTypeIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevCenterProjectEnvironmentTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterProjectEnvironmentTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserRoleAssignment block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermDevCenterProjectEnvironmentTypeUserRoleAssignmentBlock>? UserRoleAssignment
    {
        get => GetArgument<TerraformSet<AzurermDevCenterProjectEnvironmentTypeUserRoleAssignmentBlock>>("user_role_assignment");
        set => SetArgument("user_role_assignment", value);
    }

}
