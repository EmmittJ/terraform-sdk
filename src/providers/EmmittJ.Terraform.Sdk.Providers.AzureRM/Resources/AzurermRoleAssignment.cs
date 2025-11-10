using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleAssignmentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    [TerraformPropertyName("condition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Condition { get; set; }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    [TerraformPropertyName("condition_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ConditionVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "condition_version");

    /// <summary>
    /// The delegated_managed_identity_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("delegated_managed_identity_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DelegatedManagedIdentityResourceId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformPropertyName("principal_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrincipalId { get; set; }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [TerraformPropertyName("principal_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrincipalType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "principal_type");

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [TerraformPropertyName("role_definition_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoleDefinitionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_definition_id");

    /// <summary>
    /// The role_definition_name attribute.
    /// </summary>
    [TerraformPropertyName("role_definition_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoleDefinitionName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_definition_name");

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

    /// <summary>
    /// The skip_service_principal_aad_check attribute.
    /// </summary>
    [TerraformPropertyName("skip_service_principal_aad_check")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SkipServicePrincipalAadCheck { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "skip_service_principal_aad_check");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRoleAssignmentTimeoutsBlock>? Timeouts { get; set; } = new();

}
