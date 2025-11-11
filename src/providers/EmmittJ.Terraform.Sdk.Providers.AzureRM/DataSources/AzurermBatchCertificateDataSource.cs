using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchCertificateDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_batch_certificate.
/// </summary>
public class AzurermBatchCertificateDataSource : TerraformDataSource
{
    public AzurermBatchCertificateDataSource(string name) : base("azurerm_batch_certificate", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBatchCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [TerraformPropertyName("format")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Format => new TerraformReference(this, "format");

    /// <summary>
    /// The public_data attribute.
    /// </summary>
    [TerraformPropertyName("public_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicData => new TerraformReference(this, "public_data");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Thumbprint => new TerraformReference(this, "thumbprint");

    /// <summary>
    /// The thumbprint_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint_algorithm")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ThumbprintAlgorithm => new TerraformReference(this, "thumbprint_algorithm");

}
