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
    public TerraformLiteralProperty<string>? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AddressLine1
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_line_1");
        set => this.WithProperty("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AddressLine2
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_line_2");
        set => this.WithProperty("address_line_2", value);
    }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AddressLine3
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_line_3");
        set => this.WithProperty("address_line_3", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? City
    {
        get => GetProperty<TerraformLiteralProperty<string>>("city");
        set => this.WithProperty("city", value);
    }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CompanyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("company_name");
        set => this.WithProperty("company_name", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CountryCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("country_code");
        set => this.WithProperty("country_code", value);
    }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DistrictOrCounty
    {
        get => GetProperty<TerraformLiteralProperty<string>>("district_or_county");
        set => this.WithProperty("district_or_county", value);
    }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FullName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("full_name");
        set => this.WithProperty("full_name", value);
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
    /// The phone_number attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("phone_number");
        set => this.WithProperty("phone_number", value);
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PostalCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("postal_code");
        set => this.WithProperty("postal_code", value);
    }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StateOrRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state_or_region");
        set => this.WithProperty("state_or_region", value);
    }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WebsiteUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("website_url");
        set => this.WithProperty("website_url", value);
    }

}
