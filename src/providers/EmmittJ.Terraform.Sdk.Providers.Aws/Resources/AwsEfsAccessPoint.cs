using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for posix_user in .
/// Nesting mode: list
/// </summary>
public class AwsEfsAccessPointPosixUserBlock : TerraformBlock
{
    /// <summary>
    /// The gid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gid is required")]
    public required TerraformProperty<double> Gid
    {
        set => SetProperty("gid", value);
    }

    /// <summary>
    /// The secondary_gids attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? SecondaryGids
    {
        set => SetProperty("secondary_gids", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    public required TerraformProperty<double> Uid
    {
        set => SetProperty("uid", value);
    }

}

/// <summary>
/// Block type for root_directory in .
/// Nesting mode: list
/// </summary>
public class AwsEfsAccessPointRootDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

}

/// <summary>
/// Manages a aws_efs_access_point resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEfsAccessPoint : TerraformResource
{
    public AwsEfsAccessPoint(string name) : base("aws_efs_access_point", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("file_system_arn");
        SetOutput("owner_id");
        SetOutput("file_system_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformProperty<string> FileSystemId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_system_id");
        set => SetProperty("file_system_id", value);
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
    /// Block for posix_user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixUser block(s) allowed")]
    public List<AwsEfsAccessPointPosixUserBlock>? PosixUser
    {
        set => SetProperty("posix_user", value);
    }

    /// <summary>
    /// Block for root_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootDirectory block(s) allowed")]
    public List<AwsEfsAccessPointRootDirectoryBlock>? RootDirectory
    {
        set => SetProperty("root_directory", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The file_system_arn attribute.
    /// </summary>
    public TerraformExpression FileSystemArn => this["file_system_arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
