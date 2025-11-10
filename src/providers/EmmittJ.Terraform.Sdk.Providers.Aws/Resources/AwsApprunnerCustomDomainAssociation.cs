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
        SetOutput("certificate_validation_records");
        SetOutput("dns_target");
        SetOutput("status");
        SetOutput("domain_name");
        SetOutput("enable_www_subdomain");
        SetOutput("id");
        SetOutput("region");
        SetOutput("service_arn");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The enable_www_subdomain attribute.
    /// </summary>
    public TerraformProperty<bool> EnableWwwSubdomain
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_www_subdomain");
        set => SetProperty("enable_www_subdomain", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceArn is required")]
    public required TerraformProperty<string> ServiceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_arn");
        set => SetProperty("service_arn", value);
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
