using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_signer_signing_profile Terraform data source.
/// Retrieves information about a aws_signer_signing_profile.
/// </summary>
public partial class AwsSignerSigningProfileDataSource(string name) : TerraformDataSource("aws_signer_signing_profile", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
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
    /// The platform_id attribute.
    /// </summary>
    public TerraformValue<string> PlatformId
        => AsReference("platform_id");

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RevocationRecord
        => AsReference("revocation_record");

    /// <summary>
    /// The signature_validity_period attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SignatureValidityPeriod
        => AsReference("signature_validity_period");

    /// <summary>
    /// The signing_material attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SigningMaterial
        => AsReference("signing_material");

    /// <summary>
    /// The signing_parameters attribute.
    /// </summary>
    public TerraformMap<string> SigningParameters
        => AsReference("signing_parameters");

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

}
