using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for contact_settings in GoogleClouddomainsRegistration.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationContactSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "contact_settings";

    /// <summary>
    /// Required. Privacy setting for the contacts associated with the Registration.
    /// Values are PUBLIC_CONTACT_DATA, PRIVATE_CONTACT_DATA, and REDACTED_CONTACT_DATA
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Privacy is required")]
    public required TerraformValue<string> Privacy
    {
        get => GetRequiredArgument<TerraformValue<string>>("privacy");
        set => SetArgument("privacy", value);
    }

    /// <summary>
    /// AdminContact block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminContact is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AdminContact block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminContact block(s) allowed")]
    public required TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockAdminContactBlock> AdminContact
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockAdminContactBlock>>("admin_contact");
        set => SetArgument("admin_contact", value);
    }

    /// <summary>
    /// RegistrantContact block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistrantContact is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RegistrantContact block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RegistrantContact block(s) allowed")]
    public required TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockRegistrantContactBlock> RegistrantContact
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockRegistrantContactBlock>>("registrant_contact");
        set => SetArgument("registrant_contact", value);
    }

    /// <summary>
    /// TechnicalContact block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TechnicalContact is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TechnicalContact block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TechnicalContact block(s) allowed")]
    public required TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockTechnicalContactBlock> TechnicalContact
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockTechnicalContactBlock>>("technical_contact");
        set => SetArgument("technical_contact", value);
    }

}

/// <summary>
/// Block type for admin_contact in GoogleClouddomainsRegistrationContactSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationContactSettingsBlockAdminContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_contact";

    /// <summary>
    /// Required. Email address of the contact.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// Fax number of the contact in international format. For example, &amp;quot;+1-800-555-0123&amp;quot;.
    /// </summary>
    public TerraformValue<string>? FaxNumber
    {
        get => GetArgument<TerraformValue<string>>("fax_number");
        set => SetArgument("fax_number", value);
    }

    /// <summary>
    /// Required. Phone number of the contact in international format. For example, &amp;quot;+1-800-555-0123&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// PostalAddress block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostalAddress is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PostalAddress block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostalAddress block(s) allowed")]
    public required TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockAdminContactBlockPostalAddressBlock> PostalAddress
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockAdminContactBlockPostalAddressBlock>>("postal_address");
        set => SetArgument("postal_address", value);
    }

}

/// <summary>
/// Block type for postal_address in GoogleClouddomainsRegistrationContactSettingsBlockAdminContactBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationContactSettingsBlockAdminContactBlockPostalAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postal_address";

    /// <summary>
    /// Unstructured address lines describing the lower levels of an address.
    /// Because values in addressLines do not have type information and may sometimes contain multiple values in a single
    /// field (e.g. &amp;quot;Austin, TX&amp;quot;), it is important that the line order is clear. The order of address lines should be
    /// &amp;quot;envelope order&amp;quot; for the country/region of the address. In places where this can vary (e.g. Japan), address_language
    /// is used to make it explicit (e.g. &amp;quot;ja&amp;quot; for large-to-small ordering and &amp;quot;ja-Latn&amp;quot; or &amp;quot;en&amp;quot; for small-to-large). This way,
    /// the most specific line of an address can be selected based on the language.
    /// </summary>
    public TerraformList<string>? AddressLines
    {
        get => GetArgument<TerraformList<string>>("address_lines");
        set => SetArgument("address_lines", value);
    }

    /// <summary>
    /// Highest administrative subdivision which is used for postal addresses of a country or region. For example, this can be a state,
    /// a province, an oblast, or a prefecture. Specifically, for Spain this is the province and not the autonomous community
    /// (e.g. &amp;quot;Barcelona&amp;quot; and not &amp;quot;Catalonia&amp;quot;). Many countries don&#39;t use an administrative area in postal addresses. E.g. in Switzerland
    /// this should be left unpopulated.
    /// </summary>
    public TerraformValue<string>? AdministrativeArea
    {
        get => GetArgument<TerraformValue<string>>("administrative_area");
        set => SetArgument("administrative_area", value);
    }

    /// <summary>
    /// Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post town. In regions of the world
    /// where localities are not well defined or do not fit into this structure well, leave locality empty and use addressLines.
    /// </summary>
    public TerraformValue<string>? Locality
    {
        get => GetArgument<TerraformValue<string>>("locality");
        set => SetArgument("locality", value);
    }

    /// <summary>
    /// The name of the organization at the address.
    /// </summary>
    public TerraformValue<string>? Organization
    {
        get => GetArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// Postal code of the address. Not all countries use or require postal codes to be present, but where they are used,
    /// they may trigger additional validation with other parts of the address (e.g. state/zip validation in the U.S.A.).
    /// </summary>
    public TerraformValue<string>? PostalCode
    {
        get => GetArgument<TerraformValue<string>>("postal_code");
        set => SetArgument("postal_code", value);
    }

    /// <summary>
    /// The recipient at the address. This field may, under certain circumstances, contain multiline information. For example,
    /// it might contain &amp;quot;care of&amp;quot; information.
    /// </summary>
    public TerraformList<string>? Recipients
    {
        get => GetArgument<TerraformList<string>>("recipients");
        set => SetArgument("recipients", value);
    }

    /// <summary>
    /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the user to
    /// ensure the value is correct. See https://cldr.unicode.org/ and
    /// https://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: &amp;quot;CH&amp;quot; for Switzerland.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionCode is required")]
    public required TerraformValue<string> RegionCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("region_code");
        set => SetArgument("region_code", value);
    }

}

/// <summary>
/// Block type for registrant_contact in GoogleClouddomainsRegistrationContactSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationContactSettingsBlockRegistrantContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registrant_contact";

    /// <summary>
    /// Required. Email address of the contact.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// Fax number of the contact in international format. For example, &amp;quot;+1-800-555-0123&amp;quot;.
    /// </summary>
    public TerraformValue<string>? FaxNumber
    {
        get => GetArgument<TerraformValue<string>>("fax_number");
        set => SetArgument("fax_number", value);
    }

    /// <summary>
    /// Required. Phone number of the contact in international format. For example, &amp;quot;+1-800-555-0123&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// PostalAddress block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostalAddress is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PostalAddress block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostalAddress block(s) allowed")]
    public required TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockRegistrantContactBlockPostalAddressBlock> PostalAddress
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockRegistrantContactBlockPostalAddressBlock>>("postal_address");
        set => SetArgument("postal_address", value);
    }

}

/// <summary>
/// Block type for postal_address in GoogleClouddomainsRegistrationContactSettingsBlockRegistrantContactBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationContactSettingsBlockRegistrantContactBlockPostalAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postal_address";

    /// <summary>
    /// Unstructured address lines describing the lower levels of an address.
    /// Because values in addressLines do not have type information and may sometimes contain multiple values in a single
    /// field (e.g. &amp;quot;Austin, TX&amp;quot;), it is important that the line order is clear. The order of address lines should be
    /// &amp;quot;envelope order&amp;quot; for the country/region of the address. In places where this can vary (e.g. Japan), address_language
    /// is used to make it explicit (e.g. &amp;quot;ja&amp;quot; for large-to-small ordering and &amp;quot;ja-Latn&amp;quot; or &amp;quot;en&amp;quot; for small-to-large). This way,
    /// the most specific line of an address can be selected based on the language.
    /// </summary>
    public TerraformList<string>? AddressLines
    {
        get => GetArgument<TerraformList<string>>("address_lines");
        set => SetArgument("address_lines", value);
    }

    /// <summary>
    /// Highest administrative subdivision which is used for postal addresses of a country or region. For example, this can be a state,
    /// a province, an oblast, or a prefecture. Specifically, for Spain this is the province and not the autonomous community
    /// (e.g. &amp;quot;Barcelona&amp;quot; and not &amp;quot;Catalonia&amp;quot;). Many countries don&#39;t use an administrative area in postal addresses. E.g. in Switzerland
    /// this should be left unpopulated.
    /// </summary>
    public TerraformValue<string>? AdministrativeArea
    {
        get => GetArgument<TerraformValue<string>>("administrative_area");
        set => SetArgument("administrative_area", value);
    }

    /// <summary>
    /// Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post town. In regions of the world
    /// where localities are not well defined or do not fit into this structure well, leave locality empty and use addressLines.
    /// </summary>
    public TerraformValue<string>? Locality
    {
        get => GetArgument<TerraformValue<string>>("locality");
        set => SetArgument("locality", value);
    }

    /// <summary>
    /// The name of the organization at the address.
    /// </summary>
    public TerraformValue<string>? Organization
    {
        get => GetArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// Postal code of the address. Not all countries use or require postal codes to be present, but where they are used,
    /// they may trigger additional validation with other parts of the address (e.g. state/zip validation in the U.S.A.).
    /// </summary>
    public TerraformValue<string>? PostalCode
    {
        get => GetArgument<TerraformValue<string>>("postal_code");
        set => SetArgument("postal_code", value);
    }

    /// <summary>
    /// The recipient at the address. This field may, under certain circumstances, contain multiline information. For example,
    /// it might contain &amp;quot;care of&amp;quot; information.
    /// </summary>
    public TerraformList<string>? Recipients
    {
        get => GetArgument<TerraformList<string>>("recipients");
        set => SetArgument("recipients", value);
    }

    /// <summary>
    /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the user to
    /// ensure the value is correct. See https://cldr.unicode.org/ and
    /// https://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: &amp;quot;CH&amp;quot; for Switzerland.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionCode is required")]
    public required TerraformValue<string> RegionCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("region_code");
        set => SetArgument("region_code", value);
    }

}

/// <summary>
/// Block type for technical_contact in GoogleClouddomainsRegistrationContactSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationContactSettingsBlockTechnicalContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "technical_contact";

    /// <summary>
    /// Required. Email address of the contact.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// Fax number of the contact in international format. For example, &amp;quot;+1-800-555-0123&amp;quot;.
    /// </summary>
    public TerraformValue<string>? FaxNumber
    {
        get => GetArgument<TerraformValue<string>>("fax_number");
        set => SetArgument("fax_number", value);
    }

    /// <summary>
    /// Required. Phone number of the contact in international format. For example, &amp;quot;+1-800-555-0123&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

    /// <summary>
    /// PostalAddress block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostalAddress is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PostalAddress block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostalAddress block(s) allowed")]
    public required TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockTechnicalContactBlockPostalAddressBlock> PostalAddress
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddomainsRegistrationContactSettingsBlockTechnicalContactBlockPostalAddressBlock>>("postal_address");
        set => SetArgument("postal_address", value);
    }

}

/// <summary>
/// Block type for postal_address in GoogleClouddomainsRegistrationContactSettingsBlockTechnicalContactBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationContactSettingsBlockTechnicalContactBlockPostalAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "postal_address";

    /// <summary>
    /// Unstructured address lines describing the lower levels of an address.
    /// Because values in addressLines do not have type information and may sometimes contain multiple values in a single
    /// field (e.g. &amp;quot;Austin, TX&amp;quot;), it is important that the line order is clear. The order of address lines should be
    /// &amp;quot;envelope order&amp;quot; for the country/region of the address. In places where this can vary (e.g. Japan), address_language
    /// is used to make it explicit (e.g. &amp;quot;ja&amp;quot; for large-to-small ordering and &amp;quot;ja-Latn&amp;quot; or &amp;quot;en&amp;quot; for small-to-large). This way,
    /// the most specific line of an address can be selected based on the language.
    /// </summary>
    public TerraformList<string>? AddressLines
    {
        get => GetArgument<TerraformList<string>>("address_lines");
        set => SetArgument("address_lines", value);
    }

    /// <summary>
    /// Highest administrative subdivision which is used for postal addresses of a country or region. For example, this can be a state,
    /// a province, an oblast, or a prefecture. Specifically, for Spain this is the province and not the autonomous community
    /// (e.g. &amp;quot;Barcelona&amp;quot; and not &amp;quot;Catalonia&amp;quot;). Many countries don&#39;t use an administrative area in postal addresses. E.g. in Switzerland
    /// this should be left unpopulated.
    /// </summary>
    public TerraformValue<string>? AdministrativeArea
    {
        get => GetArgument<TerraformValue<string>>("administrative_area");
        set => SetArgument("administrative_area", value);
    }

    /// <summary>
    /// Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post town. In regions of the world
    /// where localities are not well defined or do not fit into this structure well, leave locality empty and use addressLines.
    /// </summary>
    public TerraformValue<string>? Locality
    {
        get => GetArgument<TerraformValue<string>>("locality");
        set => SetArgument("locality", value);
    }

    /// <summary>
    /// The name of the organization at the address.
    /// </summary>
    public TerraformValue<string>? Organization
    {
        get => GetArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// Postal code of the address. Not all countries use or require postal codes to be present, but where they are used,
    /// they may trigger additional validation with other parts of the address (e.g. state/zip validation in the U.S.A.).
    /// </summary>
    public TerraformValue<string>? PostalCode
    {
        get => GetArgument<TerraformValue<string>>("postal_code");
        set => SetArgument("postal_code", value);
    }

    /// <summary>
    /// The recipient at the address. This field may, under certain circumstances, contain multiline information. For example,
    /// it might contain &amp;quot;care of&amp;quot; information.
    /// </summary>
    public TerraformList<string>? Recipients
    {
        get => GetArgument<TerraformList<string>>("recipients");
        set => SetArgument("recipients", value);
    }

    /// <summary>
    /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the user to
    /// ensure the value is correct. See https://cldr.unicode.org/ and
    /// https://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: &amp;quot;CH&amp;quot; for Switzerland.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionCode is required")]
    public required TerraformValue<string> RegionCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("region_code");
        set => SetArgument("region_code", value);
    }

}


/// <summary>
/// Block type for dns_settings in GoogleClouddomainsRegistration.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationDnsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_settings";

    /// <summary>
    /// CustomDns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDns block(s) allowed")]
    public TerraformList<GoogleClouddomainsRegistrationDnsSettingsBlockCustomDnsBlock>? CustomDns
    {
        get => GetArgument<TerraformList<GoogleClouddomainsRegistrationDnsSettingsBlockCustomDnsBlock>>("custom_dns");
        set => SetArgument("custom_dns", value);
    }

    /// <summary>
    /// GlueRecords block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddomainsRegistrationDnsSettingsBlockGlueRecordsBlock>? GlueRecords
    {
        get => GetArgument<TerraformList<GoogleClouddomainsRegistrationDnsSettingsBlockGlueRecordsBlock>>("glue_records");
        set => SetArgument("glue_records", value);
    }

}

/// <summary>
/// Block type for custom_dns in GoogleClouddomainsRegistrationDnsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationDnsSettingsBlockCustomDnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_dns";

    /// <summary>
    /// Required. A list of name servers that store the DNS zone for this domain. Each name server is a domain
    /// name, with Unicode domain names expressed in Punycode format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NameServers is required")]
    public TerraformList<string>? NameServers
    {
        get => GetArgument<TerraformList<string>>("name_servers");
        set => SetArgument("name_servers", value);
    }

    /// <summary>
    /// DsRecords block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddomainsRegistrationDnsSettingsBlockCustomDnsBlockDsRecordsBlock>? DsRecords
    {
        get => GetArgument<TerraformList<GoogleClouddomainsRegistrationDnsSettingsBlockCustomDnsBlockDsRecordsBlock>>("ds_records");
        set => SetArgument("ds_records", value);
    }

}

/// <summary>
/// Block type for ds_records in GoogleClouddomainsRegistrationDnsSettingsBlockCustomDnsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationDnsSettingsBlockCustomDnsBlockDsRecordsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ds_records";

    /// <summary>
    /// The algorithm used to generate the referenced DNSKEY.
    /// </summary>
    public TerraformValue<string>? Algorithm
    {
        get => GetArgument<TerraformValue<string>>("algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The digest generated from the referenced DNSKEY.
    /// </summary>
    public TerraformValue<string>? Digest
    {
        get => GetArgument<TerraformValue<string>>("digest");
        set => SetArgument("digest", value);
    }

    /// <summary>
    /// The hash function used to generate the digest of the referenced DNSKEY.
    /// </summary>
    public TerraformValue<string>? DigestType
    {
        get => GetArgument<TerraformValue<string>>("digest_type");
        set => SetArgument("digest_type", value);
    }

    /// <summary>
    /// The key tag of the record. Must be set in range 0 -- 65535.
    /// </summary>
    public TerraformValue<double>? KeyTag
    {
        get => GetArgument<TerraformValue<double>>("key_tag");
        set => SetArgument("key_tag", value);
    }

}

/// <summary>
/// Block type for glue_records in GoogleClouddomainsRegistrationDnsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationDnsSettingsBlockGlueRecordsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "glue_records";

    /// <summary>
    /// Required. Domain name of the host in Punycode format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// List of IPv4 addresses corresponding to this host in the standard decimal format (e.g. 198.51.100.1).
    /// At least one of ipv4_address and ipv6_address must be set.
    /// </summary>
    public TerraformList<string>? Ipv4Addresses
    {
        get => GetArgument<TerraformList<string>>("ipv4_addresses");
        set => SetArgument("ipv4_addresses", value);
    }

    /// <summary>
    /// List of IPv4 addresses corresponding to this host in the standard decimal format (e.g. 198.51.100.1).
    /// At least one of ipv4_address and ipv6_address must be set.
    /// </summary>
    public TerraformList<string>? Ipv6Addresses
    {
        get => GetArgument<TerraformList<string>>("ipv6_addresses");
        set => SetArgument("ipv6_addresses", value);
    }

}


/// <summary>
/// Block type for management_settings in GoogleClouddomainsRegistration.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationManagementSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management_settings";

    /// <summary>
    /// The desired renewal method for this Registration. The actual renewalMethod is automatically updated to reflect this choice.
    /// If unset or equal to RENEWAL_METHOD_UNSPECIFIED, the actual renewalMethod is treated as if it were set to AUTOMATIC_RENEWAL.
    /// You cannot use RENEWAL_DISABLED during resource creation, and you can update the renewal status only when the Registration
    /// resource has state ACTIVE or SUSPENDED.
    /// 
    /// When preferredRenewalMethod is set to AUTOMATIC_RENEWAL, the actual renewalMethod can be set to RENEWAL_DISABLED in case of
    /// problems with the billing account or reported domain abuse. In such cases, check the issues field on the Registration. After
    /// the problem is resolved, the renewalMethod is automatically updated to preferredRenewalMethod in a few hours.
    /// </summary>
    public TerraformValue<string> PreferredRenewalMethod
    {
        get => GetArgument<TerraformValue<string>>("preferred_renewal_method") ?? CreateReference("preferred_renewal_method");
        set => SetArgument("preferred_renewal_method", value);
    }

    /// <summary>
    /// Output only. The actual renewal method for this Registration. When preferredRenewalMethod is set to AUTOMATIC_RENEWAL,
    /// the actual renewalMethod can be equal to RENEWAL_DISABLED—for example, when there are problems with the billing account
    /// or reported domain abuse. In such cases, check the issues field on the Registration. After the problem is resolved, the
    /// renewalMethod is automatically updated to preferredRenewalMethod in a few hours.
    /// </summary>
    public TerraformValue<string> RenewalMethod
        => CreateReference("renewal_method");

    /// <summary>
    /// Controls whether the domain can be transferred to another registrar. Values are UNLOCKED or LOCKED.
    /// </summary>
    public TerraformValue<string> TransferLockState
    {
        get => GetArgument<TerraformValue<string>>("transfer_lock_state") ?? CreateReference("transfer_lock_state");
        set => SetArgument("transfer_lock_state", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleClouddomainsRegistration.
/// Nesting mode: single
/// </summary>
public class GoogleClouddomainsRegistrationTimeoutsBlock : TerraformBlock
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
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
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
/// Block type for yearly_price in GoogleClouddomainsRegistration.
/// Nesting mode: list
/// </summary>
public class GoogleClouddomainsRegistrationYearlyPriceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "yearly_price";

    /// <summary>
    /// The three-letter currency code defined in ISO 4217.
    /// </summary>
    public TerraformValue<string>? CurrencyCode
    {
        get => GetArgument<TerraformValue<string>>("currency_code");
        set => SetArgument("currency_code", value);
    }

    /// <summary>
    /// The whole units of the amount. For example if currencyCode is &amp;quot;USD&amp;quot;, then 1 unit is one US dollar.
    /// </summary>
    public TerraformValue<string>? Units
    {
        get => GetArgument<TerraformValue<string>>("units");
        set => SetArgument("units", value);
    }

}


/// <summary>
/// Represents a google_clouddomains_registration Terraform resource.
/// Manages a google_clouddomains_registration resource.
/// </summary>
public partial class GoogleClouddomainsRegistration(string name) : TerraformResource("google_clouddomains_registration", name)
{
    /// <summary>
    /// The list of contact notices that the caller acknowledges. Possible value is PUBLIC_CONTACT_DATA_ACKNOWLEDGEMENT
    /// </summary>
    public TerraformList<string>? ContactNotices
    {
        get => GetArgument<TerraformList<string>>("contact_notices");
        set => SetArgument("contact_notices", value);
    }

    /// <summary>
    /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The list of domain notices that you acknowledge. Possible value is HSTS_PRELOADED
    /// </summary>
    public TerraformList<string>? DomainNotices
    {
        get => GetArgument<TerraformList<string>>("domain_notices");
        set => SetArgument("domain_notices", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Set of labels associated with the Registration.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. Time at which the automation was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Output only. Time at which the automation was updated.
    /// </summary>
    public TerraformValue<string> ExpireTime
        => CreateReference("expire_time");

    /// <summary>
    /// Output only. The set of issues with the Registration that require attention.
    /// </summary>
    public TerraformList<string> Issues
        => CreateReference("issues");

    /// <summary>
    /// Output only. Name of the Registration resource, in the format projects/*/locations/*/registrations/&amp;lt;domain_name&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Output only. The reason the domain registration failed. Only set for domains in REGISTRATION_FAILED state.
    /// </summary>
    public TerraformValue<string> RegisterFailureReason
        => CreateReference("register_failure_reason");

    /// <summary>
    /// Output only. The current state of the Registration.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Output only. Set of options for the contactSettings.privacy field that this Registration supports.
    /// </summary>
    public TerraformList<string> SupportedPrivacy
        => CreateReference("supported_privacy");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// ContactSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContactSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContactSettings block(s) allowed")]
    public required TerraformList<GoogleClouddomainsRegistrationContactSettingsBlock> ContactSettings
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddomainsRegistrationContactSettingsBlock>>("contact_settings");
        set => SetArgument("contact_settings", value);
    }

    /// <summary>
    /// DnsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    public TerraformList<GoogleClouddomainsRegistrationDnsSettingsBlock>? DnsSettings
    {
        get => GetArgument<TerraformList<GoogleClouddomainsRegistrationDnsSettingsBlock>>("dns_settings");
        set => SetArgument("dns_settings", value);
    }

    /// <summary>
    /// ManagementSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementSettings block(s) allowed")]
    public TerraformList<GoogleClouddomainsRegistrationManagementSettingsBlock>? ManagementSettings
    {
        get => GetArgument<TerraformList<GoogleClouddomainsRegistrationManagementSettingsBlock>>("management_settings");
        set => SetArgument("management_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleClouddomainsRegistrationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleClouddomainsRegistrationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// YearlyPrice block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "YearlyPrice is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 YearlyPrice block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 YearlyPrice block(s) allowed")]
    public required TerraformList<GoogleClouddomainsRegistrationYearlyPriceBlock> YearlyPrice
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddomainsRegistrationYearlyPriceBlock>>("yearly_price");
        set => SetArgument("yearly_price", value);
    }

}
