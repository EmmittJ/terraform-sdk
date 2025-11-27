using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_account_primary_contact Terraform resource.
/// Manages a aws_account_primary_contact resource.
/// </summary>
public partial class AwsAccountPrimaryContact(string name) : TerraformResource("aws_account_primary_contact", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressLine1 is required")]
    public required TerraformValue<string> AddressLine1
    {
        get => new TerraformReference<string>(this, "address_line_1");
        set => SetArgument("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformValue<string>? AddressLine2
    {
        get => new TerraformReference<string>(this, "address_line_2");
        set => SetArgument("address_line_2", value);
    }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    public TerraformValue<string>? AddressLine3
    {
        get => new TerraformReference<string>(this, "address_line_3");
        set => SetArgument("address_line_3", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "City is required")]
    public required TerraformValue<string> City
    {
        get => new TerraformReference<string>(this, "city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    public TerraformValue<string>? CompanyName
    {
        get => new TerraformReference<string>(this, "company_name");
        set => SetArgument("company_name", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    public required TerraformValue<string> CountryCode
    {
        get => new TerraformReference<string>(this, "country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    public TerraformValue<string>? DistrictOrCounty
    {
        get => new TerraformReference<string>(this, "district_or_county");
        set => SetArgument("district_or_county", value);
    }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullName is required")]
    public required TerraformValue<string> FullName
    {
        get => new TerraformReference<string>(this, "full_name");
        set => SetArgument("full_name", value);
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
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostalCode is required")]
    public required TerraformValue<string> PostalCode
    {
        get => new TerraformReference<string>(this, "postal_code");
        set => SetArgument("postal_code", value);
    }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    public TerraformValue<string>? StateOrRegion
    {
        get => new TerraformReference<string>(this, "state_or_region");
        set => SetArgument("state_or_region", value);
    }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    public TerraformValue<string>? WebsiteUrl
    {
        get => new TerraformReference<string>(this, "website_url");
        set => SetArgument("website_url", value);
    }

}
