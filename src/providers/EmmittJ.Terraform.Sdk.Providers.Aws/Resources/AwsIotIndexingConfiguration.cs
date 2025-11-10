using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for thing_group_indexing_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The thing_group_indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingGroupIndexingMode is required")]
    public required TerraformProperty<string> ThingGroupIndexingMode
    {
        set => SetProperty("thing_group_indexing_mode", value);
    }

}

/// <summary>
/// Block type for thing_indexing_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsIotIndexingConfigurationThingIndexingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The device_defender_indexing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceDefenderIndexingMode
    {
        set => SetProperty("device_defender_indexing_mode", value);
    }

    /// <summary>
    /// The named_shadow_indexing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? NamedShadowIndexingMode
    {
        set => SetProperty("named_shadow_indexing_mode", value);
    }

    /// <summary>
    /// The thing_connectivity_indexing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ThingConnectivityIndexingMode
    {
        set => SetProperty("thing_connectivity_indexing_mode", value);
    }

    /// <summary>
    /// The thing_indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingIndexingMode is required")]
    public required TerraformProperty<string> ThingIndexingMode
    {
        set => SetProperty("thing_indexing_mode", value);
    }

}

/// <summary>
/// Manages a aws_iot_indexing_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIotIndexingConfiguration : TerraformResource
{
    public AwsIotIndexingConfiguration(string name) : base("aws_iot_indexing_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for thing_group_indexing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingGroupIndexingConfiguration block(s) allowed")]
    public List<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock>? ThingGroupIndexingConfiguration
    {
        set => SetProperty("thing_group_indexing_configuration", value);
    }

    /// <summary>
    /// Block for thing_indexing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingIndexingConfiguration block(s) allowed")]
    public List<AwsIotIndexingConfigurationThingIndexingConfigurationBlock>? ThingIndexingConfiguration
    {
        set => SetProperty("thing_indexing_configuration", value);
    }

}
