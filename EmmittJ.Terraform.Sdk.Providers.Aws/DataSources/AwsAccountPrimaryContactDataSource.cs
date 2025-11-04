using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_account_primary_contact.
/// </summary>
public class AwsAccountPrimaryContactDataSource : TerraformDataSource
{
    public AwsAccountPrimaryContactDataSource(string name) : base("aws_account_primary_contact", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        DeclareOutput("address_line_1");
        DeclareOutput("address_line_2");
        DeclareOutput("address_line_3");
        DeclareOutput("city");
        DeclareOutput("company_name");
        DeclareOutput("country_code");
        DeclareOutput("district_or_county");
        DeclareOutput("full_name");
        DeclareOutput("phone_number");
        DeclareOutput("postal_code");
        DeclareOutput("state_or_region");
        DeclareOutput("website_url");
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
    public TerraformExpression AddressLine1 => this["address_line_1"];

    /// <summary>
    /// The address_line_2 attribute.
    /// </summary>
    public TerraformExpression AddressLine2 => this["address_line_2"];

    /// <summary>
    /// The address_line_3 attribute.
    /// </summary>
    public TerraformExpression AddressLine3 => this["address_line_3"];

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformExpression City => this["city"];

    /// <summary>
    /// The company_name attribute.
    /// </summary>
    public TerraformExpression CompanyName => this["company_name"];

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformExpression CountryCode => this["country_code"];

    /// <summary>
    /// The district_or_county attribute.
    /// </summary>
    public TerraformExpression DistrictOrCounty => this["district_or_county"];

    /// <summary>
    /// The full_name attribute.
    /// </summary>
    public TerraformExpression FullName => this["full_name"];

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformExpression PhoneNumber => this["phone_number"];

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    public TerraformExpression PostalCode => this["postal_code"];

    /// <summary>
    /// The state_or_region attribute.
    /// </summary>
    public TerraformExpression StateOrRegion => this["state_or_region"];

    /// <summary>
    /// The website_url attribute.
    /// </summary>
    public TerraformExpression WebsiteUrl => this["website_url"];

}
