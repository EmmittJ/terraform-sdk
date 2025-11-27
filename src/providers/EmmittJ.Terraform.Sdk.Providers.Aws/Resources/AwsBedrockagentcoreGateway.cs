using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authorizer_configuration in AwsBedrockagentcoreGateway.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayAuthorizerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_configuration";

    /// <summary>
    /// CustomJwtAuthorizer block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayAuthorizerConfigurationBlockCustomJwtAuthorizerBlock>? CustomJwtAuthorizer
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayAuthorizerConfigurationBlockCustomJwtAuthorizerBlock>>("custom_jwt_authorizer");
        set => SetArgument("custom_jwt_authorizer", value);
    }

}

/// <summary>
/// Block type for custom_jwt_authorizer in AwsBedrockagentcoreGatewayAuthorizerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayAuthorizerConfigurationBlockCustomJwtAuthorizerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_jwt_authorizer";

    /// <summary>
    /// The allowed_audience attribute.
    /// </summary>
    public TerraformSet<string>? AllowedAudience
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_audience").ResolveNodes(ctx));
        set => SetArgument("allowed_audience", value);
    }

    /// <summary>
    /// The allowed_clients attribute.
    /// </summary>
    public TerraformSet<string>? AllowedClients
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_clients").ResolveNodes(ctx));
        set => SetArgument("allowed_clients", value);
    }

    /// <summary>
    /// The discovery_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiscoveryUrl is required")]
    public required TerraformValue<string> DiscoveryUrl
    {
        get => new TerraformReference<string>(this, "discovery_url");
        set => SetArgument("discovery_url", value);
    }

}


/// <summary>
/// Block type for protocol_configuration in AwsBedrockagentcoreGateway.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayProtocolConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protocol_configuration";

    /// <summary>
    /// Mcp block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayProtocolConfigurationBlockMcpBlock>? Mcp
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayProtocolConfigurationBlockMcpBlock>>("mcp");
        set => SetArgument("mcp", value);
    }

}

/// <summary>
/// Block type for mcp in AwsBedrockagentcoreGatewayProtocolConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayProtocolConfigurationBlockMcpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mcp";

    /// <summary>
    /// The instructions attribute.
    /// </summary>
    public TerraformValue<string>? Instructions
    {
        get => new TerraformReference<string>(this, "instructions");
        set => SetArgument("instructions", value);
    }

    /// <summary>
    /// The search_type attribute.
    /// </summary>
    public TerraformValue<string>? SearchType
    {
        get => new TerraformReference<string>(this, "search_type");
        set => SetArgument("search_type", value);
    }

    /// <summary>
    /// The supported_versions attribute.
    /// </summary>
    public TerraformSet<string>? SupportedVersions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_versions").ResolveNodes(ctx));
        set => SetArgument("supported_versions", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockagentcoreGateway.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentcoreGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagentcore_gateway Terraform resource.
/// Manages a aws_bedrockagentcore_gateway resource.
/// </summary>
public partial class AwsBedrockagentcoreGateway(string name) : TerraformResource("aws_bedrockagentcore_gateway", name)
{
    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerType is required")]
    public required TerraformValue<string> AuthorizerType
    {
        get => new TerraformReference<string>(this, "authorizer_type");
        set => SetArgument("authorizer_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The exception_level attribute.
    /// </summary>
    public TerraformValue<string>? ExceptionLevel
    {
        get => new TerraformReference<string>(this, "exception_level");
        set => SetArgument("exception_level", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
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
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    public required TerraformValue<string> ProtocolType
    {
        get => new TerraformReference<string>(this, "protocol_type");
        set => SetArgument("protocol_type", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
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
    /// The gateway_arn attribute.
    /// </summary>
    public TerraformValue<string> GatewayArn
    {
        get => new TerraformReference<string>(this, "gateway_arn");
    }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    public TerraformValue<string> GatewayId
    {
        get => new TerraformReference<string>(this, "gateway_id");
    }

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    public TerraformValue<string> GatewayUrl
    {
        get => new TerraformReference<string>(this, "gateway_url");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workload_identity_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadIdentityDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "workload_identity_details").ResolveNodes(ctx));
    }

    /// <summary>
    /// AuthorizerConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayAuthorizerConfigurationBlock>? AuthorizerConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayAuthorizerConfigurationBlock>>("authorizer_configuration");
        set => SetArgument("authorizer_configuration", value);
    }

    /// <summary>
    /// ProtocolConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayProtocolConfigurationBlock>? ProtocolConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayProtocolConfigurationBlock>>("protocol_configuration");
        set => SetArgument("protocol_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentcoreGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentcoreGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
