using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for permitted_public_security_group_rule_range in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRange is required")]
    [TerraformProperty("max_range")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxRange { get; set; }

    /// <summary>
    /// The min_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinRange is required")]
    [TerraformProperty("min_range")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinRange { get; set; }

}

/// <summary>
/// Manages a aws_emr_block_public_access_configuration resource.
/// </summary>
public partial class AwsEmrBlockPublicAccessConfiguration : TerraformResource
{
    public AwsEmrBlockPublicAccessConfiguration(string name) : base("aws_emr_block_public_access_configuration", name)
    {
    }

    /// <summary>
    /// The block_public_security_group_rules attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockPublicSecurityGroupRules is required")]
    [TerraformProperty("block_public_security_group_rules")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> BlockPublicSecurityGroupRules { get; set; }

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
    /// Block for permitted_public_security_group_rule_range.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("permitted_public_security_group_rule_range")]
    public TerraformList<TerraformBlock<AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock>>? PermittedPublicSecurityGroupRuleRange { get; set; }

}
