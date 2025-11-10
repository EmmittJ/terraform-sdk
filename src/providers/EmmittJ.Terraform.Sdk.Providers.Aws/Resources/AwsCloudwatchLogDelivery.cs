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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("delivery_destination_arn");
        SetOutput("delivery_source_name");
        SetOutput("field_delimiter");
        SetOutput("record_fields");
        SetOutput("region");
        SetOutput("s3_delivery_configuration");
        SetOutput("tags");
    }

    /// <summary>
    /// The delivery_destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryDestinationArn is required")]
    public required TerraformProperty<string> DeliveryDestinationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delivery_destination_arn");
        set => SetProperty("delivery_destination_arn", value);
    }

    /// <summary>
    /// The delivery_source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliverySourceName is required")]
    public required TerraformProperty<string> DeliverySourceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delivery_source_name");
        set => SetProperty("delivery_source_name", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformProperty<string> FieldDelimiter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("field_delimiter");
        set => SetProperty("field_delimiter", value);
    }

    /// <summary>
    /// The record_fields attribute.
    /// </summary>
    public List<TerraformProperty<string>> RecordFields
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("record_fields");
        set => SetProperty("record_fields", value);
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
    /// The s3_delivery_configuration attribute.
    /// </summary>
    public List<TerraformProperty<object>> S3DeliveryConfiguration
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("s3_delivery_configuration");
        set => SetProperty("s3_delivery_configuration", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
