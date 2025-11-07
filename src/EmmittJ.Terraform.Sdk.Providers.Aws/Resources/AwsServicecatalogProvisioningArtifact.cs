using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_provisioning_artifact resource.
/// </summary>
public class AwsServicecatalogProvisioningArtifact : TerraformResource
{
    public AwsServicecatalogProvisioningArtifact(string name) : base("aws_servicecatalog_provisioning_artifact", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_time");
        this.DeclareOutput("provisioning_artifact_id");
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AcceptLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accept_language");
        set => this.WithProperty("accept_language", value);
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Active
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("active");
        set => this.WithProperty("active", value);
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
    /// The disable_template_validation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableTemplateValidation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_template_validation");
        set => this.WithProperty("disable_template_validation", value);
    }

    /// <summary>
    /// The guidance attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Guidance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("guidance");
        set => this.WithProperty("guidance", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProductId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_id");
        set => this.WithProperty("product_id", value);
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
    /// The template_physical_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemplatePhysicalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_physical_id");
        set => this.WithProperty("template_physical_id", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemplateUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_url");
        set => this.WithProperty("template_url", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformExpression ProvisioningArtifactId => this["provisioning_artifact_id"];

}
