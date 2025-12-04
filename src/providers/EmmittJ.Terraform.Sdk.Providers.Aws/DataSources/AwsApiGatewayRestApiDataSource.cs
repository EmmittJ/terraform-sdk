using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_rest_api Terraform data source.
/// Retrieves information about a aws_api_gateway_rest_api.
/// </summary>
public partial class AwsApiGatewayRestApiDataSource(string name) : TerraformDataSource("aws_api_gateway_rest_api", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    public TerraformValue<string> ApiKeySource
        => AsReference("api_key_source");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    public TerraformList<string> BinaryMediaTypes
        => AsReference("binary_media_types");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EndpointConfiguration
        => AsReference("endpoint_configuration");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
        => AsReference("execution_arn");

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    public TerraformValue<string> MinimumCompressionSize
        => AsReference("minimum_compression_size");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
        => AsReference("policy");

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    public TerraformValue<string> RootResourceId
        => AsReference("root_resource_id");

}
