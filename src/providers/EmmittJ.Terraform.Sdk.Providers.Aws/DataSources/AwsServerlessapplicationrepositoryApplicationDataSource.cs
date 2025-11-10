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
        this.WithOutput("name");
        this.WithOutput("required_capabilities");
        this.WithOutput("source_code_url");
        this.WithOutput("template_url");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The semantic_version attribute.
    /// </summary>
    public TerraformProperty<string>? SemanticVersion
    {
        get => GetProperty<TerraformProperty<string>>("semantic_version");
        set => this.WithProperty("semantic_version", value);
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
