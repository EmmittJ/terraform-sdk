using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_resolver_firewall_rule_group Terraform data source.
/// Retrieves information about a aws_route53_resolver_firewall_rule_group.
/// </summary>
public partial class AwsRoute53ResolverFirewallRuleGroupDataSource(string name) : TerraformDataSource("aws_route53_resolver_firewall_rule_group", name)
{
    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupId is required")]
    public required TerraformValue<string> FirewallRuleGroupId
    {
        get => new TerraformReference<string>(this, "firewall_rule_group_id");
        set => SetArgument("firewall_rule_group_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    public TerraformValue<string> CreatorRequestId
    {
        get => new TerraformReference<string>(this, "creator_request_id");
    }

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    public TerraformValue<string> ModificationTime
    {
        get => new TerraformReference<string>(this, "modification_time");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The rule_count attribute.
    /// </summary>
    public TerraformValue<double> RuleCount
    {
        get => new TerraformReference<double>(this, "rule_count");
    }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public TerraformValue<string> ShareStatus
    {
        get => new TerraformReference<string>(this, "share_status");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
    {
        get => new TerraformReference<string>(this, "status_message");
    }

}
