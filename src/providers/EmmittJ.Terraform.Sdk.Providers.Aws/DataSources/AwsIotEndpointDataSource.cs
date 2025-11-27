using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iot_endpoint Terraform data source.
/// Retrieves information about a aws_iot_endpoint.
/// </summary>
public partial class AwsIotEndpointDataSource(string name) : TerraformDataSource("aws_iot_endpoint", name)
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformValue<string>? EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> EndpointAddress
    {
        get => new TerraformReference<string>(this, "endpoint_address");
    }

}
