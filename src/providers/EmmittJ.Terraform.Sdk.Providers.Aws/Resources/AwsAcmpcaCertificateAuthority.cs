using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_authority_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    public required TerraformProperty<string> KeyAlgorithm
    {
        set => SetProperty("key_algorithm", value);
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformProperty<string> SigningAlgorithm
    {
        set => SetProperty("signing_algorithm", value);
    }

}

/// <summary>
/// Block type for revocation_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAcmpcaCertificateAuthorityTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_acmpca_certificate_authority resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAcmpcaCertificateAuthority : TerraformResource
{
    public AwsAcmpcaCertificateAuthority(string name) : base("aws_acmpca_certificate_authority", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("certificate");
        SetOutput("certificate_chain");
        SetOutput("certificate_signing_request");
        SetOutput("not_after");
        SetOutput("not_before");
        SetOutput("serial");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("key_storage_security_standard");
        SetOutput("permanent_deletion_time_in_days");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
        SetOutput("usage_mode");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The key_storage_security_standard attribute.
    /// </summary>
    public TerraformProperty<string> KeyStorageSecurityStandard
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_storage_security_standard");
        set => SetProperty("key_storage_security_standard", value);
    }

    /// <summary>
    /// The permanent_deletion_time_in_days attribute.
    /// </summary>
    public TerraformProperty<double> PermanentDeletionTimeInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("permanent_deletion_time_in_days");
        set => SetProperty("permanent_deletion_time_in_days", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    public TerraformProperty<string> UsageMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("usage_mode");
        set => SetProperty("usage_mode", value);
    }

    /// <summary>
    /// Block for certificate_authority_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CertificateAuthorityConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityConfiguration block(s) allowed")]
    public List<AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock>? CertificateAuthorityConfiguration
    {
        set => SetProperty("certificate_authority_configuration", value);
    }

    /// <summary>
    /// Block for revocation_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RevocationConfiguration block(s) allowed")]
    public List<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock>? RevocationConfiguration
    {
        set => SetProperty("revocation_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAcmpcaCertificateAuthorityTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
