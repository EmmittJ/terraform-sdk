using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_ip_restriction resource.
/// </summary>
public class AwsQuicksightIpRestriction : TerraformResource
{
    public AwsQuicksightIpRestriction(string name) : base("aws_quicksight_ip_restriction", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The ip_restriction_rule_map attribute.
    /// </summary>
    public TerraformMapProperty<string>? IpRestrictionRuleMap
    {
        get => GetProperty<TerraformMapProperty<string>>("ip_restriction_rule_map");
        set => this.WithProperty("ip_restriction_rule_map", value);
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
    /// The vpc_endpoint_id_restriction_rule_map attribute.
    /// </summary>
    public TerraformMapProperty<string>? VpcEndpointIdRestrictionRuleMap
    {
        get => GetProperty<TerraformMapProperty<string>>("vpc_endpoint_id_restriction_rule_map");
        set => this.WithProperty("vpc_endpoint_id_restriction_rule_map", value);
    }

    /// <summary>
    /// The vpc_id_restriction_rule_map attribute.
    /// </summary>
    public TerraformMapProperty<string>? VpcIdRestrictionRuleMap
    {
        get => GetProperty<TerraformMapProperty<string>>("vpc_id_restriction_rule_map");
        set => this.WithProperty("vpc_id_restriction_rule_map", value);
    }

}
