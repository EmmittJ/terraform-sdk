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
        get => GetArgument<TerraformValue<string>>("endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> EndpointAddress
        => AsReference("endpoint_address");

}
