using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_destination_configuration in AwsCloudwatchLogDeliveryDestination.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delivery_destination_configuration";

    /// <summary>
    /// The destination_resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationResourceArn is required")]
    public required TerraformValue<string> DestinationResourceArn
    {
        get => new TerraformReference<string>(this, "destination_resource_arn");
        set => SetArgument("destination_resource_arn", value);
    }

}


/// <summary>
/// Represents a aws_cloudwatch_log_delivery_destination Terraform resource.
/// Manages a aws_cloudwatch_log_delivery_destination resource.
/// </summary>
public partial class AwsCloudwatchLogDeliveryDestination(string name) : TerraformResource("aws_cloudwatch_log_delivery_destination", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    public TerraformValue<string>? OutputFormat
    {
        get => new TerraformReference<string>(this, "output_format");
        set => SetArgument("output_format", value);
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
    /// The delivery_destination_type attribute.
    /// </summary>
    public TerraformValue<string> DeliveryDestinationType
    {
        get => new TerraformReference<string>(this, "delivery_destination_type");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// DeliveryDestinationConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock>? DeliveryDestinationConfiguration
    {
        get => GetArgument<TerraformList<AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock>>("delivery_destination_configuration");
        set => SetArgument("delivery_destination_configuration", value);
    }

}
