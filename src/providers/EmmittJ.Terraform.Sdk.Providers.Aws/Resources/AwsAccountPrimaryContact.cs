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
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressLine1 is required")]
    public required TerraformValue<string> AddressLine1
    {
        get => GetRequiredArgument<TerraformValue<string>>("address_line_1");
        set => SetArgument("address_line_1", value);
    }

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformValue<string>? AddressLine2
    {
        get => GetArgument<TerraformValue<string>>("address_line_2");
        set => SetArgument("address_line_2", value);
    }

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    public TerraformValue<string>? AddressLine3
    {
        get => GetArgument<TerraformValue<string>>("address_line_3");
        set => SetArgument("address_line_3", value);
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "City is required")]
    public required TerraformValue<string> City
    {
        get => GetRequiredArgument<TerraformValue<string>>("city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    public TerraformValue<string>? CompanyName
    {
        get => GetArgument<TerraformValue<string>>("company_name");
        set => SetArgument("company_name", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    public required TerraformValue<string> CountryCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    public TerraformValue<string>? DistrictOrCounty
    {
        get => GetArgument<TerraformValue<string>>("district_or_county");
        set => SetArgument("district_or_county", value);
    }

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullName is required")]
    public required TerraformValue<string> FullName
    {
        get => GetRequiredArgument<TerraformValue<string>>("full_name");
        set => SetArgument("full_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostalCode is required")]
    public required TerraformValue<string> PostalCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("postal_code");
        set => SetArgument("postal_code", value);
    }

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    public TerraformValue<string>? StateOrRegion
    {
        get => GetArgument<TerraformValue<string>>("state_or_region");
        set => SetArgument("state_or_region", value);
    }

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    public TerraformValue<string>? WebsiteUrl
    {
        get => GetArgument<TerraformValue<string>>("website_url");
        set => SetArgument("website_url", value);
    }

}
