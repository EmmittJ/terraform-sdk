using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for permitted_public_security_group_rule_range in AwsEmrBlockPublicAccessConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permitted_public_security_group_rule_range";

    /// <summary>
    /// The max_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRange is required")]
    public required TerraformValue<double> MaxRange
    {
        get => new TerraformReference<double>(this, "max_range");
        set => SetArgument("max_range", value);
    }

    /// <summary>
    /// The min_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinRange is required")]
    public required TerraformValue<double> MinRange
    {
        get => new TerraformReference<double>(this, "min_range");
        set => SetArgument("min_range", value);
    }

}


/// <summary>
/// Represents a aws_emr_block_public_access_configuration Terraform resource.
/// Manages a aws_emr_block_public_access_configuration resource.
/// </summary>
public partial class AwsEmrBlockPublicAccessConfiguration(string name) : TerraformResource("aws_emr_block_public_access_configuration", name)
{
    /// <summary>
    /// The block_public_security_group_rules attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockPublicSecurityGroupRules is required")]
    public required TerraformValue<bool> BlockPublicSecurityGroupRules
    {
        get => new TerraformReference<bool>(this, "block_public_security_group_rules");
        set => SetArgument("block_public_security_group_rules", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// PermittedPublicSecurityGroupRuleRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock>? PermittedPublicSecurityGroupRuleRange
    {
        get => GetArgument<TerraformList<AwsEmrBlockPublicAccessConfigurationPermittedPublicSecurityGroupRuleRangeBlock>>("permitted_public_security_group_rule_range");
        set => SetArgument("permitted_public_security_group_rule_range", value);
    }

}
