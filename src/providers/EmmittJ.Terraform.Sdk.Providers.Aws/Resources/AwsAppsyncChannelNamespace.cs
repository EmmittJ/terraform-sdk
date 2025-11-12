using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for handler_configs in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncChannelNamespaceHandlerConfigsBlock() : TerraformBlock("handler_configs")
{
}

/// <summary>
/// Block type for publish_auth_mode in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncChannelNamespacePublishAuthModeBlock() : TerraformBlock("publish_auth_mode")
{
    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformProperty("auth_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthType { get; set; }

}

/// <summary>
/// Block type for subscribe_auth_mode in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppsyncChannelNamespaceSubscribeAuthModeBlock() : TerraformBlock("subscribe_auth_mode")
{
    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    [TerraformProperty("auth_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthType { get; set; }

}

/// <summary>
/// Manages a aws_appsync_channel_namespace resource.
/// </summary>
public partial class AwsAppsyncChannelNamespace : TerraformResource
{
    public AwsAppsyncChannelNamespace(string name) : base("aws_appsync_channel_namespace", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The code_handlers attribute.
    /// </summary>
    [TerraformProperty("code_handlers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CodeHandlers { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for handler_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("handler_configs")]
    public TerraformList<AwsAppsyncChannelNamespaceHandlerConfigsBlock> HandlerConfigs { get; set; } = new();

    /// <summary>
    /// Block for publish_auth_mode.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("publish_auth_mode")]
    public TerraformList<AwsAppsyncChannelNamespacePublishAuthModeBlock> PublishAuthMode { get; set; } = new();

    /// <summary>
    /// Block for subscribe_auth_mode.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("subscribe_auth_mode")]
    public TerraformList<AwsAppsyncChannelNamespaceSubscribeAuthModeBlock> SubscribeAuthMode { get; set; } = new();

    /// <summary>
    /// The channel_namespace_arn attribute.
    /// </summary>
    [TerraformProperty("channel_namespace_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ChannelNamespaceArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
