using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProvisioningArtifactTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("created_time");
        SetOutput("provisioning_artifact_id");
        SetOutput("accept_language");
        SetOutput("active");
        SetOutput("description");
        SetOutput("disable_template_validation");
        SetOutput("guidance");
        SetOutput("id");
        SetOutput("name");
        SetOutput("product_id");
        SetOutput("region");
        SetOutput("template_physical_id");
        SetOutput("template_url");
        SetOutput("type");
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformProperty<string> AcceptLanguage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("accept_language");
        set => SetProperty("accept_language", value);
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool> Active
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("active");
        set => SetProperty("active", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The disable_template_validation attribute.
    /// </summary>
    public TerraformProperty<bool> DisableTemplateValidation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_template_validation");
        set => SetProperty("disable_template_validation", value);
    }

    /// <summary>
    /// The guidance attribute.
    /// </summary>
    public TerraformProperty<string> Guidance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("guidance");
        set => SetProperty("guidance", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    public required TerraformProperty<string> ProductId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("product_id");
        set => SetProperty("product_id", value);
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
    /// The template_physical_id attribute.
    /// </summary>
    public TerraformProperty<string> TemplatePhysicalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_physical_id");
        set => SetProperty("template_physical_id", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformProperty<string> TemplateUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_url");
        set => SetProperty("template_url", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsServicecatalogProvisioningArtifactTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
