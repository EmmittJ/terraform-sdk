using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspaces_directory Terraform data source.
/// Retrieves information about a aws_workspaces_directory.
/// </summary>
public partial class AwsWorkspacesDirectoryDataSource(string name) : TerraformDataSource("aws_workspaces_directory", name)
{
    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformValue<string> DirectoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("directory_id");
        set => SetArgument("directory_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The active_directory_config attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ActiveDirectoryConfig
        => CreateReference("active_directory_config");

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
        => CreateReference("alias");

    /// <summary>
    /// The certificate_based_auth_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateBasedAuthProperties
        => CreateReference("certificate_based_auth_properties");

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    public TerraformValue<string> CustomerUserName
        => CreateReference("customer_user_name");

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformValue<string> DirectoryName
        => CreateReference("directory_name");

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    public TerraformValue<string> DirectoryType
        => CreateReference("directory_type");

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> DnsIpAddresses
        => CreateReference("dns_ip_addresses");

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    public TerraformValue<string> IamRoleId
        => CreateReference("iam_role_id");

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    public TerraformSet<string> IpGroupIds
        => CreateReference("ip_group_ids");

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    public TerraformValue<string> RegistrationCode
        => CreateReference("registration_code");

    /// <summary>
    /// The saml_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SamlProperties
        => CreateReference("saml_properties");

    /// <summary>
    /// The self_service_permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SelfServicePermissions
        => CreateReference("self_service_permissions");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
        => CreateReference("subnet_ids");

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    public TerraformValue<string> UserIdentityType
        => CreateReference("user_identity_type");

    /// <summary>
    /// The workspace_access_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkspaceAccessProperties
        => CreateReference("workspace_access_properties");

    /// <summary>
    /// The workspace_creation_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkspaceCreationProperties
        => CreateReference("workspace_creation_properties");

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceDirectoryDescription
        => CreateReference("workspace_directory_description");

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceDirectoryName
        => CreateReference("workspace_directory_name");

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceSecurityGroupId
        => CreateReference("workspace_security_group_id");

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceType
        => CreateReference("workspace_type");

}
