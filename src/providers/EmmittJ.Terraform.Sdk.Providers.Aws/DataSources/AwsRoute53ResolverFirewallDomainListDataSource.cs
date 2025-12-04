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
        get => GetRequiredArgument<TerraformValue<string>>("firewall_domain_list_id");
        set => SetArgument("firewall_domain_list_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The creator_request_id attribute.
    /// </summary>
    public TerraformValue<string> CreatorRequestId
        => AsReference("creator_request_id");

    /// <summary>
    /// The domain_count attribute.
    /// </summary>
    public TerraformValue<double> DomainCount
        => AsReference("domain_count");

    /// <summary>
    /// The managed_owner_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedOwnerName
        => AsReference("managed_owner_name");

    /// <summary>
    /// The modification_time attribute.
    /// </summary>
    public TerraformValue<string> ModificationTime
        => AsReference("modification_time");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformValue<string> StatusMessage
        => AsReference("status_message");

}
