using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_group.
/// </summary>
public class AzureadGroupDataSource : TerraformDataSource
{
    public AzureadGroupDataSource(string name) : base("azuread_group", name)
    {
    }

    /// <summary>
    /// The display name for the group
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Specifies whether to include transitive members (a flat list of all nested members).
    /// </summary>
    [TerraformPropertyName("include_transitive_members")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeTransitiveMembers { get; set; }

    /// <summary>
    /// Whether the group is mail-enabled
    /// </summary>
    [TerraformPropertyName("mail_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> MailEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "mail_enabled");

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    [TerraformPropertyName("mail_nickname")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MailNickname { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mail_nickname");

    /// <summary>
    /// The object ID of the group
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ObjectId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

    /// <summary>
    /// Whether the group is a security group
    /// </summary>
    [TerraformPropertyName("security_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SecurityEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "security_enabled");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadGroupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role
    /// </summary>
    [TerraformPropertyName("assignable_to_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AssignableToRole => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "assignable_to_role");

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    [TerraformPropertyName("auto_subscribe_new_members")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoSubscribeNewMembers => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_subscribe_new_members");

    /// <summary>
    /// The group behaviors for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("behaviors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Behaviors => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "behaviors");

    /// <summary>
    /// The optional description of the group
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// An optional block to configure dynamic membership for the group. Cannot be used with `members`
    /// </summary>
    [TerraformPropertyName("dynamic_membership")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DynamicMembership => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dynamic_membership");

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    [TerraformPropertyName("external_senders_allowed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExternalSendersAllowed => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "external_senders_allowed");

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    [TerraformPropertyName("hide_from_address_lists")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HideFromAddressLists => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "hide_from_address_lists");

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    [TerraformPropertyName("hide_from_outlook_clients")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HideFromOutlookClients => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "hide_from_outlook_clients");

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    [TerraformPropertyName("mail")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Mail => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mail");

    /// <summary>
    /// The object IDs of the group members
    /// </summary>
    [TerraformPropertyName("members")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Members => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "members");

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_domain_name");

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    [TerraformPropertyName("onpremises_group_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OnpremisesGroupType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "onpremises_group_type");

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
    /// The object IDs of the group owners
    /// </summary>
    [TerraformPropertyName("owners")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Owners => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "owners");

    /// <summary>
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredLanguage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_language");

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("provisioning_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ProvisioningOptions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "provisioning_options");

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    [TerraformPropertyName("proxy_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ProxyAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "proxy_addresses");

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("theme")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Theme => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "theme");

    /// <summary>
    /// A list of group types configured for the group. The only supported type is `Unified`, which specifies a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Types => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "types");

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Visibility => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "visibility");

    /// <summary>
    /// Whether this group is synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("writeback_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> WritebackEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "writeback_enabled");

}
