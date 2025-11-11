using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permissions in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRoleDefinitionPermissionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [TerraformProperty("actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Actions { get; set; }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    [TerraformProperty("data_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DataActions { get; set; }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    [TerraformProperty("not_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? NotActions { get; set; }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    [TerraformProperty("not_data_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? NotDataActions { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRoleDefinitionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_role_definition resource.
/// </summary>
public partial class AzurermRoleDefinition : TerraformResource
{
    public AzurermRoleDefinition(string name) : base("azurerm_role_definition", name)
    {
    }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    [TerraformProperty("assignable_scopes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> AssignableScopes { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [TerraformProperty("role_definition_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoleDefinitionId { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("permissions")]
    public partial TerraformList<TerraformBlock<AzurermRoleDefinitionPermissionsBlock>>? Permissions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermRoleDefinitionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The role_definition_resource_id attribute.
    /// </summary>
    [TerraformProperty("role_definition_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RoleDefinitionResourceId { get; }

}
