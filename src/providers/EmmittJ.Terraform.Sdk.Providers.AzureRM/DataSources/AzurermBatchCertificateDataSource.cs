using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchCertificateDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBatchCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The format attribute.
    /// </summary>
    [TerraformPropertyName("format")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Format => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "format");

    /// <summary>
    /// The public_data attribute.
    /// </summary>
    [TerraformPropertyName("public_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_data");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "thumbprint");

    /// <summary>
    /// The thumbprint_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint_algorithm")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ThumbprintAlgorithm => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "thumbprint_algorithm");

}
