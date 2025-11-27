using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for addresses in AwsIdentitystoreUser.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserAddressesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "addresses";

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => new TerraformReference<string>(this, "country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    public TerraformValue<string>? Formatted
    {
        get => new TerraformReference<string>(this, "formatted");
        set => SetArgument("formatted", value);
    }

    /// <summary>
    /// The locality attribute.
    /// </summary>
    public TerraformValue<string>? Locality
    {
        get => new TerraformReference<string>(this, "locality");
        set => SetArgument("locality", value);
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    public TerraformValue<string>? PostalCode
    {
        get => new TerraformReference<string>(this, "postal_code");
        set => SetArgument("postal_code", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The street_address attribute.
    /// </summary>
    public TerraformValue<string>? StreetAddress
    {
        get => new TerraformReference<string>(this, "street_address");
        set => SetArgument("street_address", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for emails in AwsIdentitystoreUser.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserEmailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "emails";

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for name in AwsIdentitystoreUser.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "name";

    /// <summary>
    /// The family_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FamilyName is required")]
    public required TerraformValue<string> FamilyName
    {
        get => new TerraformReference<string>(this, "family_name");
        set => SetArgument("family_name", value);
    }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    public TerraformValue<string>? Formatted
    {
        get => new TerraformReference<string>(this, "formatted");
        set => SetArgument("formatted", value);
    }

    /// <summary>
    /// The given_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GivenName is required")]
    public required TerraformValue<string> GivenName
    {
        get => new TerraformReference<string>(this, "given_name");
        set => SetArgument("given_name", value);
    }

    /// <summary>
    /// The honorific_prefix attribute.
    /// </summary>
    public TerraformValue<string>? HonorificPrefix
    {
        get => new TerraformReference<string>(this, "honorific_prefix");
        set => SetArgument("honorific_prefix", value);
    }

    /// <summary>
    /// The honorific_suffix attribute.
    /// </summary>
    public TerraformValue<string>? HonorificSuffix
    {
        get => new TerraformReference<string>(this, "honorific_suffix");
        set => SetArgument("honorific_suffix", value);
    }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    public TerraformValue<string>? MiddleName
    {
        get => new TerraformReference<string>(this, "middle_name");
        set => SetArgument("middle_name", value);
    }

}


/// <summary>
/// Block type for phone_numbers in AwsIdentitystoreUser.
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserPhoneNumbersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "phone_numbers";

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_identitystore_user Terraform resource.
/// Manages a aws_identitystore_user resource.
/// </summary>
public partial class AwsIdentitystoreUser(string name) : TerraformResource("aws_identitystore_user", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformValue<string> IdentityStoreId
    {
        get => new TerraformReference<string>(this, "identity_store_id");
        set => SetArgument("identity_store_id", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformValue<string>? Locale
    {
        get => new TerraformReference<string>(this, "locale");
        set => SetArgument("locale", value);
    }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    public TerraformValue<string>? Nickname
    {
        get => new TerraformReference<string>(this, "nickname");
        set => SetArgument("nickname", value);
    }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    public TerraformValue<string>? PreferredLanguage
    {
        get => new TerraformReference<string>(this, "preferred_language");
        set => SetArgument("preferred_language", value);
    }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    public TerraformValue<string>? ProfileUrl
    {
        get => new TerraformReference<string>(this, "profile_url");
        set => SetArgument("profile_url", value);
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
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public TerraformValue<string>? UserType
    {
        get => new TerraformReference<string>(this, "user_type");
        set => SetArgument("user_type", value);
    }

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExternalIds
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "external_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string> UserId
    {
        get => new TerraformReference<string>(this, "user_id");
    }

    /// <summary>
    /// Addresses block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Addresses block(s) allowed")]
    public TerraformList<AwsIdentitystoreUserAddressesBlock>? Addresses
    {
        get => GetArgument<TerraformList<AwsIdentitystoreUserAddressesBlock>>("addresses");
        set => SetArgument("addresses", value);
    }

    /// <summary>
    /// Emails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Emails block(s) allowed")]
    public TerraformList<AwsIdentitystoreUserEmailsBlock>? Emails
    {
        get => GetArgument<TerraformList<AwsIdentitystoreUserEmailsBlock>>("emails");
        set => SetArgument("emails", value);
    }

    /// <summary>
    /// Name block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Name block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Name block(s) allowed")]
    public required TerraformList<AwsIdentitystoreUserNameBlock> Name
    {
        get => GetRequiredArgument<TerraformList<AwsIdentitystoreUserNameBlock>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// PhoneNumbers block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneNumbers block(s) allowed")]
    public TerraformList<AwsIdentitystoreUserPhoneNumbersBlock>? PhoneNumbers
    {
        get => GetArgument<TerraformList<AwsIdentitystoreUserPhoneNumbersBlock>>("phone_numbers");
        set => SetArgument("phone_numbers", value);
    }

}
