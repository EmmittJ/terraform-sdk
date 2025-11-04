using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_configuration_set_event_destination resource.
/// </summary>
public class AwsSesv2ConfigurationSetEventDestination : TerraformResource
{
    public AwsSesv2ConfigurationSetEventDestination(string name) : base("aws_sesv2_configuration_set_event_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    public string? ConfigurationSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_set_name")?.Value;
        set => this.WithProperty("configuration_set_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_destination_name attribute.
    /// </summary>
    public string? EventDestinationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_destination_name")?.Value;
        set => this.WithProperty("event_destination_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
