using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_account_primary_contact resource.
/// </summary>
public class AwsAccountPrimaryContact : TerraformResource
{
    public AwsAccountPrimaryContact(string name) : base("aws_account_primary_contact", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_id");
        SetOutput("address_line_1");
        SetOutput("address_line_2");
        SetOutput("address_line_3");
        SetOutput("city");
        SetOutput("company_name");
        SetOutput("country_code");
        SetOutput("district_or_county");
        SetOutput("full_name");
        SetOutput("id");
        SetOutput("phone_number");
        SetOutput("postal_code");
        SetOutput("state_or_region");
        SetOutput("website_url");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressLine1 is required")]
    public required TerraformProperty<string> AddressLine1
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_line_1");
        set => SetProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string> AddressLine2
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_line_2");
        set => SetProperty("address_line_2", value);
    }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    public TerraformProperty<string> AddressLine3
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_line_3");
        set => SetProperty("address_line_3", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "City is required")]
    public required TerraformProperty<string> City
    {
        get => GetRequiredOutput<TerraformProperty<string>>("city");
        set => SetProperty("city", value);
    }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    public TerraformProperty<string> CompanyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("company_name");
        set => SetProperty("company_name", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    public required TerraformProperty<string> CountryCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("country_code");
        set => SetProperty("country_code", value);
    }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    public TerraformProperty<string> DistrictOrCounty
    {
        get => GetRequiredOutput<TerraformProperty<string>>("district_or_county");
        set => SetProperty("district_or_county", value);
    }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullName is required")]
    public required TerraformProperty<string> FullName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("full_name");
        set => SetProperty("full_name", value);
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
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        get => GetRequiredOutput<TerraformProperty<string>>("phone_number");
        set => SetProperty("phone_number", value);
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostalCode is required")]
    public required TerraformProperty<string> PostalCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("postal_code");
        set => SetProperty("postal_code", value);
    }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    public TerraformProperty<string> StateOrRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state_or_region");
        set => SetProperty("state_or_region", value);
    }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    public TerraformProperty<string> WebsiteUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("website_url");
        set => SetProperty("website_url", value);
    }

}
