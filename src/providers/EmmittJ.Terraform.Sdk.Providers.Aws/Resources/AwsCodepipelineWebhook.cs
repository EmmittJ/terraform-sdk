using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_configuration in AwsCodepipelineWebhook.
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineWebhookAuthenticationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_configuration";

    /// <summary>
    /// The allowed_ip_range attribute.
    /// </summary>
    public TerraformValue<string>? AllowedIpRange
    {
        get => GetArgument<TerraformValue<string>>("allowed_ip_range");
        set => SetArgument("allowed_ip_range", value);
    }

    /// <summary>
    /// The secret_token attribute.
    /// </summary>
    public TerraformValue<string>? SecretToken
    {
        get => GetArgument<TerraformValue<string>>("secret_token");
        set => SetArgument("secret_token", value);
    }

}


/// <summary>
/// Block type for filter in AwsCodepipelineWebhook.
/// Nesting mode: set
/// </summary>
public class AwsCodepipelineWebhookFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The json_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JsonPath is required")]
    public required TerraformValue<string> JsonPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("json_path");
        set => SetArgument("json_path", value);
    }

    /// <summary>
    /// The match_equals attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchEquals is required")]
    public required TerraformValue<string> MatchEquals
    {
        get => GetRequiredArgument<TerraformValue<string>>("match_equals");
        set => SetArgument("match_equals", value);
    }

}


/// <summary>
/// Represents a aws_codepipeline_webhook Terraform resource.
/// Manages a aws_codepipeline_webhook resource.
/// </summary>
public partial class AwsCodepipelineWebhook(string name) : TerraformResource("aws_codepipeline_webhook", name)
{
    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authentication is required")]
    public required TerraformValue<string> Authentication
    {
        get => GetRequiredArgument<TerraformValue<string>>("authentication");
        set => SetArgument("authentication", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAction is required")]
    public required TerraformValue<string> TargetAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_action");
        set => SetArgument("target_action", value);
    }

    /// <summary>
    /// The target_pipeline attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPipeline is required")]
    public required TerraformValue<string> TargetPipeline
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_pipeline");
        set => SetArgument("target_pipeline", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => CreateReference("url");

    /// <summary>
    /// AuthenticationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfiguration block(s) allowed")]
    public TerraformList<AwsCodepipelineWebhookAuthenticationConfigurationBlock>? AuthenticationConfiguration
    {
        get => GetArgument<TerraformList<AwsCodepipelineWebhookAuthenticationConfigurationBlock>>("authentication_configuration");
        set => SetArgument("authentication_configuration", value);
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Filter block(s) allowed")]
    public required TerraformSet<AwsCodepipelineWebhookFilterBlock> Filter
    {
        get => GetRequiredArgument<TerraformSet<AwsCodepipelineWebhookFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
