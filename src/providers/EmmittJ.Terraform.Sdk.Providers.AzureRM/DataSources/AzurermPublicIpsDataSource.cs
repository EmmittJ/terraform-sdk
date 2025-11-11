using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPublicIpsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_public_ips.
/// </summary>
public partial class AzurermPublicIpsDataSource : TerraformDataSource
{
    public AzurermPublicIpsDataSource(string name) : base("azurerm_public_ips", name)
    {
    }

    /// <summary>
    /// The allocation_type attribute.
    /// </summary>
    [TerraformProperty("allocation_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AllocationType { get; set; }

    /// <summary>
    /// The attachment_status attribute.
    /// </summary>
    [TerraformProperty("attachment_status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AttachmentStatus { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NamePrefix { get; set; }

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
    public TerraformBlock<AzurermPublicIpsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    [TerraformProperty("public_ips")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PublicIps { get; }

}
