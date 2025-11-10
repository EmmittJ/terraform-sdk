using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_resolver_firewall_rule resource.
/// </summary>
public class AwsRoute53ResolverFirewallRule : TerraformResource
{
    public AwsRoute53ResolverFirewallRule(string name) : base("aws_route53_resolver_firewall_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("action");
        SetOutput("block_override_dns_type");
        SetOutput("block_override_domain");
        SetOutput("block_override_ttl");
        SetOutput("block_response");
        SetOutput("firewall_domain_list_id");
        SetOutput("firewall_domain_redirection_action");
        SetOutput("firewall_rule_group_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("priority");
        SetOutput("q_type");
        SetOutput("region");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The block_override_dns_type attribute.
    /// </summary>
    public TerraformProperty<string> BlockOverrideDnsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("block_override_dns_type");
        set => SetProperty("block_override_dns_type", value);
    }

    /// <summary>
    /// The block_override_domain attribute.
    /// </summary>
    public TerraformProperty<string> BlockOverrideDomain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("block_override_domain");
        set => SetProperty("block_override_domain", value);
    }

    /// <summary>
    /// The block_override_ttl attribute.
    /// </summary>
    public TerraformProperty<double> BlockOverrideTtl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("block_override_ttl");
        set => SetProperty("block_override_ttl", value);
    }

    /// <summary>
    /// The block_response attribute.
    /// </summary>
    public TerraformProperty<string> BlockResponse
    {
        get => GetRequiredOutput<TerraformProperty<string>>("block_response");
        set => SetProperty("block_response", value);
    }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallDomainListId is required")]
    public required TerraformProperty<string> FirewallDomainListId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firewall_domain_list_id");
        set => SetProperty("firewall_domain_list_id", value);
    }

    /// <summary>
    /// The firewall_domain_redirection_action attribute.
    /// </summary>
    public TerraformProperty<string> FirewallDomainRedirectionAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firewall_domain_redirection_action");
        set => SetProperty("firewall_domain_redirection_action", value);
    }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupId is required")]
    public required TerraformProperty<string> FirewallRuleGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firewall_rule_group_id");
        set => SetProperty("firewall_rule_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The q_type attribute.
    /// </summary>
    public TerraformProperty<string> QType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("q_type");
        set => SetProperty("q_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
