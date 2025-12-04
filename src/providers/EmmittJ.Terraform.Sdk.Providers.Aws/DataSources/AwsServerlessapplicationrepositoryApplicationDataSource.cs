using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_serverlessapplicationrepository_application Terraform data source.
/// Retrieves information about a aws_serverlessapplicationrepository_application.
/// </summary>
public partial class AwsServerlessapplicationrepositoryApplicationDataSource(string name) : TerraformDataSource("aws_serverlessapplicationrepository_application", name)
{
    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The semantic_version attribute.
    /// </summary>
    public TerraformValue<string>? SemanticVersion
    {
        get => GetArgument<TerraformValue<string>>("semantic_version");
        set => SetArgument("semantic_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The required_capabilities attribute.
    /// </summary>
    public TerraformSet<string> RequiredCapabilities
        => AsReference("required_capabilities");

    /// <summary>
    /// The source_code_url attribute.
    /// </summary>
    public TerraformValue<string> SourceCodeUrl
        => AsReference("source_code_url");

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformValue<string> TemplateUrl
        => AsReference("template_url");

}
