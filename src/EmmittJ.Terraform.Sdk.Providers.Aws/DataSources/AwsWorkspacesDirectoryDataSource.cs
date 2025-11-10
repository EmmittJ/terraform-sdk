using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_workspaces_directory.
/// </summary>
public class AwsWorkspacesDirectoryDataSource : TerraformDataSource
{
    public AwsWorkspacesDirectoryDataSource(string name) : base("aws_workspaces_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("active_directory_config");
        this.DeclareOutput("alias");
        this.DeclareOutput("certificate_based_auth_properties");
        this.DeclareOutput("customer_user_name");
        this.DeclareOutput("directory_name");
        this.DeclareOutput("directory_type");
        this.DeclareOutput("dns_ip_addresses");
        this.DeclareOutput("iam_role_id");
        this.DeclareOutput("ip_group_ids");
        this.DeclareOutput("registration_code");
        this.DeclareOutput("saml_properties");
        this.DeclareOutput("self_service_permissions");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("user_identity_type");
        this.DeclareOutput("workspace_access_properties");
        this.DeclareOutput("workspace_creation_properties");
        this.DeclareOutput("workspace_directory_description");
        this.DeclareOutput("workspace_directory_name");
        this.DeclareOutput("workspace_security_group_id");
        this.DeclareOutput("workspace_type");
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformProperty<string> DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The active_directory_config attribute.
    /// </summary>
    public TerraformExpression ActiveDirectoryConfig => this["active_directory_config"];

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

    /// <summary>
    /// The certificate_based_auth_properties attribute.
    /// </summary>
    public TerraformExpression CertificateBasedAuthProperties => this["certificate_based_auth_properties"];

    /// <summary>
    /// The customer_user_name attribute.
    /// </summary>
    public TerraformExpression CustomerUserName => this["customer_user_name"];

    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    public TerraformExpression DirectoryName => this["directory_name"];

    /// <summary>
    /// The directory_type attribute.
    /// </summary>
    public TerraformExpression DirectoryType => this["directory_type"];

    /// <summary>
    /// The dns_ip_addresses attribute.
    /// </summary>
    public TerraformExpression DnsIpAddresses => this["dns_ip_addresses"];

    /// <summary>
    /// The iam_role_id attribute.
    /// </summary>
    public TerraformExpression IamRoleId => this["iam_role_id"];

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    public TerraformExpression IpGroupIds => this["ip_group_ids"];

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    public TerraformExpression RegistrationCode => this["registration_code"];

    /// <summary>
    /// The saml_properties attribute.
    /// </summary>
    public TerraformExpression SamlProperties => this["saml_properties"];

    /// <summary>
    /// The self_service_permissions attribute.
    /// </summary>
    public TerraformExpression SelfServicePermissions => this["self_service_permissions"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    public TerraformExpression UserIdentityType => this["user_identity_type"];

    /// <summary>
    /// The workspace_access_properties attribute.
    /// </summary>
    public TerraformExpression WorkspaceAccessProperties => this["workspace_access_properties"];

    /// <summary>
    /// The workspace_creation_properties attribute.
    /// </summary>
    public TerraformExpression WorkspaceCreationProperties => this["workspace_creation_properties"];

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    public TerraformExpression WorkspaceDirectoryDescription => this["workspace_directory_description"];

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    public TerraformExpression WorkspaceDirectoryName => this["workspace_directory_name"];

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    public TerraformExpression WorkspaceSecurityGroupId => this["workspace_security_group_id"];

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    public TerraformExpression WorkspaceType => this["workspace_type"];

}
