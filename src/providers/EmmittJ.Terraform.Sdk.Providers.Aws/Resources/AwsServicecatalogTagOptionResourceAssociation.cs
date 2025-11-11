using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsServicecatalogTagOptionResourceAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a aws_servicecatalog_tag_option_resource_association resource.
/// </summary>
public partial class AwsServicecatalogTagOptionResourceAssociation : TerraformResource
{
    public AwsServicecatalogTagOptionResourceAssociation(string name) : base("aws_servicecatalog_tag_option_resource_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The tag_option_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagOptionId is required")]
    [TerraformProperty("tag_option_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TagOptionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsServicecatalogTagOptionResourceAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformProperty("resource_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceArn { get; }

    /// <summary>
    /// The resource_created_time attribute.
    /// </summary>
    [TerraformProperty("resource_created_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceCreatedTime { get; }

    /// <summary>
    /// The resource_description attribute.
    /// </summary>
    [TerraformProperty("resource_description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceDescription { get; }

    /// <summary>
    /// The resource_name attribute.
    /// </summary>
    [TerraformProperty("resource_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceName { get; }

}
