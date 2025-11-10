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
        set => SetProperty("create", value);
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
        SetOutput("certificate_arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("validation_record_fqdns");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    public required TerraformProperty<string> CertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_arn");
        set => SetProperty("certificate_arn", value);
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
    /// The validation_record_fqdns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ValidationRecordFqdns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("validation_record_fqdns");
        set => SetProperty("validation_record_fqdns", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAcmCertificateValidationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
