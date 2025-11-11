using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for network_access_control in .
/// Nesting mode: list
/// </summary>
public partial class AwsGrafanaWorkspaceNetworkAccessControlBlock : TerraformBlockBase
{
    /// <summary>
    /// The prefix_list_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixListIds is required")]
    [TerraformProperty("prefix_list_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> PrefixListIds { get; set; }

    /// <summary>
    /// The vpce_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpceIds is required")]
    [TerraformProperty("vpce_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> VpceIds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGrafanaWorkspaceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsGrafanaWorkspaceVpcConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformProperty("security_group_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SubnetIds { get; set; }

}

/// <summary>
/// Manages a aws_grafana_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGrafanaWorkspace : TerraformResource
{
    public AwsGrafanaWorkspace(string name) : base("aws_grafana_workspace", name)
    {
    }

    /// <summary>
    /// The account_access_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountAccessType is required")]
    [TerraformProperty("account_access_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccountAccessType { get; set; }

    /// <summary>
    /// The authentication_providers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProviders is required")]
    [TerraformProperty("authentication_providers")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? AuthenticationProviders { get; set; }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformProperty("configuration")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Configuration { get; set; }

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    [TerraformProperty("data_sources")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? DataSources { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    [TerraformProperty("grafana_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> GrafanaVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_destinations attribute.
    /// </summary>
    [TerraformProperty("notification_destinations")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? NotificationDestinations { get; set; }

    /// <summary>
    /// The organization_role_name attribute.
    /// </summary>
    [TerraformProperty("organization_role_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OrganizationRoleName { get; set; }

    /// <summary>
    /// The organizational_units attribute.
    /// </summary>
    [TerraformProperty("organizational_units")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? OrganizationalUnits { get; set; }

    /// <summary>
    /// The permission_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionType is required")]
    [TerraformProperty("permission_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PermissionType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [TerraformProperty("stack_set_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StackSetName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for network_access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAccessControl block(s) allowed")]
    [TerraformProperty("network_access_control")]
    public TerraformList<TerraformBlock<AwsGrafanaWorkspaceNetworkAccessControlBlock>>? NetworkAccessControl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsGrafanaWorkspaceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    [TerraformProperty("vpc_configuration")]
    public TerraformList<TerraformBlock<AwsGrafanaWorkspaceVpcConfigurationBlock>>? VpcConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The saml_configuration_status attribute.
    /// </summary>
    [TerraformProperty("saml_configuration_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SamlConfigurationStatus { get; }

}
