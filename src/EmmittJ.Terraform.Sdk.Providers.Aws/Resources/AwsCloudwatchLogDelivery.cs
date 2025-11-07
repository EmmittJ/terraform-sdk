using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_delivery resource.
/// </summary>
public class AwsCloudwatchLogDelivery : TerraformResource
{
    public AwsCloudwatchLogDelivery(string name) : base("aws_cloudwatch_log_delivery", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The delivery_destination_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeliveryDestinationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_destination_arn");
        set => this.WithProperty("delivery_destination_arn", value);
    }

    /// <summary>
    /// The delivery_source_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeliverySourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_source_name");
        set => this.WithProperty("delivery_source_name", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FieldDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("field_delimiter");
        set => this.WithProperty("field_delimiter", value);
    }

    /// <summary>
    /// The record_fields attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? RecordFields
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("record_fields");
        set => this.WithProperty("record_fields", value);
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
    /// The s3_delivery_configuration attribute.
    /// </summary>
    public TerraformLiteralProperty<List<object>>? S3DeliveryConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("s3_delivery_configuration");
        set => this.WithProperty("s3_delivery_configuration", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
