using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_customerprofiles_profile resource.
/// </summary>
public class AwsCustomerprofilesProfile : TerraformResource
{
    public AwsCustomerprofilesProfile(string name) : base("aws_customerprofiles_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_number attribute.
    /// </summary>
    public TerraformProperty<string>? AccountNumber
    {
        get => GetProperty<TerraformProperty<string>>("account_number");
        set => this.WithProperty("account_number", value);
    }

    /// <summary>
    /// The additional_information attribute.
    /// </summary>
    public TerraformProperty<string>? AdditionalInformation
    {
        get => GetProperty<TerraformProperty<string>>("additional_information");
        set => this.WithProperty("additional_information", value);
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformMapProperty<string>? Attributes
    {
        get => GetProperty<TerraformMapProperty<string>>("attributes");
        set => this.WithProperty("attributes", value);
    }

    /// <summary>
    /// The birth_date attribute.
    /// </summary>
    public TerraformProperty<string>? BirthDate
    {
        get => GetProperty<TerraformProperty<string>>("birth_date");
        set => this.WithProperty("birth_date", value);
    }

    /// <summary>
    /// The business_email_address attribute.
    /// </summary>
    public TerraformProperty<string>? BusinessEmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("business_email_address");
        set => this.WithProperty("business_email_address", value);
    }

    /// <summary>
    /// The business_name attribute.
    /// </summary>
    public TerraformProperty<string>? BusinessName
    {
        get => GetProperty<TerraformProperty<string>>("business_name");
        set => this.WithProperty("business_name", value);
    }

    /// <summary>
    /// The business_phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? BusinessPhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("business_phone_number");
        set => this.WithProperty("business_phone_number", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformProperty<string>? EmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("email_address");
        set => this.WithProperty("email_address", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        get => GetProperty<TerraformProperty<string>>("first_name");
        set => this.WithProperty("first_name", value);
    }

    /// <summary>
    /// The gender_string attribute.
    /// </summary>
    public TerraformProperty<string>? GenderString
    {
        get => GetProperty<TerraformProperty<string>>("gender_string");
        set => this.WithProperty("gender_string", value);
    }

    /// <summary>
    /// The home_phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? HomePhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("home_phone_number");
        set => this.WithProperty("home_phone_number", value);
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
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        get => GetProperty<TerraformProperty<string>>("last_name");
        set => this.WithProperty("last_name", value);
    }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    public TerraformProperty<string>? MiddleName
    {
        get => GetProperty<TerraformProperty<string>>("middle_name");
        set => this.WithProperty("middle_name", value);
    }

    /// <summary>
    /// The mobile_phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? MobilePhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("mobile_phone_number");
        set => this.WithProperty("mobile_phone_number", value);
    }

    /// <summary>
    /// The party_type_string attribute.
    /// </summary>
    public TerraformProperty<string>? PartyTypeString
    {
        get => GetProperty<TerraformProperty<string>>("party_type_string");
        set => this.WithProperty("party_type_string", value);
    }

    /// <summary>
    /// The personal_email_address attribute.
    /// </summary>
    public TerraformProperty<string>? PersonalEmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("personal_email_address");
        set => this.WithProperty("personal_email_address", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => this.WithProperty("phone_number", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
