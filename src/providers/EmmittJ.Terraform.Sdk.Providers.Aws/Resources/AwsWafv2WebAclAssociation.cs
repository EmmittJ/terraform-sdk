using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsWafv2WebAclAssociationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_wafv2_web_acl_association resource.
/// </summary>
public partial class AwsWafv2WebAclAssociation : TerraformResource
{
    public AwsWafv2WebAclAssociation(string name) : base("aws_wafv2_web_acl_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformProperty("resource_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// The web_acl_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAclArn is required")]
    [TerraformProperty("web_acl_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebAclArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsWafv2WebAclAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
