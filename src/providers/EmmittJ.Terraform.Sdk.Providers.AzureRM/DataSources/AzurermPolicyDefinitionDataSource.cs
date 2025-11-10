using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyDefinitionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_policy_definition.
/// </summary>
public class AzurermPolicyDefinitionDataSource : TerraformDataSource
{
    public AzurermPolicyDefinitionDataSource(string name) : base("azurerm_policy_definition", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The management_group_name attribute.
    /// </summary>
    [TerraformPropertyName("management_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagementGroupName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPolicyDefinitionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Metadata => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metadata");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Mode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mode");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Parameters => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameters");

    /// <summary>
    /// The policy_rule attribute.
    /// </summary>
    [TerraformPropertyName("policy_rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PolicyRule => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_rule");

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformPropertyName("policy_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PolicyType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_type");

    /// <summary>
    /// The role_definition_ids attribute.
    /// </summary>
    [TerraformPropertyName("role_definition_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> RoleDefinitionIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "role_definition_ids");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
