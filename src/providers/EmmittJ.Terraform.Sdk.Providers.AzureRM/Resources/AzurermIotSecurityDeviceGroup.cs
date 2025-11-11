using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for allow_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIotSecurityDeviceGroupAllowRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_from_ips_not_allowed attribute.
    /// </summary>
    [TerraformProperty("connection_from_ips_not_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ConnectionFromIpsNotAllowed { get; set; }

    /// <summary>
    /// The connection_to_ips_not_allowed attribute.
    /// </summary>
    [TerraformProperty("connection_to_ips_not_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ConnectionToIpsNotAllowed { get; set; }

    /// <summary>
    /// The local_users_not_allowed attribute.
    /// </summary>
    [TerraformProperty("local_users_not_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? LocalUsersNotAllowed { get; set; }

    /// <summary>
    /// The processes_not_allowed attribute.
    /// </summary>
    [TerraformProperty("processes_not_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ProcessesNotAllowed { get; set; }

}

/// <summary>
/// Block type for range_rule in .
/// Nesting mode: set
/// </summary>
public partial class AzurermIotSecurityDeviceGroupRangeRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformProperty("duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Duration { get; set; }

    /// <summary>
    /// The max attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Max is required")]
    [TerraformProperty("max")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Max { get; set; }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    [TerraformProperty("min")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Min { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermIotSecurityDeviceGroupTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_iot_security_device_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermIotSecurityDeviceGroup : TerraformResource
{
    public AzurermIotSecurityDeviceGroup(string name) : base("azurerm_iot_security_device_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    [TerraformProperty("iothub_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IothubId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for allow_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowRule block(s) allowed")]
    [TerraformProperty("allow_rule")]
    public partial TerraformList<TerraformBlock<AzurermIotSecurityDeviceGroupAllowRuleBlock>>? AllowRule { get; set; }

    /// <summary>
    /// Block for range_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("range_rule")]
    public partial TerraformSet<TerraformBlock<AzurermIotSecurityDeviceGroupRangeRuleBlock>>? RangeRule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermIotSecurityDeviceGroupTimeoutsBlock>? Timeouts { get; set; }

}
