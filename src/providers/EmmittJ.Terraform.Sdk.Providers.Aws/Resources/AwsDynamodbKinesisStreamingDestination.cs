using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dynamodb_kinesis_streaming_destination Terraform resource.
/// Manages a aws_dynamodb_kinesis_streaming_destination resource.
/// </summary>
public partial class AwsDynamodbKinesisStreamingDestination(string name) : TerraformResource("aws_dynamodb_kinesis_streaming_destination", name)
{
    /// <summary>
    /// The approximate_creation_date_time_precision attribute.
    /// </summary>
    public TerraformValue<string>? ApproximateCreationDateTimePrecision
    {
        get => GetArgument<TerraformValue<string>>("approximate_creation_date_time_precision");
        set => SetArgument("approximate_creation_date_time_precision", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformValue<string> StreamArn
    {
        get => GetArgument<TerraformValue<string>>("stream_arn");
        set => SetArgument("stream_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

}
