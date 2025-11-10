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
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformProperty<string>? FirstName
    {
        set => SetProperty("first_name", value);
    }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformProperty<string>? LastName
    {
        set => SetProperty("last_name", value);
    }

    /// <summary>
    /// The secondary_email attribute.
    /// </summary>
    public TerraformProperty<string>? SecondaryEmail
    {
        set => SetProperty("secondary_email", value);
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
        set => SetProperty("after_contact_work_time_limit", value);
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoAccept
    {
        set => SetProperty("auto_accept", value);
    }

    /// <summary>
    /// The desk_phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? DeskPhoneNumber
    {
        set => SetProperty("desk_phone_number", value);
    }

    /// <summary>
    /// The phone_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneType is required")]
    public required TerraformProperty<string> PhoneType
    {
        set => SetProperty("phone_type", value);
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
        SetOutput("arn");
        SetOutput("user_id");
        SetOutput("directory_user_id");
        SetOutput("hierarchy_group_id");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("name");
        SetOutput("password");
        SetOutput("region");
        SetOutput("routing_profile_id");
        SetOutput("security_profile_ids");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The directory_user_id attribute.
    /// </summary>
    public TerraformProperty<string> DirectoryUserId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_user_id");
        set => SetProperty("directory_user_id", value);
    }

    /// <summary>
    /// The hierarchy_group_id attribute.
    /// </summary>
    public TerraformProperty<string> HierarchyGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hierarchy_group_id");
        set => SetProperty("hierarchy_group_id", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
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
    /// The routing_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingProfileId is required")]
    public required TerraformProperty<string> RoutingProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_profile_id");
        set => SetProperty("routing_profile_id", value);
    }

    /// <summary>
    /// The security_profile_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityProfileIds is required")]
    public HashSet<TerraformProperty<string>> SecurityProfileIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_profile_ids");
        set => SetProperty("security_profile_ids", value);
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
    /// Block for identity_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityInfo block(s) allowed")]
    public List<AwsConnectUserIdentityInfoBlock>? IdentityInfo
    {
        set => SetProperty("identity_info", value);
    }

    /// <summary>
    /// Block for phone_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PhoneConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneConfig block(s) allowed")]
    public List<AwsConnectUserPhoneConfigBlock>? PhoneConfig
    {
        set => SetProperty("phone_config", value);
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
