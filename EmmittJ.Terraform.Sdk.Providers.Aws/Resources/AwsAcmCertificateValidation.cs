using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn")?.Value;
        set => this.WithProperty("certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The validation_record_fqdns attribute.
    /// </summary>
    public HashSet<string>? ValidationRecordFqdns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("validation_record_fqdns")?.Value;
        set => this.WithProperty("validation_record_fqdns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
