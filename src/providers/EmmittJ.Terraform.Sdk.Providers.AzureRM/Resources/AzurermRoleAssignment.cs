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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleAssignmentTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_role_assignment resource.
/// </summary>
public class AzurermRoleAssignment : TerraformResource
{
    public AzurermRoleAssignment(string name) : base("azurerm_role_assignment", name)
    {
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    [TerraformArgument("condition")]
    public TerraformValue<string>? Condition
    {
        get => new TerraformReference<string>(this, "condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    [TerraformArgument("condition_version")]
    public TerraformValue<string> ConditionVersion
    {
        get => new TerraformReference<string>(this, "condition_version");
        set => SetArgument("condition_version", value);
    }

    /// <summary>
    /// The delegated_managed_identity_resource_id attribute.
    /// </summary>
    [TerraformArgument("delegated_managed_identity_resource_id")]
    public TerraformValue<string>? DelegatedManagedIdentityResourceId
    {
        get => new TerraformReference<string>(this, "delegated_managed_identity_resource_id");
        set => SetArgument("delegated_managed_identity_resource_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformArgument("principal_id")]
    public required TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [TerraformArgument("principal_type")]
    public TerraformValue<string> PrincipalType
    {
        get => new TerraformReference<string>(this, "principal_type");
        set => SetArgument("principal_type", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [TerraformArgument("role_definition_id")]
    public TerraformValue<string> RoleDefinitionId
    {
        get => new TerraformReference<string>(this, "role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The role_definition_name attribute.
    /// </summary>
    [TerraformArgument("role_definition_name")]
    public TerraformValue<string> RoleDefinitionName
    {
        get => new TerraformReference<string>(this, "role_definition_name");
        set => SetArgument("role_definition_name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformArgument("scope")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The skip_service_principal_aad_check attribute.
    /// </summary>
    [TerraformArgument("skip_service_principal_aad_check")]
    public TerraformValue<bool> SkipServicePrincipalAadCheck
    {
        get => new TerraformReference<bool>(this, "skip_service_principal_aad_check");
        set => SetArgument("skip_service_principal_aad_check", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRoleAssignmentTimeoutsBlock Timeouts { get; set; } = new();

}
