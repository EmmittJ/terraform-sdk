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
        SetOutput("approximate_creation_date_time_precision");
        SetOutput("id");
        SetOutput("region");
        SetOutput("stream_arn");
        SetOutput("table_name");
    }

    /// <summary>
    /// The approximate_creation_date_time_precision attribute.
    /// </summary>
    public TerraformProperty<string> ApproximateCreationDateTimePrecision
    {
        get => GetRequiredOutput<TerraformProperty<string>>("approximate_creation_date_time_precision");
        set => SetProperty("approximate_creation_date_time_precision", value);
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
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformProperty<string> StreamArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_arn");
        set => SetProperty("stream_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_name");
        set => SetProperty("table_name", value);
    }

}
