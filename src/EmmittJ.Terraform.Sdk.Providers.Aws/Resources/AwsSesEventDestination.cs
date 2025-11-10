using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_destination in .
/// Nesting mode: set
/// </summary>
public class AwsSesEventDestinationCloudwatchDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultValue is required")]
    public required TerraformProperty<string> DefaultValue
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_value");
        set => WithProperty("default_value", value);
    }

    /// <summary>
    /// The dimension_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DimensionName is required")]
    public required TerraformProperty<string> DimensionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("dimension_name");
        set => WithProperty("dimension_name", value);
    }

    /// <summary>
    /// The value_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueSource is required")]
    public required TerraformProperty<string> ValueSource
    {
        get => GetRequiredProperty<TerraformProperty<string>>("value_source");
        set => WithProperty("value_source", value);
    }

}

/// <summary>
/// Block type for kinesis_destination in .
/// Nesting mode: list
/// </summary>
public class AwsSesEventDestinationKinesisDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformProperty<string> StreamArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("stream_arn");
        set => WithProperty("stream_arn", value);
    }

}

/// <summary>
/// Block type for sns_destination in .
/// Nesting mode: list
/// </summary>
public class AwsSesEventDestinationSnsDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformProperty<string> TopicArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
    }

}

/// <summary>
/// Manages a aws_ses_event_destination resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSesEventDestination : TerraformResource
{
    public AwsSesEventDestination(string name) : base("aws_ses_event_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    public required TerraformProperty<string> ConfigurationSetName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("configuration_set_name");
        set => this.WithProperty("configuration_set_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The matching_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingTypes is required")]
    public HashSet<TerraformProperty<string>>? MatchingTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("matching_types");
        set => this.WithProperty("matching_types", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for cloudwatch_destination.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesEventDestinationCloudwatchDestinationBlock>? CloudwatchDestination
    {
        get => GetProperty<HashSet<AwsSesEventDestinationCloudwatchDestinationBlock>>("cloudwatch_destination");
        set => this.WithProperty("cloudwatch_destination", value);
    }

    /// <summary>
    /// Block for kinesis_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisDestination block(s) allowed")]
    public List<AwsSesEventDestinationKinesisDestinationBlock>? KinesisDestination
    {
        get => GetProperty<List<AwsSesEventDestinationKinesisDestinationBlock>>("kinesis_destination");
        set => this.WithProperty("kinesis_destination", value);
    }

    /// <summary>
    /// Block for sns_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnsDestination block(s) allowed")]
    public List<AwsSesEventDestinationSnsDestinationBlock>? SnsDestination
    {
        get => GetProperty<List<AwsSesEventDestinationSnsDestinationBlock>>("sns_destination");
        set => this.WithProperty("sns_destination", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
