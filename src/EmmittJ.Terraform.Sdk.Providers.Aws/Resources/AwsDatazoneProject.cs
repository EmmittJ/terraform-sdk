using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datazone_project resource.
/// </summary>
public class AwsDatazoneProject : TerraformResource
{
    public AwsDatazoneProject(string name) : base("aws_datazone_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("created_by");
        this.DeclareOutput("failure_reasons");
        this.DeclareOutput("id");
        this.DeclareOutput("last_updated_at");
        this.DeclareOutput("project_status");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_identifier");
        set => this.WithProperty("domain_identifier", value);
    }

    /// <summary>
    /// The glossary_terms attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? GlossaryTerms
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("glossary_terms");
        set => this.WithProperty("glossary_terms", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The skip_deletion_check attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipDeletionCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_deletion_check");
        set => this.WithProperty("skip_deletion_check", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The failure_reasons attribute.
    /// </summary>
    public TerraformExpression FailureReasons => this["failure_reasons"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    public TerraformExpression LastUpdatedAt => this["last_updated_at"];

    /// <summary>
    /// The project_status attribute.
    /// </summary>
    public TerraformExpression ProjectStatus => this["project_status"];

}
