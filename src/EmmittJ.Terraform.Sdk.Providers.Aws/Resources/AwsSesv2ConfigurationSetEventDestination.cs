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
    public TerraformProperty<string>? ConfigurationSetName
    {
        get => GetProperty<TerraformProperty<string>>("configuration_set_name");
        set => this.WithProperty("configuration_set_name", value);
    }

    /// <summary>
    /// The event_destination_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventDestinationName
    {
        get => GetProperty<TerraformProperty<string>>("event_destination_name");
        set => this.WithProperty("event_destination_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
