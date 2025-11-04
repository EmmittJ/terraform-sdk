using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

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
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("account_id")?.Value;
        set => WithPropertyInternal("account_id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public string? AddressLine1
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("address_line_1")?.Value;
        set => WithPropertyInternal("address_line_1", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public string? AddressLine2
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("address_line_2")?.Value;
        set => WithPropertyInternal("address_line_2", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    public string? AddressLine3
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("address_line_3")?.Value;
        set => WithPropertyInternal("address_line_3", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public string? City
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("city")?.Value;
        set => WithPropertyInternal("city", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    public string? CompanyName
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("company_name")?.Value;
        set => WithPropertyInternal("company_name", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public string? CountryCode
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("country_code")?.Value;
        set => WithPropertyInternal("country_code", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    public string? DistrictOrCounty
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("district_or_county")?.Value;
        set => WithPropertyInternal("district_or_county", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    public string? FullName
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("full_name")?.Value;
        set => WithPropertyInternal("full_name", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public string? PhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("phone_number")?.Value;
        set => WithPropertyInternal("phone_number", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    public string? PostalCode
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("postal_code")?.Value;
        set => WithPropertyInternal("postal_code", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    public string? StateOrRegion
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("state_or_region")?.Value;
        set => WithPropertyInternal("state_or_region", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    public string? WebsiteUrl
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("website_url")?.Value;
        set => WithPropertyInternal("website_url", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

}
