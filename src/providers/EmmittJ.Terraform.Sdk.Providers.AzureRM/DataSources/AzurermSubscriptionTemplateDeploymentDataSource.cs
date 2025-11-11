using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSubscriptionTemplateDeploymentDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_subscription_template_deployment.
/// </summary>
public partial class AzurermSubscriptionTemplateDeploymentDataSource : TerraformDataSource
{
    public AzurermSubscriptionTemplateDeploymentDataSource(string name) : base("azurerm_subscription_template_deployment", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSubscriptionTemplateDeploymentDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The output_content attribute.
    /// </summary>
    [TerraformProperty("output_content")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OutputContent { get; }

}
