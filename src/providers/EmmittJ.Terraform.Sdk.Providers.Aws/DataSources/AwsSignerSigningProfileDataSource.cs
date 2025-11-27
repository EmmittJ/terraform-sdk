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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
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
    /// The platform_id attribute.
    /// </summary>
    public TerraformValue<string> PlatformId
    {
        get => new TerraformReference<string>(this, "platform_id");
    }

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RevocationRecord
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "revocation_record").ResolveNodes(ctx));
    }

    /// <summary>
    /// The signature_validity_period attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SignatureValidityPeriod
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "signature_validity_period").ResolveNodes(ctx));
    }

    /// <summary>
    /// The signing_material attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SigningMaterial
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "signing_material").ResolveNodes(ctx));
    }

    /// <summary>
    /// The signing_parameters attribute.
    /// </summary>
    public TerraformMap<string> SigningParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "signing_parameters").ResolveNodes(ctx));
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

}
