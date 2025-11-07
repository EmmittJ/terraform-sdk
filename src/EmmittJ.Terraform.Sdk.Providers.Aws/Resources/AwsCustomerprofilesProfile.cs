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
    public TerraformLiteralProperty<string>? AccountNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_number");
        set => this.WithProperty("account_number", value);
    }

    /// <summary>
    /// The additional_information attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdditionalInformation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_information");
        set => this.WithProperty("additional_information", value);
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Attributes
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("attributes");
        set => this.WithProperty("attributes", value);
    }

    /// <summary>
    /// The birth_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BirthDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("birth_date");
        set => this.WithProperty("birth_date", value);
    }

    /// <summary>
    /// The business_email_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BusinessEmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("business_email_address");
        set => this.WithProperty("business_email_address", value);
    }

    /// <summary>
    /// The business_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BusinessName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("business_name");
        set => this.WithProperty("business_name", value);
    }

    /// <summary>
    /// The business_phone_number attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BusinessPhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("business_phone_number");
        set => this.WithProperty("business_phone_number", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address");
        set => this.WithProperty("email_address", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FirstName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("first_name");
        set => this.WithProperty("first_name", value);
    }

    /// <summary>
    /// The gender_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GenderString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gender_string");
        set => this.WithProperty("gender_string", value);
    }

    /// <summary>
    /// The home_phone_number attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HomePhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("home_phone_number");
        set => this.WithProperty("home_phone_number", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LastName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("last_name");
        set => this.WithProperty("last_name", value);
    }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MiddleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("middle_name");
        set => this.WithProperty("middle_name", value);
    }

    /// <summary>
    /// The mobile_phone_number attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MobilePhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_phone_number");
        set => this.WithProperty("mobile_phone_number", value);
    }

    /// <summary>
    /// The party_type_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PartyTypeString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("party_type_string");
        set => this.WithProperty("party_type_string", value);
    }

    /// <summary>
    /// The personal_email_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PersonalEmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("personal_email_address");
        set => this.WithProperty("personal_email_address", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("phone_number");
        set => this.WithProperty("phone_number", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
