using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for kms_settings in GoogleAssuredWorkloadsWorkload.
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadKmsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_settings";

    /// <summary>
    /// Required. Input only. Immutable. The time at which the Key Management Service will automatically create a new version of the crypto key and mark it as the primary.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextRotationTime is required")]
    public required TerraformValue<string> NextRotationTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("next_rotation_time");
        set => SetArgument("next_rotation_time", value);
    }

    /// <summary>
    /// Required. Input only. Immutable. will be advanced by this period when the Key Management Service automatically rotates a key. Must be at least 24 hours and at most 876,000 hours.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationPeriod is required")]
    public required TerraformValue<string> RotationPeriod
    {
        get => GetRequiredArgument<TerraformValue<string>>("rotation_period");
        set => SetArgument("rotation_period", value);
    }

}


/// <summary>
/// Block type for partner_permissions in GoogleAssuredWorkloadsWorkload.
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "partner_permissions";

    /// <summary>
    /// Optional. Allow partner to view violation alerts.
    /// </summary>
    public TerraformValue<bool>? AssuredWorkloadsMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("assured_workloads_monitoring");
        set => SetArgument("assured_workloads_monitoring", value);
    }

    /// <summary>
    /// Allow the partner to view inspectability logs and monitoring violations.
    /// </summary>
    public TerraformValue<bool>? DataLogsViewer
    {
        get => GetArgument<TerraformValue<bool>>("data_logs_viewer");
        set => SetArgument("data_logs_viewer", value);
    }

    /// <summary>
    /// Optional. Allow partner to view access approval logs.
    /// </summary>
    public TerraformValue<bool>? ServiceAccessApprover
    {
        get => GetArgument<TerraformValue<bool>>("service_access_approver");
        set => SetArgument("service_access_approver", value);
    }

}


/// <summary>
/// Block type for resource_settings in GoogleAssuredWorkloadsWorkload.
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadResourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_settings";

    /// <summary>
    /// User-assigned resource display name. If not empty it will be used to create a resource with the specified name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Resource identifier. For a project this represents projectId. If the project is already taken, the workload creation will fail. For KeyRing, this represents the keyring_id. For a folder, don&#39;t set this value as folder_id is assigned by Google.
    /// </summary>
    public TerraformValue<string>? ResourceId
    {
        get => GetArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// Indicates the type of resource. This field should be specified to correspond the id to the right project type (CONSUMER_PROJECT or ENCRYPTION_KEYS_PROJECT) Possible values: RESOURCE_TYPE_UNSPECIFIED, CONSUMER_PROJECT, ENCRYPTION_KEYS_PROJECT, KEYRING, CONSUMER_FOLDER
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAssuredWorkloadsWorkload.
/// Nesting mode: single
/// </summary>
public class GoogleAssuredWorkloadsWorkloadTimeoutsBlock : TerraformBlock
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
/// Block type for workload_options in GoogleAssuredWorkloadsWorkload.
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workload_options";

    /// <summary>
    /// Indicates type of KAJ enrollment for the workload. Currently, only specifiying KEY_ACCESS_TRANSPARENCY_OFF is implemented to not enroll in KAT-level KAJ enrollment for Regional Controls workloads. Possible values: KAJ_ENROLLMENT_TYPE_UNSPECIFIED, FULL_KAJ, EKM_ONLY, KEY_ACCESS_TRANSPARENCY_OFF
    /// </summary>
    public TerraformValue<string>? KajEnrollmentType
    {
        get => GetArgument<TerraformValue<string>>("kaj_enrollment_type");
        set => SetArgument("kaj_enrollment_type", value);
    }

}


/// <summary>
/// Represents a google_assured_workloads_workload Terraform resource.
/// Manages a google_assured_workloads_workload resource.
/// </summary>
public partial class GoogleAssuredWorkloadsWorkload(string name) : TerraformResource("google_assured_workloads_workload", name)
{
    /// <summary>
    /// Optional. Input only. The billing account used for the resources which are direct children of workload. This billing account is initially associated with the resources created as part of Workload creation. After the initial creation of these resources, the customer can change the assigned billing account. The resource name has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF`.
    /// </summary>
    public TerraformValue<string>? BillingAccount
    {
        get => GetArgument<TerraformValue<string>>("billing_account");
        set => SetArgument("billing_account", value);
    }

    /// <summary>
    /// Required. Immutable. Compliance Regime associated with this workload. Possible values: COMPLIANCE_REGIME_UNSPECIFIED, IL4, CJIS, FEDRAMP_HIGH, FEDRAMP_MODERATE, US_REGIONAL_ACCESS, HIPAA, HITRUST, EU_REGIONS_AND_SUPPORT, CA_REGIONS_AND_SUPPORT, ITAR, AU_REGIONS_AND_US_SUPPORT, ASSURED_WORKLOADS_FOR_PARTNERS, ISR_REGIONS, ISR_REGIONS_AND_SUPPORT, CA_PROTECTED_B, IL5, IL2, JP_REGIONS_AND_SUPPORT, KSA_REGIONS_AND_SUPPORT_WITH_SOVEREIGNTY_CONTROLS, REGIONAL_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS_US_SUPPORT, IRS_1075
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComplianceRegime is required")]
    public required TerraformValue<string> ComplianceRegime
    {
        get => GetRequiredArgument<TerraformValue<string>>("compliance_regime");
        set => SetArgument("compliance_regime", value);
    }

    /// <summary>
    /// Required. The user-assigned display name of the Workload. When present it must be between 4 to 30 characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, and spaces. Example: My Workload
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Optional. Indicates the sovereignty status of the given workload. Currently meant to be used by Europe/Canada customers.
    /// </summary>
    public TerraformValue<bool>? EnableSovereignControls
    {
        get => GetArgument<TerraformValue<bool>>("enable_sovereign_controls");
        set => SetArgument("enable_sovereign_controls", value);
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
    /// Optional. Labels applied to the workload.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
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
    /// The organization for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformValue<string> Organization
    {
        get => GetRequiredArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// Optional. Partner regime associated with this workload. Possible values: PARTNER_UNSPECIFIED, LOCAL_CONTROLS_BY_S3NS, SOVEREIGN_CONTROLS_BY_T_SYSTEMS, SOVEREIGN_CONTROLS_BY_SIA_MINSAIT, SOVEREIGN_CONTROLS_BY_PSN, SOVEREIGN_CONTROLS_BY_CNTXT, SOVEREIGN_CONTROLS_BY_CNTXT_NO_EKM
    /// </summary>
    public TerraformValue<string>? Partner
    {
        get => GetArgument<TerraformValue<string>>("partner");
        set => SetArgument("partner", value);
    }

    /// <summary>
    /// Optional. Input only. Billing account necessary for purchasing services from Sovereign Partners. This field is required for creating SIA/PSN/CNTXT partner workloads. The caller should have &#39;billing.resourceAssociations.create&#39; IAM permission on this billing-account. The format of this string is billingAccounts/AAAAAA-BBBBBB-CCCCCC.
    /// </summary>
    public TerraformValue<string>? PartnerServicesBillingAccount
    {
        get => GetArgument<TerraformValue<string>>("partner_services_billing_account");
        set => SetArgument("partner_services_billing_account", value);
    }

    /// <summary>
    /// Input only. The parent resource for the resources managed by this Assured Workload. May be either empty or a folder resource which is a child of the Workload parent. If not specified all resources are created under the parent organization. Format: folders/{folder_id}
    /// </summary>
    public TerraformValue<string>? ProvisionedResourcesParent
    {
        get => GetArgument<TerraformValue<string>>("provisioned_resources_parent");
        set => SetArgument("provisioned_resources_parent", value);
    }

    /// <summary>
    /// Optional. Indicates whether the e-mail notification for a violation is enabled for a workload. This value will be by default True, and if not present will be considered as true. This should only be updated via updateWorkload call. Any Changes to this field during the createWorkload call will not be honored. This will always be true while creating the workload.
    /// </summary>
    public TerraformValue<bool> ViolationNotificationsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("violation_notifications_enabled") ?? CreateReference("violation_notifications_enabled");
        set => SetArgument("violation_notifications_enabled", value);
    }

    /// <summary>
    /// Output only. Count of active Violations in the Workload.
    /// </summary>
    public TerraformList<TerraformMap<object>> ComplianceStatus
        => CreateReference("compliance_status");

    /// <summary>
    /// Output only. Urls for services which are compliant for this Assured Workload, but which are currently disallowed by the ResourceUsageRestriction org policy. Invoke workloads.restrictAllowedResources endpoint to allow your project developers to use these services in their environment.
    /// </summary>
    public TerraformList<string> CompliantButDisallowedServices
        => CreateReference("compliant_but_disallowed_services");

    /// <summary>
    /// Output only. Immutable. The Workload creation timestamp.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Optional. Represents the Ekm Provisioning State of the given workload.
    /// </summary>
    public TerraformList<TerraformMap<object>> EkmProvisioningResponse
        => CreateReference("ekm_provisioning_response");

    /// <summary>
    /// Output only. Represents the KAJ enrollment state of the given workload. Possible values: KAJ_ENROLLMENT_STATE_UNSPECIFIED, KAJ_ENROLLMENT_STATE_PENDING, KAJ_ENROLLMENT_STATE_COMPLETE
    /// </summary>
    public TerraformValue<string> KajEnrollmentState
        => CreateReference("kaj_enrollment_state");

    /// <summary>
    /// Output only. The resource name of the workload.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Output only. The resources associated with this workload. These resources will be created when creating the workload. If any of the projects already exist, the workload creation will fail. Always read only.
    /// </summary>
    public TerraformList<TerraformMap<object>> Resources
        => CreateReference("resources");

    /// <summary>
    /// Output only. Represents the SAA enrollment response of the given workload. SAA enrollment response is queried during workloads.get call. In failure cases, user friendly error message is shown in SAA details page.
    /// </summary>
    public TerraformList<TerraformMap<object>> SaaEnrollmentResponse
        => CreateReference("saa_enrollment_response");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// KmsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsSettings block(s) allowed")]
    public TerraformList<GoogleAssuredWorkloadsWorkloadKmsSettingsBlock>? KmsSettings
    {
        get => GetArgument<TerraformList<GoogleAssuredWorkloadsWorkloadKmsSettingsBlock>>("kms_settings");
        set => SetArgument("kms_settings", value);
    }

    /// <summary>
    /// PartnerPermissions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartnerPermissions block(s) allowed")]
    public TerraformList<GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock>? PartnerPermissions
    {
        get => GetArgument<TerraformList<GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock>>("partner_permissions");
        set => SetArgument("partner_permissions", value);
    }

    /// <summary>
    /// ResourceSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAssuredWorkloadsWorkloadResourceSettingsBlock>? ResourceSettings
    {
        get => GetArgument<TerraformList<GoogleAssuredWorkloadsWorkloadResourceSettingsBlock>>("resource_settings");
        set => SetArgument("resource_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAssuredWorkloadsWorkloadTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAssuredWorkloadsWorkloadTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WorkloadOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadOptions block(s) allowed")]
    public TerraformList<GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock>? WorkloadOptions
    {
        get => GetArgument<TerraformList<GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock>>("workload_options");
        set => SetArgument("workload_options", value);
    }

}
