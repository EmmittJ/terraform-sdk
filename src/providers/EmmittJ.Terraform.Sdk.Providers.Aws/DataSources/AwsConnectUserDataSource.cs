using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_user.
/// </summary>
public class AwsConnectUserDataSource : TerraformDataSource
{
    public AwsConnectUserDataSource(string name) : base("aws_connect_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("directory_user_id");
        SetOutput("hierarchy_group_id");
        SetOutput("identity_info");
        SetOutput("phone_config");
        SetOutput("routing_profile_id");
        SetOutput("security_profile_ids");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("user_id");
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// The user_id attribute.
    /// </summary>
    public TerraformProperty<string> UserId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_id");
        set => SetProperty("user_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    public TerraformExpression DirectoryUserId => this["directory_user_id"];

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformExpression HierarchyGroupId => this["hierarchy_group_id"];

    /// <summary>
    /// The identity_info attribute.
    /// </summary>
    public TerraformExpression IdentityInfo => this["identity_info"];

    /// <summary>
    /// The phone_config attribute.
    /// </summary>
    public TerraformExpression PhoneConfig => this["phone_config"];

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformExpression RoutingProfileId => this["routing_profile_id"];

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    public TerraformExpression SecurityProfileIds => this["security_profile_ids"];

}
