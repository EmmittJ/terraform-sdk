using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPolicyDefinitionBuiltInDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_policy_definition_built_in.
/// </summary>
public partial class AzurermPolicyDefinitionBuiltInDataSource : TerraformDataSource
{
    public AzurermPolicyDefinitionBuiltInDataSource(string name) : base("azurerm_policy_definition_built_in", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The management_group_name attribute.
    /// </summary>
    [TerraformProperty("management_group_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagementGroupName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPolicyDefinitionBuiltInDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Metadata { get; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Mode { get; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Parameters { get; }

    /// <summary>
    /// The policy_rule attribute.
    /// </summary>
    [TerraformProperty("policy_rule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PolicyRule { get; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformProperty("policy_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PolicyType { get; }

    /// <summary>
    /// The role_definition_ids attribute.
    /// </summary>
    [TerraformProperty("role_definition_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> RoleDefinitionIds { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
