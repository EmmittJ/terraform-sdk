using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Specifies whether to include transitive members (a flat list of all nested members).
    /// </summary>
    [TerraformPropertyName("include_transitive_members")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeTransitiveMembers { get; set; }

    /// <summary>
    /// Whether the group is mail-enabled
    /// </summary>
    [TerraformPropertyName("mail_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> MailEnabled { get; set; } = default!;

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    [TerraformPropertyName("mail_nickname")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MailNickname { get; set; } = default!;

    /// <summary>
    /// The object ID of the group
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectId { get; set; } = default!;

    /// <summary>
    /// Whether the group is a security group
    /// </summary>
    [TerraformPropertyName("security_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SecurityEnabled { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role
    /// </summary>
    [TerraformPropertyName("assignable_to_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AssignableToRole => new TerraformReference(this, "assignable_to_role");

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    [TerraformPropertyName("auto_subscribe_new_members")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoSubscribeNewMembers => new TerraformReference(this, "auto_subscribe_new_members");

    /// <summary>
    /// The group behaviors for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("behaviors")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Behaviors => new TerraformReference(this, "behaviors");

    /// <summary>
    /// The optional description of the group
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// An optional block to configure dynamic membership for the group. Cannot be used with `members`
    /// </summary>
    [TerraformPropertyName("dynamic_membership")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DynamicMembership => new TerraformReference(this, "dynamic_membership");

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    [TerraformPropertyName("external_senders_allowed")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExternalSendersAllowed => new TerraformReference(this, "external_senders_allowed");

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    [TerraformPropertyName("hide_from_address_lists")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HideFromAddressLists => new TerraformReference(this, "hide_from_address_lists");

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    [TerraformPropertyName("hide_from_outlook_clients")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HideFromOutlookClients => new TerraformReference(this, "hide_from_outlook_clients");

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    [TerraformPropertyName("mail")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Mail => new TerraformReference(this, "mail");

    /// <summary>
    /// The object IDs of the group members
    /// </summary>
    [TerraformPropertyName("members")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Members => new TerraformReference(this, "members");

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesDomainName => new TerraformReference(this, "onpremises_domain_name");

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    [TerraformPropertyName("onpremises_group_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesGroupType => new TerraformReference(this, "onpremises_group_type");

    /// <summary>
    /// The on-premises NetBIOS name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_netbios_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesNetbiosName => new TerraformReference(this, "onpremises_netbios_name");

    /// <summary>
    /// The on-premises SAM account name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_sam_account_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesSamAccountName => new TerraformReference(this, "onpremises_sam_account_name");

    /// <summary>
    /// The on-premises security identifier (SID), synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_security_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesSecurityIdentifier => new TerraformReference(this, "onpremises_security_identifier");

    /// <summary>
    /// Whether this group is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    [TerraformPropertyName("onpremises_sync_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> OnpremisesSyncEnabled => new TerraformReference(this, "onpremises_sync_enabled");

    /// <summary>
    /// The object IDs of the group owners
    /// </summary>
    [TerraformPropertyName("owners")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Owners => new TerraformReference(this, "owners");

    /// <summary>
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredLanguage => new TerraformReference(this, "preferred_language");

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("provisioning_options")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ProvisioningOptions => new TerraformReference(this, "provisioning_options");

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    [TerraformPropertyName("proxy_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ProxyAddresses => new TerraformReference(this, "proxy_addresses");

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("theme")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Theme => new TerraformReference(this, "theme");

    /// <summary>
    /// A list of group types configured for the group. The only supported type is `Unified`, which specifies a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("types")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Types => new TerraformReference(this, "types");

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Visibility => new TerraformReference(this, "visibility");

    /// <summary>
    /// Whether this group is synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("writeback_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> WritebackEnabled => new TerraformReference(this, "writeback_enabled");

}
