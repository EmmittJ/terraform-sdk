using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSourceControlTokenDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_source_control_token.
/// </summary>
public class AzurermSourceControlTokenDataSource : TerraformDataSource
{
    public AzurermSourceControlTokenDataSource(string name) : base("azurerm_source_control_token", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSourceControlTokenDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The token attribute.
    /// </summary>
    [TerraformPropertyName("token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Token => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "token");

    /// <summary>
    /// The token_secret attribute.
    /// </summary>
    [TerraformPropertyName("token_secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TokenSecret => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "token_secret");

}
