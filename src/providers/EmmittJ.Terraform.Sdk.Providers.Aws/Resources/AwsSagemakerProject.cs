using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for service_catalog_provisioning_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock : TerraformBlockBase
{
    /// <summary>
    /// The path_id attribute.
    /// </summary>
    [TerraformProperty("path_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PathId { get; set; }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    [TerraformProperty("product_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProductId { get; set; }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    [TerraformProperty("provisioning_artifact_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProvisioningArtifactId { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_project resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerProject : TerraformResource
{
    public AwsSagemakerProject(string name) : base("aws_sagemaker_project", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project_description attribute.
    /// </summary>
    [TerraformProperty("project_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProjectDescription { get; set; }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformProperty("project_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for service_catalog_provisioning_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCatalogProvisioningDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceCatalogProvisioningDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceCatalogProvisioningDetails block(s) allowed")]
    [TerraformProperty("service_catalog_provisioning_details")]
    public partial TerraformList<TerraformBlock<AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock>>? ServiceCatalogProvisioningDetails { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The project_id attribute.
    /// </summary>
    [TerraformProperty("project_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProjectId { get; }

}
