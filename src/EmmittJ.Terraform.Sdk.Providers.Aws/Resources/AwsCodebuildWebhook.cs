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
    public TerraformLiteralProperty<string>? BranchFilter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("branch_filter");
        set => this.WithProperty("branch_filter", value);
    }

    /// <summary>
    /// The build_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BuildType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("build_type");
        set => this.WithProperty("build_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The manual_creation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ManualCreation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manual_creation");
        set => this.WithProperty("manual_creation", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProjectName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_name");
        set => this.WithProperty("project_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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
