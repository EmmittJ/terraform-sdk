using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datazone_environment resource.
/// </summary>
public class AwsDatazoneEnvironment : TerraformResource
{
    public AwsDatazoneEnvironment(string name) : base("aws_datazone_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("created_by");
        this.DeclareOutput("id");
        this.DeclareOutput("last_deployment");
        this.DeclareOutput("provider_environment");
        this.DeclareOutput("provisioned_resources");
    }

    /// <summary>
    /// The account_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_identifier");
        set => this.WithProperty("account_identifier", value);
    }

    /// <summary>
    /// The account_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_region");
        set => this.WithProperty("account_region", value);
    }

    /// <summary>
    /// The blueprint_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BlueprintIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blueprint_identifier");
        set => this.WithProperty("blueprint_identifier", value);
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
    /// The profile_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProfileIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_identifier");
        set => this.WithProperty("profile_identifier", value);
    }

    /// <summary>
    /// The project_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProjectIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_identifier");
        set => this.WithProperty("project_identifier", value);
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
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_deployment attribute.
    /// </summary>
    public TerraformExpression LastDeployment => this["last_deployment"];

    /// <summary>
    /// The provider_environment attribute.
    /// </summary>
    public TerraformExpression ProviderEnvironment => this["provider_environment"];

    /// <summary>
    /// The provisioned_resources attribute.
    /// </summary>
    public TerraformExpression ProvisionedResources => this["provisioned_resources"];

}
