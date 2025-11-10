using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeGroupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_san_volume_group.
/// </summary>
public class AzurermElasticSanVolumeGroupDataSource : TerraformDataSource
{
    public AzurermElasticSanVolumeGroupDataSource(string name) : base("azurerm_elastic_san_volume_group", name)
    {
    }

    /// <summary>
    /// The elastic_san_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticSanId is required")]
    [TerraformPropertyName("elastic_san_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ElasticSanId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticSanVolumeGroupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformPropertyName("encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Encryption => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption");

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("encryption_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptionType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encryption_type");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The network_rule attribute.
    /// </summary>
    [TerraformPropertyName("network_rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkRule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_rule");

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [TerraformPropertyName("protocol_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProtocolType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol_type");

}
