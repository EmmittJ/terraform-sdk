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
        set => SetProperty("path_id", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    public required TerraformProperty<string> ProductId
    {
        set => SetProperty("product_id", value);
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisioningArtifactId
    {
        set => SetProperty("provisioning_artifact_id", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_project resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerProject : TerraformResource
{
    public AwsSagemakerProject(string name) : base("aws_sagemaker_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("project_id");
        SetOutput("id");
        SetOutput("project_description");
        SetOutput("project_name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The project_description attribute.
    /// </summary>
    public TerraformProperty<string> ProjectDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_description");
        set => SetProperty("project_description", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformProperty<string> ProjectName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_name");
        set => SetProperty("project_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for service_catalog_provisioning_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCatalogProvisioningDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceCatalogProvisioningDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceCatalogProvisioningDetails block(s) allowed")]
    public List<AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock>? ServiceCatalogProvisioningDetails
    {
        set => SetProperty("service_catalog_provisioning_details", value);
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
