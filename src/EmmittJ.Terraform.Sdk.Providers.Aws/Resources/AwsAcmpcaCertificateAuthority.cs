using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_acmpca_certificate_authority resource.
/// </summary>
public class AwsAcmpcaCertificateAuthority : TerraformResource
{
    public AwsAcmpcaCertificateAuthority(string name) : base("aws_acmpca_certificate_authority", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate");
        this.DeclareOutput("certificate_chain");
        this.DeclareOutput("certificate_signing_request");
        this.DeclareOutput("not_after");
        this.DeclareOutput("not_before");
        this.DeclareOutput("serial");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The key_storage_security_standard attribute.
    /// </summary>
    public TerraformProperty<string>? KeyStorageSecurityStandard
    {
        get => GetProperty<TerraformProperty<string>>("key_storage_security_standard");
        set => this.WithProperty("key_storage_security_standard", value);
    }

    /// <summary>
    /// The permanent_deletion_time_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? PermanentDeletionTimeInDays
    {
        get => GetProperty<TerraformProperty<double>>("permanent_deletion_time_in_days");
        set => this.WithProperty("permanent_deletion_time_in_days", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    public TerraformProperty<string>? UsageMode
    {
        get => GetProperty<TerraformProperty<string>>("usage_mode");
        set => this.WithProperty("usage_mode", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformExpression CertificateChain => this["certificate_chain"];

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    public TerraformExpression CertificateSigningRequest => this["certificate_signing_request"];

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    public TerraformExpression NotAfter => this["not_after"];

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformExpression NotBefore => this["not_before"];

    /// <summary>
    /// The serial attribute.
    /// </summary>
    public TerraformExpression Serial => this["serial"];

}
