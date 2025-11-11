using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyAssignmentDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    [TerraformPropertyName("scope_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ScopeId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPolicyAssignmentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The enforce attribute.
    /// </summary>
    [TerraformPropertyName("enforce")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Enforce => new TerraformReference(this, "enforce");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Metadata => new TerraformReference(this, "metadata");

    /// <summary>
    /// The non_compliance_message attribute.
    /// </summary>
    [TerraformPropertyName("non_compliance_message")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NonComplianceMessage => new TerraformReference(this, "non_compliance_message");

    /// <summary>
    /// The not_scopes attribute.
    /// </summary>
    [TerraformPropertyName("not_scopes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> NotScopes => new TerraformReference(this, "not_scopes");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Parameters => new TerraformReference(this, "parameters");

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [TerraformPropertyName("policy_definition_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PolicyDefinitionId => new TerraformReference(this, "policy_definition_id");

}
