using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for address in AwsCustomerprofilesProfile.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesProfileAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "address";

    /// <summary>
    /// The address_1 attribute.
    /// </summary>
    public TerraformValue<string>? Address1
    {
        get => new TerraformReference<string>(this, "address_1");
        set => SetArgument("address_1", value);
    }

    /// <summary>
    /// The address_2 attribute.
    /// </summary>
    public TerraformValue<string>? Address2
    {
        get => new TerraformReference<string>(this, "address_2");
        set => SetArgument("address_2", value);
    }

    /// <summary>
    /// The address_3 attribute.
    /// </summary>
    public TerraformValue<string>? Address3
    {
        get => new TerraformReference<string>(this, "address_3");
        set => SetArgument("address_3", value);
    }

    /// <summary>
    /// The address_4 attribute.
    /// </summary>
    public TerraformValue<string>? Address4
    {
        get => new TerraformReference<string>(this, "address_4");
        set => SetArgument("address_4", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => new TerraformReference<string>(this, "city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => new TerraformReference<string>(this, "country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The county attribute.
    /// </summary>
    public TerraformValue<string>? County
    {
        get => new TerraformReference<string>(this, "county");
        set => SetArgument("county", value);
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
    /// The province attribute.
    /// </summary>
    public TerraformValue<string>? Province
    {
        get => new TerraformReference<string>(this, "province");
        set => SetArgument("province", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for billing_address in AwsCustomerprofilesProfile.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesProfileBillingAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "billing_address";

    /// <summary>
    /// The address_1 attribute.
    /// </summary>
    public TerraformValue<string>? Address1
    {
        get => new TerraformReference<string>(this, "address_1");
        set => SetArgument("address_1", value);
    }

    /// <summary>
    /// The address_2 attribute.
    /// </summary>
    public TerraformValue<string>? Address2
    {
        get => new TerraformReference<string>(this, "address_2");
        set => SetArgument("address_2", value);
    }

    /// <summary>
    /// The address_3 attribute.
    /// </summary>
    public TerraformValue<string>? Address3
    {
        get => new TerraformReference<string>(this, "address_3");
        set => SetArgument("address_3", value);
    }

    /// <summary>
    /// The address_4 attribute.
    /// </summary>
    public TerraformValue<string>? Address4
    {
        get => new TerraformReference<string>(this, "address_4");
        set => SetArgument("address_4", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => new TerraformReference<string>(this, "city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => new TerraformReference<string>(this, "country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The county attribute.
    /// </summary>
    public TerraformValue<string>? County
    {
        get => new TerraformReference<string>(this, "county");
        set => SetArgument("county", value);
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
    /// The province attribute.
    /// </summary>
    public TerraformValue<string>? Province
    {
        get => new TerraformReference<string>(this, "province");
        set => SetArgument("province", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for mailing_address in AwsCustomerprofilesProfile.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesProfileMailingAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mailing_address";

    /// <summary>
    /// The address_1 attribute.
    /// </summary>
    public TerraformValue<string>? Address1
    {
        get => new TerraformReference<string>(this, "address_1");
        set => SetArgument("address_1", value);
    }

    /// <summary>
    /// The address_2 attribute.
    /// </summary>
    public TerraformValue<string>? Address2
    {
        get => new TerraformReference<string>(this, "address_2");
        set => SetArgument("address_2", value);
    }

    /// <summary>
    /// The address_3 attribute.
    /// </summary>
    public TerraformValue<string>? Address3
    {
        get => new TerraformReference<string>(this, "address_3");
        set => SetArgument("address_3", value);
    }

    /// <summary>
    /// The address_4 attribute.
    /// </summary>
    public TerraformValue<string>? Address4
    {
        get => new TerraformReference<string>(this, "address_4");
        set => SetArgument("address_4", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => new TerraformReference<string>(this, "city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => new TerraformReference<string>(this, "country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The county attribute.
    /// </summary>
    public TerraformValue<string>? County
    {
        get => new TerraformReference<string>(this, "county");
        set => SetArgument("county", value);
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
    /// The province attribute.
    /// </summary>
    public TerraformValue<string>? Province
    {
        get => new TerraformReference<string>(this, "province");
        set => SetArgument("province", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for shipping_address in AwsCustomerprofilesProfile.
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesProfileShippingAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shipping_address";

    /// <summary>
    /// The address_1 attribute.
    /// </summary>
    public TerraformValue<string>? Address1
    {
        get => new TerraformReference<string>(this, "address_1");
        set => SetArgument("address_1", value);
    }

    /// <summary>
    /// The address_2 attribute.
    /// </summary>
    public TerraformValue<string>? Address2
    {
        get => new TerraformReference<string>(this, "address_2");
        set => SetArgument("address_2", value);
    }

    /// <summary>
    /// The address_3 attribute.
    /// </summary>
    public TerraformValue<string>? Address3
    {
        get => new TerraformReference<string>(this, "address_3");
        set => SetArgument("address_3", value);
    }

    /// <summary>
    /// The address_4 attribute.
    /// </summary>
    public TerraformValue<string>? Address4
    {
        get => new TerraformReference<string>(this, "address_4");
        set => SetArgument("address_4", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => new TerraformReference<string>(this, "city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => new TerraformReference<string>(this, "country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The county attribute.
    /// </summary>
    public TerraformValue<string>? County
    {
        get => new TerraformReference<string>(this, "county");
        set => SetArgument("county", value);
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
    /// The province attribute.
    /// </summary>
    public TerraformValue<string>? Province
    {
        get => new TerraformReference<string>(this, "province");
        set => SetArgument("province", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Represents a aws_customerprofiles_profile Terraform resource.
/// Manages a aws_customerprofiles_profile resource.
/// </summary>
public partial class AwsCustomerprofilesProfile(string name) : TerraformResource("aws_customerprofiles_profile", name)
{
    /// <summary>
    /// The account_number attribute.
    /// </summary>
    public TerraformValue<string>? AccountNumber
    {
        get => new TerraformReference<string>(this, "account_number");
        set => SetArgument("account_number", value);
    }

    /// <summary>
    /// The additional_information attribute.
    /// </summary>
    public TerraformValue<string>? AdditionalInformation
    {
        get => new TerraformReference<string>(this, "additional_information");
        set => SetArgument("additional_information", value);
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformMap<string>? Attributes
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "attributes").ResolveNodes(ctx));
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// The birth_date attribute.
    /// </summary>
    public TerraformValue<string>? BirthDate
    {
        get => new TerraformReference<string>(this, "birth_date");
        set => SetArgument("birth_date", value);
    }

    /// <summary>
    /// The business_email_address attribute.
    /// </summary>
    public TerraformValue<string>? BusinessEmailAddress
    {
        get => new TerraformReference<string>(this, "business_email_address");
        set => SetArgument("business_email_address", value);
    }

    /// <summary>
    /// The business_name attribute.
    /// </summary>
    public TerraformValue<string>? BusinessName
    {
        get => new TerraformReference<string>(this, "business_name");
        set => SetArgument("business_name", value);
    }

    /// <summary>
    /// The business_phone_number attribute.
    /// </summary>
    public TerraformValue<string>? BusinessPhoneNumber
    {
        get => new TerraformReference<string>(this, "business_phone_number");
        set => SetArgument("business_phone_number", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformValue<string>? EmailAddress
    {
        get => new TerraformReference<string>(this, "email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The gender_string attribute.
    /// </summary>
    public TerraformValue<string>? GenderString
    {
        get => new TerraformReference<string>(this, "gender_string");
        set => SetArgument("gender_string", value);
    }

    /// <summary>
    /// The home_phone_number attribute.
    /// </summary>
    public TerraformValue<string>? HomePhoneNumber
    {
        get => new TerraformReference<string>(this, "home_phone_number");
        set => SetArgument("home_phone_number", value);
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
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    public TerraformValue<string>? MiddleName
    {
        get => new TerraformReference<string>(this, "middle_name");
        set => SetArgument("middle_name", value);
    }

    /// <summary>
    /// The mobile_phone_number attribute.
    /// </summary>
    public TerraformValue<string>? MobilePhoneNumber
    {
        get => new TerraformReference<string>(this, "mobile_phone_number");
        set => SetArgument("mobile_phone_number", value);
    }

    /// <summary>
    /// The party_type_string attribute.
    /// </summary>
    public TerraformValue<string>? PartyTypeString
    {
        get => new TerraformReference<string>(this, "party_type_string");
        set => SetArgument("party_type_string", value);
    }

    /// <summary>
    /// The personal_email_address attribute.
    /// </summary>
    public TerraformValue<string>? PersonalEmailAddress
    {
        get => new TerraformReference<string>(this, "personal_email_address");
        set => SetArgument("personal_email_address", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string>? PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
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
    /// Address block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Address block(s) allowed")]
    public TerraformList<AwsCustomerprofilesProfileAddressBlock>? Address
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesProfileAddressBlock>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// BillingAddress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BillingAddress block(s) allowed")]
    public TerraformList<AwsCustomerprofilesProfileBillingAddressBlock>? BillingAddress
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesProfileBillingAddressBlock>>("billing_address");
        set => SetArgument("billing_address", value);
    }

    /// <summary>
    /// MailingAddress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MailingAddress block(s) allowed")]
    public TerraformList<AwsCustomerprofilesProfileMailingAddressBlock>? MailingAddress
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesProfileMailingAddressBlock>>("mailing_address");
        set => SetArgument("mailing_address", value);
    }

    /// <summary>
    /// ShippingAddress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShippingAddress block(s) allowed")]
    public TerraformList<AwsCustomerprofilesProfileShippingAddressBlock>? ShippingAddress
    {
        get => GetArgument<TerraformList<AwsCustomerprofilesProfileShippingAddressBlock>>("shipping_address");
        set => SetArgument("shipping_address", value);
    }

}
