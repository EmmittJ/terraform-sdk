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
    public TerraformProperty<string>? AppId
    {
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The enable_auto_sub_domain attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAutoSubDomain
    {
        get => GetProperty<TerraformProperty<bool>>("enable_auto_sub_domain");
        set => this.WithProperty("enable_auto_sub_domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForVerification
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_verification");
        set => this.WithProperty("wait_for_verification", value);
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
