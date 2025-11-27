using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_account_primary_contact Terraform data source.
/// Retrieves information about a aws_account_primary_contact.
/// </summary>
public partial class AwsAccountPrimaryContactDataSource(string name) : TerraformDataSource("aws_account_primary_contact", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformValue<string> AddressLine1
    {
        get => new TerraformReference<string>(this, "address_line_1");
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformValue<string> AddressLine2
    {
        get => new TerraformReference<string>(this, "address_line_2");
    }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    public TerraformValue<string> AddressLine3
    {
        get => new TerraformReference<string>(this, "address_line_3");
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformValue<string> City
    {
        get => new TerraformReference<string>(this, "city");
    }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    public TerraformValue<string> CompanyName
    {
        get => new TerraformReference<string>(this, "company_name");
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformValue<string> CountryCode
    {
        get => new TerraformReference<string>(this, "country_code");
    }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    public TerraformValue<string> DistrictOrCounty
    {
        get => new TerraformReference<string>(this, "district_or_county");
    }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    public TerraformValue<string> FullName
    {
        get => new TerraformReference<string>(this, "full_name");
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    public TerraformValue<string> PostalCode
    {
        get => new TerraformReference<string>(this, "postal_code");
    }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    public TerraformValue<string> StateOrRegion
    {
        get => new TerraformReference<string>(this, "state_or_region");
    }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    public TerraformValue<string> WebsiteUrl
    {
        get => new TerraformReference<string>(this, "website_url");
    }

}
