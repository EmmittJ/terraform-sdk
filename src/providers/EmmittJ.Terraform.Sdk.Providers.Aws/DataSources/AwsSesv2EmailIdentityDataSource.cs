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
        get => GetArgument<TerraformValue<string>>("email_identity");
        set => SetArgument("email_identity", value);
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
    /// The configuration_set_name attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationSetName
        => AsReference("configuration_set_name");

    /// <summary>
    /// The dkim_signing_attributes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DkimSigningAttributes
        => AsReference("dkim_signing_attributes");

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public TerraformValue<string> IdentityType
        => AsReference("identity_type");

    /// <summary>
    /// The verification_status attribute.
    /// </summary>
    public TerraformValue<string> VerificationStatus
        => AsReference("verification_status");

    /// <summary>
    /// The verified_for_sending_status attribute.
    /// </summary>
    public TerraformValue<bool> VerifiedForSendingStatus
        => AsReference("verified_for_sending_status");

}
