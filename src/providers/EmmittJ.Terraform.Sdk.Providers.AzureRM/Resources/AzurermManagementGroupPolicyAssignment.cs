using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagementGroupPolicyAssignmentIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for non_compliance_message in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagementGroupPolicyAssignmentNonComplianceMessageBlock() : TerraformBlock("non_compliance_message")
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    [TerraformProperty("policy_definition_reference_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyDefinitionReferenceId { get; set; }

}

/// <summary>
/// Block type for overrides in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagementGroupPolicyAssignmentOverridesBlock() : TerraformBlock("overrides")
{
    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for resource_selectors in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagementGroupPolicyAssignmentResourceSelectorsBlock() : TerraformBlock("resource_selectors")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermManagementGroupPolicyAssignmentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_management_group_policy_assignment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermManagementGroupPolicyAssignment : TerraformResource
{
    public AzurermManagementGroupPolicyAssignment(string name) : base("azurerm_management_group_policy_assignment", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The enforce attribute.
    /// </summary>
    [TerraformProperty("enforce")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enforce { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    [TerraformProperty("management_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagementGroupId { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The not_scopes attribute.
    /// </summary>
    [TerraformProperty("not_scopes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? NotScopes { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Parameters { get; set; }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionId is required")]
    [TerraformProperty("policy_definition_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyDefinitionId { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermManagementGroupPolicyAssignmentIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for non_compliance_message.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("non_compliance_message")]
    public TerraformList<AzurermManagementGroupPolicyAssignmentNonComplianceMessageBlock> NonComplianceMessage { get; set; } = new();

    /// <summary>
    /// Block for overrides.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("overrides")]
    public TerraformList<AzurermManagementGroupPolicyAssignmentOverridesBlock> Overrides { get; set; } = new();

    /// <summary>
    /// Block for resource_selectors.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("resource_selectors")]
    public TerraformList<AzurermManagementGroupPolicyAssignmentResourceSelectorsBlock> ResourceSelectors { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermManagementGroupPolicyAssignmentTimeoutsBlock Timeouts { get; set; } = new();

}
