using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in AwsApiGatewayRestApi.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayRestApiEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_configuration";

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    public TerraformList<string>? Types
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "types").ResolveNodes(ctx));
        set => SetArgument("types", value);
    }

    /// <summary>
    /// The vpc_endpoint_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcEndpointIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_endpoint_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_endpoint_ids", value);
    }

}


/// <summary>
/// Represents a aws_api_gateway_rest_api Terraform resource.
/// Manages a aws_api_gateway_rest_api resource.
/// </summary>
public partial class AwsApiGatewayRestApi(string name) : TerraformResource("aws_api_gateway_rest_api", name)
{
    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    public TerraformValue<string> ApiKeySource
    {
        get => new TerraformReference<string>(this, "api_key_source");
        set => SetArgument("api_key_source", value);
    }

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    public TerraformList<string> BinaryMediaTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "binary_media_types").ResolveNodes(ctx));
        set => SetArgument("binary_media_types", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => new TerraformReference<string>(this, "body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformValue<bool> DisableExecuteApiEndpoint
    {
        get => new TerraformReference<bool>(this, "disable_execute_api_endpoint");
        set => SetArgument("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnWarnings
    {
        get => new TerraformReference<bool>(this, "fail_on_warnings");
        set => SetArgument("fail_on_warnings", value);
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
    /// The minimum_compression_size attribute.
    /// </summary>
    public TerraformValue<string> MinimumCompressionSize
    {
        get => new TerraformReference<string>(this, "minimum_compression_size");
        set => SetArgument("minimum_compression_size", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The put_rest_api_mode attribute.
    /// </summary>
    public TerraformValue<string>? PutRestApiMode
    {
        get => new TerraformReference<string>(this, "put_rest_api_mode");
        set => SetArgument("put_rest_api_mode", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
    {
        get => new TerraformReference<string>(this, "execution_arn");
    }

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    public TerraformValue<string> RootResourceId
    {
        get => new TerraformReference<string>(this, "root_resource_id");
    }

    /// <summary>
    /// EndpointConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfiguration block(s) allowed")]
    public TerraformList<AwsApiGatewayRestApiEndpointConfigurationBlock>? EndpointConfiguration
    {
        get => GetArgument<TerraformList<AwsApiGatewayRestApiEndpointConfigurationBlock>>("endpoint_configuration");
        set => SetArgument("endpoint_configuration", value);
    }

}
