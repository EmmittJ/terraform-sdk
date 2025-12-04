using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_quicksight_ip_restriction Terraform resource.
/// Manages a aws_quicksight_ip_restriction resource.
/// </summary>
public partial class AwsQuicksightIpRestriction(string name) : TerraformResource("aws_quicksight_ip_restriction", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id") ?? AsReference("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ip_restriction_rule_map attribute.
    /// </summary>
    public TerraformMap<string>? IpRestrictionRuleMap
    {
        get => GetArgument<TerraformMap<string>>("ip_restriction_rule_map");
        set => SetArgument("ip_restriction_rule_map", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The vpc_endpoint_id_restriction_rule_map attribute.
    /// </summary>
    public TerraformMap<string>? VpcEndpointIdRestrictionRuleMap
    {
        get => GetArgument<TerraformMap<string>>("vpc_endpoint_id_restriction_rule_map");
        set => SetArgument("vpc_endpoint_id_restriction_rule_map", value);
    }

    /// <summary>
    /// The vpc_id_restriction_rule_map attribute.
    /// </summary>
    public TerraformMap<string>? VpcIdRestrictionRuleMap
    {
        get => GetArgument<TerraformMap<string>>("vpc_id_restriction_rule_map");
        set => SetArgument("vpc_id_restriction_rule_map", value);
    }

}
