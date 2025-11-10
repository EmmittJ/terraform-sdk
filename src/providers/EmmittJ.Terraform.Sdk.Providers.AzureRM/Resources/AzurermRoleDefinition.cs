using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permissions in .
/// Nesting mode: list
/// </summary>
public class AzurermRoleDefinitionPermissionsBlock : ITerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [TerraformPropertyName("actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Actions { get; set; }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    [TerraformPropertyName("data_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DataActions { get; set; }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    [TerraformPropertyName("not_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? NotActions { get; set; }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    [TerraformPropertyName("not_data_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NotDataActions { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleDefinitionTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_role_definition resource.
/// </summary>
public class AzurermRoleDefinition : TerraformResource
{
    public AzurermRoleDefinition(string name) : base("azurerm_role_definition", name)
    {
    }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    [TerraformPropertyName("assignable_scopes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> AssignableScopes { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "assignable_scopes");

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [TerraformPropertyName("role_definition_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoleDefinitionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_definition_id");

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("permissions")]
    public TerraformList<TerraformBlock<AzurermRoleDefinitionPermissionsBlock>>? Permissions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermRoleDefinitionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The role_definition_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("role_definition_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleDefinitionResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_definition_resource_id");

}
