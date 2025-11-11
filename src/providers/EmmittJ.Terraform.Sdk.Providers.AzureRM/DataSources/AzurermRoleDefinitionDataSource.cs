using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRoleDefinitionDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_role_definition.
/// </summary>
public partial class AzurermRoleDefinitionDataSource : TerraformDataSource
{
    public AzurermRoleDefinitionDataSource(string name) : base("azurerm_role_definition", name)
    {
    }

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
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [TerraformProperty("role_definition_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RoleDefinitionId { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermRoleDefinitionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    [TerraformProperty("assignable_scopes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AssignableScopes { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformProperty("permissions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Permissions { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
