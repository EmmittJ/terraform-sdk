using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_firewall_domain_list.
/// </summary>
public class AwsRoute53ResolverFirewallDomainListDataSource : TerraformDataSource
{
    public AwsRoute53ResolverFirewallDomainListDataSource(string name) : base("aws_route53_resolver_firewall_domain_list", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputrn");
        this.WithOutputreation_time");
        this.WithOutputreator_request_id");
        this.WithOutputomain_count");
        this.WithOutputanaged_owner_name");
        this.WithOutputodification_time");
        this.WithOutputame");
        this.WithOutputtatus");
        this.WithOutputtatus_message");
    }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallDomainListId is required")]
    public required TerraformProperty<string> FirewallDomainListId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("firewall_domain_list_id");
        set => this.WithProperty("firewall_domain_list_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    public TerraformExpression CreatorRequestId => this["creator_request_id"];

    /// <summary>
    /// The domain_count attribute.
    /// </summary>
    public TerraformExpression DomainCount => this["domain_count"];

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    public TerraformExpression ManagedOwnerName => this["managed_owner_name"];

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    public TerraformExpression ModificationTime => this["modification_time"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformExpression StatusMessage => this["status_message"];

}
