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
    public string? AccountNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_number")?.Value;
        set => this.WithProperty("account_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The additional_information attribute.
    /// </summary>
    public string? AdditionalInformation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("additional_information")?.Value;
        set => this.WithProperty("additional_information", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public Dictionary<string, string>? Attributes
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("attributes")?.Value;
        set => this.WithProperty("attributes", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The birth_date attribute.
    /// </summary>
    public string? BirthDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("birth_date")?.Value;
        set => this.WithProperty("birth_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The business_email_address attribute.
    /// </summary>
    public string? BusinessEmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("business_email_address")?.Value;
        set => this.WithProperty("business_email_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The business_name attribute.
    /// </summary>
    public string? BusinessName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("business_name")?.Value;
        set => this.WithProperty("business_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The business_phone_number attribute.
    /// </summary>
    public string? BusinessPhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("business_phone_number")?.Value;
        set => this.WithProperty("business_phone_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public string? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address")?.Value;
        set => this.WithProperty("email_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public string? FirstName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("first_name")?.Value;
        set => this.WithProperty("first_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gender_string attribute.
    /// </summary>
    public string? GenderString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gender_string")?.Value;
        set => this.WithProperty("gender_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The home_phone_number attribute.
    /// </summary>
    public string? HomePhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("home_phone_number")?.Value;
        set => this.WithProperty("home_phone_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public string? LastName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("last_name")?.Value;
        set => this.WithProperty("last_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    public string? MiddleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("middle_name")?.Value;
        set => this.WithProperty("middle_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mobile_phone_number attribute.
    /// </summary>
    public string? MobilePhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_phone_number")?.Value;
        set => this.WithProperty("mobile_phone_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The party_type_string attribute.
    /// </summary>
    public string? PartyTypeString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("party_type_string")?.Value;
        set => this.WithProperty("party_type_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The personal_email_address attribute.
    /// </summary>
    public string? PersonalEmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("personal_email_address")?.Value;
        set => this.WithProperty("personal_email_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public string? PhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("phone_number")?.Value;
        set => this.WithProperty("phone_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
