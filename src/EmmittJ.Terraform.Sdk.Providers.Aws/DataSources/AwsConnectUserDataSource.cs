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
        this.DeclareOutput("arn");
        this.DeclareOutput("directory_user_id");
        this.DeclareOutput("hierarchy_group_id");
        this.DeclareOutput("identity_info");
        this.DeclareOutput("phone_config");
        this.DeclareOutput("routing_profile_id");
        this.DeclareOutput("security_profile_ids");
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
    /// The instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserId
    {
        get => GetProperty<TerraformProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
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
