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
        SetOutput("aws_account_id");
        SetOutput("enabled");
        SetOutput("ip_restriction_rule_map");
        SetOutput("region");
        SetOutput("vpc_endpoint_id_restriction_rule_map");
        SetOutput("vpc_id_restriction_rule_map");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The ip_restriction_rule_map attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> IpRestrictionRuleMap
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("ip_restriction_rule_map");
        set => SetProperty("ip_restriction_rule_map", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The vpc_endpoint_id_restriction_rule_map attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> VpcEndpointIdRestrictionRuleMap
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("vpc_endpoint_id_restriction_rule_map");
        set => SetProperty("vpc_endpoint_id_restriction_rule_map", value);
    }

    /// <summary>
    /// The vpc_id_restriction_rule_map attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> VpcIdRestrictionRuleMap
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("vpc_id_restriction_rule_map");
        set => SetProperty("vpc_id_restriction_rule_map", value);
    }

}
