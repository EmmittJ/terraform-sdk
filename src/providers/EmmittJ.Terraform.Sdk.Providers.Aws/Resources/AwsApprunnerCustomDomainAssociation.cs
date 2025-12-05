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
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The enable_www_subdomain attribute.
    /// </summary>
    public TerraformValue<bool>? EnableWwwSubdomain
    {
        get => GetArgument<TerraformValue<bool>>("enable_www_subdomain");
        set => SetArgument("enable_www_subdomain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceArn is required")]
    public required TerraformValue<string> ServiceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_arn");
        set => SetArgument("service_arn", value);
    }

    /// <summary>
    /// The certificate_validation_records attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> CertificateValidationRecords
        => CreateReference("certificate_validation_records");

    /// <summary>
    /// The dns_target attribute.
    /// </summary>
    public TerraformValue<string> DnsTarget
        => CreateReference("dns_target");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

}
