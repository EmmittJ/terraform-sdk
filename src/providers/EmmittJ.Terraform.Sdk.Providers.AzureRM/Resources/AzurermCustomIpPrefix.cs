using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCustomIpPrefixTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_custom_ip_prefix resource.
/// </summary>
public partial class AzurermCustomIpPrefix : TerraformResource
{
    public AzurermCustomIpPrefix(string name) : base("azurerm_custom_ip_prefix", name)
    {
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    [TerraformProperty("cidr")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Cidr { get; set; }

    /// <summary>
    /// The commissioning_enabled attribute.
    /// </summary>
    [TerraformProperty("commissioning_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CommissioningEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The internet_advertising_disabled attribute.
    /// </summary>
    [TerraformProperty("internet_advertising_disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? InternetAdvertisingDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_custom_ip_prefix_id attribute.
    /// </summary>
    [TerraformProperty("parent_custom_ip_prefix_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ParentCustomIpPrefixId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The roa_validity_end_date attribute.
    /// </summary>
    [TerraformProperty("roa_validity_end_date")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoaValidityEndDate { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The wan_validation_signed_message attribute.
    /// </summary>
    [TerraformProperty("wan_validation_signed_message")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WanValidationSignedMessage { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermCustomIpPrefixTimeoutsBlock>? Timeouts { get; set; }

}
