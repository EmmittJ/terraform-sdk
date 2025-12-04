using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for admin_contact in AwsRoute53domainsRegisteredDomain.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainAdminContactBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("address_line_1");
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
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => GetArgument<TerraformValue<string>>("city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformValue<string>? ContactType
    {
        get => GetArgument<TerraformValue<string>>("contact_type");
        set => SetArgument("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => GetArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public TerraformMap<string>? ExtraParams
    {
        get => GetArgument<TerraformMap<string>>("extra_params");
        set => SetArgument("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformValue<string>? Fax
    {
        get => GetArgument<TerraformValue<string>>("fax");
        set => SetArgument("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => GetArgument<TerraformValue<string>>("first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => GetArgument<TerraformValue<string>>("last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationName
    {
        get => GetArgument<TerraformValue<string>>("organization_name");
        set => SetArgument("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string>? PhoneNumber
    {
        get => GetArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformValue<string>? ZipCode
    {
        get => GetArgument<TerraformValue<string>>("zip_code");
        set => SetArgument("zip_code", value);
    }

}


/// <summary>
/// Block type for billing_contact in AwsRoute53domainsRegisteredDomain.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainBillingContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "billing_contact";

    /// <summary>
    /// The address_line_1 attribute.
    /// </summary>
    public TerraformValue<string>? AddressLine1
    {
        get => GetArgument<TerraformValue<string>>("address_line_1");
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
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => GetArgument<TerraformValue<string>>("city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformValue<string>? ContactType
    {
        get => GetArgument<TerraformValue<string>>("contact_type");
        set => SetArgument("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => GetArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public TerraformMap<string>? ExtraParams
    {
        get => GetArgument<TerraformMap<string>>("extra_params");
        set => SetArgument("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformValue<string>? Fax
    {
        get => GetArgument<TerraformValue<string>>("fax");
        set => SetArgument("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => GetArgument<TerraformValue<string>>("first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => GetArgument<TerraformValue<string>>("last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationName
    {
        get => GetArgument<TerraformValue<string>>("organization_name");
        set => SetArgument("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string>? PhoneNumber
    {
        get => GetArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformValue<string>? ZipCode
    {
        get => GetArgument<TerraformValue<string>>("zip_code");
        set => SetArgument("zip_code", value);
    }

}


/// <summary>
/// Block type for name_server in AwsRoute53domainsRegisteredDomain.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainNameServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "name_server";

    /// <summary>
    /// The glue_ips attribute.
    /// </summary>
    public TerraformSet<string>? GlueIps
    {
        get => GetArgument<TerraformSet<string>>("glue_ips");
        set => SetArgument("glue_ips", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for registrant_contact in AwsRoute53domainsRegisteredDomain.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainRegistrantContactBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("address_line_1");
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
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => GetArgument<TerraformValue<string>>("city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformValue<string>? ContactType
    {
        get => GetArgument<TerraformValue<string>>("contact_type");
        set => SetArgument("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => GetArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public TerraformMap<string>? ExtraParams
    {
        get => GetArgument<TerraformMap<string>>("extra_params");
        set => SetArgument("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformValue<string>? Fax
    {
        get => GetArgument<TerraformValue<string>>("fax");
        set => SetArgument("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => GetArgument<TerraformValue<string>>("first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => GetArgument<TerraformValue<string>>("last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationName
    {
        get => GetArgument<TerraformValue<string>>("organization_name");
        set => SetArgument("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string>? PhoneNumber
    {
        get => GetArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformValue<string>? ZipCode
    {
        get => GetArgument<TerraformValue<string>>("zip_code");
        set => SetArgument("zip_code", value);
    }

}


/// <summary>
/// Block type for tech_contact in AwsRoute53domainsRegisteredDomain.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsRegisteredDomainTechContactBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("address_line_1");
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
    /// The city attribute.
    /// </summary>
    public TerraformValue<string>? City
    {
        get => GetArgument<TerraformValue<string>>("city");
        set => SetArgument("city", value);
    }

    /// <summary>
    /// The contact_type attribute.
    /// </summary>
    public TerraformValue<string>? ContactType
    {
        get => GetArgument<TerraformValue<string>>("contact_type");
        set => SetArgument("contact_type", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => GetArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The extra_params attribute.
    /// </summary>
    public TerraformMap<string>? ExtraParams
    {
        get => GetArgument<TerraformMap<string>>("extra_params");
        set => SetArgument("extra_params", value);
    }

    /// <summary>
    /// The fax attribute.
    /// </summary>
    public TerraformValue<string>? Fax
    {
        get => GetArgument<TerraformValue<string>>("fax");
        set => SetArgument("fax", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string>? FirstName
    {
        get => GetArgument<TerraformValue<string>>("first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string>? LastName
    {
        get => GetArgument<TerraformValue<string>>("last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The organization_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationName
    {
        get => GetArgument<TerraformValue<string>>("organization_name");
        set => SetArgument("organization_name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string>? PhoneNumber
    {
        get => GetArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The zip_code attribute.
    /// </summary>
    public TerraformValue<string>? ZipCode
    {
        get => GetArgument<TerraformValue<string>>("zip_code");
        set => SetArgument("zip_code", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRoute53domainsRegisteredDomain.
/// Nesting mode: single
/// </summary>
public class AwsRoute53domainsRegisteredDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_route53domains_registered_domain Terraform resource.
/// Manages a aws_route53domains_registered_domain resource.
/// </summary>
public partial class AwsRoute53domainsRegisteredDomain(string name) : TerraformResource("aws_route53domains_registered_domain", name)
{
    /// <summary>
    /// The admin_privacy attribute.
    /// </summary>
    public TerraformValue<bool>? AdminPrivacy
    {
        get => GetArgument<TerraformValue<bool>>("admin_privacy");
        set => SetArgument("admin_privacy", value);
    }

    /// <summary>
    /// The auto_renew attribute.
    /// </summary>
    public TerraformValue<bool>? AutoRenew
    {
        get => GetArgument<TerraformValue<bool>>("auto_renew");
        set => SetArgument("auto_renew", value);
    }

    /// <summary>
    /// The billing_privacy attribute.
    /// </summary>
    public TerraformValue<bool>? BillingPrivacy
    {
        get => GetArgument<TerraformValue<bool>>("billing_privacy");
        set => SetArgument("billing_privacy", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The registrant_privacy attribute.
    /// </summary>
    public TerraformValue<bool>? RegistrantPrivacy
    {
        get => GetArgument<TerraformValue<bool>>("registrant_privacy");
        set => SetArgument("registrant_privacy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tech_privacy attribute.
    /// </summary>
    public TerraformValue<bool>? TechPrivacy
    {
        get => GetArgument<TerraformValue<bool>>("tech_privacy");
        set => SetArgument("tech_privacy", value);
    }

    /// <summary>
    /// The transfer_lock attribute.
    /// </summary>
    public TerraformValue<bool>? TransferLock
    {
        get => GetArgument<TerraformValue<bool>>("transfer_lock");
        set => SetArgument("transfer_lock", value);
    }

    /// <summary>
    /// The abuse_contact_email attribute.
    /// </summary>
    public TerraformValue<string> AbuseContactEmail
        => AsReference("abuse_contact_email");

    /// <summary>
    /// The abuse_contact_phone attribute.
    /// </summary>
    public TerraformValue<string> AbuseContactPhone
        => AsReference("abuse_contact_phone");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => AsReference("creation_date");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
        => AsReference("expiration_date");

    /// <summary>
    /// The registrar_name attribute.
    /// </summary>
    public TerraformValue<string> RegistrarName
        => AsReference("registrar_name");

    /// <summary>
    /// The registrar_url attribute.
    /// </summary>
    public TerraformValue<string> RegistrarUrl
        => AsReference("registrar_url");

    /// <summary>
    /// The reseller attribute.
    /// </summary>
    public TerraformValue<string> Reseller
        => AsReference("reseller");

    /// <summary>
    /// The status_list attribute.
    /// </summary>
    public TerraformList<string> StatusList
        => AsReference("status_list");

    /// <summary>
    /// The updated_date attribute.
    /// </summary>
    public TerraformValue<string> UpdatedDate
        => AsReference("updated_date");

    /// <summary>
    /// The whois_server attribute.
    /// </summary>
    public TerraformValue<string> WhoisServer
        => AsReference("whois_server");

    /// <summary>
    /// AdminContact block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminContact block(s) allowed")]
    public TerraformList<AwsRoute53domainsRegisteredDomainAdminContactBlock>? AdminContact
    {
        get => GetArgument<TerraformList<AwsRoute53domainsRegisteredDomainAdminContactBlock>>("admin_contact");
        set => SetArgument("admin_contact", value);
    }

    /// <summary>
    /// BillingContact block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BillingContact block(s) allowed")]
    public TerraformList<AwsRoute53domainsRegisteredDomainBillingContactBlock>? BillingContact
    {
        get => GetArgument<TerraformList<AwsRoute53domainsRegisteredDomainBillingContactBlock>>("billing_contact");
        set => SetArgument("billing_contact", value);
    }

    /// <summary>
    /// NameServer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(6, ErrorMessage = "Maximum 6 NameServer block(s) allowed")]
    public TerraformList<AwsRoute53domainsRegisteredDomainNameServerBlock>? NameServer
    {
        get => GetArgument<TerraformList<AwsRoute53domainsRegisteredDomainNameServerBlock>>("name_server");
        set => SetArgument("name_server", value);
    }

    /// <summary>
    /// RegistrantContact block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrantContact block(s) allowed")]
    public TerraformList<AwsRoute53domainsRegisteredDomainRegistrantContactBlock>? RegistrantContact
    {
        get => GetArgument<TerraformList<AwsRoute53domainsRegisteredDomainRegistrantContactBlock>>("registrant_contact");
        set => SetArgument("registrant_contact", value);
    }

    /// <summary>
    /// TechContact block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TechContact block(s) allowed")]
    public TerraformList<AwsRoute53domainsRegisteredDomainTechContactBlock>? TechContact
    {
        get => GetArgument<TerraformList<AwsRoute53domainsRegisteredDomainTechContactBlock>>("tech_contact");
        set => SetArgument("tech_contact", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53domainsRegisteredDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53domainsRegisteredDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
