using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for handler_configs in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceHandlerConfigsBlock
{
}

/// <summary>
/// Block type for publish_auth_mode in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespacePublishAuthModeBlock
{
    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformPropertyName("auth_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthType { get; set; }

}

/// <summary>
/// Block type for subscribe_auth_mode in .
/// Nesting mode: list
/// </summary>
public class AwsAppsyncChannelNamespaceSubscribeAuthModeBlock
{
    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformPropertyName("auth_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthType { get; set; }

}

/// <summary>
/// Manages a aws_appsync_channel_namespace resource.
/// </summary>
public class AwsAppsyncChannelNamespace : TerraformResource
{
    public AwsAppsyncChannelNamespace(string name) : base("aws_appsync_channel_namespace", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The code_handlers attribute.
    /// </summary>
    [TerraformPropertyName("code_handlers")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CodeHandlers { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for handler_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("handler_configs")]
    public TerraformList<TerraformBlock<AwsAppsyncChannelNamespaceHandlerConfigsBlock>>? HandlerConfigs { get; set; }

    /// <summary>
    /// Block for publish_auth_mode.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("publish_auth_mode")]
    public TerraformList<TerraformBlock<AwsAppsyncChannelNamespacePublishAuthModeBlock>>? PublishAuthMode { get; set; }

    /// <summary>
    /// Block for subscribe_auth_mode.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("subscribe_auth_mode")]
    public TerraformList<TerraformBlock<AwsAppsyncChannelNamespaceSubscribeAuthModeBlock>>? SubscribeAuthMode { get; set; }

    /// <summary>
    /// The channel_namespace_arn attribute.
    /// </summary>
    [TerraformPropertyName("channel_namespace_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ChannelNamespaceArn => new TerraformReference(this, "channel_namespace_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
