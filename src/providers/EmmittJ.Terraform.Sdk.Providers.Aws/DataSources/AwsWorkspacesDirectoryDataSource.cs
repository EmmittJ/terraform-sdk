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
        get => new TerraformReference<string>(this, "directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The active_directory_config attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ActiveDirectoryConfig
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "active_directory_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
    {
        get => new TerraformReference<string>(this, "alias");
    }

    /// <summary>
    /// The certificate_based_auth_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateBasedAuthProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificate_based_auth_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    public TerraformValue<string> CustomerUserName
    {
        get => new TerraformReference<string>(this, "customer_user_name");
    }

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformValue<string> DirectoryName
    {
        get => new TerraformReference<string>(this, "directory_name");
    }

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    public TerraformValue<string> DirectoryType
    {
        get => new TerraformReference<string>(this, "directory_type");
    }

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformSet<string> DnsIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "dns_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    public TerraformValue<string> IamRoleId
    {
        get => new TerraformReference<string>(this, "iam_role_id");
    }

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    public TerraformSet<string> IpGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    public TerraformValue<string> RegistrationCode
    {
        get => new TerraformReference<string>(this, "registration_code");
    }

    /// <summary>
    /// The saml_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SamlProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "saml_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The self_service_permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SelfServicePermissions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "self_service_permissions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    public TerraformValue<string> UserIdentityType
    {
        get => new TerraformReference<string>(this, "user_identity_type");
    }

    /// <summary>
    /// The workspace_access_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkspaceAccessProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "workspace_access_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workspace_creation_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkspaceCreationProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "workspace_creation_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceDirectoryDescription
    {
        get => new TerraformReference<string>(this, "workspace_directory_description");
    }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceDirectoryName
    {
        get => new TerraformReference<string>(this, "workspace_directory_name");
    }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceSecurityGroupId
    {
        get => new TerraformReference<string>(this, "workspace_security_group_id");
    }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceType
    {
        get => new TerraformReference<string>(this, "workspace_type");
    }

}
