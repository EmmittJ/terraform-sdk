using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_ip_restriction resource.
/// </summary>
public partial class AwsQuicksightIpRestriction : TerraformResource
{
    public AwsQuicksightIpRestriction(string name) : base("aws_quicksight_ip_restriction", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The ip_restriction_rule_map attribute.
    /// </summary>
    [TerraformProperty("ip_restriction_rule_map")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? IpRestrictionRuleMap { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The vpc_endpoint_id_restriction_rule_map attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_id_restriction_rule_map")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? VpcEndpointIdRestrictionRuleMap { get; set; }

    /// <summary>
    /// The vpc_id_restriction_rule_map attribute.
    /// </summary>
    [TerraformProperty("vpc_id_restriction_rule_map")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? VpcIdRestrictionRuleMap { get; set; }

}
