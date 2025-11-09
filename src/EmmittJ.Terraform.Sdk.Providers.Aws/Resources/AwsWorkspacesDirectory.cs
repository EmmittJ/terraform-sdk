using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspaces_directory resource.
/// </summary>
public class AwsWorkspacesDirectory : TerraformResource
{
    public AwsWorkspacesDirectory(string name) : base("aws_workspaces_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alias");
        this.DeclareOutput("customer_user_name");
        this.DeclareOutput("directory_name");
        this.DeclareOutput("directory_type");
        this.DeclareOutput("dns_ip_addresses");
        this.DeclareOutput("iam_role_id");
        this.DeclareOutput("registration_code");
        this.DeclareOutput("workspace_security_group_id");
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryId
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
    /// The ip_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? IpGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("ip_group_ids");
        set => this.WithProperty("ip_group_ids", value);
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
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    public TerraformProperty<string>? UserIdentityType
    {
        get => GetProperty<TerraformProperty<string>>("user_identity_type");
        set => this.WithProperty("user_identity_type", value);
    }

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceDirectoryDescription
    {
        get => GetProperty<TerraformProperty<string>>("workspace_directory_description");
        set => this.WithProperty("workspace_directory_description", value);
    }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceDirectoryName
    {
        get => GetProperty<TerraformProperty<string>>("workspace_directory_name");
        set => this.WithProperty("workspace_directory_name", value);
    }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceType
    {
        get => GetProperty<TerraformProperty<string>>("workspace_type");
        set => this.WithProperty("workspace_type", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

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
    /// The registration_code attribute.
    /// </summary>
    public TerraformExpression RegistrationCode => this["registration_code"];

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    public TerraformExpression WorkspaceSecurityGroupId => this["workspace_security_group_id"];

}
