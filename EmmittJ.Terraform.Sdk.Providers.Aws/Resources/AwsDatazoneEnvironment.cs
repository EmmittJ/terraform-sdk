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
    public string? AccountIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_identifier")?.Value;
        set => this.WithProperty("account_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The account_region attribute.
    /// </summary>
    public string? AccountRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_region")?.Value;
        set => this.WithProperty("account_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The blueprint_identifier attribute.
    /// </summary>
    public string? BlueprintIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("blueprint_identifier")?.Value;
        set => this.WithProperty("blueprint_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    public string? DomainIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_identifier")?.Value;
        set => this.WithProperty("domain_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The glossary_terms attribute.
    /// </summary>
    public List<string>? GlossaryTerms
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("glossary_terms")?.Value;
        set => this.WithProperty("glossary_terms", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The profile_identifier attribute.
    /// </summary>
    public string? ProfileIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_identifier")?.Value;
        set => this.WithProperty("profile_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project_identifier attribute.
    /// </summary>
    public string? ProjectIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_identifier")?.Value;
        set => this.WithProperty("project_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
