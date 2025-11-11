using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for policy_definition_group in .
/// Nesting mode: set
/// </summary>
public partial class AzurermPolicySetDefinitionPolicyDefinitionGroupBlock : TerraformBlockBase
{
    /// <summary>
    /// The additional_metadata_resource_id attribute.
    /// </summary>
    [TerraformProperty("additional_metadata_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdditionalMetadataResourceId { get; set; }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [TerraformProperty("category")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Category { get; set; }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for policy_definition_reference in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPolicySetDefinitionPolicyDefinitionReferenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The parameter_values attribute.
    /// </summary>
    [TerraformProperty("parameter_values")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ParameterValues { get; set; }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionId is required")]
    [TerraformProperty("policy_definition_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyDefinitionId { get; set; }

    /// <summary>
    /// The policy_group_names attribute.
    /// </summary>
    [TerraformProperty("policy_group_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? PolicyGroupNames { get; set; }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    [TerraformProperty("reference_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ReferenceId { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPolicySetDefinitionTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_policy_set_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermPolicySetDefinition : TerraformResource
{
    public AzurermPolicySetDefinition(string name) : base("azurerm_policy_set_definition", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("management_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagementGroupId { get; set; }

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
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Parameters { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    [TerraformProperty("policy_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyType { get; set; }

    /// <summary>
    /// Block for policy_definition_group.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("policy_definition_group")]
    public partial TerraformSet<TerraformBlock<AzurermPolicySetDefinitionPolicyDefinitionGroupBlock>>? PolicyDefinitionGroup { get; set; }

    /// <summary>
    /// Block for policy_definition_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDefinitionReference block(s) required")]
    [TerraformProperty("policy_definition_reference")]
    public partial TerraformList<TerraformBlock<AzurermPolicySetDefinitionPolicyDefinitionReferenceBlock>>? PolicyDefinitionReference { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermPolicySetDefinitionTimeoutsBlock>? Timeouts { get; set; }

}
