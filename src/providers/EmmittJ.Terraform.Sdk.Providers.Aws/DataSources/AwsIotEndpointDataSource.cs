using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iot_endpoint.
/// </summary>
public class AwsIotEndpointDataSource : TerraformDataSource
{
    public AwsIotEndpointDataSource(string name) : base("aws_iot_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("endpoint_address");
        SetOutput("endpoint_type");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string> EndpointType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_type");
        set => SetProperty("endpoint_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The endpoint_address attribute.
    /// </summary>
    public TerraformExpression EndpointAddress => this["endpoint_address"];

}
