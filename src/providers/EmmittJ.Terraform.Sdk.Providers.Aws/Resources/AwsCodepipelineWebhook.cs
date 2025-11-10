using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCodepipelineWebhookAuthenticationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_ip_range attribute.
    /// </summary>
    public TerraformProperty<string>? AllowedIpRange
    {
        get => GetProperty<TerraformProperty<string>>("allowed_ip_range");
        set => WithProperty("allowed_ip_range", value);
    }

    /// <summary>
    /// The secret_token attribute.
    /// </summary>
    public TerraformProperty<string>? SecretToken
    {
        get => GetProperty<TerraformProperty<string>>("secret_token");
        set => WithProperty("secret_token", value);
    }

}

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsCodepipelineWebhookFilterBlock : TerraformBlock
{
    /// <summary>
    /// The json_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JsonPath is required")]
    public required TerraformProperty<string> JsonPath
    {
        get => GetRequiredProperty<TerraformProperty<string>>("json_path");
        set => WithProperty("json_path", value);
    }

    /// <summary>
    /// The match_equals attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchEquals is required")]
    public required TerraformProperty<string> MatchEquals
    {
        get => GetRequiredProperty<TerraformProperty<string>>("match_equals");
        set => WithProperty("match_equals", value);
    }

}

/// <summary>
/// Manages a aws_codepipeline_webhook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodepipelineWebhook : TerraformResource
{
    public AwsCodepipelineWebhook(string name) : base("aws_codepipeline_webhook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("url");
    }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authentication is required")]
    public required TerraformProperty<string> Authentication
    {
        get => GetRequiredProperty<TerraformProperty<string>>("authentication");
        set => this.WithProperty("authentication", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAction is required")]
    public required TerraformProperty<string> TargetAction
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_action");
        set => this.WithProperty("target_action", value);
    }

    /// <summary>
    /// The target_pipeline attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPipeline is required")]
    public required TerraformProperty<string> TargetPipeline
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_pipeline");
        set => this.WithProperty("target_pipeline", value);
    }

    /// <summary>
    /// Block for authentication_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfiguration block(s) allowed")]
    public List<AwsCodepipelineWebhookAuthenticationConfigurationBlock>? AuthenticationConfiguration
    {
        get => GetProperty<List<AwsCodepipelineWebhookAuthenticationConfigurationBlock>>("authentication_configuration");
        set => this.WithProperty("authentication_configuration", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Filter block(s) allowed")]
    public HashSet<AwsCodepipelineWebhookFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsCodepipelineWebhookFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
