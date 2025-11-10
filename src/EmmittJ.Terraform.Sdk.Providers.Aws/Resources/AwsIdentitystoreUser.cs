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
        get => GetProperty<TerraformProperty<string>>("country");
        set => WithProperty("country", value);
    }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    public TerraformProperty<string>? Formatted
    {
        get => GetProperty<TerraformProperty<string>>("formatted");
        set => WithProperty("formatted", value);
    }

    /// <summary>
    /// The locality attribute.
    /// </summary>
    public TerraformProperty<string>? Locality
    {
        get => GetProperty<TerraformProperty<string>>("locality");
        set => WithProperty("locality", value);
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    public TerraformProperty<string>? PostalCode
    {
        get => GetProperty<TerraformProperty<string>>("postal_code");
        set => WithProperty("postal_code", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformProperty<bool>? Primary
    {
        get => GetProperty<TerraformProperty<bool>>("primary");
        set => WithProperty("primary", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

    /// <summary>
    /// The street_address attribute.
    /// </summary>
    public TerraformProperty<string>? StreetAddress
    {
        get => GetProperty<TerraformProperty<string>>("street_address");
        set => WithProperty("street_address", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<bool>>("primary");
        set => WithProperty("primary", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
        get => GetProperty<TerraformProperty<string>>("family_name");
        set => WithProperty("family_name", value);
    }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    public TerraformProperty<string>? Formatted
    {
        get => GetProperty<TerraformProperty<string>>("formatted");
        set => WithProperty("formatted", value);
    }

    /// <summary>
    /// The given_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GivenName is required")]
    public required TerraformProperty<string> GivenName
    {
        get => GetProperty<TerraformProperty<string>>("given_name");
        set => WithProperty("given_name", value);
    }

    /// <summary>
    /// The honorific_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? HonorificPrefix
    {
        get => GetProperty<TerraformProperty<string>>("honorific_prefix");
        set => WithProperty("honorific_prefix", value);
    }

    /// <summary>
    /// The honorific_suffix attribute.
    /// </summary>
    public TerraformProperty<string>? HonorificSuffix
    {
        get => GetProperty<TerraformProperty<string>>("honorific_suffix");
        set => WithProperty("honorific_suffix", value);
    }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    public TerraformProperty<string>? MiddleName
    {
        get => GetProperty<TerraformProperty<string>>("middle_name");
        set => WithProperty("middle_name", value);
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
        get => GetProperty<TerraformProperty<bool>>("primary");
        set => WithProperty("primary", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
        this.DeclareOutput("external_ids");
        this.DeclareOutput("user_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformProperty<string> IdentityStoreId
    {
        get => GetProperty<TerraformProperty<string>>("identity_store_id");
        set => this.WithProperty("identity_store_id", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformProperty<string>? Locale
    {
        get => GetProperty<TerraformProperty<string>>("locale");
        set => this.WithProperty("locale", value);
    }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    public TerraformProperty<string>? Nickname
    {
        get => GetProperty<TerraformProperty<string>>("nickname");
        set => this.WithProperty("nickname", value);
    }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredLanguage
    {
        get => GetProperty<TerraformProperty<string>>("preferred_language");
        set => this.WithProperty("preferred_language", value);
    }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    public TerraformProperty<string>? ProfileUrl
    {
        get => GetProperty<TerraformProperty<string>>("profile_url");
        set => this.WithProperty("profile_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        get => GetProperty<TerraformProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => this.WithProperty("title", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public TerraformProperty<string>? UserType
    {
        get => GetProperty<TerraformProperty<string>>("user_type");
        set => this.WithProperty("user_type", value);
    }

    /// <summary>
    /// Block for addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Addresses block(s) allowed")]
    public List<AwsIdentitystoreUserAddressesBlock>? Addresses
    {
        get => GetProperty<List<AwsIdentitystoreUserAddressesBlock>>("addresses");
        set => this.WithProperty("addresses", value);
    }

    /// <summary>
    /// Block for emails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Emails block(s) allowed")]
    public List<AwsIdentitystoreUserEmailsBlock>? Emails
    {
        get => GetProperty<List<AwsIdentitystoreUserEmailsBlock>>("emails");
        set => this.WithProperty("emails", value);
    }

    /// <summary>
    /// Block for name.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Name block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Name block(s) allowed")]
    public List<AwsIdentitystoreUserNameBlock>? Name
    {
        get => GetProperty<List<AwsIdentitystoreUserNameBlock>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for phone_numbers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneNumbers block(s) allowed")]
    public List<AwsIdentitystoreUserPhoneNumbersBlock>? PhoneNumbers
    {
        get => GetProperty<List<AwsIdentitystoreUserPhoneNumbersBlock>>("phone_numbers");
        set => this.WithProperty("phone_numbers", value);
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
