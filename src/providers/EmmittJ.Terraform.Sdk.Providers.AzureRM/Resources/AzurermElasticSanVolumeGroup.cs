using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public partial class AzurermElasticSanVolumeGroupEncryptionBlock() : TerraformBlock("encryption")
{


    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformProperty("key_vault_key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultKeyId { get; set; }


    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermElasticSanVolumeGroupIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for network_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermElasticSanVolumeGroupNetworkRuleBlock() : TerraformBlock("network_rule")
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformProperty("action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Action { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermElasticSanVolumeGroupTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_elastic_san_volume_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermElasticSanVolumeGroup : TerraformResource
{
    public AzurermElasticSanVolumeGroup(string name) : base("azurerm_elastic_san_volume_group", name)
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
    /// The encryption_type attribute.
    /// </summary>
    [TerraformProperty("encryption_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionType { get; set; }

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
    /// The protocol_type attribute.
    /// </summary>
    [TerraformProperty("protocol_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProtocolType { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformProperty("encryption")]
    public TerraformList<AzurermElasticSanVolumeGroupEncryptionBlock> Encryption { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermElasticSanVolumeGroupIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for network_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_rule")]
    public TerraformList<AzurermElasticSanVolumeGroupNetworkRuleBlock> NetworkRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermElasticSanVolumeGroupTimeoutsBlock Timeouts { get; set; } = new();

}
