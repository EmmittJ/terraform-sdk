using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for user_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerUserProfileUserSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The auto_mount_home_efs attribute.
    /// </summary>
    public TerraformProperty<string>? AutoMountHomeEfs
    {
        set => SetProperty("auto_mount_home_efs", value);
    }

    /// <summary>
    /// The default_landing_uri attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultLandingUri
    {
        set => SetProperty("default_landing_uri", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformProperty<string> ExecutionRole
    {
        set => SetProperty("execution_role", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The studio_web_portal attribute.
    /// </summary>
    public TerraformProperty<string>? StudioWebPortal
    {
        set => SetProperty("studio_web_portal", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_user_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerUserProfile : TerraformResource
{
    public AwsSagemakerUserProfile(string name) : base("aws_sagemaker_user_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("home_efs_file_system_uid");
        SetOutput("domain_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("single_sign_on_user_identifier");
        SetOutput("single_sign_on_user_value");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("user_profile_name");
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformProperty<string> DomainId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_id");
        set => SetProperty("domain_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The single_sign_on_user_identifier attribute.
    /// </summary>
    public TerraformProperty<string> SingleSignOnUserIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("single_sign_on_user_identifier");
        set => SetProperty("single_sign_on_user_identifier", value);
    }

    /// <summary>
    /// The single_sign_on_user_value attribute.
    /// </summary>
    public TerraformProperty<string> SingleSignOnUserValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("single_sign_on_user_value");
        set => SetProperty("single_sign_on_user_value", value);
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
    /// The user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserProfileName is required")]
    public required TerraformProperty<string> UserProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_profile_name");
        set => SetProperty("user_profile_name", value);
    }

    /// <summary>
    /// Block for user_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserSettings block(s) allowed")]
    public List<AwsSagemakerUserProfileUserSettingsBlock>? UserSettings
    {
        set => SetProperty("user_settings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The home_efs_file_system_uid attribute.
    /// </summary>
    public TerraformExpression HomeEfsFileSystemUid => this["home_efs_file_system_uid"];

}
