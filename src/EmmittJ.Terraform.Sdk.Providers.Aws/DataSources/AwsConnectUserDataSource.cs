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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The user_id attribute.
    /// </summary>
    public string? UserId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_id")?.Value;
        set => this.WithProperty("user_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
