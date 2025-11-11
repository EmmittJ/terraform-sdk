using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementUserDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_user.
/// </summary>
public partial class AzurermApiManagementUserDataSource : TerraformDataSource
{
    public AzurermApiManagementUserDataSource(string name) : base("azurerm_api_management_user", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformProperty("api_management_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    [TerraformProperty("user_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApiManagementUserDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Email { get; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FirstName { get; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastName { get; }

    /// <summary>
    /// The note attribute.
    /// </summary>
    [TerraformProperty("note")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Note { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
