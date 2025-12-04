using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for signature_validity_period in AwsSignerSigningProfile.
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningProfileSignatureValidityPeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "signature_validity_period";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for signing_material in AwsSignerSigningProfile.
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningProfileSigningMaterialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "signing_material";

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    public required TerraformValue<string> CertificateArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_arn");
        set => SetArgument("certificate_arn", value);
    }

}


/// <summary>
/// Represents a aws_signer_signing_profile Terraform resource.
/// Manages a aws_signer_signing_profile resource.
/// </summary>
public partial class AwsSignerSigningProfile(string name) : TerraformResource("aws_signer_signing_profile", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? AsReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformId is required")]
    public required TerraformValue<string> PlatformId
    {
        get => GetRequiredArgument<TerraformValue<string>>("platform_id");
        set => SetArgument("platform_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The signing_parameters attribute.
    /// </summary>
    public TerraformMap<string>? SigningParameters
    {
        get => GetArgument<TerraformMap<string>>("signing_parameters");
        set => SetArgument("signing_parameters", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    public TerraformValue<string> PlatformDisplayName
        => AsReference("platform_display_name");

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RevocationRecord
        => AsReference("revocation_record");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The version_arn attribute.
    /// </summary>
    public TerraformValue<string> VersionArn
        => AsReference("version_arn");

    /// <summary>
    /// SignatureValidityPeriod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignatureValidityPeriod block(s) allowed")]
    public TerraformList<AwsSignerSigningProfileSignatureValidityPeriodBlock>? SignatureValidityPeriod
    {
        get => GetArgument<TerraformList<AwsSignerSigningProfileSignatureValidityPeriodBlock>>("signature_validity_period");
        set => SetArgument("signature_validity_period", value);
    }

    /// <summary>
    /// SigningMaterial block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SigningMaterial block(s) allowed")]
    public TerraformList<AwsSignerSigningProfileSigningMaterialBlock>? SigningMaterial
    {
        get => GetArgument<TerraformList<AwsSignerSigningProfileSigningMaterialBlock>>("signing_material");
        set => SetArgument("signing_material", value);
    }

}
