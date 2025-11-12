using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for thing_group_indexing_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock() : TerraformBlock("thing_group_indexing_configuration")
{
    /// <summary>
    /// The thing_group_indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingGroupIndexingMode is required")]
    [TerraformProperty("thing_group_indexing_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ThingGroupIndexingMode { get; set; }

}

/// <summary>
/// Block type for thing_indexing_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsIotIndexingConfigurationThingIndexingConfigurationBlock() : TerraformBlock("thing_indexing_configuration")
{
    /// <summary>
    /// The device_defender_indexing_mode attribute.
    /// </summary>
    [TerraformProperty("device_defender_indexing_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceDefenderIndexingMode { get; set; }

    /// <summary>
    /// The named_shadow_indexing_mode attribute.
    /// </summary>
    [TerraformProperty("named_shadow_indexing_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamedShadowIndexingMode { get; set; }

    /// <summary>
    /// The thing_connectivity_indexing_mode attribute.
    /// </summary>
    [TerraformProperty("thing_connectivity_indexing_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThingConnectivityIndexingMode { get; set; }

    /// <summary>
    /// The thing_indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingIndexingMode is required")]
    [TerraformProperty("thing_indexing_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ThingIndexingMode { get; set; }

}

/// <summary>
/// Manages a aws_iot_indexing_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsIotIndexingConfiguration : TerraformResource
{
    public AwsIotIndexingConfiguration(string name) : base("aws_iot_indexing_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for thing_group_indexing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingGroupIndexingConfiguration block(s) allowed")]
    [TerraformProperty("thing_group_indexing_configuration")]
    public TerraformList<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock> ThingGroupIndexingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for thing_indexing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingIndexingConfiguration block(s) allowed")]
    [TerraformProperty("thing_indexing_configuration")]
    public TerraformList<AwsIotIndexingConfigurationThingIndexingConfigurationBlock> ThingIndexingConfiguration { get; set; } = new();

}
