using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyAssignmentDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_policy_assignment.
/// </summary>
public class AzurermPolicyAssignmentDataSource : TerraformDataSource
{
    public AzurermPolicyAssignmentDataSource(string name) : base("azurerm_policy_assignment", name)
    {
    }

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
    /// The scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    [TerraformPropertyName("scope_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScopeId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPolicyAssignmentDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The enforce attribute.
    /// </summary>
    [TerraformPropertyName("enforce")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enforce => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enforce");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Metadata => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metadata");

    /// <summary>
    /// The non_compliance_message attribute.
    /// </summary>
    [TerraformPropertyName("non_compliance_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NonComplianceMessage => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "non_compliance_message");

    /// <summary>
    /// The not_scopes attribute.
    /// </summary>
    [TerraformPropertyName("not_scopes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> NotScopes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "not_scopes");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Parameters => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameters");

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [TerraformPropertyName("policy_definition_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PolicyDefinitionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_definition_id");

}
