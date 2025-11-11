using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for thing_group_indexing_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock
{
    /// <summary>
    /// The thing_group_indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingGroupIndexingMode is required")]
    [TerraformPropertyName("thing_group_indexing_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ThingGroupIndexingMode { get; set; }

}

/// <summary>
/// Block type for thing_indexing_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsIotIndexingConfigurationThingIndexingConfigurationBlock
{
    /// <summary>
    /// The device_defender_indexing_mode attribute.
    /// </summary>
    [TerraformPropertyName("device_defender_indexing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeviceDefenderIndexingMode { get; set; }

    /// <summary>
    /// The named_shadow_indexing_mode attribute.
    /// </summary>
    [TerraformPropertyName("named_shadow_indexing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamedShadowIndexingMode { get; set; }

    /// <summary>
    /// The thing_connectivity_indexing_mode attribute.
    /// </summary>
    [TerraformPropertyName("thing_connectivity_indexing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ThingConnectivityIndexingMode { get; set; }

    /// <summary>
    /// The thing_indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingIndexingMode is required")]
    [TerraformPropertyName("thing_indexing_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ThingIndexingMode { get; set; }

}

/// <summary>
/// Manages a aws_iot_indexing_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIotIndexingConfiguration : TerraformResource
{
    public AwsIotIndexingConfiguration(string name) : base("aws_iot_indexing_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for thing_group_indexing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingGroupIndexingConfiguration block(s) allowed")]
    [TerraformPropertyName("thing_group_indexing_configuration")]
    public TerraformList<TerraformBlock<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock>>? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>
    /// Block for thing_indexing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingIndexingConfiguration block(s) allowed")]
    [TerraformPropertyName("thing_indexing_configuration")]
    public TerraformList<TerraformBlock<AwsIotIndexingConfigurationThingIndexingConfigurationBlock>>? ThingIndexingConfiguration { get; set; }

}
