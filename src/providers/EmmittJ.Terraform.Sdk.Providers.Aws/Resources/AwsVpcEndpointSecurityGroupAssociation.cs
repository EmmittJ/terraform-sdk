using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_security_group_association resource.
/// </summary>
public partial class AwsVpcEndpointSecurityGroupAssociation : TerraformResource
{
    public AwsVpcEndpointSecurityGroupAssociation(string name) : base("aws_vpc_endpoint_security_group_association", name)
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
    /// The replace_default_association attribute.
    /// </summary>
    [TerraformProperty("replace_default_association")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ReplaceDefaultAssociation { get; set; }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    [TerraformProperty("security_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecurityGroupId { get; set; }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    [TerraformProperty("vpc_endpoint_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcEndpointId { get; set; }

}
