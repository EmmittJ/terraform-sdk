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
        => CreateReference("current_signing_key_length");

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
        => CreateReference("last_key_generation_timestamp");

    /// <summary>
    /// The next_signing_key_length attribute.
    /// </summary>
    public TerraformValue<string> NextSigningKeyLength
    {
        get => GetArgument<TerraformValue<string>>("next_signing_key_length") ?? CreateReference("next_signing_key_length");
        set => SetArgument("next_signing_key_length", value);
    }

    /// <summary>
    /// The signing_attributes_origin attribute.
    /// </summary>
    public TerraformValue<string> SigningAttributesOrigin
        => CreateReference("signing_attributes_origin");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The tokens attribute.
    /// </summary>
    public TerraformList<string> Tokens
        => CreateReference("tokens");

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
        get => GetRequiredArgument<TerraformValue<string>>("email_identity");
        set => SetArgument("email_identity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public TerraformValue<string> IdentityType
        => CreateReference("identity_type");

    /// <summary>
    /// The verification_status attribute.
    /// </summary>
    public TerraformValue<string> VerificationStatus
        => CreateReference("verification_status");

    /// <summary>
    /// The verified_for_sending_status attribute.
    /// </summary>
    public TerraformValue<bool> VerifiedForSendingStatus
        => CreateReference("verified_for_sending_status");

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
