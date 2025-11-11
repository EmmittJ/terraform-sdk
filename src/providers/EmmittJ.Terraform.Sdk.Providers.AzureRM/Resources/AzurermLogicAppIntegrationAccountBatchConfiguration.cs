using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for release_criteria in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock : TerraformBlockBase
{
    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    [TerraformProperty("batch_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BatchSize { get; set; }

    /// <summary>
    /// The message_count attribute.
    /// </summary>
    [TerraformProperty("message_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MessageCount { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_logic_app_integration_account_batch_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLogicAppIntegrationAccountBatchConfiguration : TerraformResource
{
    public AzurermLogicAppIntegrationAccountBatchConfiguration(string name) : base("azurerm_logic_app_integration_account_batch_configuration", name)
    {
    }

    /// <summary>
    /// The batch_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchGroupName is required")]
    [TerraformProperty("batch_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BatchGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integration_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    [TerraformProperty("integration_account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IntegrationAccountName { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for release_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseCriteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReleaseCriteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReleaseCriteria block(s) allowed")]
    [TerraformProperty("release_criteria")]
    public TerraformList<TerraformBlock<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock>>? ReleaseCriteria { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
