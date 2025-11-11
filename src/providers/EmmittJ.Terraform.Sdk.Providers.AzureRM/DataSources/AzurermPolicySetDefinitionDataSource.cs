using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicySetDefinitionDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_policy_set_definition.
/// </summary>
public class AzurermPolicySetDefinitionDataSource : TerraformDataSource
{
    public AzurermPolicySetDefinitionDataSource(string name) : base("azurerm_policy_set_definition", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The management_group_name attribute.
    /// </summary>
    [TerraformPropertyName("management_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagementGroupName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPolicySetDefinitionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Metadata => new TerraformReference(this, "metadata");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Parameters => new TerraformReference(this, "parameters");

    /// <summary>
    /// The policy_definition_group attribute.
    /// </summary>
    [TerraformPropertyName("policy_definition_group")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PolicyDefinitionGroup => new TerraformReference(this, "policy_definition_group");

    /// <summary>
    /// The policy_definition_reference attribute.
    /// </summary>
    [TerraformPropertyName("policy_definition_reference")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PolicyDefinitionReference => new TerraformReference(this, "policy_definition_reference");

    /// <summary>
    /// The policy_definitions attribute.
    /// </summary>
    [TerraformPropertyName("policy_definitions")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PolicyDefinitions => new TerraformReference(this, "policy_definitions");

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformPropertyName("policy_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PolicyType => new TerraformReference(this, "policy_type");

}
