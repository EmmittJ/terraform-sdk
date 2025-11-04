using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_amplify_domain_association resource.
/// </summary>
public class AwsAmplifyDomainAssociation : TerraformResource
{
    public AwsAmplifyDomainAssociation(string name) : base("aws_amplify_domain_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate_verification_dns_record");
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The enable_auto_sub_domain attribute.
    /// </summary>
    public bool? EnableAutoSubDomain
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_auto_sub_domain")?.Value;
        set => this.WithProperty("enable_auto_sub_domain", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The wait_for_verification attribute.
    /// </summary>
    public bool? WaitForVerification
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_for_verification")?.Value;
        set => this.WithProperty("wait_for_verification", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate_verification_dns_record attribute.
    /// </summary>
    public TerraformExpression CertificateVerificationDnsRecord => this["certificate_verification_dns_record"];

}
