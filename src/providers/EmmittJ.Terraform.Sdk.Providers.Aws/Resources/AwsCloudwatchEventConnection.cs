using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth_parameters in AwsCloudwatchEventConnection.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_parameters";

    /// <summary>
    /// ApiKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiKey block(s) allowed")]
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockApiKeyBlock>? ApiKey
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockApiKeyBlock>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// Basic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Basic block(s) allowed")]
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockBasicBlock>? Basic
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockBasicBlock>>("basic");
        set => SetArgument("basic", value);
    }

    /// <summary>
    /// InvocationHttpParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InvocationHttpParameters block(s) allowed")]
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlock>? InvocationHttpParameters
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlock>>("invocation_http_parameters");
        set => SetArgument("invocation_http_parameters", value);
    }

    /// <summary>
    /// Oauth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth block(s) allowed")]
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlock>? Oauth
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlock>>("oauth");
        set => SetArgument("oauth", value);
    }

}

/// <summary>
/// Block type for api_key in AwsCloudwatchEventConnectionAuthParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockApiKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_key";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for basic in AwsCloudwatchEventConnectionAuthParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockBasicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for invocation_http_parameters in AwsCloudwatchEventConnectionAuthParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "invocation_http_parameters";

    /// <summary>
    /// Body block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlockBodyBlock>? Body
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlockBodyBlock>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// QueryString block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlockQueryStringBlock>? QueryString
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlockQueryStringBlock>>("query_string");
        set => SetArgument("query_string", value);
    }

}

/// <summary>
/// Block type for body in AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlockBodyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "body";

    /// <summary>
    /// The is_value_secret attribute.
    /// </summary>
    public TerraformValue<bool>? IsValueSecret
    {
        get => new TerraformReference<bool>(this, "is_value_secret");
        set => SetArgument("is_value_secret", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for header in AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The is_value_secret attribute.
    /// </summary>
    public TerraformValue<bool>? IsValueSecret
    {
        get => new TerraformReference<bool>(this, "is_value_secret");
        set => SetArgument("is_value_secret", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for query_string in AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockInvocationHttpParametersBlockQueryStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_string";

    /// <summary>
    /// The is_value_secret attribute.
    /// </summary>
    public TerraformValue<bool>? IsValueSecret
    {
        get => new TerraformReference<bool>(this, "is_value_secret");
        set => SetArgument("is_value_secret", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for oauth in AwsCloudwatchEventConnectionAuthParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockOauthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth";

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformValue<string> AuthorizationEndpoint
    {
        get => new TerraformReference<string>(this, "authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformValue<string> HttpMethod
    {
        get => new TerraformReference<string>(this, "http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// ClientParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientParameters block(s) allowed")]
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockClientParametersBlock>? ClientParameters
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockClientParametersBlock>>("client_parameters");
        set => SetArgument("client_parameters", value);
    }

    /// <summary>
    /// OauthHttpParameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthHttpParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OauthHttpParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthHttpParameters block(s) allowed")]
    public required TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlock> OauthHttpParameters
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlock>>("oauth_http_parameters");
        set => SetArgument("oauth_http_parameters", value);
    }

}

/// <summary>
/// Block type for client_parameters in AwsCloudwatchEventConnectionAuthParametersBlockOauthBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockClientParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_parameters";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

}

/// <summary>
/// Block type for oauth_http_parameters in AwsCloudwatchEventConnectionAuthParametersBlockOauthBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_http_parameters";

    /// <summary>
    /// Body block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlockBodyBlock>? Body
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlockBodyBlock>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// QueryString block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlockQueryStringBlock>? QueryString
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlockQueryStringBlock>>("query_string");
        set => SetArgument("query_string", value);
    }

}

/// <summary>
/// Block type for body in AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlockBodyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "body";

    /// <summary>
    /// The is_value_secret attribute.
    /// </summary>
    public TerraformValue<bool>? IsValueSecret
    {
        get => new TerraformReference<bool>(this, "is_value_secret");
        set => SetArgument("is_value_secret", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for header in AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The is_value_secret attribute.
    /// </summary>
    public TerraformValue<bool>? IsValueSecret
    {
        get => new TerraformReference<bool>(this, "is_value_secret");
        set => SetArgument("is_value_secret", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for query_string in AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlockOauthBlockOauthHttpParametersBlockQueryStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_string";

    /// <summary>
    /// The is_value_secret attribute.
    /// </summary>
    public TerraformValue<bool>? IsValueSecret
    {
        get => new TerraformReference<bool>(this, "is_value_secret");
        set => SetArgument("is_value_secret", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for invocation_connectivity_parameters in AwsCloudwatchEventConnection.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "invocation_connectivity_parameters";

    /// <summary>
    /// ResourceParameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceParameters block(s) allowed")]
    public required TerraformList<AwsCloudwatchEventConnectionInvocationConnectivityParametersBlockResourceParametersBlock> ResourceParameters
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchEventConnectionInvocationConnectivityParametersBlockResourceParametersBlock>>("resource_parameters");
        set => SetArgument("resource_parameters", value);
    }

}

/// <summary>
/// Block type for resource_parameters in AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionInvocationConnectivityParametersBlockResourceParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_parameters";

    /// <summary>
    /// The resource_association_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceAssociationArn
    {
        get => new TerraformReference<string>(this, "resource_association_arn");
    }

    /// <summary>
    /// The resource_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceConfigurationArn is required")]
    public required TerraformValue<string> ResourceConfigurationArn
    {
        get => new TerraformReference<string>(this, "resource_configuration_arn");
        set => SetArgument("resource_configuration_arn", value);
    }

}


/// <summary>
/// Represents a aws_cloudwatch_event_connection Terraform resource.
/// Manages a aws_cloudwatch_event_connection resource.
/// </summary>
public partial class AwsCloudwatchEventConnection(string name) : TerraformResource("aws_cloudwatch_event_connection", name)
{
    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationType is required")]
    public required TerraformValue<string> AuthorizationType
    {
        get => new TerraformReference<string>(this, "authorization_type");
        set => SetArgument("authorization_type", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyIdentifier
    {
        get => new TerraformReference<string>(this, "kms_key_identifier");
        set => SetArgument("kms_key_identifier", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string> SecretArn
    {
        get => new TerraformReference<string>(this, "secret_arn");
    }

    /// <summary>
    /// AuthParameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthParameters block(s) allowed")]
    public required TerraformList<AwsCloudwatchEventConnectionAuthParametersBlock> AuthParameters
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchEventConnectionAuthParametersBlock>>("auth_parameters");
        set => SetArgument("auth_parameters", value);
    }

    /// <summary>
    /// InvocationConnectivityParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InvocationConnectivityParameters block(s) allowed")]
    public TerraformList<AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock>? InvocationConnectivityParameters
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock>>("invocation_connectivity_parameters");
        set => SetArgument("invocation_connectivity_parameters", value);
    }

}
