using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_resolver_firewall_domain_list Terraform data source.
/// Retrieves information about a aws_route53_resolver_firewall_domain_list.
/// </summary>
public partial class AwsRoute53ResolverFirewallDomainListDataSource(string name) : TerraformDataSource("aws_route53_resolver_firewall_domain_list", name)
{
    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallDomainListId is required")]
    public required TerraformValue<string> FirewallDomainListId
    {
        get => new TerraformReference<string>(this, "firewall_domain_list_id");
        set => SetArgument("firewall_domain_list_id", value);
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
    /// The domain_count attribute.
    /// </summary>
    public TerraformValue<double> DomainCount
    {
        get => new TerraformReference<double>(this, "domain_count");
    }

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedOwnerName
    {
        get => new TerraformReference<string>(this, "managed_owner_name");
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
