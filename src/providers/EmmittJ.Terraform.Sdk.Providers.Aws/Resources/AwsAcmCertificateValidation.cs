using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsAcmCertificateValidation.
/// Nesting mode: single
/// </summary>
public class AwsAcmCertificateValidationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_acm_certificate_validation Terraform resource.
/// Manages a aws_acm_certificate_validation resource.
/// </summary>
public partial class AwsAcmCertificateValidation(string name) : TerraformResource("aws_acm_certificate_validation", name)
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    public required TerraformValue<string> CertificateArn
    {
        get => GetArgument<TerraformValue<string>>("certificate_arn");
        set => SetArgument("certificate_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The validation_record_fqdns attribute.
    /// </summary>
    public TerraformSet<string>? ValidationRecordFqdns
    {
        get => GetArgument<TerraformSet<string>>("validation_record_fqdns");
        set => SetArgument("validation_record_fqdns", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAcmCertificateValidationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAcmCertificateValidationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
