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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

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
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    public TerraformValue<string> ApiKeySource
    {
        get => new TerraformReference<string>(this, "api_key_source");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    public TerraformList<string> BinaryMediaTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "binary_media_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EndpointConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "endpoint_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
    {
        get => new TerraformReference<string>(this, "execution_arn");
    }

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    public TerraformValue<string> MinimumCompressionSize
    {
        get => new TerraformReference<string>(this, "minimum_compression_size");
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
    }

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    public TerraformValue<string> RootResourceId
    {
        get => new TerraformReference<string>(this, "root_resource_id");
    }

}
