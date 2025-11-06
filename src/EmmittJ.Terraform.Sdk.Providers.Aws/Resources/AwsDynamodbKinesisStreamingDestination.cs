using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dynamodb_kinesis_streaming_destination resource.
/// </summary>
public class AwsDynamodbKinesisStreamingDestination : TerraformResource
{
    public AwsDynamodbKinesisStreamingDestination(string name) : base("aws_dynamodb_kinesis_streaming_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The approximate_creation_date_time_precision attribute.
    /// </summary>
    public string? ApproximateCreationDateTimePrecision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("approximate_creation_date_time_precision")?.Value;
        set => this.WithProperty("approximate_creation_date_time_precision", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public string? StreamArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_arn")?.Value;
        set => this.WithProperty("stream_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public string? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name")?.Value;
        set => this.WithProperty("table_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
