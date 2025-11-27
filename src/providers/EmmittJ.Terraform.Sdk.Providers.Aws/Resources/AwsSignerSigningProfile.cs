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
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
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
        get => new TerraformReference<string>(this, "certificate_arn");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformId is required")]
    public required TerraformValue<string> PlatformId
    {
        get => new TerraformReference<string>(this, "platform_id");
        set => SetArgument("platform_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The signing_parameters attribute.
    /// </summary>
    public TerraformMap<string>? SigningParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "signing_parameters").ResolveNodes(ctx));
        set => SetArgument("signing_parameters", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    public TerraformValue<string> PlatformDisplayName
    {
        get => new TerraformReference<string>(this, "platform_display_name");
    }

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RevocationRecord
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "revocation_record").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The version_arn attribute.
    /// </summary>
    public TerraformValue<string> VersionArn
    {
        get => new TerraformReference<string>(this, "version_arn");
    }

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
