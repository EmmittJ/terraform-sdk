using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for handler_configs in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceHandlerConfigsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for publish_auth_mode in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespacePublishAuthModeBlock : TerraformBlock
{
    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformProperty<string> AuthType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("auth_type");
        set => WithProperty("auth_type", value);
    }

}

/// <summary>
/// Block type for subscribe_auth_mode in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceSubscribeAuthModeBlock : TerraformBlock
{
    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformProperty<string> AuthType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("auth_type");
        set => WithProperty("auth_type", value);
    }

}

/// <summary>
/// Manages a aws_appsync_channel_namespace resource.
/// </summary>
public class AwsAppsyncChannelNamespace : TerraformResource
{
    public AwsAppsyncChannelNamespace(string name) : base("aws_appsync_channel_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("channel_namespace_arn");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The code_handlers attribute.
    /// </summary>
    public TerraformProperty<string>? CodeHandlers
    {
        get => GetProperty<TerraformProperty<string>>("code_handlers");
        set => this.WithProperty("code_handlers", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for handler_configs.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppsyncChannelNamespaceHandlerConfigsBlock>? HandlerConfigs
    {
        get => GetProperty<List<AwsAppsyncChannelNamespaceHandlerConfigsBlock>>("handler_configs");
        set => this.WithProperty("handler_configs", value);
    }

    /// <summary>
    /// Block for publish_auth_mode.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppsyncChannelNamespacePublishAuthModeBlock>? PublishAuthMode
    {
        get => GetProperty<List<AwsAppsyncChannelNamespacePublishAuthModeBlock>>("publish_auth_mode");
        set => this.WithProperty("publish_auth_mode", value);
    }

    /// <summary>
    /// Block for subscribe_auth_mode.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAppsyncChannelNamespaceSubscribeAuthModeBlock>? SubscribeAuthMode
    {
        get => GetProperty<List<AwsAppsyncChannelNamespaceSubscribeAuthModeBlock>>("subscribe_auth_mode");
        set => this.WithProperty("subscribe_auth_mode", value);
    }

    /// <summary>
    /// The channel_namespace_arn attribute.
    /// </summary>
    public TerraformExpression ChannelNamespaceArn => this["channel_namespace_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
