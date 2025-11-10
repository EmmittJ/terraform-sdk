using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for service_catalog_provisioning_details in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The path_id attribute.
    /// </summary>
    public TerraformProperty<string>? PathId
    {
        get => GetProperty<TerraformProperty<string>>("path_id");
        set => WithProperty("path_id", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    public required TerraformProperty<string> ProductId
    {
        get => GetProperty<TerraformProperty<string>>("product_id");
        set => WithProperty("product_id", value);
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisioningArtifactId
    {
        get => GetProperty<TerraformProperty<string>>("provisioning_artifact_id");
        set => WithProperty("provisioning_artifact_id", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_project resource.
/// </summary>
public class AwsSagemakerProject : TerraformResource
{
    public AwsSagemakerProject(string name) : base("aws_sagemaker_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("project_id");
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
    /// The project_description attribute.
    /// </summary>
    public TerraformProperty<string>? ProjectDescription
    {
        get => GetProperty<TerraformProperty<string>>("project_description");
        set => this.WithProperty("project_description", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformProperty<string> ProjectName
    {
        get => GetProperty<TerraformProperty<string>>("project_name");
        set => this.WithProperty("project_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for service_catalog_provisioning_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceCatalogProvisioningDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceCatalogProvisioningDetails block(s) allowed")]
    public List<AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock>? ServiceCatalogProvisioningDetails
    {
        get => GetProperty<List<AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock>>("service_catalog_provisioning_details");
        set => this.WithProperty("service_catalog_provisioning_details", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The project_id attribute.
    /// </summary>
    public TerraformExpression ProjectId => this["project_id"];

}
