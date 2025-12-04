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
        get => GetArgument<TerraformValue<string>>("ip_address_type") ?? AsReference("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    public TerraformList<string>? Types
    {
        get => GetArgument<TerraformList<string>>("types");
        set => SetArgument("types", value);
    }

    /// <summary>
    /// The vpc_endpoint_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcEndpointIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_endpoint_ids") ?? AsReference("vpc_endpoint_ids");
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
        get => GetArgument<TerraformValue<string>>("api_key_source") ?? AsReference("api_key_source");
        set => SetArgument("api_key_source", value);
    }

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    public TerraformList<string> BinaryMediaTypes
    {
        get => GetArgument<TerraformList<string>>("binary_media_types") ?? AsReference("binary_media_types");
        set => SetArgument("binary_media_types", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => GetArgument<TerraformValue<string>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description") ?? AsReference("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformValue<bool> DisableExecuteApiEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("disable_execute_api_endpoint") ?? AsReference("disable_execute_api_endpoint");
        set => SetArgument("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnWarnings
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_warnings");
        set => SetArgument("fail_on_warnings", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    public TerraformValue<string> MinimumCompressionSize
    {
        get => GetArgument<TerraformValue<string>>("minimum_compression_size") ?? AsReference("minimum_compression_size");
        set => SetArgument("minimum_compression_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => GetArgument<TerraformValue<string>>("policy") ?? AsReference("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The put_rest_api_mode attribute.
    /// </summary>
    public TerraformValue<string>? PutRestApiMode
    {
        get => GetArgument<TerraformValue<string>>("put_rest_api_mode");
        set => SetArgument("put_rest_api_mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionArn
        => AsReference("execution_arn");

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    public TerraformValue<string> RootResourceId
        => AsReference("root_resource_id");

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
