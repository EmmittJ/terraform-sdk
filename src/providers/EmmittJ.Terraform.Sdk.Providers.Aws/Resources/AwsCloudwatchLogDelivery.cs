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
        get => new TerraformReference<string>(this, "delivery_destination_arn");
        set => SetArgument("delivery_destination_arn", value);
    }

    /// <summary>
    /// The delivery_source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliverySourceName is required")]
    public required TerraformValue<string> DeliverySourceName
    {
        get => new TerraformReference<string>(this, "delivery_source_name");
        set => SetArgument("delivery_source_name", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformValue<string> FieldDelimiter
    {
        get => new TerraformReference<string>(this, "field_delimiter");
        set => SetArgument("field_delimiter", value);
    }

    /// <summary>
    /// The record_fields attribute.
    /// </summary>
    public TerraformList<string> RecordFields
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "record_fields").ResolveNodes(ctx));
        set => SetArgument("record_fields", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The s3_delivery_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> S3DeliveryConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "s3_delivery_configuration").ResolveNodes(ctx));
        set => SetArgument("s3_delivery_configuration", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

}
