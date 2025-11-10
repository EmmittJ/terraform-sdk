using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_destination_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The destination_resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationResourceArn is required")]
    public required TerraformProperty<string> DestinationResourceArn
    {
        set => SetProperty("destination_resource_arn", value);
    }

}

/// <summary>
/// Manages a aws_cloudwatch_log_delivery_destination resource.
/// </summary>
public class AwsCloudwatchLogDeliveryDestination : TerraformResource
{
    public AwsCloudwatchLogDeliveryDestination(string name) : base("aws_cloudwatch_log_delivery_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("delivery_destination_type");
        SetOutput("tags_all");
        SetOutput("name");
        SetOutput("output_format");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    public TerraformProperty<string> OutputFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("output_format");
        set => SetProperty("output_format", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for delivery_destination_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock>? DeliveryDestinationConfiguration
    {
        set => SetProperty("delivery_destination_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The delivery_destination_type attribute.
    /// </summary>
    public TerraformExpression DeliveryDestinationType => this["delivery_destination_type"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
