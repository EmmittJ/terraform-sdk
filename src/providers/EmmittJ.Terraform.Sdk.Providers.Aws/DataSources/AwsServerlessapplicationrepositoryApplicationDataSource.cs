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
        SetOutput("name");
        SetOutput("required_capabilities");
        SetOutput("source_code_url");
        SetOutput("template_url");
        SetOutput("application_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("semantic_version");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The semantic_version attribute.
    /// </summary>
    public TerraformProperty<string> SemanticVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("semantic_version");
        set => SetProperty("semantic_version", value);
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
