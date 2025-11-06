using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_serverlessapplicationrepository_application.
/// </summary>
public class AwsServerlessapplicationrepositoryApplicationDataSource : TerraformDataSource
{
    public AwsServerlessapplicationrepositoryApplicationDataSource(string name) : base("aws_serverlessapplicationrepository_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("required_capabilities");
        this.DeclareOutput("source_code_url");
        this.DeclareOutput("template_url");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The semantic_version attribute.
    /// </summary>
    public string? SemanticVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("semantic_version")?.Value;
        set => this.WithProperty("semantic_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The required_capabilities attribute.
    /// </summary>
    public TerraformExpression RequiredCapabilities => this["required_capabilities"];

    /// <summary>
    /// The source_code_url attribute.
    /// </summary>
    public TerraformExpression SourceCodeUrl => this["source_code_url"];

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformExpression TemplateUrl => this["template_url"];

}
