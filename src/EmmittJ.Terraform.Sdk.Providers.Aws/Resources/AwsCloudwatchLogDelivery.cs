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
    public string? DeliveryDestinationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_destination_arn")?.Value;
        set => this.WithProperty("delivery_destination_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delivery_source_name attribute.
    /// </summary>
    public string? DeliverySourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_source_name")?.Value;
        set => this.WithProperty("delivery_source_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public string? FieldDelimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("field_delimiter")?.Value;
        set => this.WithProperty("field_delimiter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The record_fields attribute.
    /// </summary>
    public List<string>? RecordFields
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("record_fields")?.Value;
        set => this.WithProperty("record_fields", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The s3_delivery_configuration attribute.
    /// </summary>
    public List<object>? S3DeliveryConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("s3_delivery_configuration")?.Value;
        set => this.WithProperty("s3_delivery_configuration", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
