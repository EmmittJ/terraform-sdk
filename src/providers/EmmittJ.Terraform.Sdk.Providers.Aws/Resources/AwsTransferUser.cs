using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for home_directory_mappings in .
/// Nesting mode: list
/// </summary>
public class AwsTransferUserHomeDirectoryMappingsBlock : TerraformBlock
{
    /// <summary>
    /// The entry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entry is required")]
    public required TerraformProperty<string> Entry
    {
        set => SetProperty("entry", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        set => SetProperty("target", value);
    }

}

/// <summary>
/// Block type for posix_profile in .
/// Nesting mode: list
/// </summary>
public class AwsTransferUserPosixProfileBlock : TerraformBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsTransferUserTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_transfer_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTransferUser : TerraformResource
{
    public AwsTransferUser(string name) : base("aws_transfer_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("home_directory");
        SetOutput("home_directory_type");
        SetOutput("id");
        SetOutput("policy");
        SetOutput("region");
        SetOutput("role");
        SetOutput("server_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("user_name");
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public TerraformProperty<string> HomeDirectory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("home_directory");
        set => SetProperty("home_directory", value);
    }

    /// <summary>
    /// The home_directory_type attribute.
    /// </summary>
    public TerraformProperty<string> HomeDirectoryType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("home_directory_type");
        set => SetProperty("home_directory_type", value);
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
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
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
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role");
        set => SetProperty("role", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_id");
        set => SetProperty("server_id", value);
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
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// Block for home_directory_mappings.
    /// Nesting mode: list
    /// </summary>
    public List<AwsTransferUserHomeDirectoryMappingsBlock>? HomeDirectoryMappings
    {
        set => SetProperty("home_directory_mappings", value);
    }

    /// <summary>
    /// Block for posix_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixProfile block(s) allowed")]
    public List<AwsTransferUserPosixProfileBlock>? PosixProfile
    {
        set => SetProperty("posix_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsTransferUserTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
