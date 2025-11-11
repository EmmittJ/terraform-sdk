using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLighthouseDefinitionAuthorizationBlock : TerraformBlockBase
{
    /// <summary>
    /// The delegated_role_definition_ids attribute.
    /// </summary>
    [TerraformProperty("delegated_role_definition_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DelegatedRoleDefinitionIds { get; set; }

    /// <summary>
    /// The principal_display_name attribute.
    /// </summary>
    [TerraformProperty("principal_display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrincipalDisplayName { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformProperty("principal_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformProperty("role_definition_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleDefinitionId { get; set; }

}

/// <summary>
/// Block type for eligible_authorization in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLighthouseDefinitionEligibleAuthorizationBlock : TerraformBlockBase
{
    /// <summary>
    /// The principal_display_name attribute.
    /// </summary>
    [TerraformProperty("principal_display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrincipalDisplayName { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformProperty("principal_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrincipalId { get; set; }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformProperty("role_definition_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleDefinitionId { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLighthouseDefinitionPlanBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformProperty("product")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLighthouseDefinitionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_lighthouse_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLighthouseDefinition : TerraformResource
{
    public AzurermLighthouseDefinition(string name) : base("azurerm_lighthouse_definition", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lighthouse_definition_id attribute.
    /// </summary>
    [TerraformProperty("lighthouse_definition_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LighthouseDefinitionId { get; set; }

    /// <summary>
    /// The managing_tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagingTenantId is required")]
    [TerraformProperty("managing_tenant_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ManagingTenantId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    [TerraformProperty("authorization")]
    public TerraformSet<TerraformBlock<AzurermLighthouseDefinitionAuthorizationBlock>>? Authorization { get; set; }

    /// <summary>
    /// Block for eligible_authorization.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("eligible_authorization")]
    public TerraformSet<TerraformBlock<AzurermLighthouseDefinitionEligibleAuthorizationBlock>>? EligibleAuthorization { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformProperty("plan")]
    public TerraformList<TerraformBlock<AzurermLighthouseDefinitionPlanBlock>>? Plan { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLighthouseDefinitionTimeoutsBlock>? Timeouts { get; set; }

}
