using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsServicecatalogProvisioningArtifactTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_servicecatalog_provisioning_artifact resource.
/// </summary>
public partial class AwsServicecatalogProvisioningArtifact : TerraformResource
{
    public AwsServicecatalogProvisioningArtifact(string name) : base("aws_servicecatalog_provisioning_artifact", name)
    {
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    [TerraformProperty("accept_language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceptLanguage { get; set; }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformProperty("active")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Active { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The disable_template_validation attribute.
    /// </summary>
    [TerraformProperty("disable_template_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableTemplateValidation { get; set; }

    /// <summary>
    /// The guidance attribute.
    /// </summary>
    [TerraformProperty("guidance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Guidance { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    [TerraformProperty("product_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProductId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The template_physical_id attribute.
    /// </summary>
    [TerraformProperty("template_physical_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplatePhysicalId { get; set; }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    [TerraformProperty("template_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplateUrl { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsServicecatalogProvisioningArtifactTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    [TerraformProperty("provisioning_artifact_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProvisioningArtifactId { get; }

}
