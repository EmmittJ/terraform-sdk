using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for policy_definition_group in .
/// Nesting mode: set
/// </summary>
public class AzurermManagementGroupPolicySetDefinitionPolicyDefinitionGroupBlock : ITerraformBlock
{
    /// <summary>
    /// The additional_metadata_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("additional_metadata_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdditionalMetadataResourceId { get; set; }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [TerraformPropertyName("category")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Category { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for policy_definition_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicySetDefinitionPolicyDefinitionReferenceBlock : ITerraformBlock
{
    /// <summary>
    /// The parameter_values attribute.
    /// </summary>
    [TerraformPropertyName("parameter_values")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ParameterValues { get; set; }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionId is required")]
    [TerraformPropertyName("policy_definition_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PolicyDefinitionId { get; set; }

    /// <summary>
    /// The policy_group_names attribute.
    /// </summary>
    [TerraformPropertyName("policy_group_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? PolicyGroupNames { get; set; }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    [TerraformPropertyName("reference_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ReferenceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "reference_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "version");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupPolicySetDefinitionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_management_group_policy_set_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermManagementGroupPolicySetDefinition : TerraformResource
{
    public AzurermManagementGroupPolicySetDefinition(string name) : base("azurerm_management_group_policy_set_definition", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    [TerraformPropertyName("management_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ManagementGroupId { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Metadata { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metadata");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Parameters { get; set; }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    [TerraformPropertyName("policy_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PolicyType { get; set; }

    /// <summary>
    /// Block for policy_definition_group.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("policy_definition_group")]
    public TerraformSet<TerraformBlock<AzurermManagementGroupPolicySetDefinitionPolicyDefinitionGroupBlock>>? PolicyDefinitionGroup { get; set; } = new();

    /// <summary>
    /// Block for policy_definition_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDefinitionReference block(s) required")]
    [TerraformPropertyName("policy_definition_reference")]
    public TerraformList<TerraformBlock<AzurermManagementGroupPolicySetDefinitionPolicyDefinitionReferenceBlock>>? PolicyDefinitionReference { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermManagementGroupPolicySetDefinitionTimeoutsBlock>? Timeouts { get; set; } = new();

}
