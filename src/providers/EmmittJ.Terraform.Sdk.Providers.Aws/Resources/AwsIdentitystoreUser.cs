using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for addresses in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserAddressesBlock : TerraformBlock
{
    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformProperty<string>? Country
    {
        set => SetProperty("country", value);
    }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    public TerraformProperty<string>? Formatted
    {
        set => SetProperty("formatted", value);
    }

    /// <summary>
    /// The locality attribute.
    /// </summary>
    public TerraformProperty<string>? Locality
    {
        set => SetProperty("locality", value);
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    public TerraformProperty<string>? PostalCode
    {
        set => SetProperty("postal_code", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformProperty<bool>? Primary
    {
        set => SetProperty("primary", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The street_address attribute.
    /// </summary>
    public TerraformProperty<string>? StreetAddress
    {
        set => SetProperty("street_address", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for emails in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserEmailsBlock : TerraformBlock
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformProperty<bool>? Primary
    {
        set => SetProperty("primary", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for name in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserNameBlock : TerraformBlock
{
    /// <summary>
    /// The family_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FamilyName is required")]
    public required TerraformProperty<string> FamilyName
    {
        set => SetProperty("family_name", value);
    }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    public TerraformProperty<string>? Formatted
    {
        set => SetProperty("formatted", value);
    }

    /// <summary>
    /// The given_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GivenName is required")]
    public required TerraformProperty<string> GivenName
    {
        set => SetProperty("given_name", value);
    }

    /// <summary>
    /// The honorific_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? HonorificPrefix
    {
        set => SetProperty("honorific_prefix", value);
    }

    /// <summary>
    /// The honorific_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? HonorificSuffix
    {
        set => SetProperty("honorific_suffix", value);
    }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    public TerraformProperty<string>? MiddleName
    {
        set => SetProperty("middle_name", value);
    }

}

/// <summary>
/// Block type for phone_numbers in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserPhoneNumbersBlock : TerraformBlock
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformProperty<bool>? Primary
    {
        set => SetProperty("primary", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_identitystore_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIdentitystoreUser : TerraformResource
{
    public AwsIdentitystoreUser(string name) : base("aws_identitystore_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("external_ids");
        SetOutput("user_id");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("identity_store_id");
        SetOutput("locale");
        SetOutput("nickname");
        SetOutput("preferred_language");
        SetOutput("profile_url");
        SetOutput("region");
        SetOutput("timezone");
        SetOutput("title");
        SetOutput("user_name");
        SetOutput("user_type");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformProperty<string> IdentityStoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_store_id");
        set => SetProperty("identity_store_id", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformProperty<string> Locale
    {
        get => GetRequiredOutput<TerraformProperty<string>>("locale");
        set => SetProperty("locale", value);
    }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    public TerraformProperty<string> Nickname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("nickname");
        set => SetProperty("nickname", value);
    }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    public TerraformProperty<string> PreferredLanguage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_language");
        set => SetProperty("preferred_language", value);
    }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    public TerraformProperty<string> ProfileUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_url");
        set => SetProperty("profile_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string> Timezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timezone");
        set => SetProperty("timezone", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string> Title
    {
        get => GetRequiredOutput<TerraformProperty<string>>("title");
        set => SetProperty("title", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public TerraformProperty<string> UserType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_type");
        set => SetProperty("user_type", value);
    }

    /// <summary>
    /// Block for addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Addresses block(s) allowed")]
    public List<AwsIdentitystoreUserAddressesBlock>? Addresses
    {
        set => SetProperty("addresses", value);
    }

    /// <summary>
    /// Block for emails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Emails block(s) allowed")]
    public List<AwsIdentitystoreUserEmailsBlock>? Emails
    {
        set => SetProperty("emails", value);
    }

    /// <summary>
    /// Block for name.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Name block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Name block(s) allowed")]
    public List<AwsIdentitystoreUserNameBlock>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for phone_numbers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneNumbers block(s) allowed")]
    public List<AwsIdentitystoreUserPhoneNumbersBlock>? PhoneNumbers
    {
        set => SetProperty("phone_numbers", value);
    }

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    public TerraformExpression ExternalIds => this["external_ids"];

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformExpression UserId => this["user_id"];

}
