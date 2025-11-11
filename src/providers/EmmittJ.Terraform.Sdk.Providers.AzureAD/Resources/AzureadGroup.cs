using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for dynamic_membership in .
/// Nesting mode: list
/// </summary>
public class AzureadGroupDynamicMembershipBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Rule to determine members for a dynamic group. Required when `group_types` contains &#39;DynamicMembership&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [TerraformPropertyName("rule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Rule { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    public TerraformSet<string>? AdministrativeUnitIds { get; set; }

    /// <summary>
    /// Indicates whether this group can be assigned to an Azure Active Directory role. This property can only be `true` for security-enabled groups.
    /// </summary>
    [TerraformPropertyName("assignable_to_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AssignableToRole { get; set; }

    /// <summary>
    /// Indicates whether new members added to the group will be auto-subscribed to receive email notifications.
    /// </summary>
    [TerraformPropertyName("auto_subscribe_new_members")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AutoSubscribeNewMembers { get; set; } = default!;

    /// <summary>
    /// The group behaviours for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("behaviors")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Behaviors { get; set; }

    /// <summary>
    /// The description for the group
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name for the group
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Indicates whether people external to the organization can send messages to the group.
    /// </summary>
    [TerraformPropertyName("external_senders_allowed")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ExternalSendersAllowed { get; set; } = default!;

    /// <summary>
    /// Indicates whether the group is displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups.
    /// </summary>
    [TerraformPropertyName("hide_from_address_lists")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> HideFromAddressLists { get; set; } = default!;

    /// <summary>
    /// Indicates whether the group is displayed in Outlook clients, such as Outlook for Windows and Outlook on the web.
    /// </summary>
    [TerraformPropertyName("hide_from_outlook_clients")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> HideFromOutlookClients { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Whether the group is a mail enabled, with a shared group mailbox. At least one of `mail_enabled` or `security_enabled` must be specified. A group can be mail enabled _and_ security enabled
    /// </summary>
    [TerraformPropertyName("mail_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MailEnabled { get; set; }

    /// <summary>
    /// The mail alias for the group, unique in the organisation
    /// </summary>
    [TerraformPropertyName("mail_nickname")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MailNickname { get; set; } = default!;

    /// <summary>
    /// A set of members who should be present in this group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    [TerraformPropertyName("members")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Members { get; set; } = default!;

    /// <summary>
    /// Indicates the target on-premise group type the group will be written back as
    /// </summary>
    [TerraformPropertyName("onpremises_group_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OnpremisesGroupType { get; set; } = default!;

    /// <summary>
    /// A set of owners who own this group. Supported object types are Users or Service Principals
    /// </summary>
    [TerraformPropertyName("owners")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Owners { get; set; } = default!;

    /// <summary>
    /// If `true`, will return an error if an existing group is found with the same name
    /// </summary>
    [TerraformPropertyName("prevent_duplicate_names")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PreventDuplicateNames { get; set; }

    /// <summary>
    /// The group provisioning options for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("provisioning_options")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ProvisioningOptions { get; set; }

    /// <summary>
    /// Whether the group is a security group for controlling access to in-app resources. At least one of `security_enabled` or `mail_enabled` must be specified. A group can be security enabled _and_ mail enabled
    /// </summary>
    [TerraformPropertyName("security_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SecurityEnabled { get; set; }

    /// <summary>
    /// The colour theme for a Microsoft 365 group
    /// </summary>
    [TerraformPropertyName("theme")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Theme { get; set; }

    /// <summary>
    /// A set of group types to configure for the group. `Unified` specifies a Microsoft 365 group. Required when `mail_enabled` is true
    /// </summary>
    [TerraformPropertyName("types")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Types { get; set; }

    /// <summary>
    /// Specifies the group join policy and group content visibility
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Visibility { get; set; } = default!;

    /// <summary>
    /// Whether this group should be synced from Azure AD to the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("writeback_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WritebackEnabled { get; set; }

    /// <summary>
    /// Block for dynamic_membership.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicMembership block(s) allowed")]
    [TerraformPropertyName("dynamic_membership")]
    public TerraformList<TerraformBlock<AzureadGroupDynamicMembershipBlock>>? DynamicMembership { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The SMTP address for the group
    /// </summary>
    [TerraformPropertyName("mail")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Mail => new TerraformReference(this, "mail");

    /// <summary>
    /// The object ID of the group
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObjectId => new TerraformReference(this, "object_id");

    /// <summary>
    /// The on-premises FQDN, also called dnsDomainName, synchronized from the on-premises directory when Azure AD Connect is used
    /// </summary>
    [TerraformPropertyName("onpremises_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OnpremisesDomainName => new TerraformReference(this, "onpremises_domain_name");

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
    /// The preferred language for a Microsoft 365 group, in ISO 639-1 notation
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredLanguage => new TerraformReference(this, "preferred_language");

    /// <summary>
    /// Email addresses for the group that direct to the same group mailbox
    /// </summary>
    [TerraformPropertyName("proxy_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ProxyAddresses => new TerraformReference(this, "proxy_addresses");

}
