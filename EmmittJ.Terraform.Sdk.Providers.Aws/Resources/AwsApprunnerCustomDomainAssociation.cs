using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apprunner_custom_domain_association resource.
/// </summary>
public class AwsApprunnerCustomDomainAssociation : TerraformResource
{
    public AwsApprunnerCustomDomainAssociation(string name) : base("aws_apprunner_custom_domain_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_validation_records");
        this.DeclareOutput("dns_target");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_www_subdomain attribute.
    /// </summary>
    public bool? EnableWwwSubdomain
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_www_subdomain")?.Value;
        set => this.WithProperty("enable_www_subdomain", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The service_arn attribute.
    /// </summary>
    public string? ServiceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_arn")?.Value;
        set => this.WithProperty("service_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_validation_records attribute.
    /// </summary>
    public TerraformExpression CertificateValidationRecords => this["certificate_validation_records"];

    /// <summary>
    /// The dns_target attribute.
    /// </summary>
    public TerraformExpression DnsTarget => this["dns_target"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
