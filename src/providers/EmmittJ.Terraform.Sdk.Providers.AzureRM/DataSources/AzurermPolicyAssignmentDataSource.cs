using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPolicyAssignmentDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_policy_assignment.
/// </summary>
public partial class AzurermPolicyAssignmentDataSource : TerraformDataSource
{
    public AzurermPolicyAssignmentDataSource(string name) : base("azurerm_policy_assignment", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    [TerraformProperty("scope_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ScopeId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPolicyAssignmentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The enforce attribute.
    /// </summary>
    [TerraformProperty("enforce")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Enforce { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Metadata { get; }

    /// <summary>
    /// The non_compliance_message attribute.
    /// </summary>
    [TerraformProperty("non_compliance_message")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NonComplianceMessage { get; }

    /// <summary>
    /// The not_scopes attribute.
    /// </summary>
    [TerraformProperty("not_scopes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> NotScopes { get; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Parameters { get; }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [TerraformProperty("policy_definition_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PolicyDefinitionId { get; }

}
