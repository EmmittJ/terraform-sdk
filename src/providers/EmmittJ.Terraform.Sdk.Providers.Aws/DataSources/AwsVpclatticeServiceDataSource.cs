using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpclattice_service Terraform data source.
/// Retrieves information about a aws_vpclattice_service.
/// </summary>
public partial class AwsVpclatticeServiceDataSource(string name) : TerraformDataSource("aws_vpclattice_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The service_identifier attribute.
    /// </summary>
    public TerraformValue<string> ServiceIdentifier
    {
        get => new TerraformReference<string>(this, "service_identifier");
        set => SetArgument("service_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public TerraformValue<string> AuthType
    {
        get => new TerraformReference<string>(this, "auth_type");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
    }

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainName
    {
        get => new TerraformReference<string>(this, "custom_domain_name");
    }

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsEntry
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dns_entry").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
