using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for service_catalog_provisioning_details in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock : ITerraformBlock
{
    /// <summary>
    /// The path_id attribute.
    /// </summary>
    [TerraformPropertyName("path_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PathId { get; set; }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    [TerraformPropertyName("product_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProductId { get; set; }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_artifact_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProvisioningArtifactId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "provisioning_artifact_id");

}

/// <summary>
/// Manages a aws_sagemaker_project resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerProject : TerraformResource
{
    public AwsSagemakerProject(string name) : base("aws_sagemaker_project", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project_description attribute.
    /// </summary>
    [TerraformPropertyName("project_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProjectDescription { get; set; }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformPropertyName("project_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for service_catalog_provisioning_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCatalogProvisioningDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceCatalogProvisioningDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceCatalogProvisioningDetails block(s) allowed")]
    [TerraformPropertyName("service_catalog_provisioning_details")]
    public TerraformList<TerraformBlock<AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock>>? ServiceCatalogProvisioningDetails { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The project_id attribute.
    /// </summary>
    [TerraformPropertyName("project_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project_id");

}
