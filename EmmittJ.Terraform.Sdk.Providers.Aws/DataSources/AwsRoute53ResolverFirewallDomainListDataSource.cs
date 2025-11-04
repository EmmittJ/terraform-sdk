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
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("creator_request_id");
        this.DeclareOutput("domain_count");
        this.DeclareOutput("managed_owner_name");
        this.DeclareOutput("modification_time");
        this.DeclareOutput("name");
        this.DeclareOutput("status");
        this.DeclareOutput("status_message");
    }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    public string? FirewallDomainListId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_domain_list_id")?.Value;
        set => this.WithProperty("firewall_domain_list_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
