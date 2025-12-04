using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_log_delivery Terraform resource.
/// Manages a aws_cloudwatch_log_delivery resource.
/// </summary>
public partial class AwsCloudwatchLogDelivery(string name) : TerraformResource("aws_cloudwatch_log_delivery", name)
{
    /// <summary>
    /// The delivery_destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryDestinationArn is required")]
    public required TerraformValue<string> DeliveryDestinationArn
    {
        get => GetArgument<TerraformValue<string>>("delivery_destination_arn");
        set => SetArgument("delivery_destination_arn", value);
    }

    /// <summary>
    /// The delivery_source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliverySourceName is required")]
    public required TerraformValue<string> DeliverySourceName
    {
        get => GetArgument<TerraformValue<string>>("delivery_source_name");
        set => SetArgument("delivery_source_name", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformValue<string>? FieldDelimiter
    {
        get => GetArgument<TerraformValue<string>>("field_delimiter");
        set => SetArgument("field_delimiter", value);
    }

    /// <summary>
    /// The record_fields attribute.
    /// </summary>
    public TerraformList<string>? RecordFields
    {
        get => GetArgument<TerraformList<string>>("record_fields");
        set => SetArgument("record_fields", value);
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
    /// The s3_delivery_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? S3DeliveryConfiguration
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("s3_delivery_configuration");
        set => SetArgument("s3_delivery_configuration", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

}
