using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for kms_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAssuredWorkloadsWorkloadKmsSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. Input only. Immutable. The time at which the Key Management Service will automatically create a new version of the crypto key and mark it as the primary.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextRotationTime is required")]
    [TerraformProperty("next_rotation_time")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NextRotationTime { get; set; }

    /// <summary>
    /// Required. Input only. Immutable. will be advanced by this period when the Key Management Service automatically rotates a key. Must be at least 24 hours and at most 876,000 hours.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationPeriod is required")]
    [TerraformProperty("rotation_period")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RotationPeriod { get; set; }

}

/// <summary>
/// Block type for partner_permissions in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Allow partner to view violation alerts.
    /// </summary>
    [TerraformProperty("assured_workloads_monitoring")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AssuredWorkloadsMonitoring { get; set; }

    /// <summary>
    /// Allow the partner to view inspectability logs and monitoring violations.
    /// </summary>
    [TerraformProperty("data_logs_viewer")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DataLogsViewer { get; set; }

    /// <summary>
    /// Optional. Allow partner to view access approval logs.
    /// </summary>
    [TerraformProperty("service_access_approver")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ServiceAccessApprover { get; set; }

}

/// <summary>
/// Block type for resource_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAssuredWorkloadsWorkloadResourceSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// User-assigned resource display name. If not empty it will be used to create a resource with the specified name.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Resource identifier. For a project this represents projectId. If the project is already taken, the workload creation will fail. For KeyRing, this represents the keyring_id. For a folder, don&#39;t set this value as folder_id is assigned by Google.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceId { get; set; }

    /// <summary>
    /// Indicates the type of resource. This field should be specified to correspond the id to the right project type (CONSUMER_PROJECT or ENCRYPTION_KEYS_PROJECT) Possible values: RESOURCE_TYPE_UNSPECIFIED, CONSUMER_PROJECT, ENCRYPTION_KEYS_PROJECT, KEYRING, CONSUMER_FOLDER
    /// </summary>
    [TerraformProperty("resource_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAssuredWorkloadsWorkloadTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for workload_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Indicates type of KAJ enrollment for the workload. Currently, only specifiying KEY_ACCESS_TRANSPARENCY_OFF is implemented to not enroll in KAT-level KAJ enrollment for Regional Controls workloads. Possible values: KAJ_ENROLLMENT_TYPE_UNSPECIFIED, FULL_KAJ, EKM_ONLY, KEY_ACCESS_TRANSPARENCY_OFF
    /// </summary>
    [TerraformProperty("kaj_enrollment_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KajEnrollmentType { get; set; }

}

/// <summary>
/// Manages a google_assured_workloads_workload resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAssuredWorkloadsWorkload : TerraformResource
{
    public GoogleAssuredWorkloadsWorkload(string name) : base("google_assured_workloads_workload", name)
    {
    }

    /// <summary>
    /// Optional. Input only. The billing account used for the resources which are direct children of workload. This billing account is initially associated with the resources created as part of Workload creation. After the initial creation of these resources, the customer can change the assigned billing account. The resource name has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF`.
    /// </summary>
    [TerraformProperty("billing_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BillingAccount { get; set; }

    /// <summary>
    /// Required. Immutable. Compliance Regime associated with this workload. Possible values: COMPLIANCE_REGIME_UNSPECIFIED, IL4, CJIS, FEDRAMP_HIGH, FEDRAMP_MODERATE, US_REGIONAL_ACCESS, HIPAA, HITRUST, EU_REGIONS_AND_SUPPORT, CA_REGIONS_AND_SUPPORT, ITAR, AU_REGIONS_AND_US_SUPPORT, ASSURED_WORKLOADS_FOR_PARTNERS, ISR_REGIONS, ISR_REGIONS_AND_SUPPORT, CA_PROTECTED_B, IL5, IL2, JP_REGIONS_AND_SUPPORT, KSA_REGIONS_AND_SUPPORT_WITH_SOVEREIGNTY_CONTROLS, REGIONAL_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS_US_SUPPORT, IRS_1075
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComplianceRegime is required")]
    [TerraformProperty("compliance_regime")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ComplianceRegime { get; set; }

    /// <summary>
    /// Required. The user-assigned display name of the Workload. When present it must be between 4 to 30 characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, and spaces. Example: My Workload
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Optional. Indicates the sovereignty status of the given workload. Currently meant to be used by Europe/Canada customers.
    /// </summary>
    [TerraformProperty("enable_sovereign_controls")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableSovereignControls { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional. Labels applied to the workload.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The organization for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformProperty("organization")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Organization { get; set; }

    /// <summary>
    /// Optional. Partner regime associated with this workload. Possible values: PARTNER_UNSPECIFIED, LOCAL_CONTROLS_BY_S3NS, SOVEREIGN_CONTROLS_BY_T_SYSTEMS, SOVEREIGN_CONTROLS_BY_SIA_MINSAIT, SOVEREIGN_CONTROLS_BY_PSN, SOVEREIGN_CONTROLS_BY_CNTXT, SOVEREIGN_CONTROLS_BY_CNTXT_NO_EKM
    /// </summary>
    [TerraformProperty("partner")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Partner { get; set; }

    /// <summary>
    /// Optional. Input only. Billing account necessary for purchasing services from Sovereign Partners. This field is required for creating SIA/PSN/CNTXT partner workloads. The caller should have &#39;billing.resourceAssociations.create&#39; IAM permission on this billing-account. The format of this string is billingAccounts/AAAAAA-BBBBBB-CCCCCC.
    /// </summary>
    [TerraformProperty("partner_services_billing_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PartnerServicesBillingAccount { get; set; }

    /// <summary>
    /// Input only. The parent resource for the resources managed by this Assured Workload. May be either empty or a folder resource which is a child of the Workload parent. If not specified all resources are created under the parent organization. Format: folders/{folder_id}
    /// </summary>
    [TerraformProperty("provisioned_resources_parent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProvisionedResourcesParent { get; set; }

    /// <summary>
    /// Optional. Indicates whether the e-mail notification for a violation is enabled for a workload. This value will be by default True, and if not present will be considered as true. This should only be updated via updateWorkload call. Any Changes to this field during the createWorkload call will not be honored. This will always be true while creating the workload.
    /// </summary>
    [TerraformProperty("violation_notifications_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ViolationNotificationsEnabled { get; set; }

    /// <summary>
    /// Block for kms_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsSettings block(s) allowed")]
    [TerraformProperty("kms_settings")]
    public TerraformList<TerraformBlock<GoogleAssuredWorkloadsWorkloadKmsSettingsBlock>>? KmsSettings { get; set; }

    /// <summary>
    /// Block for partner_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartnerPermissions block(s) allowed")]
    [TerraformProperty("partner_permissions")]
    public TerraformList<TerraformBlock<GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock>>? PartnerPermissions { get; set; }

    /// <summary>
    /// Block for resource_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("resource_settings")]
    public TerraformList<TerraformBlock<GoogleAssuredWorkloadsWorkloadResourceSettingsBlock>>? ResourceSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAssuredWorkloadsWorkloadTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for workload_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadOptions block(s) allowed")]
    [TerraformProperty("workload_options")]
    public TerraformList<TerraformBlock<GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock>>? WorkloadOptions { get; set; }

    /// <summary>
    /// Output only. Count of active Violations in the Workload.
    /// </summary>
    [TerraformProperty("compliance_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ComplianceStatus { get; }

    /// <summary>
    /// Output only. Urls for services which are compliant for this Assured Workload, but which are currently disallowed by the ResourceUsageRestriction org policy. Invoke workloads.restrictAllowedResources endpoint to allow your project developers to use these services in their environment.
    /// </summary>
    [TerraformProperty("compliant_but_disallowed_services")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> CompliantButDisallowedServices { get; }

    /// <summary>
    /// Output only. Immutable. The Workload creation timestamp.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Optional. Represents the Ekm Provisioning State of the given workload.
    /// </summary>
    [TerraformProperty("ekm_provisioning_response")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EkmProvisioningResponse { get; }

    /// <summary>
    /// Output only. Represents the KAJ enrollment state of the given workload. Possible values: KAJ_ENROLLMENT_STATE_UNSPECIFIED, KAJ_ENROLLMENT_STATE_PENDING, KAJ_ENROLLMENT_STATE_COMPLETE
    /// </summary>
    [TerraformProperty("kaj_enrollment_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KajEnrollmentState { get; }

    /// <summary>
    /// Output only. The resource name of the workload.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The resources associated with this workload. These resources will be created when creating the workload. If any of the projects already exist, the workload creation will fail. Always read only.
    /// </summary>
    [TerraformProperty("resources")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Resources { get; }

    /// <summary>
    /// Output only. Represents the SAA enrollment response of the given workload. SAA enrollment response is queried during workloads.get call. In failure cases, user friendly error message is shown in SAA details page.
    /// </summary>
    [TerraformProperty("saa_enrollment_response")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SaaEnrollmentResponse { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
