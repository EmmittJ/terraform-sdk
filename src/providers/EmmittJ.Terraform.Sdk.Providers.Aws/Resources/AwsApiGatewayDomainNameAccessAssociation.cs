using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_domain_name_access_association resource.
/// </summary>
public partial class AwsApiGatewayDomainNameAccessAssociation : TerraformResource
{
    public AwsApiGatewayDomainNameAccessAssociation(string name) : base("aws_api_gateway_domain_name_access_association", name)
    {
    }

    /// <summary>
    /// The access_association_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessAssociationSource is required")]
    [TerraformProperty("access_association_source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessAssociationSource { get; set; }

    /// <summary>
    /// The access_association_source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessAssociationSourceType is required")]
    [TerraformProperty("access_association_source_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessAssociationSourceType { get; set; }

    /// <summary>
    /// The domain_name_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNameArn is required")]
    [TerraformProperty("domain_name_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainNameArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
