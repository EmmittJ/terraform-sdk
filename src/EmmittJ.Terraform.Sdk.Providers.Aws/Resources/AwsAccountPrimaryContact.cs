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
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public string? AddressLine1
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_line_1")?.Value;
        set => this.WithProperty("address_line_1", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public string? AddressLine2
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_line_2")?.Value;
        set => this.WithProperty("address_line_2", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    public string? AddressLine3
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_line_3")?.Value;
        set => this.WithProperty("address_line_3", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public string? City
    {
        get => GetProperty<TerraformLiteralProperty<string>>("city")?.Value;
        set => this.WithProperty("city", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    public string? CompanyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("company_name")?.Value;
        set => this.WithProperty("company_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public string? CountryCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("country_code")?.Value;
        set => this.WithProperty("country_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    public string? DistrictOrCounty
    {
        get => GetProperty<TerraformLiteralProperty<string>>("district_or_county")?.Value;
        set => this.WithProperty("district_or_county", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    public string? FullName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("full_name")?.Value;
        set => this.WithProperty("full_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The phone_number attribute.
    /// </summary>
    public string? PhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("phone_number")?.Value;
        set => this.WithProperty("phone_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    public string? PostalCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("postal_code")?.Value;
        set => this.WithProperty("postal_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    public string? StateOrRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state_or_region")?.Value;
        set => this.WithProperty("state_or_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    public string? WebsiteUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("website_url")?.Value;
        set => this.WithProperty("website_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
