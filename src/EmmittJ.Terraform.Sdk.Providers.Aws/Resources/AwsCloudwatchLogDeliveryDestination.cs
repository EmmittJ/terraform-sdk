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
        get => GetProperty<TerraformProperty<string>>("destination_resource_arn");
        set => WithProperty("destination_resource_arn", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("delivery_destination_type");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    public TerraformProperty<string>? OutputFormat
    {
        get => GetProperty<TerraformProperty<string>>("output_format");
        set => this.WithProperty("output_format", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for delivery_destination_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock>? DeliveryDestinationConfiguration
    {
        get => GetProperty<List<AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock>>("delivery_destination_configuration");
        set => this.WithProperty("delivery_destination_configuration", value);
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
