using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for address in .
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesProfileAddressBlock : ITerraformBlock
{
    /// <summary>
    /// The address_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_1")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address1 { get; set; }

    /// <summary>
    /// The address_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address2 { get; set; }

    /// <summary>
    /// The address_3 attribute.
    /// </summary>
    [TerraformPropertyName("address_3")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address3 { get; set; }

    /// <summary>
    /// The address_4 attribute.
    /// </summary>
    [TerraformPropertyName("address_4")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address4 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? City { get; set; }

    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformPropertyName("country")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Country { get; set; }

    /// <summary>
    /// The county attribute.
    /// </summary>
    [TerraformPropertyName("county")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? County { get; set; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostalCode { get; set; }

    /// <summary>
    /// The province attribute.
    /// </summary>
    [TerraformPropertyName("province")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Province { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

}

/// <summary>
/// Block type for billing_address in .
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesProfileBillingAddressBlock : ITerraformBlock
{
    /// <summary>
    /// The address_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_1")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address1 { get; set; }

    /// <summary>
    /// The address_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address2 { get; set; }

    /// <summary>
    /// The address_3 attribute.
    /// </summary>
    [TerraformPropertyName("address_3")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address3 { get; set; }

    /// <summary>
    /// The address_4 attribute.
    /// </summary>
    [TerraformPropertyName("address_4")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address4 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? City { get; set; }

    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformPropertyName("country")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Country { get; set; }

    /// <summary>
    /// The county attribute.
    /// </summary>
    [TerraformPropertyName("county")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? County { get; set; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostalCode { get; set; }

    /// <summary>
    /// The province attribute.
    /// </summary>
    [TerraformPropertyName("province")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Province { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

}

/// <summary>
/// Block type for mailing_address in .
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesProfileMailingAddressBlock : ITerraformBlock
{
    /// <summary>
    /// The address_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_1")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address1 { get; set; }

    /// <summary>
    /// The address_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address2 { get; set; }

    /// <summary>
    /// The address_3 attribute.
    /// </summary>
    [TerraformPropertyName("address_3")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address3 { get; set; }

    /// <summary>
    /// The address_4 attribute.
    /// </summary>
    [TerraformPropertyName("address_4")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address4 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? City { get; set; }

    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformPropertyName("country")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Country { get; set; }

    /// <summary>
    /// The county attribute.
    /// </summary>
    [TerraformPropertyName("county")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? County { get; set; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostalCode { get; set; }

    /// <summary>
    /// The province attribute.
    /// </summary>
    [TerraformPropertyName("province")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Province { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

}

/// <summary>
/// Block type for shipping_address in .
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesProfileShippingAddressBlock : ITerraformBlock
{
    /// <summary>
    /// The address_1 attribute.
    /// </summary>
    [TerraformPropertyName("address_1")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address1 { get; set; }

    /// <summary>
    /// The address_2 attribute.
    /// </summary>
    [TerraformPropertyName("address_2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address2 { get; set; }

    /// <summary>
    /// The address_3 attribute.
    /// </summary>
    [TerraformPropertyName("address_3")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address3 { get; set; }

    /// <summary>
    /// The address_4 attribute.
    /// </summary>
    [TerraformPropertyName("address_4")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Address4 { get; set; }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [TerraformPropertyName("city")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? City { get; set; }

    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformPropertyName("country")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Country { get; set; }

    /// <summary>
    /// The county attribute.
    /// </summary>
    [TerraformPropertyName("county")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? County { get; set; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostalCode { get; set; }

    /// <summary>
    /// The province attribute.
    /// </summary>
    [TerraformPropertyName("province")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Province { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

}

/// <summary>
/// Manages a aws_customerprofiles_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCustomerprofilesProfile : TerraformResource
{
    public AwsCustomerprofilesProfile(string name) : base("aws_customerprofiles_profile", name)
    {
    }

    /// <summary>
    /// The account_number attribute.
    /// </summary>
    [TerraformPropertyName("account_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccountNumber { get; set; }

    /// <summary>
    /// The additional_information attribute.
    /// </summary>
    [TerraformPropertyName("additional_information")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdditionalInformation { get; set; }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [TerraformPropertyName("attributes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Attributes { get; set; }

    /// <summary>
    /// The birth_date attribute.
    /// </summary>
    [TerraformPropertyName("birth_date")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BirthDate { get; set; }

    /// <summary>
    /// The business_email_address attribute.
    /// </summary>
    [TerraformPropertyName("business_email_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BusinessEmailAddress { get; set; }

    /// <summary>
    /// The business_name attribute.
    /// </summary>
    [TerraformPropertyName("business_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BusinessName { get; set; }

    /// <summary>
    /// The business_phone_number attribute.
    /// </summary>
    [TerraformPropertyName("business_phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BusinessPhoneNumber { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [TerraformPropertyName("email_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EmailAddress { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirstName { get; set; }

    /// <summary>
    /// The gender_string attribute.
    /// </summary>
    [TerraformPropertyName("gender_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GenderString { get; set; }

    /// <summary>
    /// The home_phone_number attribute.
    /// </summary>
    [TerraformPropertyName("home_phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HomePhoneNumber { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LastName { get; set; }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    [TerraformPropertyName("middle_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MiddleName { get; set; }

    /// <summary>
    /// The mobile_phone_number attribute.
    /// </summary>
    [TerraformPropertyName("mobile_phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MobilePhoneNumber { get; set; }

    /// <summary>
    /// The party_type_string attribute.
    /// </summary>
    [TerraformPropertyName("party_type_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PartyTypeString { get; set; }

    /// <summary>
    /// The personal_email_address attribute.
    /// </summary>
    [TerraformPropertyName("personal_email_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PersonalEmailAddress { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PhoneNumber { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for address.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Address block(s) allowed")]
    [TerraformPropertyName("address")]
    public TerraformList<TerraformBlock<AwsCustomerprofilesProfileAddressBlock>>? Address { get; set; } = new();

    /// <summary>
    /// Block for billing_address.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BillingAddress block(s) allowed")]
    [TerraformPropertyName("billing_address")]
    public TerraformList<TerraformBlock<AwsCustomerprofilesProfileBillingAddressBlock>>? BillingAddress { get; set; } = new();

    /// <summary>
    /// Block for mailing_address.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MailingAddress block(s) allowed")]
    [TerraformPropertyName("mailing_address")]
    public TerraformList<TerraformBlock<AwsCustomerprofilesProfileMailingAddressBlock>>? MailingAddress { get; set; } = new();

    /// <summary>
    /// Block for shipping_address.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShippingAddress block(s) allowed")]
    [TerraformPropertyName("shipping_address")]
    public TerraformList<TerraformBlock<AwsCustomerprofilesProfileShippingAddressBlock>>? ShippingAddress { get; set; } = new();

}
