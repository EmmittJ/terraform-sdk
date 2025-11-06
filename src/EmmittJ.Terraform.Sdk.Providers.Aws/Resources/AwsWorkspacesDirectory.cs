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
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_group_ids attribute.
    /// </summary>
    public HashSet<string>? IpGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ip_group_ids")?.Value;
        set => this.WithProperty("ip_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<string>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_ids")?.Value;
        set => this.WithProperty("subnet_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The user_identity_type attribute.
    /// </summary>
    public string? UserIdentityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_identity_type")?.Value;
        set => this.WithProperty("user_identity_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_directory_description attribute.
    /// </summary>
    public string? WorkspaceDirectoryDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_directory_description")?.Value;
        set => this.WithProperty("workspace_directory_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_directory_name attribute.
    /// </summary>
    public string? WorkspaceDirectoryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_directory_name")?.Value;
        set => this.WithProperty("workspace_directory_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_type attribute.
    /// </summary>
    public string? WorkspaceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_type")?.Value;
        set => this.WithProperty("workspace_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
