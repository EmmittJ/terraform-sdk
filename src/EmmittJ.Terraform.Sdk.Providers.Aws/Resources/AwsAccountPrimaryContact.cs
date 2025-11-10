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
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressLine1 is required")]
    public required TerraformProperty<string> AddressLine1
    {
        get => GetProperty<TerraformProperty<string>>("address_line_1");
        set => this.WithProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine2
    {
        get => GetProperty<TerraformProperty<string>>("address_line_2");
        set => this.WithProperty("address_line_2", value);
    }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressLine3
    {
        get => GetProperty<TerraformProperty<string>>("address_line_3");
        set => this.WithProperty("address_line_3", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "City is required")]
    public required TerraformProperty<string> City
    {
        get => GetProperty<TerraformProperty<string>>("city");
        set => this.WithProperty("city", value);
    }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    public TerraformProperty<string>? CompanyName
    {
        get => GetProperty<TerraformProperty<string>>("company_name");
        set => this.WithProperty("company_name", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    public required TerraformProperty<string> CountryCode
    {
        get => GetProperty<TerraformProperty<string>>("country_code");
        set => this.WithProperty("country_code", value);
    }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    public TerraformProperty<string>? DistrictOrCounty
    {
        get => GetProperty<TerraformProperty<string>>("district_or_county");
        set => this.WithProperty("district_or_county", value);
    }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullName is required")]
    public required TerraformProperty<string> FullName
    {
        get => GetProperty<TerraformProperty<string>>("full_name");
        set => this.WithProperty("full_name", value);
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
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => this.WithProperty("phone_number", value);
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostalCode is required")]
    public required TerraformProperty<string> PostalCode
    {
        get => GetProperty<TerraformProperty<string>>("postal_code");
        set => this.WithProperty("postal_code", value);
    }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    public TerraformProperty<string>? StateOrRegion
    {
        get => GetProperty<TerraformProperty<string>>("state_or_region");
        set => this.WithProperty("state_or_region", value);
    }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    public TerraformProperty<string>? WebsiteUrl
    {
        get => GetProperty<TerraformProperty<string>>("website_url");
        set => this.WithProperty("website_url", value);
    }

}
