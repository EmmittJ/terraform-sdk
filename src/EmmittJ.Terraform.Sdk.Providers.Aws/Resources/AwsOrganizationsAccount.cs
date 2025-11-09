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
        this.DeclareOutput("state");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The close_on_deletion attribute.
    /// </summary>
    public TerraformProperty<bool>? CloseOnDeletion
    {
        get => GetProperty<TerraformProperty<bool>>("close_on_deletion");
        set => this.WithProperty("close_on_deletion", value);
    }

    /// <summary>
    /// The create_govcloud attribute.
    /// </summary>
    public TerraformProperty<bool>? CreateGovcloud
    {
        get => GetProperty<TerraformProperty<bool>>("create_govcloud");
        set => this.WithProperty("create_govcloud", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => this.WithProperty("email", value);
    }

    /// <summary>
    /// The iam_user_access_to_billing attribute.
    /// </summary>
    public TerraformProperty<string>? IamUserAccessToBilling
    {
        get => GetProperty<TerraformProperty<string>>("iam_user_access_to_billing");
        set => this.WithProperty("iam_user_access_to_billing", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformProperty<string>? ParentId
    {
        get => GetProperty<TerraformProperty<string>>("parent_id");
        set => this.WithProperty("parent_id", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoleName
    {
        get => GetProperty<TerraformProperty<string>>("role_name");
        set => this.WithProperty("role_name", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
