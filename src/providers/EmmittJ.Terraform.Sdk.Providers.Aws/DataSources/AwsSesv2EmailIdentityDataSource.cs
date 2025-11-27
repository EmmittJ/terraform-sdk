using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sesv2_email_identity Terraform data source.
/// Retrieves information about a aws_sesv2_email_identity.
/// </summary>
public partial class AwsSesv2EmailIdentityDataSource(string name) : TerraformDataSource("aws_sesv2_email_identity", name)
{
    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    public required TerraformValue<string> EmailIdentity
    {
        get => new TerraformReference<string>(this, "email_identity");
        set => SetArgument("email_identity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The configuration_set_name attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationSetName
    {
        get => new TerraformReference<string>(this, "configuration_set_name");
    }

    /// <summary>
    /// The dkim_signing_attributes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DkimSigningAttributes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dkim_signing_attributes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public TerraformValue<string> IdentityType
    {
        get => new TerraformReference<string>(this, "identity_type");
    }

    /// <summary>
    /// The verification_status attribute.
    /// </summary>
    public TerraformValue<string> VerificationStatus
    {
        get => new TerraformReference<string>(this, "verification_status");
    }

    /// <summary>
    /// The verified_for_sending_status attribute.
    /// </summary>
    public TerraformValue<bool> VerifiedForSendingStatus
    {
        get => new TerraformReference<bool>(this, "verified_for_sending_status");
    }

}
