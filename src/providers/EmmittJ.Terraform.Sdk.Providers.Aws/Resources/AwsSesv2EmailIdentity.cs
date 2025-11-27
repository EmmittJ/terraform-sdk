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
    {
        get => new TerraformReference<string>(this, "current_signing_key_length");
    }

    /// <summary>
    /// The domain_signing_private_key attribute.
    /// </summary>
    public TerraformValue<string>? DomainSigningPrivateKey
    {
        get => new TerraformReference<string>(this, "domain_signing_private_key");
        set => SetArgument("domain_signing_private_key", value);
    }

    /// <summary>
    /// The domain_signing_selector attribute.
    /// </summary>
    public TerraformValue<string>? DomainSigningSelector
    {
        get => new TerraformReference<string>(this, "domain_signing_selector");
        set => SetArgument("domain_signing_selector", value);
    }

    /// <summary>
    /// The last_key_generation_timestamp attribute.
    /// </summary>
    public TerraformValue<string> LastKeyGenerationTimestamp
    {
        get => new TerraformReference<string>(this, "last_key_generation_timestamp");
    }

    /// <summary>
    /// The next_signing_key_length attribute.
    /// </summary>
    public TerraformValue<string> NextSigningKeyLength
    {
        get => new TerraformReference<string>(this, "next_signing_key_length");
        set => SetArgument("next_signing_key_length", value);
    }

    /// <summary>
    /// The signing_attributes_origin attribute.
    /// </summary>
    public TerraformValue<string> SigningAttributesOrigin
    {
        get => new TerraformReference<string>(this, "signing_attributes_origin");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The tokens attribute.
    /// </summary>
    public TerraformList<string> Tokens
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tokens").ResolveNodes(ctx));
    }

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
        get => new TerraformReference<string>(this, "configuration_set_name");
        set => SetArgument("configuration_set_name", value);
    }

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
