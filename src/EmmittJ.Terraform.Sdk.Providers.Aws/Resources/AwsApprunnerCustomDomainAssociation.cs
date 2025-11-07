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
    public TerraformLiteralProperty<string>? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The enable_www_subdomain attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableWwwSubdomain
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_www_subdomain");
        set => this.WithProperty("enable_www_subdomain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_arn");
        set => this.WithProperty("service_arn", value);
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
