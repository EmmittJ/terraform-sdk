using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_application.
/// </summary>
public class AwsSsoadminApplicationDataSource : TerraformDataSource
{
    public AwsSsoadminApplicationDataSource(string name) : base("aws_ssoadmin_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("application_account");
        this.DeclareOutput("application_provider_arn");
        this.DeclareOutput("description");
        this.DeclareOutput("id");
        this.DeclareOutput("instance_arn");
        this.DeclareOutput("name");
        this.DeclareOutput("portal_options");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    public required TerraformProperty<string> ApplicationArn
    {
        get => GetProperty<TerraformProperty<string>>("application_arn");
        set => this.WithProperty("application_arn", value);
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
    /// The application_account attribute.
    /// </summary>
    public TerraformExpression ApplicationAccount => this["application_account"];

    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    public TerraformExpression ApplicationProviderArn => this["application_provider_arn"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    public TerraformExpression InstanceArn => this["instance_arn"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The portal_options attribute.
    /// </summary>
    public TerraformExpression PortalOptions => this["portal_options"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
