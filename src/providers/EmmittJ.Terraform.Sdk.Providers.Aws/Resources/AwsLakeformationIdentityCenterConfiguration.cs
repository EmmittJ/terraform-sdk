using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lakeformation_identity_center_configuration resource.
/// </summary>
public partial class AwsLakeformationIdentityCenterConfiguration : TerraformResource
{
    public AwsLakeformationIdentityCenterConfiguration(string name) : base("aws_lakeformation_identity_center_configuration", name)
    {
    }

    /// <summary>
    /// The ID of the Data Catalog.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The ARN of the Identity Center instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    [TerraformProperty("instance_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [TerraformProperty("application_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApplicationArn { get; }

    /// <summary>
    /// The resource_share attribute.
    /// </summary>
    [TerraformProperty("resource_share")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceShare { get; }

}
