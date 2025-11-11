using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementWorkspacePolicyTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_api_management_workspace_policy resource.
/// </summary>
public partial class AzurermApiManagementWorkspacePolicy : TerraformResource
{
    public AzurermApiManagementWorkspacePolicy(string name) : base("azurerm_api_management_workspace_policy", name)
    {
    }

    /// <summary>
    /// The api_management_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementWorkspaceId is required")]
    [TerraformProperty("api_management_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiManagementWorkspaceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The xml_content attribute.
    /// </summary>
    [TerraformProperty("xml_content")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> XmlContent { get; set; }

    /// <summary>
    /// The xml_link attribute.
    /// </summary>
    [TerraformProperty("xml_link")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? XmlLink { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermApiManagementWorkspacePolicyTimeoutsBlock>? Timeouts { get; set; }

}
