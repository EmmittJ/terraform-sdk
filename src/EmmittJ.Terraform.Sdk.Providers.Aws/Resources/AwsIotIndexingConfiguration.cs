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
        get => GetProperty<TerraformProperty<string>>("thing_group_indexing_mode");
        set => WithProperty("thing_group_indexing_mode", value);
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
        get => GetProperty<TerraformProperty<string>>("device_defender_indexing_mode");
        set => WithProperty("device_defender_indexing_mode", value);
    }

    /// <summary>
    /// The named_shadow_indexing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? NamedShadowIndexingMode
    {
        get => GetProperty<TerraformProperty<string>>("named_shadow_indexing_mode");
        set => WithProperty("named_shadow_indexing_mode", value);
    }

    /// <summary>
    /// The thing_connectivity_indexing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ThingConnectivityIndexingMode
    {
        get => GetProperty<TerraformProperty<string>>("thing_connectivity_indexing_mode");
        set => WithProperty("thing_connectivity_indexing_mode", value);
    }

    /// <summary>
    /// The thing_indexing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThingIndexingMode is required")]
    public required TerraformProperty<string> ThingIndexingMode
    {
        get => GetProperty<TerraformProperty<string>>("thing_indexing_mode");
        set => WithProperty("thing_indexing_mode", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for thing_group_indexing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingGroupIndexingConfiguration block(s) allowed")]
    public List<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock>? ThingGroupIndexingConfiguration
    {
        get => GetProperty<List<AwsIotIndexingConfigurationThingGroupIndexingConfigurationBlock>>("thing_group_indexing_configuration");
        set => this.WithProperty("thing_group_indexing_configuration", value);
    }

    /// <summary>
    /// Block for thing_indexing_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThingIndexingConfiguration block(s) allowed")]
    public List<AwsIotIndexingConfigurationThingIndexingConfigurationBlock>? ThingIndexingConfiguration
    {
        get => GetProperty<List<AwsIotIndexingConfigurationThingIndexingConfigurationBlock>>("thing_indexing_configuration");
        set => this.WithProperty("thing_indexing_configuration", value);
    }

}
