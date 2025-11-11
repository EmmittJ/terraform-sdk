using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_workspaces_directory.
/// </summary>
public class AwsWorkspacesDirectoryDataSource : TerraformDataSource
{
    public AwsWorkspacesDirectoryDataSource(string name) : base("aws_workspaces_directory", name)
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformPropertyName("directory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The active_directory_config attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_config")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> ActiveDirectoryConfig => new TerraformReference(this, "active_directory_config");

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Alias => new TerraformReference(this, "alias");

    /// <summary>
    /// The certificate_based_auth_properties attribute.
    /// </summary>
    [TerraformPropertyName("certificate_based_auth_properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CertificateBasedAuthProperties => new TerraformReference(this, "certificate_based_auth_properties");

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    [TerraformPropertyName("customer_user_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerUserName => new TerraformReference(this, "customer_user_name");

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [TerraformPropertyName("directory_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DirectoryName => new TerraformReference(this, "directory_name");

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [TerraformPropertyName("directory_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DirectoryType => new TerraformReference(this, "directory_type");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("dns_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> DnsIpAddresses => new TerraformReference(this, "dns_ip_addresses");

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IamRoleId => new TerraformReference(this, "iam_role_id");

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("ip_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> IpGroupIds => new TerraformReference(this, "ip_group_ids");

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    [TerraformPropertyName("registration_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RegistrationCode => new TerraformReference(this, "registration_code");

    /// <summary>
    /// The saml_properties attribute.
    /// </summary>
    [TerraformPropertyName("saml_properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SamlProperties => new TerraformReference(this, "saml_properties");

    /// <summary>
    /// The self_service_permissions attribute.
    /// </summary>
    [TerraformPropertyName("self_service_permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SelfServicePermissions => new TerraformReference(this, "self_service_permissions");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SubnetIds => new TerraformReference(this, "subnet_ids");

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    [TerraformPropertyName("user_identity_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserIdentityType => new TerraformReference(this, "user_identity_type");

    /// <summary>
    /// The workspace_access_properties attribute.
    /// </summary>
    [TerraformPropertyName("workspace_access_properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WorkspaceAccessProperties => new TerraformReference(this, "workspace_access_properties");

    /// <summary>
    /// The workspace_creation_properties attribute.
    /// </summary>
    [TerraformPropertyName("workspace_creation_properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WorkspaceCreationProperties => new TerraformReference(this, "workspace_creation_properties");

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    [TerraformPropertyName("workspace_directory_description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceDirectoryDescription => new TerraformReference(this, "workspace_directory_description");

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    [TerraformPropertyName("workspace_directory_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceDirectoryName => new TerraformReference(this, "workspace_directory_name");

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceSecurityGroupId => new TerraformReference(this, "workspace_security_group_id");

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    [TerraformPropertyName("workspace_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceType => new TerraformReference(this, "workspace_type");

}
