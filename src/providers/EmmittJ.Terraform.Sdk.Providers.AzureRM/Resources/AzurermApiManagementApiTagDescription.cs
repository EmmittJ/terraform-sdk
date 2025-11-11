using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementApiTagDescriptionTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_api_management_api_tag_description resource.
/// </summary>
public partial class AzurermApiManagementApiTagDescription : TerraformResource
{
    public AzurermApiManagementApiTagDescription(string name) : base("azurerm_api_management_api_tag_description", name)
    {
    }

    /// <summary>
    /// The api_tag_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiTagId is required")]
    [TerraformProperty("api_tag_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiTagId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The external_documentation_description attribute.
    /// </summary>
    [TerraformProperty("external_documentation_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExternalDocumentationDescription { get; set; }

    /// <summary>
    /// The external_documentation_url attribute.
    /// </summary>
    [TerraformProperty("external_documentation_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExternalDocumentationUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermApiManagementApiTagDescriptionTimeoutsBlock>? Timeouts { get; set; }

}
