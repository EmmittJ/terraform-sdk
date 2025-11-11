using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for dynamic_membership in .
/// Nesting mode: list
/// </summary>
public partial class AzureadGroupWithoutMembersDynamicMembershipBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Rule to determine members for a dynamic group. Required when `group_types` contains &#39;DynamicMembership&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [TerraformProperty("rule")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Rule { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadGroupWithoutMembersTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_group_without_members resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzureadGroupWithoutMembers : TerraformResource
{
    public AzureadGroupWithoutMembers(string name) : base("azuread_group_without_members", name)
    {
    }

    /// <summary>
    /// The administrative unit IDs in which the group should be. If empty, the group will be created at the tenant level.
    /// </summary>
    [TerraformProperty("administrative_unit_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AdministrativeUnitIds { get; set; }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    [TerraformProperty("assignable_to_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AssignableToRole { get; set; }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    [TerraformProperty("auto_subscribe_new_members")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AutoSubscribeNewMembers { get; set; }

    /// <summary>
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    [TerraformProperty("behaviors")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Behaviors { get; set; }

    /// <summary>
    /// The description for the group
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name for the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    [TerraformProperty("external_senders_allowed")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ExternalSendersAllowed { get; set; }

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    [TerraformProperty("hide_from_address_lists")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> HideFromAddressLists { get; set; }

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    [TerraformProperty("hide_from_outlook_clients")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> HideFromOutlookClients { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    [TerraformProperty("mail_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MailEnabled { get; set; }

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    [TerraformProperty("mail_nickname")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MailNickname { get; set; }

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    [TerraformProperty("onpremises_group_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OnpremisesGroupType { get; set; }

    /// <summary>
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    [TerraformProperty("owners")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Owners { get; set; }

    /// <summary>
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    [TerraformProperty("prevent_duplicate_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PreventDuplicateNames { get; set; }

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    [TerraformProperty("provisioning_options")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ProvisioningOptions { get; set; }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    [TerraformProperty("security_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SecurityEnabled { get; set; }

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    [TerraformProperty("theme")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Theme { get; set; }

    /// <summary>
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    [TerraformProperty("types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Types { get; set; }

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    [TerraformProperty("visibility")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Visibility { get; set; }

    /// <summary>
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("writeback_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WritebackEnabled { get; set; }

    /// <summary>
    /// Block for dynamic_membership.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicMembership block(s) allowed")]
    [TerraformProperty("dynamic_membership")]
    public partial TerraformList<TerraformBlock<AzureadGroupWithoutMembersDynamicMembershipBlock>>? DynamicMembership { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadGroupWithoutMembersTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    [TerraformProperty("mail")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Mail { get; }

    /// <summary>
    /// The object ID of the group
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ObjectId { get; }

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("onpremises_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesDomainName { get; }

    /// <summary>
    /// The on-premises NetBIOS name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("onpremises_netbios_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesNetbiosName { get; }

    /// <summary>
    /// The on-premises SAM account name, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("onpremises_sam_account_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesSamAccountName { get; }

    /// <summary>
    /// The on-premises security identifier (SID), synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformProperty("onpremises_security_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OnpremisesSecurityIdentifier { get; }

    /// <summary>
    /// Whether this group is synchronized from an on-premises directory (true), no longer synchronized (false), or has never been synchronized (null)
    /// </summary>
    [TerraformProperty("onpremises_sync_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> OnpremisesSyncEnabled { get; }

    /// <summary>
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    [TerraformProperty("preferred_language")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreferredLanguage { get; }

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    [TerraformProperty("proxy_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ProxyAddresses { get; }

}
