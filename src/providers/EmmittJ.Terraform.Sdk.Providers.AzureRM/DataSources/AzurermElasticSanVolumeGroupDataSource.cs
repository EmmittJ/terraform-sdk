using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermElasticSanVolumeGroupDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_san_volume_group.
/// </summary>
public partial class AzurermElasticSanVolumeGroupDataSource : TerraformDataSource
{
    public AzurermElasticSanVolumeGroupDataSource(string name) : base("azurerm_elastic_san_volume_group", name)
    {
    }

    /// <summary>
    /// The elastic_san_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticSanId is required")]
    [TerraformProperty("elastic_san_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ElasticSanId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermElasticSanVolumeGroupDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformProperty("encryption")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Encryption { get; }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformProperty("encryption_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EncryptionType { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The network_rule attribute.
    /// </summary>
    [TerraformProperty("network_rule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkRule { get; }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [TerraformProperty("protocol_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProtocolType { get; }

}
