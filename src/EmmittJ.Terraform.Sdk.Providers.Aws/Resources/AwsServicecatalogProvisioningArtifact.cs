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
    public TerraformProperty<string>? AcceptLanguage
    {
        get => GetProperty<TerraformProperty<string>>("accept_language");
        set => this.WithProperty("accept_language", value);
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        get => GetProperty<TerraformProperty<bool>>("active");
        set => this.WithProperty("active", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disable_template_validation attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableTemplateValidation
    {
        get => GetProperty<TerraformProperty<bool>>("disable_template_validation");
        set => this.WithProperty("disable_template_validation", value);
    }

    /// <summary>
    /// The guidance attribute.
    /// </summary>
    public TerraformProperty<string>? Guidance
    {
        get => GetProperty<TerraformProperty<string>>("guidance");
        set => this.WithProperty("guidance", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProductId
    {
        get => GetProperty<TerraformProperty<string>>("product_id");
        set => this.WithProperty("product_id", value);
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
    /// The template_physical_id attribute.
    /// </summary>
    public TerraformProperty<string>? TemplatePhysicalId
    {
        get => GetProperty<TerraformProperty<string>>("template_physical_id");
        set => this.WithProperty("template_physical_id", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateUrl
    {
        get => GetProperty<TerraformProperty<string>>("template_url");
        set => this.WithProperty("template_url", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
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
