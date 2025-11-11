using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadGroupDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_group.
/// </summary>
public partial class AzureadGroupDataSource : TerraformDataSource
{
    public AzureadGroupDataSource(string name) : base("azuread_group", name)
    {
    }

    /// <summary>
    /// The display name for the group
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Specifies whether to include transitive members (a flat list of all nested members).
    /// </summary>
    [TerraformProperty("include_transitive_members")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeTransitiveMembers { get; set; }

    /// <summary>
    /// Whether the group is mail-enabled
    /// </summary>
    [TerraformProperty("mail_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> MailEnabled { get; set; }

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    [TerraformProperty("mail_nickname")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MailNickname { get; set; }

    /// <summary>
    /// The object ID of the group
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// Whether the group is a security group
    /// </summary>
    [TerraformProperty("security_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> SecurityEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role
    /// </summary>
    [TerraformProperty("assignable_to_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AssignableToRole { get; }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    [TerraformProperty("auto_subscribe_new_members")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AutoSubscribeNewMembers { get; }

    /// <summary>
    /// The group behaviors for a Microsoft 365 group
    /// </summary>
    [TerraformProperty("behaviors")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Behaviors { get; }

    /// <summary>
    /// The optional description of the group
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// An optional block to configure dynamic membership for the group. Cannot be used with `members`
    /// </summary>
    [TerraformProperty("dynamic_membership")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DynamicMembership { get; }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    [TerraformProperty("external_senders_allowed")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ExternalSendersAllowed { get; }

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    [TerraformProperty("hide_from_address_lists")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> HideFromAddressLists { get; }

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    [TerraformProperty("hide_from_outlook_clients")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> HideFromOutlookClients { get; }

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    [TerraformProperty("mail")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Mail { get; }

    /// <summary>
    /// The object IDs of the group members
    /// </summary>
    [TerraformProperty("members")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Members { get; }

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("onpremises_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OnpremisesDomainName { get; }

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    [TerraformProperty("onpremises_group_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OnpremisesGroupType { get; }

    /// <summary>
    /// The on-premises NetBIOS name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("onpremises_netbios_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OnpremisesNetbiosName { get; }

    /// <summary>
    /// The on-premises SAM account name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("onpremises_sam_account_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OnpremisesSamAccountName { get; }

    /// <summary>
    /// The on-premises security identifier (SID), synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("onpremises_security_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OnpremisesSecurityIdentifier { get; }

    /// <summary>
    /// Whether this group is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    [TerraformProperty("onpremises_sync_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> OnpremisesSyncEnabled { get; }

    /// <summary>
    /// The object IDs of the group owners
    /// </summary>
    [TerraformProperty("owners")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Owners { get; }

    /// <summary>
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    [TerraformProperty("preferred_language")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreferredLanguage { get; }

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    [TerraformProperty("provisioning_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ProvisioningOptions { get; }

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    [TerraformProperty("proxy_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ProxyAddresses { get; }

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    [TerraformProperty("theme")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Theme { get; }

    /// <summary>
    /// A list of group types configured for the group. The only supported type is `Unified`, which specifies a Microsoft 365 group
    /// </summary>
    [TerraformProperty("types")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Types { get; }

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    [TerraformProperty("visibility")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Visibility { get; }

    /// <summary>
    /// Whether this group is synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("writeback_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> WritebackEnabled { get; }

}
