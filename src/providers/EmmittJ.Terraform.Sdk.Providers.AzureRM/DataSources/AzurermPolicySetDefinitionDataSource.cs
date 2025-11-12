using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPolicySetDefinitionDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_policy_set_definition.
/// </summary>
public partial class AzurermPolicySetDefinitionDataSource : TerraformDataSource
{
    public AzurermPolicySetDefinitionDataSource(string name) : base("azurerm_policy_set_definition", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The management_group_name attribute.
    /// </summary>
    [TerraformProperty("management_group_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagementGroupName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPolicySetDefinitionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Metadata { get; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Parameters { get; }

    /// <summary>
    /// The policy_definition_group attribute.
    /// </summary>
    [TerraformProperty("policy_definition_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PolicyDefinitionGroup { get; }

    /// <summary>
    /// The policy_definition_reference attribute.
    /// </summary>
    [TerraformProperty("policy_definition_reference")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PolicyDefinitionReference { get; }

    /// <summary>
    /// The policy_definitions attribute.
    /// </summary>
    [TerraformProperty("policy_definitions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PolicyDefinitions { get; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformProperty("policy_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PolicyType { get; }

}
