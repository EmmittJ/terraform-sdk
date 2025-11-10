using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for dynamic_membership in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupDynamicMembershipBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// Rule to determine members for a dynamic group. Required when `group_types` contains &#39;DynamicMembership&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [TerraformPropertyName("rule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Rule { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadGroup : TerraformResource
{
    public AzureadGroup(string name) : base("azuread_group", name)
    {
    }

    /// <summary>
    /// The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.
    /// </summary>
    [TerraformPropertyName("administrative_unit_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AdministrativeUnitIds { get; set; }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    [TerraformPropertyName("assignable_to_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AssignableToRole { get; set; }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    [TerraformPropertyName("auto_subscribe_new_members")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AutoSubscribeNewMembers { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_subscribe_new_members");

    /// <summary>
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("behaviors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Behaviors { get; set; }

    /// <summary>
    /// The description for the group
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display name for the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    [TerraformPropertyName("external_senders_allowed")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ExternalSendersAllowed { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "external_senders_allowed");

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    [TerraformPropertyName("hide_from_address_lists")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> HideFromAddressLists { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "hide_from_address_lists");

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    [TerraformPropertyName("hide_from_outlook_clients")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> HideFromOutlookClients { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "hide_from_outlook_clients");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    [TerraformPropertyName("mail_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MailEnabled { get; set; }

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    [TerraformPropertyName("mail_nickname")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MailNickname { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mail_nickname");

    /// <summary>
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    [TerraformPropertyName("members")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Members { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "members");

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    [TerraformPropertyName("onpremises_group_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OnpremisesGroupType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_group_type");

    /// <summary>
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    [TerraformPropertyName("owners")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Owners { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "owners");

    /// <summary>
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    [TerraformPropertyName("prevent_duplicate_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PreventDuplicateNames { get; set; }

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("provisioning_options")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ProvisioningOptions { get; set; }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    [TerraformPropertyName("security_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SecurityEnabled { get; set; }

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("theme")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Theme { get; set; }

    /// <summary>
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    [TerraformPropertyName("types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Types { get; set; }

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Visibility { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "visibility");

    /// <summary>
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("writeback_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WritebackEnabled { get; set; }

    /// <summary>
    /// Block for dynamic_membership.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicMembership block(s) allowed")]
    [TerraformPropertyName("dynamic_membership")]
    public TerraformList<TerraformBlock<AzureadGroupDynamicMembershipBlock>>? DynamicMembership { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    [TerraformPropertyName("mail")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Mail => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mail");

    /// <summary>
    /// The object ID of the group
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_domain_name");

    /// <summary>
    /// The on-premises NetBIOS name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_netbios_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesNetbiosName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_netbios_name");

    /// <summary>
    /// The on-premises SAM account name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_sam_account_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesSamAccountName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_sam_account_name");

    /// <summary>
    /// The on-premises security identifier (SID), synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_security_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesSecurityIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_security_identifier");

    /// <summary>
    /// Whether this group is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    [TerraformPropertyName("onpremises_sync_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> OnpremisesSyncEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "onpremises_sync_enabled");

    /// <summary>
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredLanguage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_language");

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    [TerraformPropertyName("proxy_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ProxyAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "proxy_addresses");

}
