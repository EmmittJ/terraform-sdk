using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for allow_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermIotSecurityDeviceGroupAllowRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The connection_from_ips_not_allowed attribute.
    /// </summary>
    [TerraformPropertyName("connection_from_ips_not_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ConnectionFromIpsNotAllowed { get; set; }

    /// <summary>
    /// The connection_to_ips_not_allowed attribute.
    /// </summary>
    [TerraformPropertyName("connection_to_ips_not_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ConnectionToIpsNotAllowed { get; set; }

    /// <summary>
    /// The local_users_not_allowed attribute.
    /// </summary>
    [TerraformPropertyName("local_users_not_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? LocalUsersNotAllowed { get; set; }

    /// <summary>
    /// The processes_not_allowed attribute.
    /// </summary>
    [TerraformPropertyName("processes_not_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ProcessesNotAllowed { get; set; }

}

/// <summary>
/// Block type for range_rule in .
/// Nesting mode: set
/// </summary>
public class AzurermIotSecurityDeviceGroupRangeRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformPropertyName("duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Duration { get; set; }

    /// <summary>
    /// The max attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Max is required")]
    [TerraformPropertyName("max")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Max { get; set; }

    /// <summary>
    /// The min attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Min is required")]
    [TerraformPropertyName("min")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Min { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIotSecurityDeviceGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_iot_security_device_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermIotSecurityDeviceGroup : TerraformResource
{
    public AzurermIotSecurityDeviceGroup(string name) : base("azurerm_iot_security_device_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    [TerraformPropertyName("iothub_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IothubId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for allow_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowRule block(s) allowed")]
    [TerraformPropertyName("allow_rule")]
    public TerraformList<TerraformBlock<AzurermIotSecurityDeviceGroupAllowRuleBlock>>? AllowRule { get; set; } = new();

    /// <summary>
    /// Block for range_rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("range_rule")]
    public TerraformSet<TerraformBlock<AzurermIotSecurityDeviceGroupRangeRuleBlock>>? RangeRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermIotSecurityDeviceGroupTimeoutsBlock>? Timeouts { get; set; } = new();

}
