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
        get => GetArgument<TerraformValue<string>>("country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    public TerraformValue<string>? Formatted
    {
        get => GetArgument<TerraformValue<string>>("formatted");
        set => SetArgument("formatted", value);
    }

    /// <summary>
    /// The locality attribute.
    /// </summary>
    public TerraformValue<string>? Locality
    {
        get => GetArgument<TerraformValue<string>>("locality");
        set => SetArgument("locality", value);
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    public TerraformValue<string>? PostalCode
    {
        get => GetArgument<TerraformValue<string>>("postal_code");
        set => SetArgument("postal_code", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformValue<bool>? Primary
    {
        get => GetArgument<TerraformValue<bool>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The street_address attribute.
    /// </summary>
    public TerraformValue<string>? StreetAddress
    {
        get => GetArgument<TerraformValue<string>>("street_address");
        set => SetArgument("street_address", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<bool>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
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
        get => GetRequiredArgument<TerraformValue<string>>("family_name");
        set => SetArgument("family_name", value);
    }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    public TerraformValue<string>? Formatted
    {
        get => GetArgument<TerraformValue<string>>("formatted");
        set => SetArgument("formatted", value);
    }

    /// <summary>
    /// The given_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GivenName is required")]
    public required TerraformValue<string> GivenName
    {
        get => GetRequiredArgument<TerraformValue<string>>("given_name");
        set => SetArgument("given_name", value);
    }

    /// <summary>
    /// The honorific_prefix attribute.
    /// </summary>
    public TerraformValue<string>? HonorificPrefix
    {
        get => GetArgument<TerraformValue<string>>("honorific_prefix");
        set => SetArgument("honorific_prefix", value);
    }

    /// <summary>
    /// The honorific_suffix attribute.
    /// </summary>
    public TerraformValue<string>? HonorificSuffix
    {
        get => GetArgument<TerraformValue<string>>("honorific_suffix");
        set => SetArgument("honorific_suffix", value);
    }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    public TerraformValue<string>? MiddleName
    {
        get => GetArgument<TerraformValue<string>>("middle_name");
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
        get => GetArgument<TerraformValue<bool>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
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
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformValue<string> IdentityStoreId
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_store_id");
        set => SetArgument("identity_store_id", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformValue<string>? Locale
    {
        get => GetArgument<TerraformValue<string>>("locale");
        set => SetArgument("locale", value);
    }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    public TerraformValue<string>? Nickname
    {
        get => GetArgument<TerraformValue<string>>("nickname");
        set => SetArgument("nickname", value);
    }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    public TerraformValue<string>? PreferredLanguage
    {
        get => GetArgument<TerraformValue<string>>("preferred_language");
        set => SetArgument("preferred_language", value);
    }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    public TerraformValue<string>? ProfileUrl
    {
        get => GetArgument<TerraformValue<string>>("profile_url");
        set => SetArgument("profile_url", value);
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
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => GetArgument<TerraformValue<string>>("timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public TerraformValue<string>? UserType
    {
        get => GetArgument<TerraformValue<string>>("user_type");
        set => SetArgument("user_type", value);
    }

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExternalIds
        => CreateReference("external_ids");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformValue<string> UserId
        => CreateReference("user_id");

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
