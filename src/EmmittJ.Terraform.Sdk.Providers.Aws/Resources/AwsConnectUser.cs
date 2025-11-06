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
    public string? DirectoryUserId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_user_id")?.Value;
        set => this.WithProperty("directory_user_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public string? HierarchyGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hierarchy_group_id")?.Value;
        set => this.WithProperty("hierarchy_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance_id attribute.
    /// </summary>
    public string? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id")?.Value;
        set => this.WithProperty("instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The routing_profile_id attribute.
    /// </summary>
    public string? RoutingProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_profile_id")?.Value;
        set => this.WithProperty("routing_profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityProfileIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_profile_ids")?.Value;
        set => this.WithProperty("security_profile_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The user_id attribute.
    /// </summary>
    public TerraformExpression UserId => this["user_id"];

}
