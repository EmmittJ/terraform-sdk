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
    public TerraformLiteralProperty<string>? ApproximateCreationDateTimePrecision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("approximate_creation_date_time_precision");
        set => this.WithProperty("approximate_creation_date_time_precision", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_arn");
        set => this.WithProperty("stream_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

}
