using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBatchCertificateDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_batch_certificate.
/// </summary>
public partial class AzurermBatchCertificateDataSource : TerraformDataSource
{
    public AzurermBatchCertificateDataSource(string name) : base("azurerm_batch_certificate", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermBatchCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [TerraformProperty("format")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Format { get; }

    /// <summary>
    /// The public_data attribute.
    /// </summary>
    [TerraformProperty("public_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicData { get; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Thumbprint { get; }

    /// <summary>
    /// The thumbprint_algorithm attribute.
    /// </summary>
    [TerraformProperty("thumbprint_algorithm")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ThumbprintAlgorithm { get; }

}
