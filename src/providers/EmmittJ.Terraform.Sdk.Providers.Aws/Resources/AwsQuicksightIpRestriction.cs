using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_ip_restriction resource.
/// </summary>
public class AwsQuicksightIpRestriction : TerraformResource
{
    public AwsQuicksightIpRestriction(string name) : base("aws_quicksight_ip_restriction", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AwsAccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_account_id");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The ip_restriction_rule_map attribute.
    /// </summary>
    [TerraformPropertyName("ip_restriction_rule_map")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? IpRestrictionRuleMap { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The vpc_endpoint_id_restriction_rule_map attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_id_restriction_rule_map")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? VpcEndpointIdRestrictionRuleMap { get; set; }

    /// <summary>
    /// The vpc_id_restriction_rule_map attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id_restriction_rule_map")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? VpcIdRestrictionRuleMap { get; set; }

}
