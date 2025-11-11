using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMarketplaceRoleAssignmentTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a azurerm_marketplace_role_assignment resource.
/// </summary>
public partial class AzurermMarketplaceRoleAssignment : TerraformResource
{
    public AzurermMarketplaceRoleAssignment(string name) : base("azurerm_marketplace_role_assignment", name)
    {
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    [TerraformProperty("condition")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    [TerraformProperty("condition_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConditionVersion { get; set; }

    /// <summary>
    /// The delegated_managed_identity_resource_id attribute.
    /// </summary>
    [TerraformProperty("delegated_managed_identity_resource_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DelegatedManagedIdentityResourceId { get; set; }

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
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

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
    [TerraformProperty("role_definition_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoleDefinitionId { get; set; }

    /// <summary>
    /// The role_definition_name attribute.
    /// </summary>
    [TerraformProperty("role_definition_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoleDefinitionName { get; set; }

    /// <summary>
    /// The skip_service_principal_aad_check attribute.
    /// </summary>
    [TerraformProperty("skip_service_principal_aad_check")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipServicePrincipalAadCheck { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMarketplaceRoleAssignmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [TerraformProperty("principal_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrincipalType { get; }

}
