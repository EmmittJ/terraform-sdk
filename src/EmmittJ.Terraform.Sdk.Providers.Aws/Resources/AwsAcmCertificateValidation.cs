using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAcmCertificateValidationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_acm_certificate_validation resource.
/// </summary>
public class AwsAcmCertificateValidation : TerraformResource
{
    public AwsAcmCertificateValidation(string name) : base("aws_acm_certificate_validation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    public required TerraformProperty<string> CertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_arn");
        set => this.WithProperty("certificate_arn", value);
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
    /// The validation_record_fqdns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ValidationRecordFqdns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("validation_record_fqdns");
        set => this.WithProperty("validation_record_fqdns", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAcmCertificateValidationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAcmCertificateValidationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
