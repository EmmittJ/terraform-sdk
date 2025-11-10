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
    public required TerraformProperty<TerraformProperty<string>> DirectoryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The active_directory_config attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> ActiveDirectoryConfig => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "active_directory_config");

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Alias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "alias");

    /// <summary>
    /// The certificate_based_auth_properties attribute.
    /// </summary>
    [TerraformPropertyName("certificate_based_auth_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CertificateBasedAuthProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificate_based_auth_properties");

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    [TerraformPropertyName("customer_user_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerUserName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_user_name");

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [TerraformPropertyName("directory_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DirectoryName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "directory_name");

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    [TerraformPropertyName("directory_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DirectoryType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "directory_type");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("dns_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DnsIpAddresses => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "dns_ip_addresses");

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IamRoleId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "iam_role_id");

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("ip_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> IpGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "ip_group_ids");

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    [TerraformPropertyName("registration_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RegistrationCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "registration_code");

    /// <summary>
    /// The saml_properties attribute.
    /// </summary>
    [TerraformPropertyName("saml_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SamlProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "saml_properties");

    /// <summary>
    /// The self_service_permissions attribute.
    /// </summary>
    [TerraformPropertyName("self_service_permissions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SelfServicePermissions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "self_service_permissions");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    [TerraformPropertyName("user_identity_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserIdentityType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_identity_type");

    /// <summary>
    /// The workspace_access_properties attribute.
    /// </summary>
    [TerraformPropertyName("workspace_access_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WorkspaceAccessProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "workspace_access_properties");

    /// <summary>
    /// The workspace_creation_properties attribute.
    /// </summary>
    [TerraformPropertyName("workspace_creation_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WorkspaceCreationProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "workspace_creation_properties");

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    [TerraformPropertyName("workspace_directory_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceDirectoryDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_directory_description");

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    [TerraformPropertyName("workspace_directory_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceDirectoryName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_directory_name");

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceSecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_security_group_id");

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    [TerraformPropertyName("workspace_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_type");

}
