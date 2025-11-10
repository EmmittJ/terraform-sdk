using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identity_info in .
/// Nesting mode: list
/// </summary>
public class AwsConnectUserIdentityInfoBlock : TerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        get => GetProperty<TerraformProperty<string>>("first_name");
        set => WithProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        get => GetProperty<TerraformProperty<string>>("last_name");
        set => WithProperty("last_name", value);
    }

    /// <summary>
    /// The secondary_email attribute.
    /// </summary>
    public TerraformProperty<string>? SecondaryEmail
    {
        get => GetProperty<TerraformProperty<string>>("secondary_email");
        set => WithProperty("secondary_email", value);
    }

}

/// <summary>
/// Block type for phone_config in .
/// Nesting mode: list
/// </summary>
public class AwsConnectUserPhoneConfigBlock : TerraformBlock
{
    /// <summary>
    /// The after_contact_work_time_limit attribute.
    /// </summary>
    public TerraformProperty<double>? AfterContactWorkTimeLimit
    {
        get => GetProperty<TerraformProperty<double>>("after_contact_work_time_limit");
        set => WithProperty("after_contact_work_time_limit", value);
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoAccept
    {
        get => GetProperty<TerraformProperty<bool>>("auto_accept");
        set => WithProperty("auto_accept", value);
    }

    /// <summary>
    /// The desk_phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? DeskPhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("desk_phone_number");
        set => WithProperty("desk_phone_number", value);
    }

    /// <summary>
    /// The phone_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneType is required")]
    public required TerraformProperty<string> PhoneType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("phone_type");
        set => WithProperty("phone_type", value);
    }

}

/// <summary>
/// Manages a aws_connect_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingProfileId is required")]
    public required TerraformProperty<string> RoutingProfileId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("routing_profile_id");
        set => this.WithProperty("routing_profile_id", value);
    }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityProfileIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityProfileIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_profile_ids");
        set => this.WithProperty("security_profile_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for identity_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityInfo block(s) allowed")]
    public List<AwsConnectUserIdentityInfoBlock>? IdentityInfo
    {
        get => GetProperty<List<AwsConnectUserIdentityInfoBlock>>("identity_info");
        set => this.WithProperty("identity_info", value);
    }

    /// <summary>
    /// Block for phone_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PhoneConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneConfig block(s) allowed")]
    public List<AwsConnectUserPhoneConfigBlock>? PhoneConfig
    {
        get => GetProperty<List<AwsConnectUserPhoneConfigBlock>>("phone_config");
        set => this.WithProperty("phone_config", value);
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
