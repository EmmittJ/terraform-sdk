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
        get => GetRequiredProperty<TerraformProperty<double>>("gid");
        set => WithProperty("gid", value);
    }

    /// <summary>
    /// The secondary_gids attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? SecondaryGids
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("secondary_gids");
        set => WithProperty("secondary_gids", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uid is required")]
    public required TerraformProperty<double> Uid
    {
        get => GetRequiredProperty<TerraformProperty<double>>("uid");
        set => WithProperty("uid", value);
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
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
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
        this.WithOutput("arn");
        this.WithOutput("file_system_arn");
        this.WithOutput("owner_id");
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformProperty<string> FileSystemId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("file_system_id");
        set => this.WithProperty("file_system_id", value);
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
    /// Block for posix_user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixUser block(s) allowed")]
    public List<AwsEfsAccessPointPosixUserBlock>? PosixUser
    {
        get => GetProperty<List<AwsEfsAccessPointPosixUserBlock>>("posix_user");
        set => this.WithProperty("posix_user", value);
    }

    /// <summary>
    /// Block for root_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootDirectory block(s) allowed")]
    public List<AwsEfsAccessPointRootDirectoryBlock>? RootDirectory
    {
        get => GetProperty<List<AwsEfsAccessPointRootDirectoryBlock>>("root_directory");
        set => this.WithProperty("root_directory", value);
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
