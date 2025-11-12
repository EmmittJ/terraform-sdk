using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_destination in .
/// Nesting mode: set
/// </summary>
public partial class AwsSesEventDestinationCloudwatchDestinationBlock() : TerraformBlock("cloudwatch_destination")
{
    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultValue is required")]
    [TerraformProperty("default_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultValue { get; set; }

    /// <summary>
    /// The dimension_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DimensionName is required")]
    [TerraformProperty("dimension_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DimensionName { get; set; }

    /// <summary>
    /// The value_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueSource is required")]
    [TerraformProperty("value_source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ValueSource { get; set; }

}

/// <summary>
/// Block type for kinesis_destination in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesEventDestinationKinesisDestinationBlock() : TerraformBlock("kinesis_destination")
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    [TerraformProperty("stream_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StreamArn { get; set; }

}

/// <summary>
/// Block type for sns_destination in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesEventDestinationSnsDestinationBlock() : TerraformBlock("sns_destination")
{
    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformProperty("topic_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TopicArn { get; set; }

}

/// <summary>
/// Manages a aws_ses_event_destination resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSesEventDestination : TerraformResource
{
    public AwsSesEventDestination(string name) : base("aws_ses_event_destination", name)
    {
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    [TerraformProperty("configuration_set_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConfigurationSetName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The matching_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingTypes is required")]
    [TerraformProperty("matching_types")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> MatchingTypes { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for cloudwatch_destination.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cloudwatch_destination")]
    public TerraformSet<AwsSesEventDestinationCloudwatchDestinationBlock> CloudwatchDestination { get; set; } = new();

    /// <summary>
    /// Block for kinesis_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisDestination block(s) allowed")]
    [TerraformProperty("kinesis_destination")]
    public TerraformList<AwsSesEventDestinationKinesisDestinationBlock> KinesisDestination { get; set; } = new();

    /// <summary>
    /// Block for sns_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnsDestination block(s) allowed")]
    [TerraformProperty("sns_destination")]
    public TerraformList<AwsSesEventDestinationSnsDestinationBlock> SnsDestination { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
