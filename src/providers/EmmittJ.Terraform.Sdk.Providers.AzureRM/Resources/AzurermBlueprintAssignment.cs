using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermBlueprintAssignmentIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBlueprintAssignmentTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_blueprint_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBlueprintAssignment : TerraformResource
{
    public AzurermBlueprintAssignment(string name) : base("azurerm_blueprint_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("blueprint_name");
        this.WithOutput("description");
        this.WithOutput("display_name");
        this.WithOutput("type");
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The lock_exclude_actions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LockExcludeActions
    {
        get => GetProperty<List<TerraformProperty<string>>>("lock_exclude_actions");
        set => this.WithProperty("lock_exclude_actions", value);
    }

    /// <summary>
    /// The lock_exclude_principals attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LockExcludePrincipals
    {
        get => GetProperty<List<TerraformProperty<string>>>("lock_exclude_principals");
        set => this.WithProperty("lock_exclude_principals", value);
    }

    /// <summary>
    /// The lock_mode attribute.
    /// </summary>
    public TerraformProperty<string>? LockMode
    {
        get => GetProperty<TerraformProperty<string>>("lock_mode");
        set => this.WithProperty("lock_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameter_values attribute.
    /// </summary>
    public TerraformProperty<string>? ParameterValues
    {
        get => GetProperty<TerraformProperty<string>>("parameter_values");
        set => this.WithProperty("parameter_values", value);
    }

    /// <summary>
    /// The resource_groups attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroups
    {
        get => GetProperty<TerraformProperty<string>>("resource_groups");
        set => this.WithProperty("resource_groups", value);
    }

    /// <summary>
    /// The target_subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetSubscriptionId is required")]
    public required TerraformProperty<string> TargetSubscriptionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_subscription_id");
        set => this.WithProperty("target_subscription_id", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    public required TerraformProperty<string> VersionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("version_id");
        set => this.WithProperty("version_id", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermBlueprintAssignmentIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermBlueprintAssignmentIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBlueprintAssignmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBlueprintAssignmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The blueprint_name attribute.
    /// </summary>
    public TerraformExpression BlueprintName => this["blueprint_name"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
