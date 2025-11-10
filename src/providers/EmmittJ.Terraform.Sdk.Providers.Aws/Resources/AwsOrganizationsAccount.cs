using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOrganizationsAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("arn");
        SetOutput("govcloud_id");
        SetOutput("joined_method");
        SetOutput("joined_timestamp");
        SetOutput("state");
        SetOutput("status");
        SetOutput("close_on_deletion");
        SetOutput("create_govcloud");
        SetOutput("email");
        SetOutput("iam_user_access_to_billing");
        SetOutput("id");
        SetOutput("name");
        SetOutput("parent_id");
        SetOutput("role_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The close_on_deletion attribute.
    /// </summary>
    public TerraformProperty<bool> CloseOnDeletion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("close_on_deletion");
        set => SetProperty("close_on_deletion", value);
    }

    /// <summary>
    /// The create_govcloud attribute.
    /// </summary>
    public TerraformProperty<bool> CreateGovcloud
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("create_govcloud");
        set => SetProperty("create_govcloud", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email");
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The iam_user_access_to_billing attribute.
    /// </summary>
    public TerraformProperty<string> IamUserAccessToBilling
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_user_access_to_billing");
        set => SetProperty("iam_user_access_to_billing", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformProperty<string> ParentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_id");
        set => SetProperty("parent_id", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string> RoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_name");
        set => SetProperty("role_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOrganizationsAccountTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
