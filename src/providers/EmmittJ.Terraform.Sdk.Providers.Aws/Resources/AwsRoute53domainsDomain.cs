using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for admin_contact in AwsRoute53domainsDomain.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainAdminContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_contact";

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformValue<string>? AddressLine1
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
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => new TerraformReference<string>(this, "city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformValue<string>? ContactType
    {
        get => new TerraformReference<string>(this, "contact_type");
        set => SetArgument("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => new TerraformReference<string>(this, "country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformValue<string>? Fax
    {
        get => new TerraformReference<string>(this, "fax");
        set => SetArgument("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationName
    {
        get => new TerraformReference<string>(this, "organization_name");
        set => SetArgument("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string>? PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformValue<string>? ZipCode
    {
        get => new TerraformReference<string>(this, "zip_code");
        set => SetArgument("zip_code", value);
    }

    /// <summary>
    /// ExtraParam block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53domainsDomainAdminContactBlockExtraParamBlock>? ExtraParam
    {
        get => GetArgument<TerraformList<AwsRoute53domainsDomainAdminContactBlockExtraParamBlock>>("extra_param");
        set => SetArgument("extra_param", value);
    }

}

/// <summary>
/// Block type for extra_param in AwsRoute53domainsDomainAdminContactBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainAdminContactBlockExtraParamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extra_param";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for registrant_contact in AwsRoute53domainsDomain.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainRegistrantContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registrant_contact";

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformValue<string>? AddressLine1
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
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => new TerraformReference<string>(this, "city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformValue<string>? ContactType
    {
        get => new TerraformReference<string>(this, "contact_type");
        set => SetArgument("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => new TerraformReference<string>(this, "country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformValue<string>? Fax
    {
        get => new TerraformReference<string>(this, "fax");
        set => SetArgument("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationName
    {
        get => new TerraformReference<string>(this, "organization_name");
        set => SetArgument("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string>? PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformValue<string>? ZipCode
    {
        get => new TerraformReference<string>(this, "zip_code");
        set => SetArgument("zip_code", value);
    }

    /// <summary>
    /// ExtraParam block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53domainsDomainRegistrantContactBlockExtraParamBlock>? ExtraParam
    {
        get => GetArgument<TerraformList<AwsRoute53domainsDomainRegistrantContactBlockExtraParamBlock>>("extra_param");
        set => SetArgument("extra_param", value);
    }

}

/// <summary>
/// Block type for extra_param in AwsRoute53domainsDomainRegistrantContactBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainRegistrantContactBlockExtraParamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extra_param";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for tech_contact in AwsRoute53domainsDomain.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainTechContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tech_contact";

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformValue<string>? AddressLine1
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
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => new TerraformReference<string>(this, "city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformValue<string>? ContactType
    {
        get => new TerraformReference<string>(this, "contact_type");
        set => SetArgument("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => new TerraformReference<string>(this, "country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformValue<string>? Fax
    {
        get => new TerraformReference<string>(this, "fax");
        set => SetArgument("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationName
    {
        get => new TerraformReference<string>(this, "organization_name");
        set => SetArgument("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string>? PhoneNumber
    {
        get => new TerraformReference<string>(this, "phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformValue<string>? ZipCode
    {
        get => new TerraformReference<string>(this, "zip_code");
        set => SetArgument("zip_code", value);
    }

    /// <summary>
    /// ExtraParam block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53domainsDomainTechContactBlockExtraParamBlock>? ExtraParam
    {
        get => GetArgument<TerraformList<AwsRoute53domainsDomainTechContactBlockExtraParamBlock>>("extra_param");
        set => SetArgument("extra_param", value);
    }

}

/// <summary>
/// Block type for extra_param in AwsRoute53domainsDomainTechContactBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDomainTechContactBlockExtraParamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extra_param";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRoute53domainsDomain.
/// Nesting mode: single
/// </summary>
public class AwsRoute53domainsDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_route53domains_domain Terraform resource.
/// Manages a aws_route53domains_domain resource.
/// </summary>
public partial class AwsRoute53domainsDomain(string name) : TerraformResource("aws_route53domains_domain", name)
{
    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    public TerraformValue<bool> AdminPrivacy
    {
        get => new TerraformReference<bool>(this, "admin_privacy");
        set => SetArgument("admin_privacy", value);
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformValue<bool> AutoRenew
    {
        get => new TerraformReference<bool>(this, "auto_renew");
        set => SetArgument("auto_renew", value);
    }

    /// <summary>
    /// The billing_contact attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BillingContact
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "billing_contact").ResolveNodes(ctx));
        set => SetArgument("billing_contact", value);
    }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    public TerraformValue<bool> BillingPrivacy
    {
        get => new TerraformReference<bool>(this, "billing_privacy");
        set => SetArgument("billing_privacy", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The duration_in_years attribute.
    /// </summary>
    public TerraformValue<double> DurationInYears
    {
        get => new TerraformReference<double>(this, "duration_in_years");
        set => SetArgument("duration_in_years", value);
    }

    /// <summary>
    /// The name_server attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NameServer
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "name_server").ResolveNodes(ctx));
        set => SetArgument("name_server", value);
    }

    /// <summary>
    /// The registrant_privacy attribute.
    /// </summary>
    public TerraformValue<bool> RegistrantPrivacy
    {
        get => new TerraformReference<bool>(this, "registrant_privacy");
        set => SetArgument("registrant_privacy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    public TerraformValue<bool> TechPrivacy
    {
        get => new TerraformReference<bool>(this, "tech_privacy");
        set => SetArgument("tech_privacy", value);
    }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    public TerraformValue<bool> TransferLock
    {
        get => new TerraformReference<bool>(this, "transfer_lock");
        set => SetArgument("transfer_lock", value);
    }

    /// <summary>
    /// The abuse_contact_email attribute.
    /// </summary>
    public TerraformValue<string> AbuseContactEmail
    {
        get => new TerraformReference<string>(this, "abuse_contact_email");
    }

    /// <summary>
    /// The abuse_contact_phone attribute.
    /// </summary>
    public TerraformValue<string> AbuseContactPhone
    {
        get => new TerraformReference<string>(this, "abuse_contact_phone");
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The registrar_name attribute.
    /// </summary>
    public TerraformValue<string> RegistrarName
    {
        get => new TerraformReference<string>(this, "registrar_name");
    }

    /// <summary>
    /// The registrar_url attribute.
    /// </summary>
    public TerraformValue<string> RegistrarUrl
    {
        get => new TerraformReference<string>(this, "registrar_url");
    }

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    public TerraformList<string> StatusList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "status_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The updated_date attribute.
    /// </summary>
    public TerraformValue<string> UpdatedDate
    {
        get => new TerraformReference<string>(this, "updated_date");
    }

    /// <summary>
    /// The whois_server attribute.
    /// </summary>
    public TerraformValue<string> WhoisServer
    {
        get => new TerraformReference<string>(this, "whois_server");
    }

    /// <summary>
    /// AdminContact block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53domainsDomainAdminContactBlock>? AdminContact
    {
        get => GetArgument<TerraformList<AwsRoute53domainsDomainAdminContactBlock>>("admin_contact");
        set => SetArgument("admin_contact", value);
    }

    /// <summary>
    /// RegistrantContact block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53domainsDomainRegistrantContactBlock>? RegistrantContact
    {
        get => GetArgument<TerraformList<AwsRoute53domainsDomainRegistrantContactBlock>>("registrant_contact");
        set => SetArgument("registrant_contact", value);
    }

    /// <summary>
    /// TechContact block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53domainsDomainTechContactBlock>? TechContact
    {
        get => GetArgument<TerraformList<AwsRoute53domainsDomainTechContactBlock>>("tech_contact");
        set => SetArgument("tech_contact", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53domainsDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53domainsDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
