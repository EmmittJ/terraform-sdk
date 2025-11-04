using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

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
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("certificate_arn")?.Value;
        set => WithPropertyInternal("certificate_arn", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The validation_record_fqdns attribute.
    /// </summary>
    public HashSet&lt;string&gt;? ValidationRecordFqdns
    {
        get => GetProperty<TerraformLiteralProperty&lt;HashSet&lt;string&gt;&gt;>("validation_record_fqdns")?.Value;
        set => WithPropertyInternal("validation_record_fqdns", value == null ? null : new TerraformLiteralProperty&lt;HashSet&lt;string&gt;&gt;(value));
    }

}
