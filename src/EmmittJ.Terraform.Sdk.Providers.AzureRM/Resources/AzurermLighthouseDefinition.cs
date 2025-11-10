using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: set
/// </summary>
public class AzurermLighthouseDefinitionAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// The delegated_role_definition_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DelegatedRoleDefinitionIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("delegated_role_definition_ids");
        set => WithProperty("delegated_role_definition_ids", value);
    }

    /// <summary>
    /// The principal_display_name attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("principal_display_name");
        set => WithProperty("principal_display_name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformProperty<string> RoleDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_id");
        set => WithProperty("role_definition_id", value);
    }

}

/// <summary>
/// Block type for eligible_authorization in .
/// Nesting mode: set
/// </summary>
public class AzurermLighthouseDefinitionEligibleAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// The principal_display_name attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("principal_display_name");
        set => WithProperty("principal_display_name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformProperty<string> RoleDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_id");
        set => WithProperty("role_definition_id", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermLighthouseDefinitionPlanBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        get => GetProperty<TerraformProperty<string>>("product");
        set => WithProperty("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLighthouseDefinitionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_lighthouse_definition resource.
/// </summary>
public class AzurermLighthouseDefinition : TerraformResource
{
    public AzurermLighthouseDefinition(string name) : base("azurerm_lighthouse_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The lighthouse_definition_id attribute.
    /// </summary>
    public TerraformProperty<string>? LighthouseDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("lighthouse_definition_id");
        set => this.WithProperty("lighthouse_definition_id", value);
    }

    /// <summary>
    /// The managing_tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagingTenantId is required")]
    public required TerraformProperty<string> ManagingTenantId
    {
        get => GetProperty<TerraformProperty<string>>("managing_tenant_id");
        set => this.WithProperty("managing_tenant_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    public HashSet<AzurermLighthouseDefinitionAuthorizationBlock>? Authorization
    {
        get => GetProperty<HashSet<AzurermLighthouseDefinitionAuthorizationBlock>>("authorization");
        set => this.WithProperty("authorization", value);
    }

    /// <summary>
    /// Block for eligible_authorization.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLighthouseDefinitionEligibleAuthorizationBlock>? EligibleAuthorization
    {
        get => GetProperty<HashSet<AzurermLighthouseDefinitionEligibleAuthorizationBlock>>("eligible_authorization");
        set => this.WithProperty("eligible_authorization", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermLighthouseDefinitionPlanBlock>? Plan
    {
        get => GetProperty<List<AzurermLighthouseDefinitionPlanBlock>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLighthouseDefinitionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLighthouseDefinitionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
