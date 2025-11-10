using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ownership_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceOwnershipSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The owner_user_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerUserProfileName is required")]
    public required TerraformProperty<string> OwnerUserProfileName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("owner_user_profile_name");
        set => WithProperty("owner_user_profile_name", value);
    }

}

/// <summary>
/// Block type for space_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The app_type attribute.
    /// </summary>
    public TerraformProperty<string>? AppType
    {
        get => GetProperty<TerraformProperty<string>>("app_type");
        set => WithProperty("app_type", value);
    }

}

/// <summary>
/// Block type for space_sharing_settings in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerSpaceSpaceSharingSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The sharing_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharingType is required")]
    public required TerraformProperty<string> SharingType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sharing_type");
        set => WithProperty("sharing_type", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_space resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerSpace : TerraformResource
{
    public AwsSagemakerSpace(string name) : base("aws_sagemaker_space", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("home_efs_file_system_uid");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformProperty<string> DomainId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_id");
        set => this.WithProperty("domain_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The space_display_name attribute.
    /// </summary>
    public TerraformProperty<string>? SpaceDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("space_display_name");
        set => this.WithProperty("space_display_name", value);
    }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    public required TerraformProperty<string> SpaceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("space_name");
        set => this.WithProperty("space_name", value);
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
    /// Block for ownership_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OwnershipSettings block(s) allowed")]
    public List<AwsSagemakerSpaceOwnershipSettingsBlock>? OwnershipSettings
    {
        get => GetProperty<List<AwsSagemakerSpaceOwnershipSettingsBlock>>("ownership_settings");
        set => this.WithProperty("ownership_settings", value);
    }

    /// <summary>
    /// Block for space_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSettings block(s) allowed")]
    public List<AwsSagemakerSpaceSpaceSettingsBlock>? SpaceSettings
    {
        get => GetProperty<List<AwsSagemakerSpaceSpaceSettingsBlock>>("space_settings");
        set => this.WithProperty("space_settings", value);
    }

    /// <summary>
    /// Block for space_sharing_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpaceSharingSettings block(s) allowed")]
    public List<AwsSagemakerSpaceSpaceSharingSettingsBlock>? SpaceSharingSettings
    {
        get => GetProperty<List<AwsSagemakerSpaceSpaceSharingSettingsBlock>>("space_sharing_settings");
        set => this.WithProperty("space_sharing_settings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The home_efs_file_system_uid attribute.
    /// </summary>
    public TerraformExpression HomeEfsFileSystemUid => this["home_efs_file_system_uid"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
