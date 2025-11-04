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
    public string? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id")?.Value;
        set => this.WithProperty("aws_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ip_restriction_rule_map attribute.
    /// </summary>
    public Dictionary<string, string>? IpRestrictionRuleMap
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("ip_restriction_rule_map")?.Value;
        set => this.WithProperty("ip_restriction_rule_map", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_endpoint_id_restriction_rule_map attribute.
    /// </summary>
    public Dictionary<string, string>? VpcEndpointIdRestrictionRuleMap
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("vpc_endpoint_id_restriction_rule_map")?.Value;
        set => this.WithProperty("vpc_endpoint_id_restriction_rule_map", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_id_restriction_rule_map attribute.
    /// </summary>
    public Dictionary<string, string>? VpcIdRestrictionRuleMap
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("vpc_id_restriction_rule_map")?.Value;
        set => this.WithProperty("vpc_id_restriction_rule_map", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
