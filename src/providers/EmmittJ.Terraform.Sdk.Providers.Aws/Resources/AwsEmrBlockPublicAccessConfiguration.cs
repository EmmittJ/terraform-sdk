using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for permitted_public_security_group_rule_range in .
/// Nesting mode: list
/// </summary>
public class AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock : TerraformBlock
{
    /// <summary>
    /// The max_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRange is required")]
    public required TerraformProperty<double> MaxRange
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_range");
        set => WithProperty("max_range", value);
    }

    /// <summary>
    /// The min_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinRange is required")]
    public required TerraformProperty<double> MinRange
    {
        get => GetRequiredProperty<TerraformProperty<double>>("min_range");
        set => WithProperty("min_range", value);
    }

}

/// <summary>
/// Manages a aws_emr_block_public_access_configuration resource.
/// </summary>
public class AwsEmrBlockPublicAccessConfiguration : TerraformResource
{
    public AwsEmrBlockPublicAccessConfiguration(string name) : base("aws_emr_block_public_access_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The block_public_security_group_rules attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockPublicSecurityGroupRules is required")]
    public required TerraformProperty<bool> BlockPublicSecurityGroupRules
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("block_public_security_group_rules");
        set => this.WithProperty("block_public_security_group_rules", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for permitted_public_security_group_rule_range.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock>? PermittedPublicSecurityGroupRuleRange
    {
        get => GetProperty<List<AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock>>("permitted_public_security_group_rule_range");
        set => this.WithProperty("permitted_public_security_group_rule_range", value);
    }

}
