using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_organizations_account resource.
/// </summary>
public class AwsOrganizationsAccount : TerraformResource
{
    public AwsOrganizationsAccount(string name) : base("aws_organizations_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("govcloud_id");
        this.DeclareOutput("joined_method");
        this.DeclareOutput("joined_timestamp");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The close_on_deletion attribute.
    /// </summary>
    public bool? CloseOnDeletion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("close_on_deletion")?.Value;
        set => this.WithProperty("close_on_deletion", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The create_govcloud attribute.
    /// </summary>
    public bool? CreateGovcloud
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_govcloud")?.Value;
        set => this.WithProperty("create_govcloud", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public string? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email")?.Value;
        set => this.WithProperty("email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_user_access_to_billing attribute.
    /// </summary>
    public string? IamUserAccessToBilling
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_user_access_to_billing")?.Value;
        set => this.WithProperty("iam_user_access_to_billing", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public string? ParentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_id")?.Value;
        set => this.WithProperty("parent_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public string? RoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_name")?.Value;
        set => this.WithProperty("role_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The govcloud_id attribute.
    /// </summary>
    public TerraformExpression GovcloudId => this["govcloud_id"];

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    public TerraformExpression JoinedMethod => this["joined_method"];

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    public TerraformExpression JoinedTimestamp => this["joined_timestamp"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
