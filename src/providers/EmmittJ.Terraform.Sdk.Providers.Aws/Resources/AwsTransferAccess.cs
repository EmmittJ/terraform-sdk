using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for home_directory_mappings in .
/// Nesting mode: list
/// </summary>
public class AwsTransferAccessHomeDirectoryMappingsBlock : TerraformBlock
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
public class AwsTransferAccessPosixProfileBlock : TerraformBlock
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
/// Manages a aws_transfer_access resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTransferAccess : TerraformResource
{
    public AwsTransferAccess(string name) : base("aws_transfer_access", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("external_id");
        SetOutput("home_directory");
        SetOutput("home_directory_type");
        SetOutput("id");
        SetOutput("policy");
        SetOutput("region");
        SetOutput("role");
        SetOutput("server_id");
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    public required TerraformProperty<string> ExternalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("external_id");
        set => SetProperty("external_id", value);
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
    public TerraformProperty<string> Role
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
    /// Block for home_directory_mappings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 HomeDirectoryMappings block(s) allowed")]
    public List<AwsTransferAccessHomeDirectoryMappingsBlock>? HomeDirectoryMappings
    {
        set => SetProperty("home_directory_mappings", value);
    }

    /// <summary>
    /// Block for posix_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixProfile block(s) allowed")]
    public List<AwsTransferAccessPosixProfileBlock>? PosixProfile
    {
        set => SetProperty("posix_profile", value);
    }

}
