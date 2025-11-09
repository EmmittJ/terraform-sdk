using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_connect_user resource.
/// </summary>
public class AwsConnectUser : TerraformResource
{
    public AwsConnectUser(string name) : base("aws_connect_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("user_id");
    }

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryUserId
    {
        get => GetProperty<TerraformProperty<string>>("directory_user_id");
        set => this.WithProperty("directory_user_id", value);
    }

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? HierarchyGroupId
    {
        get => GetProperty<TerraformProperty<string>>("hierarchy_group_id");
        set => this.WithProperty("hierarchy_group_id", value);
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
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
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
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingProfileId
    {
        get => GetProperty<TerraformProperty<string>>("routing_profile_id");
        set => this.WithProperty("routing_profile_id", value);
    }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityProfileIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_profile_ids");
        set => this.WithProperty("security_profile_ids", value);
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
    /// The user_id attribute.
    /// </summary>
    public TerraformExpression UserId => this["user_id"];

}
