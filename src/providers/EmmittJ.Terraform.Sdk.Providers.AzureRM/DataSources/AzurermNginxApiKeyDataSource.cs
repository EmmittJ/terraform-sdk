using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxApiKeyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_api_key.
/// </summary>
public class AzurermNginxApiKeyDataSource : TerraformDataSource
{
    public AzurermNginxApiKeyDataSource(string name) : base("azurerm_nginx_api_key", name)
    {
    }

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
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    [TerraformPropertyName("nginx_deployment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NginxDeploymentId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNginxApiKeyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The end_date_time attribute.
    /// </summary>
    [TerraformPropertyName("end_date_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndDateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_date_time");

    /// <summary>
    /// The hint attribute.
    /// </summary>
    [TerraformPropertyName("hint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hint");

}
