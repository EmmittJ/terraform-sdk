using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_apprunner_custom_domain_association Terraform resource.
/// Manages a aws_apprunner_custom_domain_association resource.
/// </summary>
public partial class AwsApprunnerCustomDomainAssociation(string name) : TerraformResource("aws_apprunner_custom_domain_association", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The enable_www_subdomain attribute.
    /// </summary>
    public TerraformValue<bool>? EnableWwwSubdomain
    {
        get => new TerraformReference<bool>(this, "enable_www_subdomain");
        set => SetArgument("enable_www_subdomain", value);
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
    /// The service_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceArn is required")]
    public required TerraformValue<string> ServiceArn
    {
        get => new TerraformReference<string>(this, "service_arn");
        set => SetArgument("service_arn", value);
    }

    /// <summary>
    /// The certificate_validation_records attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> CertificateValidationRecords
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "certificate_validation_records").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns_target attribute.
    /// </summary>
    public TerraformValue<string> DnsTarget
    {
        get => new TerraformReference<string>(this, "dns_target");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
