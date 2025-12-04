using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dkim_signing_attributes in AwsSesv2EmailIdentity.
/// Nesting mode: list
/// </summary>
public class AwsSesv2EmailIdentityDkimSigningAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dkim_signing_attributes";

    /// <summary>
    /// The current_signing_key_length attribute.
    /// </summary>
    public TerraformValue<string> CurrentSigningKeyLength
        => AsReference("current_signing_key_length");

    /// <summary>
    /// The domain_signing_private_key attribute.
    /// </summary>
    public TerraformValue<string>? DomainSigningPrivateKey
    {
        get => GetArgument<TerraformValue<string>>("domain_signing_private_key");
        set => SetArgument("domain_signing_private_key", value);
    }

    /// <summary>
    /// The domain_signing_selector attribute.
    /// </summary>
    public TerraformValue<string>? DomainSigningSelector
    {
        get => GetArgument<TerraformValue<string>>("domain_signing_selector");
        set => SetArgument("domain_signing_selector", value);
    }

    /// <summary>
    /// The last_key_generation_timestamp attribute.
    /// </summary>
    public TerraformValue<string> LastKeyGenerationTimestamp
        => AsReference("last_key_generation_timestamp");

    /// <summary>
    /// The next_signing_key_length attribute.
    /// </summary>
    public TerraformValue<string>? NextSigningKeyLength
    {
        get => GetArgument<TerraformValue<string>>("next_signing_key_length");
        set => SetArgument("next_signing_key_length", value);
    }

    /// <summary>
    /// The signing_attributes_origin attribute.
    /// </summary>
    public TerraformValue<string> SigningAttributesOrigin
        => AsReference("signing_attributes_origin");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The tokens attribute.
    /// </summary>
    public TerraformList<string> Tokens
        => AsReference("tokens");

}


/// <summary>
/// Represents a aws_sesv2_email_identity Terraform resource.
/// Manages a aws_sesv2_email_identity resource.
/// </summary>
public partial class AwsSesv2EmailIdentity(string name) : TerraformResource("aws_sesv2_email_identity", name)
{
    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationSetName
    {
        get => GetArgument<TerraformValue<string>>("configuration_set_name");
        set => SetArgument("configuration_set_name", value);
    }

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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

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

    /// <summary>
    /// DkimSigningAttributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DkimSigningAttributes block(s) allowed")]
    public TerraformList<AwsSesv2EmailIdentityDkimSigningAttributesBlock>? DkimSigningAttributes
    {
        get => GetArgument<TerraformList<AwsSesv2EmailIdentityDkimSigningAttributesBlock>>("dkim_signing_attributes");
        set => SetArgument("dkim_signing_attributes", value);
    }

}
