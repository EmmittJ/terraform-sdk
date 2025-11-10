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
        get => GetRequiredProperty<TerraformProperty<string>>("entry");
        set => WithProperty("entry", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target");
        set => WithProperty("target", value);
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
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    public required TerraformProperty<string> ExternalId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("external_id");
        set => this.WithProperty("external_id", value);
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public TerraformProperty<string>? HomeDirectory
    {
        get => GetProperty<TerraformProperty<string>>("home_directory");
        set => this.WithProperty("home_directory", value);
    }

    /// <summary>
    /// The home_directory_type attribute.
    /// </summary>
    public TerraformProperty<string>? HomeDirectoryType
    {
        get => GetProperty<TerraformProperty<string>>("home_directory_type");
        set => this.WithProperty("home_directory_type", value);
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
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
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
    /// The role attribute.
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
    }

    /// <summary>
    /// Block for home_directory_mappings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 HomeDirectoryMappings block(s) allowed")]
    public List<AwsTransferAccessHomeDirectoryMappingsBlock>? HomeDirectoryMappings
    {
        get => GetProperty<List<AwsTransferAccessHomeDirectoryMappingsBlock>>("home_directory_mappings");
        set => this.WithProperty("home_directory_mappings", value);
    }

    /// <summary>
    /// Block for posix_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixProfile block(s) allowed")]
    public List<AwsTransferAccessPosixProfileBlock>? PosixProfile
    {
        get => GetProperty<List<AwsTransferAccessPosixProfileBlock>>("posix_profile");
        set => this.WithProperty("posix_profile", value);
    }

}
