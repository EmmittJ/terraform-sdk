using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for permitted_public_security_group_rule_range in .
/// Nesting mode: list
/// </summary>
public class AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock : ITerraformBlock
{
    /// <summary>
    /// The max_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRange is required")]
    [TerraformPropertyName("max_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxRange { get; set; }

    /// <summary>
    /// The min_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinRange is required")]
    [TerraformPropertyName("min_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinRange { get; set; }

}

/// <summary>
/// Manages a aws_emr_block_public_access_configuration resource.
/// </summary>
public class AwsEmrBlockPublicAccessConfiguration : TerraformResource
{
    public AwsEmrBlockPublicAccessConfiguration(string name) : base("aws_emr_block_public_access_configuration", name)
    {
    }

    /// <summary>
    /// The block_public_security_group_rules attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockPublicSecurityGroupRules is required")]
    [TerraformPropertyName("block_public_security_group_rules")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> BlockPublicSecurityGroupRules { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for permitted_public_security_group_rule_range.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("permitted_public_security_group_rule_range")]
    public TerraformList<TerraformBlock<AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock>>? PermittedPublicSecurityGroupRuleRange { get; set; } = new();

}
