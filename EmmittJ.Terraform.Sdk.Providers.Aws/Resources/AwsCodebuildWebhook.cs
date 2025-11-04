using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codebuild_webhook resource.
/// </summary>
public class AwsCodebuildWebhook : TerraformResource
{
    public AwsCodebuildWebhook(string name) : base("aws_codebuild_webhook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("payload_url");
        this.DeclareOutput("secret");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The branch_filter attribute.
    /// </summary>
    public string? BranchFilter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("branch_filter")?.Value;
        set => this.WithProperty("branch_filter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The build_type attribute.
    /// </summary>
    public string? BuildType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("build_type")?.Value;
        set => this.WithProperty("build_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The manual_creation attribute.
    /// </summary>
    public bool? ManualCreation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manual_creation")?.Value;
        set => this.WithProperty("manual_creation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    public string? ProjectName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_name")?.Value;
        set => this.WithProperty("project_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The payload_url attribute.
    /// </summary>
    public TerraformExpression PayloadUrl => this["payload_url"];

    /// <summary>
    /// The secret attribute.
    /// </summary>
    public TerraformExpression Secret => this["secret"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
