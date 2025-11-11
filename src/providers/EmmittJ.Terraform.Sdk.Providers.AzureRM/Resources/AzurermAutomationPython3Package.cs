using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAutomationPython3PackageTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_automation_python3_package resource.
/// </summary>
public partial class AzurermAutomationPython3Package : TerraformResource
{
    public AzurermAutomationPython3Package(string name) : base("azurerm_automation_python3_package", name)
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    [TerraformProperty("automation_account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutomationAccountName { get; set; }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentUri is required")]
    [TerraformProperty("content_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContentUri { get; set; }

    /// <summary>
    /// The content_version attribute.
    /// </summary>
    [TerraformProperty("content_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContentVersion { get; set; }

    /// <summary>
    /// The hash_algorithm attribute.
    /// </summary>
    [TerraformProperty("hash_algorithm")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HashAlgorithm { get; set; }

    /// <summary>
    /// The hash_value attribute.
    /// </summary>
    [TerraformProperty("hash_value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HashValue { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAutomationPython3PackageTimeoutsBlock>? Timeouts { get; set; }

}
