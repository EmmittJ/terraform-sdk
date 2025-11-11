using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_workspaces_directory.
/// </summary>
public partial class AwsWorkspacesDirectoryDataSource : TerraformDataSource
{
    public AwsWorkspacesDirectoryDataSource(string name) : base("aws_workspaces_directory", name)
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformProperty("directory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The active_directory_config attribute.
    /// </summary>
    [TerraformProperty("active_directory_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> ActiveDirectoryConfig { get; }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Alias { get; }

    /// <summary>
    /// The certificate_based_auth_properties attribute.
    /// </summary>
    [TerraformProperty("certificate_based_auth_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CertificateBasedAuthProperties { get; }

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    [TerraformProperty("customer_user_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomerUserName { get; }

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [TerraformProperty("directory_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DirectoryName { get; }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [TerraformProperty("directory_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DirectoryType { get; }

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("dns_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> DnsIpAddresses { get; }

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    [TerraformProperty("iam_role_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IamRoleId { get; }

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    [TerraformProperty("ip_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> IpGroupIds { get; }

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    [TerraformProperty("registration_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistrationCode { get; }

    /// <summary>
    /// The saml_properties attribute.
    /// </summary>
    [TerraformProperty("saml_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SamlProperties { get; }

    /// <summary>
    /// The self_service_permissions attribute.
    /// </summary>
    [TerraformProperty("self_service_permissions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SelfServicePermissions { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SubnetIds { get; }

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    [TerraformProperty("user_identity_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserIdentityType { get; }

    /// <summary>
    /// The workspace_access_properties attribute.
    /// </summary>
    [TerraformProperty("workspace_access_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> WorkspaceAccessProperties { get; }

    /// <summary>
    /// The workspace_creation_properties attribute.
    /// </summary>
    [TerraformProperty("workspace_creation_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> WorkspaceCreationProperties { get; }

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    [TerraformProperty("workspace_directory_description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkspaceDirectoryDescription { get; }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    [TerraformProperty("workspace_directory_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkspaceDirectoryName { get; }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    [TerraformProperty("workspace_security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkspaceSecurityGroupId { get; }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    [TerraformProperty("workspace_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkspaceType { get; }

}
