using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for handler_configs in AwsAppsyncChannelNamespace.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceHandlerConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "handler_configs";

    /// <summary>
    /// OnPublish block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlock>? OnPublish
    {
        get => GetArgument<TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlock>>("on_publish");
        set => SetArgument("on_publish", value);
    }

    /// <summary>
    /// OnSubscribe block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlock>? OnSubscribe
    {
        get => GetArgument<TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlock>>("on_subscribe");
        set => SetArgument("on_subscribe", value);
    }

}

/// <summary>
/// Block type for on_publish in AwsAppsyncChannelNamespaceHandlerConfigsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_publish";

    /// <summary>
    /// The behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformValue<string> Behavior
    {
        get => GetArgument<TerraformValue<string>>("behavior");
        set => SetArgument("behavior", value);
    }

    /// <summary>
    /// Integration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlockIntegrationBlock>? Integration
    {
        get => GetArgument<TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlockIntegrationBlock>>("integration");
        set => SetArgument("integration", value);
    }

}

/// <summary>
/// Block type for integration in AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlockIntegrationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "integration";

    /// <summary>
    /// The data_source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceName is required")]
    public required TerraformValue<string> DataSourceName
    {
        get => GetArgument<TerraformValue<string>>("data_source_name");
        set => SetArgument("data_source_name", value);
    }

    /// <summary>
    /// LambdaConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlockIntegrationBlockLambdaConfigBlock>? LambdaConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlockIntegrationBlockLambdaConfigBlock>>("lambda_config");
        set => SetArgument("lambda_config", value);
    }

}

/// <summary>
/// Block type for lambda_config in AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlockIntegrationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceHandlerConfigsBlockOnPublishBlockIntegrationBlockLambdaConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_config";

    /// <summary>
    /// The invoke_type attribute.
    /// </summary>
    public TerraformValue<string>? InvokeType
    {
        get => GetArgument<TerraformValue<string>>("invoke_type");
        set => SetArgument("invoke_type", value);
    }

}

/// <summary>
/// Block type for on_subscribe in AwsAppsyncChannelNamespaceHandlerConfigsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_subscribe";

    /// <summary>
    /// The behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformValue<string> Behavior
    {
        get => GetArgument<TerraformValue<string>>("behavior");
        set => SetArgument("behavior", value);
    }

    /// <summary>
    /// Integration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlockIntegrationBlock>? Integration
    {
        get => GetArgument<TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlockIntegrationBlock>>("integration");
        set => SetArgument("integration", value);
    }

}

/// <summary>
/// Block type for integration in AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlockIntegrationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "integration";

    /// <summary>
    /// The data_source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceName is required")]
    public required TerraformValue<string> DataSourceName
    {
        get => GetArgument<TerraformValue<string>>("data_source_name");
        set => SetArgument("data_source_name", value);
    }

    /// <summary>
    /// LambdaConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlockIntegrationBlockLambdaConfigBlock>? LambdaConfig
    {
        get => GetArgument<TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlockIntegrationBlockLambdaConfigBlock>>("lambda_config");
        set => SetArgument("lambda_config", value);
    }

}

/// <summary>
/// Block type for lambda_config in AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlockIntegrationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceHandlerConfigsBlockOnSubscribeBlockIntegrationBlockLambdaConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_config";

    /// <summary>
    /// The invoke_type attribute.
    /// </summary>
    public TerraformValue<string>? InvokeType
    {
        get => GetArgument<TerraformValue<string>>("invoke_type");
        set => SetArgument("invoke_type", value);
    }

}


/// <summary>
/// Block type for publish_auth_mode in AwsAppsyncChannelNamespace.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespacePublishAuthModeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publish_auth_mode";

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

}


/// <summary>
/// Block type for subscribe_auth_mode in AwsAppsyncChannelNamespace.
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceSubscribeAuthModeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subscribe_auth_mode";

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

}


/// <summary>
/// Represents a aws_appsync_channel_namespace Terraform resource.
/// Manages a aws_appsync_channel_namespace resource.
/// </summary>
public partial class AwsAppsyncChannelNamespace(string name) : TerraformResource("aws_appsync_channel_namespace", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => GetArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The code_handlers attribute.
    /// </summary>
    public TerraformValue<string>? CodeHandlers
    {
        get => GetArgument<TerraformValue<string>>("code_handlers");
        set => SetArgument("code_handlers", value);
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
    /// The channel_namespace_arn attribute.
    /// </summary>
    public TerraformValue<string> ChannelNamespaceArn
        => AsReference("channel_namespace_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// HandlerConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlock>? HandlerConfigs
    {
        get => GetArgument<TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlock>>("handler_configs");
        set => SetArgument("handler_configs", value);
    }

    /// <summary>
    /// PublishAuthMode block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncChannelNamespacePublishAuthModeBlock>? PublishAuthMode
    {
        get => GetArgument<TerraformList<AwsAppsyncChannelNamespacePublishAuthModeBlock>>("publish_auth_mode");
        set => SetArgument("publish_auth_mode", value);
    }

    /// <summary>
    /// SubscribeAuthMode block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppsyncChannelNamespaceSubscribeAuthModeBlock>? SubscribeAuthMode
    {
        get => GetArgument<TerraformList<AwsAppsyncChannelNamespaceSubscribeAuthModeBlock>>("subscribe_auth_mode");
        set => SetArgument("subscribe_auth_mode", value);
    }

}
