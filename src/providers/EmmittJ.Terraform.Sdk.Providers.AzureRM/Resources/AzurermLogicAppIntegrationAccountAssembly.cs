using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogicAppIntegrationAccountAssemblyTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_logic_app_integration_account_assembly resource.
/// </summary>
public partial class AzurermLogicAppIntegrationAccountAssembly : TerraformResource
{
    public AzurermLogicAppIntegrationAccountAssembly(string name) : base("azurerm_logic_app_integration_account_assembly", name)
    {
    }

    /// <summary>
    /// The assembly_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssemblyName is required")]
    [TerraformProperty("assembly_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AssemblyName { get; set; }

    /// <summary>
    /// The assembly_version attribute.
    /// </summary>
    [TerraformProperty("assembly_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AssemblyVersion { get; set; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformProperty("content")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Content { get; set; }

    /// <summary>
    /// The content_link_uri attribute.
    /// </summary>
    [TerraformProperty("content_link_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContentLinkUri { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLogicAppIntegrationAccountAssemblyTimeoutsBlock>? Timeouts { get; set; }

}
